using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServisVozila.Models
{
    public class PopisKlijenata
    {
        private List<Klijenti>listaKlijenata=new List<Klijenti>();
        private static bool listaInicijalizirana = false;

        public PopisKlijenata() 
        {
            if (listaInicijalizirana == false)
            {

            }

        }

        public List<Klijenti> VratiListu()
        {
            return listaKlijenata;
        }

       

    }
}