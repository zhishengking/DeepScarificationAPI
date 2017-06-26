using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepScarificationAPI.Tests.Model
{
    /// <summary>
    /// 查询企业的输入条件
    /// </summary>
    public class OrganizationSel
    {
        #region Model 原生的属性
        private string _id;
        private string _org_name;
        private int? _org_type;
        private string _org_ids;
        private string _parent_id;
        private string _parent_name;
        private DateTime? _create_time;
        private DateTime? _update_time;
        private string _update_user_id;
        private int? _in_use = 0;
        private int? _is_manufacturer;
        private string _manufacturer_id;
        /// <summary>
        /// 
        /// </summary>
        public string id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string org_name
        {
            set { _org_name = value; }
            get { return _org_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? org_type
        {
            set { _org_type = value; }
            get { return _org_type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string org_ids
        {
            set { _org_ids = value; }
            get { return _org_ids; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string parent_id
        {
            set { _parent_id = value; }
            get { return _parent_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string parent_name
        {
            set { _parent_name = value; }
            get { return _parent_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? create_time
        {
            set { _create_time = value; }
            get { return _create_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? update_time
        {
            set { _update_time = value; }
            get { return _update_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string update_user_id
        {
            set { _update_user_id = value; }
            get { return _update_user_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? in_use
        {
            set { _in_use = value; }
            get { return _in_use; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? is_manufacturer
        {
            set { _is_manufacturer = value; }
            get { return _is_manufacturer; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string manufacturer_id
        {
            set { _manufacturer_id = value; }
            get { return _manufacturer_id; }
        }
        #endregion Model

        #region 新增的属性
        public string forg_name
        {
            get;
            set;
        }

        #endregion





    }
}
