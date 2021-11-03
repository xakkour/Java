package com.heritage.tuto;

import java.util.Date;

public class GeometricObject  {
	
	private String color="white";
	private boolean filled=false;
	private Date dateCreated;
	
	public GeometricObject() {
		dateCreated = new Date();
	}
	
	public GeometricObject(String color, boolean filled) {
		this.color=color;
		this.filled=filled;
		dateCreated = new Date();
	}
	
	public String getColor() {
		return this.color;
	}
	
	public void setColor(String color) {
		this.color=color;
	}
	
	public boolean isFilled() {
		return filled;
	}
	
	public void setFilled(boolean filled) {
		this.filled=filled;
	}
	
	public Date getDateCreated() {
		return this.dateCreated;
	}
	
	public static int sum(int a,int b) {
		return a+b;
	}
	
	protected void display() {
		System.out.println("dfsf");
	}
	
	@Override
	public String toString() {
		return "constructed on "+this.dateCreated+" \ncolor: "+color+
				" and filled: "+filled;
	}
	
	
	

}
