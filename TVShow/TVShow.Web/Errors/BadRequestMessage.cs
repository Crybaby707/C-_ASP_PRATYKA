using System.ComponentModel.DataAnnotations;

namespace TVShows.Web.Errors
{
    public class BadRequestMessage
    {
        [Required]
        public string Message { get; set; }
    }
}
