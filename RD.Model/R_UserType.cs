/******************************************
* 模块名称：实体 R_UserType
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
	/// 实体 R_UserType
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public partial class R_UserType
	{
        #region 构造函数
        /// <summary>
        /// 实体 R_UserType
        /// </summary>
        public R_UserType(){}
        #endregion

        #region 私有变量
        private long _id = long.MinValue;
        private string _usertype_name = null;
        private long _usertype_value = long.MinValue;
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
        /// UserType_Name
        /// </summary>
        public string UserType_Name
        {
            set{ _usertype_name=value;}
            get{return _usertype_name;}
        }
        /// <summary>
        /// UserType_Value
        /// </summary>
        public long UserType_Value
        {
            set{ _usertype_value=value;}
            get{return _usertype_value;}
        }
        #endregion

        #region 公共静态只读属性
        /// <summary>
        /// 表名 表原信息描述: R_UserType
        /// </summary>
        public static readonly string s_TableName =  "R_UserType";
        /// <summary>
        /// 信息描述: ID(NOT NULL)
        /// </summary>
        public static readonly string s_ID =  "R_UserType┋ID┋System.Int64";
        /// <summary>
        /// 信息描述: UserType_Name
        /// </summary>
        public static readonly string s_UserType_Name =  "R_UserType┋UserType_Name┋System.String";
        /// <summary>
        /// 信息描述: UserType_Value
        /// </summary>
        public static readonly string s_UserType_Value =  "R_UserType┋UserType_Value┋System.Int64";
        #endregion
	}
}
