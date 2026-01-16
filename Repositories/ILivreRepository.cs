using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3_BD.Entities;

namespace TP3_BD.Repositories
{

    public interface ILivreRepository
    {
        List<Livre> GetAll();
        void Add(Livre livre);
    }
}
