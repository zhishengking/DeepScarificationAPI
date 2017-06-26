using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepScarificationAPI.Tests.Model
{
    public class PermissionTreeSel
    {
        /// <summary>
        /// 分配权限的用户角色ID
        /// </summary>
        public string localRoleId
        {
            get;
            set;
        }

        /// <summary>
        /// 被分配权限的角色ID
        /// </summary>
        public string SubRoleId
        {
            get;
            set;
        }

        /// <summary>
        /// 是否查询按钮(0:不查询，1:查询)
        /// </summary>
        public int Btn
        {
            get;
            set;
        }
    }
}
