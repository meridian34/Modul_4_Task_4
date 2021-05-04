using Modul_4_Task_4.Helpers;
using System;

namespace Modul_4_Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Starter();
            s.Start().GetAwaiter().GetResult();

        }
    }
}
