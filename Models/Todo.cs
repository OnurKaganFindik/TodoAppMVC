using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TodoAppMVC.Models
{
    [Table("Todos")]
    public class Todo
    {

        [Key]
        public int ID { get; set; }
        [Required]
        public string Description { get; set; }

        public int UserID { get; set; }

        [Required]
        [ForeignKey("UserID")]
        public virtual User User { get; set; }
    }
}
