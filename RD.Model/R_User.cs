/******************************************
* 模块名称：实体 R_User
* 当前版本：1.0
* 开发人员：Tan
* 生成时间：2014/3/14 星期五
* 版本历史：此代码由 VB/C#.Net实体代码生成工具(EntitysCodeGenerate 4.5) 自动生成。
* 
******************************************/
using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;

namespace RD.Model
{
	/// <summary>
	/// 实体 R_User
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public partial class R_User
	{
        #region 构造函数
        /// <summary>
        /// 实体 R_User
        /// </summary>
        public R_User(){}
        #endregion

        #region 私有变量
        private long _id = long.MinValue;
        private long _logincount = long.MinValue;
        private string _lostlogintime = null;
        private string _password = null;
        private string _user_name = null;
        private long _user_type = long.MinValue;
        #endregion

        #region 公共属性
        /// <summary>
        /// 主键 ID(NOT NULL)
        /// </summary>
        public long ID
        {
            set{ _id=value;}
            get{return _id;}
        }
        /// <summary>
        /// LoginCount
        /// </summary>
        public long LoginCount
        {
            set{ _logincount=value;}
            get{return _logincount;}
        }
        /// <summary>
        /// LostLoginTime
        /// </summary>
        public string LostLoginTime
        {
            set{ _lostlogintime=value;}
            get{return _lostlogintime;}
        }
        /// <summary>
        /// Password
        /// </summary>
        public string Password
        {
            set{ _password=value;}
            get{return _password;}
        }
        /// <summary>
        /// User_Name
        /// </summary>
        public string User_Name
        {
            set{ _user_name=value;}
            get{return _user_name;}
        }
        /// <summary>
        /// User_Type
        /// </summary>
        public long User_Type
        {
            set{ _user_type=value;}
            get{return _user_type;}
        }
        #endregion

        #region 公共静态只读属性
        /// <summary>
        /// 表名 表原信息描述: R_User
        /// </summary>
        public static readonly string s_TableName =  "R_User";
        /// <summary>
        /// 信息描述: ID(NOT NULL)
        /// </summary>
        public static readonly string s_ID =  "R_User┋ID┋System.Int64";
        /// <summary>
        /// 信息描述: LoginCount
        /// </summary>
        public static readonly string s_LoginCount =  "R_User┋LoginCount┋System.Int64";
        /// <summary>
        /// 信息描述: LostLoginTime
        /// </summary>
        public static readonly string s_LostLoginTime =  "R_User┋LostLoginTime┋System.String";
        /// <summary>
        /// 信息描述: Password
        /// </summary>
        public static readonly string s_Password =  "R_User┋Password┋System.String";
        /// <summary>
        /// 信息描述: User_Name
        /// </summary>
        public static readonly string s_User_Name =  "R_User┋User_Name┋System.String";
        /// <summary>
        /// 信息描述: User_Type
        /// </summary>
        public static readonly string s_User_Type =  "R_User┋User_Type┋System.Int64";
        #endregion
	}
}
