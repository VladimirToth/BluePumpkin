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

                System.IO.FileStream file1 = new System.IO.FileStream(@"C:\Users\Vlado\Desktop\BluePumpkin\zamestnaci_jednotna_velkost\jenn-hudson.jpg", System.IO.FileMode.Open, System.IO.FileAccess.Read);
                byte[] data1 = new byte[file1.Length];
                file1.Read(data1, 0, data1.Length);
                file1.Close();

                System.IO.FileStream file2 = new System.IO.FileStream(@"C:\Users\Vlado\Desktop\BluePumpkin\zamestnaci_jednotna_velkost\lewis-c-morel.jpg", System.IO.FileMode.Open, System.IO.FileAccess.Read);
                byte[] data2 = new byte[file2.Length];
                file2.Read(data2, 0, data2.Length);
                file2.Close();

                System.IO.FileStream file3 = new System.IO.FileStream(@"C:\Users\Vlado\Desktop\BluePumpkin\zamestnaci_jednotna_velkost\desirae-young.jpg", System.IO.FileMode.Open, System.IO.FileAccess.Read);
                byte[] data3 = new byte[file3.Length];
                file3.Read(data3, 0, data3.Length);
                file3.Close();

                System.IO.FileStream file4 = new System.IO.FileStream(@"C:\Users\Vlado\Desktop\BluePumpkin\zamestnaci_jednotna_velkost\john-g-winn.jpg", System.IO.FileMode.Open, System.IO.FileAccess.Read);
                byte[] data4 = new byte[file4.Length];
                file4.Read(data4, 0, data4.Length);
                file4.Close();

                System.IO.FileStream file5 = new System.IO.FileStream(@"C:\Users\Vlado\Desktop\BluePumpkin\zamestnaci_jednotna_velkost\elisabeth-c-cooper.jpg", System.IO.FileMode.Open, System.IO.FileAccess.Read);
                byte[] data5 = new byte[file5.Length];
                file5.Read(data5, 0, data5.Length);
                file5.Close();

                System.IO.FileStream file6 = new System.IO.FileStream(@"C:\Users\Vlado\Desktop\BluePumpkin\zamestnaci_jednotna_velkost\christine-j-maynard.jpg", System.IO.FileMode.Open, System.IO.FileAccess.Read);
                byte[] data6 = new byte[file6.Length];
                file6.Read(data6, 0, data6.Length);
                file6.Close();

                System.IO.FileStream file7 = new System.IO.FileStream(@"C:\Users\Vlado\Desktop\BluePumpkin\zamestnaci_jednotna_velkost\james-p-galvan.jpg", System.IO.FileMode.Open, System.IO.FileAccess.Read);
                byte[] data7 = new byte[file7.Length];
                file7.Read(data7, 0, data7.Length);
                file7.Close();

                System.IO.FileStream file8 = new System.IO.FileStream(@"C:\Users\Vlado\Desktop\BluePumpkin\zamestnaci_jednotna_velkost\debra-c-titus.jpg", System.IO.FileMode.Open, System.IO.FileAccess.Read);
                byte[] data8 = new byte[file8.Length];
                file8.Read(data8, 0, data8.Length);
                file8.Close();

                System.IO.FileStream file9 = new System.IO.FileStream(@"C:\Users\Vlado\Desktop\BluePumpkin\zamestnaci_jednotna_velkost\giovanni-j-peng.jpg", System.IO.FileMode.Open, System.IO.FileAccess.Read);
                byte[] data9 = new byte[file9.Length];
                file9.Read(data9, 0, data9.Length);
                file9.Close();

                System.IO.FileStream file10 = new System.IO.FileStream(@"C:\Users\Vlado\Desktop\BluePumpkin\zamestnaci_jednotna_velkost\henrich-fuller.jpg", System.IO.FileMode.Open, System.IO.FileAccess.Read);
                byte[] data10 = new byte[file10.Length];
                file10.Read(data10, 0, data10.Length);
                file10.Close();

                System.IO.FileStream file11 = new System.IO.FileStream(@"C:\Users\Vlado\Desktop\BluePumpkin\zamestnaci_jednotna_velkost\michael-d-stewart.jpg", System.IO.FileMode.Open, System.IO.FileAccess.Read);
                byte[] data11 = new byte[file11.Length];
                file11.Read(data11, 0, data11.Length);
                file11.Close();

                var admin = new ApplicationUser
                {
                    Email = "administrator@bluepumpkin.com",
                    Firstname="Jane",
                    Surname="Hudson",
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
                    Firstname = "Lewis C.", 
                    Surname= "Morrel",
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
                    Firstname = "Desirae",
                    Surname="Young",
                    EmailConfirmed = true,
                    BirthDate = DateTime.Parse("1990-07-09").Date,
                    TwoFactorEnabled = false,
                    PhoneNumberConfirmed = false,
                    LockoutEnabled = true,
                    Photo = data3
                };
                userManager.CreateAsync(user2, "Password@123").Wait();
                userManager.AddToRolesAsync(user2.Id, "Employee").Wait();

                var user3 = new ApplicationUser
                {
                    Email = "john.g.winn@bluepumpkin.com",
                    UserName = "john.g.winn@bluepumpkin.com",
                    Firstname = "John G.",
                    Surname="Winn",
                    EmailConfirmed = true,
                    BirthDate = DateTime.Parse("1982-02-27").Date,
                    TwoFactorEnabled = false,
                    PhoneNumberConfirmed = false,
                    LockoutEnabled = true,
                    Photo = data4
                };
                userManager.CreateAsync(user3, "Password@123").Wait();
                userManager.AddToRolesAsync(user3.Id, "Employee").Wait();

                var user4 = new ApplicationUser
                {
                    Email = "elisabeth.c.cooper@bluepumpkin.com",
                    UserName = "elisabeth.c.cooper@bluepumpkin.com",
                    Firstname = "Elisabeth C.",
                    Surname="Cooper",
                    EmailConfirmed = true,
                    BirthDate = DateTime.Parse("1984-01-24").Date,
                    TwoFactorEnabled = false,
                    PhoneNumberConfirmed = false,
                    LockoutEnabled = true,
                    Photo = data5
                };
                userManager.CreateAsync(user4, "Password@123").Wait();
                userManager.AddToRolesAsync(user4.Id, "Employee").Wait();

                var user5 = new ApplicationUser
                {
                    Email = "christine.j.maynard@bluepumpkin.com",
                    UserName = "christine.j.maynard@bluepumpkin.com",
                    Firstname = "Christin J.",
                    Surname="Maynard",
                    EmailConfirmed = true,
                    BirthDate = DateTime.Parse("1978-09-09").Date,
                    TwoFactorEnabled = false,
                    PhoneNumberConfirmed = false,
                    LockoutEnabled = true,
                    Photo=data6
                };
                userManager.CreateAsync(user5, "Password@123").Wait();
                userManager.AddToRolesAsync(user5.Id, "Employee").Wait();

                var user6 = new ApplicationUser
                {
                    Email = "james.p.galvan@bluepumpkin.com",
                    UserName = "james.p.galvan@bluepumpkin.com",
                    Firstname = "James P.",
                    Surname="Galvan",
                    EmailConfirmed = true,
                    BirthDate = DateTime.Parse("1990-12-06").Date,
                    TwoFactorEnabled = false,
                    PhoneNumberConfirmed = false,
                    LockoutEnabled = true,
                    Photo = data7
                };
                userManager.CreateAsync(user6, "Password@123").Wait();
                userManager.AddToRolesAsync(user6.Id, "Employee").Wait();

                var user7 = new ApplicationUser
                {
                    Email = "debra.c.titus@bluepumpkin.com",
                    UserName = "debra.c.titus@bluepumpkin.com",
                    Firstname = "Debra C.",
                    Surname="Titus",
                    EmailConfirmed = true,
                    BirthDate = DateTime.Parse("1983-08-22").Date,
                    TwoFactorEnabled = false,
                    PhoneNumberConfirmed = false,
                    LockoutEnabled = true,
                    Photo = data8
                };
                userManager.CreateAsync(user7, "Password@123").Wait();
                userManager.AddToRolesAsync(user7.Id, "Employee").Wait();

                var user8 = new ApplicationUser
                {
                    Email = "giovanni.j.peng@bluepumpkin.com",
                    UserName = "giovanni.j.peng@bluepumpkin.com",
                    Firstname = "Giovanni J.",
                    Surname="Peng",
                    EmailConfirmed = true,
                    BirthDate = DateTime.Parse("1990-12-10").Date,
                    TwoFactorEnabled = false,
                    PhoneNumberConfirmed = false,
                    LockoutEnabled = true,
                    Photo = data9
                };
                userManager.CreateAsync(user8, "Password@123").Wait();
                userManager.AddToRolesAsync(user8.Id, "Employee").Wait();

                var user9 = new ApplicationUser
                {
                    Email = "henrich.fuller@bluepumpkin.com",
                    UserName = "henrich.fuller@bluepumpkin.com",
                    Firstname = "Henrich",
                    Surname="Fuller",
                    EmailConfirmed = true,
                    BirthDate = DateTime.Parse("1975-09-16").Date,
                    TwoFactorEnabled = false,
                    PhoneNumberConfirmed = false,
                    LockoutEnabled = true,
                    Photo=data10
                };
                userManager.CreateAsync(user9, "Password@123").Wait();
                userManager.AddToRolesAsync(user9.Id, "Employee").Wait();

                var user10 = new ApplicationUser
                {
                    Email = "michael.d.stewart@bluepumpkin.com",
                    UserName = "michael.d.stewart@bluepumpkin.com",
                    Firstname = "Michael D.",
                    Surname="Stewart",
                    EmailConfirmed = true,
                    BirthDate = DateTime.Parse("1999-09-01").Date,
                    TwoFactorEnabled = false,
                    PhoneNumberConfirmed = false,
                    LockoutEnabled = true,
                    Photo = data11
                };
                userManager.CreateAsync(user10, "Password@123").Wait();
                userManager.AddToRolesAsync(user10.Id, "Employee").Wait();
            }


            
        }
    }
}
