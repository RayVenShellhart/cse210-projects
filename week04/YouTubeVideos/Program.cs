using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {

        Console.Clear();

        List<Video> videosList = new List<Video>();

        // Video one
        Video video = new Video("How to use an Airfryer", "Dave Fryer", 600);
        Comments comments1 = new Comments();
        comments1._name = "Dale Landry";
        comments1._comment = "Thank you, airfryers have alway been a struggle for me!";
        Comments comments2 = new Comments();
        comments2._name = "Kari Shepherd";
        comments2._comment = "Thanks Dave for this walkthrough. I was so lost on how to use the airfryer my son get me for christmas!";
        Comments comments3 = new Comments();
        comments3._name = "Otis Madden";
        comments3._comment = "Great Video. Though my airfryer has some diffrent buttons. Any Advice?";
        Comments comments4 = new Comments();
        comments4._name = "Leonardo Hudson";
        comments4._comment = "Wish I had an airfryer.";

        video._text.Add(comments1);
        video._text.Add(comments2);
        video._text.Add(comments3);
        video._text.Add(comments4);

        videosList.Add(video);


        // Video 2
        Video video1 = new Video("An unpopular opinion about cheese", "FoodOpinions", 1200);
        Comments comments5 = new Comments();
        comments5._name = "Florine Weiss";
        comments5._comment = "Definitely an unpopular choice for a reason.";
        Comments comments6 = new Comments();
        comments6._name = "Erika Caldwell";
        comments6._comment = "I Never thought about it like that.";
        Comments comments7 = new Comments();
        comments7._name = "Santiago Lee";
        comments7._comment = "I'm Not fond of cheese.";

        video1._text.Add(comments5);
        video1._text.Add(comments6);
        video1._text.Add(comments7);

        videosList.Add(video1);

        // video 3
        Video video2 = new Video("The Philadelphia Trip You'll never forget", "TravelTrips", 1800);
        Comments comments8 = new Comments();
        comments8._name = "Leigh House";
        comments8._comment = "I'm excited for my own trip.";
        Comments comments9 = new Comments();
        comments9._name = "Roosevelt Ingram";
        comments9._comment = "I will use this as my guide.";
        Comments comments10 = new Comments();
        comments10._name = "Rolland Mclean";
        comments10._comment = "I wonder if Philadelphia well ever finish construction. You know since it's been about 40 years";

        video2._text.Add(comments8);
        video2._text.Add(comments9);
        video2._text.Add(comments10);

        videosList.Add(video2);


        foreach (Video item in videosList)
        {
            item.DisplayAll();
            Console.WriteLine("\n");
        }




    }
}