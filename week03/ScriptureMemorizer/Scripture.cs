public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] Words = text.Split(' ');
        foreach (string word in Words)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int wordsToHide)
    {
        Random rand = new Random();
        int wordsHidden = 0;

        while (wordsHidden < wordsToHide)
        {
            int index = rand.Next(_words.Count);

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
    {
        string display = _reference.GetDisplayText() + "\n";
        foreach (Word word in _words)
        {
            display += word.GetDisplayText() + " ";
        }
        return display.Trim();
    }

    public bool IsCompletelyHidden()
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