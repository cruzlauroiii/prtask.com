namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("PlainTextDbEndpoints source structure")]
    public void PlainTextDbEndpointsStructure()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "PlainTextDbEndpoints.cs");
        Assert.IsTrue(Source.Contains(nameof(PrTask.Domain.Constants.RouteConstants.ApiPlainTextDb)), "Uses ApiPlainTextDb");
        Assert.IsTrue(Source.Contains(nameof(PrTask.Application.Services.IPlainTextDbService)), "Injects IPlainTextDbService");
        Assert.IsTrue(Source.Contains("RequireAuthorization"), "Requires auth");
        Assert.IsTrue(Source.Contains("ListAsync"), "Calls ListAsync");
        Assert.IsTrue(Source.Contains("ReadAsync"), "Calls ReadAsync");
        Assert.IsTrue(Source.Contains("WriteAsync"), "Calls WriteAsync");
        Assert.IsTrue(Source.Contains("DeleteAsync"), "Calls DeleteAsync");
        Assert.IsTrue(Source.Contains("ExportCollectionAsync"), "Calls ExportCollectionAsync");
        Assert.IsTrue(Source.Contains("ImportCollectionAsync"), "Calls ImportCollectionAsync");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("CustomerEndpoints source structure")]
    public void CustomerEndpointsStructure()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "CustomerEndpoints.cs");
        Assert.IsTrue(Source.Contains(nameof(PrTask.Domain.Constants.RouteConstants.ApiCustomers)), "Uses ApiCustomers");
        Assert.IsTrue(Source.Contains(nameof(PrTask.Application.Services.IPaymentService)), "Injects IPaymentService");
        Assert.IsTrue(Source.Contains("RequireAuthorization"), "Requires auth");
        Assert.IsTrue(Source.Contains("CreateCustomerAsync"), "Calls CreateCustomerAsync");
        Assert.IsTrue(Source.Contains("GetCustomerAsync"), "Calls GetCustomerAsync");
        Assert.IsTrue(Source.Contains("UpdateCustomerAsync"), "Calls UpdateCustomerAsync");
        Assert.IsTrue(Source.Contains("DeleteCustomerAsync"), "Calls DeleteCustomerAsync");
        Assert.IsTrue(Source.Contains("VaultCardAsync"), "Calls VaultCardAsync");
        Assert.IsTrue(Source.Contains("PayWithVaultedCardAsync"), "Calls PayWithVaultedCardAsync");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("PaymentV2Endpoints source structure")]
    public void PaymentV2EndpointsStructure()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "PaymentV2Endpoints.cs");
        Assert.IsTrue(Source.Contains(nameof(PrTask.Domain.Constants.RouteConstants.ApiPaymentsV2)), "Uses ApiPaymentsV2");
        Assert.IsTrue(Source.Contains(nameof(PrTask.Application.Services.IPaymentV2Service)), "Injects IPaymentV2Service");
        Assert.IsTrue(Source.Contains("RequireAuthorization"), "Requires auth");
        Assert.IsTrue(Source.Contains("CreatePaymentV2Async"), "Calls CreatePaymentV2Async");
        Assert.IsTrue(Source.Contains("GetPaymentV2Async"), "Calls GetPaymentV2Async");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("QrPaymentEndpoints source structure")]
    public void QrPaymentEndpointsStructure()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "QrPaymentEndpoints.cs");
        Assert.IsTrue(Source.Contains(nameof(PrTask.Domain.Constants.RouteConstants.ApiQrPayments)), "Uses ApiQrPayments");
        Assert.IsTrue(Source.Contains(nameof(PrTask.Application.Services.IQrPaymentService)), "Injects IQrPaymentService");
        Assert.IsTrue(Source.Contains("RequireAuthorization"), "Requires auth");
        Assert.IsTrue(Source.Contains("CreateDynamicQrAsync"), "Calls CreateDynamicQrAsync");
        Assert.IsTrue(Source.Contains("CreateStaticQrPaymentAsync"), "Calls CreateStaticQrPaymentAsync");
        Assert.IsTrue(Source.Contains("ExecuteQrPaymentAsync"), "Calls ExecuteQrPaymentAsync");
        Assert.IsTrue(Source.Contains("GetQrPaymentAsync"), "Calls GetQrPaymentAsync");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("WalletPaymentEndpoints and MayaConnectEndpoints source structure")]
    public void WalletAndMayaConnectEndpointsStructure()
    {
        var Wallet = ReadSource("PrTask.Server", "Endpoints", "WalletPaymentEndpoints.cs");
        Assert.IsTrue(Wallet.Contains(nameof(PrTask.Domain.Constants.RouteConstants.ApiWalletPayments)), "Uses ApiWalletPayments");
        Assert.IsTrue(Wallet.Contains(nameof(PrTask.Application.Services.IWalletPaymentService)), "Injects IWalletPaymentService");
        Assert.IsTrue(Wallet.Contains("CreateWalletPaymentAsync"), "Calls CreateWalletPaymentAsync");
        Assert.IsTrue(Wallet.Contains("CreateWalletLinkAsync"), "Calls CreateWalletLinkAsync");
        Assert.IsTrue(Wallet.Contains("DeleteWalletLinkAsync"), "Calls DeleteWalletLinkAsync");
        var Connect = ReadSource("PrTask.Server", "Endpoints", "MayaConnectEndpoints.cs");
        Assert.IsTrue(Connect.Contains(nameof(PrTask.Domain.Constants.RouteConstants.ApiMayaConnect)), "Uses ApiMayaConnect");
        Assert.IsTrue(Connect.Contains(nameof(PrTask.Application.Services.IMayaConnectService)), "Injects IMayaConnectService");
        Assert.IsTrue(Connect.Contains("AuthorizeAsync"), "Calls AuthorizeAsync");
        Assert.IsTrue(Connect.Contains("ExchangeTokenAsync"), "Calls ExchangeTokenAsync");
        Assert.IsTrue(Connect.Contains("GetJwkAsync"), "Calls GetJwkAsync");
    }
}
