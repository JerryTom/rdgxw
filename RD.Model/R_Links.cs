/******************************************
* 模块名称：实体 R_Links
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
	/// 实体 R_Links
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public partial class R_Links
	{
        #region 构造函数
        /// <summary>
        /// 实体 R_Links
        /// </summary>
        public R_Links(){}
        #endregion

        #region 私有变量
        private long _id = long.MinValue;
        private string _links_name = null;
        private string _links_url = null;
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
        /// Links_Name
        /// </summary>
        public string Links_Name
        {
            set{ _links_name=value;}
            get{return _links_name;}
        }
        /// <summary>
        /// Links_Url
        /// </summary>
        public string Links_Url
        {
            set{ _links_url=value;}
            get{return _links_url;}
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
        /// 表名 表原信息描述: R_Links
        /// </summary>
        public static readonly string s_TableName =  "R_Links";
        /// <summary>
        /// 信息描述: ID(NOT NULL)
        /// </summary>
        public static readonly string s_ID =  "R_Links┋ID┋System.Int64";
        /// <summary>
        /// 信息描述: Links_Name
        /// </summary>
        public static readonly string s_Links_Name =  "R_Links┋Links_Name┋System.String";
        /// <summary>
        /// 信息描述: Links_Url
        /// </summary>
        public static readonly string s_Links_Url =  "R_Links┋Links_Url┋System.String";
        /// <summary>
        /// 信息描述: User_ID
        /// </summary>
        public static readonly string s_User_ID =  "R_Links┋User_ID┋System.Int64";
        #endregion
	}
}
