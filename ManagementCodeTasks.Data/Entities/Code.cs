using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ManagementCodeTasks.Data.Entities
{
    public class Code
    {
        [Key]
        public int IdCode { get; set; }
        public string MyProperty { get; set; }
    }
}
