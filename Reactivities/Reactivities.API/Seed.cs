using Microsoft.AspNetCore.Identity;
using Reactivities.Domain;
using Reactivities.Persistence;

namespace Reactivities.API
{
    public class Seed
    {
        public static async Task SeedData(ReactivitiesContext context, UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var users = new List<AppUser>
                {
                      new AppUser
                {
                    DisplayName="Mi ong",
                    UserName="Miong",
                    Email="miong@gmail.com"
                    
                },
                 new AppUser
                 {
                     DisplayName = "Mi mi",
                     UserName = "Mimi",
                     Email = "mimi@gmail.com"
                     
                 },
                  new AppUser
                  {
                      DisplayName = "Mi panda",
                      UserName = "Mipanda",
                      Email = "mipanda@gmail.com"
                     
                  },
                   new AppUser
                   {
                       DisplayName = "Jenifer",
                       UserName = "jenifer",
                       Email = "jenifer@gmail.com"
                       
                   }
                };
                foreach(var user  in users)
                {
                    await userManager.CreateAsync(user, "Abc@123456");
                }
            }
        }
    }
}
