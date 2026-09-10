using System.Data;
using Dapper;
using TFLEcommerce.Data;

namespace TFLEcommerce.Repositories;

public class CartRepository
{
    private readonly DbConnectionFactory connectionFactory;

    public CartRepository(DbConnectionFactory connectionFactory)
    {
        this.connectionFactory=connectionFactory;
    }

    public async Task<int> RemoveFromCart(int productId,int customerId)
    {
        using var connection = connectionFactory.CreateConnection();
        var parameters= new DynamicParameters();

        parameters.Add("in_product_id",productId);
        parameters.Add("in_user_id",customerId);

        var rowsAffected=await connection.ExecuteAsync("remove_from_cart",parameters,commandType:CommandType.StoredProcedure);
        return rowsAffected;
    }
}