using System;

namespace TP3_BD.Entities
{
    public class Evaluation
    {
        public int EvaluationId { get; set; }

        public int LivreId { get; set; }
        public Livre? Livre { get; set; }

        public int UsagerId { get; set; }
        public Usager? Usager { get; set; }

        // Note sur 5 par exemple
        public int Note { get; set; }

        public string Commentaire { get; set; } = "";
        public DateTime DateEvaluation { get; set; } = DateTime.Today;
    }
}
