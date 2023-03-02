 public class BreatheActivity : Activity
    {
        private List<string> _messages = new List<string>()
                    {
                    "Breathe in...",
                    "Hold for...",
                    "Now Breathe out...",
                    "Hold for...", 
                    };
        private string _message;
       
        

        public BreatheActivity()
        {
            _name = "Breathing Activity";
            _explanation = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        }
        
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
                ShowCountDown(4);
                Console.WriteLine();
                index++;
                if (index >= _messages.Count)
                {
                    Console.WriteLine();
                    index = 0;
                }

            }
        }
        

    }