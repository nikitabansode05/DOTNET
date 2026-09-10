namespace TFLEcommerce.Repositories;

using Dapper;
using System.Data;
using TFLEcommerce.Data;

public class CartRepository{
    private readonly DbConnectionFactory connectionFactory;

    public CartRepository(DbConnectionFactory connectionFactory){
        this.connectionFactory=connectionFactory;
    }

    public async Task<int> AddToCart(int in_user_id,int in_product_id,int in_quantity,string in_item_image){
        using var connection = connectionFactory.CreateConnection();
        var parameters=new DynamicParameters();
        parameters.Add("in_user_id",in_user_id);
        parameters.Add("in_product_id",in_product_id);
        parameters.Add("in_quantity",in_quantity);
        parameters.Add("in_item_image",in_item_image);

        var rowsAffected=await connection.ExecuteAsync("add_to_cart",parameters,commandType:CommandType.StoredProcedure);
        return rowsAffected;
    }

    public async Task<int> RemoveFromCart(int in_product_id,int in_user_id ){
        using var connection=connectionFactory.CreateConnection();
        var parameters=new DynamicParameters();
        parameters.Add("in_product_id",in_product_id);
        parameters.Add("in_user_id",in_user_id);

        var rowsAffected=await connection.ExecuteAsync("remove_from_cart",parameters,commandType:CommandType.StoredProcedure);
        return rowsAffected;
    }
}