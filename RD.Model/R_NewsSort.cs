/******************************************
* 模块名称：实体 R_NewsSort
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
	/// 实体 R_NewsSort
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public partial class R_NewsSort
	{
        #region 构造函数
        /// <summary>
        /// 实体 R_NewsSort
        /// </summary>
        public R_NewsSort(){}
        #endregion

        #region 私有变量
        private long _id = long.MinValue;
        private string _sort_name = null;
        private string _sort_value = null;
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
        /// Sort_Name
        /// </summary>
        public string Sort_Name
        {
            set{ _sort_name=value;}
            get{return _sort_name;}
        }
        /// <summary>
        /// Sort_Value
        /// </summary>
        public string Sort_Value
        {
            set{ _sort_value=value;}
            get{return _sort_value;}
        }
        #endregion

        #region 公共静态只读属性
        /// <summary>
        /// 表名 表原信息描述: R_NewsSort
        /// </summary>
        public static readonly string s_TableName =  "R_NewsSort";
        /// <summary>
        /// 信息描述: ID(NOT NULL)
        /// </summary>
        public static readonly string s_ID =  "R_NewsSort┋ID┋System.Int64";
        /// <summary>
        /// 信息描述: Sort_Name
        /// </summary>
        public static readonly string s_Sort_Name =  "R_NewsSort┋Sort_Name┋System.String";
        /// <summary>
        /// 信息描述: Sort_Value
        /// </summary>
        public static readonly string s_Sort_Value =  "R_NewsSort┋Sort_Value┋System.String";
        #endregion
	}
}
