class Scripture
{
    private Reference _reference;
   private Word _word;

   public Scripture(Reference reference, Word word)
   {
    _reference = reference;
    _word = word;
   }
   
   public void memorizeScripture()
   {
        Console.Clear();
        _reference.showReference();
        _word.showText();

        int words = _word.GetUniqueWords();
        for (int i = 0; i < words; i++)
        {
            Console.WriteLine("Press ENTER to begin memorizing or type 'quit' to exit.");
            String input = Console.ReadLine();
            if (input == "quit")
            {
                return;
            }
            else
            {
                Console.Clear();
                _reference.showReference();
                _word.showVerse(i);
            }
        }
   }
}