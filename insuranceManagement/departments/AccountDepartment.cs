public class AccountDepartment
{
    public void OnPolicyPurchased(Policy policy)
    {
        PolicyRepository policyRepository=new PolicyRepository();
        List<Policy> policies=policyRepository.Deserialize();
        policies.Add(policy);
        policyRepository.Serialize(policies);
    }

    public void OnPolicyCancel(string policyno)
    {
        PolicyRepository policyRepository=new PolicyRepository();
        List<Policy> policies=policyRepository.Deserialize();
        foreach(Policy policy in policies)
        {
            if (policy.PolicyNumber == policyno)
            {
               policy.Status="Deactive"; 
            }
        }
        policyRepository.Serialize(policies);
    }

    public void OnPremiumPaid(Premium premium)
    {
        PremiumRepository premiumRepository=new PremiumRepository();
        List<Premium> premiums=premiumRepository.Deserialise();
        premiums.Add(premium);
        premiumRepository.Serialize(premiums);
    }

    public void OnPremiumRefunde(Premium premium)
    {
        
    }

    public void OnClaimApproved(Claim claim)
    {
        
    }

    public void OnClaimSettled(Claim claim)
    {
        
    }

    public void OnAgentCommissionCalculation(Agent agent)
    {
        
    }

    public void OnPaymentReceiptGenerated(Premium premium)
    {
        
    }

    public void OnLateFeeApplied(string policyNumber)
    {
        
    }

    public void OnDailyReportGenerated(DateTime reportDate)
    {
        
    }

    public void OnMonthlyReportGenerated(DateTime reportDate)
    {
        
    }
}