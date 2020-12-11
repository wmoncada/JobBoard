using System.ComponentModel.DataAnnotations;

namespace JobBoard.Models
{
    public class BaseJobObject
    {
        [Key]
        [Required]
        public string Id { get; set; }
        // public virtual string name { get; set; }


    }
}