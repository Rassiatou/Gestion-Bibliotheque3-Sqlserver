using System;

namespace TP3_BD.Entities
{
    public class Emprunt
    {
        public int EmpruntId { get; set; }

        public int LivreId { get; set; }
        public Livre? Livre { get; set; }

        public int UsagerId { get; set; }
        public Usager? Usager { get; set; }

        public DateTime DateEmprunt { get; set; } = DateTime.Today;
        public DateTime DateRetourPrevue { get; set; } = DateTime.Today.AddDays(14);
        public DateTime? DateRetour { get; set; }

        // "EnCours", "EnRetard", "Retourne"
        public string Etat { get; set; } = "EnCours";
    }
}
