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
<div class="alert alert-success" role="alert"> Siasie d'un Produite</div>
<div class="panel-body">
<form action="SaveProduit.do" method="post">
<div class="form-group">
<label class="control-label"> Désignation</label>
<input type="text" required name="designation" value="${produit.designation}"  class="form-control"/>
 <span></span>
 </div>
 <div class="form-group">
<label class="control-label"> Prix</label>
<input type="text" name="prix" value="${produit.prix}" class="form-control"/>
 <span></span>
 </div>
 <div class="form-group">
<label class="control-label"> Quantité</label>
<input type="text" name="quantite" value="${produit.quantite}" class="form-control"/>
 <span></span>
 </div>
 <div>
 <button type="submit" class="btn btn-primary">Save</button>
 </div>


</form>
</div>

</div>


 </div>

</body>
</html>