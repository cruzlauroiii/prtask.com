using System.Security.Cryptography;
using System.Text;

namespace WillowMaze.Server;

internal sealed class SandboxGateway : IGateway
{
    public bool SupportsTokenization => true;

    public Task<GatewayResponse> TokenizeAsync(TokenizeRequest req)
    {
        var c = req.Card;
        var token = $"tok_{Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes($"{c.MaskedPan}{c.Last4}{c.Expiry}{DateTimeOffset.UtcNow.Ticks}")))[..24]}";
        return Ok(new GatewayResponse { Token = token, ResponseMessage = "Token created" });
    }

    public Task<GatewayResponse> AuthorizeAsync(AuthorizeRequest req)
    {
        if (req.Amount <= 0) return Decline("13", "Invalid amount");
        if (!string.IsNullOrEmpty(req.Card.Expiry) && IsExpired(req.Card.Expiry)) return Decline("54", "Card expired");
        if (req.Amount > 999999) return Decline("61", "Exceeds limit");
        return Ok(new GatewayResponse
        {
            AuthorizationCode = GenAuth(), AuthorizedAmount = req.Amount, Currency = req.Currency,
            ResponseMessage = $"Approved {req.Amount:F2} {req.Currency}",
            AvsResult = "Y", CvvResult = "M", NetworkTransactionId = $"NTI{GenRef()[3..]}"
        });
    }

    public Task<GatewayResponse> CaptureAsync(CaptureRequest req)
    {
        if (string.IsNullOrEmpty(req.AuthorizationCode)) return Decline("12", "No authorization");
        var total = req.Amount + (req.TipAmount ?? 0);
        return Ok(new GatewayResponse { AuthorizationCode = req.AuthorizationCode, AuthorizedAmount = total, Currency = req.Currency, ResponseMessage = $"Captured {total:F2} {req.Currency}" });
    }

    public Task<GatewayResponse> VoidAsync(VoidRequest req)
    {
        if (string.IsNullOrEmpty(req.AuthorizationCode) && string.IsNullOrEmpty(req.ReferenceNumber)) return Decline("12", "No reference");
        return Ok(new GatewayResponse { ResponseMessage = $"Voided{(req.Reason is not null ? $": {req.Reason}" : "")}" });
    }

    public Task<GatewayResponse> RefundAsync(RefundRequest req)
    {
        var amt = req.PartialAmount ?? req.Amount;
        if (amt <= 0) return Decline("13", "Invalid amount");
        if (amt > req.Amount) return Decline("13", "Exceeds original");
        return Ok(new GatewayResponse { AuthorizedAmount = amt, Currency = req.Currency, ResponseMessage = $"Refunded {amt:F2} {req.Currency}{(req.Reason is not null ? $": {req.Reason}" : "")}" });
    }

    public Task<GatewayResponse> SettleAsync(SettleRequest req)
    {
        return Ok(new GatewayResponse { AuthorizedAmount = req.Amount, ResponseMessage = "Settled", Metadata = { ["BatchId"] = req.BatchId ?? $"BATCH{DateTimeOffset.UtcNow:yyyyMMdd}" } });
    }

    public Task<GatewayResponse> VerifyCardAsync(VerifyRequest req)
    {
        if (!string.IsNullOrEmpty(req.Card.Expiry) && IsExpired(req.Card.Expiry)) return Decline("54", "Card expired");
        return Ok(new GatewayResponse { AuthorizationCode = GenAuth(), AuthorizedAmount = 0, ResponseMessage = "Card verified (zero-auth)", AvsResult = "Y", CvvResult = "M" });
    }

    public Task<GatewayResponse> ChargeVaultAsync(ChargeVaultRequest req)
    {
        if (string.IsNullOrEmpty(req.Token) && string.IsNullOrEmpty(req.VaultId) && string.IsNullOrEmpty(req.Card.MaskedPan)) return Decline("14", "No card");
        if (req.Amount <= 0) return Decline("13", "Invalid amount");
        return Ok(new GatewayResponse
        {
            AuthorizationCode = GenAuth(), AuthorizedAmount = req.Amount, Currency = req.Currency,
            ResponseMessage = $"Vault charge {req.Amount:F2} {req.Currency}",
            NetworkTransactionId = $"NTI{GenRef()[3..]}",
            Metadata = req.IsRecurring ? new() { ["RecurringFlag"] = "Y", ["SubscriptionId"] = req.SubscriptionId ?? "" } : []
        });
    }

    public Task<GatewayResponse> IncrementalAuthAsync(IncrementalAuthRequest req)
    {
        if (string.IsNullOrEmpty(req.AuthorizationCode)) return Decline("12", "No authorization");
        if (req.AdditionalAmount <= 0) return Decline("13", "Invalid amount");
        return Ok(new GatewayResponse { AuthorizationCode = req.AuthorizationCode, AuthorizedAmount = req.AdditionalAmount, Currency = req.Currency, ResponseMessage = $"Incremental +{req.AdditionalAmount:F2} {req.Currency}" });
    }

    private static Task<GatewayResponse> Ok(GatewayResponse r) { r.Approved = true; r.ResponseCode = "00"; r.ReferenceNumber ??= GenRef(); r.ProcessedUtc = DateTimeOffset.UtcNow; return Task.FromResult(r); }
    private static Task<GatewayResponse> Decline(string code, string msg) => Task.FromResult(new GatewayResponse { Approved = false, ResponseCode = code, ResponseMessage = msg, ReferenceNumber = GenRef(), ProcessedUtc = DateTimeOffset.UtcNow });
    private static string GenAuth() => Convert.ToHexString(RandomNumberGenerator.GetBytes(3));
    private static string GenRef() => $"REF{DateTimeOffset.UtcNow:yyyyMMddHHmmss}{RandomNumberGenerator.GetInt32(1000, 9999)}";
    private static bool IsExpired(string exp) { if (exp.Length < 4 || !int.TryParse(exp[..2], out var y) || !int.TryParse(exp[2..4], out var m)) return false; return DateTimeOffset.UtcNow > new DateTimeOffset(2000 + y, m, 1, 0, 0, 0, TimeSpan.Zero).AddMonths(1); }
}
