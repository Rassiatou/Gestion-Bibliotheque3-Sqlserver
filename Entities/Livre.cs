using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_BD.Entities
{
    public class Livre
    {
        public int LivreId { get; set; }
        public string Titre { get; set; } = "";
        public string ISBN { get; set; } = "";
        public int Annee { get; set; }
        public int Quantite { get; set; }

        public int AuteurId { get; set; }
        public Auteur? Auteur { get; set; }

        public int CategorieId { get; set; }
        public Categorie? Categorie { get; set; }

        public List<Emprunt> Emprunts { get; set; } = new();
        public List<Evaluation> Evaluations { get; set; } = new();
    }
}
