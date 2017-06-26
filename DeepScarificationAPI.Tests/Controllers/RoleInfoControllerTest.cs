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
    public class RoleInfoControllerTest : ApiTestBase
    {

         public RoleInfo roleInfo = null;
         public RoleInfo roleEdit = null;
         public RoleInfoSel roleSel = null;
         public  PermissionTreeSel pt = null;
         public RoleInfoControllerTest() 
         {
             pt = new PermissionTreeSel { 
                localRoleId="11111111",
                SubRoleId="11000111",
                Btn=1
             };

             roleInfo = new RoleInfo
             {
                 //id = Guid.NewGuid().ToString("N"),
                 role_name = "TestR3",
                 permission_ids = "",
                 in_use = 1,
                 update_user_id = "0c008d48110e420c9a1ff48e51860156",
                 org_id = "685882e15f5e42c29fae21d14c763333",
                 remark = "rmk"
             };
             roleEdit = new RoleInfo
             {
                 id = "7dbf885a2c0a4ab3b5953acbacac74f3",
                 role_name = "NewRoleEdit",
                 permission_ids = "",
                 in_use = 1,
                 update_user_id = "0c008d48110e420c9a1ff48e51860156",
                 org_id = "1",
                 remark = "rmk"
             };

             roleSel = new RoleInfoSel
             {
                 //id = "7dbf885a2c0a4ab3b5953acbacac74f3",
                 role_name = "stR",
                 in_use = 1,
                 update_user_id = "0c008d48110e420c9a1ff48e51860156",
                 org_id = "1",
                 remark = "rmk"
             };

         
         }

         [TestMethod]
         public void AddRole()
         {
             var model = new SSInterfaceResultModel
             {
                 ServiceURL = GetBaseAddress() + "/api/Role/AddRole",
                 ParameterModel = roleInfo
             };
             var result = new SSInterfaceAction().Send(model, "UMLServiceKey", "a4478d501b74ee89cff5743cd920bc4f");
             Assert.IsNotNull(result.Result);
         }

         [TestMethod]
         public void DelRole()
         {
             var model = new SSInterfaceResultModel
             {
                 ServiceURL = GetBaseAddress() + "/api/Role/DelRole",
                 ParameterModel = "7dbf885a2c0a4ab3b5953acbacac74f3"
             };
             var result = new SSInterfaceAction().Send(model, "UMLServiceKey", "a4478d501b74ee89cff5743cd920bc4f");
             Assert.IsNotNull(result.Result);
         }

         [TestMethod]
         public void UpdateRole()
         {
             var model = new SSInterfaceResultModel
             {
                 ServiceURL = GetBaseAddress() + "/api/Role/UpdateRole",
                 ParameterModel = roleEdit
             };
             var result = new SSInterfaceAction().Send(model, "UMLServiceKey", "a4478d501b74ee89cff5743cd920bc4f");
             Assert.IsNotNull(result.Result);
         }

         [TestMethod]
         public void GetRoleList()
         {
             var model = new SSInterfaceResultModel
             {
                 ServiceURL = GetBaseAddress() + "/api/Role/GetRoleList",
                 ParameterModel = roleSel
             };
             var result = new SSInterfaceAction().Send(model, "UMLServiceKey", "a4478d501b74ee89cff5743cd920bc4f");
             Assert.IsNotNull(result.Result);
         }


         [TestMethod]
         public void GetPermission()
         {
             var model = new SSInterfaceResultModel
             {
                 ServiceURL = GetBaseAddress() + "/api/Role/GetPermission",
                 ParameterModel = "11010011"
             };
             var result = new SSInterfaceAction().Send(model, "UMLServiceKey", "a4478d501b74ee89cff5743cd920bc4f");
             Assert.IsNotNull(result.Result);
         }

         [TestMethod]
         public void GetMenuTree()
         {
             var model = new SSInterfaceResultModel
             {
                 ServiceURL = GetBaseAddress() + "/api/Role/GetMenuTree",
                 ParameterModel = pt
             };
             var result = new SSInterfaceAction().Send(model, "UMLServiceKey", "a4478d501b74ee89cff5743cd920bc4f");
             Assert.IsNotNull(result.Result);
         }

         [TestMethod]
         public void GetRoleInfoListByRoleId()
         {
             var model = new SSInterfaceResultModel
             {
                 ServiceURL = GetBaseAddress() + "/api/Role/GetRoleInfoListByRoleId",
                 ParameterModel = "7dbf885a2c0a4ab3b5953acbacac74f3"
             };
             var result = new SSInterfaceAction().Send(model, "UMLServiceKey", "a4478d501b74ee89cff5743cd920bc4f");
             Assert.IsNotNull(result.Result);
         }





         public override string GetBaseAddress()
         {

             return "http://localhost:6155/";
         }

    }
}
