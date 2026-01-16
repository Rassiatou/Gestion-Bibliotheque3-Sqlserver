using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_BD.Entities
{
    public class Activite
    {
        public int ActiviteId { get; set; }          // PK

        public string Titre { get; set; } = "";

        // "Évènement" / "Concours" (comme ton combo)
        public string Type { get; set; } = "";

        public DateTime Date { get; set; }

        public int CapaciteMax { get; set; }         // capacité

        // FK vers Employe (Organisateur)
        public int OrganisateurId { get; set; }
        public Employe? Organisateur { get; set; }

        // (Optionnel) participations liées à l'activité
        public List<Participation> Participations { get; set; } = new();
    }
}
