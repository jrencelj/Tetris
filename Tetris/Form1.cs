using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Tetris
{
    public partial class Okno : Form
    {
        private const int velikostKvadrata = 20;
        private const int sirinaPlatna = 300;
        private const int visinaPlatna = 500;
        private Color[,] obmocje;
        private Oblika oblika = new Oblika(new Tocka(5, -2), OblikaTip.L);
        private Oblika naslednjaOblika = new Oblika(new Tocka(5, -2), OblikaTip.T);
        static Random random = new Random();
        public Okno()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void PricniIgro(object sender, MouseEventArgs e)
        {
            Nastavitve nastavitveIgre = new Nastavitve();
            nastavitveIgre.Show();
            // OknoIgra oknoIgra = new OknoIgra();
            // oknoIgra.Show();
        }

        private void ZapriOkno(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void PrikaziRezultate(object sender, MouseEventArgs e)
        {
            Rezultati oknoRezultati = new Rezultati();
            oknoRezultati.Show();
        }
    }
}
