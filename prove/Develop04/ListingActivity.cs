 public class ListingActivity : Activity
    {

        public ListingActivity()
        {
            _name = "Listing Activity";
            _explanation = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
            _prompts = new List<string>()
                    {
                    "Who are people that you appreciate?",
                    "What are personal strengths of yours?",
                    "Who are people that you have helped this week?",
                    "When have you felt the Holy Ghost this month?",
                    "Who are some of your personal heroes?"
                    };
        }

        public void RunActivity()
        {
            Console.WriteLine("List as many responses you can to the following prompt");
            DisplayPrompt();
            Console.Write("You may begin in ");
            ShowCountDown(5);

            Console.WriteLine();

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);
            int counter = 0;

            while (DateTime.Now <= endTime)
            {
                Console.Write("> ");
                Console.ReadLine();
                counter++;
            }
            Console.WriteLine($"You have listed {counter} items.");
        }

    }