using System;
using System.Collections.Generic;

namespace _08.SoftuniParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<char[]> vipGuests = new HashSet<char[]>();
            HashSet<char[]> regularGuests = new HashSet<char[]>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "PARTY")
                {
                    break;
                }
                else
                {
                    char[] reservationNumber = input.ToCharArray();
                    if (Char.IsDigit(reservationNumber[0]))
                    {
                        vipGuests.Add(reservationNumber);
                    }
                    else
                    {
                        regularGuests.Add(reservationNumber);
                    }
                }
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                else
                {
                    char[] reservationNumber = input.ToCharArray();
                    if (Char.IsDigit(reservationNumber[0]))
                    {
                        vipGuests.Remove(reservationNumber);
                    }
                    else
                    {
                        regularGuests.Remove(reservationNumber);
                    }
                }
            }

            Console.WriteLine(vipGuests.Count + regularGuests.Count);
            foreach (var vip in vipGuests)
            {
                Console.WriteLine(vip);
            }
            foreach (var regular in regularGuests)
            {
                Console.WriteLine(regular);
            }
        }
    }
}
