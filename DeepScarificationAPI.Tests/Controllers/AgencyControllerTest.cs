using System;
using System.Text;
using System.Collections.Generic;
using DeepScarificationAPI.Tests.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeepScarificationAPI.Tests.Controllers
{
    /// <summary>
    /// AgencyControllerTest 的摘要说明
    /// </summary>
    [TestClass]
    public class AgencyControllerTest:ApiTestBase
    {
        public string CarId = "";
        public AgencyControllerTest()
        {
            CarId = "9fe1d63666ee4bc0ac55be0c197f3534";
            //
            //TODO:  在此处添加构造函数逻辑
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，该上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试特性
        //
        // 编写测试时，可以使用以下附加特性: 
        //
        // 在运行类中的第一个测试之前使用 ClassInitialize 运行代码
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // 在类中的所有测试都已运行之后使用 ClassCleanup 运行代码
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // 在运行每个测试之前，使用 TestInitialize 来运行代码
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // 在每个测试运行完之后，使用 TestCleanup 来运行代码
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
        {
            //
            // TODO:  在此处添加测试逻辑
            //
        }

        [TestMethod]
        public void GetCarStatusHistory()
        {
            //carId = "9fe1d63666ee4bc0ac55be0c197f3534";
            //Dictionary<string, string> Param = new Dictionary<string, string>();
            //Param.Add("carId", carId);
            var model = new SSInterfaceResultModel
            {
                ServiceURL = GetBaseAddress() + "/api/AgencyManage/GetTerminalTranferHistory",
                ParameterModel = CarId
            };
            var result = new SSInterfaceAction().Send(model, "UMLServiceKey", "a4478d501b74ee89cff5743cd920bc4f");
            string k = result.Result;
            //return result.Result;

            Assert.IsNotNull(result.Result);
        }


        [TestMethod]
        public void GetHistoryCanInfo()
        {
            Dictionary<string,string> Dic =new Dictionary<string, string>();
            Dic.Add("vehicleId", "a7ac382fd42c4ac6b8953e1fc4bdfed4");
            Dic.Add("sTime","2017-05-16 00:00:00");
            Dic.Add("eTime", "2017-05-16 23:59:59");
                 var model = new SSInterfaceResultModel
            {
                ServiceURL = GetBaseAddress() + "/api/HistoryInfo/GetHistoryCanInfo",
                ParameterModel = Dic
            };
            var result = new SSInterfaceAction().Send(model, "UMLServiceKey", "a4478d501b74ee89cff5743cd920bc4f");
            string k = result.Result;
            
        }

        public override string GetBaseAddress()
        {

            return "http://localhost:6155/";
        }
    }
}
