public class Activity
    {
        protected string _name;
        protected string _explanation;
        protected int _duration;
        protected string _outroMessage;
        private List<string> animationStrings;
        

        public Activity()
        {
            _outroMessage = "Well done!";
        }
        public void DisplayName()
        {

            Console.WriteLine("Welcome to " + _name);
        }
        public void DisplayExplanation()
        {

            Console.WriteLine(_explanation);
        }
        public int GetDuration(int duration)
        {
            _duration = duration;
            return _duration;
        }
        public void ShowSpinner(int spinnerDuration)
        {

            animationStrings =  new List<string>();
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");

            int index = 0;
            
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(spinnerDuration);
            while (DateTime.Now <= endTime)
            {
                string s = animationStrings [index];
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                index++;
                if (index >= animationStrings.Count)
                {
                    index = 0;
                }
            }
        }
        public void StartRunning()
        {
            DisplayName();
            Console.WriteLine();
            DisplayExplanation();
            Console.WriteLine();
            Console.Write("How long, in seconds, would you like to perform this activity? ");
            GetDuration(int.Parse(Console.ReadLine()));
            Console.Clear();
            Console.WriteLine("Get Ready...");
            ShowSpinner(5);
        }

        public void DisplayOutroMessage()
        {
            Console.WriteLine();
            Console.WriteLine(_outroMessage);
            Console.WriteLine();
            Console.WriteLine($"You have completed another {_duration} of the {_name}.");
            ShowSpinner(5);
        }
    }