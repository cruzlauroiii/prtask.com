namespace WillowMaze.Server;

internal interface IGateway
{
    bool SupportsTokenization { get; }

    Task<GatewayResponse> TokenizeAsync(TokenizeRequest request);
    Task<GatewayResponse> AuthorizeAsync(AuthorizeRequest request);
    Task<GatewayResponse> CaptureAsync(CaptureRequest request);
    Task<GatewayResponse> VoidAsync(VoidRequest request);
    Task<GatewayResponse> RefundAsync(RefundRequest request);
    Task<GatewayResponse> SettleAsync(SettleRequest request);
    Task<GatewayResponse> VerifyCardAsync(VerifyRequest request);
    Task<GatewayResponse> ChargeVaultAsync(ChargeVaultRequest request);
    Task<GatewayResponse> IncrementalAuthAsync(IncrementalAuthRequest request);
}

internal sealed class GatewayResponse
{
    public bool Approved { get; set; }
    public string ResponseCode { get; set; } = "";
    public string ResponseMessage { get; set; } = "";
    public string? AuthorizationCode { get; set; }
    public string? ReferenceNumber { get; set; }
    public string? Token { get; set; }
    public string? AvsResult { get; set; }
    public string? CvvResult { get; set; }
    public string? NetworkTransactionId { get; set; }
    public string? IssuerResponse { get; set; }
    public decimal? AuthorizedAmount { get; set; }
    public string? Currency { get; set; }
    public DateTimeOffset ProcessedUtc { get; set; }
    public Dictionary<string, string> Metadata { get; set; } = [];
}

internal sealed class CardData
{
    public string? MaskedPan { get; set; }
    public string? Last4 { get; set; }
    public string? Expiry { get; set; }
    public string? CardholderName { get; set; }
    public string? AidHex { get; set; }
    public string? CardBrand { get; set; }
    public string? Fingerprint { get; set; }
    public string? EmvData { get; set; }
}

internal sealed class TokenizeRequest
{
    public CardData Card { get; set; } = new();
}

internal sealed class AuthorizeRequest
{
    public string? Token { get; set; }
    public string? VaultId { get; set; }
    public CardData Card { get; set; } = new();
    public decimal Amount { get; set; }
    public string Currency { get; set; } = "PHP";
    public string? MerchantReference { get; set; }
    public bool IsRecurring { get; set; }
    public string? SubscriptionId { get; set; }
}

internal sealed class CaptureRequest
{
    public string? AuthorizationCode { get; set; }
    public string? ReferenceNumber { get; set; }
    public string? Token { get; set; }
    public CardData Card { get; set; } = new();
    public decimal Amount { get; set; }
    public string Currency { get; set; } = "PHP";
    public decimal? TipAmount { get; set; }
}

internal sealed class VoidRequest
{
    public string? AuthorizationCode { get; set; }
    public string? ReferenceNumber { get; set; }
    public string? Token { get; set; }
    public CardData Card { get; set; } = new();
    public decimal Amount { get; set; }
    public string? Reason { get; set; }
}

internal sealed class RefundRequest
{
    public string? ReferenceNumber { get; set; }
    public string? Token { get; set; }
    public CardData Card { get; set; } = new();
    public decimal Amount { get; set; }
    public string Currency { get; set; } = "PHP";
    public decimal? PartialAmount { get; set; }
    public string? Reason { get; set; }
}

internal sealed class SettleRequest
{
    public string? ReferenceNumber { get; set; }
    public string? Token { get; set; }
    public decimal Amount { get; set; }
    public string? BatchId { get; set; }
}

internal sealed class VerifyRequest
{
    public string? Token { get; set; }
    public string? VaultId { get; set; }
    public CardData Card { get; set; } = new();
}

internal sealed class ChargeVaultRequest
{
    public string? Token { get; set; }
    public string? VaultId { get; set; }
    public CardData Card { get; set; } = new();
    public decimal Amount { get; set; }
    public string Currency { get; set; } = "PHP";
    public string? Description { get; set; }
    public string? CustomerId { get; set; }
    public string? SubscriptionId { get; set; }
    public bool IsRecurring { get; set; }
}

internal sealed class IncrementalAuthRequest
{
    public string? AuthorizationCode { get; set; }
    public string? ReferenceNumber { get; set; }
    public string? Token { get; set; }
    public decimal AdditionalAmount { get; set; }
    public string Currency { get; set; } = "PHP";
}
