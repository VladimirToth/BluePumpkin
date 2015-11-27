namespace BluePumpkinn.Migrations
{
    using BluePumpkinn.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BluePumpkinn.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "BluePumpkinn.Models.ApplicationDbContext";
        }
 

        protected override void Seed(BluePumpkinn.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.
        
            
            if (!context.Roles.Any())
            {
                var roleStore = new RoleStore<IdentityRole>(context);
                var roleManager = new RoleManager<IdentityRole>(roleStore);

                var role1 = new IdentityRole
                {
                    Name = "Administrator"
                };
                roleManager.CreateAsync(role1).Wait();

                var role2 = new IdentityRole
                {
                    Name = "Employee"
                };
                roleManager.CreateAsync(role2).Wait();
            }

            if (!context.Users.Any())
            {
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new ApplicationUserManager(userStore);

                System.IO.FileStream file1 = new System.IO.FileStream(@"C:\Users\toth\Desktop\zamestnaci_jednotna_velkost\benoit-fleury.jpg", System.IO.FileMode.Open, System.IO.FileAccess.Read);
                byte[] data1 = new byte[file1.Length];
                file1.Read(data1, 0, data1.Length);
                file1.Close();

                System.IO.FileStream file2 = new System.IO.FileStream(@"C:\Users\toth\Desktop\zamestnaci_jednotna_velkost\carin-meier.jpg", System.IO.FileMode.Open, System.IO.FileAccess.Read);
                byte[] data2 = new byte[file2.Length];
                file2.Read(data2, 0, data1.Length);
                file2.Close();

                System.IO.FileStream file3 = new System.IO.FileStream(@"C:\Users\toth\Desktop\zamestnaci_jednotna_velkost\carin-meier.jpg", System.IO.FileMode.Open, System.IO.FileAccess.Read);
                byte[] data3 = new byte[file3.Length];
                file3.Read(data3, 0, data3.Length);
                file3.Close();

                System.IO.FileStream file4 = new System.IO.FileStream(@"C:\Users\toth\Desktop\zamestnaci_jednotna_velkost\carin-meier.jpg", System.IO.FileMode.Open, System.IO.FileAccess.Read);
                byte[] data4 = new byte[file4.Length];
                file4.Read(data1, 0, data4.Length);
                file4.Close();

                System.IO.FileStream file5 = new System.IO.FileStream(@"C:\Users\toth\Desktop\zamestnaci_jednotna_velkost\carin-meier.jpg", System.IO.FileMode.Open, System.IO.FileAccess.Read);
                byte[] data5 = new byte[file5.Length];
                file5.Read(data5, 0, data5.Length);
                file5.Close();

                System.IO.FileStream file6 = new System.IO.FileStream(@"C:\Users\toth\Desktop\zamestnaci_jednotna_velkost\carin-meier.jpg", System.IO.FileMode.Open, System.IO.FileAccess.Read);
                byte[] data6 = new byte[file1.Length];
                file6.Read(data6, 0, data6.Length);
                file6.Close();

                var admin = new ApplicationUser
                {
                    Email = "administrator@bluepumpkin.com",
                    //Name
                    UserName = "administrator@bluepumpkin.com",
                    EmailConfirmed = true,
                    BirthDate = DateTime.Parse("1970-12-23").Date,
                    TwoFactorEnabled=false,
                    PhoneNumberConfirmed=false,
                    LockoutEnabled=true,
                    Photo=data1
                    
                };
                userManager.CreateAsync(admin, "Password@123").Wait();
                userManager.AddToRolesAsync(admin.Id, "Administrator").Wait();

                var user1 = new ApplicationUser
                {
                    Email = "lewis.c.morrel@bluepumpkin.com",
                    //Name = "Lewis C. Morrel",
                    UserName = "lewis.c.morrel@bluepumpkin.com",
                    EmailConfirmed = true,
                    BirthDate = DateTime.Parse("1985-12-15").Date,
                    TwoFactorEnabled = false,
                    PhoneNumberConfirmed = false,
                    LockoutEnabled = true,
                    Photo=data2
                };
                userManager.CreateAsync(user1, "Password@123").Wait();
                userManager.AddToRolesAsync(user1.Id, "Employee").Wait();

                var user2 = new ApplicationUser
                {
                    Email = "desirae.young@bluepumpkin.com",
                    UserName = "desirae.young@bluepumpkin.com",
                   //Name = "Desirae Young",
                    EmailConfirmed = true,
                    BirthDate = DateTime.Parse("1990-07-09").Date,
                    TwoFactorEnabled = false,
                    PhoneNumberConfirmed = false,
                    LockoutEnabled = true
                };
                userManager.CreateAsync(user2, "Password@123").Wait();
                userManager.AddToRolesAsync(user2.Id, "Employee").Wait();

                var user3 = new ApplicationUser
                {
                    Email = "john.g.winn@bluepumpkin.com",
                    UserName = "john.g.winn@bluepumpkin.com",
                    //Name = "John G. Winn",
                    EmailConfirmed = true,
                    BirthDate = DateTime.Parse("1982-02-27").Date,
                    TwoFactorEnabled = false,
                    PhoneNumberConfirmed = false,
                    LockoutEnabled = true
                };
                userManager.CreateAsync(user3, "Password@123").Wait();
                userManager.AddToRolesAsync(user3.Id, "Employee").Wait();

                var user4 = new ApplicationUser
                {
                    Email = "elisabeth.c.cooper@bluepumpkin.com",
                    UserName = "elisabeth.c.cooper@bluepumpkin.com",
                    //Name = "Elisabeth C. Cooper",
                    EmailConfirmed = true,
                    BirthDate = DateTime.Parse("1984-01-24").Date,
                    TwoFactorEnabled = false,
                    PhoneNumberConfirmed = false,
                    LockoutEnabled = true
                };
                userManager.CreateAsync(user4, "Password@123").Wait();
                userManager.AddToRolesAsync(user4.Id, "Employee").Wait();

                var user5 = new ApplicationUser
                {
                    Email = "christine.j.maynard@bluepumpkin.com",
                    UserName = "christine.j.maynard@bluepumpkin.com",
                    //Name = "Christin J. Maynard",
                    EmailConfirmed = true,
                    BirthDate = DateTime.Parse("1978-09-09").Date,
                    TwoFactorEnabled = false,
                    PhoneNumberConfirmed = false,
                    LockoutEnabled = true
                };
                userManager.CreateAsync(user5, "Password@123").Wait();
                userManager.AddToRolesAsync(user5.Id, "Employee").Wait();

                var user6 = new ApplicationUser
                {
                    Email = "james.p.galvan@bluepumpkin.com",
                    UserName = "james.p.galvan@bluepumpkin.com",
                    //Name = "James P. Galvan",
                    EmailConfirmed = true,
                    BirthDate = DateTime.Parse("1990-12-06").Date,
                    TwoFactorEnabled = false,
                    PhoneNumberConfirmed = false,
                    LockoutEnabled = true
                };
                userManager.CreateAsync(user6, "Password@123").Wait();
                userManager.AddToRolesAsync(user6.Id, "Employee").Wait();

                var user7 = new ApplicationUser
                {
                    Email = "debra.c.titus@bluepumpkin.com",
                    UserName = "debra.c.titus@bluepumpkin.com",
                    //Name = "Debra C. Titus",
                    EmailConfirmed = true,
                    BirthDate = DateTime.Parse("1983-08-22").Date,
                    TwoFactorEnabled = false,
                    PhoneNumberConfirmed = false,
                    LockoutEnabled = true
                };
                userManager.CreateAsync(user7, "Password@123").Wait();
                userManager.AddToRolesAsync(user7.Id, "Employee").Wait();

                var user8 = new ApplicationUser
                {
                    Email = "giovanni.j.peng@bluepumpkin.com",
                    UserName = "giovanni.j.peng@bluepumpkin.com",
                    //Name = "Giovanni J. Peng",
                    EmailConfirmed = true,
                    BirthDate = DateTime.Parse("1990-12-10").Date,
                    TwoFactorEnabled = false,
                    PhoneNumberConfirmed = false,
                    LockoutEnabled = true
                };
                userManager.CreateAsync(user8, "Password@123").Wait();
                userManager.AddToRolesAsync(user8.Id, "Employee").Wait();

                var user9 = new ApplicationUser
                {
                    Email = "henrich.fuller@bluepumpkin.com",
                    UserName = "henrich.fuller@bluepumpkin.com",
                    //Name = "Henrich Fuller",
                    EmailConfirmed = true,
                    BirthDate = DateTime.Parse("1975-09-16").Date,
                    TwoFactorEnabled = false,
                    PhoneNumberConfirmed = false,
                    LockoutEnabled = true
                };
                userManager.CreateAsync(user9, "Password@123").Wait();
                userManager.AddToRolesAsync(user9.Id, "Employee").Wait();

                var user10 = new ApplicationUser
                {
                    Email = "michael.d.stewart@bluepumpkin.com",
                    UserName = "michael.d.stewart@bluepumpkin.com",
                    //Name = "Michael D. Stewart",
                    EmailConfirmed = true,
                    BirthDate = DateTime.Parse("1999-09-01").Date,
                    TwoFactorEnabled = false,
                    PhoneNumberConfirmed = false,
                    LockoutEnabled = true
                };
                userManager.CreateAsync(user10, "Password@123").Wait();
                userManager.AddToRolesAsync(user10.Id, "Employee").Wait();
            }


            
        }
    }
}
