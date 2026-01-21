using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_BD.Entities
{

    public class RapportEvaluationDetail
    {
        public string Usager { get; set; } = "";
        public int Note { get; set; }
        public string Commentaire { get; set; } = "";
        public DateTime DateEvaluation { get; set; }
    }
}
