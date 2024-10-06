class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(string filePath)
    {

        // This criterion is linked to a Learning Outcome10. Shows creativity and exceeds core requirements
        _reference = LoadReferenceFromFile(filePath);
        _words = LoadWordsFromFile(filePath);
    }


    // This criterion is linked to a Learning Outcome10. Shows creativity and exceeds core requirements
    private Reference LoadReferenceFromFile(string filePath)
    {
        string[] lines = File.ReadAllLines(filePath);
        string referenceText = lines[0];

        string[] parts = referenceText.Split(' ');
        string book = parts[0];
        string[] chapterAndVerses = parts[1].Split(':');
        int chapter = int.Parse(chapterAndVerses[0]);

        string[] verses = chapterAndVerses[1].Split('-');
        int startVerse = int.Parse(verses[0]);
        int endVerse = verses.Length > 1 ? int.Parse(verses[1]) : startVerse;

        return new Reference(book, chapter, startVerse, endVerse);
    }


    // This criterion is linked to a Learning Outcome10. Shows creativity and exceeds core requirements
    private List<Word> LoadWordsFromFile(string filePath)
    {
        string[] lines = File.ReadAllLines(filePath);
        string scriptureText = string.Join(" ", lines.Skip(1));
        string[] wordsArray = scriptureText.Split(' ');

        List<Word> words = new List<Word>();
        foreach (string wordText in wordsArray)
        {
            words.Add(new Word(wordText));
        }

        return words;
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        int wordsToHide = 4;
        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(_words.Count);
            _words[index].Hide();
        }
    }

    public void DisplayScripture()
    {
        Console.WriteLine(_reference.GetDisplayText());
        foreach (Word word in _words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
        Console.WriteLine();
    }

    public bool AllWordsHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}
