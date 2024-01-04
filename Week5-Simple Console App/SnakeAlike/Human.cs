using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAlike
{
    internal class Human : LifeForm
    {
        public Human(int mapWidth,  int mapHeight) : base(mapWidth, mapHeight) { }

        public override void PrintLastPosition()
        {
            Console.WriteLine("Report Actual Coordinate:");
            Console.WriteLine($"[{x}, {y}]");
        }

        public override void PrintAllPositions()
        {
            Console.WriteLine("Report Path:");
            foreach (var position in allCoordinates)
            {
                Console.WriteLine($"[{position.Item1}, {position.Item2}]");
            }
        }
    }
}
