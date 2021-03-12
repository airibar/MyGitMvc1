using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiGitMvc1.Models
    {
    public class OneTask
        {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateCreation = DateTime.Now;
        public string DueDate { get; set; }
        }
    }