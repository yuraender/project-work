using ProjectWork.Entities.One;
using ProjectWork.Enums;
using ProjectWork.Utils;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjectWork.Forms.Tasks.One {

    public partial class CharacteristicEditForm : Form {

        private SubsystemEditForm _form;
        private BindingEntity<Characteristic> _characteristic;
        private CrudAction _action;

        public CharacteristicEditForm(
            SubsystemEditForm form, BindingEntity<Characteristic> characteristic, CrudAction action
        ) {
            InitializeComponent();
            _form = form;
            _characteristic = characteristic;
            _action = action;
        }

        private void CharacteristicEditForm_Load(object sender, EventArgs e) {
            typeBox.DataSource = Enum.GetValues(typeof(CharacteristicType));
            criteriaBox.DataSource = Enum.GetValues(typeof(CharacteristicCriteria));

            if (_action == CrudAction.Create) {
                Text = "Добавить характеристику";
                createUpdateButton.Text = "Добавить";
            } else {
                Text = "Обновить характеристику";
                createUpdateButton.Text = "Обновить";
                nameBox.Text = _characteristic.Value.Name;
                minBox.Text = _characteristic.Value.Min.ToString();
                maxBox.Text = _characteristic.Value.Max.ToString();
                typeBox.SelectedItem = _characteristic.Value.Type;
                criteriaBox.SelectedItem = _characteristic.Value.Criteria;
            }
        }

        private void createUpdateButton_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(nameBox.Text)
                || !double.TryParse(minBox.Text, out double min)
                || !double.TryParse(maxBox.Text, out double max)
                || typeBox.SelectedIndex < 0
                || criteriaBox.SelectedIndex < 0) {
                MessageBox.Show(
                    "Введены неверные данные.", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning
                );
                return;
            }

            Characteristic characteristic = new Characteristic {
                Name = nameBox.Text,
                Min = min,
                Max = max,
                Type = (CharacteristicType) typeBox.SelectedItem,
                Criteria = (CharacteristicCriteria) criteriaBox.SelectedItem
            };
            if (_action == CrudAction.Create) {
                if (_form.Characteristics.Any(c => c.Value.Name == characteristic.Name)) {
                    MessageBox.Show(
                        "Характеристика с таким названием уже существует.", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning
                    );
                    return;
                }
                _form.Characteristics.Add(new BindingEntity<Characteristic> {
                    Value = characteristic
                });
            } else if (_action == CrudAction.Update) {
                _characteristic.Value = characteristic;
            }
            Close();
        }
    }
}
