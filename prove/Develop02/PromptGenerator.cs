using System;
using System.Collections.Generic;
using System.Linq;
					
public class PromptGenerator {

	public static void GeneratePrompt()	{

		List<string> _prompts = new List<string>(new string[] { 
            "What was the best experience I had today? ", 
            "What was the worst experience I had today? ", 
            "What was something that I am proud to have performed today? ",
            "Did I meet someone new today? If positive, what is the name of that person? ",
            "Did I do everything I planned for today? If not, what didn't I do? " });

		Random Selector = new Random();
 
		int indexSelector = Selector.Next(0, _prompts.Count());

		public List<string> _chosenPrompt = new List<string>;
		_chosenPrompt.Add(_prompts.ElementAt(indexSelector))

		Console.WriteLine(_prompts.ElementAt(indexSelector)); // Here the program will select a random prompt

	}

}
