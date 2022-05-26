using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyChallenges
{
    public class ChallengeRepository
    {
        public string SpongeBobCaser(string input)
    {
        string output = "";

        foreach (char x in input)
        {
            if (input.IndexOf(x) % 2 == 0)
            {
                output += char.ToUpper(x);
            }
            else 
            {
                output += char.ToLower(x);
            }
        }
        return output;

    }

    public int intArr{

        int[] intArr = { 3, 6, 90, 5, 2, 8, 6, 120, 8, 12, 7, -56 };

    }
    public List<float> ConvertToKm(List<float> measurements)
        {
            List<float> newMeasurements = new List<float>(){};
            foreach (float x in measurements)
            {
                if (x > 0.5f)
                {
                    float convertedFloatToAdd = (x * 1.609344f);
                    newMeasurements.Add(convertedFloatToAdd);
                }
            }
            return newMeasurements;
        }




public string Greeting(string name)
{

        Console.Write("What is your name?");

        name = Console.ReadLine();

         Console.WriteLine($"Hello {name} hope you are well!");
}




    public void AnimalOrFood()
        {
            Console.Write("Please enter option A, B, or C: ");
            string input = Console.ReadLine();
            switch(input)
            {
                case "A":
                    Console.WriteLine("alligator");
                    break;
                case "B":
                    Console.WriteLine("biscuit");
                    break;
                case "C":
                    Console.WriteLine("chihuahua");
                    break;
                default:
                    Console.WriteLine("spaghetti");
                    break;
            }
        }


    }


    
            

}

