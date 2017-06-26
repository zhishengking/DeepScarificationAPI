using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepScarificationAPI.Tests.Model
{
    public class sys_user_info
    {
        private string _org_name;
        public string org_name
        {
            set { _org_name = value; }
            get { return _org_name; }
        }
        private int _is_Bind;
        /// <summary>
        /// 是否绑定角色
        /// </summary>
        public int is_Bind
        {
            get { return _is_Bind; }
            set { _is_Bind = value; }
        }
        private int _is_admin;
        /// <summary>
        /// 
        /// </summary>
        public int is_admin { get; set; }
        private string _login_name;
        public string role_id { get; set; }
        public string login_name
        {
            get { return _login_name; }
            set { _login_name = value; }
        }
        /// <summary>
        /// id
        /// </summary>		
        private string _id;

        public string id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// user_name
        /// </summary>		
        private string _user_name;

        public string user_name
        {
            get { return _user_name; }
            set { _user_name = value; }
        }

        /// <summary>
        /// user_type
        /// </summary>		
        private int _user_type;

        public int user_type
        {
            get { return _user_type; }
            set { _user_type = value; }
        }

        /// <summary>
        /// email
        /// </summary>		
        private string _email;

        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        /// <summary>
        /// phone
        /// </summary>		
        private string _phone;

        public string phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        /// <summary>
        /// password
        /// </summary>		
        private string _password;

        public string password
        {
            get { return _password; }
            set { _password = value; }
        }
        private string _password1;

        public string password1
        {
            get { return _password1; }
            set { _password1 = value; }
        }

        /// <summary>
        /// salt
        /// </summary>		
        private string _salt;

        public string salt
        {
            get { return _salt; }
            set { _salt = value; }
        }

        /// <summary>
        /// locked
        /// </summary>		
        private int _locked;

        public int locked
        {
            get { return _locked; }
            set { _locked = value; }
        }

        /// <summary>
        /// url
        /// </summary>		
        private string _url;

        public string url
        {
            get { return _url; }
            set { _url = value; }
        }

        /// <summary>
        /// gender
        /// </summary>		
        private int _gender;

        public int gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        /// <summary>
        /// age
        /// </summary>		
        private int _age;

        public int age
        {
            get { return _age; }
            set { _age = value; }
        }

        /// <summary>
        /// pnid
        /// </summary>		
        private string _pnid;

        public string pnid
        {
            get { return _pnid; }
            set { _pnid = value; }
        }

        /// <summary>
        /// create_time
        /// </summary>		
        private DateTime _create_time;

        public DateTime create_time
        {
            get { return _create_time; }
            set { _create_time = value; }
        }

        /// <summary>
        /// update_time
        /// </summary>		
        private DateTime _update_time;

        public DateTime update_time
        {
            get { return _update_time; }
            set { _update_time = value; }
        }

        /// <summary>
        /// update_user_id
        /// </summary>		
        private string _update_user_id;

        public string update_user_id
        {
            get { return _update_user_id; }
            set { _update_user_id = value; }
        }

        /// <summary>
        /// org_id
        /// </summary>		
        private string _org_id;

        public string org_id
        {
            get { return _org_id; }
            set { _org_id = value; }
        }
        /// <summary>
        /// valid
        /// </summary>		
        private int _valid;
        public int valid
        {
            get { return _valid; }
            set { _valid = value; }
        }

        private string _typeName;

        public string typeName
        {
            get { return _typeName; }
            set { _typeName = value; }
        }
        private string _isValidate;
        public string is_verify
        {
            get { return _isValidate; }
            set { _isValidate = value; }
        }
        public string org_type { get; set; }
        public string AuthMethod { get; set; }
    }
}
