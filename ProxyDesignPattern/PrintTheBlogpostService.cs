using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    public class PrintTheBlogpostService : IBlogPostService
    {
        private readonly IBlogPostService blogPostService;

        public PrintTheBlogpostService(IBlogPostService blogPostService)
        {
            this.blogPostService = blogPostService;
        }
        public IList<Blog> GetAllBlogs()
        {
           var blogs = blogPostService.GetAllBlogs();
            foreach (var blog in blogs) {
                Console.WriteLine($"You are reding a blog writen by : '{blog.Author}' on the topic :'{blog.Title}'");
            }
            return blogs;
        }
    }
}
