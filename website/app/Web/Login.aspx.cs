using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using NetDimension.Weibo;

namespace Maticsoft.Web
{
    public partial class Login : System.Web.UI.Page
    {

        public const string AppKey = "3954533200";
        public const string AppSecret = "f5e28ee4709f9423fc47a20d606169a9";
        public const string CallbackUrl = "http://localhost:50970/Default.aspx";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string cusCallbackUrl = CallbackUrl + "?point=1";

                OAuth oauth = new NetDimension.Weibo.OAuth(AppKey, AppSecret, cusCallbackUrl);

                if (Session["Token"] != null)
                {
                    string token = (string)Session["Token"];
                    OAuth newoauth = new OAuth(AppKey, AppSecret, token, "");

                    NetDimension.Weibo.Client Sina = new NetDimension.Weibo.Client(newoauth);



                    String uid = Sina.API.Account.GetUID();
                    NetDimension.Weibo.Entities.user.Entity userInfo = Sina.API.Users.Show(uid, null);


                    //NetDimension.Weibo.Entities.user.Collection userFriends = new NetDimension.Weibo.Entities.user.Collection();

                    Session["wid"] = uid;

                    Response.Redirect(CallbackUrl);

                }
                else
                {
                    String mycode = Request.QueryString["code"];

                    if (mycode == String.Empty || mycode == null)
                    {
                        String authUrl = oauth.GetAuthorizeURL(ResponseType.Code, null, DisplayType.Default);
                        Response.Redirect(authUrl);
                    }
                    else
                    {

                        AccessToken accessToken = oauth.GetAccessTokenByAuthorizationCode(mycode);

                        NetDimension.Weibo.Client Sina = new NetDimension.Weibo.Client(oauth);
                        String uid = Sina.API.Account.GetUID();
                        //Response.Write(uid);
                        Session["wid"] = Sina.API.Account.GetUID();


                        Response.Redirect(CallbackUrl);

                        Session["Token"] = accessToken.Token;

                    }
                }
            }

        }
    }
}