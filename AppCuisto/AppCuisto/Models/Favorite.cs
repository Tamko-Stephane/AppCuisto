using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace AppCuisto_MVC.Models
{
    public class Favorite
    {
        public int Id { get; set; }

        [DataType(DataType.DateTime)]
        public int Created_At { get; set; }

        public int Receipts_Id { get; set; }

        public int Cookers_Id { get; set; }

        public virtual Receipt Receipt { get; set; }

        public virtual Cooker Cooker { get; set; }
    }
}