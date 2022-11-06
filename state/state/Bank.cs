using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state
{
    internal class Bank
    {
        List<Rachunek> rachunki;
        public Bank()
        {
            rachunki = new List<Rachunek>();

            rachunki.Add(new Rachunek("Agnieszka", 1000.5f, new OdsetkiA()));
            rachunki.Add(new Rachunek("Ania", 50.0f, new OdsetkiC()));

        }

        public void pokazOdsetkiRachunkow()
        {
            foreach( Rachunek rachunek in this.rachunki )
            {
                Console.WriteLine(rachunek.Nazwa + " " + rachunek.Saldo.ToString() + " " + rachunek.opisOdsetki() + " " + rachunek.obliczOdsetki() );
            }
        }

    }
}
