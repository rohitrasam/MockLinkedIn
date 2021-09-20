using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedinApp.Models
{
    public class Activity
    {
        public User User { get; set; }
        public string Description { get; set; }
        public string ImageUri { get; set; }
        public int Likes { get; set; }
        public int Comments { get; set; }


    }
}
