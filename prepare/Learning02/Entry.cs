public class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    public Entry(string prompt, string response)
    {
        Date = DateTime.Now.ToString("yyyy-MM-dd");
        Prompt = prompt;
        Response = response;
    }

    public void Display()
    {
        Console.WriteLine($"{Date}: {Prompt}");
        Console.WriteLine(Response);
        Console.WriteLine();
    }
}
