public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;


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
}