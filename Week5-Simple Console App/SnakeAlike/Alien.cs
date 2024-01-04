using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAlike
{
    internal class Alien : LifeForm
    {
        public Alien(int mapWidth, int mapHeight) : base(mapWidth, mapHeight) { }

        public override void PrintLastPosition()
        {
            // coordinates are reversed here
            Console.WriteLine($"[{y}, {x}]");
        }

        public override void PrintAllPositions()
        {
            foreach (var position in allCoordinates)
            {
                Console.WriteLine($"[{position.Item2}, {position.Item1}]");
            }
        }
    }
}
