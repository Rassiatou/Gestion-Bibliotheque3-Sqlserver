using System.Collections.Generic;

namespace TP3_BD.Entities
{
    public class Materiel
    {
        public int MaterielId { get; set; }
        public string Nom { get; set; } = "";

        // "Disponible", "Brisé", etc.
        public string Etat { get; set; } = "Disponible";

        public int Quantite { get; set; }

        public List<EmpruntMateriel> Emprunts { get; set; } = new();
    }
}
