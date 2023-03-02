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
                    "Breathe out...",
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
        // public string GetMessage(int index)
        // {
        //     _message = _messages[index];
        //     return _message;
        // }
        
        public void DisplayMessage()
        {
            

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);
            
            int index = 0;

            while (DateTime.Now <= endTime)
            {

                _message = _messages[index];
                Console.Write(_message);
                Thread.Sleep(1000);
                ShowCountDown();
                Console.WriteLine();
                index++;
                if (index >= _messages.Count)
                {
                    Console.WriteLine();
                    index = 0;
                }

            }
        }
        public void ShowCountDown()
        {

            int index = 0;

            while (index <= 3)
            {
                string s = _numbers [index];
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                index++;
            }
        }

    }