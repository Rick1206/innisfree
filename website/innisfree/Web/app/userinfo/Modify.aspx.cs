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
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace Maticsoft.Web.app.userinfo
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int ID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(ID);
				}
			}
		}
			
	private void ShowInfo(int ID)
	{
		Maticsoft.BLL.app.userinfo bll=new Maticsoft.BLL.app.userinfo();
		Maticsoft.Model.app.userinfo model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtuname.Text=model.uname;
		this.chkusex.Checked=model.usex;
		this.txtuage.Text=model.uage.ToString();
		this.txtuphone.Text=model.uphone;
		this.txtuemail.Text=model.uemail;
		this.txtwid.Text=model.wid;
		this.txtwname.Text=model.wname;
		this.txtparameter1.Text=model.parameter1;
		this.txtparameter2.Text=model.parameter2;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtuname.Text.Trim().Length==0)
			{
				strErr+="uname不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtuage.Text))
			{
				strErr+="uage格式错误！\\n";	
			}
			if(this.txtuphone.Text.Trim().Length==0)
			{
				strErr+="uphone不能为空！\\n";	
			}
			if(this.txtuemail.Text.Trim().Length==0)
			{
				strErr+="uemail不能为空！\\n";	
			}
			if(this.txtwid.Text.Trim().Length==0)
			{
				strErr+="wid不能为空！\\n";	
			}
			if(this.txtwname.Text.Trim().Length==0)
			{
				strErr+="wname不能为空！\\n";	
			}
			if(this.txtparameter1.Text.Trim().Length==0)
			{
				strErr+="parameter1不能为空！\\n";	
			}
			if(this.txtparameter2.Text.Trim().Length==0)
			{
				strErr+="parameter2不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ID=int.Parse(this.lblID.Text);
			string uname=this.txtuname.Text;
			bool usex=this.chkusex.Checked;
			int uage=int.Parse(this.txtuage.Text);
			string uphone=this.txtuphone.Text;
			string uemail=this.txtuemail.Text;
			string wid=this.txtwid.Text;
			string wname=this.txtwname.Text;
			string parameter1=this.txtparameter1.Text;
			string parameter2=this.txtparameter2.Text;


			Maticsoft.Model.app.userinfo model=new Maticsoft.Model.app.userinfo();
			model.ID=ID;
			model.uname=uname;
			model.usex=usex;
			model.uage=uage;
			model.uphone=uphone;
			model.uemail=uemail;
			model.wid=wid;
			model.wname=wname;
			model.parameter1=parameter1;
			model.parameter2=parameter2;

			Maticsoft.BLL.app.userinfo bll=new Maticsoft.BLL.app.userinfo();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
