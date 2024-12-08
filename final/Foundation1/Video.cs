using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Transactions;

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
        _comments = new List<Comment>();
    }


    public void AddComment(Comment comment)
    {
        if (comment != null)
        {
            _comments.Add(comment);
        }
        else
        {
            throw new ArgumentException("Comment cannot be null.");
        }
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public override string ToString()
    {
        int minutes = _length / 60;
        int seconds = _length % 60;
        string lengthStr = _length >= 60 ? $"{minutes}m {seconds}s" : $"{_length}s";

        return $"Title: {_title}\nAuthor: {_author}\nLength: {lengthStr}\nComments: {GetCommentCount()}";
    }

    public void DisplayComments()
    {
        foreach (var comment in _comments)
        {
            Console.WriteLine($"  - {comment}");
        }
    }
}