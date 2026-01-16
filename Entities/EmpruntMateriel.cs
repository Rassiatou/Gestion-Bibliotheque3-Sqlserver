using System;

namespace TP3_BD.Entities
{
    public class EmpruntMateriel
    {
        public int EmpruntMaterielId { get; set; }

        public int MaterielId { get; set; }
        public Materiel? Materiel { get; set; }

        public int UsagerId { get; set; }
        public Usager? Usager { get; set; }

        public DateTime DateEmprunt { get; set; } = DateTime.Today;
        public DateTime DateRetourPrevue { get; set; } = DateTime.Today.AddDays(7);
        public DateTime? DateRetour { get; set; }

        public string Etat { get; set; } = "EnCours";
    }
}
