using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace AppCuisto_MVC.Models
{
    public class Cooker
    {
        public int Id { get; set; }

        [StringLength(45)]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        [StringLength(45)]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [StringLength(45)]
        public string Password { get; set; }

    }
}