public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();


    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int ReturnNumComments()
    {
        return _comments.Count;
    } 
    public void DisplayAll()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length in seconds: {_length.ToString()}");
        Console.WriteLine($"Number of comments: {ReturnNumComments().ToString()}");
        Console.WriteLine("Comments:");

        foreach (Comment i in _comments)
        {
            Console.WriteLine(i.GetComment());
        }

    }
}