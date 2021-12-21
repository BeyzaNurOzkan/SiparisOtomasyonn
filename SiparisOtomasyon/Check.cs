using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyon
{
    public class Check : Payment
    {
        public string Name { get; set; }
        private string bankID { get; set; }

        public Check(string bankID)
        {
            this.bankID = bankID;
        }

        internal double Amount;
    }
}
