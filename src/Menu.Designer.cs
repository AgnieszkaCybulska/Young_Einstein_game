namespace Young_Einstein
{
    /// <summary>
    /// Menu sluzy do wyswietlania podstawowych opcji sluzacych do rozpoczecia rozgrywki oraz do zapisu i odczytu otrzymanych wynikow.
    /// </summary>
    partial class Menu
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        //Gra gra = new Gra();
        /// <summary>
        /// Wyczysc wszystkie uzywane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jezeli zarzadzane zasoby powinny zostac zlikwidowane; Falsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obslugi projektanta — nie nalezy modyfikowac
        /// jej zawartosci w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.rozpocznij_gre = new System.Windows.Forms.Button();
            this.wyjdz = new System.Windows.Forms.Button();
            this.zapisz = new System.Windows.Forms.Button();
            this.autor = new System.Windows.Forms.Label();
            this.tytul = new System.Windows.Forms.Label();
            this.opis = new System.Windows.Forms.Label();
            this.kontynuuj_gre = new System.Windows.Forms.Button();
            this.informacje = new System.Windows.Forms.Button();
            this.tekst_informacji = new System.Windows.Forms.Label();
            this.zamknij_informacje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rozpocznij_gre
            // 
            this.rozpocznij_gre.BackColor = System.Drawing.Color.YellowGreen;
            this.rozpocznij_gre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rozpocznij_gre.Location = new System.Drawing.Point(239, 186);
            this.rozpocznij_gre.Name = "rozpocznij_gre";
            this.rozpocznij_gre.Size = new System.Drawing.Size(321, 69);
            this.rozpocznij_gre.TabIndex = 0;
            this.rozpocznij_gre.Text = "ROZPOCZNIJ NOWA GRE";
            this.rozpocznij_gre.UseVisualStyleBackColor = false;
            this.rozpocznij_gre.Click += new System.EventHandler(this.rozpocznij_gre_Click);
            // 
            // wyjdz
            // 
            this.wyjdz.BackColor = System.Drawing.Color.Tomato;
            this.wyjdz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.wyjdz.Location = new System.Drawing.Point(239, 261);
            this.wyjdz.Name = "wyjdz";
            this.wyjdz.Size = new System.Drawing.Size(321, 69);
            this.wyjdz.TabIndex = 2;
            this.wyjdz.Text = "WYJDZ";
            this.wyjdz.UseVisualStyleBackColor = false;
            this.wyjdz.Click += new System.EventHandler(this.wyjdz_Click);
            // 
            // zapisz
            // 
            this.zapisz.BackColor = System.Drawing.Color.Goldenrod;
            this.zapisz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zapisz.Location = new System.Drawing.Point(586, 383);
            this.zapisz.Name = "zapisz";
            this.zapisz.Size = new System.Drawing.Size(202, 55);
            this.zapisz.TabIndex = 3;
            this.zapisz.Text = "ZAPISZ POZIOM";
            this.zapisz.UseVisualStyleBackColor = false;
            this.zapisz.Visible = false;
            this.zapisz.Click += new System.EventHandler(this.zapisz_Click);
            // 
            // autor
            // 
            this.autor.AutoSize = true;
            this.autor.BackColor = System.Drawing.Color.Transparent;
            this.autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.autor.Location = new System.Drawing.Point(13, 420);
            this.autor.Name = "autor";
            this.autor.Size = new System.Drawing.Size(180, 17);
            this.autor.TabIndex = 4;
            this.autor.Text = "Autor: Agnieszka Cybulska ";
            // 
            // tytul
            // 
            this.tytul.AutoSize = true;
            this.tytul.BackColor = System.Drawing.Color.Transparent;
            this.tytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tytul.Location = new System.Drawing.Point(213, 19);
            this.tytul.Name = "tytul";
            this.tytul.Size = new System.Drawing.Size(403, 51);
            this.tytul.TabIndex = 5;
            this.tytul.Text = "YOUNG EINSTEIN";
            this.tytul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // opis
            // 
            this.opis.AutoSize = true;
            this.opis.BackColor = System.Drawing.Color.Transparent;
            this.opis.Location = new System.Drawing.Point(317, 71);
            this.opis.Name = "opis";
            this.opis.Size = new System.Drawing.Size(189, 17);
            this.opis.TabIndex = 6;
            this.opis.Text = "gra matematyczno - logiczna";
            // 
            // kontynuuj_gre
            // 
            this.kontynuuj_gre.BackColor = System.Drawing.Color.Chartreuse;
            this.kontynuuj_gre.Enabled = false;
            this.kontynuuj_gre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kontynuuj_gre.Location = new System.Drawing.Point(239, 111);
            this.kontynuuj_gre.Name = "kontynuuj_gre";
            this.kontynuuj_gre.Size = new System.Drawing.Size(321, 69);
            this.kontynuuj_gre.TabIndex = 7;
            this.kontynuuj_gre.Text = "KONTYNUUJ GRE";
            this.kontynuuj_gre.UseVisualStyleBackColor = false;
            this.kontynuuj_gre.Visible = false;
            this.kontynuuj_gre.Click += new System.EventHandler(this.kontynuuj_gre_Click);
            // 
            // informacje
            // 
            this.informacje.AutoEllipsis = true;
            this.informacje.BackColor = System.Drawing.Color.LightSkyBlue;
            this.informacje.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.informacje.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informacje.Location = new System.Drawing.Point(4, 4);
            this.informacje.Name = "informacje";
            this.informacje.Size = new System.Drawing.Size(54, 50);
            this.informacje.TabIndex = 8;
            this.informacje.Text = "i";
            this.informacje.UseVisualStyleBackColor = false;
            this.informacje.Click += new System.EventHandler(this.informacje_Click);
            // 
            // tekst_informacji
            // 
            this.tekst_informacji.BackColor = System.Drawing.Color.FloralWhite;
            this.tekst_informacji.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tekst_informacji.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tekst_informacji.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tekst_informacji.Location = new System.Drawing.Point(82, 98);
            this.tekst_informacji.Name = "tekst_informacji";
            this.tekst_informacji.Size = new System.Drawing.Size(651, 312);
            this.tekst_informacji.TabIndex = 9;
            this.tekst_informacji.Text = resources.GetString("tekst_informacji.Text");
            this.tekst_informacji.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tekst_informacji.Visible = false;
            // 
            // zamknij_informacje
            // 
            this.zamknij_informacje.BackColor = System.Drawing.Color.Red;
            this.zamknij_informacje.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zamknij_informacje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zamknij_informacje.Location = new System.Drawing.Point(704, 98);
            this.zamknij_informacje.Name = "zamknij_informacje";
            this.zamknij_informacje.Size = new System.Drawing.Size(29, 27);
            this.zamknij_informacje.TabIndex = 10;
            this.zamknij_informacje.Text = "x";
            this.zamknij_informacje.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.zamknij_informacje.UseVisualStyleBackColor = false;
            this.zamknij_informacje.Visible = false;
            this.zamknij_informacje.Click += new System.EventHandler(this.zamknij_informacje_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.zamknij_informacje);
            this.Controls.Add(this.tekst_informacji);
            this.Controls.Add(this.informacje);
            this.Controls.Add(this.kontynuuj_gre);
            this.Controls.Add(this.opis);
            this.Controls.Add(this.tytul);
            this.Controls.Add(this.autor);
            this.Controls.Add(this.zapisz);
            this.Controls.Add(this.wyjdz);
            this.Controls.Add(this.rozpocznij_gre);
            this.Name = "Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        /// <summary>
        /// Publiczny przycisk "zapisz" pozwala na zapisanie numeru rundy w klasie Gra, po zamknieciu jej okna.
        /// </summary>
        public System.Windows.Forms.Button zapisz;
        private System.Windows.Forms.Label autor;
        private System.Windows.Forms.Label tytul;
        private System.Windows.Forms.Label opis;
        private System.Windows.Forms.Button informacje;
        private System.Windows.Forms.Label tekst_informacji;
        private System.Windows.Forms.Button zamknij_informacje;
        private System.Windows.Forms.Button rozpocznij_gre;
        private System.Windows.Forms.Button wyjdz;
        private System.Windows.Forms.Button kontynuuj_gre;
    }
}

