using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.SocialMedia
{
    public class SocialMediaPostBuilder
    {
        private readonly SocialMediaPost socialMediaPost;
        public SocialMediaPostBuilder()
        {
            socialMediaPost = new SocialMediaPost();
        }
        public SocialMediaPostBuilder SetTitle(string title)
        {
            socialMediaPost.Title = title; 
            return this;
        }
        public SocialMediaPostBuilder SetTags(string tag)
        {
            if(socialMediaPost.Tags== null)
            {
                socialMediaPost.Tags = new List<string>();
            }
            socialMediaPost.Tags.Add(tag);
            return this;
        }
        public SocialMediaPostBuilder SetLinks(string link)
        {
            if (socialMediaPost.Links == null)
            {
                socialMediaPost.Links = new List<string>();
            }
            socialMediaPost.Links.Add(link);
            return this;
        }
        public SocialMediaPostBuilder SetAuthor(string author)
        {
            socialMediaPost.Author = author;
            return this;
        }
        public SocialMediaPostBuilder SetLinks(Uri imageURL)
        {
            socialMediaPost.ImageURL = imageURL;
            return this;
        }
        public SocialMediaPostBuilder SetDateOfPosts(DateTime dateOfPosts)
        {
            socialMediaPost.DateOfPosted = dateOfPosts;
            return this;
        }
        public SocialMediaPostBuilder SetContent(string content)
        {
            socialMediaPost.Content = content;
            return this;
        }
    
        public SocialMediaPost Build() {
            return socialMediaPost;
        }
    }
}
