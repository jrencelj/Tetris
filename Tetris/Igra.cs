using System;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using System.Data.SqlTypes;

namespace Tetris
{
    public class Igra
    {
        private string igralec;
        private const string potTezka = @"rezultatiTezka.txt";
        private const string potLahka = @"rezultatiLahka.txt";
        private const string potSrednja = @"rezultatiSrednja.txt";
        private const int STEVILO_KOLON = 15;
        private const int STEVILO_VRSTIC = 25;
        private int tocke = 0;
        private bool igraKonec = false;
        private Color[,] obmocje;
        private string tezavnost;
        static Random random = new Random();
        private Oblika oblika = new Oblika(new Tocka(5, -2), OblikaTip.L);
        private Oblika naslednjaOblika = new Oblika(new Tocka(5, -2), OblikaTip.T);

        public Igra()
        {
            NastaviObmocje();
        }
        public string Tezavnost
        {
            get { return tezavnost; }
            set { tezavnost = value; }
        }
        public string Igralec
        {
            get { return igralec; }
            set { igralec = value; }
        }

        public int Tocke
        {
            get { return tocke; }
            set { tocke = value; }
        }

        public bool IgraKonec
        {
            get { return igraKonec; }
            set { igraKonec = value; }
        }

        public Oblika Oblika
        { 
            get { return oblika; } 
            set { oblika = value; }
        }  
        
        public Oblika NaslednjaOblika
        {
            get { return naslednjaOblika; }
            set { naslednjaOblika = value; }
        }


        public Color[,] Obmocje
        {
            get { return obmocje; }
            set { obmocje = value; }
        }

        public void NastaviObmocje()
        {
            obmocje = new Color[STEVILO_VRSTIC, STEVILO_KOLON];
        }

        public Oblika PridobiNaslednjoObliko()
        {
            if (Tezavnost == "tezka")
            {
                Array vrednosti = Enum.GetValues(typeof(OblikaTip));
                OblikaTip oblikaTip = (OblikaTip)vrednosti.GetValue(random.Next(vrednosti.Length));
                naslednjaOblika = new Oblika(new Tocka(5, -2), oblikaTip);
            }
            else if (Tezavnost == "lahka" || Tezavnost == "srednja")
            {
                Array vrednosti = Enum.GetValues(typeof(OblikaTip));
                OblikaTip oblikaTip = (OblikaTip)vrednosti.GetValue(random.Next(vrednosti.Length - 4));
                naslednjaOblika = new Oblika(new Tocka(5, -2), oblikaTip);
            }
            return naslednjaOblika;
        }

        /// <summary>
        /// Preveri ali se oblika lahko premakne levo oz. če je območje še prosto.
        /// </summary>
        /// <returns>Vrne true/false.</returns>
        public bool jePremakljivLevo()
        {
            if (!oblika.premikLevo())
            {
                return false;
            }
            foreach (Tocka tocka in oblika.getTocke())
            {
                int x = tocka.X;
                int y = tocka.Y;
                if (y < 0)
                {
                    continue;
                }
                if (!obmocje[y, x - 1].IsEmpty)
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Preveri ali se oblika lahko premakne desno oz. če je območje še prosto.
        /// </summary>
        /// <returns>Vrne true/false.</returns>
        public bool jePremakljivDesno()
        {
            if (!oblika.premikDesno())
            {
                return false;
            }
            foreach (Tocka tocka in oblika.getTocke())
            {
                int x = tocka.X;
                int y = tocka.Y;
                if (y < 0)
                {
                    continue;
                }
                if (!obmocje[y, x + 1].IsEmpty)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Preveri ali je vrstica polna.
        /// </summary>
        /// <param name="i">Indeks vrstice.</param>
        /// <returns>Vrne true/false.</returns>
        public bool polnaVrstica(int vrstica)
        {
            for (int j = 0; j < STEVILO_KOLON; j++)
            {
                if (obmocje[vrstica, j].IsEmpty)
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Zapolni prazne vrstice.
        /// </summary>
        /// <param name="vrstica">Indeks polne vrstice.</param>
        public void premakniVrstice(int vrstica)
        {
            for (int i = 0; i < STEVILO_KOLON; i++)
            {
                for (int j = vrstica; j > 0; j--)
                {
                    obmocje[j, i] = obmocje[j - 1, i];
                }
                obmocje[0, i] = Color.Empty;
            }
        }
        /// <summary>
        /// Shranimo rezultat igre.
        /// </summary>
        public void ShraniIgra()
        {
            string pot;
            if (Tezavnost == "lahka")
            {
                pot = potLahka;
            }
            else if (Tezavnost == "srednja")
            {
                pot = potSrednja;
            }
            else
            {
                pot = potTezka;
            }
            if (!File.Exists(pot) && Igralec != "")
            {
                using (StreamWriter sw = File.CreateText(pot))
                {
                    sw.WriteLine($"{Igralec}\t{Tocke}\t{DateTime.Now}");
                }
            }
            else if (File.Exists(pot) &&  Igralec != "")
            {
                List<Igralec> igralci = new List<Igralec>();
                using (StreamReader sr = File.OpenText(pot))
                {
                    string vrstica = "";
                    while ((vrstica = sr.ReadLine()) != null)
                    {
                        string[] podatki = vrstica.Trim().Split('\t');
                        Igralec igralec = new Igralec(podatki[0], int.Parse(podatki[1]), DateTime.Parse(podatki[2]));
                        igralci.Add(igralec);
                    }
                }
                igralci.Add(new Igralec(Igralec, Tocke, DateTime.Now));
                igralci.Sort();
                if (igralci.Count < 10)
                {
                    using (StreamWriter sw = File.CreateText(pot))
                    {
                        foreach (Igralec igralec in igralci)
                        {
                            sw.WriteLine(igralec.ToString());
                        }
                    }
                }
                else
                {
                    using (StreamWriter sw = File.CreateText(pot))
                    {
                        int stevec = 0;
                        while (stevec < 10)
                        {
                            Igralec igralec = igralci[stevec];
                            sw.WriteLine(igralec.ToString());
                            stevec++;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Odstrani polne vrstice in jih nadomesti z gornjimi vrsticami.
        /// </summary>
        public void odstraniPolneVrstice()
        {
            for (int vrstica = STEVILO_VRSTIC - 1; vrstica >= 0; vrstica--)
            {
                if (polnaVrstica(vrstica))
                {
                    premakniVrstice(vrstica);
                    vrstica++;
                    tocke++;
                }
            }
        }

    }
}
