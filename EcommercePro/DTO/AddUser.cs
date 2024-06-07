using System.ComponentModel.DataAnnotations;

namespace EcommercePro.DTO
{
    public class AddUser
    {

        [Required(ErrorMessage = "The UserName is Required")]
        public string username { set; get; }
        [Required(ErrorMessage = "The Password is Required")]
        public string password { set; get; }
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "The Email is Required")]
        public string email { set; get; }

        [Required(ErrorMessage = "The Role is Required")]

        public string Role { set; get; }

    }
}
