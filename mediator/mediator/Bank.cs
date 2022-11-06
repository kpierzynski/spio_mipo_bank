using mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state
{
    internal class Bank
    {
        String nazwa;
        KrajowaIzbaRozliczeniowa kir;
        List<Rachunek> rachunki;

        public String Nazwa
        {
            get
            {
                return nazwa;
            }
        }

        public Bank(string nazwa, KrajowaIzbaRozliczeniowa kir)
        {
            this.nazwa = nazwa;
            this.kir = kir;
            rachunki = new List<Rachunek>();
        }

        public void stworzTransakcje(Transakcja t)
        {
            foreach (Rachunek rachunek in this.rachunki)
            {
                if (rachunek.Nazwa == t.RachunekNadawczy)
                {
                    rachunek.zmienSaldo(-t.Kwota);
                    t.BankNadawczy = this.Nazwa;
                    kir.wykonajTransakcje(t);
                    return;
                }
            }
        }

        public void dodajRachunek(Rachunek rachunek)
        {
            this.rachunki.Add(rachunek);
        }

        public void rozliczRachunek(Transakcja t)
        {
            foreach( Rachunek rachunek in this.rachunki )
            {
                if (rachunek.Nazwa == t.RachunekOdbiorczy)
                {
                    rachunek.zmienSaldo(t.Kwota);
                    return;
                }
            }

            t.zamien();
            this.kir.wykonajTransakcje(t);
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
