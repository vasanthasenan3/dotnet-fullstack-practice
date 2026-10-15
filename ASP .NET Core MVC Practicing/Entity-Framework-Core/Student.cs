
using System.ComponentModel.DataAnnotations;

namespace ShopingApp.Models
{
    public class Student
    {
     
        public int Id { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage ="Please enter the name")]
        public string Name { get; set; }


        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter the Collegename")]
        public string College { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter the Department")]
        public string Department { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter the Degree")]
        public string Degree { get; set; }
        [Required(ErrorMessage = "Please enter the Email")]
        [EmailAddress(ErrorMessage ="Please enter the valid email")]
        public string Email { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter the DOB")]
        public string DOB { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please enter the JoiningDate")]
        public string JoiningDate { get; set; }

        public string UploadPhoto { get; set; }

  
   
      
 
    }
}
