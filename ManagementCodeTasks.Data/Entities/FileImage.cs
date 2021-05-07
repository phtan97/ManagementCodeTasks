using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ManagementCodeTasks.Data.Entities
{
    public class FileImage
    {
        [Key]
        public int Id { get; set; }
        public string FileExtension { get; set; }
        public string FileName { get; set; }
        public string FileUrl { get; set; }
        public int FileSize { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
