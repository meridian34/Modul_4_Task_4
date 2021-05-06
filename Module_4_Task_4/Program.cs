using Modul_4_Task_4.Helpers;
using System;
using System.Threading.Tasks;

namespace Modul_4_Task_4
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            var s = new Starter();
            await s.Start();
        }
    }
}
