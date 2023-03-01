 public class Activity
    {
        protected string _name;
        protected string _explanation;
        protected int _duration;
        protected string _outroMessage;
        private List<string> animationStrings;
        

        public Activity(string name,string explanation,int duration)
        {
            _name = name;
            _explanation = explanation;
            _duration = duration;

        }
        public void DisplayName()
        {

            Console.WriteLine(_name);
        }
        public void DisplayExplanation()
        {

            Console.WriteLine(_explanation);
        }
        public void ShowSpinner(int spinnerDuration)
        {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(spinnerDuration);
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        int index = 0;

        while (DateTime.Now >= endTime)
        {
            string s = animationStrings [index];
            Console.Write(s);
            Thread.Sleep(100);
            Console.Write("\b \b");
            index++;
            if (index >= animationStrings.Count)
            {
                index = 0;
            }
        }
        }

    }