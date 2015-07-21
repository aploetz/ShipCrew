using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

using Cassandra;
using Cassandra.Mapping;

using ShipCrew.Models;

namespace ShipCrew.DAO
{
    public interface IShipCrewDAO
    {
        Task<IEnumerable<ShipCrewModels>> getCrew();
    }

    public class ShipCrewDAO : IShipCrewDAO
    {
        protected readonly ISession session;
        protected readonly IMapper mapper;

        public ShipCrewDAO()
        {
            ICassandraDAO cassandraDAO = new CassandraDAO();
            session = cassandraDAO.GetSession();
            mapper = new Mapper(session);
        }

        public async Task<IEnumerable<ShipCrewModels>> getCrew()
        {
            return await mapper.FetchAsync<ShipCrewModels>();
        }
    }
}