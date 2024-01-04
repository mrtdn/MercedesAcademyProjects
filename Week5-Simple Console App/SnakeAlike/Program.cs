using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAlike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter map dimensions in the w,y format: ");
            var dimensions = Console.ReadLine().Split(',');
            int width = int.Parse(dimensions[0]);
            int height = int.Parse(dimensions[1]);

            Console.WriteLine("Enter movements in the x1,y1,x2,y2... format: ");
            var stepsInput = Console.ReadLine();
            var steps = parseSteps(stepsInput);

            Console.WriteLine("Select Life Form (1: Human, 2: Alien): ");
            int lifeFormID = int.Parse(Console.ReadLine());

            ILifeForm lifeForm;
            if (lifeFormID == 1)
            {
                lifeForm = new Human(width, height);
            }
            else if (lifeFormID == 2)
            {
                lifeForm = new Alien(width, height);
            }
            else return;

            lifeForm.Move(steps);
            lifeForm.PrintAllPositions();
            lifeForm.PrintLastPosition();
        }
        private static string[] parseSteps(string stepsInput)
        {
            var tempSteps = stepsInput.Split(',');
            // create an string array half size of the input because it will ve stored as pairs
            var steps = new string[tempSteps.Length / 2];

            // every loop creates a pair of coordinates of (x1,y1) (x2,y2)
            for (int i = 0, j = 0; i < tempSteps.Length; i += 2, j++)
            {
                steps[j] = tempSteps[i] + "," + tempSteps[i + 1];
            }

            return steps;
        }
    }
}
