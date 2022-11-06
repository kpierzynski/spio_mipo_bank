using state;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediator
{
    internal class KrajowaIzbaRozliczeniowa
    {
        Dictionary<string, Bank> banki;

        public KrajowaIzbaRozliczeniowa()
        {
            banki = new Dictionary<string, Bank>();
        }

        public void zarejestrujBank(Bank bank)
        {
            banki.Add(bank.Nazwa, bank);
        }

        public void wykonajTransakcje(Transakcja t)
        {
            try
            {
                Bank b = banki[t.BankOdbiorczy];

                b.rozliczRachunek(t);
            } catch( Exception e )
            {
                Bank n = banki[t.BankNadawczy];
                t.zamien();
                n.rozliczRachunek(t);
            }
        }
    }
}
