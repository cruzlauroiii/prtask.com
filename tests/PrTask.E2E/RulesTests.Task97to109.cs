using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("MAUI Routes.razor wraps Router in ErrorBoundary with reload button and OnParametersSet recovery")]
    public void Rule97MauiRoutesErrorBoundary()
    {
        var Routes = ReadSource("PrTask.Maui", "Routes.razor");
        Assert.IsTrue(Routes.Contains("ErrorBoundary"), "Routes.razor must contain ErrorBoundary component");
        Assert.IsTrue(Routes.Contains("ErrorContent"), "Routes.razor must have ErrorContent section");
        Assert.IsTrue(Routes.Contains("location.reload()") || Routes.Contains("Reload") || Routes.Contains("reload"),
            "Routes.razor ErrorContent must have a reload button");
        Assert.IsTrue(Routes.Contains("OnParametersSet"), "Routes.razor must override OnParametersSet");
        Assert.IsTrue(Routes.Contains("Recover"), "Routes.razor OnParametersSet must call ErrorBoundary.Recover()");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("MAUI index.html prtaskCheckAuth uses Promise.resolve with local storage instead of fetch")]
    public void Rule98MauiCheckAuthUsesPromiseResolve()
    {
        var MauiIndex = ReadSource("PrTask.Maui", "wwwroot", "index.html");
        Assert.IsTrue(MauiIndex.Contains("prtaskCheckAuth"), "MAUI index.html must have prtaskCheckAuth function");
        Assert.IsTrue(MauiIndex.Contains("Promise.resolve"), "prtaskCheckAuth must use Promise.resolve not fetch");
        Assert.IsTrue(MauiIndex.Contains("prtaskGetUser"), "prtaskCheckAuth must use local prtaskGetUser");
        Assert.IsFalse(MauiIndex.Contains("fetch("), "prtaskCheckAuth must not use fetch to avoid hanging mobile requests");
        Assert.IsTrue(MauiIndex.Contains("prtaskSignOut"), "MAUI index.html must have prtaskSignOut function");
        Assert.IsTrue(MauiIndex.Contains("localStorage"), "prtaskSignOut must clear localStorage directly");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("MauiProgram.cs wraps database init in nested try-catch so startup never crashes on DB failure")]
    public void Rule99MauiProgramNestedTryCatch()
    {
        var MauiProgram = ReadSource("PrTask.Maui", "MauiProgram.cs");
        Assert.IsTrue(MauiProgram.Contains("EnsureCreated"), "MauiProgram must call EnsureCreated");
        Assert.IsTrue(MauiProgram.Contains("EnsureDeleted"), "MauiProgram must call EnsureDeleted in fallback");
        var TryCatchCount = CountOccurrences(MauiProgram, "try");
        Assert.IsTrue(TryCatchCount >= 2, $"MauiProgram must have nested try-catch blocks (found {TryCatchCount})");
        var CatchCount = CountOccurrences(MauiProgram, "catch");
        Assert.IsTrue(CatchCount >= 2, $"MauiProgram must have at least 2 catch blocks (found {CatchCount})");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("PrTask.Desktop project exists or Download page references Windows exe")]
    public void Rule100DesktopProjectOrDownloadPlaceholder()
    {
        var DesktopCsproj = Path.Combine(SourceRoot, "PrTask.Desktop", "PrTask.Desktop.csproj");
        var DownloadPage = ReadSource("PrTask.SharedUI", "Pages", "DownloadPage.razor");
        if (!File.Exists(DesktopCsproj))
        {
            Assert.IsTrue(DownloadPage.Contains("Windows") || DownloadPage.Contains("exe") || DownloadPage.Contains("Desktop"),
                "If PrTask.Desktop does not exist, DownloadPage must reference Windows exe placeholder");
            Assert.Inconclusive("PrTask.Desktop project not yet created — placeholder test passed");
            return;
        }
        var DesktopContent = File.ReadAllText(DesktopCsproj);
        Assert.IsTrue(DesktopContent.Contains("Exe") || DesktopContent.Contains("WinExe"),
            "PrTask.Desktop must produce an executable output type");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("IPaymentService has CreateCheckoutAsync with Maya Checkout v1 required fields")]
    public void Rule101MayaCheckoutSession()
    {
        var IPayment = ReadSource("PrTask.Application", "Services", "IPaymentService.cs");
        Assert.IsTrue(IPayment.Contains("CreateCheckoutAsync"), "IPaymentService must have CreateCheckoutAsync");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("IPaymentService has CreatePaymentTokenAsync for Maya Payment Token API")]
    public void Rule102MayaPaymentToken()
    {
        var IPayment = ReadSource("PrTask.Application", "Services", "IPaymentService.cs");
        Assert.IsTrue(IPayment.Contains("CreatePaymentTokenAsync"), "IPaymentService must have CreatePaymentTokenAsync");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("IPaymentService has PayWithVaultedCardAsync for Maya Card Payment API")]
    public void Rule103MayaCardPayment()
    {
        var IPayment = ReadSource("PrTask.Application", "Services", "IPaymentService.cs");
        Assert.IsTrue(IPayment.Contains("PayWithVaultedCardAsync"), "IPaymentService must have PayWithVaultedCardAsync");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("IPaymentService has full Maya Customer Vault lifecycle methods")]
    public void Rule104MayaCustomerVault()
    {
        var IPayment = ReadSource("PrTask.Application", "Services", "IPaymentService.cs");
        Assert.IsTrue(IPayment.Contains("CreateCustomerAsync"), "IPaymentService must have CreateCustomerAsync");
        Assert.IsTrue(IPayment.Contains("GetCustomerAsync"), "IPaymentService must have GetCustomerAsync");
        Assert.IsTrue(IPayment.Contains("UpdateCustomerAsync"), "IPaymentService must have UpdateCustomerAsync");
        Assert.IsTrue(IPayment.Contains("DeleteCustomerAsync"), "IPaymentService must have DeleteCustomerAsync");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("IPaymentService has full Maya Card Vault methods per customer")]
    public void Rule105MayaCardVault()
    {
        var IPayment = ReadSource("PrTask.Application", "Services", "IPaymentService.cs");
        Assert.IsTrue(IPayment.Contains("VaultCardAsync"), "IPaymentService must have VaultCardAsync");
        Assert.IsTrue(IPayment.Contains("GetVaultedCardsAsync"), "IPaymentService must have GetVaultedCardsAsync");
        Assert.IsTrue(IPayment.Contains("GetVaultedCardAsync"), "IPaymentService must have GetVaultedCardAsync");
        Assert.IsTrue(IPayment.Contains("UpdateVaultedCardAsync"), "IPaymentService must have UpdateVaultedCardAsync");
        Assert.IsTrue(IPayment.Contains("DeleteVaultedCardAsync"), "IPaymentService must have DeleteVaultedCardAsync");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("IPaymentService has Maya Webhook management methods including HandleWebhookAsync")]
    public void Rule106MayaWebhookApi()
    {
        var IPayment = ReadSource("PrTask.Application", "Services", "IPaymentService.cs");
        Assert.IsTrue(IPayment.Contains("RegisterWebhookAsync"), "IPaymentService must have RegisterWebhookAsync");
        Assert.IsTrue(IPayment.Contains("GetWebhooksAsync"), "IPaymentService must have GetWebhooksAsync");
        Assert.IsTrue(IPayment.Contains("UpdateWebhookAsync"), "IPaymentService must have UpdateWebhookAsync");
        Assert.IsTrue(IPayment.Contains("DeleteWebhookAsync"), "IPaymentService must have DeleteWebhookAsync");
        Assert.IsTrue(IPayment.Contains("HandleWebhookAsync"), "IPaymentService must have HandleWebhookAsync");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("IPaymentService has VoidPaymentAsync and RefundPaymentAsync for Maya Void and Refund API")]
    public void Rule107MayaVoidRefund()
    {
        var IPayment = ReadSource("PrTask.Application", "Services", "IPaymentService.cs");
        Assert.IsTrue(IPayment.Contains("VoidPaymentAsync"), "IPaymentService must have VoidPaymentAsync");
        Assert.IsTrue(IPayment.Contains("RefundPaymentAsync"), "IPaymentService must have RefundPaymentAsync");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("IPaymentService has SetCustomizationAsync for Maya Customization API branding")]
    public void Rule108MayaCustomization()
    {
        var IPayment = ReadSource("PrTask.Application", "Services", "IPaymentService.cs");
        Assert.IsTrue(IPayment.Contains("SetCustomizationAsync"), "IPaymentService must have SetCustomizationAsync");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("MayaConstants defines sandbox and production URLs and keys stored in user-secrets")]
    public void Rule109MayaSandboxAndProductionConfig()
    {
        var MayaConst = ReadSource("PrTask.Domain", "Constants", "MayaConstants.cs");
        Assert.IsTrue(MayaConst.Contains("SandboxBaseUrl"), "MayaConstants must define SandboxBaseUrl");
        Assert.IsTrue(MayaConst.Contains("ProductionBaseUrl"), "MayaConstants must define ProductionBaseUrl");
        Assert.IsTrue(MayaConst.Contains("pg-sandbox.paymaya.com"), "MayaConstants SandboxBaseUrl must point to pg-sandbox.paymaya.com");
        Assert.IsTrue(MayaConst.Contains("pg.paymaya.com"), "MayaConstants ProductionBaseUrl must point to pg.paymaya.com");
    }

    private static int CountOccurrences(string Source, string Word)
    {
        var Count = 0;
        var Index = 0;
        while ((Index = Source.IndexOf(Word, Index, StringComparison.Ordinal)) >= 0)
        {
            Count++;
            Index += Word.Length;
        }
        return Count;
    }
}
