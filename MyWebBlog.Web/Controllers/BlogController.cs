using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyWebBlog.ViewModel;
using MyWebBlog.DataModel;
using MyWebBlog.ServiceLayer.Blog;
using MyWebBlog.Data.Sql.Database.DataAccess;

namespace MyWebBlog.Web.Controllers
{
    public class BlogController : Controller
    {
        BlogService blogservice;
        BlogDataAccess _blog;

        public BlogController()
        {
            blogservice = new BlogService();
            _blog = new BlogDataAccess();
        }

        public IActionResult Index()
        {
            var blogList = _blog.GetBlogList();
            var resultViewModel = blogservice.convertDataToViewModelList(blogList);

            return View(resultViewModel);
        }
        
        public IActionResult BlogDetail(Guid id)
        {
            var list = _blog.GetBlogList();
            BlogDataModel foundBlog = _blog.find(id);
            
            BlogDataModel previous = new BlogDataModel();
            BlogDataModel next = new BlogDataModel();
            
            for (var i=0; i<list.Count; i++)
            {
                if(foundBlog.Date == list[i].Date)
                {
                    if((i - 1) >= 0 )
                    {
                        previous = list[i - 1];
                    }                   
                    if((i+1) != list.Count)
                    {
                        next = list[i + 1];
                    }                   
                }
            }

            var blog = blogservice.ConvertDataToDetailModel(foundBlog, previous, next);
            blog.Thumbnail = _blog.FindLanguageImagePath(blog.Language);
            return View(blog);
        }
       
    }
}