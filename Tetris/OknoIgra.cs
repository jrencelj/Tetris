using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public partial class OknoIgra : Form
    {
        private const int velikostKvadrata = 20;
        private const int sirinaPlatna = 300;
        private const int visinaPlatna = 500;
        private const int stKvadratovSirina = 15;
        private const int stKvadratovVisina = 25;
        private Igra igra;
        public OknoIgra()
        {
            InitializeComponent();
            rezultatLabel.Text = $"Rezultat: 0";
            Cas.Start();
            CasH.Start();
            this.KeyPreview = true;
        }
        public Igra Igra 
        { 
            get { return igra; }
            set { igra = value; }
        }
        private void Narisi(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            
            // Risanje mreže
            g.FillRectangle(new SolidBrush(Color.LightGray), new Rectangle(velikostKvadrata, velikostKvadrata, sirinaPlatna, visinaPlatna));

            // Risanje območja.
            for (int i = 0; i < stKvadratovVisina; i++)
            {
                for (int j = 0; j < stKvadratovSirina; j++)
                {
                    if (!igra.Obmocje[i, j].IsEmpty)
                    {
                        Color barva = igra.Obmocje[i, j];
                        Color obroba = Color.Black;
                        g.FillRectangle(new SolidBrush(barva),
                            new Rectangle(velikostKvadrata + velikostKvadrata * j,
                            velikostKvadrata + velikostKvadrata * i,
                            velikostKvadrata, velikostKvadrata));
                        g.DrawRectangle(new Pen(obroba),
                            new Rectangle(velikostKvadrata + velikostKvadrata * j,
                            velikostKvadrata + velikostKvadrata * i,
                            velikostKvadrata, velikostKvadrata));
                    }
                }
            }

            // Risanje padajoče oblike
            foreach (Tocka tocka in igra.Oblika.getTocke())
            {
                if (tocka.Y >= 0)
                {
                    g.FillRectangle(new SolidBrush(igra.Oblika.getBarva()),
                        new Rectangle(velikostKvadrata + velikostKvadrata * tocka.X,
                        velikostKvadrata + velikostKvadrata * tocka.Y,
                        velikostKvadrata, velikostKvadrata));
                    g.DrawRectangle(new Pen(Color.Black),
                        new Rectangle(velikostKvadrata + velikostKvadrata * tocka.X,
                        velikostKvadrata + velikostKvadrata * tocka.Y,
                        velikostKvadrata, velikostKvadrata));
                }
            }

            // Risanje mreže
            if (igra.Tezavnost == "lahka" || igra.Tezavnost == "srednja")
            {
                for (int i = velikostKvadrata; i <= velikostKvadrata + sirinaPlatna; i = i + velikostKvadrata)
                {
                    g.DrawLine(new Pen(Color.Black), i, velikostKvadrata, i, velikostKvadrata + visinaPlatna);
                }

                for (int i = velikostKvadrata; i <= velikostKvadrata + visinaPlatna; i = i + velikostKvadrata)
                {
                    g.DrawLine(new Pen(Color.Black), velikostKvadrata, i, sirinaPlatna + velikostKvadrata, i);
                }
            }


            // Naslednja oblika
            if (Igra.Tezavnost != "tezka")
            {
                int sirinaMaloOkno = 10;
                int visinaMaloOkno = 7;
                g.FillRectangle(new SolidBrush(Color.LightGray),
                    new Rectangle(velikostKvadrata + sirinaPlatna + 100, velikostKvadrata, sirinaMaloOkno * velikostKvadrata, visinaMaloOkno * velikostKvadrata));

                // Naslednja oblika - figura
                // Začetna pozicija naslednje figure

                int zacetekMaliKvadratX = velikostKvadrata + sirinaPlatna + 100; // x-kooridnata malega okna.
                int zacetekMaliKvadratY = velikostKvadrata; // y-koordinata malega okna.

                foreach (Tocka tocka in igra.NaslednjaOblika.getTocke())
                {
                    g.FillRectangle(new SolidBrush(igra.NaslednjaOblika.getBarva()),
                        new Rectangle(
                            zacetekMaliKvadratX + 5 * velikostKvadrata + (tocka.X - 5) * velikostKvadrata,
                            zacetekMaliKvadratY + 3 * velikostKvadrata + (tocka.Y + 2) * velikostKvadrata,
                            velikostKvadrata,
                            velikostKvadrata
                            ));
                }
                // Naslednje oblika - mreža


                for (int i = 0; i <= sirinaMaloOkno; i++)
                {
                    g.DrawLine(new Pen(Color.Black), zacetekMaliKvadratX + i * velikostKvadrata, velikostKvadrata, zacetekMaliKvadratX + i * velikostKvadrata, velikostKvadrata + visinaMaloOkno * velikostKvadrata);
                }

                for (int i = 0; i <= visinaMaloOkno; i++)
                {
                    g.DrawLine(new Pen(Color.Black), zacetekMaliKvadratX, zacetekMaliKvadratY + i * velikostKvadrata, zacetekMaliKvadratX + sirinaMaloOkno * velikostKvadrata, zacetekMaliKvadratY + i * velikostKvadrata);
                }
            }

        }
        /// <summary>
        /// Nastavi interval premikanja oblike, glede na težavnost igre.
        /// </summary>
        /// <param name="tezavnost">Težavnost igre (lahka, srednja, tezka).</param>
        public void NastaviCas(string tezavnost)
        {
            tezavnostLabel.Text = $"Težavnost = {tezavnost.ToUpperInvariant()}";
            if (tezavnost == "lahka")
                Cas.Interval = 500;
            else
                Cas.Interval = 250;
        }
        private void Casovnik(object sender, EventArgs e)
        {
            bool premik = true; // Oblika se lahko premakne.
            foreach (Tocka tocka in igra.Oblika.getTocke())
            {
                // Točka je na vidnem polju.
                if (tocka.Y >= 0)
                {
                    // Preverimo ali je točka prišla do mesta ko se ne more več premakniti navzdol.
                    if (tocka.Y + 1 >= stKvadratovVisina || !igra.Obmocje[tocka.Y + 1, tocka.X].IsEmpty)
                    {
                        // Preverimo ali katera točka oblike ni na območju.
                        foreach (Tocka t in igra.Oblika.getTocke())
                        {
                            if (t.Y < 0)
                            {
                                igra.IgraKonec = true; // Igre je konec.
                                premik = false; // Se ne more več premakniti
                                // Cas.Stop();
                            }
                            else
                            {
                                // Nastavimo barve na območju.
                                igra.Obmocje[t.Y, t.X] = igra.Oblika.getBarva();
                            }
                        }
                        igra.odstraniPolneVrstice(); // Odstranimo polne.
                        rezultatLabel.Text = $"Rezultat: {igra.Tocke}";
                        premik = false; // Oblika je na končnem mestu.
                        NastaviCas(igra.Tezavnost); // Ponastavimo interval padanja.
                        if (igra.IgraKonec)
                        {
                            Cas.Stop();
                            prikaziMessageBox();
                            igra.NastaviObmocje();
                            igra.ShraniIgra();
                            igra.IgraKonec = false;
                        }
                        break;
                    }
                }
                // Igre je konec
                else if (tocka.Y < 0)
                {
                    foreach (Tocka t in igra.Oblika.getTocke())
                    {
                        if (tocka.Y + 1 < 0)
                        {
                            continue;
                        }
                        // Vrh je poln
                        if (!igra.Obmocje[tocka.Y + 1, tocka.X].IsEmpty)
                        {
                            igra.IgraKonec = true;
                            break;
                            // igra.NastaviObmocje();
                        }
                    }
                }
                if (igra.IgraKonec)
                {
                    Cas.Stop();
                    igra.NastaviObmocje();
                    igra.ShraniIgra();
                    prikaziMessageBox();
                    break;
                }
            }
            // Oblika se lahko premakne navzdol.
            if (premik)
            {
                igra.Oblika.oblikaPremakni();
            }
            // Vzamemo novo obliko.
            else
            {
                igra.Oblika = igra.NaslednjaOblika;
                igra.NaslednjaOblika = igra.PridobiNaslednjoObliko();
            }
            this.Invalidate();
        }

        private void CasovnikHorizontalno(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Premik(object sender, KeyPressEventArgs e)
        {
            if (Cas.Enabled)
            {
                if (e.KeyChar == 'A' || e.KeyChar == 'a')
                {
                    if (igra.jePremakljivLevo())
                    {
                        igra.Oblika.oblikaPremakniLevo();
                    }
                }
                else if (e.KeyChar == 'D' || e.KeyChar == 'd')
                {
                    if (igra.jePremakljivDesno())
                    {
                        igra.Oblika.oblikaPremakniDesno();
                    }
                }
                else if (e.KeyChar == 'Q' || e.KeyChar == 'q')
                {
                    if (igra.Oblika.jeRotabilenLevo())
                    {
                        igra.Oblika.rotirajLevo();
                    }
                }
                else if (e.KeyChar == 'E' || e.KeyChar == 'e')
                {
                    if (igra.Oblika.jeRotabilenDesno())
                    {
                        igra.Oblika.rotirajDesno();
                    }
                }
                else if (e.KeyChar == 'S' || e.KeyChar == 's')
                {
                    Cas.Interval = 10;
                }
            }
        }
        /// <summary>
        /// Gumb za ustavitev igre.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pause(object sender, MouseEventArgs e)
        {
            if (Cas.Enabled)
            {
                Cas.Stop();
                pauseButton.Text = "Nadaljuj";
            }
            else
            {
                Cas.Start();
                pauseButton.Text = "Ustavi";
            }
        }

        private void ZapustiIgro(object sender, MouseEventArgs e)
        {
            igra.ShraniIgra();
            this.Close();
        }
        // MESSAGE BOX
        /// <summary>
        /// Prikaže Dialog Box ob koncu igre.
        /// </summary>
        private void prikaziMessageBox()
        {
            string sporocilo = $"Konec igre, zbrali ste {igra.Tocke} točk!";
            string naslov = "Konec";
            MessageBoxButtons gumb = MessageBoxButtons.OK;
            DialogResult odziv = MessageBox.Show(sporocilo, naslov, gumb);
            if (odziv == DialogResult.OK) 
            {
                this.Close();
            }
        }
    }
}
