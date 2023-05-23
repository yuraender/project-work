using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProjectWork.Forms.Tasks {

    public partial class TaskSevenForm : Form {

        private List<Arc> _arcs = new List<Arc>();

        public TaskSevenForm() {
            InitializeComponent();
        }

        private void TaskSevenForm_Load(object sender, EventArgs e) {
            CreateDataGrid();
        }

        private void button1_Click(object sender, EventArgs e) {
            FillArcs();
            if (!AreArcsEmpty()) {
                float[] expectedValues = {
                    CalculateFirstWay(),
                    CalculateSecondWay(),
                    CalculateThirdWay(),
                    CalculateFourthWay(),
                };
                label1.Text = $"Путь 1: {expectedValues[0]}";
                label2.Text = $"Путь 2: {expectedValues[1]}";
                label3.Text = $"Путь 3: {expectedValues[2]}";
                label4.Text = $"Путь 4: {expectedValues[3]}";
                label5.Text = $"Критический путь: {expectedValues.Max()}";
            }
        }

        private void FillArcs() {
            _arcs.Clear();
            if (!AreArcsEmpty()) {
                for (int i = 0; i < dataGridView1.Rows.Count; i++) {
                    float min = float.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                    float max = float.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                    dataGridView1.Rows[i].Cells[2].Value = CalculateExpectedValue(min, max).ToString();
                    _arcs.Add(new Arc(min, max));
                }
            } else {
                MessageBox.Show("Таблица не содержит данных.");
            }
        }

        private bool AreArcsEmpty() {
            for (int i = 0; i < dataGridView1.Rows.Count; i++) {
                if (dataGridView1.Rows[i].Cells[0].Value == null
                    || dataGridView1.Rows[i].Cells[1].Value == null) {
                    return true;
                }
            }
            return false;
        }

        private float CalculateExpectedValue(float min, float max) {
            return (3 * min + 2 * max) / 5;
        }

        private float CalculateFirstWay() {
            //0-1-3-6
            return CalculateExpectedValue(_arcs[0].Min, _arcs[0].Max)
                + CalculateExpectedValue(_arcs[2].Min, _arcs[2].Max)
                + CalculateExpectedValue(_arcs[6].Min, _arcs[6].Max);
        }

        private float CalculateSecondWay() {
            //0-1-3-4-6
            return CalculateExpectedValue(_arcs[0].Min, _arcs[0].Max)
                + CalculateExpectedValue(_arcs[2].Min, _arcs[2].Max)
                + 0
                + CalculateExpectedValue(_arcs[8].Min, _arcs[8].Max);
        }

        private float CalculateThirdWay() {
            //0-2-4-6
            return CalculateExpectedValue(_arcs[1].Min, _arcs[1].Max)
                + CalculateExpectedValue(_arcs[4].Min, _arcs[4].Max)
                + CalculateExpectedValue(_arcs[8].Min, _arcs[8].Max);
        }

        private float CalculateFourthWay() {
            //0-2-3-4-6
            return CalculateExpectedValue(_arcs[1].Min, _arcs[1].Max)
                + CalculateExpectedValue(_arcs[3].Min, _arcs[3].Max)
                + 0
                + CalculateExpectedValue(_arcs[8].Min, _arcs[8].Max);
        }

        private void CreateDataGrid() {
            string[] ways = { "0-1", "0-2", "1-3", "2-3", "2-4", "3-4", "3-5", "3-6", "4-5", "4-6" };
            foreach (string way in ways) {
                DataGridViewRow row = new DataGridViewRow();
                row.HeaderCell.Value = way;
                if (way == "3-4") {
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                    row.ReadOnly = true;
                }
                dataGridView1.Rows.Add(row);
            }
            dataGridView1.Rows[5].Cells[0].Value = 0;
            dataGridView1.Rows[5].Cells[1].Value = 0;

            foreach (DataGridViewColumn column in dataGridView1.Columns) {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            int rowHeight = (dataGridView1.Size.Height - dataGridView1.ColumnHeadersHeight)
                / dataGridView1.Rows.Count;
            if (rowHeight > 0) {
                for (int i = 0; i < dataGridView1.Rows.Count; i++) {
                    dataGridView1.Rows[i].Height = rowHeight;
                }
            }
        }
    }

    public class Arc {

        public float Min {
            get; private set;
        }
        public float Max {
            get; private set;
        }

        public Arc(float min, float max) {
            Min = min;
            Max = max;
        }
    }
}
