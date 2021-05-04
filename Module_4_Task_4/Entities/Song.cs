using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_4_Task_4.Entities
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        public DateTime RelesedDate { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public List<Artist> Artists { get; set; }
    }
}
