public class Program
{
    public static void Main()
    {
        int choice=0;
        do
        {
            Console.WriteLine("************************************************");
            Console.WriteLine("1)Purchase a new policy");
            Console.WriteLine("2)Renew policy");
            Console.WriteLine("3)Pay premium");
            Console.WriteLine("4)Register claim");
            Console.WriteLine("5)Approve claim");
            Console.WriteLine("6)Settle claim");
            Console.WriteLine("7)Reject claim");
            Console.WriteLine("8)Get all policies");
            Console.WriteLine("9)Register a customer");
            Console.WriteLine("10)Cancel policy");
            Console.WriteLine("11)Send renewal reminders");
            Console.WriteLine("12)Generate policy documenty");
            Console.WriteLine("13)Exit");
            choice=int.Parse(Console.ReadLine());
            Console.WriteLine("************************************************");

            switch (choice)
            {
                case 1:
                    {
                        SalesManager salesManager = new SalesManager();
                        SalesDepartment sales = new SalesDepartment();
                        AccountDepartment accounts = new AccountDepartment();

                        salesManager.policyPurchased += sales.OnPolicyPurchased;  //event subscription
                        salesManager.policyPurchased += accounts.OnPolicyPurchased;
                        
                        //salesManager.PurchasePolicy(policy);
                    }
                    break;
                case 2:
                    {
                        RenewalManager renewalManager = new RenewalManager();
                        RenewalDepartment renewals = new RenewalDepartment();
                        renewalManager.policyRenewed += renewals.OnRenewPolicy;

                        //renewalManager.RenewPolicy(policyno);
                    }
                    break;
                case 3:
                    {
                        PremiumManager premiumManager = new PremiumManager();
                        AccountDepartment accounts = new AccountDepartment();
                        SMSNotificationService sms=new SMSNotificationService();

                        premiumManager.premiumPaid += accounts.OnPremiumPaid;
                        premiumManager.premiumPaid += accounts.OnPaymentReceiptGenerated;
                        premiumManager.premiumPaid += sms.OnPaymentReceived;
                        
                       // premiumManager.PayPremium(premium);
                    }
                    break;
                case 4:
                    {
                        ClaimManager claimsManager = new ClaimManager();
                        ClaimDepartment claims = new ClaimDepartment();
                        SMSNotificationService sms = new SMSNotificationService();
                        EmailNotificationService emailService = new EmailNotificationService();
                        claimsManager.claimRegistered += claims.OnClaimRegistered;
                        claimsManager.claimRegistered += sms.OnClaimStatusUpdate;

                        //claimsManager.RegisterClaim(claim);
                    }
                    break;
                case 5:
                    {
                        ClaimManager claimsManager = new ClaimManager();
                        ClaimDepartment claims = new ClaimDepartment();
                        AccountDepartment accounts=new AccountDepartment();
                        SMSNotificationService sms = new SMSNotificationService();
                        EmailNotificationService emailService = new EmailNotificationService();

                        claimsManager.claimApproved += claims.OnClaimApproved;
                        claimsManager.claimApproved += accounts.OnClaimApproved;
                        claimsManager.claimRegistered += sms.OnClaimStatusUpdate;
                        claimsManager.claimRegistered += emailService.OnClaimStatusEmail;

                       // claimsManager.ApproveClaim(claim);
                    }
                    break;
                case 6:
                    {
                        ClaimManager claimManager = new ClaimManager();
                        ClaimDepartment claims = new ClaimDepartment();
                        AccountDepartment accounts = new AccountDepartment();
                        SMSNotificationService sms = new SMSNotificationService();
                        EmailNotificationService emailService = new EmailNotificationService();

                        claimManager.claimRegistered += sms.OnClaimStatusUpdate;
                        claimManager.claimRegistered += emailService.OnClaimStatusEmail;

                        //claimManager.SettleClaim(claim);
                    }
                    break;
                case 7:
                    {
                        ClaimManager claimManager = new ClaimManager();
                        SMSNotificationService sms = new SMSNotificationService();
                        ClaimDepartment claims = new ClaimDepartment();
                        EmailNotificationService emailService = new EmailNotificationService();

                        claimManager.claimRejected += claims.OnClaimRejected;
                        claimManager.claimRegistered += sms.OnClaimStatusUpdate;
                        claimManager.claimRegistered += emailService.OnClaimStatusEmail;

                      //  claimManager.RejectClaim(claim);
                    }
                    break;
                case 8:
                    {
                        PolicyRepository repo = new PolicyRepository();
                        repo.Deserialize();
                    }
                    break;
                case 9:
                    {
                        Customer customer=new Customer{
                        CustomerId = 1,
                        CustomerCode = "CUST001",
                        FirstName = "Nikita",
                        LastName = "Patil",
                        DateOfBirth = new DateTime(1995, 5, 20),
                        Gender = "Female",
                        Email = "nikita@example.com",
                        MobileNumber = "9876543210",
                        AlternateMobileNumber = "9123456789",
                        AddressLine1 = "123 MG Road",
                        AddressLine2 = "Near City Mall",
                        City = "Pune",
                        State = "Maharashtra",
                        PostalCode = "411001",
                        Country = "India",
                        PanNumber = "ABCDE1234F",
                        AadhaarNumber = "123456789012",
                        Occupation = "Software Engineer",
                        AnnualIncome = 1200000m,
                        NomineeName = "Rahul Patil",
                        NomineeRelationship = "Brother",
                        NomineeContactNumber = "9988776655",
                        RegistrationDate = DateTime.Now,
                        IsActive = true,
                        TotalPoliciesPurchased = 2};
                        
                        CustomerManager customerManager = new CustomerManager();
                        CustomerDepartment customerService = new CustomerDepartment();
                        EmailNotificationService emailService = new EmailNotificationService();

                        customerManager.customerRegistered += customerService.OnCustomerRegistered;
                        customerManager.customerRegistered += emailService.OnCustomerWelcomeEmail;

                        customerManager.RegisterCustomer(customer);
                    }
                    break;
                case 10:
                    {
                        SalesManager salesManager = new SalesManager();
                        AccountDepartment accountsDepartment=new AccountDepartment();
                        salesManager.policyCancelled+=accountsDepartment.OnPolicyCancel;
                        //salesManager.CancelPolicy(policyNumber);
                    }
                    break;
                case 11:
                    {
                        RenewalManager renewalManager = new RenewalManager();
                        SMSNotificationService sms = new SMSNotificationService();
                        EmailNotificationService emailService = new EmailNotificationService();

                        renewalManager.renewalReminderSent += emailService.OnRenewalReminderSent;
                        renewalManager.renewalReminderSent += sms.OnRenewalReminderSent;

                        //renewalManager.SendRenewalReminder(policyNumber);
                    }
                    break;
                case 12:
                    {
                        PolicyAdminManager policyAdminManager = new PolicyAdminManager();
                        SMSNotificationService sms = new SMSNotificationService();
                        EmailNotificationService emailService = new EmailNotificationService();

                        policyAdminManager.policyDocumentGenerated += emailService.OnPolicyDocumentSent;
                        policyAdminManager.policyDocumentGenerated +=sms.OnPolicyDocumentSent;

                        //policyAdminManager.SendPolicyDocument(policyNumber);
                    }
                    break;
                default:
                Console.WriteLine("Byeee");
                break;

            }
            
        }while(choice!=13);
}
}