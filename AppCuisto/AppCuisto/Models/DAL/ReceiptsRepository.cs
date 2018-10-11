using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppCuisto_MVC.Models;
using System.Data.Entity;

namespace AppCuisto_MVC.Models.DAL
{
    public class ReceiptsRepository : IAppCuistoRepository<Receipt>
    {
        private List<Receipt> _receipts = new List<Receipt>();

        //Initialize context to be used
        private AppCuistoDB context = new AppCuistoDB();

        public ReceiptsRepository()
        {
            //Get Receipts list before operations

        }

        public void Add(int? id)
        {
            
        }

        public void Add(Receipt T)
        {
            context.Receipts.Add(T);
            context.SaveChanges();
        }

        public void Delete(int? id)
        {
            Receipt cooker = context.Receipts.Find(id);
            context.Receipts.Remove(cooker);
            context.SaveChanges();

        }

        public void Remove(Receipt T)
        {
            context.Receipts.Remove(T);   
            context.SaveChanges();
        }

        public void Edit(Receipt cooker)
        {
            context.Entry(cooker).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public Receipt Find(int? id)
        {
            Receipt cooker = context.Receipts.Find(id);
            return cooker;
        }

        public IEnumerable<Receipt> FindAll()
        {
            _receipts = context.Receipts.ToList();
            return _receipts;
        }

       
    }
}