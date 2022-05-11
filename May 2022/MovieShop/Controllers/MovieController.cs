using Microsoft.AspNetCore.Mvc;

namespace MovieShopMVC.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Details(int id)
        {
            // go to movies talbe and get the movie details by ID
            // connect to SQL server and execute the SQL query
            //select * from Movie where id=2
            // get the movies entity (object)
            // Repositories => Data access Logic
            //Services => Business Logic
            // Controllers action methods => Services methods => Repository methods => SQL database
            // get the mode data from the sevices and send the data to the views(M)
            // Onion architecture or N-Layer architecture
            return View();
        }
    }
}
