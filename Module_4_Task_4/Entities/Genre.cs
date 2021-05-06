using System.Collections.Generic;

namespace Modul_4_Task_4.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual List<Song> Songs { get; set; }
    }
}
