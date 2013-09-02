<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Maticsoft.Web.Default" %>
<!DOCTYPE HTML>
<html xmlns:wb=“http://open.weibo.com/wb” lang="en-US">
<head runat="server">
    <title>首页</title>
    <meta charset="UTF-8" />
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
		var scroller  = null;
		var scrollbar = null;
		var scroller1  = null;
		var scrollbar1 = null;
		var scroller2  = null;
		var scrollbar2 = null;
		var scroller3  = null;
		var scrollbar3 = null;
		window.onload = function () {
		  scroller  = new Scrolling.Scroller(document.getElementById("Scroller-1"), 400, 200);
		  scrollbar = new Scrolling.Scrollbar(document.getElementById("Scrollbar-Container"), scroller, new Scrolling.ScrollTween());
		  scroller1  = new Scrolling.Scroller(document.getElementById("Scroller-2"), 400, 200);
		  scrollbar1 = new Scrolling.Scrollbar(document.getElementById("Scrollbar-Container1"), scroller1, new Scrolling.ScrollTween());
		  scroller2 = new Scrolling.Scroller(document.getElementById("Scroller-3"), 400, 200);
		  scrollbar2 = new Scrolling.Scrollbar(document.getElementById("Scrollbar-Container2"), scroller2, new Scrolling.ScrollTween());
		  scroller3 = new Scrolling.Scroller(document.getElementById("Scroller-4"), 400, 300);
		  scrollbar3 = new Scrolling.Scrollbar(document.getElementById("Scrollbar-Container3"), scroller3, new Scrolling.ScrollTween());
		}	
	</script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="panel">
		<div class="bg1">
			<a href="http://www.innisfree.cn/Product.do?method=productView&seq=1000002880" class="btn1" target="_blank"><img src="img/buyrn.png" alt="立即购买" /></a>
		</div>
		<div class="bg2">
			<asp:LinkButton ID="LinkButton1" runat="server" class="btn2" 
                onclick="LinkButton1_Click"><img src="img/share.png" alt="" /></asp:LinkButton>
			<div class="video">
				<object classid="clsid:d27cdb6e-ae6d-11cf-96b8-444553540000" width="100%" height="100%" id="FlvPlay1" align="middle">
				<param name="movie" value="swf/innisfree.swf" />
				<param name="quality" value="high" />
				<param name="bgcolor" value="#000000" />
				<param name="wmode" value="window" />
				<param name="scale" value="showall" />
				<param name="menu" value="true" />
				<param name="FlashVars" value="videoPath=/video/innisfree.flv" />
				<param name="devicefont" value="false" />
				<param name="salign" value="" />
				<param name="allowScriptAccess" value="sameDomain" />
				<!--[if !IE]>-->
				<object type="application/x-shockwave-flash" data="swf/innisfree.swf" width="100%" height="100%">
					<param name="movie" value="swf/innisfree.swf" />
					<param name="quality" value="high" />
					<param name="bgcolor" value="#000000" />
					<param name="FlashVars" value="videoPath=/video/innisfree.flv" />
					<param name="wmode" value="window" />
					<param name="scale" value="showall" />
					<param name="menu" value="true" />
					<param name="devicefont" value="false" />
					<param name="salign" value="" />
					<param name="allowScriptAccess" value="sameDomain" />
				<!--<![endif]-->
					<a href="http://www.adobe.com/go/getflash">
						<img src="http://www.adobe.com/images/shared/download_buttons/get_flash_player.gif" alt="获得 Adobe Flash Player" />
					</a>
				<!--[if !IE]>-->
				</object>
				<!--<![endif]-->
			</object>
			</div>
		</div>
		<div class="bg3">
			<a href="http://www.innisfree.cn/Product.do?method=productView&seq=1000002880" class="btn3" target="_blank"><img src="img/buyrn.png" alt="立即购买" /></a>
		</div>
		<div class="bg4">
            <asp:LinkButton ID="LinkButton3" runat="server" class="btn4" onclick="LinkButton2_Click"><img src="img/supplyrn.png" alt="" /></asp:LinkButton>
			<a href="http://www.innisfree.cn" class="btn5"  target="_blank"><img src="img/go.png" alt="官网" /></a>
			<asp:TextBox ID="uname" runat="server" type="text" class="input1 name" ></asp:TextBox>
			<asp:TextBox ID="usex" runat="server" type="text" class="input1 sex" ></asp:TextBox>
			<asp:TextBox ID="uage" runat="server" type="text" class="input1 age" ></asp:TextBox>
			<asp:TextBox ID="umobile" runat="server" type="text" class="input1 mobile" ></asp:TextBox>
			<asp:TextBox ID="uemail" runat="server" type="text" class="input1 mail" ></asp:TextBox>
		</div>
		<div class="bg5">
			<a target="_blank" href="http://weibo.com/1660235667/A6Rperjao" class="teacherlink t3"></a>
			<div class="kol1">
				<div id="Scrollbar-Container"> 
					<div class="Scrollbar-Track">
						<img src="img/scrollbar.png" class="Scrollbar-Handle" />
					</div>
				</div>
				<div class="Container">
					<div id="Scroller-1">
						<div class="Scroller-Container">
							<img src="img/kol_text1.png" alt="" />
						</div>
					</div>
				</div>
			</div>
			<div class="kol2">
				<div id="Scrollbar-Container1"> 
					<div class="Scrollbar-Track">
						<img src="img/scrollbar.png" class="Scrollbar-Handle" />
					</div>
				</div>
				<div class="Container">
					<div id="Scroller-2">
						<div class="Scroller-Container">
							<img src="img/kol_text2.png" alt="" />
						</div>
					</div>
				</div>
			</div>
			<div class="kol3">
				<div id="Scrollbar-Container2"> 
					<div class="Scrollbar-Track">
						<img src="img/scrollbar.png" class="Scrollbar-Handle" />
					</div>
				</div>
				<div class="Container">
					<div id="Scroller-3">
						<div class="Scroller-Container">
							<a target="_blank" href="http://weibo.com/1660235667/A6Rperjao"><img src="img/kol_text3.png" alt="" /></a>
						</div>
					</div>
				</div>
			</div>
		</div>
		<div class="bg6">
		
		<div class="darenicon">
				<img src="img/darenicon.png" alt="美容达人" />
			</div>
			<div class="daren">
				<div id="Scrollbar-Container3"> 
					<div class="Scrollbar-Track" style="height:248px">
						<img src="img/scrollbar.png" class="Scrollbar-Handle" />
					</div>
				</div>
				<div class="Container">
					<div id="Scroller-4">
						<div class="Scroller-Container">
							<img src="img/daren.png" alt="" />
						</div>
					</div>
				</div>
			</div>
		</div>

        <wb:livestream skin="silver" topic="%E4%BA%BA%E4%BA%BA%E9%83%BD%E7%88%B1%E5%B0%91%E5%A5%B3%E8%82%8C%E8%82%A4|%E4%BA%BA%E4%BA%BA%E9%83%BD%E7%88%B1%E5%B0%91%E5%A5%B3%E8%82%8C%E8%82%A4" width="auto" height="500" ></wb:livestream>

    </form>
    <script type="text/javascript">
        $(function () {
//            var so = new SWFObject("swf/CuPlayerMiniV20_Gray_S.swf", "video_area", "404", "304", "9", "#ffffff");
//            so.addParam("allowfullscreen", "true");
//            so.addParam("allowscriptaccess", "always");
//            so.addParam("wmode", "opaque");
//            so.addParam("quality", "high");
//            so.addParam("salign", "lt");
//            so.addVariable("CuPlayerImage", "");
//            so.addVariable("CuPlayerShowImage", "false");
//            so.addVariable("CuPlayerWidth", "404");
//            so.addVariable("CuPlayerHeight", "304");
//            so.addVariable("CuPlayerAutoPlay", "true");
//            so.addVariable("CuPlayerAutoRepeat", "true");
//            so.addVariable("CuPlayerShowControl", "true");
//            so.addVariable("CuPlayerAutoHideControl", "false");
//            so.addVariable("CuPlayerAutoHideTime", "6");
//            so.addVariable("CuPlayerVolume", "50");
//            so.addVariable("CuPlayerGetNext", "true");
//            so.addVariable("CuPlayerFile", "/video/video1.flv");
//            so.write("videocontent");

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
