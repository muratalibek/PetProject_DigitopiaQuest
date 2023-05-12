using DigitopiaQuest.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigitopiaQuest.Data;

public class DigitopiaQuestContext : IdentityDbContext<DigitopiaQuestUser>
{
    public DigitopiaQuestContext(DbContextOptions<DigitopiaQuestContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        builder.ApplyConfiguration(new DigitopiaQuestUserEntityConfiguration());
    }
}

public class DigitopiaQuestUserEntityConfiguration : IEntityTypeConfiguration<DigitopiaQuestUser>
{
    public void Configure(EntityTypeBuilder<DigitopiaQuestUser> builder)
    {
        builder.Property(u => u.FirstNameOfUser).HasMaxLength(255);
        builder.Property(u => u.LastNameOfUser).HasMaxLength(255);
    }
}
