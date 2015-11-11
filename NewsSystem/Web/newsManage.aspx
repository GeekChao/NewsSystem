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
		    	<div class="dropdown">
				  <button class="btn btn-primary btn-lg dropdown-toggle" type="button" id="dropdownMenu1" data-toggle="dropdown" aria-haspopup="true" aria-expanded="true">
				    Category
				    <span class="caret"></span>
				  </button>
				  <ul class="dropdown-menu" aria-labelledby="dropdownMenu1">
				    <li><a href="#">Activity</a></li>
				    <li><a href="#">Academic</a></li>
				    <li><a href="#">Else</a></li>
				  </ul>
				</div>
		    </div>
		    <div class="col-md-4">
		    	<button type="button" class="btn btn-info btn-lg">
				  <span class="glyphicon glyphicon-plus-sign" aria-hidden="true"></span> Add News
				</button>
		    </div>
	    </div>
	    <div class="row">
	    	<div class="col-md-8">
	    		<p>Title</p>
	    		<p>Date</p>
	    	</div>
	    	<div class="col-md-4">
		    	<button type="button" class="btn btn-warning btn-sm">
				  <span class="glyphicon glyphicon-edit" aria-hidden="true"></span> Modify
				</button>
				<button type="button" class="btn btn-danger btn-sm">
				  <span class="glyphicon glyphicon-remove-sign" aria-hidden="true"></span> Remove
				</button>
		    </div>
	    </div>
	</div>

	<form id="form1" runat="server">
	
	</form>
</body>
</html>


