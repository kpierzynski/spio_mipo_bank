using state;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator
{
    internal class RachunekDebetowy : IRachunek
    {
        float debet;
        float debetLimit = 300.0f;

        Rachunek rachunek;
        public RachunekDebetowy()
        {

        }

        public void zmienSaldo(float dSaldo)
        {
            throw new NotImplementedException();
        }
    }
}
