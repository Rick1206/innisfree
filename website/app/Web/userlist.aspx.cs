using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web
{
    public partial class userlist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AccessDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

     
            GridView1.AllowPaging = false;

            //GridView1.DataSource = AccessDataSource1;
           
            GridView1.DataBind();

            DateTime dt = DateTime.Now;
            
            string filename = dt.Year.ToString() + dt.Month.ToString() + dt.Day.ToString() + dt.Hour.ToString() + dt.Minute.ToString() + dt.Second.ToString();

            
            Response.Clear();

            Response.AddHeader("Content-Disposition", "attachment;filename=" + System.Web.HttpUtility.UrlEncode("用户列表" + filename, System.Text.Encoding.UTF8) + ".xls");//导出文件命名
           
            Response.ContentEncoding = System.Text.Encoding.UTF8;//如果设置为"GB2312"则中文字符可能会乱码

            Response.ContentType = "application/ms-excel";
            
            System.IO.StringWriter oStringWriter = new System.IO.StringWriter();
            
            System.Web.UI.HtmlTextWriter oHtmlTextWriter = new System.Web.UI.HtmlTextWriter(oStringWriter);
            
            Panel1.RenderControl(oHtmlTextWriter);
            
            Response.Write(oStringWriter.ToString());
            
            Response.Flush();
            
            Response.End();


        }

        public override void VerifyRenderingInServerForm(Control control)
        {
            //override VerifyRenderingInServerForm.
        }

    }
}