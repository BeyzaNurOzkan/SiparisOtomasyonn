using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyon
{
    public class Credit
    {
        private string Number { get; set; }
        private string ExpirationDate { get; set; }
        private int CVV { get; set; }

        public Credit(string Number, string ExpirationDate, int CVV)
        {
            this.Number = Number;
            this.ExpirationDate = ExpirationDate;
            this.CVV = CVV;
        }

        internal double Amount;
    }
}
