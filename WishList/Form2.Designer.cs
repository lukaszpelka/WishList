﻿namespace WishList
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.opisRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataDodaniaLabel = new System.Windows.Forms.Label();
            this.priorytetLabel = new System.Windows.Forms.Label();
            this.cenaLabel = new System.Windows.Forms.Label();
            this.trescLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Treść:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cena:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Priorytet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data dodania:";
            // 
            // opisRichTextBox
            // 
            this.opisRichTextBox.Location = new System.Drawing.Point(16, 97);
            this.opisRichTextBox.Name = "opisRichTextBox";
            this.opisRichTextBox.Size = new System.Drawing.Size(372, 172);
            this.opisRichTextBox.TabIndex = 4;
            this.opisRichTextBox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Opis:";
            // 
            // dataDodaniaLabel
            // 
            this.dataDodaniaLabel.AutoSize = true;
            this.dataDodaniaLabel.Location = new System.Drawing.Point(93, 64);
            this.dataDodaniaLabel.Name = "dataDodaniaLabel";
            this.dataDodaniaLabel.Size = new System.Drawing.Size(35, 13);
            this.dataDodaniaLabel.TabIndex = 9;
            this.dataDodaniaLabel.Text = "label7";
            // 
            // priorytetLabel
            // 
            this.priorytetLabel.AutoSize = true;
            this.priorytetLabel.Location = new System.Drawing.Point(93, 47);
            this.priorytetLabel.Name = "priorytetLabel";
            this.priorytetLabel.Size = new System.Drawing.Size(35, 13);
            this.priorytetLabel.TabIndex = 8;
            this.priorytetLabel.Text = "label8";
            // 
            // cenaLabel
            // 
            this.cenaLabel.AutoSize = true;
            this.cenaLabel.Location = new System.Drawing.Point(93, 30);
            this.cenaLabel.Name = "cenaLabel";
            this.cenaLabel.Size = new System.Drawing.Size(35, 13);
            this.cenaLabel.TabIndex = 7;
            this.cenaLabel.Text = "label9";
            // 
            // trescLabel
            // 
            this.trescLabel.AutoSize = true;
            this.trescLabel.Location = new System.Drawing.Point(93, 13);
            this.trescLabel.Name = "trescLabel";
            this.trescLabel.Size = new System.Drawing.Size(41, 13);
            this.trescLabel.TabIndex = 6;
            this.trescLabel.Text = "label10";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(313, 275);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 10;
            this.closeButton.Text = "Zamknij";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 316);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.dataDodaniaLabel);
            this.Controls.Add(this.priorytetLabel);
            this.Controls.Add(this.cenaLabel);
            this.Controls.Add(this.trescLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.opisRichTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Szczegóły życzenia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox opisRichTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label dataDodaniaLabel;
        private System.Windows.Forms.Label priorytetLabel;
        private System.Windows.Forms.Label cenaLabel;
        private System.Windows.Forms.Label trescLabel;
        private System.Windows.Forms.Button closeButton;
    }
}