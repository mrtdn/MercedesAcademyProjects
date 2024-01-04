using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAlike
{
    internal abstract class LifeForm : ILifeForm
    {   
        // its protected because LifeForm is an abstract class therefore
        // when derived from a subclass its fields need to be accessible from those classes
        protected int x;
        protected int y;
        protected int mapWidth;
        protected int mapHeight;
        protected List<Tuple<int, int>> allCoordinates = new List<Tuple<int, int>>();

        protected LifeForm(int mapWidth, int mapHeight)
        {
            // creating the map borders
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;

            // starting from the origin
            x = 0;
            y = 0;
        }

        public void Move(String[] steps)
        {
            foreach (var step in steps)
            {
                var temp = step.Split(',');
                var stepX = int.Parse(temp[0]);
                var stepY = int.Parse(temp[1]);
                // tekrar mapwidth+1 ile topladim cunku bolumunden kalan negatif sayi vermemeli
                // modulus kullandim cunku harita sinirlarina geldigimde
                // ayni satirin basina gelmesini istiyoruz
                x = (x + stepX + (mapWidth + 1)) % (mapWidth + 1);
                y = (y + stepY + (mapHeight + 1)) % (mapHeight + 1);
                allCoordinates.Add(new Tuple<int, int>(x, y));
            }
        }
        public abstract void PrintLastPosition();
        public abstract void PrintAllPositions();

    }
}
