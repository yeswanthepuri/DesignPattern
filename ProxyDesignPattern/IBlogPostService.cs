﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    public interface IBlogPostService
    {
        IList<Blog> GetAllBlogs();
    }
}
