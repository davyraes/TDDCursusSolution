using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public class LandService
    {
        public LandService(ILandDAO landDAO)
        {
            this.landDAO = landDAO;
        }
        private readonly ILandDAO landDAO;
        public decimal VerhoudingOppervlakteLandToOppervlakteAlleLanden(string landcode)
        {
            var land = landDAO.Read(landcode);
            var oppervlaktAlleLanden = landDAO.OppervlakteAllelanden();
            return (decimal)land.Oppervlakte / oppervlaktAlleLanden;
        }
    }
}
