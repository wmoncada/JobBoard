using System.ComponentModel.DataAnnotations;

namespace JobBoard.Models
{
    public class BaseJobObject
    {
        [Key]
        public string Id { get; set; }
        // public virtual string name { get; set; }


    }
}