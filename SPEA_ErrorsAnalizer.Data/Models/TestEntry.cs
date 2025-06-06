using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPEA_ErrorsAnalizer.Data.Models
{
    public class TestEntry
    {
        [Key]
        public int Id { get; set; }               // PK
        public string TestName { get; set; }
        public string TestNumber { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }

        public string TP { get; set; }
        public string Min { get; set; }
        public string Value { get; set; }
        public string Max { get; set; }

        public string EndInfo { get; set; }

        public int DefectSiteNumber { get; set; }  // дефектното място
    }
}
