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
    public partial class Nastavitve : Form
    {
        private Igra igra;
        public Nastavitve()
        {
            Igra = new Igra();
            InitializeComponent();
        }
        public Igra Igra 
        { 
            get { return igra; }
            set { igra = value; }
        }
        private void PricniIgro(object sender, MouseEventArgs e)
        {
            OknoIgra oknoIgra = new OknoIgra();
            oknoIgra.Igra = Igra;
            oknoIgra.Igra.Igralec = uporabnikTextBox.Text;
            if (lahkaRB.Checked) 
            {
                oknoIgra.Igra.Tezavnost = "lahka";
            }
            else if (srednjaRB.Checked) 
            {
                oknoIgra.Igra.Tezavnost = "srednja";
            }
            else
            {
                oknoIgra.Igra.Tezavnost = "tezka";
            }
            oknoIgra.NastaviCas(oknoIgra.Igra.Tezavnost);
            oknoIgra.Show();
            Close();
        }

        private void OmogociUporabnika(object sender, EventArgs e)
        {
            uporabnikTextBox.Enabled = true;
        }

        private void OnemogociUpLahka(object sender, EventArgs e)
        {
            uporabnikTextBox.Enabled = false;
        }

        private void OnemogociUpSrednja(object sender, EventArgs e)
        {
            uporabnikTextBox.Enabled = false;
        }
    }
}
