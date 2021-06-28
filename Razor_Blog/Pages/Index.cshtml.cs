using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using Razor_Blog.Mapping;
using Razor_Blog.Model;

namespace Razor_Blog.Pages
{
    public class IndexModel : PageModel
    {
        public  List<ArticleViewModel> Article { get; set;  }
        private readonly Blogcontext _context;

        public IndexModel(Blogcontext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Article = _context.Articles.Where(x=>x.IsDeleted==false).Select(x =>
                new ArticleViewModel
                {
                    Id = x.Id,
                    Title = x.Title,
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    Body = x.Body,
                    ShortDess = x.ShortDess,
                    CreationDate = x.CreationDate.ToString(),

                }).OrderByDescending(x=>x.Id).ToList();
            
        }

        public IActionResult OnGetDelete(int id )
        {
            var article = _context.Articles.First(x => x.Id == id);
            article.IsDeleted = true;
            _context.SaveChanges();
            return RedirectToPage("./Index");


        }
        
    }
}
