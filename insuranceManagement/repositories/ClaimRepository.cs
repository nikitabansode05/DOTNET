using System.Text.Json;
public class ClaimRepository
{
    public List<Claim> GetAllRegisterClaim()
    {
        string fileName=@".\data\claimrequests.json";
        string jsonString=File.ReadAllText(fileName);
        var options=new JsonSerializerOptions{PropertyNameCaseInsensitive=true};
        List<Claim> registerClaims=JsonSerializer.Deserialize<List<Claim>>(jsonString,options);
        return registerClaims;
    }

    public bool SaveRegisterClaim(List<Claim> claims)
    {
        bool status=false;
        string fileName=@".\data\claimrequests.json";
        var options=new JsonSerializerOptions{PropertyNameCaseInsensitive=true};
        string jsonString=JsonSerializer.Serialize(claims, options);
        return status;

    }
}