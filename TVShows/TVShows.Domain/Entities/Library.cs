using TVShows.Domain.Extensions;

namespace TVShows.Domain.Entities
{
    public class Library
    {
        public int Id { get; set; }

        public List<Content> Contents { get; set; }

        public bool AddContent(Content content)
        {
            var contents = Contents.Count();

            if (content.Title.HasLetters())
                Contents.Add(content);

            return contents > Contents.Count();
        }

    }
}
