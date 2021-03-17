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
        private DateTime _DateCreation;
        private DateTime _DateStarted;
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
        public DateTime DateCreation {
            get {return _DateCreation; }
            set { _DateCreation = value; }
            }
        [Required]
        [DisplayName("Task Due Date")]
        public string DueDate { get; set; }

        [DisplayName("Start Date")]
        public DateTime DateStart
            {
            get { return _DateStarted; }
            set { _DateStarted = value; }
            }
        [DisplayName("Task Status")]
        public string Status { get; set; }
        }
    }