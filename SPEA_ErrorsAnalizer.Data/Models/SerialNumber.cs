using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPEA_ErrorsAnalizer.Data.Models
{
    public class SerialNumber
    {
        [Key]
        public int Id { get; set; }              // PK

        [Required]
        public int SiteNumber { get; set; }     // числото от края, напр. 1, 2, 3, 4
        [Required]
        public string FullSerial { get; set; }  // пълния сериен номер
    }
}
