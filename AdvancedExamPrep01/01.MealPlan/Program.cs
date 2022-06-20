using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.MealPlan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfMeals = 0;
            Dictionary<string, int> caloriesByMeal = new Dictionary<string, int>()
            {
                { "salad", 350 },
                { "soup", 490},
                { "pasta", 680},
                { "steak", 790},
            };
            string[] meals = Console.ReadLine().Split(' ');
            int[] caloriesPerDay = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Queue<string> mealsQueue = new Queue<string>();
            for (int i = 0; i < meals.Length; i++)
            {
                mealsQueue.Enqueue(meals[i]);
            }

            Stack<int> caloriesPerDayStack = new Stack<int>();
            for (int i = 0; i < caloriesPerDay.Length; i++)
            {
                caloriesPerDayStack.Push(caloriesPerDay[i]);
            }

            while (mealsQueue.Count > 0 && caloriesPerDayStack.Sum() > 0)
            {
                string currMeal = mealsQueue.Peek(); 
                int currCalories = caloriesPerDayStack.Peek(); 
                if (currCalories >= caloriesByMeal[currMeal])
                {
                    currCalories -= caloriesByMeal[currMeal]; 
                    mealsQueue.Dequeue();
                    numOfMeals++;
                    caloriesPerDayStack.Pop();
                    caloriesPerDayStack.Push(currCalories);
                }
                else
                {
                    int calForTomorrow = caloriesByMeal[currMeal] - currCalories;
                    caloriesPerDayStack.Pop();
                    if (caloriesPerDayStack.Sum() > 0)
                    {
                        currCalories = caloriesPerDayStack.Peek();
                        currCalories -= calForTomorrow;
                        caloriesPerDayStack.Pop();
                        caloriesPerDayStack.Push(currCalories);
                        mealsQueue.Dequeue();
                        numOfMeals++;
                    }
                    else
                    {
                        mealsQueue.Dequeue();
                        numOfMeals++;
                        break;
                    }
                    
                }
            }

            if (mealsQueue.Count == 0)
            {
                Console.WriteLine($"John had {numOfMeals} meals.");
                Console.WriteLine($"For the next few days, he can eat {string.Join(", ", caloriesPerDayStack)} calories.");
              
            }
            else
            {
                Console.WriteLine($"John ate enough, he had {numOfMeals} meals.");
                Console.WriteLine($"Meals left: {string.Join(", ", mealsQueue)}.");
            }
        }
    }
}
