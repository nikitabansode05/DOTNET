using System.Text.Json;

public class CustomerRepository
{
    public List<Customer> Deserialize()
    {
        string fileName=@".\data\customers.json";
        string jsonString=File.ReadAllText(fileName);
        var options=new JsonSerializerOptions{PropertyNameCaseInsensitive=true};
        List<Customer> customers=JsonSerializer.Deserialize<List<Customer>>(jsonString,options);
        return customers;
    }

    public bool Serialize(List<Customer> customers)
    {
        bool status= false;
        string fileName=@".\data\customers.json";
        var options=new JsonSerializerOptions{PropertyNameCaseInsensitive=true};
        string jsonString=JsonSerializer.Serialize(customers,options);
        File.WriteAllText(fileName, jsonString);
        status=true;
        return status;
    }
}