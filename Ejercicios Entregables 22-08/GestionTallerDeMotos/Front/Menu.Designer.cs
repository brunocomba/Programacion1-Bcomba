﻿namespace Front
{
    partial class Menu
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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(196, 210);
            button1.Name = "button1";
            button1.Size = new Size(183, 99);
            button1.TabIndex = 0;
            button1.Text = "MOTOS DEPORTIVAS";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 128);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(551, 210);
            button2.Name = "button2";
            button2.Size = new Size(183, 99);
            button2.TabIndex = 1;
            button2.Text = "MOTOS\r\n UTILITARIAS";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(972, 575);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
    }
}