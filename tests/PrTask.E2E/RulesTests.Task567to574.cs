using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("AuthErrorCodes must define error code constants for authentication failures")]
    public void AuthErrorCodesHasAuthFailureConstants()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "AuthErrorCodes.cs");
        Assert.IsTrue(Source.Contains("AuthFailed"), "Has AuthFailed");
        Assert.IsTrue(Source.Contains("ProfileFailed"), "Has ProfileFailed");
        Assert.IsTrue(Source.Contains("NoCode"), "Has NoCode");
        Assert.IsTrue(Source.Contains("PkceMissing"), "Has PkceMissing");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("E2ECrudConstants must define identity and entity ID constants for CRUD tests")]
    public void E2ECrudConstantsHasCrudTestIdentifiers()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "E2ECrudConstants.cs");
        Assert.IsTrue(Source.Contains("DevProvider"), "Has DevProvider");
        Assert.IsTrue(Source.Contains("User1SubjectId"), "Has User1SubjectId");
        Assert.IsTrue(Source.Contains("CrudTaskId"), "Has CrudTaskId");
        Assert.IsTrue(Source.Contains("CrudPrId"), "Has CrudPrId");
        Assert.IsTrue(Source.Contains("CrudSprintId"), "Has CrudSprintId");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("E2EWorkflowConstants must define workflow step and screenshot constants")]
    public void E2EWorkflowConstantsHasWorkflowStepConstants()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "E2EWorkflowConstants.cs");
        Assert.IsTrue(Source.Contains("ScreenshotFormat"), "Has ScreenshotFormat");
        Assert.IsTrue(Source.Contains("BeforeLabel"), "Has BeforeLabel");
        Assert.IsTrue(Source.Contains("AfterLabel"), "Has AfterLabel");
        Assert.IsTrue(Source.Contains("StepCount"), "Has StepCount");
        Assert.IsTrue(Source.Contains("MinScreenshotBytes"), "Has MinScreenshotBytes");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("FormatStrings must define string formatting helper methods")]
    public void FormatStringsHasFormattingHelpers()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "FormatStrings.cs");
        Assert.IsTrue(Source.Contains("BountyAmount"), "Has BountyAmount");
        Assert.IsTrue(Source.Contains("TruncateText"), "Has TruncateText");
        Assert.IsTrue(Source.Contains("BuyerEmail"), "Has BuyerEmail");
        Assert.IsTrue(Source.Contains("PaymentSuccessRedirect"), "Has PaymentSuccessRedirect");
        Assert.IsTrue(Source.Contains("BasicAuthPayload"), "Has BasicAuthPayload");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("MayaErrorCodes must define payment and auth error code constants")]
    public void MayaErrorCodesHasPaymentErrorConstants()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "MayaErrorCodes.cs");
        Assert.IsTrue(Source.Contains("CardExpired"), "Has CardExpired");
        Assert.IsTrue(Source.Contains("PaymentNotFound"), "Has PaymentNotFound");
        Assert.IsTrue(Source.Contains("CurrencyNotSupported"), "Has CurrencyNotSupported");
        Assert.IsTrue(Source.Contains("AuthInvalidApiCredentials"), "Has AuthInvalidApiCredentials");
        Assert.IsTrue(Source.Contains("InsufficientBalance"), "Has InsufficientBalance");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("MayaSandboxCredentials must define sandbox API key pairs")]
    public void MayaSandboxCredentialsHasApiKeyPairs()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "MayaSandboxCredentials.cs");
        Assert.IsTrue(Source.Contains("Party1PublicKey"), "Has Party1PublicKey");
        Assert.IsTrue(Source.Contains("Party1SecretKey"), "Has Party1SecretKey");
        Assert.IsTrue(Source.Contains("P3SecretKey"), "Has P3SecretKey");
        Assert.IsTrue(Source.Contains("P3MerchantIdIndividual"), "Has P3MerchantIdIndividual");
        Assert.IsTrue(Source.Contains("SandboxStatusUrl"), "Has SandboxStatusUrl");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("MayaTestCards must define test card numbers for each card brand")]
    public void MayaTestCardsHasCardBrandConstants()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "MayaTestCards.cs");
        Assert.IsTrue(Source.Contains("VisaNoThreeDsNumber"), "Has VisaNoThreeDsNumber");
        Assert.IsTrue(Source.Contains("MasterCardThreeDsNumber"), "Has MasterCardThreeDsNumber");
        Assert.IsTrue(Source.Contains("AmexNumber"), "Has AmexNumber");
        Assert.IsTrue(Source.Contains("JcbNumber"), "Has JcbNumber");
        Assert.IsTrue(Source.Contains("InsufficientFundsVisaNumber"), "Has InsufficientFundsVisaNumber");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("ScoringConstants must define weight tiers and language difficulty mappings")]
    public void ScoringConstantsHasWeightAndDifficultyMappings()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "ScoringConstants.cs");
        Assert.IsTrue(Source.Contains("WeightHigh"), "Has WeightHigh");
        Assert.IsTrue(Source.Contains("WeightMedium"), "Has WeightMedium");
        Assert.IsTrue(Source.Contains("WeightLow"), "Has WeightLow");
        Assert.IsTrue(Source.Contains("FileScoreMultiplier"), "Has FileScoreMultiplier");
        Assert.IsTrue(Source.Contains("LanguageDifficultyWeights"), "Has LanguageDifficultyWeights");
    }
}
