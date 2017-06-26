using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSystem
{
    [TestClass]
    public class OrgTest
    {

        [TestMethod]
        public string AddOrg()
        {
            var coutmodel = new SSInterfaceResultModel
            {
                ServiceURL = CommFunction.GetBaseAddress() + "api/Org/AddOrg",
                ParameterModel = strTerminalNo
            };
            var countresult = new SSInterfaceAction().Send(coutmodel, "UMLServiceKey", "a4478d501b74ee89cff5743cd920bc4f");
            var str = Newtonsoft.Json.JsonConvert.DeserializeObject<string>(countresult.Result);
            return str;
        }
    }
}
