using System.ComponentModel.DataAnnotations;

namespace BasicMVC.Models
{
    public class Candidate
    {
        [Required (ErrorMessage ="Email cant be empty")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "FirstName cant be empty")]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "LastName cant be empty")]
        public string? LastName { get; set; }
        public string? FullName => $"{FirstName} {LastName}";
        public int? Age { get; set; }
        public DateTime ApplyAt { get; set; }
        public string? SelectedCourse { get; set; }

        public Candidate()
        {
            ApplyAt = DateTime.Now;   
        }
    }
    
}
