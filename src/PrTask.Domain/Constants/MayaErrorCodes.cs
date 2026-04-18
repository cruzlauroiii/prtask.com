namespace PrTask.Domain.Constants;
public static class MayaErrorCodes
{
    public const string CardExpired = "PY0002";
    public const string CardInvalid = "PY0003";
    public const string PaymentNotFound = "PY0009";
    public const string ProcessingFailed = "PY0010";
    public const string MerchantForbidden = "PY0019";
    public const string CurrencyNotSupported = "PY0037";
    public const string InvalidVoidRequest = "PY0045";
    public const string IneligibleForRefund = "PY0047";
    public const string InvalidRefundAmount = "PY0048";
    public const string PaymentExpired = "PY0057";
    public const string RefundCutoff = "PY0072";
    public const string VoidCutoff = "PY0073";
    public const string RrnNotUnique = "PY0104";
    public const string InsufficientBalance = "PY0105";
    public const string AuthInvalidApiCredentials = "K001";
    public const string AuthMissingApiKey = "K002";
    public const string AuthDeactivatedMerchant = "K003";
    public const string AuthInvalidPublicKeyForEndpoint = "K004";
    public const string AuthInvalidSecretKeyForEndpoint = "K005";
    public const string AuthPermissionDenied = "K006";
    public const string AuthForbiddenCountry = "K007";
}
