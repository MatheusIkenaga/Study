package registroCliente;

import java.sql.Connection;
import java.sql.Date;
import java.sql.PreparedStatement;
import java.sql.SQLException;
import java.util.Calendar;

public class ClienteDAO {

	private Connection conexao;

	public ClienteDAO() {

		this.conexao = new ConnectionFactory().pegarConexao();
	}

	public void insert(Cliente cliente) {
		String sql = "insert into clientes (nome, cpf, endereco, telefone, dataNascimento, dataRegistro) values (?,?,?,?,?,?)";

		try {
			PreparedStatement stmt = conexao.prepareStatement(sql);

			stmt.setString(1, cliente.getNome());
			stmt.setString(2, cliente.getCpf());
			stmt.setString(3, cliente.getEndereco());
			stmt.setString(4, cliente.getTelefone());
			stmt.setDate(5, (Date) cliente.getDataNasc());
			stmt.setDate(6,	new	java.sql.Date(Calendar.getInstance().getTimeInMillis()));

			stmt.execute();
			stmt.close();
		} catch (SQLException e) {
			throw new RuntimeException(e);
		}
	}

}
