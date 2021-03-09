using System;
using System.Collections.Generic;
using System.Text;
using MyWebBlog.DataModel;
using MyWebBlog.ViewModel;

namespace MyWebBlog.ServiceLayer.Blog
{
    public class BlogService
    {       
        public BlogDataModel CreateNewBlog(BlogViewModel blog)
        {
            
            BlogDataModel newBlog = CreateBlogDataModel(blog);
            newBlog.Id = Guid.NewGuid();
            return newBlog;
        }

        public BlogDataModel CreateBlogDataModel(BlogViewModel blog)
        {
            BlogDataModel newBlog = new BlogDataModel();            
            newBlog.Writer = blog.Writer;
            newBlog.Title = blog.Title;
            newBlog.Language = blog.Language;
            newBlog.Thumbnail = blog.Thumbnail;

            for(var i =0; i<blog.Body.Length; i++)
            {
                newBlog.Body = newBlog.Body + blog.Body[i];
            }
            
            newBlog.Date = DateTime.Now;

            return newBlog;
        }

        public BlogViewModel ConvertDataToViewModel(BlogDataModel data)
        {
            BlogViewModel view = new BlogViewModel();
            view.Id = data.Id;
            view.Language = data.Language;
            view.Title = data.Title;
            view.Thumbnail = data.Thumbnail;
            view.Body = data.Body;
            view.Writer = data.Writer;

            return view;
        }

        public BlogDetailModel ConvertDataToDetailModel(BlogDataModel data)
        {
            BlogDetailModel blogDetailModel = new BlogDetailModel();
            blogDetailModel.Id = data.Id;
            blogDetailModel.Writer = data.Writer;
            blogDetailModel.Title = data.Title;
            blogDetailModel.Language = data.Language;
            blogDetailModel.Body = data.Body;
            blogDetailModel.Date = data.Date.ToString("dd/MM/yyyy");
            
            return blogDetailModel;
        }

        public BlogDetailModel ConvertDataToDetailModel(BlogDataModel data, BlogDataModel previous, BlogDataModel next)
        {
            BlogDetailModel blogDetailModel = new BlogDetailModel();
            blogDetailModel.Id = data.Id;
            blogDetailModel.Writer = data.Writer;
            blogDetailModel.Title = data.Title;
            blogDetailModel.Body = data.Body;
            blogDetailModel.Language = data.Language;
            blogDetailModel.Date = data.Date.ToString("dd/MM/yyyy");
            blogDetailModel.Previous = new BlogDetailRecommend();
            blogDetailModel.Next = new BlogDetailRecommend();
            blogDetailModel.Previous.Id = previous.Id;
            blogDetailModel.Previous.Title = previous.Title;
            blogDetailModel.Previous.Thumbnail = previous.Thumbnail;
            blogDetailModel.Next.Id = next.Id;
            blogDetailModel.Next.Title = next.Title;
            blogDetailModel.Next.Thumbnail = next.Thumbnail;
            return blogDetailModel;
        }

        public BlogListViewModel convertDataToListViewModel(BlogDataModel data)
        {
            BlogListViewModel blogListViewModel = new BlogListViewModel();
            blogListViewModel.Id = data.Id;
            blogListViewModel.Author = data.Writer;
            blogListViewModel.Title = data.Title;
            blogListViewModel.Language = data.Language;
            blogListViewModel.Thumbnail = data.Thumbnail;
           DateTime localDate = DateTime.Now;
            if (data.Date.Date == localDate.Date)
            {
                blogListViewModel.Date = data.Date.ToString("hh:mm tt");
            }
            else
            {
                blogListViewModel.Date = data.Date.ToString("dd/MM/yyyy");
            }

            return blogListViewModel;
        }

        public List<BlogListViewModel> convertDataToViewModelList(List<BlogDataModel> dataBlogList)
        {
            List<BlogListViewModel> blogViewModelList = new List<BlogListViewModel>();
            for(var i = 0; i < dataBlogList.Count; i++)
            {
                var result = convertDataToListViewModel(dataBlogList[i]);
                blogViewModelList.Add(result);
            }

            return blogViewModelList;
        }
    }
}   
