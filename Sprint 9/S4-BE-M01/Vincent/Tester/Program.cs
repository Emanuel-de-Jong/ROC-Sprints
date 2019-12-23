using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioDevices.Tracks;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            Track t1 = new Track(1, "Nelly Furtado", "Maneater");
            t1.AlbumSource = "Loose";
            t1.Length = new Time(4, 31);
            t1.Style = Category.Pop;
            Console.WriteLine(t1.DisplayName);
            Console.WriteLine(t1.DisplayLength);
            Console.WriteLine("Tijd in seconden: {0}", t1.GetLengthInSeconds());
            Console.WriteLine("Category: {0}", t1.Style.ToString());
            Console.ReadLine();
        }
    }
}
