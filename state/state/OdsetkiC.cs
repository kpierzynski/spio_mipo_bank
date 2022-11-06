using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state
{
    internal class OdsetkiC : IMechanizmOdsetkowy
    {
        public float oblicz(float saldo)
        {
            if (saldo > 100.0f && saldo < 500.0f) return saldo * 0.05f;
            if (saldo >= 500.0f) return saldo * 0.15f;

            return 0.0f;
        }

        public string opis()
        {
            return "Odseteczka C";
        }
    }
}
