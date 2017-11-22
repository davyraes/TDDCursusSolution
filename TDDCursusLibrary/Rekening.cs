using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public class Rekening
    {
        private decimal saldoWaarde;
        public void storten(decimal bedrag)
        {
            if (bedrag <= decimal.Zero)
                throw new ArgumentException();
            saldoWaarde += bedrag;
        }
        public decimal Saldo
        { get
            {
                return saldoWaarde;
            }
        }
    }
}
