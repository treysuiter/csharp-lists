using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            List<string> lastPlanets = new List<string>() {"Neptune", "Uranus"};

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            planetList.AddRange(lastPlanets);

            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");
            List<string> rockyPlanets = planetList.GetRange(0, 4);
            planetList.Remove("Pluto");
            planetList.ForEach(planet => Console.WriteLine(planet));
            rockyPlanets.ForEach(planet => Console.WriteLine(planet));

        }

        
    }
}
