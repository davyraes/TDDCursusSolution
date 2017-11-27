using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public class Persoon
    {
        private List<string> Voornamen { get; set; }

        public Persoon( List<string> voornamen)
        {
            if (voornamen.Count == 0)
                throw new ArgumentException();
            foreach (string voornaam in voornamen)
            {
                if (voornaam == null)
                    throw new ArgumentException();
                if (voornaam.ToArray().Count() == 0)
                    throw new ArgumentException();
                if (voornamen.IndexOf(voornaam) != voornamen.LastIndexOf(voornaam))
                    throw new ArgumentException();
            }
            Voornamen = voornamen; 
        }
        public override string ToString()
        {
            var voornamen = new StringBuilder();
            foreach (var voornaam in Voornamen)
            {
                voornamen.Append(voornaam);
                voornamen.Append(" ");
            }
             voornamen.Remove(voornamen.Length - 1, 1);
            return voornamen.ToString();
        }
    }
}
