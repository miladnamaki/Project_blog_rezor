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
    public class CreateArticleModel : PageModel
    {
        [TempData]
        public string ErrorMessage { get; set; }
       

        public CreateArticle Command { get; set; }

        private readonly Blogcontext _context;

        public CreateArticleModel(Blogcontext context)
        {
            _context = context;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost(CreateArticle command)
        {
            if (ModelState.IsValid)
            {
                var article = new Article(command.Title, command.Picture, command.PictureAlt, command.PictureTitle, command.ShortDes, command.Body);

                _context.Articles.Add(article);
                _context.SaveChanges();
                return RedirectToPage("./index");

            }
            else
            {
                ErrorMessage = "لطفا مقادیر خواسته شده رو پر کنید ";
                return Page();


            }



        }
    }
}
