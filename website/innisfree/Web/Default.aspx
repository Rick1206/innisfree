<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Maticsoft.Web.Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <meta charset="UTF-8">
    <link rel="stylesheet" href="css/innisfree.css" />
	<link rel="stylesheet" href="css/reset.css" />
	<link rel="stylesheet" href="css/jscrollpane.css" />
	<script type="text/javascript" src="js/jquery-1.7.1.min.js"></script>
	<script type="text/javascript" src="js/Scrolling.Scroller.js"></script>
	<script type="text/javascript" src="js/Scrolling.Scrollbar.js"></script>
	<script type="text/javascript" src="js/Scrolling.ScrollTween.js"></script>
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
				
			</div>
		</div>
		<div class="bg3">
			<a href="" class="btn3"><img src="img/buyrn.png" alt="" /></a>
		</div>
		<div class="bg4">
			<a href="" class="btn4"><img src="img/supplyrn.png" alt="" /></a>
			<a href="" class="btn5"><img src="img/go.png" alt="" /></a>
			<input type="text" class="input1 name" />
			<input type="text" class="input1 sex" />
			<input type="text" class="input1 age" />
			<input type="text" class="input1 mobile" />
			<input type="text" class="input1 mail" />
		</div>
		<div class="bg5">
			
		</div>
		<div class="bg6"></div>
	</div>
    </form>
</body>
</html>
