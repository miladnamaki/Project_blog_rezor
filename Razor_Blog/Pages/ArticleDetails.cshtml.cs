using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_Blog.Mapping;
using Razor_Blog.Model;

namespace Razor_Blog.Pages
{
    public class ArticleDetailsModel : PageModel
    {
        public ArticleViewModel Articles { get; set; }
        private readonly Blogcontext _context;
        public ArticleDetailsModel(Blogcontext context)
        {
            _context = context;
        }

       

        public void OnGet(int id )
        {
            Articles = _context.Articles.Select(x => new ArticleViewModel
            {
                Id = x.Id,
                Title = x.Title,
                Body = x.Body,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
               



            }).FirstOrDefault(x => x.Id == id);

        }
    }
}
