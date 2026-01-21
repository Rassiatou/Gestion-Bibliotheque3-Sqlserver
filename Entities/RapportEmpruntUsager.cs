using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_BD.Entities
{
    public class RapportEmpruntUsager
    {
        public string Livre { get; set; }
        public DateTime DateEmprunt { get; set; }
        public DateTime DateRetourPrevue { get; set; }
        public string Statut { get; set; }
    }
}
