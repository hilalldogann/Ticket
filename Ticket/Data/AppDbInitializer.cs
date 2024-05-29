using Ticket.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using Ticket.Data.Static;

namespace Ticket.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder) { 
        
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope()) { 

                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                //cinema
                if(!context.Cinemas.Any()) 
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            CinemaName = "Cinema 1",
                            Logo = "https://www.google.com/search?q=cinema&sca_esv=c27bfc2d7e5ccc09&sca_upv=1&udm=2&biw=1366&bih=633&sxsrf=ACQVn0_wFYN8ZYJhBbWKJIIK-RBaY7UbsA%3A1713096207967&ei=D8YbZtvHOq_Bxc8P1ZeOqAU&ved=0ahUKEwibi8TX1MGFAxWvYPEDHdWLA1UQ4dUDCBA&uact=5&oq=cinema&gs_lp=Egxnd3Mtd2l6LXNlcnAiBmNpbmVtYTINEAAYgAQYigUYQxixAzIFEAAYgAQyBRAAGIAEMgUQABiABDIFEAAYgAQyBRAAGIAEMgUQABiABDIFEAAYgAQyBRAAGIAEMgUQABiABEj1EVAAWABwA3gAkAEAmAEAoAEAqgEAuAEDyAEAmAIDoAIMmAMAiAYBkgcBM6AHAA&sclient=gws-wiz-serp#vhid=sQ9lZmUfX6Dv1M&vssid=mosaic",
                            Description= "Description"
                        },

                        new Cinema()
                        {
                            CinemaName = "Cinema 1",
                            Logo = "https://www.google.com/search?q=cinema&sca_esv=c27bfc2d7e5ccc09&sca_upv=1&udm=2&biw=1366&bih=633&sxsrf=ACQVn0_wFYN8ZYJhBbWKJIIK-RBaY7UbsA%3A1713096207967&ei=D8YbZtvHOq_Bxc8P1ZeOqAU&ved=0ahUKEwibi8TX1MGFAxWvYPEDHdWLA1UQ4dUDCBA&uact=5&oq=cinema&gs_lp=Egxnd3Mtd2l6LXNlcnAiBmNpbmVtYTINEAAYgAQYigUYQxixAzIFEAAYgAQyBRAAGIAEMgUQABiABDIFEAAYgAQyBRAAGIAEMgUQABiABDIFEAAYgAQyBRAAGIAEMgUQABiABEj1EVAAWABwA3gAkAEAmAEAoAEAqgEAuAEDyAEAmAIDoAIMmAMAiAYBkgcBM6AHAA&sclient=gws-wiz-serp#vhid=sQ9lZmUfX6Dv1M&vssid=mosaic",
                            Description= "Description"
                        },

                        new Cinema()
                        {
                            CinemaName = "Cinema 2",
                            Logo = "https://www.google.com/search?q=cinema&sca_esv=c27bfc2d7e5ccc09&sca_upv=1&udm=2&biw=1366&bih=633&sxsrf=ACQVn0_wFYN8ZYJhBbWKJIIK-RBaY7UbsA%3A1713096207967&ei=D8YbZtvHOq_Bxc8P1ZeOqAU&ved=0ahUKEwibi8TX1MGFAxWvYPEDHdWLA1UQ4dUDCBA&uact=5&oq=cinema&gs_lp=Egxnd3Mtd2l6LXNlcnAiBmNpbmVtYTINEAAYgAQYigUYQxixAzIFEAAYgAQyBRAAGIAEMgUQABiABDIFEAAYgAQyBRAAGIAEMgUQABiABDIFEAAYgAQyBRAAGIAEMgUQABiABEj1EVAAWABwA3gAkAEAmAEAoAEAqgEAuAEDyAEAmAIDoAIMmAMAiAYBkgcBM6AHAA&sclient=gws-wiz-serp#vhid=sQ9lZmUfX6Dv1M&vssid=mosaic",
                            Description= "Description"
                        },

                        new Cinema()
                        {
                            CinemaName = "Cinema 3",
                            Logo = "https://www.google.com/search?q=cinema&sca_esv=c27bfc2d7e5ccc09&sca_upv=1&udm=2&biw=1366&bih=633&sxsrf=ACQVn0_wFYN8ZYJhBbWKJIIK-RBaY7UbsA%3A1713096207967&ei=D8YbZtvHOq_Bxc8P1ZeOqAU&ved=0ahUKEwibi8TX1MGFAxWvYPEDHdWLA1UQ4dUDCBA&uact=5&oq=cinema&gs_lp=Egxnd3Mtd2l6LXNlcnAiBmNpbmVtYTINEAAYgAQYigUYQxixAzIFEAAYgAQyBRAAGIAEMgUQABiABDIFEAAYgAQyBRAAGIAEMgUQABiABDIFEAAYgAQyBRAAGIAEMgUQABiABEj1EVAAWABwA3gAkAEAmAEAoAEAqgEAuAEDyAEAmAIDoAIMmAMAiAYBkgcBM6AHAA&sclient=gws-wiz-serp#vhid=sQ9lZmUfX6Dv1M&vssid=mosaic",
                            Description= "Description"
                        },

                        new Cinema()
                        {
                            CinemaName = "Cinema 4",
                            Logo = "https://www.google.com/search?q=cinema&sca_esv=c27bfc2d7e5ccc09&sca_upv=1&udm=2&biw=1366&bih=633&sxsrf=ACQVn0_wFYN8ZYJhBbWKJIIK-RBaY7UbsA%3A1713096207967&ei=D8YbZtvHOq_Bxc8P1ZeOqAU&ved=0ahUKEwibi8TX1MGFAxWvYPEDHdWLA1UQ4dUDCBA&uact=5&oq=cinema&gs_lp=Egxnd3Mtd2l6LXNlcnAiBmNpbmVtYTINEAAYgAQYigUYQxixAzIFEAAYgAQyBRAAGIAEMgUQABiABDIFEAAYgAQyBRAAGIAEMgUQABiABDIFEAAYgAQyBRAAGIAEMgUQABiABEj1EVAAWABwA3gAkAEAmAEAoAEAqgEAuAEDyAEAmAIDoAIMmAMAiAYBkgcBM6AHAA&sclient=gws-wiz-serp#vhid=sQ9lZmUfX6Dv1M&vssid=mosaic",
                            Description= "Description"
                        },

                        new Cinema()
                        {
                            CinemaName = "Cinema 5",
                            Logo = "https://www.google.com/search?q=cinema&sca_esv=c27bfc2d7e5ccc09&sca_upv=1&udm=2&biw=1366&bih=633&sxsrf=ACQVn0_wFYN8ZYJhBbWKJIIK-RBaY7UbsA%3A1713096207967&ei=D8YbZtvHOq_Bxc8P1ZeOqAU&ved=0ahUKEwibi8TX1MGFAxWvYPEDHdWLA1UQ4dUDCBA&uact=5&oq=cinema&gs_lp=Egxnd3Mtd2l6LXNlcnAiBmNpbmVtYTINEAAYgAQYigUYQxixAzIFEAAYgAQyBRAAGIAEMgUQABiABDIFEAAYgAQyBRAAGIAEMgUQABiABDIFEAAYgAQyBRAAGIAEMgUQABiABEj1EVAAWABwA3gAkAEAmAEAoAEAqgEAuAEDyAEAmAIDoAIMmAMAiAYBkgcBM6AHAA&sclient=gws-wiz-serp#vhid=sQ9lZmUfX6Dv1M&vssid=mosaic",
                            Description= "Description"
                        },

                    });
                    context.SaveChanges();
                }

                //actor
                if(!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    { 
                        new Actor()
                        {
                            FullName="Actor 1",
                            Biography="1. aktörün biyografisi",
                            ProfilePictureURL=".....",
                        },

                        new Actor()
                        {
                            FullName="Leonardo DiCaprio",
                            Biography="Görev Oyuncu , Yapımcı , İdari yapımcı Daha fazlası\r\nGerçek adı: Leonardo Wilhelm DiCaprio\r\nUyruk Amerikalı\r\nDoğum tarihi 11 Kasım 1974 (Los Angeles, Kaliforniya)\r\nYaş 49",
                            ProfilePictureURL=".....",

                        },

                        new Actor()
                        {
                            FullName="Actor 3",
                            Biography="3. aktörün biyografisi",
                            ProfilePictureURL=".....",
                        },

                        new Actor() 
                        {
                            FullName="Actor 4",
                            Biography="4. aktörün biyografisi",
                            ProfilePictureURL=".....",
                        },

                        new Actor()
                        {
                            FullName="Actor 5",
                            Biography="5. aktörün biyografisi",
                            ProfilePictureURL=".....",
                        }
                    });
                    context.SaveChanges();
                }

                //producer
                if(!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            Name="Producer 1 ",
                            Biography="Producer 1 biyografisi",
                            ProfilePictureURL="https://i.pinimg.com/736x/1b/09/dc/1b09dcb5603dfb7e5e7dc1f2f0174dc0.jpg"
                        },

                        new Producer()
                        {
                            Name="Producer 2 ",
                            Biography="Producer 2 biyografisi",
                            ProfilePictureURL="https://upload.wikimedia.org/wikipedia/commons/thumb/3/30/Henry_Cavill_by_Gage_Skidmore_2.jpg/220px-Henry_Cavill_by_Gage_Skidmore_2.jpg"

                        },

                        new Producer()
                        {
                            Name="Producer 3 ",
                            Biography="Producer 3 biyografisi",
                            ProfilePictureURL="https://upload.wikimedia.org/wikipedia/commons/thumb/3/30/Henry_Cavill_by_Gage_Skidmore_2.jpg/220px-Henry_Cavill_by_Gage_Skidmore_2.jpg"
                        },

                        new Producer() 
                        {
                            Name="Producer 4 ",
                            Biography="Producer 4 biyografisi",
                            ProfilePictureURL="https://upload.wikimedia.org/wikipedia/commons/thumb/3/30/Henry_Cavill_by_Gage_Skidmore_2.jpg/220px-Henry_Cavill_by_Gage_Skidmore_2.jpg"
                        },

                        new Producer()
                        {
                            Name="Producer 5 ",
                            Biography="Producer 5 biyografisi",
                            ProfilePictureURL="https://upload.wikimedia.org/wikipedia/commons/thumb/3/30/Henry_Cavill_by_Gage_Skidmore_2.jpg/220px-Henry_Cavill_by_Gage_Skidmore_2.jpg"
                        }

                   


                    });
                    context.SaveChanges();

                }

                //activity

                if (!context.Activities.Any())
                {
                    context.Activities.AddRange(new List<Activity>()
                    {
                        new Activity() 
                        {
                            Name="theatre",
                            Description="a",
                            Price=123.9,
                            ImageURL="",
                            StartDate=DateTime.Now,
                            EndDate=DateTime.Now.AddDays(7),
                            CinemaId=1,
                            ProducerId=2,
                            ActivityCategory=Enums.ActivityCategory.Theatre
                        },

                        new Activity()
                        {
                            Name="dance",
                            Description="a",
                            Price=123.9,
                            ImageURL="",
                            StartDate=DateTime.Now,
                            EndDate=DateTime.Now.AddDays(7),
                            CinemaId=2,
                            ProducerId=3,
                            ActivityCategory=Enums.ActivityCategory.Dance
                        },

                        new Activity()
                        {
                            Name="ballet",
                            Description="a",
                            Price=123.9,
                            ImageURL="",
                            StartDate=DateTime.Now,
                            EndDate=DateTime.Now.AddDays(7),
                            CinemaId=3,
                            ProducerId=4,
                            ActivityCategory=Enums.ActivityCategory.Ballet
                        },

                        new Activity()
                        {
                            Name="concert",
                            Description="a",
                            Price=123.9,
                            ImageURL="",
                            StartDate=DateTime.Now,
                            EndDate=DateTime.Now.AddDays(7),
                            CinemaId=4,
                            ProducerId=2,
                            ActivityCategory=Enums.ActivityCategory.Concert
                        }


                    });
                    context.SaveChanges();
                }

                //actor ve activity

                if (!context.Actors_Activities.Any())
                {
                    context.Actors_Activities.AddRange(new List<Actor_Activity>()
                    {
                        new Actor_Activity() 
                        {
                            ActorId=1,
                            ActivityId=1
                        },

                        new Actor_Activity()
                        {
                            ActorId=2,
                            ActivityId=2
                        },

                        new Actor_Activity()
                        {
                            ActorId=2,
                            ActivityId=3
                        },

                        new Actor_Activity()
                        {
                            ActorId=3,
                            ActivityId=4
                        },

                        new Actor_Activity()
                        {
                            ActorId=4,
                            ActivityId=3
                        },

                        new Actor_Activity()
                        {
                            ActorId=1,
                            ActivityId=3
                        },
                    });
                    context.SaveChanges();

                }

            }
        
        
        
        }

        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var roleManager= serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if(!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@etickets.com";
                var adminUser =await userManager.FindByEmailAsync(adminUserEmail);  
                if(adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin User",
                        UserName = "admin-user",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Coding@1234?");
                    await userManager.CreateAsync(newAdminUser, UserRoles.Admin);
                }





               
                string appUserEmail = "user@etickets.com";
                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Application User",
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Coding@1234?");
                    await userManager.CreateAsync(newAppUser, UserRoles.User);
                }



            }
        }
    }
}
