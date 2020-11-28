using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ZooManagemetSystem.Model
{
    [Table("tblZooAnimalMapping")]
    public class ZooAnimalMappingModel
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ZooAnimalMappingId { get; set; }

        [ForeignKey("ZooModel")]
        public int ZooId { get; set; }
        public virtual ZooModel ZooModel { get; set; }

        [ForeignKey("AnimalModel")]
        public int AnimalId { get; set; }
        public virtual AnimalModel AnimalModel { get; set; }

        public bool IsActive { get; set; }
    }
}
