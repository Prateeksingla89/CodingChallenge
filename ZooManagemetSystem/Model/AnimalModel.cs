using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ZooManagemetSystem.Model
{
    [Table("tblAnimal")]
    public class AnimalModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AnimalId { get; set; }

        [Column(TypeName = "VARCHAR(128)")]
        public string AnimalName { get; set; }

        [ForeignKey("AnimalCategory")]
        public int AnimalCatgId { get; set; }
        public virtual AnimalCategory AnimalCategory { get; set; }

       
    }
}
