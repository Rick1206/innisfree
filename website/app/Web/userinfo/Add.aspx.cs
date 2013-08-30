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
namespace Maticsoft.Web.userinfo
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtuname.Text.Trim().Length==0)
			{
				strErr+="uname不能为空！\\n";	
			}
			if(this.txtusex.Text.Trim().Length==0)
			{
				strErr+="usex不能为空！\\n";	
			}
			if(this.txtuage.Text.Trim().Length==0)
			{
				strErr+="uage不能为空！\\n";	
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
			string uname=this.txtuname.Text;
			string usex=this.txtusex.Text;
			string uage=this.txtuage.Text;
			string uphone=this.txtuphone.Text;
			string uemail=this.txtuemail.Text;
			string wid=this.txtwid.Text;
			string wname=this.txtwname.Text;
			string parameter1=this.txtparameter1.Text;
			string parameter2=this.txtparameter2.Text;

			Maticsoft.Model.userinfo model=new Maticsoft.Model.userinfo();
			model.uname=uname;
			model.usex=usex;
			model.uage=uage;
			model.uphone=uphone;
			model.uemail=uemail;
			model.wid=wid;
			model.wname=wname;
			model.parameter1=parameter1;
			model.parameter2=parameter2;

			Maticsoft.BLL.userinfo bll=new Maticsoft.BLL.userinfo();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
