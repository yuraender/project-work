namespace ProjectWork.Forms.Tasks {
    partial class TaskOneForm {
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
            this.subsystemBox = new System.Windows.Forms.ListBox();
            this.comboBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.subsystemAddButton = new System.Windows.Forms.Button();
            this.comboAddButton = new System.Windows.Forms.Button();
            this.solveButton = new System.Windows.Forms.Button();
            this.subsystemEditButton = new System.Windows.Forms.Button();
            this.subsystemDeleteButton = new System.Windows.Forms.Button();
            this.comboDeleteButton = new System.Windows.Forms.Button();
            this.comboEditButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subsystemBox
            // 
            this.subsystemBox.FormattingEnabled = true;
            this.subsystemBox.Location = new System.Drawing.Point(12, 25);
            this.subsystemBox.Name = "subsystemBox";
            this.subsystemBox.Size = new System.Drawing.Size(120, 82);
            this.subsystemBox.TabIndex = 1;
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(152, 25);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(120, 82);
            this.comboBox.TabIndex = 6;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Подсистемы";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(152, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Связки реализаций";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subsystemAddButton
            // 
            this.subsystemAddButton.Location = new System.Drawing.Point(35, 113);
            this.subsystemAddButton.Name = "subsystemAddButton";
            this.subsystemAddButton.Size = new System.Drawing.Size(75, 23);
            this.subsystemAddButton.TabIndex = 2;
            this.subsystemAddButton.Text = "Добавить";
            this.subsystemAddButton.UseVisualStyleBackColor = true;
            this.subsystemAddButton.Click += new System.EventHandler(this.subsystemAddButton_Click);
            // 
            // comboAddButton
            // 
            this.comboAddButton.Enabled = false;
            this.comboAddButton.Location = new System.Drawing.Point(175, 113);
            this.comboAddButton.Name = "comboAddButton";
            this.comboAddButton.Size = new System.Drawing.Size(75, 23);
            this.comboAddButton.TabIndex = 7;
            this.comboAddButton.Text = "Добавить";
            this.comboAddButton.UseVisualStyleBackColor = true;
            this.comboAddButton.Click += new System.EventHandler(this.comboAddButton_Click);
            // 
            // solveButton
            // 
            this.solveButton.Location = new System.Drawing.Point(90, 226);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(103, 23);
            this.solveButton.TabIndex = 10;
            this.solveButton.Text = "Синтезировать";
            this.solveButton.UseVisualStyleBackColor = true;
            this.solveButton.Click += new System.EventHandler(this.solveButton_Click);
            // 
            // subsystemEditButton
            // 
            this.subsystemEditButton.Enabled = false;
            this.subsystemEditButton.Location = new System.Drawing.Point(35, 142);
            this.subsystemEditButton.Name = "subsystemEditButton";
            this.subsystemEditButton.Size = new System.Drawing.Size(75, 23);
            this.subsystemEditButton.TabIndex = 3;
            this.subsystemEditButton.Text = "Изменить";
            this.subsystemEditButton.UseVisualStyleBackColor = true;
            this.subsystemEditButton.Click += new System.EventHandler(this.subsystemEditButton_Click);
            // 
            // subsystemDeleteButton
            // 
            this.subsystemDeleteButton.Enabled = false;
            this.subsystemDeleteButton.Location = new System.Drawing.Point(35, 171);
            this.subsystemDeleteButton.Name = "subsystemDeleteButton";
            this.subsystemDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.subsystemDeleteButton.TabIndex = 4;
            this.subsystemDeleteButton.Text = "Удалить";
            this.subsystemDeleteButton.UseVisualStyleBackColor = true;
            this.subsystemDeleteButton.Click += new System.EventHandler(this.subsystemDeleteButton_Click);
            // 
            // comboDeleteButton
            // 
            this.comboDeleteButton.Enabled = false;
            this.comboDeleteButton.Location = new System.Drawing.Point(175, 171);
            this.comboDeleteButton.Name = "comboDeleteButton";
            this.comboDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.comboDeleteButton.TabIndex = 9;
            this.comboDeleteButton.Text = "Удалить";
            this.comboDeleteButton.UseVisualStyleBackColor = true;
            this.comboDeleteButton.Click += new System.EventHandler(this.comboDeleteButton_Click);
            // 
            // comboEditButton
            // 
            this.comboEditButton.Enabled = false;
            this.comboEditButton.Location = new System.Drawing.Point(175, 142);
            this.comboEditButton.Name = "comboEditButton";
            this.comboEditButton.Size = new System.Drawing.Size(75, 23);
            this.comboEditButton.TabIndex = 8;
            this.comboEditButton.Text = "Изменить";
            this.comboEditButton.UseVisualStyleBackColor = true;
            this.comboEditButton.Click += new System.EventHandler(this.comboEditButton_Click);
            // 
            // TaskOneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.comboEditButton);
            this.Controls.Add(this.comboDeleteButton);
            this.Controls.Add(this.subsystemDeleteButton);
            this.Controls.Add(this.subsystemEditButton);
            this.Controls.Add(this.solveButton);
            this.Controls.Add(this.comboAddButton);
            this.Controls.Add(this.subsystemAddButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.subsystemBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TaskOneForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Структурный синтез систем";
            this.Load += new System.EventHandler(this.TaskOneForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox subsystemBox;
        private System.Windows.Forms.ListBox comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button subsystemAddButton;
        private System.Windows.Forms.Button comboAddButton;
        private System.Windows.Forms.Button solveButton;
        private System.Windows.Forms.Button subsystemEditButton;
        private System.Windows.Forms.Button subsystemDeleteButton;
        private System.Windows.Forms.Button comboDeleteButton;
        private System.Windows.Forms.Button comboEditButton;
    }
}