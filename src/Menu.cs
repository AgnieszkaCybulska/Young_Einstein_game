using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Young_Einstein
{
    public partial class Menu : Form
    {
        /// <summary>
        /// Publiczna zmienna calkowita wykorzytywana do podania wartosci na ktorej skonczyla sie runda. To wartosc ktora jest zapisywana do pliku. 
        /// </summary>
        public int runda;

        /// <summary>
        /// Publiczna zmienna calkowita wykorzystywana jest w celu przepisania jej do numeru rundy, na ktorym zakonczono gre.
        /// </summary>
        public int kontynuuj = 1;

        /// <summary>
        /// Publiczna zmienna typu logicznego, ktora wykorzystywana jest w klasie "Gra" - sprawdza czy nacisnieto przycisk KONTYNUUJ. 
        /// </summary>
        public bool klikniecie_kontynuuj = false;

        /// <summary>
        /// Publiczna zmienna typu logicznego, ktora wykorzystywana jest w klasie "Gra" - sprawdza czy nacisnieto przycisk ROZPOCZNIJ GRE. 
        /// </summary>
        public bool klikniecie_rozpocznij= false;

        /// <summary>
        /// Konstruktor inicjalizuje komponenty, sprawdza czy istnieje plik z uprzednio zapisanymi wynikami gry - jesli tak to go odczytuje.
        /// Jesli zapisana wartosc w tym pliku jest rozna od 1 lub jest mniejsza od maksymalnego poziomu gry to pojawia sie przycisk "Kontynuuj".
        /// </summary>
        public Menu()
        {
            InitializeComponent();
            if (File.Exists("wynik_gry.txt"))
            {
                odczyt();
            }
            if (kontynuuj != 1 && kontynuuj < 10)
            {
                kontynuuj_gre.Visible = kontynuuj_gre.Enabled = true;
            }
            else
            {
                kontynuuj_gre.Visible = kontynuuj_gre.Enabled = false;
            }
            klikniecie_kontynuuj = false;
            klikniecie_rozpocznij = false;
        }

        /// <summary>
        /// Nacisniecie przycisku powoduje otworzenie nowego okna, w ktorym zrealizowana jest gra.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rozpocznij_gre_Click(object sender, EventArgs e)
        {
            klikniecie_rozpocznij = true;
            Gra gra = new Gra(this);
            gra.Owner = this;
            gra.ShowDialog();
        }

        /// <summary>
        /// Przycisk, ktory pozwala na zamkniecie programu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wyjdz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Nacisniecie przycisku powoduje zapisanie w pliku wynik_gry.txt numeru rundy, na ktorym zakonczono gre.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zapisz_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText("wynik_gry.txt", runda.ToString());
                TextWriter tw = new StreamWriter("wynik_gry.txt", true);
            }
            catch (Exception exp)
            {
                Console.WriteLine("Bledny zapis pliku: ");
                Console.WriteLine(exp.Message);
            }
        }

        /// <summary>
        /// Metoda odczyt() pozwala na odczytanie z pliku wynik_gry.txtx wartosci przechowujacej zapisany podczas poprzedniej gry poziom.
        /// </summary>
        private void odczyt()
        {
            try
            {
                using (StreamReader sr = new StreamReader("wynik_gry.txt"))
                {
                    kontynuuj = int.Parse(sr.ReadLine());
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine("Bledny odczyt pliku: ");
                Console.WriteLine(exp.Message);
            }
        }

        /// <summary>
        /// Po ponownym otwarciu aplikacji, jesli zapisany poziom gry jest rozny od poziomu pierwszego,
        /// to mozna kontynuuowac rozgrywke, na poziomie, na ktorym skonczylo sie gre poprzednim razem.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void kontynuuj_gre_Click(object sender, EventArgs e)
        {
            klikniecie_kontynuuj = true;
            Gra gra = new Gra(this);
            gra.Owner = this;
            gra.ShowDialog();
        }

        /// <summary>
        /// Wyswietla informacje o programie i wyswietla guzik zamykajacy informacje.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void informacje_Click(object sender, EventArgs e)
        {
            zamknij_informacje.Visible = zamknij_informacje.Enabled = true;
            tekst_informacji.Visible = tekst_informacji.Enabled = true;
        }

        /// <summary>
        /// Zamyka okno z informacjami o programie.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zamknij_informacje_Click(object sender, EventArgs e)
        {
            tekst_informacji.Visible = tekst_informacji.Enabled = false;
            zamknij_informacje.Visible = zamknij_informacje.Enabled = false;
        }
    }
}
