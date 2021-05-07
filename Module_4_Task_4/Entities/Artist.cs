using System;
using System.Collections.Generic;

namespace Modul_4_Task_4.Entities
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string InstagramUrl { get; set; }
        public virtual List<Song> Songs { get; set; }
    }
}
