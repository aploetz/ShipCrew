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
        public static Container Initialize()
        {
            var container = new Container();
            container.Register<ICassandraDAO, CassandraDAO>();

            return container;
        }

    }
}