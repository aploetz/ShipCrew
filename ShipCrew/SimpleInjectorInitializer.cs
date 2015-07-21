using SimpleInjector;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using ShipCrew.DAO;

namespace ShipCrew
{
    public static class SimpleInjectorInitializer
    {
        public static Container cont { get; set; }

        public static Container Initialize()
        {
            cont = new Container();
            cont.Register<IShipCrewDAO, ShipCrewDAO>();

            return cont;
        }

    }
}