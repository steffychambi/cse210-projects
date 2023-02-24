 public class Activity
    {
        protected string _name;
        protected string _explanation;
        protected int _duration;
        protected string _outroMessage;
        

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
        public void ShowSpinner()
        {

        }

    }