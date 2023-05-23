using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProjectWork.Forms.Tasks {

    public partial class TaskSixForm : Form {

        private int _scaleX = 6, _scaleY = 8;

        public TaskSixForm() {
            InitializeComponent();
        }

        private void TaskSixForm_Load(object sender, EventArgs e) {
            comboBox1.SelectedIndex = comboBox2.SelectedIndex = 0;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            comboBox1.Enabled = checkBox1.Checked;
            textBox1.Enabled = checkBox1.Checked;
            checkBox2.Enabled = !checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) {
            comboBox2.Enabled = checkBox2.Checked;
            textBox2.Enabled = checkBox2.Checked;
            checkBox1.Enabled = !checkBox2.Checked;
        }

        private void button3_Click(object sender, EventArgs e) {
            double x2;
            try {
                if (textBox1.Enabled) {
                    double.Parse(textBox1.Text);
                }
                x2 = textBox2.Enabled
                    ? double.Parse(textBox2.Text)
                    : 2;
            } catch {
                MessageBox.Show(
                    "Введены неверные данные.", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning
                );
                return;
            }

            double maxZ = double.MinValue;
            double x = 0, y = 0;
            for (double x1 = 0; x1 <= _scaleX; x1 += 0.01) {
                for (
                    double i = comboBox2.SelectedIndex == 0 ? 0 : x2;
                    i <= (comboBox2.SelectedIndex == 0 ? x2 : _scaleY);
                    i += 0.01
                ) {
                    double totalZ = TotalZ(x1, i);
                    if (totalZ >= maxZ) {
                        x = x1;
                        y = i;
                        maxZ = totalZ;
                    }
                }
            }
            if (maxZ != -1) {
                CreateChart(x, y);
                MessageBox.Show(
                    $"Z = {string.Format("{0:0.##}\n", maxZ)}"
                    + $"Оптимум: ({string.Format("{0:0.##}", x)}, {string.Format("{0:0.##}", y)})"
                );
            } else {
                MessageBox.Show("Решения не существует.");
            }
        }

        private void CreateChart(double x, double y) {
            chart1.Series.Clear();
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = _scaleX + 1;
            chart1.ChartAreas[0].AxisY.Maximum = _scaleY + 1;

            // Condition 1: x2 = 0.5 * (6 - x1)
            chart1.Series.Add("1");
            chart1.Series["1"].BorderWidth = 3;
            chart1.Series["1"].ChartType = SeriesChartType.Line;
            for (int i = 0; i <= 8; i++) {
                chart1.Series["1"].Points.AddXY(i, 0.5 * (6 - i));
            }

            // Condition 2: x2 = 8 - 2 * x1
            chart1.Series.Add("2");
            chart1.Series["2"].BorderWidth = 3;
            chart1.Series["2"].ChartType = SeriesChartType.Line;
            for (int i = 0; i <= 8; i++) {
                chart1.Series["2"].Points.AddXY(i, 8 - 2 * i);
            }

            // Condition 3: x2 = 1 + x1
            chart1.Series.Add("3");
            chart1.Series["3"].BorderWidth = 3;
            chart1.Series["3"].ChartType = SeriesChartType.Line;
            for (int i = 0; i <= 8; i++) {
                if (textBox1.Enabled) {
                    chart1.Series["3"].Points.AddXY(i, i + double.Parse(textBox1.Text));
                } else {
                    chart1.Series["3"].Points.AddXY(i, i + 1);
                }
            }

            // Condition 4: x2 = 2
            chart1.Series.Add("4");
            chart1.Series["4"].BorderWidth = 3;
            chart1.Series["4"].ChartType = SeriesChartType.Line;
            for (int i = 0; i <= 8; i++) {
                if (textBox2.Enabled) {
                    chart1.Series["4"].Points.AddXY(i, double.Parse(textBox2.Text));
                } else {
                    chart1.Series["4"].Points.AddXY(i, 2);
                }
            }

            // Condition 5: x1 = 0
            chart1.Series.Add("5");
            chart1.Series["5"].BorderWidth = 3;
            chart1.Series["5"].ChartType = SeriesChartType.Line;
            for (int i = 0; i <= 8; i++) {
                chart1.Series["5"].Points.AddXY(0, i);
            }

            // Condition 6: x2 = 0
            chart1.Series.Add("6");
            chart1.Series["6"].BorderWidth = 3;
            chart1.Series["6"].ChartType = SeriesChartType.Line;
            for (int i = 0; i <= 8; ++i) {
                chart1.Series["6"].Points.AddXY(i, 0);
            }

            // Optimum point
            chart1.Series.Add("O");
            chart1.Series["O"].MarkerStyle = MarkerStyle.Circle;
            chart1.Series["O"].MarkerSize = 10;
            chart1.Series["O"].ChartType = SeriesChartType.Point;
            chart1.Series["O"].Color = Color.Red;
            chart1.Series["O"].Points.Add(new DataPoint(x, y));
        }

        private bool IsProductionVolumeValid(double x1, double x2) {
            return x1 + 2 * x2 <= 6 && 2 * x1 + x2 <= 8;
        }

        private bool IsRequestValid(double x1, double x2) {
            double diffHB = 1;
            double B = 2;

            if (checkBox1.Checked) {
                diffHB = double.Parse(textBox1.Text);
            }
            if (checkBox2.Checked) {
                B = double.Parse(textBox2.Text);
            }

            if (checkBox1.Checked && comboBox1.SelectedIndex == 1) {
                return -x1 + x2 >= diffHB && x2 <= B;
            }
            if (checkBox2.Checked && comboBox2.SelectedIndex == 1) {
                return -x1 + x2 <= diffHB && x2 >= B;
            }
            return -x1 + x2 <= diffHB && x2 <= B;
        }

        private double TotalZ(double x1, double x2) {
            return IsProductionVolumeValid(x1, x2) && IsRequestValid(x1, x2)
                ? 3 * x1 + 2 * x2
                : -1;
        }
    }
}
