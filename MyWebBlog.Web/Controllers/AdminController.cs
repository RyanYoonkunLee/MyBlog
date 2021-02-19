﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyWebBlog.Data.Sql.Database.DataAccess;
using MyWebBlog.DataModel;
using MyWebBlog.ServiceLayer.Blog;
using MyWebBlog.ViewModel;

namespace MyWebBlog.Web.Controllers
{
    public class AdminController : Controller
    {


        BlogService blogservice;
        BlogDataAccess _blog;

        public AdminController()
        {
            blogservice = new BlogService();
            _blog = new BlogDataAccess();
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult Index()
        {
            var blogList = _blog.GetBlogList();
            var resultViewModel = blogservice.convertDataToViewModelList(blogList);
            return View(resultViewModel);
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult BlogCreate()
        {
            BlogViewModel blog = new BlogViewModel();
            blog.writer = "Yoonkun Lee";
            return View(blog);
        }
        public IActionResult SendBlogItem(BlogViewModel blog)
        {
            BlogDataModel newBlog = blogservice.CreateNewBlog(blog);
            _blog.Create(newBlog);

            return RedirectToAction("Index", "Blog");
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult BlogUpdate(Guid id)
        {
            BlogDataModel foundBlog = _blog.find(id);
            var blog = blogservice.ConvertDataToDetailModel(foundBlog);

            return View(blog);
        }
        [HttpPost]
        [Route("Admin/BlogUpdate/{id?}")]
        public IActionResult BlogUpdate(BlogViewModel blog)
        {

            var updateBlog = blogservice.CreateBlogDataModel(blog);
            updateBlog.Id = blog.Id;
            _blog.Update(updateBlog);

            return RedirectToAction("Index", "Admin");
        }
        [Authorize(Roles = "Administrator")]
        public IActionResult BlogDelete(Guid id)
        {
            _blog.Delete(id);

            return RedirectToAction("Index", "Admin");
        }
    }
}