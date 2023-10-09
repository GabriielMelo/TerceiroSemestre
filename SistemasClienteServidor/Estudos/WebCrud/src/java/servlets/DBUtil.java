package servlets;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
        
public class DBUtil {
    
    // Informações sobre o banco de dados.
    private static final String dbURL = "jdbc:mysql://localhost:3306/dbcadastro";
    private static final String dbUser = "root";
    private static final String dbPassword = "root";
    
    
    // Metodo para conexão com banco de dados mySQL
    public static Connection getConnection(){
        Connection conn = null;
        try{
            Class.forName("com.mysql.jdbc.Driver");
            conn = DriverManager.getConnection(dbURL,dbUser,dbPassword);
            
        }catch(ClassNotFoundException | SQLException e){
            e.printStackTrace();
        }
        return conn;
    }
   
}
