class Program
{
    static void Main(string[] args)
    {        

        string book = "Moroni";
        string chapter = "10";
        string firstNumber = "4";
        string finalNumber = "5";

        //Get the reference of the scripture.
        Reference reference = new Reference(book, chapter, firstNumber, finalNumber);
        
        //Text
        string text = "And when you receive these things, I would exhort you to a ask God the Eternal Father, in the name of Christ, if these things are not true; and if you ask with a sincere heart, with a true intent, having faith in Christ, he will manifest to you the truth of them by the power of the Holy Spirit and by the power of the Holy Spirit you will be able to know the truth of all things.";
        
        //Initializating the Scripture
        Scripture scripture = new Scripture(reference, text);
        scripture.SetWordList();

        string userDecision = "";
        int counter = 0;
        int hiddenWords = scripture.GetTotalWords();

        do
        {
            Console.Clear();
            if (counter < scripture.GetTotalWords() + 1)
            {

                scripture.Display();
                scripture.HideWord();
                Console.WriteLine("");
                Console.WriteLine("Please press 'enter' to continue or type 'quit' to finish");
                userDecision = Console.ReadLine();
            }
            else
            {
                break;
            }
            counter += 1;

        }
        while (userDecision != "quit"); 
    }
}