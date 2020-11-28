using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ZooManagemetSystem.Model
{
    /// <summary>
    /// catg can be Tiger ,Elephant 
    /// </summary>
    /// 
    [Table("tblAnimalCategory")]
    public class AnimalCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AnimalCatgId { get; set; }
        [Column(TypeName = "VARCHAR(128)")]
        public string AnimalCatgName { get; set; }
    }
}
