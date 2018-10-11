using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppCuisto_MVC.Models;
using System.Data.Entity;

namespace AppCuisto_MVC.Models.DAL
{
    public class FavoritesRepository : IAppCuistoRepository<Favorite>
    {
        private List<Favorite> _favorites = new List<Favorite>();

        //Initialize context to be used
        private AppCuistoDB context = new AppCuistoDB(); 

        public FavoritesRepository()
        {
            //Get favorites list before operations

        }

        public void Add(int? id)
        {
            
        }

        public void Add(Favorite T)
        {
            context.Favorites.Add(T);
            context.SaveChanges();
        }

        public void Delete(int? id)
        {
            Favorite favorite = context.Favorites.Find(id);
            context.Favorites.Remove(favorite);
            context.SaveChanges();

        }

        public void Remove(Favorite T)
        {
            context.Favorites.Remove(T);   
            context.SaveChanges();
        }

        public void Edit(Favorite favorite)
        {
            context.Entry(favorite).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public Favorite Find(int? id)
        {
            Favorite favorite  = context.Favorites.Find(id);
            return favorite;
        }

        public IEnumerable<Favorite> FindAll()
        {
            _favorites = context.Favorites.ToList();
            return _favorites;
        }

       
    }
}