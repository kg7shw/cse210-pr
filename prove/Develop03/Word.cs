class Word
{
    private string _text;
    public bool _IsHidden;
    

    public Word(string text)
    {
        _text = text;
        _IsHidden = false;
    }


    public string GetText()
    {
        return _text;
    }

    public bool GetIsHidden()
    {
        return _IsHidden;
    }

    // public void SetHidden(bool hidden)
    // {
    //     _IsHidden = hidden;
    // }

    public void HideWord()
    {
        _IsHidden = true;
    }
}
