package dao;

import java.util.List;

import metier.enteties.*;

public class TestDao {

	public static void main(String[] args) {
		
		ProduitDaoImpl dao=new ProduitDaoImpl();
		
		Produit p2=dao.save(new Produit("gfgf h", 45, 10));
System.out.println(p2.toString());
System.out.println("Cherche des produits");
List<Produit> prods=dao.produitsParMC("%H%");

}
}