namespace ProjectWork.Forms.Tasks.One {
    partial class CharacteristicEditForm {
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
            this.minBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.criteriaBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.createUpdateButton = new System.Windows.Forms.Button();
            this.maxBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(70, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(70, 43);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 1;
            // 
            // minBox
            // 
            this.minBox.Location = new System.Drawing.Point(69, 82);
            this.minBox.Name = "minBox";
            this.minBox.Size = new System.Drawing.Size(40, 20);
            this.minBox.TabIndex = 3;
            this.minBox.Text = "0";
            this.minBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(60, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Предельные значения";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(70, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Тип связи";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // typeBox
            // 
            this.typeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Location = new System.Drawing.Point(70, 121);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(100, 21);
            this.typeBox.TabIndex = 7;
            // 
            // criteriaBox
            // 
            this.criteriaBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.criteriaBox.FormattingEnabled = true;
            this.criteriaBox.Location = new System.Drawing.Point(70, 161);
            this.criteriaBox.Name = "criteriaBox";
            this.criteriaBox.Size = new System.Drawing.Size(100, 21);
            this.criteriaBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(70, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Критерий отбора";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createUpdateButton
            // 
            this.createUpdateButton.Location = new System.Drawing.Point(82, 215);
            this.createUpdateButton.Name = "createUpdateButton";
            this.createUpdateButton.Size = new System.Drawing.Size(75, 23);
            this.createUpdateButton.TabIndex = 10;
            this.createUpdateButton.Text = "createUpdateButton";
            this.createUpdateButton.UseVisualStyleBackColor = true;
            this.createUpdateButton.Click += new System.EventHandler(this.createUpdateButton_Click);
            // 
            // maxBox
            // 
            this.maxBox.Location = new System.Drawing.Point(131, 82);
            this.maxBox.Name = "maxBox";
            this.maxBox.Size = new System.Drawing.Size(40, 20);
            this.maxBox.TabIndex = 5;
            this.maxBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(115, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "—";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CharacteristicEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 261);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maxBox);
            this.Controls.Add(this.createUpdateButton);
            this.Controls.Add(this.criteriaBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.minBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CharacteristicEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CharacteristicEditForm";
            this.Load += new System.EventHandler(this.CharacteristicEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox minBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.ComboBox criteriaBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button createUpdateButton;
        private System.Windows.Forms.TextBox maxBox;
        private System.Windows.Forms.Label label5;
    }
}