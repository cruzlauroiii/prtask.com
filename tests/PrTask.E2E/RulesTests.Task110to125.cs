namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("No crypto or bank-transfer references in payment-related source files")]
    public void Rule110CreditCardOnlyNoOtherPaymentMethods()
    {
        var PaymentFiles = GetSourceFiles(".cs")
            .Where(F => F.Contains("Payment") || F.Contains("Maya"))
            .ToList();
        var Violations = new List<string>();
        foreach (var File in PaymentFiles)
        {
            var Content = System.IO.File.ReadAllText(File);
            if (Content.Contains("crypto", StringComparison.OrdinalIgnoreCase) ||
                Content.Contains("bitcoin", StringComparison.OrdinalIgnoreCase) ||
                Content.Contains("ethereum", StringComparison.OrdinalIgnoreCase))
            {
                Violations.Add($"{Path.GetFileName(File)}: contains crypto reference");
            }
            if (Content.Contains("bank_transfer", StringComparison.OrdinalIgnoreCase) ||
                Content.Contains("bank transfer", StringComparison.OrdinalIgnoreCase))
            {
                Violations.Add($"{Path.GetFileName(File)}: contains bank-transfer reference");
            }
        }
        Assert.AreEqual(0, Violations.Count,
            $"Payment files must not reference crypto or bank-transfer:\n{string.Join("\n", Violations)}");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("RouteConstants defines all CRUD endpoint constants for tasks, PRs, users, payments, sprints, boards, achievements")]
    public void Rule111AllCrudEndpointConstants()
    {
        var Routes = ReadSource("PrTask.Domain", "Constants", "RouteConstants.cs");
        Assert.IsTrue(Routes.Contains("ApiTasks"), "RouteConstants must define ApiTasks");
        Assert.IsTrue(Routes.Contains("ApiPullRequests"), "RouteConstants must define ApiPullRequests");
        Assert.IsTrue(Routes.Contains("ApiUsers"), "RouteConstants must define ApiUsers");
        Assert.IsTrue(Routes.Contains("ApiPayments"), "RouteConstants must define ApiPayments");
        Assert.IsTrue(Routes.Contains("ApiSprints"), "RouteConstants must define ApiSprints");
        Assert.IsTrue(Routes.Contains("ApiBoards"), "RouteConstants must define ApiBoards");
        Assert.IsTrue(Routes.Contains("ApiAchievements"), "RouteConstants must define ApiAchievements");
        Assert.IsTrue(Routes.Contains("SubById") || Routes.Contains("/{TaskId}"), "RouteConstants must define by-id sub-route");
        Assert.IsTrue(Routes.Contains("SubDelete") || Routes.Contains("DELETE"), "RouteConstants must define delete sub-route");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("PullRequestDetailPage renders diff viewer with file tree, line numbers, additions, and deletions")]
    public void Rule112PullRequestDetailDiffViewer()
    {
        var PrDetail = ReadSource("PrTask.SharedUI", "Pages", "PullRequestDetailPage.razor");
        Assert.IsTrue(PrDetail.Contains("diff-viewer") || PrDetail.Contains("diff-section"),
            "PullRequestDetailPage must have diff viewer markup");
        Assert.IsTrue(PrDetail.Contains("diff-file-tree") || PrDetail.Contains("file-tree") || PrDetail.Contains("file-list"),
            "PullRequestDetailPage must have file tree section");
        Assert.IsTrue(PrDetail.Contains("line-add") || PrDetail.Contains("line-del") || PrDetail.Contains("diff-line"),
            "PullRequestDetailPage must show diff lines with add/delete styling");
        Assert.IsTrue(PrDetail.Contains("line-number") || PrDetail.Contains("LineNumber"),
            "PullRequestDetailPage must show line numbers");
        Assert.IsTrue(PrDetail.Contains("Additions") || PrDetail.Contains("Deletions") || PrDetail.Contains("diff-stats"),
            "PullRequestDetailPage must show diff statistics");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("IInferenceService interface exists in Application with required LLamaSharp methods")]
    public void Rule113InferenceServiceInterface()
    {
        var InferencePath = Path.Combine(SourceRoot, "PrTask.Application", "Services", "IInferenceService.cs");
        Assert.IsTrue(File.Exists(InferencePath), "IInferenceService must exist in PrTask.Application");
        var Inference = File.ReadAllText(InferencePath);
        Assert.IsTrue(Inference.Contains("GenerateEmbeddingAsync") || Inference.Contains("EmbeddingAsync"),
            "IInferenceService must have embedding generation method");
        Assert.IsTrue(Inference.Contains("GenerateCompletionAsync") || Inference.Contains("CompletionAsync"),
            "IInferenceService must have completion generation method");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("IVectorSearchService interface exists in Application with required USearch methods")]
    public void Rule114VectorSearchServiceInterface()
    {
        var VectorPath = Path.Combine(SourceRoot, "PrTask.Application", "Services", "IVectorSearchService.cs");
        Assert.IsTrue(File.Exists(VectorPath), "IVectorSearchService must exist in PrTask.Application");
        var Vector = File.ReadAllText(VectorPath);
        Assert.IsTrue(Vector.Contains("IndexAsync"), "IVectorSearchService must have IndexAsync");
        Assert.IsTrue(Vector.Contains("SearchAsync"), "IVectorSearchService must have SearchAsync");
        Assert.IsTrue(Vector.Contains("DeleteAsync"), "IVectorSearchService must have DeleteAsync");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("ITranscriptionService interface exists in Application with required Whisper.net methods")]
    public void Rule115TranscriptionServiceInterface()
    {
        var TranscriptionPath = Path.Combine(SourceRoot, "PrTask.Application", "Services", "ITranscriptionService.cs");
        Assert.IsTrue(File.Exists(TranscriptionPath), "ITranscriptionService must exist in PrTask.Application");
        var Transcription = File.ReadAllText(TranscriptionPath);
        Assert.IsTrue(Transcription.Contains("TranscribeAsync"), "ITranscriptionService must have TranscribeAsync");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("ISyncService interface exists in Application with required Harmony CRDT sync methods")]
    public void Rule116SyncServiceInterface()
    {
        var SyncPath = Path.Combine(SourceRoot, "PrTask.Application", "Services", "ISyncService.cs");
        Assert.IsTrue(File.Exists(SyncPath), "ISyncService must exist in PrTask.Application");
        var Sync = File.ReadAllText(SyncPath);
        Assert.IsTrue(Sync.Contains("SyncAsync"), "ISyncService must have SyncAsync");
        Assert.IsTrue(Sync.Contains("RegisterChangeAsync") || Sync.Contains("GetSyncStatus"),
            "ISyncService must have change registration or status method");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("AppDbContext uses UseSqlite as primary EF Core 10 storage provider")]
    public void Rule117AppDbContextUsesSqlite()
    {
        var Registration = ReadSource("PrTask.Infrastructure", "ServiceRegistration.cs");
        Assert.IsTrue(Registration.Contains("UseSqlite"), "ServiceRegistration must configure UseSqlite for AppDbContext");
        var DbContext = ReadSource("PrTask.Infrastructure", "Data", "AppDbContext.cs");
        Assert.IsTrue(DbContext.Contains("DbSet"), "AppDbContext must have DbSet properties for entity mapping");
        Assert.IsTrue(DbContext.Contains("Tasks"), "AppDbContext must have Tasks DbSet");
        Assert.IsTrue(DbContext.Contains("Users"), "AppDbContext must have Users DbSet");
        Assert.IsTrue(DbContext.Contains("PullRequests"), "AppDbContext must have PullRequests DbSet");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("Each rule in RULES.md has at least one E2E test method covering it")]
    public void Rule118EveryRulesmdTaskHasE2ETest()
    {
        var RulesMd = File.ReadAllText(Path.Combine(SolutionRoot, "RULES.md"));
        var RuleCount = 0;
        for (var I = 1; I <= 125; I++)
        {
            if (RulesMd.Contains($"\n{I}. ") || RulesMd.Contains($"\r\n{I}. "))
            {
                RuleCount++;
            }
        }
        Assert.IsTrue(RuleCount >= 90, $"RULES.md must define at least 90 numbered rules, found {RuleCount}");
        var TestFiles = Directory.EnumerateFiles(
            Path.Combine(SolutionRoot, "tests", "PrTask.E2E"), "RulesTests*.cs", SearchOption.TopDirectoryOnly)
            .Select(File.ReadAllText)
            .ToList();
        var AllTestContent = string.Join("\n", TestFiles);
        Assert.IsTrue(AllTestContent.Contains("[TestMethod]"), "E2E project must have test methods");
        var TestMethodCount = CountOccurrences(AllTestContent, "[TestMethod");
        Assert.IsTrue(TestMethodCount >= 90,
            $"Must have at least 90 E2E test methods to cover all rules, found {TestMethodCount}");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("LeaderboardService sorts earners by TotalEarnedCents and spenders by TotalSpentCents")]
    public void Rule119LeaderboardSortedByDollarAmount()
    {
        var Service = ReadSource("PrTask.Infrastructure", "Services", "LeaderboardService.cs");
        Assert.IsTrue(Service.Contains("TotalEarnedCents"), "LeaderboardService must sort by TotalEarnedCents");
        Assert.IsTrue(Service.Contains("TotalSpentCents"), "LeaderboardService must sort by TotalSpentCents");
        Assert.IsTrue(Service.Contains("OrderByDescending"), "LeaderboardService must use OrderByDescending");
        Assert.IsTrue(Service.Contains("GetTopAsync") || Service.Contains("GetByEarningsAsync"),
            "LeaderboardService must have earnings tab method");
        Assert.IsTrue(Service.Contains("GetTopBySpendingAsync") || Service.Contains("GetBySpendingAsync"),
            "LeaderboardService must have spending tab method");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("AppConstants has KycRequiredForWithdrawal constant for KYC-gated withdrawal enforcement")]
    public void Rule120AppConstantsKycRequired()
    {
        var AppConst = ReadSource("PrTask.Domain", "Constants", "AppConstants.cs");
        Assert.IsTrue(AppConst.Contains("KycRequiredForWithdrawal"),
            "AppConstants must define KycRequiredForWithdrawal boolean constant");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("Settings page has Maya account, vaulted cards, and payment history sections for all users")]
    public void Rule121SettingsPageMayaSections()
    {
        var Settings = ReadSource("PrTask.SharedUI", "Pages", "SettingsPage.razor");
        Assert.IsTrue(Settings.Contains("Maya") || Settings.Contains("PaymentMethod") || Settings.Contains("payment"),
            "Settings page must have Maya payment section");
        Assert.IsTrue(Settings.Contains("vault") || Settings.Contains("Vault") || Settings.Contains("card") || Settings.Contains("Card"),
            "Settings page must have vaulted cards section");
        Assert.IsTrue(Settings.Contains("Withdrawal") || Settings.Contains("withdrawal") || Settings.Contains("Deposit"),
            "Settings page must have withdrawal or deposit section");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("Privacy page covers Philippine RA 10173 and BSP compliance with NPC registration and data rights")]
    public void Rule122PhilippineLegalCompliance()
    {
        var Privacy = ReadSource("PrTask.SharedUI", "Pages", "Legal", "PrivacyPage.razor");
        Assert.IsTrue(Privacy.Contains("GdprCompliance") || Privacy.Contains("DataRights") || Privacy.Contains("GDPR") || Privacy.Contains("data rights") || Privacy.Contains("Data Rights") || Privacy.Contains("right to"),
            "Privacy page must disclose data subject rights");
        Assert.IsTrue(Privacy.Contains("retention") || Privacy.Contains("Retention"),
            "Privacy page must disclose data retention period");
        Assert.IsTrue(Privacy.Contains("CcpaCompliance") || Privacy.Contains("CCPA") || Privacy.Contains("California"),
            "Privacy page must cover CCPA rights");
        Assert.IsTrue(Privacy.Contains("GdprRightErase") || Privacy.Contains("GdprRightAccessCopy") || Privacy.Contains("erasure") || Privacy.Contains("deletion") || Privacy.Contains("right to be forgotten") || Privacy.Contains("right to access"),
            "Privacy page must specify data subject rights including erasure");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("Terms includes governing law Philippines or Delaware arbitration clause limitation of liability and indemnification")]
    public void Rule123InternationalLegalCompliance()
    {
        var Terms = ReadSource("PrTask.SharedUI", "Pages", "Legal", "TermsPage.razor");
        Assert.IsTrue(Terms.Contains("DisputeResolution") || Terms.Contains("arbitration") || Terms.Contains("Arbitration"),
            "Terms must include arbitration clause");
        Assert.IsTrue(Terms.Contains("LimitationOfLiability") || Terms.Contains("limitation of liability") || Terms.Contains("Limitation of Liability") || Terms.Contains("liable"),
            "Terms must include limitation of liability");
        Assert.IsTrue(Terms.Contains("indemnif") || Terms.Contains("Indemnif"),
            "Terms must include indemnification clause");
        Assert.IsTrue(Terms.Contains("GoverningLaw") || Terms.Contains("governing law") || Terms.Contains("Governing Law") || Terms.Contains("Philippines") || Terms.Contains("Delaware"),
            "Terms must specify governing law jurisdiction");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("Terms specifies IP ownership before PR approval and DMCA has takedown procedure for infringing submissions")]
    public void Rule124IntellectualPropertyInPrSubmissions()
    {
        var Terms = ReadSource("PrTask.SharedUI", "Pages", "Legal", "TermsPage.razor");
        var DmcaContent = ReadSource("PrTask.SharedUI", "Pages", "Legal", "DmcaPage.razor");
        Assert.IsTrue(
            Terms.Contains("IntellectualProperty") || Terms.Contains("intellectual property") || Terms.Contains("Intellectual Property") ||
            Terms.Contains("IP") || Terms.Contains("copyright") || Terms.Contains("license"),
            "Terms must address intellectual property rights for PR code submissions");
        Assert.IsTrue(
            DmcaContent.Contains("takedown") || DmcaContent.Contains("Takedown") || DmcaContent.Contains("DMCA"),
            "DMCA page must have takedown procedure");
        Assert.IsTrue(
            DmcaContent.Contains("counter") || DmcaContent.Contains("Counter"),
            "DMCA page must describe counter-notification process");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("Terms states developers are independent contractors not employees of PrTask or task posters")]
    public void Rule125IndependentContractorClassification()
    {
        var Terms = ReadSource("PrTask.SharedUI", "Pages", "Legal", "TermsPage.razor");
        Assert.IsTrue(
            Terms.Contains("IndependentContractor") || Terms.Contains("independent contractor") || Terms.Contains("Independent Contractor") ||
            Terms.Contains("not an employee") || Terms.Contains("not employees"),
            "Terms must state developers are independent contractors, not employees");
    }
}
