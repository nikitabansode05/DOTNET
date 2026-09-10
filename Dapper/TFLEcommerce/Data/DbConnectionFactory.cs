namespace TFLEcommerce.Data;

using MySql.Data.MySqlClient;

public class DbConnectionFactory{

    private readonly string connectionString;

    public DbConnectionFactory(string connectionString){
        this.connectionString=connectionString;
    }

    public MySqlConnection CreateConnection(){
        return new MySqlConnection(connectionString);
    }
}