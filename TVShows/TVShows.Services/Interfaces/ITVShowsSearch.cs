using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVShows.Services.Interfaces
{
    internal interface ITVShowsSearch
    {
        IEnumerable<Search> AllSearch { get; }
    }
}
