using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class VideoPost:Post
    {
        public string VideoURL {  get; set; }
        public float Length { get; set; }
        public VideoPost() { }

        public VideoPost(string title, string sendByUsername, bool isPublic, string videoURL, int Length)
        {
            this.ID = GetNextId();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
            this.VideoURL = videoURL;
            this.Length = Length;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3}  by {4}", this.ID, this.Title, this.VideoURL, this.Length, this.SendByUsername);
        }
        public static void  Play()
        {
            Console.WriteLine("Video has now started playing");
            
        }

    }
}
