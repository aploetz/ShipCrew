using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

using ShipCrew.Models;
using ShipCrew.DAO;

namespace ShipCrew.Controllers
{
    public class ShipCrewController : Controller
    {
        // GET: ShipCrew
        public async Task<ActionResult> Index(ShipCrewDAO shipCrewDAO)
        {
            IEnumerable<ShipCrewModels> shipcrew = await shipCrewDAO.getCrew();
            return View("Index", shipcrew.ToList());
        }
    }
}