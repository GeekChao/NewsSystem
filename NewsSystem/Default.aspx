<%@ Page Language="C#" Inherits="NewsSystem.Default" %>

<!DOCTYPE html>
<html>
<head runat="server">
	<script type="text/javascript" src="Web/js/jquery-1.11.3.min.js"></script>
	<script type="text/javascript" src="Web/js/bootstrap.min.js"></script>	
	<script type="text/javascript" src="Web/js/my.js"></script>
	<link rel="stylesheet" type="text/css" href="Web/css/bootstrap.min.css">
	<link rel="stylesheet" type="text/css" href="Web/css/style.css">
	<title>News System</title>
</head>
<body>
	

	<form id="form1" runat="server">
	<div class="input-group">
	  <input id="searchText" type="text" class="form-control" placeholder="Search for..." runat="server">
	  <span class="input-group-btn">
	    <button class="btn btn-default" type="button" onserverclick="searchBtnClick" runat="server">
	    	<span class="glyphicon glyphicon-search" aria-hidden="true"></span>
	    </button>
	  </span>
	</div>
		<asp:Button id="button1" runat="server" Text="Click me!" OnClick="button1Clicked" />
	</form>
</body>
</html>

