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
using NetDimension.Weibo;
using NetDimension.Web;
using System.IO;
using System.Drawing;


namespace Maticsoft.Web
{
    public partial class Default : System.Web.UI.Page
    {

        Client Sina = null;
        string UserID = string.Empty;
        string UserName = string.Empty;
        Cookie cookie = new Cookie("WeiboDemo", 24, TimeUnit.Hour);


        public const string AppKey = "3954533200";
        public const string AppSecret = "f5e28ee4709f9423fc47a20d606169a9";
        public const string CallbackUrl = "http://foundation.showone.com.cn/Default.aspx";



        protected void Page_Load(object sender, EventArgs e)
        {
                //string cusCallbackUrl = CallbackUrl + "?point=1";
            //Response.Write(Server.MapPath("") + "\\images\\bg1.jpg");
            OAuth oauth = new NetDimension.Weibo.OAuth(AppKey, AppSecret, CallbackUrl);

                if (Session["Token"] != null)
                {
                    string token = (string)Session["Token"];
                    OAuth newoauth = new OAuth(AppKey, AppSecret, token, "");

                    Sina = new Client(newoauth);
                    UserID = Sina.API.Account.GetUID();
                    NetDimension.Weibo.Entities.user.Entity userInfo = Sina.API.Users.Show(UserID, null);
                    UserName = userInfo.ScreenName;

                    Session["wid"] = UserID;
                }
                else
                {
                    String mycode = Request.QueryString["code"];

                    if (mycode == String.Empty || mycode == null)
                    {

                    }
                    else
                    {

                        AccessToken accessToken = oauth.GetAccessTokenByAuthorizationCode(mycode);

                        Sina = new NetDimension.Weibo.Client(oauth);
                        String UserID = Sina.API.Account.GetUID();
                        Session["wid"] = UserID;

                        Session["Token"] = accessToken.Token;

                    }
                }

        }

         protected void LinkButton2_Click(object sender, EventArgs e)
        {

            Model.userinfo user = new Model.userinfo();

            user.uname = Request.Params["uname"];
            user.usex = Request.Params["usex"];
            user.uage = Request.Params["uage"];


            user.uphone = Request.Params["umobile"];
            user.uemail = Request.Params["uemail"];
            user.wid = UserID;
            user.wname = UserName;
            user.parameter1 = DateTime.Now.ToString();
            user.parameter2 = HttpContext.Current.Request.UserHostAddress;

            BLL.userinfo actUser = new BLL.userinfo();
            if (actUser.Add(user))
            {
                Show(this, "提交成功！");
            }
            else
            {
                Show(this, "提交失败！");
            }

        }

        public static void Show(System.Web.UI.Page page, string msg)
         {
             page.ClientScript.RegisterStartupScript(page.GetType(), "message", "<script language='javascript' defer>alert('" +  msg.ToString() + "');</script>");
        }
 
         protected void LinkButton1_Click(object sender, EventArgs e)
         {

            //Response.Write( GetBytesByImagePath("/img/bg1.jpg"));

             if (Session["Token"] == null)
             {

                 //string cusCallbackUrl = CallbackUrl + "?point=1";

                 OAuth myoauth = new NetDimension.Weibo.OAuth(AppKey, AppSecret, CallbackUrl);

                 String authUrl = myoauth.GetAuthorizeURL(ResponseType.Code, null, DisplayType.Default);
                 
                 Response.Redirect(authUrl);

             }
             else
             {

                 Sina = new Client(new OAuth(AppKey, AppSecret, Session["Token"].ToString(), null)); 
                 //用cookie里的accesstoken来实例化OAuth，这样OAuth就有操作权限了

                 UserID = Sina.API.Account.GetUID();
                 string weiboContent = "想让韩国国宝级彩妆大师朴泰轮教你如何打造少女肌肤吗？现在观看#人人都爱少女肌肤#教学视频就能从#innisfree#这里学到少女肌肤的底妆秘籍，还有机会赢取#悦诗风吟矿物质纯安动人粉底膏#哦！立刻猛击";

                 string jpgPath = Server.MapPath("") + "\\img\\bg1.jpg";

                 Sina.API.Statuses.Upload(weiboContent, GetBytesByImagePath(jpgPath));

                 //Sina.API.Statuses.Update(weiboContent);

             }

         }

         public static byte[] GetBytesByImagePath(string strFile)
         {
             byte[] photo_byte = null;
             using (FileStream fs = new FileStream(strFile, FileMode.Open, FileAccess.Read))
             {
                 using (BinaryReader br = new BinaryReader(fs))
                 {
                     photo_byte = br.ReadBytes((int)fs.Length);
                 }
             }

             return photo_byte;
         }  

    }
}
