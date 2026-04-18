namespace PrTask.Domain.Constants;
public static class DemoSeedConstants
{
    public const string TaskId = "demo-task";
    public const string PrId = "demo-pr";
    public const string ClientId = "demo-client";
    public const string DeveloperId = "demo-developer";
    public const string TaskTitle = "Refactor payment module";
    public const string TaskDescription = "Refactor the payment service to use the new Maya API v2 endpoints.";
    public const string RepoUrl = "https://github.com/prtask/demo-repo";
    public const string GitHubPrUrl = "https://github.com/prtask/demo-repo/pull/1";
    public const string ExampleFilePath = "src/Example.cs";
    public const string Comment1Body = "Consider using async/await pattern here for better performance.";
    public const string Comment2Body = "Add null check before calling GetValueAsync().";
    public const long BountyAmountCents = 50000;
    public const int DeadlineDays = 30;
    public const int FilesChanged = 3;
    public const int Additions = 42;
    public const int Deletions = 15;
    public const int ComplexityScore = 7;
    public const int Comment1Line = 2;
    public const int Comment2Line = 3;
    public const string TagCsharp = "csharp";
    public const string TagPayments = "payments";
    public const string TagRefactor = "refactor";

    public const string BoardId = "demo-board";
    public const string BoardName = "Payment Module Board";

    public const string SprintId = "demo-sprint";
    public const string SprintName = "Sprint 1 - Payment Refactor";
    public const string SprintGoal = "Complete Maya API v2 migration and payment flow testing";
    public const int SprintDurationDays = 14;

    public const string PaymentId = "demo-payment";

    public const string RefundId = "demo-refund";
    public const string RefundReason = "Customer requested refund due to duplicate charge";
    public const long RefundAmountCents = 25000;
    public const string RefundCurrency = "PHP";

    public const string VoidId = "demo-void";
    public const string VoidReason = "Transaction voided before settlement";
    public const long VoidAmountCents = 15000;

    public const string BillPaymentId = "demo-bill-payment";
    public const string BillerSlug = "meralco";
    public const string BillerAccountNumber = "1234567890";
    public const long BillAmountCents = 350000;

    public const string ClientDisplayName = "Demo Client";
    public const string ClientEmail = "client@prtask.com";
    public const string DeveloperDisplayName = "Demo Developer";
    public const string DeveloperEmail = "developer@prtask.com";
    public const long ClientSpentCents = 150000;
    public const long DeveloperEarnedCents = 125000;

    public const long PaymentAmountCents = 50000;

    public const string ColumnTodoId = "demo-col-todo";
    public const string ColumnTodoName = "To Do";
    public const string ColumnInProgressId = "demo-col-inprogress";
    public const string ColumnInProgressName = "In Progress";
    public const string ColumnDoneId = "demo-col-done";
    public const string ColumnDoneName = "Done";
    public const int ColumnWipLimit = 5;

    public const string AchievementId = "demo-achievement";

    public const string SubscriptionId = "demo-subscription";
    public const string SubscriptionCardTokenId = "demo-card-token";
    public const string SubscriptionDescription = "Monthly PRTask Pro plan";
    public const long SubscriptionAmountCents = 99900;
    public const string SubscriptionCurrency = "PHP";

    public const string InvoiceId = "demo-invoice";
    public const long InvoiceAmountCents = 50000;
    public const string InvoiceCurrency = "PHP";
    public const string InvoiceDescription = "Invoice for payment module refactor";

    public const string DisbursementId = "demo-disbursement";
    public const int DisbursementBeneficiaryCount = 1;
    public const long DisbursementTotalAmountCents = 125000;

    public const string P3RecurringPaymentId = "demo-p3-recurring";
    public const string P3OriginalTransactionRefNo = "demo-p3-txn-001";
    public const string P3FrequencyIndicator = "MONTHLY";
    public const long P3RecurringAmountCents = 99900;
    public const string P3RecurringCurrency = "PHP";

    public const string RepositoryId = "demo-repository";
    public const string RepositoryUrl = "https://github.com/prtask/demo-repo";
    public const string RepositoryName = "demo-repo";
}
