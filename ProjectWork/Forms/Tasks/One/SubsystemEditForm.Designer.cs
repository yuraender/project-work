namespace ProjectWork.Forms.Tasks.One {
    partial class SubsystemEditForm {
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.characteristicBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.implementationBox = new System.Windows.Forms.ListBox();
            this.characteristicDeleteButton = new System.Windows.Forms.Button();
            this.characteristicEditButton = new System.Windows.Forms.Button();
            this.characteristicAddButton = new System.Windows.Forms.Button();
            this.implementationDeleteButton = new System.Windows.Forms.Button();
            this.implementationEditButton = new System.Windows.Forms.Button();
            this.implementationAddButton = new System.Windows.Forms.Button();
            this.createUpdateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(27, 43);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(154, 20);
            this.nameBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(27, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Характеристики";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // characteristicBox
            // 
            this.characteristicBox.FormattingEnabled = true;
            this.characteristicBox.Location = new System.Drawing.Point(27, 105);
            this.characteristicBox.Name = "characteristicBox";
            this.characteristicBox.Size = new System.Drawing.Size(154, 82);
            this.characteristicBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(206, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Реализации";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // implementationBox
            // 
            this.implementationBox.FormattingEnabled = true;
            this.implementationBox.Location = new System.Drawing.Point(206, 43);
            this.implementationBox.Name = "implementationBox";
            this.implementationBox.Size = new System.Drawing.Size(154, 147);
            this.implementationBox.TabIndex = 8;
            // 
            // characteristicDeleteButton
            // 
            this.characteristicDeleteButton.Enabled = false;
            this.characteristicDeleteButton.Location = new System.Drawing.Point(68, 254);
            this.characteristicDeleteButton.Name = "characteristicDeleteButton";
            this.characteristicDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.characteristicDeleteButton.TabIndex = 6;
            this.characteristicDeleteButton.Text = "Удалить";
            this.characteristicDeleteButton.UseVisualStyleBackColor = true;
            this.characteristicDeleteButton.Click += new System.EventHandler(this.characteristicDeleteButton_Click);
            // 
            // characteristicEditButton
            // 
            this.characteristicEditButton.Enabled = false;
            this.characteristicEditButton.Location = new System.Drawing.Point(68, 225);
            this.characteristicEditButton.Name = "characteristicEditButton";
            this.characteristicEditButton.Size = new System.Drawing.Size(75, 23);
            this.characteristicEditButton.TabIndex = 5;
            this.characteristicEditButton.Text = "Изменить";
            this.characteristicEditButton.UseVisualStyleBackColor = true;
            this.characteristicEditButton.Click += new System.EventHandler(this.characteristicEditButton_Click);
            // 
            // characteristicAddButton
            // 
            this.characteristicAddButton.Location = new System.Drawing.Point(68, 196);
            this.characteristicAddButton.Name = "characteristicAddButton";
            this.characteristicAddButton.Size = new System.Drawing.Size(75, 23);
            this.characteristicAddButton.TabIndex = 4;
            this.characteristicAddButton.Text = "Добавить";
            this.characteristicAddButton.UseVisualStyleBackColor = true;
            this.characteristicAddButton.Click += new System.EventHandler(this.characteristicAddButton_Click);
            // 
            // implementationDeleteButton
            // 
            this.implementationDeleteButton.Enabled = false;
            this.implementationDeleteButton.Location = new System.Drawing.Point(245, 254);
            this.implementationDeleteButton.Name = "implementationDeleteButton";
            this.implementationDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.implementationDeleteButton.TabIndex = 11;
            this.implementationDeleteButton.Text = "Удалить";
            this.implementationDeleteButton.UseVisualStyleBackColor = true;
            this.implementationDeleteButton.Click += new System.EventHandler(this.implementationDeleteButton_Click);
            // 
            // implementationEditButton
            // 
            this.implementationEditButton.Enabled = false;
            this.implementationEditButton.Location = new System.Drawing.Point(245, 225);
            this.implementationEditButton.Name = "implementationEditButton";
            this.implementationEditButton.Size = new System.Drawing.Size(75, 23);
            this.implementationEditButton.TabIndex = 10;
            this.implementationEditButton.Text = "Изменить";
            this.implementationEditButton.UseVisualStyleBackColor = true;
            this.implementationEditButton.Click += new System.EventHandler(this.implementationEditButton_Click);
            // 
            // implementationAddButton
            // 
            this.implementationAddButton.Enabled = false;
            this.implementationAddButton.Location = new System.Drawing.Point(245, 196);
            this.implementationAddButton.Name = "implementationAddButton";
            this.implementationAddButton.Size = new System.Drawing.Size(75, 23);
            this.implementationAddButton.TabIndex = 9;
            this.implementationAddButton.Text = "Добавить";
            this.implementationAddButton.UseVisualStyleBackColor = true;
            this.implementationAddButton.Click += new System.EventHandler(this.implementationAddButton_Click);
            // 
            // createUpdateButton
            // 
            this.createUpdateButton.Location = new System.Drawing.Point(155, 313);
            this.createUpdateButton.Name = "createUpdateButton";
            this.createUpdateButton.Size = new System.Drawing.Size(75, 23);
            this.createUpdateButton.TabIndex = 12;
            this.createUpdateButton.Text = "createUpdateButton";
            this.createUpdateButton.UseVisualStyleBackColor = true;
            this.createUpdateButton.Click += new System.EventHandler(this.createUpdateButton_Click);
            // 
            // SubsystemEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.createUpdateButton);
            this.Controls.Add(this.implementationDeleteButton);
            this.Controls.Add(this.implementationEditButton);
            this.Controls.Add(this.implementationAddButton);
            this.Controls.Add(this.characteristicDeleteButton);
            this.Controls.Add(this.characteristicEditButton);
            this.Controls.Add(this.characteristicAddButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.implementationBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.characteristicBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SubsystemEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SubsystemEditForm";
            this.Load += new System.EventHandler(this.SubsystemEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox characteristicBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox implementationBox;
        private System.Windows.Forms.Button characteristicDeleteButton;
        private System.Windows.Forms.Button characteristicEditButton;
        private System.Windows.Forms.Button characteristicAddButton;
        private System.Windows.Forms.Button implementationDeleteButton;
        private System.Windows.Forms.Button implementationEditButton;
        private System.Windows.Forms.Button implementationAddButton;
        private System.Windows.Forms.Button createUpdateButton;
    }
}