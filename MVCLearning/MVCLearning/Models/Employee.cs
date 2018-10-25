using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCLearning.Models
{
    public class Employee
    {
       
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid EmployeeId {get;set;}
        [Required(ErrorMessage ="FirstName is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage ="LastName is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage ="Enter a valid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password,ErrorMessage ="Invalid password type")]
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public string Region { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
    
}