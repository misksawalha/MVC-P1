using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebApplication2.ApplicationContext;
using WebApplication2.Models;
namespace WebApplication2.Controllers
{
    

    public class UserController() : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public void addData()
        {
            List<Users> User = new List<Users>()
            {
                new Users()
                {

                    Name = "Misk",
                    Title = "Sawallha",
                    Age = 23
                },
                new Users()
                {
                    Name = "Misk",
                    Title = "Sawallha",
                    Age = 23
                }
            };

            context.Users.AddRange(User);
            context.SaveChanges();
            


        }

        public IActionResult displayData()
        {
            var users = context.Users.ToList();
            return View("userData",users);
        }
    }
}
