<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Maticsoft.Web.Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns:wb=“http://open.weibo.com/wb”>
<head runat="server">
    <title>首页</title>
    <meta charset="UTF-8">
    <link rel="stylesheet" href="css/innisfree.css" />
	<link rel="stylesheet" href="css/reset.css" />
	<link rel="stylesheet" href="css/jscrollpane.css" />
	<script type="text/javascript" src="js/jquery-1.7.1.min.js"></script>
	<script type="text/javascript" src="js/Scrolling.Scroller.js"></script>
	<script type="text/javascript" src="js/Scrolling.Scrollbar.js"></script>
	<script type="text/javascript" src="js/Scrolling.ScrollTween.js"></script>
    <script type="text/javascript" src="js/swfobject_flv.js"></script>
    <script src="http://tjs.sjs.sinajs.cn/open/api/js/wb.js" type="text/javascript" charset="utf-8"></script>
    <script type="text/javascript">
        var scroller = null;
        var scrollbar = null;
        var scroller1 = null;
        var scrollbar1 = null;
        var scroller2 = null;
        var scrollbar2 = null;
        var scroller3 = null;
        var scrollbar3 = null;
        window.onload = function () {
            scroller = new Scrolling.Scroller(document.getElementById("Scroller-1"), 400, 200);
            scrollbar = new Scrolling.Scrollbar(document.getElementById("Scrollbar-Container"), scroller, new Scrolling.ScrollTween());
            scroller1 = new Scrolling.Scroller(document.getElementById("Scroller-2"), 400, 200);
            scrollbar1 = new Scrolling.Scrollbar(document.getElementById("Scrollbar-Container1"), scroller, new Scrolling.ScrollTween());
            scroller2 = new Scrolling.Scroller(document.getElementById("Scroller-1"), 400, 200);
            scrollbar2 = new Scrolling.Scrollbar(document.getElementById("Scrollbar-Container"), scroller, new Scrolling.ScrollTween());
            scroller3 = new Scrolling.Scroller(document.getElementById("Scroller-2"), 400, 200);
            scrollbar3 = new Scrolling.Scrollbar(document.getElementById("Scrollbar-Container1"), scroller, new Scrolling.ScrollTween());
        }	
	</script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="panel">
		<div class="bg1">
			<a href="" class="btn1"><img src="img/buyrn.png" alt="" /></a>
		</div>
		<div class="bg2">
			<asp:LinkButton ID="LinkButton1" runat="server" class="btn2" 
                onclick="LinkButton1_Click"><img src="img/share.png" alt="" /></asp:LinkButton>
			<div class="video">
                    <div id="videocontent"></div>
			</div>
		</div>
		<div class="bg3">
       <a href="" class="btn3"><img src="img/buyrn.png" alt="" /></a>
		</div>
		<div class="bg4">
            <asp:LinkButton ID="LinkButton3" runat="server" class="btn4" onclick="LinkButton2_Click"><img src="img/supplyrn.png" alt="" /></asp:LinkButton>
			<a href="" class="btn5"><img src="img/go.png" alt="" /></a>
			<asp:TextBox ID="uname" runat="server" type="text" class="input1 name" /></asp:TextBox>
			<asp:TextBox ID="usex" runat="server" type="text" class="input1 sex" /></asp:TextBox>
			<asp:TextBox ID="uage" runat="server" type="text" class="input1 age" /></asp:TextBox>
			<asp:TextBox ID="umobile" runat="server" type="text" class="input1 mobile" /></asp:TextBox>
			<asp:TextBox ID="uemail" runat="server" type="text" class="input1 mail" /></asp:TextBox>
		</div>
		<div class="bg5">
			
		</div>
		<div class="bg6">
        <div class="weibowall">
        <wb:livestream skin="silver" topic="%E4%BA%BA%E4%BA%BA%E9%83%BD%E7%88%B1%E5%B0%91%E5%A5%B3%E8%82%8C%E8%82%A4|%E4%BA%BA%E4%BA%BA%E9%83%BD%E7%88%B1%E5%B0%91%E5%A5%B3%E8%82%8C%E8%82%A4" width="auto" height="250" ></wb:livestream>
        </div>
        </div>
	</div>
    </form>
    <script type="text/javascript">
        $(function () {
            var so = new SWFObject("swf/CuPlayerMiniV20_Gray_S.swf", "video_area", "404", "304", "9", "#ffffff");
            so.addParam("allowfullscreen", "true");
            so.addParam("allowscriptaccess", "always");
            so.addParam("wmode", "opaque");
            so.addParam("quality", "high");
            so.addParam("salign", "lt");
            so.addVariable("CuPlayerImage", "");
            so.addVariable("CuPlayerShowImage", "false");
            so.addVariable("CuPlayerWidth", "404");
            so.addVariable("CuPlayerHeight", "304");
            so.addVariable("CuPlayerAutoPlay", "true");
            so.addVariable("CuPlayerAutoRepeat", "true");
            so.addVariable("CuPlayerShowControl", "true");
            so.addVariable("CuPlayerAutoHideControl", "false");
            so.addVariable("CuPlayerAutoHideTime", "6");
            so.addVariable("CuPlayerVolume", "50");
            so.addVariable("CuPlayerGetNext", "true");
            so.addVariable("CuPlayerFile", "/video/video1.flv");
            so.write("videocontent");

            $(".btn4").click(function () {

                if (!checkMobile($(".mobile").val())) {
                    return false;
                } 
            });



        });

        function checkMobile(str) {
            if (!(/^1[3|4|5|8][0-9]\d{4,8}$/.test(str))) {
                alert("不是完整的11位手机号或者正确的手机号前七位");
                $(".mobile").focus();
                return false;
            } else {
                 return true;
            }
        } 
     </script>

</body>
</html>
