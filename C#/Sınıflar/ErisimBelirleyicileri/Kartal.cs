using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Istanbul
{
    class Kartal
    {
        public string Mahalle { get; set; }
        public string Sokak { get; set; }
        internal string Cadde { get; set; }
        private string hepsi;

        public string Hepsi
        {
            get
            {
                return Mahalle + " " + Sokak + " " + Cadde;
            }

            set
            {
                hepsi = value;
            }
        }

        public void Yazdir()
        {

        }
        private void Yazdir2()
        {

        }
        internal void Yazdir3()
        {

        }
    }
}
