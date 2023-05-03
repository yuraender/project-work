namespace ProjectWork.Forms.Tasks.One {
    partial class CombinationEditForm {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fullBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.requiredBox = new System.Windows.Forms.ListBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.createUpdateButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fullBox);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.requiredBox);
            this.groupBox1.Controls.Add(this.removeButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 150);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Реализации";
            // 
            // fullBox
            // 
            this.fullBox.FormattingEnabled = true;
            this.fullBox.Location = new System.Drawing.Point(6, 19);
            this.fullBox.Name = "fullBox";
            this.fullBox.Size = new System.Drawing.Size(138, 121);
            this.fullBox.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(150, 55);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(50, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = ">>";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // requiredBox
            // 
            this.requiredBox.FormattingEnabled = true;
            this.requiredBox.Location = new System.Drawing.Point(206, 19);
            this.requiredBox.Name = "requiredBox";
            this.requiredBox.Size = new System.Drawing.Size(138, 121);
            this.requiredBox.TabIndex = 1;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(150, 84);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(50, 23);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "<<";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // createUpdateButton
            // 
            this.createUpdateButton.Location = new System.Drawing.Point(149, 176);
            this.createUpdateButton.Name = "createUpdateButton";
            this.createUpdateButton.Size = new System.Drawing.Size(75, 23);
            this.createUpdateButton.TabIndex = 10;
            this.createUpdateButton.Text = "createUpdateButton";
            this.createUpdateButton.UseVisualStyleBackColor = true;
            this.createUpdateButton.Click += new System.EventHandler(this.createUpdateButton_Click);
            // 
            // CombinationEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 211);
            this.Controls.Add(this.createUpdateButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CombinationEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CombinationEditForm";
            this.Load += new System.EventHandler(this.CombinationEditForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox fullBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox requiredBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button createUpdateButton;
    }
}