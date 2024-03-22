﻿using LeaveManagment.Web.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagment.Web.Configurations.Entities; 
public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
{
    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {
        builder.HasData(
            new IdentityRole
            {
                Id = "cac43a6e-f7bb-4448-baa4-1add431ccbb1",
                Name = Roles.Administrator,
                NormalizedName = Roles.Administrator.ToUpper()
            },
            new IdentityRole()
            {
                Id = "33c43a6e-f7bb-4448-baa4-1add431c6aa1",
                Name = Roles.User,
                NormalizedName = Roles.User.ToUpper()
            }
        );
    }
}