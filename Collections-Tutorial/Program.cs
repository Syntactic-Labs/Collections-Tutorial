using System;
using System.Collections.Generic;

namespace Collections_Tutorial
{
    class Program
    {
        static void Main(string[] args)                    //!!!Bowling Game!!!
        {   // rnd becomes random number generating var
            var rnd = new Random();
            // frames is the name of my list/array
            var frames = new List<int>();
            // idx starts at zero. Remains active till 10. Goes up by one each time
            for (int idx = 0; idx < 10; idx++)
            {   // puts rnd results into frame. frame is collected into frames
                var frame = rnd.Next(0, 31);            
                frames.Add(frame);
            }
            //container to put scores from
            var game = 0;
            //score is a container for all the frames
            foreach (var score in frames)
            {   //game is my total
                game += score;                          
            }
            Console.WriteLine($"Games is {game}");




            ////Simply finding the sum in a collection of numbers
            //var listOfNumbers = new List<int>();
            //listOfNumbers.Add(98);
            //listOfNumbers.Add(7);
            //listOfNumbers.Add(56);
            //listOfNumbers.Add(13);
            //listOfNumbers.Add(72);
            //listOfNumbers.Add(42);
            //listOfNumbers.Add(44);
            //var sum = 0;

            //foreach(var nbr in listOfNumbers)
            //{
            //    sum += nbr;  //  sum = sum + nbr
            //}
            //Console.WriteLine($"Sum is {sum}");
        }
    }
}
