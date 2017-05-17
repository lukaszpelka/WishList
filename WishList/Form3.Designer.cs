namespace WishList
{
    partial class Form3
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
            this.dodajButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.opisRichTextBox = new System.Windows.Forms.RichTextBox();
            this.wyczyscButton = new System.Windows.Forms.Button();
            this.trescTextBox = new System.Windows.Forms.TextBox();
            this.cenaTextBox = new System.Windows.Forms.TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(16, 255);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(97, 23);
            this.dodajButton.TabIndex = 5;
            this.dodajButton.Text = "Dodaj życzenie";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Treść:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Priorytet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cena:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Opis (opcjonalny):";
            // 
            // opisRichTextBox
            // 
            this.opisRichTextBox.Location = new System.Drawing.Point(16, 119);
            this.opisRichTextBox.Name = "opisRichTextBox";
            this.opisRichTextBox.Size = new System.Drawing.Size(350, 130);
            this.opisRichTextBox.TabIndex = 4;
            this.opisRichTextBox.Text = "";
            // 
            // wyczyscButton
            // 
            this.wyczyscButton.Location = new System.Drawing.Point(119, 255);
            this.wyczyscButton.Name = "wyczyscButton";
            this.wyczyscButton.Size = new System.Drawing.Size(97, 23);
            this.wyczyscButton.TabIndex = 6;
            this.wyczyscButton.Text = "Wyczyść";
            this.wyczyscButton.UseVisualStyleBackColor = true;
            this.wyczyscButton.Click += new System.EventHandler(this.wyczyscButton_Click);
            // 
            // trescTextBox
            // 
            this.trescTextBox.Location = new System.Drawing.Point(111, 12);
            this.trescTextBox.Name = "trescTextBox";
            this.trescTextBox.Size = new System.Drawing.Size(255, 20);
            this.trescTextBox.TabIndex = 1;
            // 
            // cenaTextBox
            // 
            this.cenaTextBox.Location = new System.Drawing.Point(111, 64);
            this.cenaTextBox.Name = "cenaTextBox";
            this.cenaTextBox.Size = new System.Drawing.Size(255, 20);
            this.cenaTextBox.TabIndex = 3;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(16, 294);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(35, 13);
            this.errorLabel.TabIndex = 11;
            this.errorLabel.Text = "label5";
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(111, 38);
            this.numericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(255, 20);
            this.numericUpDown.TabIndex = 12;
            this.numericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(291, 255);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 13;
            this.closeButton.Text = "Zamknij";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 331);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.cenaTextBox);
            this.Controls.Add(this.trescTextBox);
            this.Controls.Add(this.wyczyscButton);
            this.Controls.Add(this.opisRichTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dodajButton);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox opisRichTextBox;
        private System.Windows.Forms.Button wyczyscButton;
        private System.Windows.Forms.TextBox trescTextBox;
        private System.Windows.Forms.TextBox cenaTextBox;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Button closeButton;
    }
}