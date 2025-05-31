using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to Tie Shoelaces", "Samuel Costa", 100);
        video1.AddComment(new Comment("gobsmacker64", "Thank you for the good tutorial."));
        video1.AddComment(new Comment("lasagna_PARTY", "Finally, I've been trying to figure this out for ages!"));
        video1.AddComment(new Comment("alfieman", "Why was this on my recommended?"));

        Video video2 = new Video("How to Cook Spaghetti", "Brendan Brady", 300);
        video2.AddComment(new Comment("spaghettilover3000", "This is the worst video I have ever seen."));
        video2.AddComment(new Comment("jacobhansen7768", "I've never eaten italian, but I will someday."));
        video2.AddComment(new Comment("fast_and_complacent", "I think you overcooked it."));

        Video video3 = new Video("How to Breakdance", "Anna Thurston", 500);
        video3.AddComment(new Comment("raisnhell91", "Sick moves!"));
        video3.AddComment(new Comment("_kartwheel_", "What's the name of the song? It slaps."));
        video3.AddComment(new Comment("ungabunga", "That looks like it might hurt..."));

        Video video4 = new Video("How to Cook Chicken", "Ugochukwu Febechukwu", 200);
        video4.AddComment(new Comment("boldamericanhoorah", "I love chicken."));
        video4.AddComment(new Comment("MVP1", "Have you ever considered doing a mukbang?"));
        video4.AddComment(new Comment("GENHISKHAN", "I am so glad this turned up in my recommended!"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}