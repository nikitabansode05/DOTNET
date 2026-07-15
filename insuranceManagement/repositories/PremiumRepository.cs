using System.Text.Json;

public class PremiumRepository
{
    public List<Premium> Deserialise()
    {
        string filename=@".\data\premium.json";
        string jsonString=File.ReadAllText(filename);
        var options=new JsonSerializerOptions{PropertyNameCaseInsensitive=true};
        List<Premium> premiums=JsonSerializer.Deserialize<List<Premium>>(jsonString,options);
        return premiums;
    }

    public bool Serialize(List<Premium> premiums)
    {
        bool status=false;
        string filename=@".\data\premium.json";
        var options=new JsonSerializerOptions{PropertyNameCaseInsensitive=true};
        string jsonSring=JsonSerializer.Serialize(premiums,options);
        File.WriteAllText(filename,jsonSring);
        status=true;
        return status;
    }
}