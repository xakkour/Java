<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">

<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">

<!-- Optional theme -->
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" integrity="sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp" crossorigin="anonymous">

<!-- Latest compiled and minified JavaScript -->
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>

</head>
<body>
<%@include file="Header.jsp" %>
<div class="container col-md-8 col-md-offset-2 col-xs-12">
<div class="pannel pannel-primary">
<div class="alert alert-success" role="alert"> Confirmation d'un Produite</div>
<div class="panel-body">
<div class="form-group">
<label> ID:</label>
<label>${produit.id}</label>
</div>
<div class="form-group">
<label> Désignation:</label>
<label>${produit.designation}</label>
</div>
<div class="form-group">
<label> Prix:</label>
<label>${produit.prix}</label>
</div>
<div class="form-group">
<label> Quantite:</label>
<label>${produit.quantite}</label>
</div>



</div>

</div>


 </div>

</body>
</html>