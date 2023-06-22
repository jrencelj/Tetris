using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace Tetris
{
    public partial class Rezultati : Form
    {
        private const string pot = @"rezultati.json";
        public Rezultati()
        {
            InitializeComponent();
        }

        private void NaloziRezultate(object sender, EventArgs e)
        {
            List<Igralec> igralci;
            if (File.Exists(pot))
            {
                using (StreamReader sr = new StreamReader(pot))
                {
                    string vsebina = sr.ReadToEnd();
                    igralci = JsonSerializer.Deserialize<List<Igralec>>(vsebina);
                }
                igralci.Sort();
                foreach (Igralec igralec in igralci)
                {
                    rezultatiListBox.Items.Add($"{igralec.Ime} {igralec.Tocke}");
                }
            }
        }

        private void PojdiNazaj(object sender, MouseEventArgs e)
        {
            Close();
        }
    }
}
