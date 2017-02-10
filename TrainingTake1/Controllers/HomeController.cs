using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using TrainingTake1.Models;

namespace TrainingTake1.Controllers
{
    public class HomeController : Controller
    {
        UserContext db = new UserContext();

        public ActionResult Index()
        {
            //List<User> x = db.Users.AsQueryable().ToList();

            //var users =  new UsersList {Users = x};
            return View();
        }

        //public async Task<IEnumerable<Computer>> FilterAsync(ComputerFilter cFilter)
        //{
        //    var builder = Builders<Computer>.Filter;
        //    var filters = new List<FilterDefinition<Computer>>();
        //    if (!String.IsNullOrWhiteSpace(cFilter.ComputerName))
        //    {
        //        filters.Add(builder.Eq("Name", new BsonRegularExpression(cFilter.ComputerName)));
        //    }
        //    if (cFilter.Year.HasValue)
        //    {
        //        filters.Add(builder.Eq("Year", cFilter.Year));
        //    }
        //    return await db.Computers.Find(builder.And(filters)).ToListAsync();
        //}
    }
}
