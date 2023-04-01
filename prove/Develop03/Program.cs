using System;

class Program
{
    static void Main(string[] args)
    {        

        string book = "Moroni";
        string chapter = "10";
        string firstNumber = "4";
        string finalNumber = "5";

        // Get the reference of the scripture.
        Reference reference = new Reference(book, chapter, firstNumber, finalNumber);
        //string reference = heading.GetHeading();
        
        // Text
        // string t = "And when you receive these things, I would exhort you to a ask God the Eternal Father, in the name of Christ, if these things are not true; and if you ask with a sincere heart, with a true intent, having faith in Christ, he will manifest to you the truth of them by the power of the Holy Spirit and by the power of the Holy Spirit you will be able to know the truth of all things.";
        

        // Text text = new Text(t);
        // text.ConvertToList();

        // int totalWords = 0; //text.GetTotalWords();
        // Console.WriteLine(totalWords);

        // string userDecision = "";
        // int counter = 0;

        // do
        // {

        //     if (counter <= totalWords)
        //     {

        //         // clear the console
        //         //Console.Clear();
        //         Console.WriteLine("Scripture Memorizer");
        //         Console.WriteLine("");

                
        //         Scripture scripture = new Scripture(reference,t);
        //         scripture.Display();
        //         Console.WriteLine("");
                
        //         Console.WriteLine("Please press 'enter' to continue or type 'quit' to finish");
                
        //         counter += 1;
        //         t = text.GetNewText();
        //          userDecision = Console.ReadLine();
        //     }
        //     else
        //     {
        //         break;
        //     }

        // }
        // while (userDecision != "quit"); 
    }
}