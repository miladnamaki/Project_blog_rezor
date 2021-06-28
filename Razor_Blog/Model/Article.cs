using System;

namespace Razor_Blog.Model
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public string ShortDess { get; set; }
        public string Body { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsDeleted { get; set; }

        public Article(string title, string picture, string pictureAlt, string pictureTitle, string shortDess, string body)
        {
            Title = title;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            ShortDess = shortDess;
            Body = body;
            CreationDate = DateTime.Now;
            IsDeleted = false;
        }
    }
}
