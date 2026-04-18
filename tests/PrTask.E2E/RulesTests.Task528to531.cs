namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("AuthErrorCodes has all error code constants")]
    public void AuthErrorCodesHasAllConstants()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "AuthErrorCodes.cs");
        Assert.IsTrue(Source.Contains("AuthFailed"), "Has AuthFailed");
        Assert.IsTrue(Source.Contains("ProfileFailed"), "Has ProfileFailed");
        Assert.IsTrue(Source.Contains("NoCode"), "Has NoCode");
        Assert.IsTrue(Source.Contains("PkceMissing"), "Has PkceMissing");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("AuthEndpoints uses AuthErrorCodes constants for error responses")]
    public void AuthEndpointsUsesAuthErrorCodes()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "AuthEndpoints.cs");
        Assert.IsTrue(Source.Contains("AuthErrorCodes.AuthFailed"), "Uses AuthErrorCodes.AuthFailed");
        Assert.IsTrue(Source.Contains("AuthErrorCodes.ProfileFailed"), "Uses AuthErrorCodes.ProfileFailed");
        Assert.IsTrue(Source.Contains("AuthErrorCodes.NoCode"), "Uses AuthErrorCodes.NoCode");
        Assert.IsTrue(Source.Contains("AuthErrorCodes.PkceMissing"), "Uses AuthErrorCodes.PkceMissing");
        Assert.IsFalse(Source.Contains("\"auth_failed\""), "No hardcoded auth_failed string");
        Assert.IsFalse(Source.Contains("\"profile_failed\""), "No hardcoded profile_failed string");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("DbConstants has all database configuration constants")]
    public void DbConstantsHasAllConstants()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "DbConstants.cs");
        Assert.IsTrue(Source.Contains("ConfigConnectionString"), "Has ConfigConnectionString");
        Assert.IsTrue(Source.Contains("DefaultDbFileName"), "Has DefaultDbFileName");
        Assert.IsTrue(Source.Contains("DefaultConnectionString"), "Has DefaultConnectionString");
        Assert.IsTrue(Source.Contains("DataSourcePrefix"), "Has DataSourcePrefix");
        Assert.IsTrue(Source.Contains("PlainTextDbFolder"), "Has PlainTextDbFolder");
        Assert.IsTrue(Source.Contains("JsonFilePattern"), "Has JsonFilePattern");
        Assert.IsTrue(Source.Contains("EmptyJsonArray"), "Has EmptyJsonArray");
        Assert.IsTrue(Source.Contains("IdPropertyName"), "Has IdPropertyName");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("PlainTextDbService uses DbConstants for database configuration")]
    public void PlainTextDbServiceUsesDbConstants()
    {
        var Source = ReadSource("PrTask.Infrastructure", "Services", "PlainTextDbService.cs");
        Assert.IsTrue(Source.Contains("DbConstants.PlainTextDbFolder"), "Uses DbConstants.PlainTextDbFolder");
        Assert.IsTrue(Source.Contains("DbConstants.EmptyJsonArray"), "Uses DbConstants.EmptyJsonArray");
        Assert.IsTrue(Source.Contains("DbConstants.IdPropertyName"), "Uses DbConstants.IdPropertyName");
        Assert.IsTrue(Source.Contains("FormatStrings.CollectionFilePath"), "Uses FormatStrings for file paths");
    }
}
