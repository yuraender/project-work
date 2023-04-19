namespace ProjectWork.Forms.Tasks {
    partial class TaskTwoThreeForm {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.expertUpDown = new System.Windows.Forms.NumericUpDown();
            this.versionUpDown = new System.Windows.Forms.NumericUpDown();
            this.solveButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.linkedBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.significanceUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expertUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.versionUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.significanceUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите количество версий";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Введите количество экспертов";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Location = new System.Drawing.Point(12, 138);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView.Size = new System.Drawing.Size(860, 311);
            this.dataGridView.TabIndex = 8;
            // 
            // expertUpDown
            // 
            this.expertUpDown.Location = new System.Drawing.Point(428, 24);
            this.expertUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.expertUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.expertUpDown.Name = "expertUpDown";
            this.expertUpDown.ReadOnly = true;
            this.expertUpDown.Size = new System.Drawing.Size(48, 20);
            this.expertUpDown.TabIndex = 1;
            this.expertUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.expertUpDown.ValueChanged += new System.EventHandler(this.expertUpDown_ValueChanged);
            // 
            // versionUpDown
            // 
            this.versionUpDown.Location = new System.Drawing.Point(428, 50);
            this.versionUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.versionUpDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.versionUpDown.Name = "versionUpDown";
            this.versionUpDown.ReadOnly = true;
            this.versionUpDown.Size = new System.Drawing.Size(48, 20);
            this.versionUpDown.TabIndex = 3;
            this.versionUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.versionUpDown.ValueChanged += new System.EventHandler(this.versionUpDown_ValueChanged);
            // 
            // solveButton
            // 
            this.solveButton.Location = new System.Drawing.Point(520, 54);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(90, 38);
            this.solveButton.TabIndex = 9;
            this.solveButton.Text = "Оценить";
            this.solveButton.UseVisualStyleBackColor = true;
            this.solveButton.Click += new System.EventHandler(this.solveButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Есть связанные ранги";
            // 
            // linkedBox
            // 
            this.linkedBox.AutoSize = true;
            this.linkedBox.Location = new System.Drawing.Point(428, 102);
            this.linkedBox.Name = "linkedBox";
            this.linkedBox.Size = new System.Drawing.Size(15, 14);
            this.linkedBox.TabIndex = 7;
            this.linkedBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Введите уровнь значимости";
            // 
            // significanceUpDown
            // 
            this.significanceUpDown.DecimalPlaces = 3;
            this.significanceUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.significanceUpDown.Location = new System.Drawing.Point(428, 76);
            this.significanceUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.significanceUpDown.Name = "significanceUpDown";
            this.significanceUpDown.Size = new System.Drawing.Size(48, 20);
            this.significanceUpDown.TabIndex = 5;
            this.significanceUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // TaskTwoThreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.significanceUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkedBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.solveButton);
            this.Controls.Add(this.versionUpDown);
            this.Controls.Add(this.expertUpDown);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TaskTwoThreeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Метод экспертной оценки";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expertUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.versionUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.significanceUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.NumericUpDown expertUpDown;
        private System.Windows.Forms.NumericUpDown versionUpDown;
        private System.Windows.Forms.Button solveButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox linkedBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown significanceUpDown;
    }
}