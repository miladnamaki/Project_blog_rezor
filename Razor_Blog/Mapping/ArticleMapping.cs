using Microsoft.EntityFrameworkCore;
using Razor_Blog.Model;
using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Razor_Blog.Mapping
{
    public class ArticleMapping : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.ToTable("Articles");
            builder.HasKey(x => x.Id);

        }
    }
}
