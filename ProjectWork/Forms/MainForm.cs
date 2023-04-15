using ProjectWork.Forms.Tasks;
using System.Windows.Forms;

namespace ProjectWork.Forms {

    public partial class MainForm : Form {

        public MainForm() {
            InitializeComponent();
        }

        private void taskOneButton_Click(object sender, System.EventArgs e) {

        }

        private void taskTwoThreeButton_Click(object sender, System.EventArgs e) {
            new TaskTwoThreeForm().ShowDialog();
        }
    }
}
