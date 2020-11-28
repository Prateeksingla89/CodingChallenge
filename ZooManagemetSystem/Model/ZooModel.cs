using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ZooManagemetSystem.Model
{
    [Table("tblZoo")]
    public class ZooModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ZooId { get; set; }
        [Column(TypeName = "VARCHAR(128)")]
        public string ZooName { get; set; }
    }
}
