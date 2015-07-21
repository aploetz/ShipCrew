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
        private static IShipCrewDAO dao;

        public ShipCrewController()
        {
        }

        protected IShipCrewDAO shipCrewDao
        {
            get
            {
                if (dao == null)
                {
                    dao = MvcApplication.container.GetInstance<IShipCrewDAO>();
                }
                return dao;
            }
        }

        public async Task<ActionResult> Index()
        {
            IEnumerable<ShipCrewModels> shipcrew = await shipCrewDao.getCrew();
            return View("Index", shipcrew.ToList());
        }
    }
}