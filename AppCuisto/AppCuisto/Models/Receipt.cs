using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace AppCuisto_MVC.Models
{
    public class Receipt
    {
        public int Id { get; set; }

        [StringLength(45)]
        public string Name { get; set; }

        public int Duration { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public int Guest { get; set; }

        public int Cookers_Id { get; set; }

        public virtual Cooker Cooker { get; set; }
    }
}