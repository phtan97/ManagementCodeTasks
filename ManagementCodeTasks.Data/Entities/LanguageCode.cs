using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ManagementCodeTasks.Data.Entities
{
    public class LanguageCode
    {
        [Key]
        public int IdLanguage { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateTime { get; set; }
        public string CreateBy { get; set; }
        public string Status { get; set; }
    }
}
