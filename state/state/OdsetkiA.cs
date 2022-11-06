using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state
{
    internal class OdsetkiA : IMechanizmOdsetkowy
    {
        public float oblicz(float saldo)
        {
            return (float)(saldo * 0.1);
        }

        public string opis()
        {
            return "Jestem odsetką A";
        }
    }
}
