using System.ComponentModel.DataAnnotations;

namespace TVShow.Web.Errors
{
    public class BadRequestMessage
    {
        [Required]
        public string Message { get; set; }
    }
}
