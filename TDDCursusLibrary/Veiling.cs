using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public class Veiling
    {
        private decimal hoogsteBodWaarde;
        public void DoeBod(decimal bedrag)
        {
            if (bedrag > Hoogstebod)
                hoogsteBodWaarde = bedrag;
        }
        public decimal Hoogstebod
        {
            get
            {
                return hoogsteBodWaarde;
            }
        }
    }
}
