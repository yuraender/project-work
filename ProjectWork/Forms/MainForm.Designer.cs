namespace ProjectWork.Forms {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.taskOneButton = new System.Windows.Forms.Button();
            this.taskTwoThreeButton = new System.Windows.Forms.Button();
            this.taskFourButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // taskOneButton
            // 
            this.taskOneButton.Location = new System.Drawing.Point(12, 12);
            this.taskOneButton.Name = "taskOneButton";
            this.taskOneButton.Size = new System.Drawing.Size(141, 53);
            this.taskOneButton.TabIndex = 0;
            this.taskOneButton.Text = "Структурный синтез систем";
            this.taskOneButton.UseVisualStyleBackColor = true;
            this.taskOneButton.Click += new System.EventHandler(this.taskOneButton_Click);
            // 
            // taskTwoThreeButton
            // 
            this.taskTwoThreeButton.Location = new System.Drawing.Point(159, 12);
            this.taskTwoThreeButton.Name = "taskTwoThreeButton";
            this.taskTwoThreeButton.Size = new System.Drawing.Size(141, 53);
            this.taskTwoThreeButton.TabIndex = 1;
            this.taskTwoThreeButton.Text = "Метод экспертной оценки";
            this.taskTwoThreeButton.UseVisualStyleBackColor = true;
            this.taskTwoThreeButton.Click += new System.EventHandler(this.taskTwoThreeButton_Click);
            // 
            // taskFourButton
            // 
            this.taskFourButton.Location = new System.Drawing.Point(305, 12);
            this.taskFourButton.Name = "taskFourButton";
            this.taskFourButton.Size = new System.Drawing.Size(141, 53);
            this.taskFourButton.TabIndex = 2;
            this.taskFourButton.Text = "Метод спектрального анализа";
            this.taskFourButton.UseVisualStyleBackColor = true;
            this.taskFourButton.Click += new System.EventHandler(this.taskFourButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.taskFourButton);
            this.Controls.Add(this.taskTwoThreeButton);
            this.Controls.Add(this.taskOneButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Проектная деятельность";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button taskOneButton;
        private System.Windows.Forms.Button taskTwoThreeButton;
        private System.Windows.Forms.Button taskFourButton;
    }
}
