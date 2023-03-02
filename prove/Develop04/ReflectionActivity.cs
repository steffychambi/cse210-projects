 public class ReflectionActivity : Activity
    {
        private List<string> _prompts;
        private List<string> _reflectionQuestions;
        private string _prompt;
        private string _question;
        

        public ReflectionActivity()
        {
            _name = "Reflecting Activity";
            _explanation = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
            _prompts = new List<string>()
                    {
                    "Think of a time when you stood up for someone else.",
                    "Think of a time when you did something really difficult.", 
                    "Think of a time when you helped someone in need.", 
                    "Think of a time when you did something truly selfless."
                    };
            _reflectionQuestions = new List<string>()
                    {
                    "> Why was this experience meaningful to you? ",
                    "> Have you ever done anything like this before? ",
                    "> How did you get started? ",
                    "> How did you feel when it was complete? ",
                    "> What made this time different than other times when you were not as successful? ",
                    "> What is your favorite thing about this experience? ",
                    "> What could you learn from this experience that applies to other situations? ",
                    "> What did you learn about yourself through this experience? ",
                    "> How can you keep this experience in mind in the future? ",
                    };

        }
        public void GetRandomPrompt()
        {
            Random randomGenerator = new Random();
            int i = randomGenerator.Next(0,3);
            _prompt = _prompts[i];

            
        }
        public void GetAQuestion(int i)
        {
            _question = _reflectionQuestions[i];  
            
            
        }
        public void DisplayPrompt()
        {
            GetRandomPrompt();
            Console.WriteLine("Consider the following prompt:");
            Console.WriteLine();
            Console.WriteLine($"---- {_prompt} ----");
            Console.WriteLine();
        }
        public void DisplayQuestions()
        {
            Console.Write(_question);
            ShowSpinner(10);
        }

        public void RunActivity()
        {
            DisplayPrompt();
                Console.WriteLine("When you have something in mind press enter to continue");
                Console.ReadLine();
                Console.WriteLine("Now ponder on each of the following question as they related to this experience.");
                Console.Write("You may begin in ");
                ShowCountDown(5);
                Console.Clear();

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);
            
            int index = 0;

            while (DateTime.Now <= endTime)
            {
                GetAQuestion(index);
                DisplayQuestions();
                index++;
                if (index == _reflectionQuestions.Count) 
                {
                    index = 0;
                }
            }
        }

    }