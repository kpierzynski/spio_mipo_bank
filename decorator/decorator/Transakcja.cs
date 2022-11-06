using mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediator
{
    internal class Transakcja
    {
        public string BankNadawczy { get; set; }
        public string BankOdbiorczy { get; set; }
        public string RachunekNadawczy { get; set; }
        public string RachunekOdbiorczy { get; set; }

        public float Kwota { get; set; }

        public void zamien()
        {
            string temp = this.BankNadawczy;
            this.BankNadawczy = this.BankOdbiorczy;
            this.BankOdbiorczy = temp;

            temp = this.RachunekNadawczy;
            this.RachunekNadawczy = this.RachunekOdbiorczy;
            this.RachunekOdbiorczy = temp;
        }
    }
}
