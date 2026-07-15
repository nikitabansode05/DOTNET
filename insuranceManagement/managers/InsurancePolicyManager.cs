public class InsurancePolicyManager
{

    // Sales Events
public event AccountsAgent? policyPurchased;
public event SalesAgent? policyQuoted;
public event SalesAgent? policyUpdated;
public event SalesAgent? policyCancelled;
public event SalesAgent? leadGenerated;
public event SalesAgent? discountOffered;

// Customer Events
public event CustomerAgent? customerRegistered;
public event CustomerAgent? customerUpdated;
public event CustomerAgent? customerDeactivated;
public event CustomerAgent? kycVerified;

// Premium & Accounts Events
public event PremiumAgent? premiumPaid;
public event PremiumAgent? premiumRefunded;
public event PremiumAgent? premiumReminderGenerated;
public event PremiumAgent? lateFeeApplied;
public event AccountsAgent? paymentReceiptGenerated;

// Renewal Events
public event RenewalAgent? policyRenewed;
public event RenewalAgent? renewalReminderSent;
public event RenewalAgent? renewalExpired;

// Claim Events
public event ClaimsAgent? claimRegistered;
public event ClaimsAgent? claimVerified;
public event ClaimsAgent? claimApproved;
public event ClaimsAgent? claimRejected;
public event ClaimsAgent? claimSettled;
public event ClaimsAgent? fraudCheckRequested;

// Policy Administration Events
public event PolicyAgent? policyIssued;
public event PolicyAgent? policyAssigned;
public event PolicyAgent? policyDocumentGenerated;
public event PolicyAgent? nomineeUpdated;
public event PolicyAgent? beneficiaryChanged;

// Notification Events
public event NotificationAgent? emailSent;
public event NotificationAgent? smsSent;
public event NotificationAgent? policyDocumentSent;

// Audit & Compliance Events
public event AuditAgent? policyAudited;
public event AuditAgent? complianceChecked;
public event AuditAgent? regulatoryReportGenerated;

// Agent & Employee Events
public event AgentManagementAgent? agentAssigned;
public event AgentManagementAgent? agentCommissionCalculated;
public event AgentManagementAgent? agentCommissionPaid;

// Reporting Events
public event ReportAgent? dailyReportGenerated;
public event ReportAgent? monthlyReportGenerated;
public event ReportAgent? annualReportGenerated;

}