using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectWork.Forms.Tasks {

    public partial class TaskFourForm : Form {

        public TaskFourForm() {
            InitializeComponent();
        }

        private void TaskFourForm_Load(object sender, EventArgs e) {
            UpdateDataGrid();
        }

        private void columnUpDown_ValueChanged(object sender, EventArgs e) {
            UpdateDataGrid();
        }

        private void rowUpDown_ValueChanged(object sender, EventArgs e) {
            UpdateDataGrid();
        }

        private void solve_Click(object sender, EventArgs e) {
            foreach (DataGridViewCell cell in dataGridView1.Rows[0].Cells) {
                if (!int.TryParse(cell.Value.ToString(), out int type) || (type != 0 && type != 1)) {
                    MessageBox.Show(
                        "Неверный режим.", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning
                    );
                    return;
                }
            }

            double[,] table = new double[dataGridView1.Columns.Count, dataGridView1.Rows.Count];
            for (int i = 0; i < dataGridView1.Columns.Count; i++) {
                if (int.Parse(dataGridView1.Rows[0].Cells[i].Value.ToString()) == 1) {
                    double max = double.MinValue;
                    for (int k = 1; k < dataGridView1.Rows.Count; k++) {
                        double value = double.Parse(dataGridView1.Rows[k].Cells[i].Value.ToString());
                        if (value > max) {
                            max = value;
                        }
                    }
                    for (int k = 1; k < dataGridView1.Rows.Count; k++) {
                        table[i, k] = double.Parse(dataGridView1.Rows[k].Cells[i].Value.ToString()) / max;
                    }
                } else {
                    double min = double.MaxValue;
                    for (int k = 1; k < dataGridView1.Rows.Count; k++) {
                        double value = double.Parse(dataGridView1.Rows[k].Cells[i].Value.ToString());
                        if (value < min) {
                            min = value;
                        }
                    }
                    for (int k = 1; k < dataGridView1.Rows.Count; k++) {
                        table[i, k] = min / double.Parse(dataGridView1.Rows[k].Cells[i].Value.ToString());
                    }
                }
            }

            double[] w0 = new double[dataGridView1.Rows.Count - 1];
            double[] w1 = new double[dataGridView1.Rows.Count - 1];
            double[] v0 = new double[dataGridView1.Columns.Count];
            double[] v1 = new double[dataGridView1.Columns.Count];
            for (int i = 0; i < dataGridView1.Columns.Count; i++) {
                v1[i] = 1;
            }
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++) {
                w1[i] = 1;
            }
            for (int q = 0; q <= 7; q++) {
                for (int i = 0; i < dataGridView1.Columns.Count; i++) {
                    v0[i] = v1[i];
                }
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++) {
                    w0[i] = w1[i];
                }
                // Обнуление новых данных
                for (int i = 0; i < dataGridView1.Columns.Count; i++) {
                    v1[i] = 0;
                }
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++) {
                    w1[i] = 0;
                }
                // Заполнение данных версиями
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++) {
                    for (int k = 0; k < dataGridView1.Columns.Count; k++) {
                        w1[i] = w1[i] + v0[k] * table[k, i + 1];
                    }
                }
                double mmax = double.MinValue;
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++) {
                    if (w1[i] > mmax) {
                        mmax = w1[i];
                    }
                }
                for (int k = 0; k < dataGridView1.Rows.Count - 1; k++) {
                    w1[k] = w1[k] / mmax;
                }
                for (int k = 0; k < dataGridView1.Columns.Count; k++) {
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++) {
                        v1[k] = v1[k] + w0[i] * table[k, i + 1];
                    }
                }
                mmax = double.MinValue;
                for (int i = 0; i < dataGridView1.Columns.Count; i++) {
                    if (v1[i] > mmax) {
                        mmax = v1[i];
                    }
                }
                for (int k = 0; k < dataGridView1.Columns.Count; k++) {
                    v1[k] = v1[k] / mmax;
                }
            }
            int[] w1Ranks = w1
                .OrderBy(w => w)
                .Select(w => Array.IndexOf(w1, w) + 1)
                .ToArray();

            StringBuilder result = new StringBuilder("Результат:");
            result.Append("\nМассив W:");
            for (int i = 0; i < w1.Length; i++) {
                result.Append("  ").Append(string.Format("{0:0.####}", w1[i]));
            }
            result.Append("\nРанги: " + string.Join("-", w1Ranks));
            MessageBox.Show(result.ToString());
        }

        private void UpdateDataGrid() {
            while (columnUpDown.Value != dataGridView1.Columns.Count) {
                if (columnUpDown.Value > dataGridView1.Columns.Count) {
                    dataGridView1.Columns.Add(
                        columnUpDown.Value.ToString(),
                        $"Характеристика {dataGridView1.Columns.Count + 1}"
                    );
                } else if (columnUpDown.Value < dataGridView1.Columns.Count) {
                    dataGridView1.Columns.RemoveAt(dataGridView1.Columns.Count - 1);
                }
            }
            while (rowUpDown.Value + 1 != dataGridView1.Rows.Count) {
                if (rowUpDown.Value + 1 > dataGridView1.Rows.Count) {
                    DataGridViewRow row = new DataGridViewRow();
                    if (dataGridView1.Rows.Count != 0) {
                        row.HeaderCell.Value = $"№{dataGridView1.Rows.Count}";
                    } else {
                        row.HeaderCell.Value = "Режим";
                    }
                    dataGridView1.Rows.Add(row);
                } else if (rowUpDown.Value + 1 < dataGridView1.Rows.Count) {
                    dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 1);
                }
            }

            foreach (DataGridViewColumn column in dataGridView1.Columns) {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            int rowHeight = (dataGridView1.Size.Height - dataGridView1.ColumnHeadersHeight) / dataGridView1.Rows.Count;
            if (rowHeight > 0) {
                for (int i = 0; i < dataGridView1.Rows.Count; i++) {
                    dataGridView1.Rows[i].Height = rowHeight;
                }
            }
        }
    }
}
