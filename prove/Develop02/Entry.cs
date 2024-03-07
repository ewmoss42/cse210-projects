using System;

class Entry
{
    // date and time of the entry
    public string Date { get; set; }

    // prompt of the entry
    public string Prompt { get; set; }

    // response 
    public string Response { get; set; }

    // parameters and sets the date to the current date and time
    public Entry(string prompt, string response)
    {
        Date = DateTime.Now.ToString();
        Prompt = prompt;
        Response = response;
    }

    // Another constructor that takes the date, prompt, and response as parameters and sets the properties accordingly
    public Entry(string date, string prompt, string response)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
    }

    // An optional method that overrides the ToString method to return a formatted string representation of the journal entry
    public override string ToString()
    {
        return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\n";
    }
}