using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.SocialMedia
{
    public interface ISocialMediaPost
    {
        public string Title { get;  set; }
        public string Content { get;  set; }
        public string Author { get;  set; }
        public DateTime DateOfPosted { get;  set; }
        public List<string> Tags { get;  set; }
        public Uri ImageURL { get;  set; }
        public List<string> Links { get;  set; }

    }
}
