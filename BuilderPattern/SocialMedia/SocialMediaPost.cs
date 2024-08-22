using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.SocialMedia
{
    public class SocialMediaPost : ISocialMediaPost
    {
        private string title;
        private string content;
        private string author;
        private DateTime dateOfPost;
        private List<string> tags;
        private Uri imageURL;
        private List<string> links;

        public string Title { get { return title; }  set { title = value; } }

        public string Content { get { return content; }  set { content = value; } }

        public string Author { get { return author; }  set { author = value; } }

        public DateTime DateOfPosted { get { return dateOfPost; }  set { dateOfPost = value; } }

        public List<string> Tags { get { return tags; }  set { tags = value; } }

        public Uri ImageURL { get { return imageURL; }  set { imageURL = value; } }

        public List<string> Links { get { return links; }  set { links = value; } }

    }
}
