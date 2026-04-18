using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("BoardType enum includes Kanban, Scrum, Agile, and Custom values")]
    public void Rule86BoardTypeEnum()
    {
        var Content = ReadSource("PrTask.Domain", "Models", "BoardType.cs");
        Assert.IsTrue(Content.Contains("enum BoardType"), "BoardType.cs must define BoardType enum");
        Assert.IsTrue(Content.Contains("Kanban"), "BoardType must include Kanban");
        Assert.IsTrue(Content.Contains("Scrum"), "BoardType must include Scrum");
        Assert.IsTrue(Content.Contains("Agile"), "BoardType must include Agile");
        Assert.IsTrue(Content.Contains("Custom"), "BoardType must include Custom");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("Users and clients are the same with UserRole for display only")]
    public void Rule87UsersAndClientsAreSame()
    {
        var UserEntity = ReadSource("PrTask.Domain", "Models", "UserEntity.cs");
        Assert.IsTrue(UserEntity.Contains("UserRole"), "UserEntity must reference UserRole");
        var UserRole = ReadSource("PrTask.Domain", "Models", "UserRole.cs");
        Assert.IsTrue(UserRole.Contains("Developer"), "UserRole must have Developer value");
        Assert.IsTrue(UserRole.Contains("Client"), "UserRole must have Client value");
        var TaskDetail = ReadSource("PrTask.SharedUI", "Pages", "TaskDetailPage.razor");
        Assert.IsTrue(TaskDetail.Contains("ClaimCurrentTask") || TaskDetail.Contains("Claim"),
            "TaskDetailPage must let any user claim a task (no role restriction)");
        Assert.IsTrue(TaskDetail.Contains("TaskDetailConstants.SubmitPrButtonText") || TaskDetail.Contains("SubmitPr") || TaskDetail.Contains("submit-pr") || TaskDetail.Contains("TaskDetailSubmitPrButton"),
            "TaskDetailPage must let any user submit a PR (no role restriction)");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("LeaderboardEntry has dual ranking with EarningsRank, SpendingRank, TasksPosted, and TotalSpentCents")]
    public void Rule88DualLeaderboard()
    {
        var Content = ReadSource("PrTask.Domain", "Models", "LeaderboardEntry.cs");
        Assert.IsTrue(Content.Contains("EarningsRank"), "LeaderboardEntry must have EarningsRank");
        Assert.IsTrue(Content.Contains("SpendingRank"), "LeaderboardEntry must have SpendingRank");
        Assert.IsTrue(Content.Contains("TasksPosted"), "LeaderboardEntry must have TasksPosted");
        Assert.IsTrue(Content.Contains("TotalSpentCents"), "LeaderboardEntry must have TotalSpentCents");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("Maya is the only payment provider with no Stripe or PayPal constants")]
    public void Rule89MayaIsOnlyProvider()
    {
        var MayaConst = ReadSource("PrTask.Domain", "Constants", "MayaConstants.cs");
        Assert.IsTrue(MayaConst.Contains("class MayaConstants"), "MayaConstants must exist");
        Assert.IsTrue(MayaConst.Contains("paymaya.com"), "MayaConstants must reference paymaya.com");
        var ConstantsDir = Path.Combine(SourceRoot, "PrTask.Domain", "Constants");
        var AllConstantFiles = Directory.EnumerateFiles(ConstantsDir, "*.cs");
        foreach (var FilePath in AllConstantFiles)
        {
            var FileContent = File.ReadAllText(FilePath);
            Assert.IsFalse(FileContent.Contains("StripeConstants") || FileContent.Contains("stripe.com"),
                $"{Path.GetFileName(FilePath)} must not reference Stripe");
            Assert.IsFalse(FileContent.Contains("PayPalConstants") || FileContent.Contains("paypal.com"),
                $"{Path.GetFileName(FilePath)} must not reference PayPal");
        }
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("IPaymentService has all 25 Maya API methods for full coverage")]
    public void Rule90FullMayaApiCoverage()
    {
        var Content = ReadSource("PrTask.Application", "Services", "IPaymentService.cs");
        var RequiredMethods = new[]
        {
            "CreateCheckoutAsync",
            "GetCheckoutStatusAsync",
            "CreatePaymentTokenAsync",
            "ListPaymentsAsync",
            "GetPaymentStatusAsync",
            "GetPaymentByRrnAsync",
            "VoidPaymentAsync",
            "RefundPaymentAsync",
            "CreateCustomerAsync",
            "GetCustomerAsync",
            "UpdateCustomerAsync",
            "DeleteCustomerAsync",
            "VaultCardAsync",
            "GetVaultedCardsAsync",
            "GetVaultedCardAsync",
            "UpdateVaultedCardAsync",
            "DeleteVaultedCardAsync",
            "PayWithVaultedCardAsync",
            "RegisterWebhookAsync",
            "GetWebhooksAsync",
            "UpdateWebhookAsync",
            "DeleteWebhookAsync",
            "HandleWebhookAsync",
            "CalculateFeesAsync",
            "SetCustomizationAsync"
        };
        foreach (var Method in RequiredMethods)
        {
            Assert.IsTrue(Content.Contains(Method), $"IPaymentService must have {Method}");
        }
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("UserEntity has KYC properties: KycStatus, KycDocumentType, KycDocumentId, KycSubmittedAt, KycVerifiedAt")]
    public void Rule91KycSupport()
    {
        var Content = ReadSource("PrTask.Domain", "Models", "UserEntity.cs");
        Assert.IsTrue(Content.Contains("KycStatus"), "UserEntity must have KycStatus property");
        Assert.IsTrue(Content.Contains("KycDocumentType"), "UserEntity must have KycDocumentType property");
        Assert.IsTrue(Content.Contains("KycDocumentId"), "UserEntity must have KycDocumentId property");
        Assert.IsTrue(Content.Contains("KycSubmittedAt"), "UserEntity must have KycSubmittedAt property");
        Assert.IsTrue(Content.Contains("KycVerifiedAt"), "UserEntity must have KycVerifiedAt property");
        var KycEnum = ReadSource("PrTask.Domain", "Models", "KycStatus.cs");
        Assert.IsTrue(KycEnum.Contains("NotSubmitted"), "KycStatus must have NotSubmitted value");
        Assert.IsTrue(KycEnum.Contains("Pending"), "KycStatus must have Pending value");
        Assert.IsTrue(KycEnum.Contains("Verified"), "KycStatus must have Verified value");
        Assert.IsTrue(KycEnum.Contains("Rejected"), "KycStatus must have Rejected value");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("IPlainTextDbService has ReadAsync, WriteAsync, DeleteAsync, ListAsync, ExportCollectionAsync, ImportCollectionAsync")]
    public void Rule92PlainTextDatabase()
    {
        var Content = ReadSource("PrTask.Application", "Services", "IPlainTextDbService.cs");
        Assert.IsTrue(Content.Contains("ReadAsync"), "IPlainTextDbService must have ReadAsync");
        Assert.IsTrue(Content.Contains("WriteAsync"), "IPlainTextDbService must have WriteAsync");
        Assert.IsTrue(Content.Contains("DeleteAsync"), "IPlainTextDbService must have DeleteAsync");
        Assert.IsTrue(Content.Contains("ListAsync"), "IPlainTextDbService must have ListAsync");
        Assert.IsTrue(Content.Contains("ExportCollectionAsync"), "IPlainTextDbService must have ExportCollectionAsync");
        Assert.IsTrue(Content.Contains("ImportCollectionAsync"), "IPlainTextDbService must have ImportCollectionAsync");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("RouteConstants has /api/sprints and /api/boards endpoints")]
    public void Rule93SprintAndBoardApiEndpoints()
    {
        var Content = ReadSource("PrTask.Domain", "Constants", "RouteConstants.cs");
        Assert.IsTrue(Content.Contains("/Api/Sprints"), "RouteConstants must have /Api/Sprints endpoint");
        Assert.IsTrue(Content.Contains("/Api/Boards"), "RouteConstants must have /Api/Boards endpoint");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("RouteConstants has /api/plaintext-db endpoint")]
    public void Rule94PlainTextDbApiEndpoints()
    {
        var Content = ReadSource("PrTask.Domain", "Constants", "RouteConstants.cs");
        Assert.IsTrue(Content.Contains("/Api/PlainTextDb"), "RouteConstants must have /Api/PlainTextDb endpoint");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("PaymentService uses partial class pattern with PaymentService.cs and PaymentService.Vault.cs")]
    public void Rule95PaymentServicePartialClass()
    {
        var MainFile = Path.Combine(SourceRoot, "PrTask.Infrastructure", "Services", "PaymentService.cs");
        var VaultFile = Path.Combine(SourceRoot, "PrTask.Infrastructure", "Services", "PaymentService.Vault.cs");
        Assert.IsTrue(File.Exists(MainFile), "PaymentService.cs must exist");
        Assert.IsTrue(File.Exists(VaultFile), "PaymentService.Vault.cs must exist");
        var MainContent = File.ReadAllText(MainFile);
        var VaultContent = File.ReadAllText(VaultFile);
        Assert.IsTrue(MainContent.Contains("partial class PaymentService"),
            "PaymentService.cs must declare partial class PaymentService");
        Assert.IsTrue(VaultContent.Contains("partial class PaymentService"),
            "PaymentService.Vault.cs must declare partial class PaymentService");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("TaskDetailPage shows pull requests list and PullRequestEntity has TaskId for multiple PRs per task")]
    public void Rule96MultiplePrsPerTask()
    {
        var TaskDetail = ReadSource("PrTask.SharedUI", "Pages", "TaskDetailPage.razor");
        Assert.IsTrue(TaskDetail.Contains("Pull Requests") || TaskDetail.Contains("PullRequest"),
            "TaskDetailPage must reference pull requests");
        Assert.IsTrue(TaskDetail.Contains("TaskPullRequests") || TaskDetail.Contains("PullRequestEntity"),
            "TaskDetailPage must display a list of pull requests for the task");
        var PrEntity = ReadSource("PrTask.Domain", "Models", "PullRequestEntity.cs");
        Assert.IsTrue(PrEntity.Contains("TaskId"), "PullRequestEntity must have TaskId to link multiple PRs to a task");
    }
}
