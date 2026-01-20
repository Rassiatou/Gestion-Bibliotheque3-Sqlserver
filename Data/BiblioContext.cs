using Microsoft.EntityFrameworkCore;
using TP3_BD.Entities;

namespace TP3_BD.Data
{
    public class BiblioContext : DbContext
    {
        public DbSet<Livre> Livres => Set<Livre>();
        public DbSet<Auteur> Auteurs => Set<Auteur>();
        public DbSet<Categorie> Categories => Set<Categorie>();

        public DbSet<Usager> Usagers => Set<Usager>();
        public DbSet<Employe> Employes => Set<Employe>();

        public DbSet<Emprunt> Emprunts => Set<Emprunt>();

        public DbSet<Activite> Activites => Set<Activite>();
        public DbSet<Participation> Participations => Set<Participation>();

        public DbSet<Materiel> Materiels => Set<Materiel>();
        public DbSet<EmpruntMateriel> EmpruntsMateriel => Set<EmpruntMateriel>();

        public DbSet<Evaluation> Evaluations => Set<Evaluation>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\MSSQLLocalDB;Database=BiblioDB;Trusted_Connection=True;TrustServerCertificate=True"
            );
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ===== LIVRE -> AUTEUR / CATEGORIE
            modelBuilder.Entity<Livre>()
                .HasOne(l => l.Auteur)
                .WithMany(a => a.Livres)
                .HasForeignKey(l => l.AuteurId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Livre>()
                .HasOne(l => l.Categorie)
                .WithMany(c => c.Livres)
                .HasForeignKey(l => l.CategorieId)
                .OnDelete(DeleteBehavior.Restrict);

            // (Optionnel) ISBN unique
            modelBuilder.Entity<Livre>()
                .HasIndex(l => l.ISBN)
                .IsUnique();

            // ===== EMPRUNT (Livre + Usager)
            modelBuilder.Entity<Emprunt>()
                .HasOne(e => e.Livre)
                .WithMany(l => l.Emprunts)
                .HasForeignKey(e => e.LivreId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Emprunt>()
                .HasOne(e => e.Usager)
                .WithMany(u => u.Emprunts)
                .HasForeignKey(e => e.UsagerId)
                .OnDelete(DeleteBehavior.Restrict);

            // ===== ACTIVITE (Organisateur = Employe)
            modelBuilder.Entity<Activite>()
                .HasOne(a => a.Organisateur)
                .WithMany(e => e.ActivitesOrganisees)
                .HasForeignKey(a => a.OrganisateurId)
                .OnDelete(DeleteBehavior.Restrict);

            // ===== PARTICIPATION (Activite + Usager)
            modelBuilder.Entity<Participation>()
                .HasOne(p => p.Activite)
                .WithMany(a => a.Participations)
                .HasForeignKey(p => p.ActiviteId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Participation>()
                .HasOne(p => p.Usager)
                .WithMany(u => u.Participations)
                .HasForeignKey(p => p.UsagerId)
                .OnDelete(DeleteBehavior.Restrict);
            // IMPORTANT : empêcher qu’un même usager soit inscrit 2 fois à la même activité
            modelBuilder.Entity<Participation>()
                .HasIndex(p => new { p.ActiviteId, p.UsagerId })
                .IsUnique();

            // ===== MATERIEL + EMPRUNTMATERIEL
            modelBuilder.Entity<EmpruntMateriel>()
                .HasOne(e => e.Materiel)
                .WithMany(m => m.Emprunts)
                .HasForeignKey(e => e.MaterielId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<EmpruntMateriel>()
                .HasOne(e => e.Usager)
                .WithMany(u => u.EmpruntsMateriel)
                .HasForeignKey(e => e.UsagerId)
                .OnDelete(DeleteBehavior.Restrict);

            // ===== EVALUATION (Livre + Usager)
            modelBuilder.Entity<Evaluation>()
                .HasOne(ev => ev.Livre)
                .WithMany(l => l.Evaluations)
                .HasForeignKey(ev => ev.LivreId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Evaluation>()
                .HasOne(ev => ev.Usager)
                .WithMany(u => u.Evaluations)
                .HasForeignKey(ev => ev.UsagerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
