using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductAPI.ApplicationCore.Entities;

namespace ProductAPI.ApplicationCore.Model.Request
{
    public class ProductRequestModel
    {
        [Required(ErrorMessage = "Name is required")]
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Unit Price is required")]
        public decimal UnitPrice { get; set; }
        [Required(ErrorMessage = "Quantity is Required")]
        public int Quantity { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }




    }
}
