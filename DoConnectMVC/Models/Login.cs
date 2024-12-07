using System.ComponentModel.DataAnnotations;

namespace DoConnectMVC.Models
{
    public class Login
    {
        public String UserName {  get; set; }
        [Required]
        public String Password { get; set; }
      

    }
}
