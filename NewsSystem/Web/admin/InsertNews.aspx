<%@ Page Language="C#" Inherits="NewsSystem.InsertNews" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<script type="text/javascript" src="../js/tinymce/tinymce.min.js"></script>
    <script type="text/javascript">
        tinymce.init({
            selector: "#mytextarea",
            plugins: ["image autosave"],
        });
    </script>
	<title>InsertNews</title>
</head>
<body>
	<form id="form1" method="post" runat="server">
		<textarea id="mytextarea">Easy! You should check out MoxieManager!</textarea>
	</form>
</body>
</html>

