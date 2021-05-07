using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ManagementCodeTasks.Data.Entities
{
    public class Code
    {
        [Key]
        public int Id { get; set; }
        public string Content { get; set; }
        public string Status { get; set; }
        public string HistoryCode { get; set; }
        public string Comment { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateTime { get; set; }

    }
}
