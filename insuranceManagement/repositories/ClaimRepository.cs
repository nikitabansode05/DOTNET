using System.Text.Json;
public class ClaimRepository
{
    public List<Claim> Deserialize()
    {
        string fileName=@".\data\claimrequests.json";
        string jsonString=File.ReadAllText(fileName);
        var options=new JsonSerializerOptions{PropertyNameCaseInsensitive=true};
        List<Claim> registerClaims=JsonSerializer.Deserialize<List<Claim>>(jsonString,options);
        return registerClaims;
    }

    public bool Serialize(List<Claim> claims)
    {
        bool status=false;
        string fileName=@".\data\claimrequests.json";
        var options=new JsonSerializerOptions{PropertyNameCaseInsensitive=true};
        string jsonString=JsonSerializer.Serialize(claims, options);
        File.WriteAllText(fileName, jsonString);
        status=true;
        return status;

    }
}