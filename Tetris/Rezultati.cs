using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace Tetris
{
    public partial class Rezultati : Form
    {
        private const string potTezka = @"rezultatiTezka.txt";
        private const string potLahka = @"rezultatiLahka.txt";
        private const string potSrednja = @"rezultatiSrednja.txt";
        private bool tezka = true;
        private bool srednja = false;
        private bool lahka = false;
        public Rezultati()
        {
            InitializeComponent();
        }

        private void NaloziRezultate(object sender, EventArgs e)
        {
            prikaziRezultate();
        }

        private void prikaziRezultate()
        {
            rezultatiListBox.Items.Clear();
            string pot;
            if (tezka)
            {
                pot = potTezka;
            }
            else if(srednja)
            {
                pot = potSrednja;
            }
            else
            {
                pot = potLahka;
            }

            List<Igralec> igralci = new List<Igralec>();
            try
            {
                StreamReader sr = new StreamReader(pot);
                string vrstica = sr.ReadLine();
                while (vrstica != null)
                {
                    string[] podatki = vrstica.Trim().Split('\t');
                    Igralec igralec = new Igralec(podatki[0], int.Parse(podatki[1]), DateTime.Parse(podatki[2]));
                    igralci.Add(igralec);
                    vrstica = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            igralci.Sort();
            foreach (Igralec igralec in igralci)
            {
                rezultatiListBox.Items.Add(igralec.ToString());
            }
        }

        private void PojdiNazaj(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void PrikaziLahka(object sender, MouseEventArgs e)
        {
            tezavnostLabel.Text = "Top 10 - Lahka";
            tezka = false;
            srednja = false;
            lahka = true;
            prikaziRezultate();
        }

        private void PrikaziSrednja(object sender, MouseEventArgs e)
        {
            tezavnostLabel.Text = "Top 10 - Srednja";
            srednja = true;
            tezka = false;
            lahka = false;
            prikaziRezultate();
        }

        private void PrikaziTezka(object sender, MouseEventArgs e)
        {
            tezavnostLabel.Text = "Top 10 - Težka";
            tezka = true;
            lahka = false;
            srednja = false;
            prikaziRezultate();
        }
    }
}
