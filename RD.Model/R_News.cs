/******************************************
* 模块名称：实体 R_News
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
	/// 实体 R_News
	/// </summary>
	[Description("Primary:ID")]
    [Serializable]
	public partial class R_News
	{
        #region 构造函数
        /// <summary>
        /// 实体 R_News
        /// </summary>
        public R_News(){}
        #endregion

        #region 私有变量
        private long _id = long.MinValue;
        private string _news_addtime = null;
        private string _news_content = null;
        private long _news_count = long.MinValue;
        private string _news_edittime = null;
        private long _news_imagebool = long.MinValue;
        private string _news_images = null;
        private long _news_reading = long.MinValue;
        private string _news_tital = null;
        private long _sort_id = long.MinValue;
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
        /// News_AddTime
        /// </summary>
        public string News_AddTime
        {
            set{ _news_addtime=value;}
            get{return _news_addtime;}
        }
        /// <summary>
        /// News_Content
        /// </summary>
        public string News_Content
        {
            set{ _news_content=value;}
            get{return _news_content;}
        }
        /// <summary>
        /// News_Count
        /// </summary>
        public long News_Count
        {
            set{ _news_count=value;}
            get{return _news_count;}
        }
        /// <summary>
        /// News_EditTime
        /// </summary>
        public string News_EditTime
        {
            set{ _news_edittime=value;}
            get{return _news_edittime;}
        }
        /// <summary>
        /// News_ImageBool
        /// </summary>
        public long News_ImageBool
        {
            set{ _news_imagebool=value;}
            get{return _news_imagebool;}
        }
        /// <summary>
        /// News_Images
        /// </summary>
        public string News_Images
        {
            set{ _news_images=value;}
            get{return _news_images;}
        }
        /// <summary>
        /// News_Reading
        /// </summary>
        public long News_Reading
        {
            set{ _news_reading=value;}
            get{return _news_reading;}
        }
        /// <summary>
        /// News_Tital
        /// </summary>
        public string News_Tital
        {
            set{ _news_tital=value;}
            get{return _news_tital;}
        }
        /// <summary>
        /// Sort_ID
        /// </summary>
        public long Sort_ID
        {
            set{ _sort_id=value;}
            get{return _sort_id;}
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
        /// 表名 表原信息描述: R_News
        /// </summary>
        public static readonly string s_TableName =  "R_News";
        /// <summary>
        /// 信息描述: ID(NOT NULL)
        /// </summary>
        public static readonly string s_ID =  "R_News┋ID┋System.Int64";
        /// <summary>
        /// 信息描述: News_AddTime
        /// </summary>
        public static readonly string s_News_AddTime =  "R_News┋News_AddTime┋System.String";
        /// <summary>
        /// 信息描述: News_Content
        /// </summary>
        public static readonly string s_News_Content =  "R_News┋News_Content┋System.String";
        /// <summary>
        /// 信息描述: News_Count
        /// </summary>
        public static readonly string s_News_Count =  "R_News┋News_Count┋System.Int64";
        /// <summary>
        /// 信息描述: News_EditTime
        /// </summary>
        public static readonly string s_News_EditTime =  "R_News┋News_EditTime┋System.String";
        /// <summary>
        /// 信息描述: News_ImageBool
        /// </summary>
        public static readonly string s_News_ImageBool =  "R_News┋News_ImageBool┋System.Int64";
        /// <summary>
        /// 信息描述: News_Images
        /// </summary>
        public static readonly string s_News_Images =  "R_News┋News_Images┋System.String";
        /// <summary>
        /// 信息描述: News_Reading
        /// </summary>
        public static readonly string s_News_Reading =  "R_News┋News_Reading┋System.Int64";
        /// <summary>
        /// 信息描述: News_Tital
        /// </summary>
        public static readonly string s_News_Tital =  "R_News┋News_Tital┋System.String";
        /// <summary>
        /// 信息描述: Sort_ID
        /// </summary>
        public static readonly string s_Sort_ID =  "R_News┋Sort_ID┋System.Int64";
        /// <summary>
        /// 信息描述: User_ID
        /// </summary>
        public static readonly string s_User_ID =  "R_News┋User_ID┋System.Int64";
        #endregion
	}
}
