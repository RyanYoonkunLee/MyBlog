using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebBlog.ViewModel
{
    public class BlogViewModel
    {
        public Guid Id { get; set; }
        public string Writer { get; set; }
        public string Body { get; set; }
        public string Title { get; set; }
        public string Thumbnail { get; set; }
        public string Language { get; set; }
    }
}
