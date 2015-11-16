function showModal(){
	$("#myModal").modal();
}

function checkInfo(){
	if(document.getElementById("usrname").value === "admin" && 
	document.getElementById("psw").value === "123456"){
		window.location.replace("admin/newsManage.aspx");
	}else{
		alert("Wrong information, please input again");
	}
}