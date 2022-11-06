using decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state
{
    internal class Rachunek : IRachunek
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
            if ( saldo + dSaldo < 0.0f ) throw new Exception("Ujemne saldo!");
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
