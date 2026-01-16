using System.Collections.Generic;

namespace TP3_BD.Entities
{
    public class Employe
    {
        public int EmployeId { get; set; }
        public string Nom { get; set; } = "";
        public string Prenom { get; set; } = "";

        // optionnel
        public string Role { get; set; } = "";

        public List<Activite> ActivitesOrganisees { get; set; } = new();
    }
}
