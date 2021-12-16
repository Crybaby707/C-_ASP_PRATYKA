using System.ComponentModel.DataAnnotations;

namespace TVShows.Web.Dto
{
    public class TokenDto
    {
        [Required]
        public string Token { get; set; }
    }
}
