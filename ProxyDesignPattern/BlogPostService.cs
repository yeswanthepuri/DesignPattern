using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    public class BlogPostService : IBlogPostService
    {
        public IList<Blog> GetAllBlogs()
        {
            Thread.Sleep(100);
            List<Blog> list = new List<Blog>()
            {
                new Blog() { Author = "Yeswanth", Details = "Want to work on Generative AI? you are on the right place", Rating = 3, Title = "Generative AI" },
                new Blog() { Author = "Yeswanth", Details = "Want to work on Hacking? you are on the right place", Rating = 3, Title = "Hack using AI" },
                new Blog() { Author = "Sai Rakshith", Details = "Want to work on How to make videous on AI? you are on the right place", Rating = 3, Title = "Video AI" },
                new Blog() { Author = "Yeswanth", Details = "Want to work on Generative AI? you are on the right place", Rating = 3, Title = "Hack Using Genative AI" }
            };
            return list;
        }
    }
}
