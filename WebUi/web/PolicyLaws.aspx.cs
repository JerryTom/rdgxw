using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RD.BAL;

public partial class web_PolicyLaws : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bindData();
        }
    }

    private void bindData()
    {
        B_Index b = new B_Index();
        Links.InnerHtml = b.getLinks();
        B_InforData bf = new B_InforData();
        hotNews.InnerHtml = bf.getHotNews();
        bindNews();
        B_News bn = new B_News();
        webInfor.InnerHtml = bn.getWebInfor().Tables[0].Rows[0]["News_Content"].ToString();
    }

    private void bindNews()
    {
        B_InforData bf = new B_InforData();
        dgPager.RecordCount = bf.getPolicyLawsCount();
        dgPager.PageSize = 15;
        dataTable.InnerHtml = bf.getPolicyLaws(dgPager.StartRecordIndex, dgPager.EndRecordIndex);
    }
    protected void dgPager_PageChanged(object sender, EventArgs e)
    {
        bindNews();
    }
}