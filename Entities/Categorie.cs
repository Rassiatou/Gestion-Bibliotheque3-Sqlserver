using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_BD.Entities
{
    public class Categorie
    {
        public int CategorieId { get; set; }
        public string Nom { get; set; } = "";

        public string Description { get; set; } = "";
        public List<Livre> Livres { get; set; } = new();
    }
}
