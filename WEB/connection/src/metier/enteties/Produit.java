package metier.enteties;

import java.io.Serializable;

public class Produit implements Serializable {
private Long id;
private String designation;
private double prix;

private int quantite;
public Produit() {
	super();
	// TODO Auto-generated constructor stub
}

public Produit( String designation,double prix, int quantite) {
	super();
	this.prix = prix;
	this.designation = designation;
	this.quantite = quantite;
}
public Long getId() {
	return id;
}
public void setId(Long id) {
	this.id = id;
}
public double getPrix() {
	return prix;
}
public void setPrix(double prix) {
	this.prix = prix;
}
public String getDesignation() {
	return designation;
}
public void setDesignation(String designation) {
	this.designation = designation;
}
public int getQuantite() {
	return quantite;
}
public void setQuantite(int quantite) {
	this.quantite = quantite;
}
@Override
public String toString() {
	return "Produit [id=" + id + ", designation=" + designation + ", prix="
			+ prix + ", quantite=" + quantite + "]";
}

}
