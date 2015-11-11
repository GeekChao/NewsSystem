<%@ Page Language="C#" Inherits="NewsSystem.index" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<script type="text/javascript" src="js/jquery-1.11.3.min.js"></script>
	<script type="text/javascript" src="js/bootstrap.min.js"></script>
	<link rel="stylesheet" type="text/css" href="css/bootstrap.min.css">
	<link rel="stylesheet" type="text/css" href="css/style.css">
	<title>News System</title>
</head>
<body>
	<div class="container">
		<div class="row">
	        <div class="col-md-8">
	          <img class="img-responsive" src="Web/images/index_logo.png">
	        </div>
	        <div class="col-md-4"> 
	          	<div class="input-group">
				  <input type="text" class="form-control" placeholder="Search for...">
				  <span class="input-group-btn">
				    <button class="btn btn-default" type="button">Go!</button>
				  </span>
				</div>
	        </div>
	    </div>
	</div>

	<form id="form1" runat="server">
	
	</form>
</body>
</html>


