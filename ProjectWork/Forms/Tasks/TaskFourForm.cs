using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWork.Forms.Tasks
{
    public partial class TaskFourForm : Form
    {
        public TaskFourForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void columnCount_TextChanged(object sender, EventArgs e)
        {
            UpdateDataGrid();
            /*
            // проверка на целое число
            if (!int.TryParse(columnCount.Text, out int columns))
            {
                MessageBox.Show("Введите целое число");
                return;
            }
            // добавление одного столбца
            dataGridView1.Columns.Add("col", "something");
            */
        }

        private void UpdateDataGrid()
        {
            if (!int.TryParse(columnCount.Text, out int columns))
            {
                MessageBox.Show("Введите целое число");
                return;
            }
            while (columns != dataGridView1.Columns.Count)
            {
                if (columns > dataGridView1.Columns.Count)
                {
                    dataGridView1.Columns.Add(
                        columns.ToString(),
                        $"Характеристика {dataGridView1.Columns.Count + 1}"
                    );
                }
                else if (columns < dataGridView1.Columns.Count)
                {
                    dataGridView1.Columns.RemoveAt(dataGridView1.Columns.Count - 1);
                }
            }
            if (!int.TryParse(rowCount.Text, out int rows) && rows <1)
            {
                MessageBox.Show("Введите целое число");
                return;
            }
            while (rows + 1 != dataGridView1.Rows.Count  )
            {
                if (rows + 1> dataGridView1.Rows.Count)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.HeaderCell.Value = $"№{dataGridView1.Rows.Count + 1}";
                    dataGridView1.Rows.Add(row);
                }
                else if (rows + 1 < dataGridView1.Rows.Count)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 1);
                }
            }

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            int rowHeight = (dataGridView1.Size.Height - dataGridView1.ColumnHeadersHeight) / dataGridView1.Rows.Count;
            if (rowHeight > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Height = rowHeight;
                }
            }
        }

        private void rowCount_TextChanged(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        private void solve_Click(object sender, EventArgs e)
        {
            double[ , ] table = new double[dataGridView1.Columns.Count, dataGridView1.Rows.Count];
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (int.Parse(dataGridView1.Rows[0].Cells[i].Value.ToString()) == 1)
                {
                    double max = double.MinValue;
                    for (int k = 1; k < dataGridView1.Rows.Count; k++)
                    {
                        double value = double.Parse(dataGridView1.Rows[k].Cells[i].Value.ToString());
                        if (value > max)
                        {
                            max = value;
                        }
                    }
                    for (int k = 1; k < dataGridView1.Rows.Count; k++)
                    {
                        table[i, k] = double.Parse(dataGridView1.Rows[k].Cells[i].Value.ToString()) / max;
 //                       MessageBox.Show(table[i, k].ToString());
                    }
                }
                else
                {
                    double min = double.MaxValue;
                    for (int k = 1; k < dataGridView1.Rows.Count; k++)
                    {
                        double value = double.Parse(dataGridView1.Rows[k].Cells[i].Value.ToString());
                        if (value < min)
                        {
                            min = value;
                        }
                    }
                    for (int k = 1; k < dataGridView1.Rows.Count; k++)
                    {
                        table[i, k] = min / double.Parse(dataGridView1.Rows[k].Cells[i].Value.ToString());
 //                       MessageBox.Show(table[i, k].ToString());
                    }
                }
            }
            
            double [] w0 = new double [dataGridView1.Rows.Count - 1];
            double[] w1 = new double[dataGridView1.Rows.Count - 1];
            double[] v0 = new double[dataGridView1.Columns.Count];
            double[] v1 = new double[dataGridView1.Columns.Count];
            for (int i = 0; i < dataGridView1.Columns.Count;i++)
            {
                v0[i] = 1;
            }
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                w0[i] = 1;
            }
            //
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                v1[i] = 0;
            }
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                w1[i] = 0;
            }
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for(int k = 0; k < dataGridView1.Columns.Count; k++)
                {
                    w1[i] = w1[i] + v0[k] * table[k ,i+1];
                }
            }
            double mmax = double.MinValue;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (w1[i] > mmax)
                {
                    mmax = w1[i];
                }
            }
            for (int k = 0; k < dataGridView1.Rows.Count - 1; k++)
            {
                w1[k] = w1[k] / mmax;
                MessageBox.Show(w1[k].ToString());
            }
        }

        private void TaskFourForm_Load(object sender, EventArgs e)
        {

        }
    }
}
