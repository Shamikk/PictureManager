using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PictureManager.BLL;

namespace PictureManager.DAL
{
    public class PictureDbConfiguration : IEntityTypeConfiguration<Picture>
    {
        public void Configure(EntityTypeBuilder<Picture> builder)
        {
            //builder.ToTable("Picture");
            builder.ToTable(typeof(Picture).Name);
            builder.HasKey(k => k.Id);
        }
    }
}