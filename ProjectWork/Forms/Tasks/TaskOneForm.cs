using Newtonsoft.Json;
using ProjectWork.Entities.One;
using ProjectWork.Enums;
using ProjectWork.Forms.Tasks.One;
using ProjectWork.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace ProjectWork.Forms.Tasks {

    public partial class TaskOneForm : Form {

        public BindingList<BindingEntity<Subsystem>> Subsystems {
            get; private set;
        }

        public TaskOneForm() {
            InitializeComponent();
        }

        private void TaskOneForm_Load(object sender, EventArgs e) {
            Subsystems = new BindingList<BindingEntity<Subsystem>>();
            Subsystems.ListChanged += Subsystems_ListChanged;
            subsystemBox.DataSource = Subsystems;
        }

        private void Subsystems_ListChanged(object sender, ListChangedEventArgs e) {
            subsystemEditButton.Enabled = Subsystems.Count != 0;
            subsystemDeleteButton.Enabled = Subsystems.Count != 0;
            comboBox.Items.Clear();
            comboAddButton.Enabled = Subsystems.Count != 0
                && Subsystems.All(be => be.Value.Implementations.Count != 0);
        }

        private void subsystemAddButton_Click(object sender, EventArgs e) {
            new SubsystemEditForm(this, null, CrudAction.Create).ShowDialog();
        }

        private void subsystemEditButton_Click(object sender, EventArgs e) {
            BindingEntity<Subsystem> be = (BindingEntity<Subsystem>) subsystemBox.SelectedItem;
            if (be == null) {
                return;
            }
            new SubsystemEditForm(this, be, CrudAction.Update).ShowDialog();
        }

        private void subsystemDeleteButton_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show(
                "Вы действительно хотите удалить запись?", "Подтверждение",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2
            );
            if (result != DialogResult.OK) {
                return;
            }
            Subsystems.Remove((BindingEntity<Subsystem>) subsystemBox.SelectedItem);
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e) {
            comboEditButton.Enabled = comboBox.SelectedIndex != -1;
            comboDeleteButton.Enabled = comboBox.SelectedIndex != -1;
        }

        private void comboAddButton_Click(object sender, EventArgs e) {
            new CombinationEditForm(this, null, CrudAction.Create).ShowDialog();
        }

        private void comboEditButton_Click(object sender, EventArgs e) {
            Combination combination = (Combination) comboBox.SelectedItem;
            if (combination == null) {
                return;
            }
            new CombinationEditForm(this, combination, CrudAction.Update).ShowDialog();
        }

        private void comboDeleteButton_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show(
                "Вы действительно хотите удалить запись?", "Подтверждение",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2
            );
            if (result != DialogResult.OK) {
                return;
            }
            comboBox.Items.Remove(comboBox.SelectedItem);
        }

        private void solveButton_Click(object sender, EventArgs e) {
            if (comboBox.Items.Count == 0) {
                MessageBox.Show(
                    "Нет связок.", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning
                );
                return;
            }

            List<Combination> combinations = comboBox.Items
                .Cast<Combination>()
                .Where(c => c.IsValid())
                .ToList();
            if (combinations.Count != 0) {
                Combination bestCombination = combinations
                   .OrderByDescending(c => c.Calculate()
                       .Where(p => p.Key.Criteria == CharacteristicCriteria.Max)
                       .All(p => p.Value == combinations.Max(c1 => c1.Calculate()[p.Key]))
                   )
                   .FirstOrDefault();
                MessageBox.Show("Лучшая связка:\n\n"
                    + JsonConvert.SerializeObject(bestCombination.Calculate(), Formatting.Indented)
                );
            } else {
                MessageBox.Show("Ни одна из связок не удовлетворяет условие.");
            }
        }
    }
}
