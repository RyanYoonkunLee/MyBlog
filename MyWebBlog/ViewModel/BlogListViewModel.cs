﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebBlog.ViewModel
{
    public class BlogListViewModel
    {
        public Guid Id { get; set; }
        public string Date { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Thumbnail { get; set; }
        public string Language { get; set; }
    }
}
