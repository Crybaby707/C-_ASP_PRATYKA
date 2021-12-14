using TVShows.Services.Models;

namespace TVShows.Services.Interfaces
{
    internal interface ITVShowsFavorite
    {
        IEnumerable<Favorite> AllFavorits { get; }
    }
}
