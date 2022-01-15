namespace HospitalApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxBrojKartona = new System.Windows.Forms.TextBox();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.textBoxJMBG = new System.Windows.Forms.TextBox();
            this.textBoxAdresa = new System.Windows.Forms.TextBox();
            this.textBoxBrojTelefona = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(28, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(284, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Podaci o pacijentima";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(28, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(284, 41);
            this.button2.TabIndex = 0;
            this.button2.Text = "Dodaj pacijenta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(28, 205);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(284, 41);
            this.button3.TabIndex = 0;
            this.button3.Text = "Izmeni podatke o pacijentu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(28, 282);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(284, 41);
            this.button4.TabIndex = 0;
            this.button4.Text = "Ukloni pacijenta";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(28, 368);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(284, 41);
            this.button5.TabIndex = 0;
            this.button5.Text = "Pronađi pacijenta";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(352, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1018, 524);
            this.listBox1.TabIndex = 1;
            // 
            // textBoxBrojKartona
            // 
            this.textBoxBrojKartona.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxBrojKartona.Location = new System.Drawing.Point(66, 626);
            this.textBoxBrojKartona.Name = "textBoxBrojKartona";
            this.textBoxBrojKartona.PlaceholderText = "Broj kartona";
            this.textBoxBrojKartona.Size = new System.Drawing.Size(175, 34);
            this.textBoxBrojKartona.TabIndex = 2;
            // 
            // textBoxIme
            // 
            this.textBoxIme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxIme.Location = new System.Drawing.Point(273, 626);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.PlaceholderText = "Ime";
            this.textBoxIme.Size = new System.Drawing.Size(175, 34);
            this.textBoxIme.TabIndex = 2;
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPrezime.Location = new System.Drawing.Point(481, 626);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.PlaceholderText = "Prezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(170, 34);
            this.textBoxPrezime.TabIndex = 2;
            // 
            // textBoxJMBG
            // 
            this.textBoxJMBG.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxJMBG.Location = new System.Drawing.Point(691, 626);
            this.textBoxJMBG.Name = "textBoxJMBG";
            this.textBoxJMBG.PlaceholderText = "JMBG";
            this.textBoxJMBG.Size = new System.Drawing.Size(199, 34);
            this.textBoxJMBG.TabIndex = 2;
            // 
            // textBoxAdresa
            // 
            this.textBoxAdresa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAdresa.Location = new System.Drawing.Point(930, 626);
            this.textBoxAdresa.Name = "textBoxAdresa";
            this.textBoxAdresa.PlaceholderText = "Adresa";
            this.textBoxAdresa.Size = new System.Drawing.Size(198, 34);
            this.textBoxAdresa.TabIndex = 2;
            // 
            // textBoxBrojTelefona
            // 
            this.textBoxBrojTelefona.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxBrojTelefona.Location = new System.Drawing.Point(1164, 626);
            this.textBoxBrojTelefona.Name = "textBoxBrojTelefona";
            this.textBoxBrojTelefona.PlaceholderText = "Broj telefona";
            this.textBoxBrojTelefona.Size = new System.Drawing.Size(173, 34);
            this.textBoxBrojTelefona.TabIndex = 2;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(28, 446);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(284, 45);
            this.button6.TabIndex = 3;
            this.button6.Text = "Informacije o kartonu";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(28, 531);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(284, 47);
            this.button7.TabIndex = 4;
            this.button7.Text = "Informacije o doktorima";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1398, 785);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBoxBrojTelefona);
            this.Controls.Add(this.textBoxAdresa);
            this.Controls.Add(this.textBoxJMBG);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.textBoxBrojKartona);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Bolnica - Informacije";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxBrojKartona;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.TextBox textBoxJMBG;
        private System.Windows.Forms.TextBox textBoxAdresa;
        private System.Windows.Forms.TextBox textBoxBrojTelefona;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}