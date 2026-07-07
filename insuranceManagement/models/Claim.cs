public class Claim
{
    public int ClaimId{get;set;}
    public string PolicyNumber{get;set;}
    public int CustomerId{get;set;}
    public string CustomerName{get;set;}
    public DateTime ClaimDate{get;set;}
    public string ClaimType{get;set;}
    public string Reason{get;set;}
    public decimal ClaimAmount {get; set;}
    public decimal ApprovedAmount{get;set;}
    public string Status{get;set;}
    public string Remarks{get;set;}
    public DateTime SettlementDate{get;set;}

    public override string ToString()
    {
        return $"ClaimId: {ClaimId}, " +
               $"Policy: {PolicyNumber}, " +
               $"Customer: {CustomerName}, " +
               $"Amount: {ClaimAmount:C}, " +
               $"Status: {Status}";
    }
}