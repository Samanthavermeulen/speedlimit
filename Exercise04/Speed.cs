using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04
{
    public class Speed
    {
        public void SpeedLimit()
        {
            // Ask the speed limit
            Console.WriteLine("What is the speed limit?");
            // Enter the speed limit:
            var enterSpeedLimit = Convert.ToInt32(Console.ReadLine());
            // Ask the User the speed limit of a car
            Console.WriteLine("Wat is Your speed limit?");
            var enterTheNextSpeedLimit = Convert.ToInt32(Console.ReadLine());

            // if the speed limit is < then the speed limit of the car
            if (enterTheNextSpeedLimit < enterSpeedLimit)
            {
                // output: OK
                Console.WriteLine("OK");

            }
            else
            {

                for (var y = 0; enterSpeedLimit < enterTheNextSpeedLimit; enterSpeedLimit += 5, y++)
                {
                    if (y == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("Geen rijbenwijs meer");
                        break;
                    }
                    Console.Clear();
                    Console.WriteLine("slow it down Partner...?");
                }



            }
        }
    }
}
