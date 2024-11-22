using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Hobby_generator
{
    internal class Oppgave
    {
        
        static string[] hobby = { "Golfing", "feeling the ironpum", "sliding down skisloopes", "programming", "Watching nascar" };
        static Random rand = new Random();
        int randomHobby = rand.Next(0, hobby.Length);

        public void Run()
        {
            Console.WriteLine("Would you like a new hobby?");
            string inputName = Console.ReadLine();
            if (randomHobby == 0)
            {
                Console.WriteLine($"{inputName}'s new hobby is {hobby[randomHobby]}");
            }
            else if (randomHobby == 2)
            {
                Console.WriteLine($"{inputName}'s new hobby is {hobby[randomHobby]}");
            }
            else if (randomHobby == 3)
            {
                Console.WriteLine($"{inputName}'s new hobby is {hobby[randomHobby]}");  
            }
            else if (randomHobby == 4)
            {
                Console.WriteLine($"{inputName}'s new hobby is {hobby[randomHobby]}");
            }
            else if (randomHobby == 5)
            {
                Console.WriteLine($"{inputName}'s new hobby is {hobby[randomHobby]}");
            }
            





        }


        /*Vi starter med å lage et array for å hente ut hobbyene som vi skal hente ut.
          Vi lager også en random funksjon som skal gi oss et tilfeldig array.
          int randomHobby = rand.next(0,hobby.length); Her starter vi å telle fra 0 og bortover hele lengden til arrayet.
        Console.Readline() lar oss å skrive inn det vi ønsker inn i konsollen.
          Console.Writeline() printer eller skriver ut tekst som vi ikke har skrevet ut i konsollen.
          $"{inputName}" Her henter vi ut verdien til variablen vår.
          $"{hobby[randomHooby]}". Her hente vi ut arrayene våres.
          
        */
    }
}
