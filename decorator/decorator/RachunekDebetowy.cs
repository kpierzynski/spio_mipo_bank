using state;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator
{
    internal class RachunekDebetowy : Rachunek
    {
        float debet = 0.0f;
        float debetLimit = 300.0f;

        public override float Saldo
        {
            get
            {
                return base.Saldo - debet;
            }
        }

        public RachunekDebetowy(string nazwa, float saldo, IMechanizmOdsetkowy mechanizm) : base(nazwa, saldo, mechanizm)
        {
           
        }

        public RachunekDebetowy(string nazwa, float saldo) : base(nazwa, saldo)
        {
        }

        public RachunekDebetowy(string nazwa) : base(nazwa)
        {
        }

        public override void zmienSaldo(float dSaldo)
        {
            if( base.Saldo + dSaldo < 0 )
            {
                //Brak pieniedzy na saldzie rachunku, trzeba uzyc debetu.
                float dodatkoweSaldo = (debetLimit - debet);
                
                if( base.Saldo + dSaldo + dodatkoweSaldo < 0 )
                {
                    //Limit debetu przekroczony, zgłaszamy blad
                    throw new Exception("Kwota przekroczyla debet.");
                } else
                {
                    debet -= base.Saldo + dSaldo;
                    base.zmienSaldo(-base.Saldo);
                }
            } else
            {
                //Pieniadze sa, uzywamy salda.
                base.zmienSaldo(dSaldo);
            }
        }
    }
}
