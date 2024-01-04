using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAlike
{
    internal interface ILifeForm
    {
        void Move(String[] steps);
        void PrintLastPosition();
        void PrintAllPositions();
    }
}
