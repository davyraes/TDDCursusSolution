using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCursusLibrary
{
    public class WinstService
    {
        private readonly IOpbrengstDAO opbrengstDAO;
        private readonly IkostDAO kostDAO;
        public WinstService(IOpbrengstDAO opbrengstdao,IkostDAO kostdao)
        {
            this.opbrengstDAO = opbrengstdao;
            this.kostDAO = kostdao;
            winst = opbrengstDAO.TotaleOpbrengst() - kostDAO.TotaleKost();
        }
        public decimal winst { get; }
    }
}
