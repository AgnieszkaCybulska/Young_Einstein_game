using System;
using System.Collections;
using System.Collections.Generic;

namespace Young_Einstein
{
    class Akcje_kart
    {
            /// <summary>
            /// Generuje liste kart mozliwych do wylosowania.
            /// </summary>
            /// <returns>Zwracana jest lista kart podstawowych (od -7 do 7 bez 0)</returns>
            public static List<int> zestaw_kart()
            {
                List<int> lista_kart = new List<int>();
                for (int wartosc = -7; wartosc < 7; wartosc++)
                {
                    lista_kart.Add(wartosc);
                }
                lista_kart.Remove(0);

                return lista_kart;
            }

            /// <summary>
            /// Do listy kart podstawowych dodaje karty magiczne.
            /// </summary>
            /// <param name="lista_kart"></param>
            /// <returns>Zwraca zaktualizowana liste kart o karty magiczne</returns>
            public static List<int> karty_magiczne(List<int> lista_kart)
            {
                lista_kart.Add(100);
                lista_kart.Add(2000);
                lista_kart.Add(1000);

                return lista_kart;
            }

            /// <summary>
            /// Losuje wartosc karty sposrod podanego zestawu kart.
            /// </summary>
            /// <param name="karty"></param>
            /// <returns>Zwraca calkowita liczbe oznaczajaca wartosc karty</returns>
            
        public static int generowanie_karty(List<int> karty)
        {
            Random random = new Random();
            int wartosc_karty;
            int indeks_karty;
            indeks_karty = random.Next(karty.Count);
            wartosc_karty = (int)karty[indeks_karty];

            return wartosc_karty;
        }

        /// <summary>
        /// Sprawdza czy otrzymana liczba wyniku miesci sie w zakresie od 0 do 20.
        /// </summary>
        /// <param name="suma"></param>
        /// <returns>Zwraca wartosc logiczna true jesli wprowadzona liczba znajduje sie w zakresie i false i jesli wyszla poza zakres.</returns>
        public Boolean sprawdzenie_zakresu(int suma)
            {
                Boolean wykonuj_dalej = true;
                if (suma < 0 || suma > 20)
                {
                    wykonuj_dalej = false;
                }

                return wykonuj_dalej;
            }
        }
}
