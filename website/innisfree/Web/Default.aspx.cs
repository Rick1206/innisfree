using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using NetDimension.Weibo;
using NetDimension.Web;

namespace Maticsoft.Web
{
    public partial class Default : System.Web.UI.Page
    {
        Client Sina = null;
        string UserID = string.Empty;
        Cookie cookie = new Cookie("WeiboDemo", 24, TimeUnit.Hour);

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(cookie["AccessToken"]))
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                Sina = new Client(new OAuth(ConfigurationManager.AppSettings["AppKey"], ConfigurationManager.AppSettings["AppSecret"], cookie["AccessToken"], null)); //用cookie里的accesstoken来实例化OAuth，这样OAuth就有操作权限了

                UserID = Sina.API.Account.GetUID();
                

            }

        }

        private string UserUpload(string username, string email, string phone, string address, string opt1, string opt2)
        {
            //string cusCallbackUrl = CallbackUrl + "?point=1";
            //OAuth oauth = new NetDimension.Weibo.OAuth(AppKey, AppSecret, cusCallbackUrl);

            return "123";

        }
    }
}
