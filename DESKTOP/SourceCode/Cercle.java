package com.heritage.tuto;

public class Cercle extends GeometricObject{

	private double radius;
	
	public Cercle() {}
	public Cercle(double radius) {
		this.radius=radius;
	}
	
	public Cercle(String color, boolean filled, double radius) {
		super(color,filled);
		this.radius = radius;
//		setColor(color);
//		setFilled(filled);
	}
	
	
	public double getRadius() {
		return this.radius;
	}
	
	public void setRadius(double radius) {
		this.radius = radius;
	}
	
	public double getArea() {
		return this.radius * this.radius * Math.PI;
	}
	
	public double getPerimetre() {
		return 2*this.radius*Math.PI;
	}
	
	public double getDiameter() {
		
		return 2*this.radius;
	}
	
	
	public String toString() {
		return super.toString()+ "\nradius is " + radius;
	}
	
	@Override
	public void display() {
		System.out.println("dfsf");
	}
	public static float sum(float k) {
		
		return k;
	}
	
	
	
//	public void printCircle() {
//		System.out.println("The circle is created "+getDateCreated()+
//				"the radius is "+this.radius);
//	}
	
	
	
}
