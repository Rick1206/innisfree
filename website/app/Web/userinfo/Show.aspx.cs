using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
namespace Maticsoft.Web.userinfo
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int ID=(Convert.ToInt32(strid));
					ShowInfo(ID);
				}
			}
		}
		
	private void ShowInfo(int ID)
	{
		Maticsoft.BLL.userinfo bll=new Maticsoft.BLL.userinfo();
		Maticsoft.Model.userinfo model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lbluname.Text=model.uname;
		this.lblusex.Text=model.usex;
		this.lbluage.Text=model.uage;
		this.lbluphone.Text=model.uphone;
		this.lbluemail.Text=model.uemail;
		this.lblwid.Text=model.wid;
		this.lblwname.Text=model.wname;
		this.lblparameter1.Text=model.parameter1;
		this.lblparameter2.Text=model.parameter2;

	}


    }
}
