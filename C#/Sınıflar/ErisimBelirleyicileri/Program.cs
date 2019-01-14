
using Istanbul;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Istanbul
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Kartal kartal = new Kartal();
            kartal.Mahalle = "Yeni";
            kartal.Sokak = "Sokak";
            kartal.Cadde = "cadde";
            string hepsi=kartal.Hepsi;
            kartal.Hepsi = "aaaa";
            string hepsi2 = kartal.Hepsi;


        }
    }
}
