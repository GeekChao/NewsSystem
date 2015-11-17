<%@ Page Language="C#" Inherits="NewsSystem.index" %>
<%@ import namespace="NewsSystem" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<script type="text/javascript" src="js/jquery-1.11.3.min.js"></script>
	<script type="text/javascript" src="js/bootstrap.min.js"></script>	
	<script type="text/javascript" src="js/my.js"></script>
	<link rel="stylesheet" type="text/css" href="css/bootstrap.min.css">
	<link rel="stylesheet" type="text/css" href="css/style.css">
	<title>News System</title>
</head>
<body>
	<form id="form1" runat="server">
		<div class="container">
		<div class="row">
	        <div class="col-md-8">
	          <img class="img-responsive" src="images/index_logo.png">
	        </div>
	        <div class="col-md-4"> 
	        	<p></p>
	        	<button type="button" class="btn btn-primary btn-xs" onclick="showModal()">
				  <span class="glyphicon glyphicon-user" aria-hidden="true"></span> Admin
				</button>
	          	<div class="input-group">
				  <input id="mSearchText" type="text" class="form-control" placeholder="Search for..." runat="server">
				  <span class="input-group-btn">
				    <button class="btn btn-default" type="button" onserverclick="searchBtnClick" runat="server">
				    	<span class="glyphicon glyphicon-search" aria-hidden="true"></span>
				    </button>
				  </span>
				</div>
	        </div>
	    </div>
	    <div class="row">
			<div class="col-md-12">
				<h1>News and Announcements</h1>
			</div>
		</div>

	    <div class="row">
          	<div class="col-md-4">
			    <div class="thumbnail">
			      <img class="img-responsive" src="<%# mHotActNews.NewsImgUrl%>" alt="Activity">
			    </div>
		    </div>
		    <div class="col-md-8">
				<h3> <a href='newsContent.aspx?newsId=<%# mHotActNews.NewsId%>' target="_blank" title='<%# mHotActNews.NewsTitle%>'><%# ProcessData.stringTruncat(mHotActNews.NewsTitle.ToString(), 80, "...") %></a></h3>
				<p>Activity <%# mHotActNews.NewsDate%><p>
		    	<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<%# ProcessData.getWords(ProcessData.stripHtml(mHotActNews.NewsText),800)%></p>
		    </div>
	    </div>
	    <div class="row">
          	<div class="col-md-4">
			    <div class="thumbnail">
			      <img class="img-responsive" src="<%# mHotAcaNews.NewsImgUrl%>" alt="Acadmic">
			    </div>
		    </div>
		    <div class="col-md-8">
				<h3> <a href='newsContent.aspx?newsid=<%# mHotAcaNews.NewsId%>' target="_blank" title='<%# mHotAcaNews.NewsTitle%>'><%# ProcessData.stringTruncat(mHotAcaNews.NewsTitle.ToString(), 80, "...") %></a></h3>
				<p>Academic <%# mHotAcaNews.NewsDate%><p>
		    	<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<%# ProcessData.getWords(ProcessData.stripHtml(mHotAcaNews.NewsText),800)%></p>
		    </div>
	    </div>
	    <div class="row">
          	<div class="col-md-4">
			    <div class="thumbnail">
			      <img class="img-responsive" src="<%# mHotElseNews.NewsImgUrl%>" alt="Else">
			    </div>
		    </div>
		    <div class="col-md-8">
				<h3> <a href='newsContent.aspx?newsid=<%# mHotElseNews.NewsId%>' target="_blank" title='<%# mHotElseNews.NewsTitle%>'><%# ProcessData.stringTruncat(mHotElseNews.NewsTitle.ToString(), 80, "...") %></a></h3>
				<p>Else <%# mHotActNews.NewsDate%><p>
		    	<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<%# ProcessData.getWords(ProcessData.stripHtml(mHotElseNews.NewsText),800)%></p>
		    </div>
	    </div>

		</div> 

	</form>

	<!--Modal-->
  		<div class="modal fade" id="myModal" role="dialog">
	    	<div class="modal-dialog">
		      <div class="modal-content">
		        <div class="modal-header" style="padding:35px 50px;">
		          <button type="button" class="close" data-dismiss="modal">&times;</button>
		          <h4><span class="glyphicon glyphicon-lock"></span> Login</h4>
		        </div>
		        <div class="modal-body" style="padding:40px 50px;">
		          <form role="form">
		            <div class="form-group">
		              <label for="usrname"><span class="glyphicon glyphicon-user"></span> Username</label>
		              <input type="text" class="form-control" id="usrname" placeholder="Enter username">
		            </div>
		            <div class="form-group">
		              <label for="psw"><span class="glyphicon glyphicon-eye-open"></span> Password</label>
		              <input type="password" class="form-control" id="psw" placeholder="Enter password">
		            </div>		    
		              <button type="button" class="btn btn-success btn-block" onclick="checkInfo()"><span class="glyphicon glyphicon-off"></span> Login</button>
		          </form>
			        </div>
		      	  </div>
			   </div>
		  	</div> 
</body>
</html>


