using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TDDCursusLibrary
{
    public class ISBN
    {
        private static readonly Regex regex = new Regex("^\\d{13}$");
        public ISBN(long nummer)
        {
            this.isbnNummer = nummer;
        }
        private long isbnWaarde;
        public long isbnNummer
        {
            get
            {
                return isbnWaarde;
            }
            set
            {
                string waarde = value.ToString();
                if (!regex.IsMatch(waarde))
                    throw new ArgumentException();
                int oneven = 0;
                int even = 0;
                for (int i = 0; i < waarde.Length-1; i++)
                {
                    if (i % 2 == 0)
                        oneven += int.Parse(waarde[i].ToString());
                    else
                        even +=int.Parse(waarde[i].ToString())*3;
                }
                if (10 - (((oneven + even) % 10)) != value % 10)
                    throw new ArgumentException();
                isbnWaarde = value;
            }
        }
        public override string ToString()
        {
            return isbnWaarde.ToString();
        }
    }
}
