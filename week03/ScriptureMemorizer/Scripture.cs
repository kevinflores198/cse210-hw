public class Scripture
{
    // Scripture is going to receive the reference from his Class
    private List<Word> _wordList = new List<Word>();
    private Reference _reference;
    public Scripture(Reference reference, string text)
    // for example: scripture(()'book',chapter,verse),'scripture text...');
    {
        _reference = reference;
        // we create an array of strings and for each 
        // part we use the ' ' divided because of the 
        // split. with a for loop we can get each word 
        // and know the length of each one. Knowin it 
        // we can hide it and replace with the underscode
        string[] parts = text.Split(' ');
        for (int i = 0; i < parts.Length; i++)
        {
            Word word = new Word(parts[i]);
            _wordList.Add(word);
        }
    }
    // It will hide words. we create a random variable to use.
    public void HideRandom(int hidding)
    {
        Random random = new Random();
        int hiddenCount = 0;
        // will do a while loop to know when 
        // the console will stop working, it 
        // will happen when all words are hidden.

        while (hidding > hiddenCount)
        {
            // we have to make sure that a word will not be hidden twice.
            // we index into the list and verify it, checking if the 
            // word is hidden by the class Word.
            int index = random.Next(_wordList.Count);
            Word word = _wordList[index];
            if (!word.Hidden())
            {
                word.Hide();
                hiddenCount++;
            }
            // if all is hidden, finished.
            if (IsAllHidden())
            {
                break;
            }
        }
    }
    // with a for loop we verify if all words are hidden, 
    // checkking with an if. If all hidden will return a 
    // false of all hidden. if not, will return a true 
    // and will continue hidding other words
    public bool IsAllHidden()
    {
        for (int i = 0; i < _wordList.Count; i++)
        {
            if (!_wordList[i].Hidden())
            {
                return false;
            }
        }
        return true;
    }
    public string GetDisplay()
    {
        // getting the complete reference to use.
        string refe = _reference.Display() + "\n";
        // it sees all words in the list again. 
        // in each word, use the display to shows 
        // if it's hidden or shown. use an space at the end. 
        for (int i = 0; i < _wordList.Count; i++)
        {
            refe += _wordList[i].Display() + " ";
        }
        return refe;
    }

}