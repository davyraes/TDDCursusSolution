using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public class Woord
    {
        public Woord(string woord)
        {
            this.woord = woord;
        }
        public string  woord { get; set; }
        public bool IsPalindroom()
        {
            string omgekeerd = new string(woord.ToArray().Reverse().ToArray());
            return woord == omgekeerd;
        }
    }
}
