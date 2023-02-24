 public class ReflectionActivity : Activity
    {
        private List<string> _prompts;
        private List<string> _reflectionQuestions;
        private string _prompt;
        private string _question;
        

        public ReflectionActivity(string name, string explanation, int duration):base(name,explanation,duration)
        {
            _prompts = new List<string>()
                    {
                    "Think of a time when you stood up for someone else.",
                    "Think of a time when you did something really difficult.", 
                    "Think of a time when you helped someone in need.", 
                    "Think of a time when you did something truly selfless."
                    };
            _reflectionQuestions = new List<string>()
                    {
                    "Why was this experience meaningful to you?",
                    "Have you ever done anything like this before?",
                    "How did you get started?",
                    "How did you feel when it was complete?",
                    "What made this time different than other times when you were not as successful?",
                    "What is your favorite thing about this experience?",
                    "What could you learn from this experience that applies to other situations?",
                    "What did you learn about yourself through this experience?",
                    "How can you keep this experience in mind in the future?",
                    };

        }
        public void GetRandomPrompt()
        {
            Random randomGenerator = new Random();
            int i = randomGenerator.Next(0,3);
            _prompt = _prompts[i];

            
        }
        public void GetRandomQuestion()
        {
            Random randomGenerator = new Random();
            int i = randomGenerator.Next(0,6);
            _question = _reflectionQuestions[i];  
            
        }
        public void DisplayPrompt()
        {
            Console.WriteLine(_prompt);
        }
        public void DisplayQuestion()
        {
            Console.WriteLine(_question);
        }

    }