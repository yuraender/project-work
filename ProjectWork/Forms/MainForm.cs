﻿using ProjectWork.Forms.Tasks;
using System;
using System.Windows.Forms;

namespace ProjectWork.Forms {

    public partial class MainForm : Form {

        public MainForm() {
            InitializeComponent();
        }

        private void taskOneButton_Click(object sender, EventArgs e) {
            new TaskOneForm().ShowDialog();
        }

        private void taskTwoThreeButton_Click(object sender, EventArgs e) {
            new TaskTwoThreeForm().ShowDialog();
        }

        private void taskFourButton_Click(object sender, EventArgs e) {
            new TaskFourForm().ShowDialog();
        }

        private void taskFiveButton_Click(object sender, EventArgs e) {
            new TaskFiveForm().ShowDialog();
        }

        private void taskSixButton_Click(object sender, EventArgs e) {
            new TaskSixForm().ShowDialog();
        }

        private void taskSevenButton_Click(object sender, EventArgs e) {
            new TaskSevenForm().ShowDialog();
        }
    }
}
