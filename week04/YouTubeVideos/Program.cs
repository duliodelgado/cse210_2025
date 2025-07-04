// Program.cs – creates 3 videos, each with 3 comments, then prints them
// By Dulio Delgado

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // ----- Create video #1 -----
        Video vid1 = new Video
        {
            Title  = "Amazing Skate Tricks",
            Author = "Sk8rKid99",
            LengthSec = 230
        };
        vid1.AddComment(new Comment("Ava",  "That kickflip was insane!"));
        vid1.AddComment(new Comment("Liam", "I wish I could skate like that."));
        vid1.AddComment(new Comment("Mia",  "What camera did you use?"));

        // ----- Create video #2 -----
        Video vid2 = new Video
        {
            Title  = "Top 5 Minecraft Builds",
            Author = "BlockMaster",
            LengthSec = 545
        };
        vid2.AddComment(new Comment("Noah",   "The castle is my favorite."));
        vid2.AddComment(new Comment("Sophia", "I love the secret base idea!"));
        vid2.AddComment(new Comment("Ethan",  "Tutorial please?"));

        // ----- Create video #3 -----
        Video vid3 = new Video
        {
            Title  = "How to Solve Rubik's Cube Fast",
            Author = "CubeGirl",
            LengthSec = 310
        };
        vid3.AddComment(new Comment("Olivia", "Solved mine in 2 minutes now!"));
        vid3.AddComment(new Comment("James",  "Step 4 was tricky but helpful."));
        vid3.AddComment(new Comment("Emma",   "Great explanation, thanks!"));

        // Put all videos into a list
        List<Video> videos = new List<Video> { vid1, vid2, vid3 };

        // ----- Display every video and its comments -----
        foreach (Video v in videos)
        {
            v.DisplayVideoInfo();
        }

        // keep console open when running with VS Code "Run" button
        Console.WriteLine("Press any key to finish...");
        Console.ReadKey();
    }
}