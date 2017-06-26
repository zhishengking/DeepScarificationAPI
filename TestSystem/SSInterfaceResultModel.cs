using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestSystem
{
    public class SSInterfaceResultModel
    {
        public SSInterfaceResultModel()
        {
            Timestamp = DateTime.UtcNow;
            SendMethod = "post";
        }

        /// <summary>
        /// 调用状态
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 错误代码
        /// </summary>
        public int ResponseCode { get; set; }

        /// <summary>
        /// 异常信息
        /// </summary>
        public string ExceptionMessage { get; set; }

        /// <summary>
        /// 全路径
        /// </summary>
        public string ServiceURL { get; set; }

        /// <summary>
        /// 参数Json格式
        /// {'key':'value'}
        /// </summary>
        public object ParameterModel { get; set; }

        /// <summary>
        /// GET\POST\PUT\DELETE
        /// </summary>
        public string SendMethod { get; set; }

        /// <summary>
        /// Json Result
        /// </summary>
        public string Result { get; set; }

        public DateTime Timestamp { private set; get; }
    }
}