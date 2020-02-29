package registroCliente;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class ConnectionFactory {
	public Connection pegarConexao() {
		try {
			System.out.println("Iniciando...");
			return DriverManager.getConnection("jdbc:mysql://localhost:3306/banco", "root",                             "manabu210897");
		///usr/local/mysql/data/
                //jdbc:mysql://127.0.0.1:/?user=root
                } catch (SQLException e) {
			throw new RuntimeException(e);
		}
	}
}
