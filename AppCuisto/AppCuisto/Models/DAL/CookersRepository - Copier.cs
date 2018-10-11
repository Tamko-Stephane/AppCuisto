using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppCuisto_MVC.Models;
using System.Data.Entity;

namespace AppCuisto_MVC.Models.DAL
{
    public class CookersRepository : IAppCuistoRepository<Cooker>
    {
        private List<Cooker> _cookers = new List<Cooker>();

        //Initialize context to be used
        private AppCuistoDB context = new AppCuistoDB();

        public CookersRepository()
        {
            //Get Cookers list before operations

        }

        public void Add(int? id)
        {
            
        }

        public void Add(Cooker T)
        {
            context.Cookers.Add(T);
            context.SaveChanges();
        }

        public void Delete(int? id)
        {
            Cooker cooker = context.Cookers.Find(id);
            context.Cookers.Remove(cooker);
            context.SaveChanges();

        }

        public void Remove(Cooker T)
        {
            context.Cookers.Remove(T);   
            context.SaveChanges();
        }

        public void Edit(Cooker cooker)
        {
            context.Entry(cooker).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public Cooker Find(int? id)
        {
            Cooker cooker = context.Cookers.Find(id);
            return cooker;
        }

        public IEnumerable<Cooker> FindAll()
        {
            _cookers = context.Cookers.ToList();
            return _cookers;
        }

       
    }
}