using System.Text.Json;

public class PolicyRepository
{
    public List<Policy> Deserialize()
    {
        string fileName=@".\data\policy.json";
        string jsonString=File.ReadAllText(fileName);
        var options=new JsonSerializerOptions{PropertyNameCaseInsensitive=true};
        List<Policy> policies=JsonSerializer.Deserialize<List<Policy>>(jsonString,options);
        return policies;
    }

    public bool Serialize(List<Policy> policies)
    {
        bool status=false;
        string fileName=@".\data\policy.json";
        var options=new JsonSerializerOptions{PropertyNameCaseInsensitive=true};
        string jsonString=JsonSerializer.Serialize(policies,options);
        File.WriteAllText(fileName,jsonString);
        status=true;
        return status;
    }
}