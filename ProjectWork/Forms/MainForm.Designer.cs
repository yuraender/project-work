﻿namespace ProjectWork.Forms {
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
            this.spectralAnalysis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // taskOneButton
            // 
            this.taskOneButton.Location = new System.Drawing.Point(16, 15);
            this.taskOneButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.taskOneButton.Name = "taskOneButton";
            this.taskOneButton.Size = new System.Drawing.Size(188, 65);
            this.taskOneButton.TabIndex = 0;
            this.taskOneButton.Text = "Структурный синтез систем";
            this.taskOneButton.UseVisualStyleBackColor = true;
            this.taskOneButton.Click += new System.EventHandler(this.taskOneButton_Click);
            // 
            // taskTwoThreeButton
            // 
            this.taskTwoThreeButton.Location = new System.Drawing.Point(212, 15);
            this.taskTwoThreeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.taskTwoThreeButton.Name = "taskTwoThreeButton";
            this.taskTwoThreeButton.Size = new System.Drawing.Size(188, 65);
            this.taskTwoThreeButton.TabIndex = 1;
            this.taskTwoThreeButton.Text = "Метод экспертной оценки";
            this.taskTwoThreeButton.UseVisualStyleBackColor = true;
            this.taskTwoThreeButton.Click += new System.EventHandler(this.taskTwoThreeButton_Click);
            // 
            // spectralAnalysis
            // 
            this.spectralAnalysis.Location = new System.Drawing.Point(421, 15);
            this.spectralAnalysis.Name = "spectralAnalysis";
            this.spectralAnalysis.Size = new System.Drawing.Size(215, 65);
            this.spectralAnalysis.TabIndex = 2;
            this.spectralAnalysis.Text = "Метод спектрального анализа";
            this.spectralAnalysis.UseVisualStyleBackColor = true;
            this.spectralAnalysis.Click += new System.EventHandler(this.spectralAnalysis_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 567);
            this.Controls.Add(this.spectralAnalysis);
            this.Controls.Add(this.taskTwoThreeButton);
            this.Controls.Add(this.taskOneButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Проектная деятельность";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button taskOneButton;
        private System.Windows.Forms.Button taskTwoThreeButton;
        private System.Windows.Forms.Button spectralAnalysis;
    }
}
