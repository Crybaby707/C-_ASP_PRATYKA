using TVShows.Domain.Enums;

namespace TVShows.Domain.Entities
{
    public class Content
    {
        public int Id { get; set; }

        public string? Description { get; set; }

        public bool Favorite { get; set; }

        public bool IsNew { get; set; }

        public string Title { get; set; }

        public GenreEnum Genre { get; set; }

    }
}