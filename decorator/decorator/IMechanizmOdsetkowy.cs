using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state
{
    internal interface IMechanizmOdsetkowy
    {
        float oblicz(float saldo);
        String opis();
    }
}
