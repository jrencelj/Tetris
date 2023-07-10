using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tetris
{
    
    public class Igralec:IComparable<Igralec>
    {
        private string ime;
        private int tocke;
        public Igralec(string ime, int tocke)
        {
            Ime = ime;
            Tocke = tocke;
        }
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        public int Tocke
        {   
            get { return tocke; } 
            set { tocke = value; } 
        }
        /// <summary>
        /// Metoda za primerjanje objektov razreda Igralec.
        /// </summary>
        /// <param name="other">Objekt razreda igralec.</param>
        /// <returns></returns>
        public int CompareTo(Igralec other) 
        {
            if (other.Tocke > this.Tocke) return 1;
            else if (other.Tocke < this.Tocke) return -1;
            else return 0;
        }
        public override string ToString() 
        {
            return $"{Ime} : {Tocke}";
        }
    }
}
