public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>(); // List of words

        // Seperate and store the words from the verse
        string[] Words = text.Split(' ');
        foreach (string word in Words)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int wordsToHide)
    {
        Random random = new Random();
        int wordsHidden = 0;

        // Hide words until all are hidden
        while (wordsHidden < wordsToHide)
        {
            int index = random.Next(_words.Count);

            if (_words[index].IsHidden() == false)
            {
                _words[index].Hide();
                wordsHidden += 1;
            }

            if (IsCompletelyHidden())
            {
                break;
            }
        }
    }

    public string GetDisplayText()
    {   // Display the reference
        string display = _reference.GetDisplayText() + "\n";
        // Display the text
        foreach (Word word in _words)
        {
            display += word.GetDisplayText() + " ";
        }
        return display.Trim();
    }

    public bool IsCompletelyHidden() // Once all words are hidden, end the program
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }
}