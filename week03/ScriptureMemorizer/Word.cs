public class Word
{
    private string _text;
    private bool _hidden = false;
    public Word(string text)
    {
        _text = text;
    }
    // Used to hide a word when changes to false. 
    // if we use word.tostring() it will print "__"
    public void Hide()
    {
        _hidden = true;
    }
    // shows true if the word isn't hide, and false if it's hide. 
    // the important is not be hidding words that are already hidden.
    public bool Hidden()
    {
        return _hidden;
    }
    // will show how the word is shown when is a text. 
    // If hidden is false, will show the word. when _hidden 
    // is true will show "_" in each word on the text.
    public string Display()
    {
        // if the word is hidden we shows "_" 
        // in each letter of the word, for that 
        // reason we use Length into the new String.
        if (_hidden)
        {
            return new String('_', _text.Length);
        }
        // else, we return the word.
        else
        {
            return _text;
        }
    }
}