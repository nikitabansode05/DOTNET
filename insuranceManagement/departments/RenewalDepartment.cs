public class RenewalDepartment
{
    public void OnRenewPolicy(string policyNumber)
    {
        PolicyRepository policyRepository = new PolicyRepository();
        List<Policy> policies = policyRepository.Deserialize();
        foreach (Policy policy in policies)
        {
            if(policy.PolicyNumber == policyNumber)
            {
                if(policy.IsRenewed==false)
                {
                    policy.IsRenewed = true;
                    policyRepository.Serialize(policies);
                }
            }
        }
    }
}