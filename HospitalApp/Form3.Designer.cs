namespace HospitalApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxIdDoktora = new System.Windows.Forms.TextBox();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.textBoxJMBG = new System.Windows.Forms.TextBox();
            this.textBoxSpecijalnost = new System.Windows.Forms.TextBox();
            this.textBoxBrojTelefona = new System.Windows.Forms.TextBox();
            this.textBoxKorisnickoIme = new System.Windows.Forms.TextBox();
            this.textBoxLozinka = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(23, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Spisak doktora";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(23, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 41);
            this.button2.TabIndex = 0;
            this.button2.Text = "Izmena informacija";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(23, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 41);
            this.button3.TabIndex = 0;
            this.button3.Text = "Pronađi doktora";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(260, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1077, 404);
            this.listBox1.TabIndex = 1;
            // 
            // textBoxIdDoktora
            // 
            this.textBoxIdDoktora.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxIdDoktora.Location = new System.Drawing.Point(23, 490);
            this.textBoxIdDoktora.Name = "textBoxIdDoktora";
            this.textBoxIdDoktora.PlaceholderText = "Id doktora";
            this.textBoxIdDoktora.Size = new System.Drawing.Size(164, 34);
            this.textBoxIdDoktora.TabIndex = 2;
            this.textBoxIdDoktora.TextChanged += new System.EventHandler(this.textBoxIdDoktora_TextChanged);
            // 
            // textBoxIme
            // 
            this.textBoxIme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxIme.Location = new System.Drawing.Point(193, 490);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.PlaceholderText = "Ime";
            this.textBoxIme.Size = new System.Drawing.Size(157, 34);
            this.textBoxIme.TabIndex = 2;
            this.textBoxIme.TextChanged += new System.EventHandler(this.textBoxIdDoktora_TextChanged);
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPrezime.Location = new System.Drawing.Point(356, 490);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.PlaceholderText = "Prezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(157, 34);
            this.textBoxPrezime.TabIndex = 2;
            this.textBoxPrezime.TextChanged += new System.EventHandler(this.textBoxIdDoktora_TextChanged);
            // 
            // textBoxJMBG
            // 
            this.textBoxJMBG.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxJMBG.Location = new System.Drawing.Point(519, 490);
            this.textBoxJMBG.Name = "textBoxJMBG";
            this.textBoxJMBG.PlaceholderText = "JMBG";
            this.textBoxJMBG.Size = new System.Drawing.Size(157, 34);
            this.textBoxJMBG.TabIndex = 2;
            this.textBoxJMBG.TextChanged += new System.EventHandler(this.textBoxIdDoktora_TextChanged);
            // 
            // textBoxSpecijalnost
            // 
            this.textBoxSpecijalnost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSpecijalnost.Location = new System.Drawing.Point(682, 490);
            this.textBoxSpecijalnost.Name = "textBoxSpecijalnost";
            this.textBoxSpecijalnost.PlaceholderText = "Specijalnost";
            this.textBoxSpecijalnost.Size = new System.Drawing.Size(164, 34);
            this.textBoxSpecijalnost.TabIndex = 2;
            this.textBoxSpecijalnost.TextChanged += new System.EventHandler(this.textBoxIdDoktora_TextChanged);
            // 
            // textBoxBrojTelefona
            // 
            this.textBoxBrojTelefona.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxBrojTelefona.Location = new System.Drawing.Point(852, 490);
            this.textBoxBrojTelefona.Name = "textBoxBrojTelefona";
            this.textBoxBrojTelefona.PlaceholderText = "Broj telefona";
            this.textBoxBrojTelefona.Size = new System.Drawing.Size(157, 34);
            this.textBoxBrojTelefona.TabIndex = 2;
            this.textBoxBrojTelefona.TextChanged += new System.EventHandler(this.textBoxIdDoktora_TextChanged);
            // 
            // textBoxKorisnickoIme
            // 
            this.textBoxKorisnickoIme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxKorisnickoIme.Location = new System.Drawing.Point(1015, 490);
            this.textBoxKorisnickoIme.Name = "textBoxKorisnickoIme";
            this.textBoxKorisnickoIme.PlaceholderText = "Korisničko ime";
            this.textBoxKorisnickoIme.Size = new System.Drawing.Size(157, 34);
            this.textBoxKorisnickoIme.TabIndex = 2;
            this.textBoxKorisnickoIme.TextChanged += new System.EventHandler(this.textBoxIdDoktora_TextChanged);
            // 
            // textBoxLozinka
            // 
            this.textBoxLozinka.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLozinka.Location = new System.Drawing.Point(1178, 490);
            this.textBoxLozinka.Name = "textBoxLozinka";
            this.textBoxLozinka.PlaceholderText = "Lozinka";
            this.textBoxLozinka.Size = new System.Drawing.Size(157, 34);
            this.textBoxLozinka.TabIndex = 2;
            this.textBoxLozinka.UseSystemPasswordChar = true;
            this.textBoxLozinka.TextChanged += new System.EventHandler(this.textBoxIdDoktora_TextChanged);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(23, 351);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(201, 41);
            this.button5.TabIndex = 3;
            this.button5.Text = "Dodaj doktora";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1383, 580);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBoxLozinka);
            this.Controls.Add(this.textBoxKorisnickoIme);
            this.Controls.Add(this.textBoxBrojTelefona);
            this.Controls.Add(this.textBoxSpecijalnost);
            this.Controls.Add(this.textBoxJMBG);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.textBoxIdDoktora);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Informacije o doktorima";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxIdDoktora;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.TextBox textBoxJMBG;
        private System.Windows.Forms.TextBox textBoxSpecijalnost;
        private System.Windows.Forms.TextBox textBoxBrojTelefona;
        private System.Windows.Forms.TextBox textBoxKorisnickoIme;
        private System.Windows.Forms.TextBox textBoxLozinka;
        private System.Windows.Forms.Button button5;
    }
}