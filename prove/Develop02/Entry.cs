class Entry {
    public string _date;
    public string _prompt;
    public string _response;

    public Entry(string prompt, string response)
    {
        _date = DateTime.Now.ToShortDateString();
        _prompt = prompt;
        _response = response;
    }

    public string OutputEntry() 
    {
        return $"[{_date}] {_prompt} -- {_response}";
    }
}