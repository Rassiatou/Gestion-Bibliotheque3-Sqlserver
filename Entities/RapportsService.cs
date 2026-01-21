using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3_BD.Data;

namespace TP3_BD.Entities
{
    public class RapportsService
    {
        private readonly BiblioContext _db;

        public RapportsService()
        {
            _db = new BiblioContext();
        }

        // =========================
        // RAPPORT 1 : Emprunts d’un usager
        // =========================
        public List<RapportEmpruntUsager> GetEmpruntsParUsager(int usagerId)
        {
            return _db.Emprunts
                .Where(e => e.UsagerId == usagerId)
                .Select(e => new RapportEmpruntUsager
                {
                    Livre = e.Livre!.Titre,
                    DateEmprunt = e.DateEmprunt,
                    DateRetourPrevue = e.DateRetourPrevue,
                    Statut = e.DateRetour == null
                        ? (e.DateRetourPrevue < DateTime.Now ? "En retard" : "En cours")
                        : "Retourné"
                })
                .ToList();
        }

        // =========================
        // RAPPORT 2 : Participants à un concours
        // =========================
        public List<RapportParticipant> GetParticipantsParConcours(int activiteId)
        {
            return _db.Participations
                .Where(p => p.ActiviteId == activiteId)
                .Select(p => new RapportParticipant
                {
                    Nom = p.Usager!.Nom,
                    Prenom = p.Usager!.Prenom
                })
                .ToList();
        }

        // =========================
        // RAPPORT 3 : Évaluations des livres
        // =========================
        public List<RapportEvaluationLivre> GetEvaluationResumeParLivre(int livreId)
        {
            return _db.Evaluations
                .Where(e => e.LivreId == livreId)
                .GroupBy(e => e.Livre!.Titre)
                .Select(g => new RapportEvaluationLivre
                {
                    Livre = g.Key,
                    NoteMoyenne = Math.Round(g.Average(x => x.Note), 2),
                    NombreEvaluations = g.Count()
                })
                .ToList();
        }

        public List<RapportEvaluationDetail> GetEvaluationsDetailsParLivre(int livreId)
        {
            return _db.Evaluations
                .Where(e => e.LivreId == livreId)
                .Select(e => new RapportEvaluationDetail
                {
                    Usager = e.Usager!.Prenom + " " + e.Usager!.Nom,
                    Note = e.Note,
                    Commentaire = e.Commentaire,
                    DateEvaluation = e.DateEvaluation
                })
                .OrderByDescending(x => x.DateEvaluation)
                .ToList();
        }


    }
}
