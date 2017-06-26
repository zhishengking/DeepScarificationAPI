using System;
namespace DeepScarificationAPI.Tests.Model
{
	/// <summary>
	/// sys_role_info:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class RoleInfo
	{
        public RoleInfo()
		{}
		#region Model
		private string _id;
		private string _role_name;
		private string _permission_ids;
		private int? _in_use=0;
		private string _parent_id;
		private DateTime? _create_time;
		private DateTime? _update_time;
		private string _update_user_id;
		private string _org_id;
        private string _remark;
		/// <summary>
		/// 
		/// </summary>
		public string id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string role_name
		{
			set{ _role_name=value;}
			get{return _role_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string permission_ids
		{
			set{ _permission_ids=value;}
			get{return _permission_ids;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? in_use
		{
			set{ _in_use=value;}
			get{return _in_use;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string parent_id
		{
			set{ _parent_id=value;}
			get{return _parent_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? create_time
		{
			set{ _create_time=value;}
			get{return _create_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? update_time
		{
			set{ _update_time=value;}
			get{return _update_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string update_user_id
		{
			set{ _update_user_id=value;}
			get{return _update_user_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string org_id
		{
			set{ _org_id=value;}
			get{return _org_id;}
		}

        /// <summary>
		/// 
		/// </summary>
        public string remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
        
		#endregion Model

	}
}

