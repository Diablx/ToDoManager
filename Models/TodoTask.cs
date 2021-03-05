using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoManager.Models
{
    public class TodoTask
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public bool IsCompleted { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public DateTime DueDate { get; set; } = DateTime.Now.Add(new TimeSpan(3,0,0));
        [Required]
        public int PersonID { get; set; }
        public Person AssignedUser { get; set; }
    }
}