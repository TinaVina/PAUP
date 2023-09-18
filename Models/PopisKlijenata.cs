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

                listaInicijalizirana = true;

                listaKlijenata.Add(new Klijenti()
                {
                    id = 1,
                    oib = "14673829841",
                    ime = "Ivan",
                    prezime = "Martan",
                    modelVozila = Modeli.A4,
                    kvarNaVozilu = "Zamijena ulja"


                }
            ) ;


                listaKlijenata.Add(new Klijenti()
                {
                    id = 1,
                    oib = "37587396857",
                    ime = "Marta",
                    prezime = "Mislavić",                 
                    modelVozila = Modeli.Q3,
                    kvarNaVozilu = "Zamijena vodene pumpe"


                }
                );

                listaKlijenata.Add(new Klijenti()
                {
                    id = 1,
                    oib = "84738475643",
                    ime = "Marko",
                    prezime = "Tomšić", 
                    modelVozila = Modeli.A3,
                    kvarNaVozilu = "Popravak fara"


                }
                );

                listaKlijenata.Add(new Klijenti()
                {
                    id = 1,
                    oib = "37463839050",
                    ime = "Nikolina",
                    prezime = "Lukša",                  
                    modelVozila = Modeli.A5,
                    kvarNaVozilu = "Zamijena filtera klime"


                }
                );

            }

        }

        public List<Klijenti> VratiListu()
        {
            return listaKlijenata;
        }

        public void AzurirajStudenta(Klijenti klijent)
        {
            int studentIndex = listaKlijenata.FindIndex(s => s.id == klijent.id);
            listaKlijenata[studentIndex] = klijent;
        }

    }
}