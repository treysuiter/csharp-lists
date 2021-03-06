﻿using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<string> planetList = new List<string>() { "Mercury", "Mars" };
            // List<string> lastPlanets = new List<string>() { "Neptune", "Uranus" };

            // planetList.Add("Jupiter");
            // planetList.Add("Saturn");

            // planetList.AddRange(lastPlanets);

            // planetList.Insert(1, "Venus");
            // planetList.Insert(2, "Earth");
            // planetList.Add("Pluto");
            // List<string> rockyPlanets = planetList.GetRange(0, 4);
            // planetList.Remove("Pluto");
            // planetList.ForEach(planet => Console.WriteLine(planet));
            // rockyPlanets.ForEach(planet => Console.WriteLine(planet));

            List<int> oneThruFive = new List<int> {0, 1, 2, 3, 4, 5,};
            Random random = new Random();
            List<int> numbers = new List<int> {
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
            };

            foreach (int i in oneThruFive) {
   // Determine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.
                if (numbers.Contains(i)) {

                    Console.WriteLine($"List contains {i}");
                }
                else
                {
                    Console.WriteLine($"List does not contain {i}");
                }
              
            }
        }
    }
}
