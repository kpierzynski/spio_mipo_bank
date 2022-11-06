using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state
{
    internal class Rachunek
    {
        float saldo = 0;
        string nazwa;
        IMechanizmOdsetkowy mechanizm = new OdsetkiA();

        public float Saldo
        {
            get
            {
                return saldo;
            }
        }

        public String Nazwa
        {
            get
            {
                return nazwa;
            }
        }

        public Rachunek(string nazwa, float saldo, IMechanizmOdsetkowy mechanizm)
        {
            this.nazwa = nazwa;
            this.saldo = saldo;
            this.mechanizm = mechanizm;
        }

        public Rachunek(string nazwa, float saldo)
        {
            this.nazwa = nazwa;
            this.saldo = saldo;
        }

        public Rachunek(string nazwa)
        {
            this.nazwa = nazwa;
        }

        public void zmienSaldo( float dSaldo )
        {
            saldo += dSaldo;
        }

        public float obliczOdsetki()
        {
            return mechanizm.oblicz(this.saldo);
        } 

        public String opisOdsetki()
        {
            return mechanizm.opis();
        }

        public void ustawOdsetki(IMechanizmOdsetkowy mechanizm)
        {
            this.mechanizm = mechanizm;
        }
    }
}
