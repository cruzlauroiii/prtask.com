namespace PrTask.Domain.Constants;
public static class KycEnforcementConstants
{
    public const string KycRequiredMessage = "KYC verification is required to access this resource.";
    public const string KycPendingMessage = "KYC verification is pending. Please wait for approval.";
    public const string KycRejectedMessage = "KYC verification was rejected. Please resubmit.";

    public static readonly string[] KycRequiredPathPrefixes =
    [
        RouteConstants.ApiPayments,
        RouteConstants.ApiPaymentsV2,
        RouteConstants.ApiSubscriptions,
        RouteConstants.ApiInvoices,
        RouteConstants.ApiDisbursements,
        RouteConstants.ApiQrPayments,
        RouteConstants.ApiWalletPayments,
        RouteConstants.ApiBillsPayments,
        RouteConstants.ApiP3,
        RouteConstants.ApiRemittances,
        RouteConstants.ApiVoids,
        RouteConstants.ApiRefunds
    ];

    public static readonly string[] KycRequiredExactPostPaths =
    [
        RouteConstants.ApiTasks,
        RouteConstants.ApiPullRequests
    ];

    public const string HttpMethodGet = "GET";
    public const string HttpMethodHead = "HEAD";
    public const string HttpMethodOptions = "OPTIONS";

    public static readonly string[] ReadOnlyMethods =
    [
        HttpMethodGet,
        HttpMethodHead,
        HttpMethodOptions
    ];

    public const string ResponseContentType = "application/json";
    public const string ErrorPropertyName = "error";
    public const string KycStatusPropertyName = "kycStatus";
}
