using ProjectWork.Entities.One;
using ProjectWork.Enums;
using ProjectWork.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static ProjectWork.Entities.One.Subsystem;

namespace ProjectWork.Forms.Tasks.One {

    public partial class ImplementationEditForm : Form {

        private SubsystemEditForm _form;
        private BindingEntity<Implementation> _implementation;
        private CrudAction _action;

        public ImplementationEditForm(
            SubsystemEditForm form,
            BindingEntity<Implementation> implementation,
            CrudAction action
        ) {
            InitializeComponent();
            _form = form;
            _implementation = implementation;
            _action = action;
        }

        private void ImplementationEditForm_Load(object sender, EventArgs e) {
            dataGridView.Columns.Add("valueColumn", "Значение");
            while (dataGridView.Rows.Count != _form.Characteristics.Count) {
                DataGridViewRow row = new DataGridViewRow();
                row.HeaderCell.Value = _form.Characteristics[dataGridView.Rows.Count].Value.Name;
                dataGridView.Rows.Add(row);
            }
            foreach (DataGridViewColumn column in dataGridView.Columns) {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            if (_action == CrudAction.Create) {
                Text = "Добавить реализацию";
                createUpdateButton.Text = "Добавить";
            } else {
                Text = "Обновить реализацию";
                createUpdateButton.Text = "Обновить";
                for (int i = 0; i < _form.Characteristics.Count; i++) {
                    dataGridView.Rows[i].Cells[0].Value
                        = _implementation.Value.Values[_form.Characteristics[i].Value];
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e) {
            Dictionary<Characteristic, double> values = new Dictionary<Characteristic, double>();
            foreach (DataGridViewRow row in dataGridView.Rows) {
                if (row.Cells[0].Value == null
                    || !double.TryParse(row.Cells[0].Value.ToString(), out double value)
                ) {
                    MessageBox.Show(
                        "Введены неверные данные.", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning
                    );
                    return;
                }
                values.Add(_form.Characteristics[row.Index].Value, value);
            }

            Implementation implementation = new Implementation {
                Values = values
            };
            if (_action == CrudAction.Create) {
                _form.Implementations.Add(new BindingEntity<Implementation> {
                    Value = implementation
                });
            } else if (_action == CrudAction.Update) {
                _implementation.Value = implementation;
            }
            Close();
        }
    }
}
