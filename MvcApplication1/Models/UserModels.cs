using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class YxUsersContext : DbContext
    {
        public YxUsersContext()
            : base("DefaultConnection")
        {

        }
        public DbSet<YxUserProfile> YxUserProfile { get; set; }
    }
    /// <summary>
    /// 用户表
    /// </summary>
    [Table("YxUser")]
    public class YxUserProfile
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Password { get; set; }
    }
    
    public class YxLoginUserModel
    {
        [Required]
        public string Name { get; set; }

        public string Password { get; set; }
    }
}