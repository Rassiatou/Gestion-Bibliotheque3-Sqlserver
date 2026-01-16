using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3_BD.Data;
using TP3_BD.Entities;

namespace TP3_BD.Repositories
{
    public class LivreRepository : ILivreRepository
    {
        private readonly BiblioContext _db;

        public LivreRepository(BiblioContext db) => _db = db;

        public List<Livre> GetAll()
        {
            return _db.Livres
                .Include(l => l.Auteur)
                .Include(l => l.Categorie)
                .OrderBy(l => l.Titre)
                .ToList();
        }

        public void Add(Livre livre)
        {
            _db.Livres.Add(livre);
            _db.SaveChanges();
        }
    }
}
