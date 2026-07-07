public class Agent
{
    public int AgentId{get;set;}
    public string AgentCode{get;set;}
    public string FullName{get;set;}
    public string Email{get;set;}
    public string MobileNo{get;set;}
    public string LicenseNumber{get;set;}
    public string Branch{get;set;}
    public string Designation{get;set;}
    public decimal CommissionRate{get;set;}
    public decimal TotalCommissionEarned{get;set;}
    public DateTime DateofJoining{get;set;}
    public bool IsActive{get;set;}
    public override string ToString()
    {
        return $"{AgentCode} - {FullName} ({Designation})";
    }

}