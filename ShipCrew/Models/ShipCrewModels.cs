using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Cassandra.Mapping.Attributes;

namespace ShipCrew.Models
{
    [Table("presentation.crew")]
    public class ShipCrewModels
    {
        public string crewname { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string phone { get; set; }
    }
}