using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementCodeTasks.Data.Entities
{
    public class User
    {
        public int IdUser { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }
        public string Image { get; set; }
    }
}
