using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());
            Stack<int> package = new Stack<int>(clothes);
        }
    }
}
