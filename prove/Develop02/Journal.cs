using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    static void Main(string[] args) {

        string option = "1"; // Jut to make sure that the do-while loop will work well, 
                             // I added the value "1" to the option variable

        do {
        
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            option = Console.ReadLine();

            if (option == "1") { // Code to write in the Journal

                PromptGenerator prompts = new PromptGenerator();
                prompts.GeneratePrompt();

                public List<string> _entries = new List<string>;
                
                Entry newEntry = new Entry();
                newEntry.AddEntry();

            }
            else if (option == "2") { // Code to display what's written in the Journal

                Console.WriteLine("Enter a file to Display: ");
                string filename = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(",");
                    Console.WriteLine(line);
                }

            }
            else if (option == "3") { // Code to load a file

                Console.WriteLine("Enter a file to Load: ");
                string filename = Console.ReadLine();
                StreamReader sr = new StreamReader(filename);

            }
            else if (option == "4") { // Code to save what has been written in the Journal

                Console.WriteLine("Enter a file to Save: ");
                string filename = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(filename)) {

                    foreach (string entry in _entries) {
                        
                        outputFile.WriteLine($"{entry},");

                    }

                }

            }
            else { // Code to quit

                Console.WriteLine("Bye bye!");
                break;

            }

        } while (option == "1" || option == "2" || option == "3" || option == "4"); // The user can insert "5" or any other info to quit the program
        
    }

}
