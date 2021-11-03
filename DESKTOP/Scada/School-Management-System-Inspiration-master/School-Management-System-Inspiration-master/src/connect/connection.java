/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package connect;
import java.sql.*; 
import javax.swing.JOptionPane;

public class connection {
    
         
      Connection conn=null;
    public static Connection connecrDB(){  
    try{  
    Class.forName("com.mysql.cj.jdbc.Driver");  
    Connection conn=DriverManager.getConnection( "jdbc:mysql://localhost:3306/scada","root","");
    Statement stmt=conn.createStatement();
    JOptionPane.showMessageDialog(null, "Connection Established");
    return conn;
      
   
      
    }catch(Exception e){ JOptionPane.showMessageDialog(null, e);
    return null;}  
    }  
    } 

