using System;
using System.IO;
using System.Drawing;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Tetris
{
    public class Igra
    {
        private string igralec;
        private const string pot = @"rezultati.json";
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
            obmocje = new Color[25, 15];
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

        public void PonastaviIgro()
        {

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
            for (int j = 0; j < 15; j++)
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
            for (int i = 0; i < 15; i++)
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
            if (Tezavnost == "tezka" || Igralec != "")
            {
                List<Igralec> igralci = new List<Igralec>();
                string json;
                if (File.Exists(pot))
                {
                    using (StreamReader sr = new StreamReader(pot))
                    {
                        string vsebina = sr.ReadToEnd();
                        igralci = JsonSerializer.Deserialize<List<Igralec>>(vsebina);
                    }
                    igralci.Sort();
                    Igralec igralec = new Igralec(Igralec, Tocke);
                    if (igralci.Count == 10)
                    {
                        int zamenjaj = 10;
                        for (int i = 0; i < igralci.Count; i++)
                        {
                            if (igralci[i].Tocke < igralec.Tocke)
                            {
                                zamenjaj = i;
                                break;
                            }
                        }
                        // Je primeren za seznam top 10.
                        if (zamenjaj < 10)
                        {
                            igralci.Insert(zamenjaj, igralec);
                            igralci = igralci.GetRange(0, 9);
                            json = JsonSerializer.Serialize(igralci);
                            File.WriteAllText(pot, json);
                        }
                    }
                    // Na seznamu še ni 10 igralcev.
                    else
                    {
                        igralci.Add(igralec);
                        json = JsonSerializer.Serialize(igralci);
                        File.WriteAllText(pot, json);
                    }


                }
                else
                {
                    igralci.Add(new Igralec(Igralec, Tocke));
                    json = JsonSerializer.Serialize(igralci);
                    File.WriteAllText(pot, json);
                }
            }
        }
        /// <summary>
        /// Odstrani polne vrstice in jih nadomesti z gornjimi vrsticami.
        /// </summary>
        public void odstraniPolneVrstice()
        {
            for (int vrstica = 24; vrstica >= 0; vrstica--)
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
