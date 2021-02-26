using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Young_Einstein
{
    public partial class Gra : Form
    {
        Menu menu;
        int suma = 0;
        int liczba_dzialan;
        int ile_dzialan = 4;
        bool uzycie_karty_z_poczekalni = false;
        bool wykonanie_karty = false;
        Random random = new Random();

        /// <summary>
        /// Konstrukotr inicjalizuje komponenty, nadaje numer rundy w zaleznosci od odczytanej wartosci.
        /// Sprawdza ilosc dzialan na runde i ustawia nowa gre.
        /// </summary>
        /// <param name="menu">Argumentem jest zmienna typu Menu</param>
        public Gra(Menu menu)
        {
            InitializeComponent();
            this.menu = menu;
            if (menu.klikniecie_kontynuuj)
            {
                numer_rundy = menu.kontynuuj;
            }
            else if(menu.klikniecie_rozpocznij)
            {
                numer_rundy = 1;
            }
           
            dzialania_w_rundzie();
            ustawianie_nowej_gry();
        }

        /// <summary>
        /// Generowanie nowej gry - metoda ustawia poczatkowy tekst na kartach. Stosowana jest na rozpoczecie kazdego poziomu.
        /// </summary>
        private void ustawianie_nowej_gry()
        {
            tekst_karty_akcji();
            ile_dzialan = liczba_dzialan;
            karta_wyniku.Text = "10";
            ktora_runda.Text = "Level " + numer_rundy;
            this.timer1.Enabled = true;
        }

        /// <summary>
        /// Metoda zeruje wszystkie karty. Stosowana w momencie przejscia do nastepnego poziomu badz przegrania. 
        /// </summary>
        private void zerowanie_kart()
        {
            this.timer1.Enabled = false;
            karta_akcji.Text = "";
            karta_wyniku.Text = "";
            poczekalnia_kart.Text = "";
        }

        /// <summary>
        /// Metoda okresla ilosc dzialan przewidzianych na runde. Przypisuje liczbe dzialan w zaleznosci od numeru rundy.
        /// </summary>
        private void dzialania_w_rundzie()
        {
            List<int> liczba_dzialan_na_runde = new List<int>();
            liczba_dzialan_na_runde.Add(0);
            for(int i = 4; i <= 22; i += 2)
            {
                liczba_dzialan_na_runde.Add(i);
            }
            
            liczba_dzialan = liczba_dzialan_na_runde[numer_rundy];
        }

        /// <summary>
        /// To zlozona metoda, ktorej zadaniem jest sprawdzenie czy powinnismy przejsc do kolejnego poziomu gry. 
        /// Jesli w poczekalni znajduje sie karta, a liczba dzialan do konca gry jest mniejsza badz rowna 1 to nalezy wyzerowac karte akcji.
        /// Jesli wykonano ostatnie dzialanie w danej rundzie, to zwiekszamy level gry i zerujemy karty.
        /// Po przejsciu 10. poziomu otrzymujemy komunikat o wygranej grze. 
        /// Jesli natomiast nie doszlismy do 10. poziomu to otrzymujemy komunikat o wygranym poziomie.
        /// Po 5. poziomie karty podstawowe zamieniamy na karty zaawansowane (dodajemy magiczne karty do rozgrywki), prawdopodobienstwo tej zamiany kart wynosi 25%.
        /// 
        /// </summary>
        private void czy_nastepna_runda()
        {
            int prawdopodobienstwo_wylosowania;

            if (ile_dzialan <= 0)
            {
                numer_rundy++;
                zerowanie_kart();
                if (numer_rundy <= 10)
                {
                    if (MessageBox.Show("Wygrales!\nCzas: " + czas_timera + "ms\nCzy chcesz przejsc do nastepnego poziomu?", "Wygrany poziom", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        czas_timera = 0;
                        if (numer_rundy > 5)
                        {
                            prawdopodobienstwo_wylosowania = random.Next(101);
                            if (prawdopodobienstwo_wylosowania <= 25)
                            {
                                List<int> karty_zaawansowane = Akcje_kart.karty_magiczne(karty_podstawowe);
                                karty_podstawowe = karty_zaawansowane;
                            }
                        }
                        dzialania_w_rundzie();
                        ustawianie_nowej_gry();
                    }
                    else
                    {
                        if (numer_rundy != 1)
                        {
                            menu.zapisz.Visible = this.Enabled = true;
                        }
                        this.Close();
                    }
                }
                else
                {
                    puchar.Visible = true;
                    MessageBox.Show("WYGRALES GRE!\nMatematyka i logika to zdecydowanie Twoje mocne strony\nGRATULACJE!", "Wygrana gra", MessageBoxButtons.OK);
                    this.Close();
                }
            }
            menu.runda = numer_rundy;
        }

        /// <summary>
        /// Oblicza sume liczby z karty akcji i liczby z karty wyniku
        /// </summary>
        /// <param name="liczba_na_karcie_akcji"></param>
        /// <returns></returns>
        private int suma_kart_akcja_wynik(string liczba_na_karcie_akcji)
        {
            int suma_akcja_wynik;
            try
            {
                if (liczba_na_karcie_akcji == "100")
                {
                    suma_akcja_wynik = 1;
                }
                else if (liczba_na_karcie_akcji == "1000")
                {
                    suma_akcja_wynik = 10;
                }
                else if (liczba_na_karcie_akcji == "2000")
                {
                    suma_akcja_wynik = 20;
                }
                else if (liczba_na_karcie_akcji == "")
                {
                    suma_akcja_wynik = int.Parse(karta_wyniku.Text);
                }
                else
                {
                    suma_akcja_wynik = (int.Parse(liczba_na_karcie_akcji) + int.Parse(karta_wyniku.Text));
                }

            }
            catch (Exception exp)
            {
                suma_akcja_wynik = 0;
                Console.WriteLine("Exception: " + exp);
            }
            return suma_akcja_wynik;
        }

        /// <summary>
        /// Oblicza sume liczby z karty znajdujacej sie w poczeklani i liczby z karty wyniku
        /// </summary>
        /// <returns>Zwraca sume liczb z karty w poczekalni i z karty wyniku</returns>
        private int suma_kart_poczekalnia_wynik()
        {
            string liczba_w_poczekalni = poczekalnia_kart.Text;
            int suma_poczekalnia_wynik;

            try
            {
                if (poczekalnia_kart.Text == "Do 1")
                {
                    suma_poczekalnia_wynik = 1;
                }
                else if (poczekalnia_kart.Text == "Do 10")
                {
                    suma_poczekalnia_wynik = 10;
                }
                else if (poczekalnia_kart.Text == "Do 20")
                {
                    suma_poczekalnia_wynik = 20;
                }
                else
                {
                    suma_poczekalnia_wynik = int.Parse(liczba_w_poczekalni) + int.Parse(karta_wyniku.Text);
                }
            }
            catch (Exception exp)
            {
                suma_poczekalnia_wynik = 0;
                Console.WriteLine("Exception: " + exp);
            }

            return suma_poczekalnia_wynik;
        }

        /// <summary>
        /// Usuwa losowosc z gry - nastepuje generowanie nowej liczby na karcie akcji w momnecie gdy zostanie spelniony warunek: 
        /// 0 > akcja + wynik > 20 i 0 > poczekalnia + wynik > 20
        /// lub jesli zostanie spelniony warunek: 
        /// 0 > akcja + poczekalnia + wynik > 20 
        /// </summary>
        /// <param name="akcja_wynik">Pobiera sume kart akcja + wynik</param>
        private void usuniecie_losowosci(int akcja_wynik)
        {
            int poczekalnia_wynik = suma_kart_poczekalnia_wynik();
            int poczekalnia;

            try
            {
                if (poczekalnia_kart.Text != "")
                {
                    poczekalnia = int.Parse(poczekalnia_kart.Text);
                }
                else
                {
                    poczekalnia = 0;
                }
            }
            catch (Exception exp)
            {
                poczekalnia = 0;
                Console.WriteLine(exp);
            }

            if (((0 > akcja_wynik || akcja_wynik > 20) && (0 > poczekalnia_wynik || poczekalnia_wynik > 20))
                || ((0 > akcja_wynik + poczekalnia) || (akcja_wynik + poczekalnia > 20)))
            {
                tekst_karty_akcji();
            }
        }

        /// <summary>
        /// Generuje karte akcji i zmienia jej tekst w zaleznosci od otrzymanej wartosci. 
        /// Oblicza sume kart akcja + wynik dla nowo wygenerowanej karty i usuwa z gry losowosc - 
        /// jesli karta nie spelnia okreslonych warunkow to losowana jest nowa karta. 
        /// </summary>
        private void tekst_karty_akcji()
        {
            string nowa_karta;
            nowa_karta = Akcje_kart.generowanie_karty(karty_podstawowe).ToString();
            int akcja_wynik_suma = suma_kart_akcja_wynik(nowa_karta);
            if (nowa_karta == "100")
            {
                karta_akcji.Text = "Do 1";
                karta_akcji.BackColor = Color.MediumOrchid;
            }
            else if (nowa_karta == "1000")
            {
                karta_akcji.Text = "Do 10";
                karta_akcji.BackColor = Color.MediumOrchid;
            }
            else if (nowa_karta == "2000")
            {
                karta_akcji.Text = "Do 20";
                karta_akcji.BackColor = Color.MediumOrchid;
            }
            else
            {
                karta_akcji.Text = nowa_karta.ToString();
                karta_akcji.BackColor = Color.SeaShell;
            }
            usuniecie_losowosci(akcja_wynik_suma);
        }

        /// <summary>
        /// Jesli karta akcji jest magiczna, to po jej uzyciu, karta wyniku zmienia sie wedle wybranej operacji
        /// </summary>
        private void tekst_karty_wyniku()
        {
            if (wykonanie_karty)
            {
                if (karta_akcji.Text == "Do 1")
                {
                    karta_wyniku.Text = "1";
                }
                else if (karta_akcji.Text == "Do 10")
                {
                    karta_wyniku.Text = "10";
                }
                else if (karta_akcji.Text == "Do 20")
                {
                    karta_wyniku.Text = "20";
                }
                else
                {
                    karta_wyniku.Text = suma.ToString();
                }

            }
            else if (uzycie_karty_z_poczekalni)
            {
                if (poczekalnia_kart.Text == "Do 1")
                {
                    karta_wyniku.Text = "1";
                }
                else if (poczekalnia_kart.Text == "Do 10")
                {
                    karta_wyniku.Text = "10";
                }
                else if (poczekalnia_kart.Text == "Do 20")
                {
                    karta_wyniku.Text = "20";
                }
                else
                {
                    karta_wyniku.Text = suma.ToString();
                }
            }
            wykonanie_karty = false;
            uzycie_karty_z_poczekalni = false;

        }
        
        /// <summary>
        /// Obsluga przycisku "WYKONAJ DZIAlANIE". 
        /// Jesli w karcie akcji umieszczona jest jakas liczba, to po uzyciu tego przycisku obecna karta akcji jest dodawana do aktualnej karty wyniku.
        /// Jendoczesnie generowana jest nowa karta akcji i zmniejsza sie liczba dzialan w rundzie o jeden. 
        /// Metoda "czy_nastepna_runda()" sprawdzam, czy powinna juz nastapic wygrana, czy jeszcze nie. 
        /// Jesli suma liczb z karty akcji i z karty wyniku da liczbe spoza zakresu od 0 do 20, to pojawia sie komunikat o przegranej z mozliwoscia powtorzenia poziomu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wykonaj_dzialanie_Click(object sender, EventArgs e)
        {
            wykonanie_karty = true;
            if(karta_akcji.Text != "")
            {
                suma = suma_kart_akcja_wynik(karta_akcji.Text);
                if (akcje.sprawdzenie_zakresu(suma))
                {
                    tekst_karty_wyniku();
                    if(ile_dzialan <= 2 && poczekalnia_kart.Text != "")
                    {
                        karta_akcji.Text = "";
                    }
                    else
                    {
                        tekst_karty_akcji();
                    }
                    ile_dzialan--;
                    czy_nastepna_runda();
                }
                else
                {
                    zerowanie_kart();
                    if (MessageBox.Show("Przegrales\n Czy chcesz powtorzyc poziom?", "Przegrana", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        czas_timera = 0;
                        ustawianie_nowej_gry();
                    }
                    else
                    {
                        if (numer_rundy != 1)
                        {
                            menu.zapisz.Visible = this.Enabled = true;
                        }
                        this.Close();
                    }
                }
            }
        }

        /// <summary>
        /// Obsluga przycisku "ODloz KARTe".
        /// Jesli w poczekalni nie znajduje sie zadna innna karta, to mozemy odlozyc tam karte akcji. 
        /// Po odlozeniu karty akcji do poczekalni generowana jest nowa karta akcji, 
        /// chyba ze pozostalo tylko jedno dzialanie do konca rundy - w takim wypadku nie generujemy kolejnej karty akcji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void odloz_karte_Click(object sender, EventArgs e)
        {
            if (poczekalnia_kart.Text == "")
            {
                poczekalnia_kart.Text = karta_akcji.Text;
                poczekalnia_kart.BackColor = karta_akcji.BackColor;

                if (ile_dzialan >= 1)
                {
                    tekst_karty_akcji();
                }
                else
                {
                    karta_akcji.Text = "";
                }
                poczekalnia_kart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            }
        }

        /// <summary>
        /// Obsluga przycisku "WEz KARTe"
        /// Jesli w poczeklani kart znajduje sie jakas karta, to mozemy nacisnac przycisk - wez karte - aby jej uzyc.
        /// Sprawdzamy czy suma kart poczekalnia + wynik wyjdzie poza zakres od 0 do 20.
        /// Jesli wynik sumy znajduje sie w przedziale to karta z poczekalni dodawana jest do karty wyniku i zmniejsza sie liczba dzialan do konca rundy.
        /// Jesli natomiast suma wychodzi poza zadany zakres - to pojawia sie komunikat o przegranej grze z mozliwoscia powtorzenia poziomu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uzyj_karty_czekajacej_Click(object sender, EventArgs e)
        {
            uzycie_karty_z_poczekalni = true;
            if (poczekalnia_kart.Text != "")
            {
                poczekalnia_kart.BackColor = Color.SeaShell;
                suma = suma_kart_poczekalnia_wynik();
                if (akcje.sprawdzenie_zakresu(suma))
                {
                    tekst_karty_wyniku();
                    ile_dzialan--;
                    czy_nastepna_runda();
                }
                else
                {
                    zerowanie_kart();
                    if (MessageBox.Show("Przegrales\n Czy chcesz powtorzyc poziom?", "Przegrana", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        czas_timera = 0;
                        ustawianie_nowej_gry();
                    }
                    else
                    {
                        if (numer_rundy != 1)
                        {
                            menu.zapisz.Visible = this.Enabled = true;
                        }
                        this.Close();
                    }
                }
                poczekalnia_kart.Text = "";
            }
        }

        /// <summary>
        /// Mierzy czas podczas rundy i wypisuje go na ekran. Interwal zegara jest ustawiony na 50ms.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            czas_timera += 50;
            this.czas.Text = czas_timera.ToString() + " ms";
        }
    }
}
