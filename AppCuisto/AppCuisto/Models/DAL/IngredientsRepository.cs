using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppCuisto_MVC.Models;
using System.Data.Entity;

namespace AppCuisto_MVC.Models.DAL
{
    public class IngredientsRepository : IAppCuistoRepository<Ingredient>
    {
        private List<Ingredient> _ingredients = new List<Ingredient>();

        //Initialize context to be used
        private AppCuistoDB context = new AppCuistoDB();

        public IngredientsRepository()
        {
            //Get Ingredients for a receipt before operations

        }

        public void Add(int? id)
        {
            
        }

        public void Add(Ingredient T)
        {
            context.Ingredients.Add(T);
            context.SaveChanges();
        }

        public void Delete(int? id)
        {
            Ingredient ingredient = context.Ingredients.Find(id);
            context.Ingredients.Remove(ingredient);
            context.SaveChanges();

        }

        public void Remove(Ingredient T)
        {
            context.Ingredients.Remove(T);   
            context.SaveChanges();
        }

        public void Edit(Ingredient ingredient)
        {
            context.Entry(ingredient).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public Ingredient Find(int? id)
        {
            Ingredient ingredient = context.Ingredients.Find(id);
            return ingredient;
        }

        public IEnumerable<Ingredient> FindAll()
        {
            _ingredients = context.Ingredients.ToList();
            return _ingredients;
        }

       
    }
}