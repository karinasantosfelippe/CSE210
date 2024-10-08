/*
Author: Karina Santos Felippe
*/
namespace Foundation1;
class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = [];

        Video video1 = new(){
            _author = "@karinasantosfelippe",
            _title = "Hello World",
            _length = 120,
            _comments = [
                new Comment() { _commentAuthor = "Author 1", _text = "What an amazing video!" },
                new Comment() { _commentAuthor = "Author 2", _text = "I liked your video!"},
                new Comment() { _commentAuthor = "Author 3", _text = "You are so talented!"},
            ]
        };
        videos.Add(video1);
        
        Video video2 = new(){
            _author = "@manualdomundo",
            _title = "How to make an original origami",
            _length = 480,
            _comments = [
                new Comment() { _commentAuthor = "John", _text = "Great job!" },
                new Comment() { _commentAuthor = "Marco", _text = "I want to practice this!"},
                new Comment() { _commentAuthor = "Jennifer", _text = "Very nice!"},
            ]
        };
        videos.Add(video2);

        Video video3 = new(){
            _author = "@edukof",
            _title = "Using my new drone",
            _length = 1300,
            _comments = [
                new Comment() { _commentAuthor = "Person 1", _text = "WOW!" },
                new Comment() { _commentAuthor = "Person 2", _text = "You are crazy!"},
                new Comment() { _commentAuthor = "Person 3", _text = "So dangerous!"},
                new Comment() { _commentAuthor = "Person 4", _text = "I will tell your mom!"},
            ]
        };
        videos.Add(video3);

        Console.Clear();
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds.");
            Console.WriteLine($"Number of comments: {video.NumberOfComments()}.");

            foreach(Comment comment in video._comments)
            {
                Console.Write($"\t{comment._commentAuthor}: ");
                Console.WriteLine($"\"{comment._text}\"");
            }

            Console.WriteLine();
        }
    }
}