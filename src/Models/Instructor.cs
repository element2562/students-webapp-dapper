using Dapper;
using Microsoft.Data.Sqlite;
using System.ComponentModel.DataAnnotations;

namespace Workforce.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        [Required]
        [Display (Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display (Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display (Name = "Slack Handle")]
        [MaxLength(20)]
        public string SlackHandle { get; set; }
        [Required]
        public string Specialty { get; set; }
        [Required]
        [Display (Name = "Cohort")]
        public int CohortId { get; set; }
        [Display (Name = "Cohort")]
        public Cohort Cohort { get; set; }
    }
}
