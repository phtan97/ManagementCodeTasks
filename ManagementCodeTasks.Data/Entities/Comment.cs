using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ManagementCodeTasks.Data.Entities
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string Content { get; set; }
        public bool Status { get; set; }
        public int UserId { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
