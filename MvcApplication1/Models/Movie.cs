using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class DbContextMovie:DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
    public class Movie
    {
        [Required]
        [DataType(DataType.CreditCard)]
        [Display(Name = "影片编号")]
        public int Id { get; set; }

    

        [Required]
        [StringLength(30)]
        [Display(Name = "影片名称")]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "价格")]
        public decimal Price { get; set; }
    }
}