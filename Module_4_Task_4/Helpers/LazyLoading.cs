using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_4_Task_4.Helpers
{
    public class LazyLoading
    {
        private readonly ApplicationContext _context;

        public LazyLoading(ApplicationContext context)
        {
            _context = context;
        }

        public async Task FirstTask()
        {  
            var t = await (from art in _context.Artists
                    from s in art.Songs
                    select new { Song = s.Title, Artist = art.Name, Genre = s.Genre.Title }).ToListAsync();
            foreach (var i in t)
            {
                Console.WriteLine($@"{i.Song}  {i.Artist}  {i.Genre}");
            }
        }
        public async Task SecondTask()
        {
            var t = await (from g in _context.Genres                     
                     select new { Genre = g.Title, Count = g.Songs.Count() }).ToListAsync();
            foreach (var i in t)
            {
                Console.WriteLine($@"{i.Genre} : {i.Count}");
            }
        }

        public async Task ThirdTask()
        {
            var t = await _context.Songs.Where(s => s.RelesedDate < s.Artists.Max(q=>q.DateOfBirth)).Select(s=>s.Title).ToListAsync();
            foreach (var i in t)
            {
                Console.WriteLine($@"{i}");
            }
        }
    }
}
