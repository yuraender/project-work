using ProjectWork.Entities.One;
using ProjectWork.Enums;
using ProjectWork.Utils;
using System;
using System.Linq;
using System.Windows.Forms;
using static ProjectWork.Entities.One.Subsystem;

namespace ProjectWork.Forms.Tasks.One {

    public partial class CombinationEditForm : Form {

        private TaskOneForm _form;
        private Combination _combination;
        private CrudAction _action;

        public CombinationEditForm(TaskOneForm form, Combination combination, CrudAction action) {
            InitializeComponent();
            _form = form;
            _combination = combination;
            _action = action;
        }

        private void CombinationEditForm_Load(object sender, EventArgs e) {
            foreach (BindingEntity<Subsystem> subsystem in _form.Subsystems) {
                fullBox.Items.AddRange(subsystem.Value.Implementations.ToArray());
            }

            if (_action == CrudAction.Create) {
                Text = "Добавить связку";
                createUpdateButton.Text = "Добавить";
            } else {
                Text = "Обновить связку";
                createUpdateButton.Text = "Обновить";
                foreach (Implementation implementation in _combination.Implementations) {
                    fullBox.Items.Remove(implementation);
                }
                requiredBox.Items.AddRange(_combination.Implementations.ToArray());
            }
        }

        private void addButton_Click(object sender, EventArgs e) {
            foreach (int index in fullBox.SelectedIndices) {
                Implementation implementation = (Implementation) fullBox.Items[index];
                foreach (Implementation other in requiredBox.Items) {
                    if (implementation.Owner == other.Owner) {
                        MessageBox.Show(
                            "Нельзя использовать несколько реализаций одной подсистемы.", "",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning
                        );
                        return;
                    }
                }
                requiredBox.Items.Add(implementation);
                fullBox.Items.Remove(implementation);
            }
        }

        private void removeButton_Click(object sender, EventArgs e) {
            foreach (int index in requiredBox.SelectedIndices) {
                fullBox.Items.Add(requiredBox.Items[index]);
                requiredBox.Items.RemoveAt(index);
            }
        }

        private void createUpdateButton_Click(object sender, EventArgs e) {
            if (requiredBox.Items.Count != _form.Subsystems.Count) {
                MessageBox.Show(
                    "Введены неверные данные.", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning
                );
                return;
            }

            if (_action == CrudAction.Create) {
                ((ListBox) _form.Controls["comboBox"]).Items.Add(new Combination {
                    Implementations = requiredBox.Items.Cast<Implementation>().ToList()
                });
            } else if (_action == CrudAction.Update) {
                _combination.Implementations = requiredBox.Items.Cast<Implementation>().ToList();
            }
            Close();
        }
    }
}
