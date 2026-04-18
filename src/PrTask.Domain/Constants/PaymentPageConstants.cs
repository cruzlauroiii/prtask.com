namespace PrTask.Domain.Constants;
public static class PaymentPageConstants
{
    public const string SeoTitle = "Payments - PrTask";
    public const string SeoDescription = "View your payment history and transaction details.";
    public const string PageHeading = "Payment History";
    public const string PageDescription = "View all your payments and their status.";
    public const string UserIdLabel = "Your User ID";
    public const string UserIdPlaceholder = "Enter your user ID";
    public const string LoadButtonText = "Load Payments";
    public const string EmptyStateText = "No payments found.";
    public const string HeaderDate = "Date";
    public const string HeaderTask = "Task";
    public const string HeaderAmount = "Amount";
    public const string HeaderStatus = "Status";
    public const string HeaderType = "Type";
    public const string TaskNotApplicable = "N/A";
    public const string DateFormat = "MMM dd, yyyy";
    public const string DescriptionHeading = "About Payment History";
    public const string DescriptionParagraph1 = "The Payment History page provides a comprehensive view of all financial transactions associated with your PrTask account. Whether you are a developer receiving bounty payouts or a client funding task bounties, this page gives you full transparency into every payment made through the platform. Each transaction record includes the date, associated task, amount, current status, and payment type so you can track your finances with confidence.";
    public const string DescriptionParagraph2 = "PrTask processes payments automatically when a pull request is approved and merged by the task owner. Developers receive 100% of the bounty amount with no platform fees deducted from their earnings. Payment statuses update in real time, allowing you to see whether a transaction is pending, completed, or requires attention. You can filter your payment history by entering your user ID to view transactions specific to your account.";
    public const string DescriptionParagraph3 = "For clients, this page also serves as a record of all bounty disbursements made to developers who completed your tasks. You can cross-reference payments with specific tasks to verify that funds were distributed correctly. If you have questions about a specific transaction or need to dispute a payment, PrTask provides a dedicated support channel accessible from your account settings. All payment data is encrypted and stored securely in compliance with PCI DSS standards.";
}
