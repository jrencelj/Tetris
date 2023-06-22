using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class Oblika
    {
        private Tocka zacetnaPozicija;
        private List<Tocka> tocke;
        private Color barva;

        public Oblika(Tocka zacetnaPozicija, OblikaTip oblikaTip)
        {
            switch (oblikaTip)
            {
                case OblikaTip.I:
                    barva = Color.Orange;
                    tocke = new List<Tocka>();
                    tocke.Add(new Tocka(zacetnaPozicija.X - 1, zacetnaPozicija.Y));
                    tocke.Add(new Tocka(zacetnaPozicija.X, zacetnaPozicija.Y));
                    tocke.Add(new Tocka(zacetnaPozicija.X + 1, zacetnaPozicija.Y));
                    tocke.Add(new Tocka(zacetnaPozicija.X + 2, zacetnaPozicija.Y));
                    break;

                case OblikaTip.L:
                    barva = Color.Yellow;
                    tocke = new List<Tocka>();
                    tocke.Add(new Tocka(zacetnaPozicija.X, zacetnaPozicija.Y + 1));
                    tocke.Add(new Tocka(zacetnaPozicija.X, zacetnaPozicija.Y));
                    tocke.Add(new Tocka(zacetnaPozicija.X + 1, zacetnaPozicija.Y));
                    tocke.Add(new Tocka(zacetnaPozicija.X + 2, zacetnaPozicija.Y));
                    break;

                case OblikaTip.Z:
                    barva = Color.Red;
                    tocke = new List<Tocka>();
                    tocke.Add(new Tocka(zacetnaPozicija.X, zacetnaPozicija.Y + 1));
                    tocke.Add(new Tocka(zacetnaPozicija.X, zacetnaPozicija.Y));
                    tocke.Add(new Tocka(zacetnaPozicija.X + 1, zacetnaPozicija.Y + 1));
                    tocke.Add(new Tocka(zacetnaPozicija.X - 1, zacetnaPozicija.Y));
                    break;

                case OblikaTip.O:
                    barva = Color.Green;
                    tocke = new List<Tocka>();
                    tocke.Add(new Tocka(zacetnaPozicija.X, zacetnaPozicija.Y + 1));
                    tocke.Add(new Tocka(zacetnaPozicija.X, zacetnaPozicija.Y));
                    tocke.Add(new Tocka(zacetnaPozicija.X + 1, zacetnaPozicija.Y + 1));
                    tocke.Add(new Tocka(zacetnaPozicija.X + 1, zacetnaPozicija.Y));
                    break;

                case OblikaTip.T:
                    barva = Color.Blue;
                    tocke = new List<Tocka>();
                    tocke.Add(new Tocka(zacetnaPozicija.X, zacetnaPozicija.Y + 1));
                    tocke.Add(new Tocka(zacetnaPozicija.X, zacetnaPozicija.Y));
                    tocke.Add(new Tocka(zacetnaPozicija.X - 1, zacetnaPozicija.Y));
                    tocke.Add(new Tocka(zacetnaPozicija.X + 1, zacetnaPozicija.Y));
                    break;

                case OblikaTip.S:
                    barva = Color.Purple;
                    tocke = new List<Tocka>();
                    tocke.Add(new Tocka(zacetnaPozicija.X, zacetnaPozicija.Y + 1));
                    tocke.Add(new Tocka(zacetnaPozicija.X, zacetnaPozicija.Y));
                    tocke.Add(new Tocka(zacetnaPozicija.X - 1, zacetnaPozicija.Y + 1));
                    tocke.Add(new Tocka(zacetnaPozicija.X + 1, zacetnaPozicija.Y));
                    break;
                case OblikaTip.P1:
                    barva = Color.DeepPink;
                    tocke = new List<Tocka>();
                    tocke.Add(new Tocka(zacetnaPozicija.X - 1, zacetnaPozicija.Y));
                    tocke.Add(new Tocka(zacetnaPozicija.X, zacetnaPozicija.Y));
                    tocke.Add(new Tocka(zacetnaPozicija.X + 1, zacetnaPozicija.Y));
                    tocke.Add(new Tocka(zacetnaPozicija.X, zacetnaPozicija.Y - 1));
                    tocke.Add(new Tocka(zacetnaPozicija.X - 1, zacetnaPozicija.Y - 1));
                    break;
                case OblikaTip.P2:
                    barva = Color.GreenYellow;
                    tocke = new List<Tocka>();
                    tocke.Add(new Tocka(zacetnaPozicija.X, zacetnaPozicija.Y - 1));
                    tocke.Add(new Tocka(zacetnaPozicija.X, zacetnaPozicija.Y));
                    tocke.Add(new Tocka(zacetnaPozicija.X + 1, zacetnaPozicija.Y));
                    tocke.Add(new Tocka(zacetnaPozicija.X, zacetnaPozicija.Y + 1));
                    tocke.Add(new Tocka(zacetnaPozicija.X + 1, zacetnaPozicija.Y + 1));
                    break;
                case OblikaTip.P3:
                    barva = Color.DarkTurquoise;
                    tocke = new List<Tocka>();
                    tocke.Add(new Tocka(zacetnaPozicija.X, zacetnaPozicija.Y - 1));
                    tocke.Add(new Tocka(zacetnaPozicija.X, zacetnaPozicija.Y));
                    tocke.Add(new Tocka(zacetnaPozicija.X - 1, zacetnaPozicija.Y - 1));
                    tocke.Add(new Tocka(zacetnaPozicija.X + 1, zacetnaPozicija.Y));
                    tocke.Add(new Tocka(zacetnaPozicija.X + 1, zacetnaPozicija.Y + 1));
                    break;
                case OblikaTip.P4:
                    barva = Color.SlateBlue;
                    tocke = new List<Tocka>();
                    tocke.Add(new Tocka(zacetnaPozicija.X - 1, zacetnaPozicija.Y));
                    tocke.Add(new Tocka(zacetnaPozicija.X, zacetnaPozicija.Y));
                    tocke.Add(new Tocka(zacetnaPozicija.X + 1, zacetnaPozicija.Y));
                    tocke.Add(new Tocka(zacetnaPozicija.X + 2, zacetnaPozicija.Y));
                    tocke.Add(new Tocka(zacetnaPozicija.X, zacetnaPozicija.Y + 1));
                    break;
            }
        }
        /// <summary>
        /// Premakne celotno obliko navzdol za 1.
        /// </summary>
        public void oblikaPremakni()
        {
            foreach (Tocka tocka in tocke)
            {
                tocka.premakniY(1);
            }
        }
        /// <summary>
        /// Premakne celotno obliko v desno za 1.
        /// </summary>
        public void oblikaPremakniDesno()
        {
            foreach (Tocka tocka in tocke)
            {
                tocka.premakniX(1);
            }
        }
        /// <summary>
        /// Premakne celotno obliko v levo za 1.
        /// </summary>
        public void oblikaPremakniLevo()
        {
            foreach (Tocka tocka in tocke)
            {
                tocka.premakniX(-1);
            }
        }
        /// <summary>
        /// Zarotira obliko v desno.
        /// </summary>
        public void rotirajLevo()
        {
            Tocka sredisceRotacije = tocke[1];
            foreach (Tocka tocka in tocke)
            {
                int x = (tocka.X - sredisceRotacije.X) * 0 + (tocka.Y - sredisceRotacije.Y) * (-1);
                int y = (tocka.X - sredisceRotacije.X) * 1 + (tocka.Y - sredisceRotacije.Y) * 0;
                tocka.X = x + sredisceRotacije.X;
                tocka.Y = y + sredisceRotacije.Y;
            }
        }
        /// <summary>
        /// Zarotira obliko v desno.
        /// </summary>
        public void rotirajDesno()
        {
            Tocka sredisceRotacije = tocke[1];
            foreach (Tocka tocka in tocke)
            {
                int x = (tocka.X - sredisceRotacije.X) * 0 + (tocka.Y - sredisceRotacije.Y) * 1;
                int y = (tocka.X - sredisceRotacije.X) * (-1) + (tocka.Y - sredisceRotacije.Y) * 0;
                tocka.X = x + sredisceRotacije.X;
                tocka.Y = y + sredisceRotacije.Y;
            }
        }
        /// <summary>
        /// Preveri ali se da obliko zarotirati levo.
        /// </summary>
        /// <returns>Vrne true/false.</returns>
        public bool jeRotabilenLevo()
        {
            Tocka sredisceRotacije = tocke[1];
            foreach (Tocka tocka in tocke)
            {
                int x = (tocka.X - sredisceRotacije.X) * 0 + (tocka.Y - sredisceRotacije.Y) * (-1);
                int y = (tocka.X - sredisceRotacije.X) * 1 + (tocka.Y - sredisceRotacije.Y) * 0;
                x = x + sredisceRotacije.X;
                y = y + sredisceRotacije.Y;
                if (x < 0 || x > 14)
                    return false;
                if (y < 0 || y > 24)
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Preveri ali se da obliko zarotirati desno.
        /// </summary>
        /// <returns>Vrne true/false.</returns>
        public bool jeRotabilenDesno()
        {
            Tocka sredisceRotacije = tocke[1];
            foreach (Tocka tocka in tocke)
            {
                int x = (tocka.X - sredisceRotacije.X) * 0 + (tocka.Y - sredisceRotacije.Y) * 1;
                int y = (tocka.X - sredisceRotacije.X) * (-1) + (tocka.Y - sredisceRotacije.Y) * 0;
                x = x + sredisceRotacije.X;
                y = y + sredisceRotacije.Y;
                if (x < 0 || x > 14)
                    return false;
                if (y < 0 || y > 24)
                    return false;
            }
            return true;
        }
        /// <summary>
        /// Funkcija, ki preveri ali je možen premik v desno in vrne true/false.
        /// </summary>
        public bool premikDesno()
        {
            foreach (Tocka tocka in tocke)
            {
                if (tocka.X + 1 > 14)
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Funkcija, ki preveri ali je možen premik v levo in vrne true/false.
        /// </summary>
        public bool premikLevo()
        {
            foreach (Tocka tocka in tocke)
            {
                if (tocka.X - 1 < 0)
                {
                    return false;
                }
            }
            return true;
        }
        public Color getBarva()
        {
            return this.barva;
        }
        public List<Tocka> getTocke()
        {
            return this.tocke;
        }
    }
}
