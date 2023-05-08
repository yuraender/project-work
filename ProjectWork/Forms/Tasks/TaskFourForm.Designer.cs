namespace ProjectWork.Forms.Tasks
{
    partial class TaskFourForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.columnCount = new System.Windows.Forms.TextBox();
            this.rowCount = new System.Windows.Forms.TextBox();
            this.solve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(930, 311);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Варианты развития технической системы";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Число технических систем";
            // 
            // columnCount
            // 
            this.columnCount.Location = new System.Drawing.Point(476, 82);
            this.columnCount.Name = "columnCount";
            this.columnCount.Size = new System.Drawing.Size(113, 22);
            this.columnCount.TabIndex = 5;
            this.columnCount.TextChanged += new System.EventHandler(this.columnCount_TextChanged);
            // 
            // rowCount
            // 
            this.rowCount.Location = new System.Drawing.Point(477, 16);
            this.rowCount.Name = "rowCount";
            this.rowCount.Size = new System.Drawing.Size(112, 22);
            this.rowCount.TabIndex = 6;
            this.rowCount.TextChanged += new System.EventHandler(this.rowCount_TextChanged);
            // 
            // solve
            // 
            this.solve.Location = new System.Drawing.Point(84, 157);
            this.solve.Name = "solve";
            this.solve.Size = new System.Drawing.Size(465, 29);
            this.solve.TabIndex = 7;
            this.solve.Text = "Получить номер лучшей технической системы";
            this.solve.UseVisualStyleBackColor = true;
            this.solve.Click += new System.EventHandler(this.solve_Click);
            // 
            // TaskFourForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 575);
            this.Controls.Add(this.solve);
            this.Controls.Add(this.rowCount);
            this.Controls.Add(this.columnCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TaskFourForm";
            this.Text = "TaskFourForm";
            this.Load += new System.EventHandler(this.TaskFourForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox columnCount;
        private System.Windows.Forms.TextBox rowCount;
        private System.Windows.Forms.Button solve;
    }
}