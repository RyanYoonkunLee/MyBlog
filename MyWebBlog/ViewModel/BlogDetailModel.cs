using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebBlog.ViewModel
{
    public class BlogDetailModel
    {
        public Guid Id { get; set; }
        public string Writer { get; set; }
        public string Body { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }

        public virtual BlogDetailRecommend Next { get; set; }
        public virtual BlogDetailRecommend Previous { get; set; }
    }
}
