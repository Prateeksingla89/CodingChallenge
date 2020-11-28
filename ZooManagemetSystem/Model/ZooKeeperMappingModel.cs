using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ZooManagemetSystem.Model
{
    [Table("tblZooKeeperMapping")]
    public class ZooKeeperMappingModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ZooKeeperMappingId { get; set; }

        [ForeignKey("ZooModel")]
        public int ZooId { get; set; }
        public virtual ZooModel ZooModel { get; set; }

        [ForeignKey("KeeperModel")]
        public int KeeperId { get; set; }
        public virtual KeeperModel KeeperModel { get; set; }

        public bool IsActive { get; set; }

    }

}
