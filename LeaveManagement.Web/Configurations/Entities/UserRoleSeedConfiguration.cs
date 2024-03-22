using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagment.Web.Configurations.Entities;

public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
{
    public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
    {
        builder.HasData(
            new IdentityUserRole<string>
            {
                RoleId = "cac43a6e-f7bb-4448-baa4-1add431ccbb1",
                UserId = "408aa945-3d84-4421-8342-7269ec64d940"
            },
            new IdentityUserRole<string>
            {
                RoleId = "33c43a6e-f7bb-4448-baa4-1add431c6aa1",
                UserId = "408aa945-3d84-4421-8342-7269ec64d840"
            }

        );
    }
}