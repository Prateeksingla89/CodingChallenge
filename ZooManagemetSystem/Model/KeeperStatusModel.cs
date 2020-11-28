using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ZooManagemetSystem.Model
{
    /// <summary>
    /// Fulltime Employee/PartTime Employee
    /// </summary>
    /// 
    [Table("tblKeeperStatus")]
    public class KeeperStatusModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int KeeperStatusId { get; set; }
        [Column(TypeName = "VARCHAR(128)")]
        public string KeeperStatusName { get; set; }
    }
}
