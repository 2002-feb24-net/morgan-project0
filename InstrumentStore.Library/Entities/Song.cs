using System;
using System.Collections.Generic;

namespace InstrumentStore.Library.Entities
{
    public partial class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
