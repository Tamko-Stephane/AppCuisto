using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCuisto_MVC.Models.DAL
{
    interface IAppCuistoRepository<TRepository> : IRespository<TRepository>
    {
    }

    internal interface IRespository<TRepository>
    {
        IEnumerable<TRepository> FindAll();
        TRepository Find(int? id);
        void Delete(int? id);
        void Add(int? id);
        void Add(TRepository T);
        void Remove(TRepository T);
        void Dispose();
        void Edit(TRepository T);
    }
}
