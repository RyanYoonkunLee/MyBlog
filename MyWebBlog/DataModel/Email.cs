using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebBlog.DataModel
{
    public class Email
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Email SenderEmail { get; set; }
        public string Message { get; set; }
    }
}
