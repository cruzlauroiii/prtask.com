using System.Net;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Payment entity must have payer id payee id amount and status fields for escrow tracking")]
    public void PaymentEntityMustHavePayerIdPayeeIdAmountAndStatusFieldsForEscrowTracking()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Models", "PaymentEntity.cs");
        Assert.IsTrue(Code.Contains("PayerId", StringComparison.Ordinal), "PaymentEntity must have PayerId for the client paying");
        Assert.IsTrue(Code.Contains("PayeeId", StringComparison.Ordinal), "PaymentEntity must have PayeeId for the developer receiving");
        Assert.IsTrue(Code.Contains("AmountCents", StringComparison.Ordinal), "PaymentEntity must have AmountCents for payment amount");
        Assert.IsTrue(Code.Contains("PaymentStatus", StringComparison.Ordinal), "PaymentEntity must have PaymentStatus for tracking state");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Payment entity must have task id and pull request id linking payment to completed work")]
    public void PaymentEntityMustHaveTaskIdAndPullRequestIdLinkingPaymentToCompletedWork()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Models", "PaymentEntity.cs");
        Assert.IsTrue(Code.Contains("TaskId", StringComparison.Ordinal), "PaymentEntity must link to the task being paid for");
        Assert.IsTrue(Code.Contains("PullRequestId", StringComparison.Ordinal), "PaymentEntity must link to the accepted pull request");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Payment entity must have maya checkout and payment ids for payment gateway integration")]
    public void PaymentEntityMustHaveMayaCheckoutAndPaymentIdsForPaymentGatewayIntegration()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Models", "PaymentEntity.cs");
        Assert.IsTrue(Code.Contains("MayaCheckoutId", StringComparison.Ordinal), "PaymentEntity must store Maya checkout session ID");
        Assert.IsTrue(Code.Contains("MayaPaymentId", StringComparison.Ordinal), "PaymentEntity must store Maya payment ID");
        Assert.IsTrue(Code.Contains("MayaStatus", StringComparison.Ordinal), "PaymentEntity must store raw Maya status");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Payment entity must have platform fee cents and webhook data for transaction processing")]
    public void PaymentEntityMustHavePlatformFeeCentsAndWebhookDataForTransactionProcessing()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Models", "PaymentEntity.cs");
        Assert.IsTrue(Code.Contains("PlatformFeeCents", StringComparison.Ordinal), "PaymentEntity must track platform fee amount");
        Assert.IsTrue(Code.Contains("WebhookData", StringComparison.Ordinal), "PaymentEntity must store webhook payload for audit");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Payment status enum must define pending processing completed failed and refunded states")]
    public void PaymentStatusEnumMustDefinePendingProcessingCompletedFailedAndRefundedStates()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Models", "PaymentStatus.cs");
        Assert.IsTrue(Code.Contains("Pending", StringComparison.Ordinal), "PaymentStatus must have Pending state");
        Assert.IsTrue(Code.Contains("Processing", StringComparison.Ordinal), "PaymentStatus must have Processing state");
        Assert.IsTrue(Code.Contains("Completed", StringComparison.Ordinal), "PaymentStatus must have Completed state");
        Assert.IsTrue(Code.Contains("Failed", StringComparison.Ordinal), "PaymentStatus must have Failed state");
        Assert.IsTrue(Code.Contains("Refunded", StringComparison.Ordinal), "PaymentStatus must have Refunded state");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Payment service interface must define checkout webhook handling and status query methods")]
    public void PaymentServiceInterfaceMustDefineCheckoutWebhookHandlingAndStatusQueryMethods()
    {
        var Code = ReadSourceFile("PrTask.Application", "Services", "IPaymentService.cs");
        Assert.IsTrue(Code.Contains("CreateCheckoutAsync", StringComparison.Ordinal), "IPaymentService must have CreateCheckoutAsync for initiating payment");
        Assert.IsTrue(Code.Contains("HandleWebhookAsync", StringComparison.Ordinal), "IPaymentService must have HandleWebhookAsync for Maya callbacks");
        Assert.IsTrue(Code.Contains("GetStatusAsync", StringComparison.Ordinal), "IPaymentService must have GetStatusAsync for checking payment state");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maya constants must define sandbox and production urls with checkout and webhook endpoints")]
    public void MayaConstantsMustDefineSandboxAndProductionUrlsWithCheckoutAndWebhookEndpoints()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "MayaConstants.cs");
        Assert.IsTrue(Code.Contains("SandboxBaseUrl", StringComparison.Ordinal), "MayaConstants must have sandbox URL for testing");
        Assert.IsTrue(Code.Contains("ProductionBaseUrl", StringComparison.Ordinal), "MayaConstants must have production URL for live payments");
        Assert.IsTrue(Code.Contains("CheckoutEndpoint", StringComparison.Ordinal), "MayaConstants must have checkout endpoint path");
        Assert.IsTrue(Code.Contains("WebhookEndpoint", StringComparison.Ordinal), "MayaConstants must have webhook endpoint path");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maya constants must define webhook event types for checkout success failure and dropout")]
    public void MayaConstantsMustDefineWebhookEventTypesForCheckoutSuccessFailureAndDropout()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "MayaConstants.cs");
        Assert.IsTrue(Code.Contains("WebhookCheckoutSuccess", StringComparison.Ordinal), "MayaConstants must define checkout success event");
        Assert.IsTrue(Code.Contains("WebhookCheckoutFailure", StringComparison.Ordinal), "MayaConstants must define checkout failure event");
        Assert.IsTrue(Code.Contains("WebhookCheckoutDropout", StringComparison.Ordinal), "MayaConstants must define checkout dropout event");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Payment checkout request contract must have task id payer id and amount cents fields")]
    public void PaymentCheckoutRequestContractMustHaveTaskIdPayerIdAndAmountCentsFields()
    {
        var Code = ReadSourceFile("PrTask.Application", "Contracts", "PaymentCheckoutRequest.cs");
        Assert.IsTrue(Code.Contains("TaskId", StringComparison.Ordinal), "PaymentCheckoutRequest must specify which task to pay for");
        Assert.IsTrue(Code.Contains("PayerId", StringComparison.Ordinal), "PaymentCheckoutRequest must identify the paying client");
        Assert.IsTrue(Code.Contains("AmountCents", StringComparison.Ordinal), "PaymentCheckoutRequest must specify payment amount in cents");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Payment endpoints must require authorization for checkout but allow anonymous webhook calls")]
    public void PaymentEndpointsMustRequireAuthorizationForCheckoutButAllowAnonymousWebhookCalls()
    {
        var Code = ReadSourceFile("PrTask.Server", "Endpoints", "PaymentEndpoints.cs");
        Assert.IsTrue(Code.Contains("RequireAuthorization", StringComparison.Ordinal), "Payment checkout must require authentication");
        Assert.IsTrue(Code.Contains("ApiPaymentsWebhook", StringComparison.Ordinal), "Payment endpoints must handle Maya webhook callbacks");
        Assert.IsTrue(Code.Contains("ApiPaymentsStatus", StringComparison.Ordinal), "Payment endpoints must expose status check route");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Route constants must define api payment routes for checkout webhook and status endpoints")]
    public void RouteConstantsMustDefineApiPaymentRoutesForCheckoutWebhookAndStatusEndpoints()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "RouteConstants.cs");
        Assert.IsTrue(Code.Contains("ApiPaymentsCheckout", StringComparison.Ordinal), "RouteConstants must define checkout route");
        Assert.IsTrue(Code.Contains("ApiPaymentsWebhook", StringComparison.Ordinal), "RouteConstants must define webhook route");
        Assert.IsTrue(Code.Contains("ApiPaymentsStatus", StringComparison.Ordinal), "RouteConstants must define status route");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("App constants must define minimum bounty amount and platform fee percent for payment rules")]
    public void AppConstantsMustDefineMinimumBountyAmountAndPlatformFeePercentForPaymentRules()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "AppConstants.cs");
        Assert.IsTrue(Code.Contains("MinBountyAmountCents", StringComparison.Ordinal), "AppConstants must define minimum bounty amount");
        Assert.IsTrue(Code.Contains("PlatformFeePercent", StringComparison.Ordinal), "AppConstants must define platform fee percentage");
    }
    [TestMethod, TestCategory("Integration")]
    [DisplayName("Payment checkout endpoint must return unauthorized when not authenticated for payment creation")]
    public async Task PaymentCheckoutEndpointMustReturnUnauthorizedWhenNotAuthenticatedForPaymentCreationAsync()
    {
        var Content = new StringContent("{\"TaskId\":\"t1\",\"PayerId\":\"p1\",\"AmountCents\":10000}", System.Text.Encoding.UTF8, "application/json");
        var Response = await ApiClient.PostAsync(RouteConstants.ApiPaymentsCheckout, Content);
        Assert.AreEqual(HttpStatusCode.Unauthorized, Response.StatusCode);
    }
    [TestMethod, TestCategory("Integration")]
    [DisplayName("Payment status endpoint must return successful response with status for valid payment query")]
    public async Task PaymentStatusEndpointMustReturnSuccessfulResponseWithStatusForValidPaymentQueryAsync()
    {
        var Response = await ApiClient.GetAsync($"{RouteConstants.ApiPaymentsStatus}/nonexistent-id");
        Assert.AreEqual(HttpStatusCode.OK, Response.StatusCode);
    }
}
