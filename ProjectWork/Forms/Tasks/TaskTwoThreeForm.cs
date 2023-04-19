using MathNet.Numerics.Distributions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectWork.Forms.Tasks {

    public partial class TaskTwoThreeForm : Form {

        public TaskTwoThreeForm() {
            InitializeComponent();
            updateDataGrid();
        }

        private void expertUpDown_ValueChanged(object sender, EventArgs e) {
            updateDataGrid();
        }

        private void versionUpDown_ValueChanged(object sender, EventArgs e) {
            updateDataGrid();
        }

        private void solveButton_Click(object sender, EventArgs e) {
            int experts = dataGridView.Columns.Count;
            int versions = dataGridView.Rows.Count;

            int minVersionSum = 0;
            double minVersionSumValue = double.MaxValue;
            double[] versionSums = new double[versions];
            double rAvg = 0;
            foreach (DataGridViewRow row in dataGridView.Rows) {
                double versionSum = 0;
                foreach (DataGridViewCell cell in row.Cells) {
                    try {
                        versionSum += double.Parse(cell.Value.ToString());
                    } catch {
                        MessageBox.Show("Некорректные данные.");
                        return;
                    }
                }
                if (versionSum < minVersionSumValue) {
                    minVersionSum = row.Index;
                    minVersionSumValue = versionSum;
                }
                versionSums[row.Index] = versionSum;
                rAvg += versionSum / versions;
            }

            double s = 0;
            foreach (double sum in versionSums) {
                s += Math.Pow(sum - rAvg, 2);
            }

            double w;
            if (!linkedBox.Checked) {
                w = 12 / (Math.Pow(experts, 2) * (Math.Pow(versions, 3) - versions)) * s;
            } else {
                double t = 0;
                for (int i = 0; i < experts; i++) {
                    Dictionary<double, int> linked = new Dictionary<double, int>();
                    foreach (DataGridViewRow row in dataGridView.Rows) {
                        double value = double.Parse(row.Cells[i].Value.ToString());
                        if (linked.ContainsKey(value)) {
                            linked[value]++;
                        } else {
                            linked.Add(value, 1);
                        }
                    }
                    linked.Where(pair => pair.Value > 1)
                        .ToList()
                        .ForEach(pair => {
                            t += Math.Pow(pair.Value, 3) - pair.Value;
                        });
                }
                w = 12 / (Math.Pow(experts, 2) * (Math.Pow(versions, 3) - versions) - experts * t) * s;
            }

            double chiCalculated = experts * (versions - 1) * w;
            double chi = ChiSquared.InvCDF(versions - 1, 1 - (double) significanceUpDown.Value);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Конкордация {(chiCalculated >= chi ? "значима" : "незначима")}");
            sb.AppendLine("Согласованность: " + w);
            sb.Append("Наиболее вероятная версия: " + (minVersionSum + 1));
            MessageBox.Show(sb.ToString());
        }

        private void updateDataGrid() {
            while (expertUpDown.Value != dataGridView.Columns.Count) {
                if (expertUpDown.Value > dataGridView.Columns.Count) {
                    dataGridView.Columns.Add(
                        expertUpDown.Value.ToString(),
                        $"Эксперт {dataGridView.Columns.Count + 1}"
                    );
                } else if (expertUpDown.Value < dataGridView.Columns.Count) {
                    dataGridView.Columns.RemoveAt(dataGridView.Columns.Count - 1);
                }
            }
            while (versionUpDown.Value != dataGridView.Rows.Count) {
                if (versionUpDown.Value > dataGridView.Rows.Count) {
                    DataGridViewRow row = new DataGridViewRow();
                    row.HeaderCell.Value = $"№{dataGridView.Rows.Count + 1}";
                    dataGridView.Rows.Add(row);
                } else if (versionUpDown.Value < dataGridView.Rows.Count) {
                    dataGridView.Rows.RemoveAt(dataGridView.Rows.Count - 1);
                }
            }
            int rowHeight = (dataGridView.Size.Height - dataGridView.ColumnHeadersHeight) / dataGridView.Rows.Count;
            if (rowHeight > 0) {
                for (int i = 0; i < dataGridView.Rows.Count; i++) {
                    dataGridView.Rows[i].Height = rowHeight;
                }
            }
        }
    }
}
