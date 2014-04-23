/******************************************
* 模块名称：实体 R_Practical
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
	/// 实体 R_Practical
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public partial class R_Practical
	{
        #region 构造函数
        /// <summary>
        /// 实体 R_Practical
        /// </summary>
        public R_Practical(){}
        #endregion

        #region 私有变量
        private long _id = long.MinValue;
        private string _practical_name = null;
        private string _practical_url = null;
        private long _user_id = long.MinValue;
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
        /// Practical_Name
        /// </summary>
        public string Practical_Name
        {
            set{ _practical_name=value;}
            get{return _practical_name;}
        }
        /// <summary>
        /// Practical_Url
        /// </summary>
        public string Practical_Url
        {
            set{ _practical_url=value;}
            get{return _practical_url;}
        }
        /// <summary>
        /// User_ID
        /// </summary>
        public long User_ID
        {
            set{ _user_id=value;}
            get{return _user_id;}
        }
        #endregion

        #region 公共静态只读属性
        /// <summary>
        /// 表名 表原信息描述: R_Practical
        /// </summary>
        public static readonly string s_TableName =  "R_Practical";
        /// <summary>
        /// 信息描述: ID(NOT NULL)
        /// </summary>
        public static readonly string s_ID =  "R_Practical┋ID┋System.Int64";
        /// <summary>
        /// 信息描述: Practical_Name
        /// </summary>
        public static readonly string s_Practical_Name =  "R_Practical┋Practical_Name┋System.String";
        /// <summary>
        /// 信息描述: Practical_Url
        /// </summary>
        public static readonly string s_Practical_Url =  "R_Practical┋Practical_Url┋System.String";
        /// <summary>
        /// 信息描述: User_ID
        /// </summary>
        public static readonly string s_User_ID =  "R_Practical┋User_ID┋System.Int64";
        #endregion
	}
}
