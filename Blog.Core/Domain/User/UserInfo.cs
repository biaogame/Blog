using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core
{
    public class UserInfo
    {
        private int _uid;
        private string _username;
        private string _email;
        private string _mobile;
        private string _password;
        private string _nickname;
        private int _verifyemail;
        private int _verifymobile;
        private DateTime _liftbantime;
        private string _avatar;

        /// <summary>
		/// uid
        /// </summary>		
        public int uid
        {
            get { return _uid; }
            set { _uid = value; }
        }
        /// <summary>
        /// username
        /// </summary>		
        public string username
        {
            get { return _username; }
            set { _username = value; }
        }
        /// <summary>
        /// email
        /// </summary>		
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }
        /// <summary>
        /// mobile
        /// </summary>		
        public string mobile
        {
            get { return _mobile; }
            set { _mobile = value; }
        }
        /// <summary>
        /// password
        /// </summary>		
        public string password
        {
            get { return _password; }
            set { _password = value; }
        }
        /// <summary>
        /// nickname
        /// </summary>		
        public string nickname
        {
            get { return _nickname; }
            set { _nickname = value; }
        }
        /// <summary>
        /// verifyemail
        /// </summary>		
        public int verifyemail
        {
            get { return _verifyemail; }
            set { _verifyemail = value; }
        }
        /// <summary>
        /// verifymobile
        /// </summary>		
        public int verifymobile
        {
            get { return _verifymobile; }
            set { _verifymobile = value; }
        }
        /// <summary>
        /// 解禁时间
        /// </summary>		
        public DateTime liftbantime
        {
            get { return _liftbantime; }
            set { _liftbantime = value; }
        }
        /// <summary>
        /// 头像
        /// </summary>		
        public string avatar
        {
            get { return _avatar; }
            set { _avatar = value; }
        }

    }
}
