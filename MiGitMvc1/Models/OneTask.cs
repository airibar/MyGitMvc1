using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiGitMvc1.Models
    {
    
    public class OneTask
        
        {
        //
               //
        public int Id { get; set; }
        [Required]
        [DisplayName("Task title")]
        public string Title { get; set; }

        [DataType(DataType.MultilineText)]
        [Required]
        [DisplayName("Task Description")]
        public string Description { get; set; }

        [DisplayName("Creation Date")]
        public string DateCreation { get; set; }
            
        [Required]
        [DisplayName("Task Due Date")]
        public string DueDate { get; set; }

        [DisplayName("Start Date")]
        public string DateStart { get; set;}
            
        [DisplayName("Task Status")]
        public string Status { get; set; }
        }
    }