using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using RD.BAL;
using System.Text;

public partial class _Default : System.Web.UI.Page
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
        Reading.InnerHtml = b.getDataByReading();
        Latestnews.InnerHtml = b.getLatestnews();
        hotNews.InnerHtml = b.getHotNews();
        imageBox.InnerHtml = b.getDataByImg();
        icoBox.InnerHtml = b.getIcoBox();
        demo1.InnerHtml = b.getImgList();

        _Marknews.InnerHtml = b.getMarknews();
        _AgricultTech.InnerHtml = b.getAgricultTech();
        _Supply_Infor.InnerHtml = b.getSupply_demandInfor();

        _PolicyLaws.InnerHtml = b.getPolicyLaws();
        _NYKJ.InnerHtml = b.getNYKJ();
        _Economicnews.InnerHtml = b.getEconomicnews();

        B_News bn=new B_News();
        webInfor.InnerHtml = bn.getWebInfor().Tables[0].Rows[0]["News_Content"].ToString();
    }
}