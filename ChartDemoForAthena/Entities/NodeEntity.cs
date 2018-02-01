using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChartDemoForAthena.Entities
{
    public class NodeEntity
    {
        public string id { get; set; }

        public string name { get; set; }

        public string value { get; set; }

        public object data { get; set; }

        public List<NodeEntity> children { get; set; }
        //     id: "node0",
        //     name: "Z109-WS·2011-Y-BGS-0001",
        //     data: {},
        //     children:
    }
}