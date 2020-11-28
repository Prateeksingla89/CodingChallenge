using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ZooManagemetSystem.Model
{
    /// <summary>
    /// keeper status can fulltime/PartTime
    /// </summary>
    [Table("tblKeeper")]
    public class KeeperModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int KeeperId { get; set; }
        [Column(TypeName = "VARCHAR(128)")]
        public string KeeperName { get; set; }

        [ForeignKey("KeeperStatusModel")]
        public int KeeperStatusId { get; set; }
        public virtual KeeperStatusModel KeeperStatusModel { get; set; }

    }
}
