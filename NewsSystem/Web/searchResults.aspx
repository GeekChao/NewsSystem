<%@ Page Language="C#" Inherits="NewsSystem.searchResults" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<script type="text/javascript" src="js/jquery-1.11.3.min.js"></script>
	<script type="text/javascript" src="js/bootstrap.min.js"></script>
	<link rel="stylesheet" type="text/css" href="css/bootstrap.min.css">
	<link rel="stylesheet" type="text/css" href="css/style.css">
	<title>Search</title>
</head>
<body>
	<div class="container">
		<div class="row">
	        <div class="col-md-12">
	          <img class="img-responsive" src="images/suny_logo.png">
	        </div>
	    </div>
	    <div class="row">
			<div class="col-md-12">
				<h1>Search Results for <%= searchText%></h1>
			</div>
		</div>
		<asp:Repeater ID="repSearchResult" runat="server">       
	    	<ItemTemplate>
			    <div class="row">
				    <div class="col-md-12">
				    	<h3> <a href='newsContent.aspx?newsId=<%#Eval("news_id")%>' target="_blank" title='<%#Eval("news_title")%>'><%# StringTruncat(Eval("news_title").ToString(), 40, "...") %></a></h3>
				    	<p><%#Eval("news_date")%></p>
				    	<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<%# GetWords(striphtml(Eval("news_text").ToString()),600)%></p>
				    </div>
			    </div>
			 </ItemTemplate>
		</asp:Repeater>
	</div>

	<form id="form1" runat="server">
	
	</form>
</body>
</html>
