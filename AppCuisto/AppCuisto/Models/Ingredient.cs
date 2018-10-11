using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace AppCuisto_MVC.Models
{
    public class Ingredient
    {
        public int Id { get; set; }

        [StringLength(45)]
        public string Name { get; set; }

        public float Quantity { get; set; }

        public int Receipts_Id { get; set; }

        public virtual Receipt Receipt { get; set; }

    }
}