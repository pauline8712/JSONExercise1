using System;
using System.Text.Json;

namespace JSONExercise1
{

//🧩 1. Skriv text till en JSON-fil
//Be användaren skriva sitt namn och ålder, och spara det i en JSON-fil(user.json).
// 💡 Tips: använd JsonSerializer.Serialize() och File.WriteAllText().

    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            {
                //Skriver text för att vägleda användaren. Så att de kan skriva in sitt namn.
                
                Console.WriteLine("PLease write down your name:");
                user.Name = Console.ReadLine();

                //Skriver text härmed för att vägleda användaren. Så att de kan skriva in sin ålder.
                //Däremot så kommer jag använda mig av TryParse ifall programmet skulle krascha.
                //Så det är därför jag har med string input
                Console.WriteLine("Please write down your age:");
                string input = (Console.ReadLine());

                //Skapar en if-sats för att kolla om inmatningen är korrekt.
                //Med en console.writeline som kommer att skriva upp en text med användarens input

                if (int.TryParse(input, out int age))
                {
                    //Här är jag osäker varför den ska vara med i ifsatsen. Men om jag förstår det rätt
                    //Så behöver jag den där så att inmatningen på ålder sparas i jsonfilen.
                    user.Age = age;
                    //Skapar en jsonfile och berättar för programmet att jag vill flytta objektet till en jsonfile
                    string stringjson = JsonSerializer.Serialize(user);
                    File.WriteAllText("user.json", stringjson);
                    
                    Console.WriteLine($"Your name is {user.Name} and you are {user.Age} years old.");
                }
                //Ifall användaren skriver in något annat än en siffra. Kör else
                else
                {
                    Console.WriteLine("Invalid input for age. Please enter a valid number.");
                }

            }

        }
    }
}
