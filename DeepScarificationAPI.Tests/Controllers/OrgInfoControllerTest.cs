using DeepScarificationAPI.Tests.Common;
using DeepScarificationAPI.Tests.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeepScarificationAPI.Tests.Model;

namespace DeepScarificationAPI.Tests.Controllers
{
    [TestClass]
   public class OrgInfoControllerTest : ApiTestBase
    {
        public Organization org = null;
        public Organization orgEdit = null;
        public OrganizationSel orgSel = null;
        public OrgInfoControllerTest()
        {
            org = new Organization
            {
                id = Guid.NewGuid().ToString("N"),
                org_name = "testOrg7",
                parent_id = "0617d6fe7c8242c3a9564ccc39be4c21",
                org_type=1,
                is_manufacturer=0,
                in_use=1
            };

            orgEdit = new Organization
            {
                id = "0617d6fe7c8242c3a9564ccc39be4c21",
                org_name = "testOrgEdit",
                update_user_id = "0c008d48110e420c9a1ff48e51860156"
            };

            orgSel = new OrganizationSel
            {
                org_name = "test",
                in_use=1
            };
        }
        [TestMethod]
        public void AddOrg()
        {
            var model = new SSInterfaceResultModel
            {
                ServiceURL = GetBaseAddress() + "/api/Org/AddOrg",
                ParameterModel = org
            };
            var result = new SSInterfaceAction().Send(model, "UMLServiceKey", "a4478d501b74ee89cff5743cd920bc4f");
            Assert.IsNotNull(result.Result);
        }

        [TestMethod]
        public void DelOrg()
        {
            var model = new SSInterfaceResultModel
            {
                ServiceURL = GetBaseAddress() + "/api/Org/DelOrg",
                ParameterModel = "7468dfd6f5fb47a3af9216231dcfc60a"
            };
            var result = new SSInterfaceAction().Send(model, "UMLServiceKey", "a4478d501b74ee89cff5743cd920bc4f");
            Assert.IsNotNull(result.Result);
        }

        [TestMethod]
        public void EditOrg()
        {
            var model = new SSInterfaceResultModel
            {
                ServiceURL = GetBaseAddress() + "/api/Org/EditOrg",
                ParameterModel = orgEdit
            };
            var result = new SSInterfaceAction().Send(model, "UMLServiceKey", "a4478d501b74ee89cff5743cd920bc4f");
            Assert.IsNotNull(result.Result);
        }

        [TestMethod]
        public void GetOrgListByParam()
        {
            var model = new SSInterfaceResultModel
            {
                ServiceURL = GetBaseAddress() + "/api/Org/GetOrgListByParam",
                ParameterModel = orgSel
            };
            var result = new SSInterfaceAction().Send(model, "UMLServiceKey", "a4478d501b74ee89cff5743cd920bc4f");
            Assert.IsNotNull(result.Result);
        }

        [TestMethod]
        public void getManuOrgByOrgids()
        {
            var model = new SSInterfaceResultModel
            {
                ServiceURL = GetBaseAddress() + "/api/Org/getManuOrgByOrgids",
                ParameterModel = "ksjdfladjkff"
            };
            var result = new SSInterfaceAction().Send(model, "UMLServiceKey", "a4478d501b74ee89cff5743cd920bc4f");
            Assert.IsNotNull(result.Result);
        }

        [TestMethod]
        public void GetOrgTree()
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("org_id", "ksjdfladjkff");
            param.Add("SelType", "3");
            var model = new SSInterfaceResultModel
            {
                ServiceURL = GetBaseAddress() + "/api/Org/GetOrgTree",
                ParameterModel = param
            };
            var result = new SSInterfaceAction().Send(model, "UMLServiceKey", "a4478d501b74ee89cff5743cd920bc4f");
            Assert.IsNotNull(result.Result);
        }

        [TestMethod]
        public void GetOrgList()
        {
            var model = new SSInterfaceResultModel
            {
                ServiceURL = GetBaseAddress() + "/api/Org/GetOrgList",
                ParameterModel = "ksjdfladjkff"
            };
            var result = new SSInterfaceAction().Send(model, "UMLServiceKey", "a4478d501b74ee89cff5743cd920bc4f");
            Assert.IsNotNull(result.Result);
        }

        [TestMethod]
        public void GetOrgCarTree()
        {
            var model = new SSInterfaceResultModel
            {
                ServiceURL = GetBaseAddress() + "/api/Org/GetOrgCarTree",
                ParameterModel = "ksjdfladjkff"
            };
            var result = new SSInterfaceAction().Send(model, "UMLServiceKey", "a4478d501b74ee89cff5743cd920bc4f");
            Assert.IsNotNull(result.Result);
        }

        #region
        //[TestMethod]
        //public void GetOrganizationInfoByOrgid()
        //{
        //    Organization  orgInfoCom = null;

        //    var model = new SSInterfaceResultModel
        //    {
        //        ServiceURL = GetBaseAddress() + "/api/OrgInfo/GetOrganizationInfoByOrgId",
        //        ParameterModel = orgInfoCom
        //    };
        //    var result = new SSInterfaceAction().Send(model, "UMLServiceKey", "a4478d501b74ee89cff5743cd920bc4f");
        //    Assert.IsNotNull(result.Result);

        //}
        //[TestMethod]
        //public void GetOrganizationTreeByOrgid()
        //{
        //    //DBEntities.USERINFO user = new USERINFO();
        // //   user.LOGINNAME = "zhangsan";
        // ////   user.ISADMIN = 1;
        // //   user.ORGID = "3";
        //    Organization orgInfoCom = null;
        // //   orgInfoCom.Userinfo = user;
        // //   orgInfoCom.Orgid = "1";

        //    var model = new SSInterfaceResultModel
        //    {
        //        ServiceURL = GetBaseAddress() + "/api/OrgInfo/GetOrganizationTreeByOrgid",
        //        ParameterModel = orgInfoCom
        //    };
        //    var result = new SSInterfaceAction().Send(model, "UMLServiceKey", "a4478d501b74ee89cff5743cd920bc4f");
        //    Assert.IsNotNull(result.Result);

        //}

        #endregion
        public override string GetBaseAddress()
        {

            return "http://localhost:6155/";
        }
    }
}
