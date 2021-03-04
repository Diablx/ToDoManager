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
        public DateTime CreatedOn { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
        [Required]
        public int PersonID { get; set; }
        [NotMapped]
        public Person AssignedUser { get; set; }
    }
}