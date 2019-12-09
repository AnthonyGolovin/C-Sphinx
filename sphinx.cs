using System;
using System.Threading;
using System.Collections.Generic;

public class Riddle
{
    public string Question;
    public string Answer;


    public Riddle(string question, string answer)
    {
        Question = question;
        Answer = answer;
    }

        // void questioning()
        // {
        // Riddle theRiddle = randomize();
        // Console.WriteLine(theRiddle.Question);
        // string answer = Console.ReadLine();
        // answering(answer);
        // }
        
        // void answering(string answer)
        // {
        //       if (answer == theRiddle.Answer)
        // {
        //     Console.WriteLine("Congratulations!");
        //     Thread.Sleep(1000);
        //     Console.WriteLine("Are you ready for the next question?");
        //     Thread.Sleep(2000);
        //     questioning();
        // }
        // else
        // {
        //     Console.WriteLine("Hahaha! I will now eat you!");
        // }
    
        // }
}

class Program
{
    static void Main()
    {
        Riddle firstRiddle = new Riddle("What kind of goose fights with snakes?", "mongoose");
        Riddle secondRiddle = new Riddle("I am wet when drying. What am I?", "towel");
        Riddle thirdRiddle = new Riddle("What word is always pronounced wrong?", "wrong");
        

        dynamic randomize()
        {
            Random rnd = new Random();
             int random = rnd.Next(1, 3);
             if (random == 1)
             {
                 return firstRiddle;
             }
             else if (random == 2)
             {
                 return secondRiddle;
             }
             else{
                 return thirdRiddle;
             }
        }
       
        

        Console.WriteLine("I am the mythical Sphinx! Bow before me!");
        Thread.Sleep(3000);
        questioning();

        void questioning()
        {
        Riddle theRiddle = randomize();
        Console.WriteLine(theRiddle.Question);
        string answer = Console.ReadLine();
        answering(answer, theRiddle);
        }
        
        void answering(string answer, Riddle theRiddle)
        {
              if (answer == theRiddle.Answer)
        {
            Console.WriteLine("Congratulations!");
            Thread.Sleep(1000);
            Console.WriteLine("Are you ready for the next question?");
            Thread.Sleep(2000);
            questioning();
        }
        else
        {
            Console.WriteLine("Hahaha! I will now eat you!");
        }
    
        }
    }
}