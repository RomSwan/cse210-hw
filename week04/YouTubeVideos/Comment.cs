public class Comment
{
    private string _username;
    private string _comment;

    public Comment(string username, string comment)
    {
        _username = username;
        _comment = comment;
    }

    public string DisplayComment()
    {
        return $"-{_username}: {_comment}";
    }
}