using System.Collections.Generic;

namespace Young_Einstein
{
    /// <summary>
    /// Klasa Gra gromadzi w sobie wszystkie, najpotrzebniejsze metody konieczne w realizacji aplikacji.
    /// </summary>
    partial class Gra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        Akcje_kart akcje = new Akcje_kart();

        List<int> karty_podstawowe = Akcje_kart.zestaw_kart();
        int numer_rundy = 1;
        double czas_timera = 0;
        

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
            this.components = new System.ComponentModel.Container();
            this.wykonaj_dzialanie = new System.Windows.Forms.Button();
            this.odloz_karte = new System.Windows.Forms.Button();
            this.uzyj_karty_czekajacej = new System.Windows.Forms.Button();
            this.karta_akcji = new System.Windows.Forms.Label();
            this.poczekalnia_kart = new System.Windows.Forms.Label();
            this.karta_wyniku = new System.Windows.Forms.Label();
            this.ktora_runda = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.czas = new System.Windows.Forms.Label();
            this.puchar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.puchar)).BeginInit();
            this.SuspendLayout();
            // 
            // wykonaj_dzialanie
            // 
            this.wykonaj_dzialanie.BackColor = System.Drawing.Color.PaleTurquoise;
            this.wykonaj_dzialanie.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.wykonaj_dzialanie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.wykonaj_dzialanie.Location = new System.Drawing.Point(565, 131);
            this.wykonaj_dzialanie.Name = "wykonaj_dzialanie";
            this.wykonaj_dzialanie.Size = new System.Drawing.Size(189, 46);
            this.wykonaj_dzialanie.TabIndex = 0;
            this.wykonaj_dzialanie.Text = "WYKONAJ DZIALANIE";
            this.wykonaj_dzialanie.UseVisualStyleBackColor = false;
            this.wykonaj_dzialanie.Click += new System.EventHandler(this.wykonaj_dzialanie_Click);
            // 
            // odloz_karte
            // 
            this.odloz_karte.BackColor = System.Drawing.Color.PaleTurquoise;
            this.odloz_karte.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.odloz_karte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.odloz_karte.Location = new System.Drawing.Point(565, 183);
            this.odloz_karte.Name = "odloz_karte";
            this.odloz_karte.Size = new System.Drawing.Size(189, 50);
            this.odloz_karte.TabIndex = 1;
            this.odloz_karte.Text = "ODLOZ KARTE";
            this.odloz_karte.UseVisualStyleBackColor = false;
            this.odloz_karte.Click += new System.EventHandler(this.odloz_karte_Click);
            // 
            // uzyj_karty_czekajacej
            // 
            this.uzyj_karty_czekajacej.BackColor = System.Drawing.Color.PaleTurquoise;
            this.uzyj_karty_czekajacej.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.uzyj_karty_czekajacej.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uzyj_karty_czekajacej.Location = new System.Drawing.Point(565, 239);
            this.uzyj_karty_czekajacej.Name = "uzyj_karty_czekajacej";
            this.uzyj_karty_czekajacej.Size = new System.Drawing.Size(189, 45);
            this.uzyj_karty_czekajacej.TabIndex = 2;
            this.uzyj_karty_czekajacej.Text = "WEZ KARTE Z POCZEKALNI";
            this.uzyj_karty_czekajacej.UseVisualStyleBackColor = false;
            this.uzyj_karty_czekajacej.Click += new System.EventHandler(this.uzyj_karty_czekajacej_Click);
            // 
            // karta_akcji
            // 
            this.karta_akcji.BackColor = System.Drawing.Color.SeaShell;
            this.karta_akcji.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.karta_akcji.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.karta_akcji.Location = new System.Drawing.Point(338, 47);
            this.karta_akcji.Name = "karta_akcji";
            this.karta_akcji.Size = new System.Drawing.Size(80, 100);
            this.karta_akcji.TabIndex = 3;
            this.karta_akcji.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // poczekalnia_kart
            // 
            this.poczekalnia_kart.BackColor = System.Drawing.Color.SeaShell;
            this.poczekalnia_kart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.poczekalnia_kart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.poczekalnia_kart.Location = new System.Drawing.Point(95, 159);
            this.poczekalnia_kart.Name = "poczekalnia_kart";
            this.poczekalnia_kart.Size = new System.Drawing.Size(80, 100);
            this.poczekalnia_kart.TabIndex = 4;
            this.poczekalnia_kart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // karta_wyniku
            // 
            this.karta_wyniku.BackColor = System.Drawing.Color.SeaShell;
            this.karta_wyniku.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.karta_wyniku.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.karta_wyniku.Location = new System.Drawing.Point(338, 309);
            this.karta_wyniku.Name = "karta_wyniku";
            this.karta_wyniku.Size = new System.Drawing.Size(80, 100);
            this.karta_wyniku.TabIndex = 5;
            this.karta_wyniku.Text = "10";
            this.karta_wyniku.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ktora_runda
            // 
            this.ktora_runda.BackColor = System.Drawing.Color.Transparent;
            this.ktora_runda.Location = new System.Drawing.Point(338, 13);
            this.ktora_runda.Name = "ktora_runda";
            this.ktora_runda.Size = new System.Drawing.Size(80, 20);
            this.ktora_runda.TabIndex = 6;
            this.ktora_runda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // czas
            // 
            this.czas.BackColor = System.Drawing.Color.Transparent;
            this.czas.Location = new System.Drawing.Point(672, 13);
            this.czas.Name = "czas";
            this.czas.Size = new System.Drawing.Size(102, 32);
            this.czas.TabIndex = 7;
            this.czas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // puchar
            // 
            this.puchar.BackgroundImage = global::Young_Einstein.Properties.Resources.puchar1;
            this.puchar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.puchar.Location = new System.Drawing.Point(198, 13);
            this.puchar.Name = "puchar";
            this.puchar.Size = new System.Drawing.Size(361, 426);
            this.puchar.TabIndex = 8;
            this.puchar.TabStop = false;
            this.puchar.Visible = false;
            // 
            // Gra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.puchar);
            this.Controls.Add(this.czas);
            this.Controls.Add(this.ktora_runda);
            this.Controls.Add(this.karta_wyniku);
            this.Controls.Add(this.poczekalnia_kart);
            this.Controls.Add(this.karta_akcji);
            this.Controls.Add(this.uzyj_karty_czekajacej);
            this.Controls.Add(this.odloz_karte);
            this.Controls.Add(this.wykonaj_dzialanie);
            this.DoubleBuffered = true;
            this.Name = "Gra";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.puchar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button wykonaj_dzialanie;
        private System.Windows.Forms.Button odloz_karte;
        private System.Windows.Forms.Button uzyj_karty_czekajacej;
        private System.Windows.Forms.Label karta_akcji;
        private System.Windows.Forms.Label poczekalnia_kart;
        private System.Windows.Forms.Label karta_wyniku;
        private System.Windows.Forms.Label ktora_runda;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label czas;
        private System.Windows.Forms.PictureBox puchar;
    }
}