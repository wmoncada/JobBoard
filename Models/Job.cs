using System;
using System.ComponentModel.DataAnnotations;

namespace JobBoard.Models
{
    public class Job : BaseJobObject
    {

        [Required(ErrorMessage = "Job Title cannot be empty.")]
        [MaxLength(100, ErrorMessage = "The Job Title is too long. The maximun Length is 100 characters.")]
        [Display(Name = "Job Title")]
        public string JobTitle { get; set; }


        [Required(ErrorMessage = "Job Description cannot be empty.")]
        [MinLength(20, ErrorMessage = "The Job description is to short. Minimun Length is 20 characters.")]
        [MaxLength(2000, ErrorMessage = "The Job description is too long. The maximun Length is 2000 characters.")]
        [Display(Prompt = "Essential responsibilities, activities, qualifications and skills of the role.", Name = "Job Description")]
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ExpiresAt { get; set; }

        public Job(string id, string title, string desc, DateTime created, DateTime expires)
        {
            Id = id;
            JobTitle = title;
            Description = desc;
            CreatedAt = created;
            ExpiresAt = expires;
        }

        public Job()
        {
        }

    }
}