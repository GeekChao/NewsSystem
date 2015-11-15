<%@ Page Language="C#" Inherits="NewsSystem.updateNews" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<script type="text/javascript" src="js/jquery-1.11.3.min.js"></script>
	<script type="text/javascript" src="js/bootstrap.min.js"></script>
	<link rel="stylesheet" type="text/css" href="css/bootstrap.min.css">
	<script type="text/javascript" src="js/tinymce/tinymce.min.js"></script>
    <script type="text/javascript">
        tinymce.init({
            selector: "#mTextArea",
            plugins: ["image autosave"],
            toolbar: "insertfile undo redo | sizeselect | bold italic | fontselect |  fontsizeselect | link image",
            fontsize_formats: "8pt 10pt 12pt 14pt 18pt 24pt 36pt",
            height: "270",
        });
    </script>
	<title>UpdateNews</title>
</head>
<body>
	<form id="form1" method="post" runat="server">
		<div class="container">
			<div class="row">
		        <div class="col-md-12">
		          <img class="img-responsive" src="images/suny_logo.png">
		        </div>
		    </div>
		    <div class="row">
				<div class="col-md-12">
					<h1>Update News</h1>
				</div>
			</div>
			<div class="row">
				<div class="col-md-2">
   					 <h4><span class="label label-info">&nbsp;Title&nbsp;</span></h4>
				</div>
				<div class="col-md-8">
				    <input type="text" class="form-control" id="title" name="title">
		    	</div>
		    	<br><br><br>
			</div>
			<div class="row">
				<div class="col-md-2">
   					 <h4><span class="label label-info">&nbsp;Category &nbsp;</span></h4>
				</div>
				<div class="col-md-10">
		    		<label class="radio-inline"><input type="radio" name="optradio">Activity</label>
					<label class="radio-inline"><input type="radio" name="optradio">Academic</label>
					<label class="radio-inline"><input type="radio" name="optradio">Else</label>
		    	</div>
		    	<br><br><br>
			</div>
		    <div class="row">
			    <div class="col-md-10">
					<textarea id="mTextArea">Easy! You should check out MoxieManager!</textarea>
			    </div>
		    </div>
		    <div class="row">
				<div class="col-md-12">
  					<input type="submit" class="btn btn-warning" value="Submit">
			    </div>		   
			</div>
		</div>
	</form>
</body>
</html>


