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
<div class="container col-md-10 col-md-offset-1">
<div class="pannel pannel-primary">
<div class="panel-body">
<form action="chercher.do" method="get">
<label> Mot Clé</label>
<input type="text" name="motCle">
<button type="submit" class="btn btn-primary">Chercher</button>
</form>
<table class="table">
 
    <tr>
      <th scope="col">ID</th>
      <th scope="col">Designation</th>
      <th scope="col">Prix</th>
      <th scope="col">Quantite</th>
    </tr>
 <c:forEach items="${model.produits}" var="p">
  <tr>
     
      <td>${p.id}</td>
      <td>${p.designation}</td>
      <td>${p.prix}</td>
      <td>${p.quantite}</td>
      <td> <a href="Edit.do?id=${p.id }" >Update</a></td>
      <td><a onclick="return confirm('Are you sure?')" href="Supprime.do?id=${p.id }" > Supprime</a></td>
      
    </tr>
 </c:forEach>
  
</table>

</div>

</div>


 </div>

</body>
</html>