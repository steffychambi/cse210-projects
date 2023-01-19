using System;

    // Keeps track of the company, job title, start year, and end year.
    public class Job
    {
        public string _company = "";
        public string _jobTitle = "";
        public int _startYear = 0;
        public int _endYear = 0;

        // A special method, called a constructor that is invoked using the  
        // new keyword followed by the class name and parentheses.
        public Job()
        {
        }
        //Displays the job information in the format "Job Title (Company) StartYear-EndYear",
        //for example: "Software Engineer (Microsoft) 2019-2022".
        public void Display()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        }

    }