using System;

public class Entry {

    public void AddEntry() {

        public string _userEntry = Console.ReadLine();
        DateTime now = DateTime.Now;
        string date = now.ToShortDateString();
        _entries.Add("Date: " + date + " - " + _chosenPrompt + "\n" + _userEntry); // Here I add the date to the rest

    }

}