﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Post
    {
        private static int currentPostId;

        //Properties
        protected int ID {  get; set; }
        protected string Title { get; set; }
        protected string SendByUsername { get; set; }   
        protected bool IsPublic { get; set; }

        public Post()
        {
            ID = 0;
            Title = "My First Post";
            IsPublic = true;
            SendByUsername = "Luke Bradbury";
        }

        //instance Constructor
        public Post(string title, bool isPublic, string sendByUsername)
        {
            this.ID = GetNextId();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
        }

        protected int GetNextId()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", this.ID, this.Title, this.SendByUsername);
        }
    }
}
