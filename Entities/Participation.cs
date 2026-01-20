using System;

namespace TP3_BD.Entities
{
    public class Participation
    {
        public int ParticipationId { get; set; }

        public int ActiviteId { get; set; }
        public Activite? Activite { get; set; }

        public int UsagerId { get; set; }
        public Usager? Usager { get; set; }

        // Case à cocher (Présence)
        public bool Presence { get; set; } = false;

        public DateTime DateInscription { get; set; } = DateTime.Today;
    }

   
}
