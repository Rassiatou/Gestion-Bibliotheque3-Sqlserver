using System.Collections.Generic;

namespace TP3_BD.Entities
{
    public class Usager
    {
        public int UsagerId { get; set; }
        public string Nom { get; set; } = "";
        public string Prenom { get; set; } = "";

        public string Telephone { get; set; } = "";

        public bool Actif { get; set; } 
        public string TypeUsager { get; set; }

        // "Actif", "Suspendu", etc. (selon ton TP)
        public string Statut { get; set; } = "Actif";

        public List<Emprunt> Emprunts { get; set; } = new();
        public List<Participation> Participations { get; set; } = new();
        public List<EmpruntMateriel> EmpruntsMateriel { get; set; } = new();
        public List<Evaluation> Evaluations { get; set; } = new();
    }
}
