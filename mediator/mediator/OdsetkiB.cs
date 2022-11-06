using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state
{
    internal class OdsetkiB : IMechanizmOdsetkowy
    {
        public float oblicz(float saldo)
        {
            return (saldo > 1000.0f) ? saldo * 0.2f : saldo * 0.1f;
        }

        public string opis()
        {
            return "A ja jestem odsetką B";
        }
    }
}
