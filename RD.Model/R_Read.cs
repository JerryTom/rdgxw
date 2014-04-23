/******************************************
* 模块名称：实体 R_Read
* 当前版本：1.0
* 开发人员：Tan
* 生成时间：2014/3/19
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
	/// 实体 R_Read
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public partial class R_Read
	{
        #region 构造函数
        /// <summary>
        /// 实体 R_Read
        /// </summary>
        public R_Read(){}
        #endregion

        #region 私有变量
        private long _id = long.MinValue;
        private long _news_id = long.MinValue;
        private string _read_count = null;
        private string _read_ip = null;
        private DateTime _read_time = DateTime.MinValue;
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
        /// News_ID
        /// </summary>
        public long News_ID
        {
            set{ _news_id=value;}
            get{return _news_id;}
        }
        /// <summary>
        /// Read_Count
        /// </summary>
        public string Read_Count
        {
            set{ _read_count=value;}
            get{return _read_count;}
        }
        /// <summary>
        /// Read_IP
        /// </summary>
        public string Read_IP
        {
            set{ _read_ip=value;}
            get{return _read_ip;}
        }
        /// <summary>
        /// Read_Time
        /// </summary>
        public DateTime Read_Time
        {
            set{ _read_time=value;}
            get{return _read_time;}
        }
        #endregion

        #region 公共静态只读属性
        /// <summary>
        /// 表名 表原信息描述: R_Read
        /// </summary>
        public static readonly string s_TableName =  "R_Read";
        /// <summary>
        /// 信息描述: ID(NOT NULL)
        /// </summary>
        public static readonly string s_ID =  "R_Read┋ID┋System.Int64";
        /// <summary>
        /// 信息描述: News_ID
        /// </summary>
        public static readonly string s_News_ID =  "R_Read┋News_ID┋System.Int64";
        /// <summary>
        /// 信息描述: Read_Count
        /// </summary>
        public static readonly string s_Read_Count =  "R_Read┋Read_Count┋System.String";
        /// <summary>
        /// 信息描述: Read_IP
        /// </summary>
        public static readonly string s_Read_IP =  "R_Read┋Read_IP┋System.String";
        /// <summary>
        /// 信息描述: Read_Time
        /// </summary>
        public static readonly string s_Read_Time =  "R_Read┋Read_Time┋System.DateTime";
        #endregion
	}
}
