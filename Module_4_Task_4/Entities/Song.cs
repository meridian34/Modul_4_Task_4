using System;
using System.Collections.Generic;

namespace Modul_4_Task_4.Entities
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public TimeSpan Duration { get; set; }
        public DateTime RelesedDate { get; set; }
        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual List<Artist> Artists { get; set; }        
    }
}
