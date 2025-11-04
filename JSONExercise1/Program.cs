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

            }

        }
    }
}
