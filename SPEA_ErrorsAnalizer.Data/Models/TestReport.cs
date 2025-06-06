using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPEA_ErrorsAnalizer.Data.Models
{
    public class TestReport
    {
        [Key]
        public int Id { get; set; }
        public string Directory { get; set; }
        public string ProgramName { get; set; }
        public int SystemNumber { get; set; }
        public int Head { get; set; }
        public string DateTimeStamp { get; set; }
        public string ProductCode { get; set; }
        public string TestResult { get; set; }
        public string TestResultDateTime { get; set; }

        public List<SerialNumber> SerialNumbers { get; set; } = new();
        public List<TestEntry> TestEntries { get; set; } = new();
    }
}
