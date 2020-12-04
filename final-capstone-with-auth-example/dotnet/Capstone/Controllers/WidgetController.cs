using Microsoft.AspNetCore.Mvc;
using Capstone.DAO;
using Capstone.Models;
using Capstone.Security;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace Capstone.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize] //you must be logged in to get to any of these endpoints!
    public class WidgetController : ControllerBase
    {
        private readonly IUserDAO userDAO;
        public WidgetController(IUserDAO _userDAO) //just wanted to show how we are using dependency injection. If you add your own DAO, make sure to inject it in the Startup.cs too!
        {
            userDAO = _userDAO;
        }

        [HttpGet]
        public string GetAWidget()
        {
            //returning a message that says hello and then the user name
            int? currentUserId = GetCurrentUserId();
            if (currentUserId == null)
            {
                return "What magic is this? You should be authorized to get here.";
            }
            else
            {
                User u = userDAO.GetUser((int)currentUserId);
                return "Hello " + u.Username + ", this string is the widget you've been wishing for.";
            }

        }

        //yes, this again. This will get the currently logged in user
        private int? GetCurrentUserId()
        {
            string userId = User.FindFirst("sub")?.Value;
            if (string.IsNullOrWhiteSpace(userId)) return null;
            int.TryParse(userId, out int userIdInt);
            return userIdInt;
        }
    }
}
