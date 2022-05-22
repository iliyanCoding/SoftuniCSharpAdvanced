using System;
using System.Collections;
using System.Collections.Generic;

namespace _10.Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int durationOfTheGreenLight = int.Parse(Console.ReadLine());
            int durationOfTheFreeWindow = int.Parse(Console.ReadLine());
            int overAllTimeToPass = durationOfTheGreenLight + durationOfTheFreeWindow;
            int overAllTimeToPassInTheBegining = overAllTimeToPass;
            int carPassed = 0;
            bool carPassedSuccessfully = false;
            bool noMoreCars = false;
            Queue<string> queue = new Queue<string>();
            string input = Console.ReadLine();
            while (input != "END")
            {
                
                if (input == "green")
                {
                    
                    foreach (var car in queue)
                    {
                        if (durationOfTheGreenLight > car.Length)
                        {
                            carPassedSuccessfully = true;
                            durationOfTheGreenLight -= car.Length;
                            
                        }
                        else
                        {
                            if (durationOfTheGreenLight + durationOfTheFreeWindow > car.Length)
                            {
                                carPassedSuccessfully = true;
                                noMoreCars = true;
                            }
                            else
                            {
                                int indexOfCharacterHit = car.Length - (durationOfTheFreeWindow + durationOfTheGreenLight);
                                Console.WriteLine($"{car} was hit at {car[indexOfCharacterHit]}");
                                carPassedSuccessfully = false;
                            }
                            
                        }
                    }

                    if (carPassedSuccessfully == false)
                    {
                        break;
                        
                    }
                    else
                    {
                        carPassed++;
                        queue.Dequeue();
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }

                input = Console.ReadLine();
                overAllTimeToPass = overAllTimeToPassInTheBegining;
            }
            if (carPassedSuccessfully == true)
            {
                Console.WriteLine("Everyone is safe");
            }
        }
    }
}
