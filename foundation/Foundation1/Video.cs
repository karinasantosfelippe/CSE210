namespace Foundation1
{
    public class Video
    {
        public string _title;
        public string _author;
        public int _length; // in seconds
        public List<Comment> _comments;

        public int NumberOfComments() => _comments.Count;
    }
}