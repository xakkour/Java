package org.scada;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import java.awt.Color;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.SwingConstants;
import java.awt.Font;
import javax.swing.ImageIcon;
import javax.swing.JTextField;
import javax.swing.JPasswordField;
import javax.swing.JCheckBox;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.sql.*;
import java.awt.event.ActionEvent;

public class login extends JFrame {

	private JPanel contentPane;
	private JTextField loginField;
	private JPasswordField passwordField;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					login frame = new login();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the frame.
	 */
	public login() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 1250, 618);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JPanel panel = new JPanel();
		panel.setBackground(new Color(224, 255, 255));
		panel.setBounds(0, 0, 460, 579);
		contentPane.add(panel);
		panel.setLayout(null);
		
		JLabel lblLogin = new JLabel("Login");
		lblLogin.setFont(lblLogin.getFont().deriveFont(lblLogin.getFont().getStyle() | Font.BOLD, lblLogin.getFont().getSize() + 2f));
		lblLogin.setForeground(new Color(128, 128, 128));
		lblLogin.setHorizontalAlignment(SwingConstants.LEFT);
		lblLogin.setBounds(36, 286, 81, 27);
		panel.add(lblLogin);
		
		loginField = new JTextField();
		loginField.setBounds(36, 313, 236, 32);
		panel.add(loginField);
		loginField.setColumns(10);
		
		JLabel label = new JLabel("Password");
		label.setHorizontalAlignment(SwingConstants.LEFT);
		label.setForeground(Color.GRAY);
		label.setFont(label.getFont().deriveFont(label.getFont().getStyle() | Font.BOLD, label.getFont().getSize() + 2f));
		label.setBounds(36, 375, 81, 27);
		panel.add(label);
		
		passwordField = new JPasswordField();
		passwordField.setBounds(36, 400, 236, 32);
		panel.add(passwordField);
		
		JCheckBox chckbxRemembreMe = new JCheckBox("Remembre me");
		chckbxRemembreMe.setBackground(new Color(224, 255, 255));
		chckbxRemembreMe.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		chckbxRemembreMe.setForeground(new Color(128, 128, 128));
		chckbxRemembreMe.setBounds(36, 452, 142, 23);
		panel.add(chckbxRemembreMe);
		
		JButton btnLogin = new JButton("Login");
		btnLogin.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				
				   String login = loginField.getText();
	                String password = passwordField.getText();
	                try {
	                    Connection connection = (Connection) DriverManager.getConnection("jdbc:mysql://localhost:3306/scada",
	                        "root", "");

	                    PreparedStatement st = (PreparedStatement) connection
	                        .prepareStatement("Select login, password from login where login=? and password=?");

	                    st.setString(1, login);
	                    st.setString(2, password);
	                    ResultSet rs = st.executeQuery();
	                    if (rs.next()) {
	                        dispose();
	                       
	    					
	                        JOptionPane.showMessageDialog(btnLogin, "You have successfully logged in");
	                    } else {
	                        JOptionPane.showMessageDialog(btnLogin, "Wrong Username & Password");
	                    }
	                } catch (SQLException sqlException) {
	                    sqlException.printStackTrace();
	                }
	            }
	        
				
			
		});
		btnLogin.setFont(new Font("Times New Roman", Font.BOLD, 20));
		btnLogin.setForeground(new Color(128, 128, 128));
		btnLogin.setBounds(36, 514, 236, 32);
		panel.add(btnLogin);
		
		JPanel panel_2 = new JPanel();
		panel_2.setBackground(new Color(255, 255, 255));
		panel_2.setBounds(24, 50, 348, 146);
		panel.add(panel_2);
		panel_2.setLayout(null);
		
		JLabel lblWelecomeToDerssa = new JLabel(" DERSSA Dashboard");
		lblWelecomeToDerssa.setBounds(10, 23, 300, 96);
		panel_2.add(lblWelecomeToDerssa);
		lblWelecomeToDerssa.setBackground(new Color(0, 0, 255));
		lblWelecomeToDerssa.setIcon(new ImageIcon("C:\\Users\\oussama\\Documents\\Eclipse-Workplace\\Scada_lv1\\Image\\icons8_combo_chart_96px_1.png"));
		lblWelecomeToDerssa.setFont(new Font("Times New Roman", Font.BOLD, 22));
		lblWelecomeToDerssa.setForeground(new Color(30, 144, 255));
		lblWelecomeToDerssa.setHorizontalAlignment(SwingConstants.CENTER);
		
		JLabel lblNewLabel_1 = new JLabel("Sign In ");
		lblNewLabel_1.setBounds(36, 238, 184, 37);
		panel.add(lblNewLabel_1);
		lblNewLabel_1.setForeground(new Color(30, 144, 255));
		lblNewLabel_1.setFont(new Font("Times New Roman", Font.BOLD, 18));
		lblNewLabel_1.setHorizontalAlignment(SwingConstants.LEFT);
		
		JPanel panel_1 = new JPanel();
		panel_1.setBackground(new Color(255, 250, 250));
		panel_1.setBounds(462, 0, 772, 579);
		contentPane.add(panel_1);
		panel_1.setLayout(null);
		
		JLabel lblNewLabel = new JLabel("New label");
		lblNewLabel.setBounds(0, -68, 772, 547);
		panel_1.add(lblNewLabel);
		lblNewLabel.setIcon(new ImageIcon("C:\\Users\\oussama\\Documents\\Eclipse-Workplace\\Scada_lv1\\Image\\Visuel_Veolia5.jpg"));
	}
}
