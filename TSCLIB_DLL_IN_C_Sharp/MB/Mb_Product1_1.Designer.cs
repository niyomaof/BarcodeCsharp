﻿namespace TSCLIB_DLL_IN_C_Sharp.MB
{
    partial class Mb_Product1_1
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
            this.label11 = new System.Windows.Forms.Label();
            this.buttonMbOk = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Angsana New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(57, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 29);
            this.label11.TabIndex = 61;
            this.label11.Text = "คุณยังไม่กรอก ชื่อสินค้า";
            // 
            // buttonMbOk
            // 
            this.buttonMbOk.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonMbOk.FlatAppearance.BorderSize = 0;
            this.buttonMbOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMbOk.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMbOk.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonMbOk.Location = new System.Drawing.Point(93, 110);
            this.buttonMbOk.Name = "buttonMbOk";
            this.buttonMbOk.Size = new System.Drawing.Size(71, 29);
            this.buttonMbOk.TabIndex = 125;
            this.buttonMbOk.Text = "Ok";
            this.buttonMbOk.UseVisualStyleBackColor = false;
            this.buttonMbOk.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TSCLIB_DLL_IN_C_Sharp.Properties.Resources.Error2;
            this.pictureBox1.Location = new System.Drawing.Point(93, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 125;
            this.pictureBox1.TabStop = false;
            // 
            // Mb_Product1_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(260, 155);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonMbOk);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mb_Product1_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mb_Product1_1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonMbOk;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}