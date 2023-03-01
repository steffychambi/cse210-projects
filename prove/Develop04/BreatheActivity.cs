 public class BreatheActivity : Activity
    {
        private List<string> _numbers = new List<string>()
                    {
                    "4",
                    "3",
                    "2",
                    "1", 
                    };
        private List<string> _messages = new List<string>()
                    {
                    "Breathe in...",
                    "Hold for...",
                    "Breathe in...",
                    "Hold for...", 
                    };
        private string _message;
       
        

        public BreatheActivity()
        {
            _name = "Breathing Activity";
            _explanation = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        }
        // public string GetName()
        // {
        //     _name = "Breathing Activity";
        //     return _name;
        // }
        // public string GetExplanation()
        // {
        //     _explanation = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        //     return _explanation;
        // }
        public int GetDuration(int duration)
        {
            _duration = duration;
            return _duration;
        }
        public string GetMessage(int index)
        {
            _message = _messages[index];
            return _message;
        }
        
        public void DisplayMessage()
        {
            Console.WriteLine(_message);
        }
        public void ShowCountDown()
        {

            int index = 0;

            while (index <= 3)
            {
                string s = _numbers [index];
                Console.Write(s);
                Thread.Sleep(100);
                Console.Write("\b \b");
                index++;
            }
        }

    }