using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebBlog.DataModel
{
    public class BlogDataModel
    {
        public Guid Id { get; set; }
        public string Writer { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Thumbnail { get; set; }
        public string Language { get; set; }
    }
}
