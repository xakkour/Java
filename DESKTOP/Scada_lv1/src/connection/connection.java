package connection;

import java.sql.Connection;
import java.sql.DriverManager;

public class connection {
	public static Connection getConnection()
	{
		Connection con=null;
		try {
			Class.forName("com.mysql.jdbc.Driver");
			con=DriverManager.getConnection("jdbc:mysql://localhsot/scada","root","");
		} 
		catch (Exception e) {
			
			System.out.println(e.getMessage());
		}
	return con;
	}
	

}
