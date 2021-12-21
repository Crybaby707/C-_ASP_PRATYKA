using System.ComponentModel.DataAnnotations;

namespace TVShow.Web.Dto
{
    public class TokenDto
    {
        [Required]
        public string Token { get; set; }
    }
}
