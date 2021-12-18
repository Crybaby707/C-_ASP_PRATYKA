using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVShow.DB
{
    public class ContentDB
    {
        public int id { get; set; }
        public string Title { get; set; }

        public int GenreID { get; set; }

        public string Description { get; set; }

        public int Rate { get; set; }

        public int Date { get; set; }

        public string Img { get; set; }

    }
}
