using ProjectWork.Entities.One;
using ProjectWork.Enums;
using ProjectWork.Utils;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using static ProjectWork.Entities.One.Subsystem;

namespace ProjectWork.Forms.Tasks.One {

    public partial class SubsystemEditForm : Form {

        private TaskOneForm _form;
        public BindingEntity<Subsystem> _subsystem;
        private CrudAction _action;

        public BindingList<BindingEntity<Characteristic>> Characteristics {
            get; private set;
        }
        public BindingList<BindingEntity<Implementation>> Implementations {
            get; private set;
        }

        public SubsystemEditForm(TaskOneForm form, BindingEntity<Subsystem> subsystem, CrudAction action) {
            InitializeComponent();
            _form = form;
            _subsystem = subsystem;
            _action = action;
        }

        private void SubsystemEditForm_Load(object sender, EventArgs e) {
            Characteristics = new BindingList<BindingEntity<Characteristic>>();
            Characteristics.ListChanged += Characteristics_ListChanged;
            characteristicBox.DataSource = Characteristics;
            Implementations = new BindingList<BindingEntity<Implementation>>();
            Implementations.ListChanged += Implementations_ListChanged;
            implementationBox.DataSource = Implementations;

            if (_action == CrudAction.Create) {
                Text = "Добавить подсистему";
                createUpdateButton.Text = "Добавить";
            } else {
                Text = "Обновить подсистему";
                createUpdateButton.Text = "Обновить";
                nameBox.Text = _subsystem.Value.Name;
                foreach (Characteristic characteristic in _subsystem.Value.Characteristics) {
                    Characteristics.Add(new BindingEntity<Characteristic> {
                        Value = characteristic
                    });
                }
                foreach (Implementation implementation in _subsystem.Value.Implementations) {
                    Implementations.Add(new BindingEntity<Implementation> {
                        Value = implementation
                    });
                }
            }
        }

        private void Characteristics_ListChanged(object sender, ListChangedEventArgs e) {
            characteristicEditButton.Enabled = Characteristics.Count != 0;
            characteristicDeleteButton.Enabled = Characteristics.Count != 0;
            Implementations.Clear();
            implementationAddButton.Enabled = Characteristics.Count != 0;
        }

        private void characteristicAddButton_Click(object sender, EventArgs e) {
            new CharacteristicEditForm(this, null, CrudAction.Create).ShowDialog();
        }

        private void characteristicEditButton_Click(object sender, EventArgs e) {
            BindingEntity<Characteristic> be = (BindingEntity<Characteristic>) characteristicBox.SelectedItem;
            if (be == null) {
                return;
            }
            new CharacteristicEditForm(this, be, CrudAction.Update).ShowDialog();
        }

        private void characteristicDeleteButton_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show(
                "Вы действительно хотите удалить запись?", "Подтверждение",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2
            );
            if (result != DialogResult.OK) {
                return;
            }
            Characteristics.Remove((BindingEntity<Characteristic>) characteristicBox.SelectedItem);
        }

        private void Implementations_ListChanged(object sender, ListChangedEventArgs e) {
            implementationEditButton.Enabled = Implementations.Count != 0;
            implementationDeleteButton.Enabled = Implementations.Count != 0;
        }

        private void implementationAddButton_Click(object sender, EventArgs e) {
            new ImplementationEditForm(this, null, CrudAction.Create).ShowDialog();
        }

        private void implementationEditButton_Click(object sender, EventArgs e) {
            BindingEntity<Implementation> be = (BindingEntity<Implementation>) implementationBox.SelectedItem;
            if (be == null) {
                return;
            }
            new ImplementationEditForm(this, be, CrudAction.Update).ShowDialog();
        }

        private void implementationDeleteButton_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show(
                "Вы действительно хотите удалить запись?", "Подтверждение",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2
            );
            if (result != DialogResult.OK) {
                return;
            }
            Implementations.Remove((BindingEntity<Implementation>) implementationBox.SelectedItem);
        }

        private void createUpdateButton_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(nameBox.Text) || characteristicBox.Items.Count == 0) {
                MessageBox.Show(
                    "Введены неверные данные.", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning
                );
                return;
            }

            Subsystem subsystem = new Subsystem {
                Name = nameBox.Text,
                Characteristics = Characteristics.Select(c => c.Value).ToList(),
                Implementations = Implementations.Select(i => i.Value).ToList()
            };
            foreach (Implementation implementation in subsystem.Implementations) {
                implementation.Owner = subsystem;
            }
            if (_action == CrudAction.Create) {
                _form.Subsystems.Add(new BindingEntity<Subsystem> {
                    Value = subsystem
                });
            } else if (_action == CrudAction.Update) {
                _subsystem.Value = subsystem;
            }
            Close();
        }
    }
}
