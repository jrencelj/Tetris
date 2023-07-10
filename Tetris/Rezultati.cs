using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tetris
{
    public partial class Rezultati : Form
    {
        private const string pot = @"rezultati.txt";
        public Rezultati()
        {
            InitializeComponent();
        }

        private void NaloziRezultate(object sender, EventArgs e)
        {
            List<Igralec> igralci = new List<Igralec>();
            try
            {
                StreamReader sr = new StreamReader(pot);
                string vrstica = sr.ReadLine();
                while (vrstica != null)
                {
                    string[] podatki = vrstica.Trim().Split(',');
                    Igralec igralec = new Igralec(podatki[0], int.Parse(podatki[1]));
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
    }
}
