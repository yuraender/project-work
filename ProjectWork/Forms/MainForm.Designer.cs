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
            this.taskFiveButton = new System.Windows.Forms.Button();
            this.taskSixButton = new System.Windows.Forms.Button();
            this.taskSevenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // taskOneButton
            // 
            this.taskOneButton.Location = new System.Drawing.Point(82, 12);
            this.taskOneButton.Name = "taskOneButton";
            this.taskOneButton.Size = new System.Drawing.Size(170, 53);
            this.taskOneButton.TabIndex = 0;
            this.taskOneButton.Text = "Структурный синтез систем";
            this.taskOneButton.UseVisualStyleBackColor = true;
            this.taskOneButton.Click += new System.EventHandler(this.taskOneButton_Click);
            // 
            // taskTwoThreeButton
            // 
            this.taskTwoThreeButton.Location = new System.Drawing.Point(82, 71);
            this.taskTwoThreeButton.Name = "taskTwoThreeButton";
            this.taskTwoThreeButton.Size = new System.Drawing.Size(170, 53);
            this.taskTwoThreeButton.TabIndex = 1;
            this.taskTwoThreeButton.Text = "Прогнозирование развития ТС методом экспертной оценки";
            this.taskTwoThreeButton.UseVisualStyleBackColor = true;
            this.taskTwoThreeButton.Click += new System.EventHandler(this.taskTwoThreeButton_Click);
            // 
            // taskFourButton
            // 
            this.taskFourButton.Location = new System.Drawing.Point(82, 130);
            this.taskFourButton.Name = "taskFourButton";
            this.taskFourButton.Size = new System.Drawing.Size(170, 53);
            this.taskFourButton.TabIndex = 2;
            this.taskFourButton.Text = "Сравнение предпочтительных вариантов ТС методом спектрального анализа";
            this.taskFourButton.UseVisualStyleBackColor = true;
            this.taskFourButton.Click += new System.EventHandler(this.taskFourButton_Click);
            // 
            // taskFiveButton
            // 
            this.taskFiveButton.Location = new System.Drawing.Point(82, 189);
            this.taskFiveButton.Name = "taskFiveButton";
            this.taskFiveButton.Size = new System.Drawing.Size(170, 53);
            this.taskFiveButton.TabIndex = 3;
            this.taskFiveButton.Text = "Сравнительная оценка вариантов построения ТС учитывая энтропию";
            this.taskFiveButton.UseVisualStyleBackColor = true;
            this.taskFiveButton.Click += new System.EventHandler(this.taskFiveButton_Click);
            // 
            // taskSixButton
            // 
            this.taskSixButton.Location = new System.Drawing.Point(82, 248);
            this.taskSixButton.Name = "taskSixButton";
            this.taskSixButton.Size = new System.Drawing.Size(170, 53);
            this.taskSixButton.TabIndex = 4;
            this.taskSixButton.Text = "Задача планирования производства";
            this.taskSixButton.UseVisualStyleBackColor = true;
            this.taskSixButton.Click += new System.EventHandler(this.taskSixButton_Click);
            // 
            // taskSevenButton
            // 
            this.taskSevenButton.Location = new System.Drawing.Point(82, 307);
            this.taskSevenButton.Name = "taskSevenButton";
            this.taskSevenButton.Size = new System.Drawing.Size(170, 53);
            this.taskSevenButton.TabIndex = 5;
            this.taskSevenButton.Text = "Задача сетевого планирования и управления";
            this.taskSevenButton.UseVisualStyleBackColor = true;
            this.taskSevenButton.Click += new System.EventHandler(this.taskSevenButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 372);
            this.Controls.Add(this.taskSevenButton);
            this.Controls.Add(this.taskSixButton);
            this.Controls.Add(this.taskFiveButton);
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
        private System.Windows.Forms.Button taskFiveButton;
        private System.Windows.Forms.Button taskSixButton;
        private System.Windows.Forms.Button taskSevenButton;
    }
}
