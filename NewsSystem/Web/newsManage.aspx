<%@ Page Language="C#" Inherits="NewsSystem.newsManage" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<script type="text/javascript" src="js/jquery-1.11.3.min.js"></script>
	<script type="text/javascript" src="js/bootstrap.min.js"></script>
	<link rel="stylesheet" type="text/css" href="css/bootstrap.min.css">
	<link rel="stylesheet" type="text/css" href="css/style.css">
	<title>News Content</title>
</head>
<body>
	<form id="form1" runat="server">
		<div class="container">
		<div class="row">
	        <div class="col-md-12">
	          <img class="img-responsive" src="images/suny_logo.png">
	        </div>
	    </div>
	    <div class="row">
			<div class="col-md-12">
				<h1>News Mangement</h1>
			</div>
		</div>
	    <div class="row">
		    <div class="col-md-8">
		    	<!--<div class="dropdown">
				  <button class="btn btn-primary btn-lg dropdown-toggle" type="button" id="dropdownMenu1" data-toggle="dropdown" aria-haspopup="true" aria-expanded="true">
				    Category
				    <span class="caret"></span>
				  </button>
				  <ul class="dropdown-menu" aria-labelledby="dropdownMenu1">
				    <li><a href="#">Activity</a></li>
				    <li><a href="#">Academic</a></li>
				    <li><a href="#">Else</a></li>
				  </ul>
				</div>-->
		    </div>
		    <div class="col-md-4">
		    	<button type="button" class="btn btn-info btn-lg" runat="server" onserverclick="addNewsBtnClick">
				  <span class="glyphicon glyphicon-plus-sign" aria-hidden="true"></span> Add News
				</button>
		    </div>
	    </div>
	    <div class="row">
		    <asp:Repeater ID="repNewsManage" runat="server">       
		    	<ItemTemplate>
				    <div class="col-md-8">
					    <h3><%# StringTruncat(Eval("news_title").ToString(), 55, "...") %></h3>
					    <p><%#Eval("news_date")%></p>
			    	</div>
			    	<div class="col-md-4">
			    		<br>
			    		<a href='./admin/updateNews.aspx?newsId=<%#Eval("news_id")%>'>
			    		<span class="glyphicon glyphicon-edit" aria-hidden="true"></span> Modify</a>
			    		&nbsp;&nbsp;&nbsp;
						<asp:LinkButton id="delteBtn" class="button" runat="server" OnClick="deleteNewsBtnClick" CommandArgument='<%#Eval("news_id")%>'>
						<span class="glyphicon glyphicon-remove-sign" aria-hidden="true"></span> Delete</asp:LinkButton>
				    </div>
				</ItemTemplate>
			</asp:Repeater>    	
	    </div>
	</div>

	</form>
</body>
</html>


