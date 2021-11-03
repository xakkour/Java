package com.heritage.tuto;

public class Rectangle extends GeometricObject {
	
	private double width;
	private double height;
	
	public Rectangle() {}
	
	public Rectangle(double width, double height) {
		this.width=width;
		this.height=height;
	}
	
	public Rectangle(double width, double height,String color, boolean filled) {
		super(color,filled);
		this.width=width;
		this.height=height;
//		setColor(color);
//		setFilled(filled);
	}
	
	public double getWidth() {
		return width;
	}
	
	public void setWidth(double width) {
		this.width=width;
	}
	
	public double getArea() {
		
		return this.width*this.height;
	}
	
	public double getPerimeter() {
		return 2*(this.width+this.height);
	}
}
