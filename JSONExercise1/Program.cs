using System;
using System.Text.Json;

namespace JSONExercise1
{

//🧩 1. Skriv text till en JSON-fil
//Be användaren skriva sitt namn och ålder, och spara det i en JSON-fil(user.json).
// 💡 Tips: använd JsonSerializer.Serialize() och File.WriteAllText().


//📖 2. Läs och visa JSON-filen
//Läs in filen du skapade i förra övningen och skriv ut innehållet i konsolen.
// 💡 Tips: använd JsonSerializer.Deserialize<T>().

//⚙️ 3. Try/Catch – fel vid inmatning
//Låt användaren skriva in ett tal.Om användaren skriver något som inte är ett tal, fånga felet med try/catch och visa ett meddelande:
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
                try
                {
                    // Försök konvertera inmatningen till int
                    user.Age = int.Parse(Console.ReadLine());

                    // Serialisera och spara till JSON
                    string stringjson = JsonSerializer.Serialize(user);
                    File.WriteAllText("user.json", stringjson);

                    Console.WriteLine($"Your name is {user.Name} and you are {user.Age} years old.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input! Please enter a valid number for age.");
                    return; // Avslutar programmet om inmatningen var fel
                }

                //the next step is to deserialize it
                string jsonFromFile = File.ReadAllText("user.json");
                User loadedUser = JsonSerializer.Deserialize<User>(jsonFromFile);

                //Then added some console writelines to show the deserialized data
                Console.WriteLine($"Name: {loadedUser.Name}");
                Console.WriteLine($"Age: {loadedUser.Age}");

            }

        }
    }
}
