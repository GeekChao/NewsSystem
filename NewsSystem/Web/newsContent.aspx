<%@ Page Language="C#" Inherits="NewsSystem.NewsContent" %>
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
	<div class="container">
		<div class="row">
	        <div class="col-md-12">
	          <img class="img-responsive" src="images/suny_logo.png">
	        </div>
	    </div>
	    <div class="row">
			<div class="col-md-12">
				<h1>News and Announcements</h1>
			</div>
		</div>
		<div class="row">
			<div class="col-md-12">
				<h3><%# mNews.NewsTitle%></h3>
			</div>
		</div>
	    <div class="row">
			<div class="col-md-12">
		    	<p><%# mNews.NewsDate%></p>
		    </div>
		</div>
		<div class="row">
		   <div class="col-md-12">
		   		<img class="img-responsive img-max" src="<%# mNews.NewsImgUrl%>">
		   </div>
		</div>
		<div class="row">
		   <div class="col-md-12">
		   		<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<%# mNews.NewsText%></p>
		   </div>
	    </div>
	    <div class="row">
	    	<div class="col-md-12">
		    	 <button type="button" class="btn btn-default" aria-label="Left Align">
					  <span class="glyphicon glyphicon-thumbs-up" aria-hidden="true"></span>
					</button>
					<button type="button" class="btn btn-default" aria-label="Left Align">
					  <span class="glyphicon glyphicon-thumbs-down" aria-hidden="true"></span>
				</button>
			</div>
	    </div>
	</div>

	<form id="form1" runat="server">
	</form>
</body>
</html>
