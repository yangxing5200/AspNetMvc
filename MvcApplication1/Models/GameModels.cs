using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
namespace MvcApplication1.Models
{
    public class GameDbContext : DbContext
    {
        public DbSet<GameModels> Games { get; set; }
    }
    public class GameModels
    {
        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "联系电话")]
        public int Tel { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name="游戏名称")]
        public string Name { get; set; }
        
        [StringLength(200)]
        [Display(Name="游戏简介")]
        public string Desc { get; set; }

    }
}