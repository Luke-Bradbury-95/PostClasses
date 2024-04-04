using ConsoleApp1;

Post post1 = new Post("Thanks for the teaching Sauv", true, "Luke B");
Post post2 = new Post("omg youll never reach the top WATCHING pokemon, but its okay we dont need competitors on this mountain", true, "Sauv");
Console.WriteLine(post1);
Console.WriteLine(post2);
Console.ReadLine();
ImagePost imagePost = new ImagePost("Check my meatballs out", "Luke Bradbury", "https://image.com/meatballs",true);
Console.WriteLine(imagePost.ToString());
Console.ReadLine();
VideoPost videoPost = new VideoPost("Video teaching sauv motivational speeches", "Luke Bradbury", true, "https://video.com/Motivation", 30);
Console.WriteLine(videoPost.ToString());
Console.ReadKey();
videoPost.Play();
Console.ReadKey();
videoPost.Stop();
