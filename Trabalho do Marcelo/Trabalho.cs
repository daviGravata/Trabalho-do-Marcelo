using Npgsql; 

public class ProdutoService { private string connectionString = "Host=localhost;Username=Postgres;Password=root;Database=Trabalho"; 

public void CriarMouse() 
{ 
    CriarProduto("Mouse G Pro Superlith g 2 - Rosa", 399.90m, 10); 
} 
public void CriarTeclado() 
{ 
    CriarProduto("Teclado Apex pro Mini 9", 799.90m, 5); 
} 
public void CriarFone() 
{ 
    CriarProduto("Fone Hyper X", 499.90m, 8); 
} 
private void CriarProduto(string nome, decimal preco, int estoque) 
{ 
    using var conn = new NpgsqlConnection(connectionString); 
    conn.Open(); 
 
    var sql = "INSERT INTO produtos (nome, preco, estoque) VALUES (@nome, @preco, @estoque)"; 
    using var cmd = new NpgsqlCommand(sql, conn); 
    cmd.Parameters.AddWithValue("nome", nome); 
    cmd.Parameters.AddWithValue("preco", preco); 
    cmd.Parameters.AddWithValue("estoque", estoque); 
 
    cmd.ExecuteNonQuery(); 
 
    Console.WriteLine($"Produto '{nome}' criado com sucesso!"); 
} 
  

} 

 

  
