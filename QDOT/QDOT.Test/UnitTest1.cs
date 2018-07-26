using QDOT.Controllers;
using QDOT.DataAccess;
using QDOT.Domain;
using QDOT.Model;
using System;
using System.Collections.Generic;
using Xunit;

namespace QDOT.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //var controller = new DeveloperController();

            //string all = "[{"firstName":"Colin","lastName":"Abbot","age":34,"skills":[{"name":"C#","type":"backend","level":9},{"name":"JavaScript","type":"frontend","level":5},{"name":"SQL","type":"backend","level":7},{"name":"HTML","type":"frontend","level":3}]},{"firstName":"Sarah","lastName":"Winchester","age":34,"skills":[{"name":"C#","type":"backend","level":1},{"name":"JavaScript","type":"frontend","level":9},{"name":"SQL","type":"backend","level":1},{"name":"HTML","type":"frontend","level":10}]},{"firstName":"Andrei","lastName":"Reeves","age":37,"skills":[{"name":"C#","type":"backend","level":5},{"name":"JavaScript","type":"frontend","level":5},{"name":"SQL","type":"frontend","level":5},{"name":"HTML","type":"frontend","level":5}]}] ";

            //string filtered = "[{"firstName":"Colin","lastName":"Abbot","age":34,"skills":[{"name":"C#","type":"backend","level":9}]},{"firstName":"Sarah","lastName":"Winchester","age":34,"skills":[{"name":"JavaScript","type":"frontend","level":9},{"name":"HTML","type":"frontend","level":10}]}]";

            //var result_GelAll = controller.Get();
            //Assert.Equal(all, result_GelAll);

            //var result_GelFiltered = controller.GetFilteredAsync();
            //Assert.Equal(filtered, result_GelFiltered);
        }
    }
}
