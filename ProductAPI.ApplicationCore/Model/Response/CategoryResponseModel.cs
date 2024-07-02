using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPI.ApplicationCore.Model.Response
{
    public class CategoryResponseModel
    {
        public int Id { get; set; }
        
        public string CategoryName { get; set; }
        
        public string CategoryDescription { get; set; }

    }
}
