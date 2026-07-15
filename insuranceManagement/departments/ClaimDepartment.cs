public class ClaimDepartment
{
    public void OnClaimRegistered(Claim claim){
        ClaimRepository claimRepository=new ClaimRepository();
        PolicyRepository policyRepository=new PolicyRepository();
        List<Policy> policies=policyRepository.Deserialize();
        foreach(Policy policy in policies){
            if(policy.PolicyNumber == claim.PolicyNumber){
                List<Claim> claims=claimRepository.Deserialize();
                claims.Add(claim);
                claimRepository.Serialize(claims);
                break;
            }
        }
    }

    public void OnClaimVerified(Claim claim){
         Console.WriteLine("====================================");
        Console.WriteLine($"Claim {claim.ClaimId} has been verified.");
        Console.WriteLine("Supporting documents validated.");
        Console.WriteLine("====================================");
    }

    public void OnClaimApproved(Claim claim){
        ClaimRepository claimRepository = new ClaimRepository();
        List<Claim> claims= claimRepository.Deserialize();
        foreach(Claim c in claims){
            if(c.ClaimId==claim.ClaimId){
                if(c.Status!="Approved"){
                    c.Status="Approved";
                    c.Remarks="Document verified successfully";
                    decimal approvedAmount=c.ClaimAmount*90/100;
                    c.ApprovedAmount=approvedAmount;
                    claimRepository.Serialize(claims);
                    break;
                }
            }
        }
    }

    public void OnClaimRejected(Claim claim){
        ClaimRepository claimRepository=new ClaimRepository();
        List<Claim> claims=claimRepository.Deserialize();
        foreach(Claim c in claims){
            if (c.ClaimId == claim.ClaimId)
            {
                c.Status="Rejected";
                c.Remarks = "Documents not verified";
                claimRepository.Serialize(claims);
            }
        }
    }

    public void OnClaimSetteled(Claim claim)
    {
        ClaimRepository claimsRepository = new ClaimRepository();
        List<Claim> claims = claimsRepository.Deserialize();

        foreach (Claim c in claims)
        {
            if (c.ClaimId == claim.ClaimId)
            {
                if (c.Status == "Approved")
                {
                    c.Status="Settled";
                    c.SettlementDate = DateTime.Now;
                    claimsRepository.Serialize(claims);
                    break;
                }
            }
        }
    }
}