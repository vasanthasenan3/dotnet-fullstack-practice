using System.ComponentModel.DataAnnotations;
namespace ShopingApp.Models
{
    public class reg
    {
        public int Id { get; set; }
        [DataType(DataType.Text)]
        [Required(ErrorMessage ="Please Enter The Name")]
        public string Name  { get; set; }
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please Enter The Education")]
        public string Education { get; set; }
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please Enter The Department")]
        public string FieldOfStudy { get; set; }
        [DataType(DataType.Text)]
        [EmailAddress(ErrorMessage ="Please enter the valid Email")]
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Please Enter MobileNumber")]
        public string MobileNo {  get; set; }

        [Required(ErrorMessage = "Please Write About You")]
        public string Profile { get; set; }
    }
}
