using DeepScarificationAPI.Tests.Common;
using DeepScarificationAPI.Tests.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepScarificationAPI.Tests.Controllers
{
    [TestClass]
    public class AnalyControllerTest : ApiTestBase
    {
        Dictionary<string, string> dc = null;
        public AnalyControllerTest()
        {
            dc = new Dictionary<string, string>();
            dc.Add("month", "2016-10-01");
            dc.Add("orgid", "ksjdfladjkff");
        }
        [TestMethod]
        public void AddOrg()
        {
            var model = new SSInterfaceResultModel
            {
                ServiceURL = GetBaseAddress() + "/api/Analysis/GeCarMonthAnaly",
                ParameterModel = dc
            };
            var result = new SSInterfaceAction().Send(model, "UMLServiceKey", "a4478d501b74ee89cff5743cd920bc4f");
            Assert.IsNotNull(result.Result);
        }


        [TestMethod]
        public void testLogin()
        {
            
            sys_user_info user =new sys_user_info();
            user.user_name = "Admin";
            user.password = "123654789";
            var model = new SSInterfaceResultModel
            {
                ServiceURL = GetBaseAddress() + "/api/UserManage/AddUser",
                ParameterModel = user
            };
            var result = new SSInterfaceAction().Send(model, "UMLServiceKey", "a4478d501b74ee89cff5743cd920bc4f");
            Assert.IsNotNull(result.Result);
            
        }


        [TestMethod]
        public void testSendLoginCode()
        {

            sys_user_info user = new sys_user_info();
            //user.user_name = "Admin";
            //user.password = "123654789";
            user.phone = "18500315286";
            //string phone = ;

            Dictionary<string,string> dic =new Dictionary<string, string>();
            dic.Add("phone", "18500315286");
            dic.Add("tpl", "4");
            var model = new SSInterfaceResultModel
            {
                ServiceURL = GetBaseAddress() + "/api/ApiForMobile/SendLoginCode",
                ParameterModel = dic
            };
            var result = new SSInterfaceAction().Send(model, "UMLServiceKey", "a4478d501b74ee89cff5743cd920bc4f");
            Assert.IsNotNull(result.Result);
            
        }
        




        public override string GetBaseAddress()
        {

            return "localhost:6155/";
        }
    }
}

