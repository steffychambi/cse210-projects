using System;

class Program
{
    static void Main(string[] args)
    {
        //Creates the first video
        Video video1 = new Video("How to improve your way of studying","Polo Guerrero.",1050);
        
        //Creating comments for the first video:
        //Comment 1:
        string text1 = "I am a civil engineering student, my average is 7/10 very often, however, I want to take a step forward. I will apply your advice doc, thanks.";
        Comment comment1 = new Comment("Ailed Walker", text1);
        //Comment 2:
        string text2 = "I study Nursing and they don't let me breathe with so many books But I like it I know this will help me thank you doc.";
        Comment comment2 = new Comment("Aldair Cruz", text2);
        //Comment 3:
        string text3 = "I needed this, since I am studying health, I am doing my third year of high school, but I have to learn many things and, above all, learn technical language, thank you very much Dr Polo.";
        Comment comment3 = new Comment("Kenny Mejia", text3);

        //Adding comments to a list inside of the first video
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        //Creates the second video
        Video video2 = new Video("10 things I learned in therapy that changed my life.","Consciousness Psychology",546);
        
        //Creating comments for the second video:
        //Comment 1:
        string text4 = "Thank you, what a beautiful video and with such important information.";
        Comment comment4 = new Comment("Jhan Piert Pimentel", text4);
        //Comment 2:
        string text5 = "I loved the video, thank you very much for adding value in these deep topics.";
        Comment comment5 = new Comment("German Fernandez", text5);
        //Comment 3:
        string text6 = "This video has to have more reach, we all need to hear it.";
        Comment comment6 = new Comment("Magali Ferreyra", text6);

        //Adding comments to a list inside of the second video
        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);

        //Creates the third video
        Video video3 = new Video("Think Fast, Talk Smart: Communication Techniques.","Stanford Graduate School of Business",3559);
        
        //Creating comments for the third video:
        //Comment 1:
        string text7 = "He is very confident, calm and knows exactly what he is doing. He has the pulse of the audience. Even as an online audience, I found it very interactive.";
        Comment comment7 = new Comment("Panchajanya Sanyal", text7);
        //Comment 2:
        string text8 = "He Never uses 'um','well','ah','hmm' for 50mins. Incredible....";
        Comment comment8 = new Comment("Leroy Heim", text8);
        //Comment 3:
        string text9 = "I think apart from communication these rules can also be applied to our daily life to make it more easier and simpler.";
        Comment comment9 = new Comment("Ismail Shareef Mohammed", text9);

        //Adding comments to a list inside of the third video
        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);

        //Creating the list of Videos
        List<Video> videos = new List<Video>();

        //Adding videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        Console.Clear();

        //Iterating through the list of videos to display their information
        int numVideo = 0;
        foreach (Video i in videos)
        {
            numVideo++;
            Console.WriteLine($"Video Number {numVideo}\n\r");
            i.DisplayAll();
            Console.WriteLine();
        }
    }
}