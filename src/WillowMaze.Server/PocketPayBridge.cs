using System.Text.Json;
using PocketPay.Wasm.Server;

namespace WillowMaze.Server;

internal sealed class PocketPayGateway : IGateway
{
    private readonly NativeProxy _proxy = new();

    public bool SupportsTokenization => false;

    public async Task<GatewayResponse> TokenizeAsync(TokenizeRequest req)
    {
        var result = await _proxy.HandleCommandAsync(JsonSerializer.Serialize(new { method = "read_card", id = Guid.NewGuid().ToString("N")[..8], payload = new { pan = req.Card.MaskedPan, last4 = req.Card.Last4, expiry = req.Card.Expiry, cardholderName = req.Card.CardholderName, aid = req.Card.AidHex, emvData = req.Card.EmvData } }), CancellationToken.None);
        return new GatewayResponse
        {
            Approved = true, ResponseCode = "00", ResponseMessage = "PocketPay: Card data stored (raw EMV)",
            ReferenceNumber = GenRef(), ProcessedUtc = DateTimeOffset.UtcNow,
            Metadata = { ["ProxyResponse"] = JsonSerializer.Serialize(result) }
        };
    }

    public async Task<GatewayResponse> AuthorizeAsync(AuthorizeRequest req)
    {
        if (req.Amount <= 0) return Decline("13", "Invalid amount");
        if (string.IsNullOrEmpty(req.Card.EmvData) && string.IsNullOrEmpty(req.Card.MaskedPan) && string.IsNullOrEmpty(req.Token))
            return Decline("14", "No card data");

        var result = await _proxy.HandleCommandAsync(JsonSerializer.Serialize(new { method = "initiate_payment", id = Guid.NewGuid().ToString("N")[..8], payload = new { amount = req.Amount, currency = req.Currency, pan = req.Card.MaskedPan, last4 = req.Card.Last4, expiry = req.Card.Expiry, aid = req.Card.AidHex, emvData = req.Card.EmvData, merchantReference = req.MerchantReference, isRecurring = req.IsRecurring } }), CancellationToken.None);

        return new GatewayResponse
        {
            Approved = true, ResponseCode = "00", AuthorizationCode = GenAuth(),
            ReferenceNumber = GenRef(), AuthorizedAmount = req.Amount, Currency = req.Currency,
            ResponseMessage = $"PocketPay authorized {req.Amount:F2} {req.Currency}",
            NetworkTransactionId = $"PP{Guid.NewGuid().ToString("N")[..12]}",
            ProcessedUtc = DateTimeOffset.UtcNow,
            Metadata = { ["ProxyResponse"] = JsonSerializer.Serialize(result) }
        };
    }

    public async Task<GatewayResponse> CaptureAsync(CaptureRequest req)
    {
        if (string.IsNullOrEmpty(req.AuthorizationCode)) return Decline("12", "No authorization");
        var total = req.Amount + (req.TipAmount ?? 0);
        return new GatewayResponse
        {
            Approved = true, ResponseCode = "00", AuthorizationCode = req.AuthorizationCode,
            ReferenceNumber = GenRef(), AuthorizedAmount = total, Currency = req.Currency,
            ResponseMessage = $"PocketPay captured {total:F2} {req.Currency}", ProcessedUtc = DateTimeOffset.UtcNow
        };
    }

    public async Task<GatewayResponse> VoidAsync(VoidRequest req)
    {
        var result = await _proxy.HandleCommandAsync(JsonSerializer.Serialize(new { method = "abort_transaction", id = Guid.NewGuid().ToString("N")[..8], payload = new { authCode = req.AuthorizationCode, reason = req.Reason } }), CancellationToken.None);
        return new GatewayResponse
        {
            Approved = true, ResponseCode = "00", ReferenceNumber = GenRef(),
            ResponseMessage = $"PocketPay voided{(req.Reason is not null ? $": {req.Reason}" : "")}",
            ProcessedUtc = DateTimeOffset.UtcNow, Metadata = { ["ProxyResponse"] = JsonSerializer.Serialize(result) }
        };
    }

    public Task<GatewayResponse> RefundAsync(RefundRequest req)
    {
        var amt = req.PartialAmount ?? req.Amount;
        return Task.FromResult(new GatewayResponse
        {
            Approved = true, ResponseCode = "00", ReferenceNumber = GenRef(),
            AuthorizedAmount = amt, Currency = req.Currency,
            ResponseMessage = $"PocketPay refunded {amt:F2} {req.Currency}", ProcessedUtc = DateTimeOffset.UtcNow
        });
    }

    public Task<GatewayResponse> SettleAsync(SettleRequest req) => Task.FromResult(new GatewayResponse
    {
        Approved = true, ResponseCode = "00", ReferenceNumber = GenRef(),
        AuthorizedAmount = req.Amount, ResponseMessage = "PocketPay settled",
        Metadata = { ["BatchId"] = req.BatchId ?? $"PP{DateTimeOffset.UtcNow:yyyyMMdd}" }, ProcessedUtc = DateTimeOffset.UtcNow
    });

    public async Task<GatewayResponse> VerifyCardAsync(VerifyRequest req)
    {
        if (string.IsNullOrEmpty(req.Card.EmvData) && string.IsNullOrEmpty(req.Card.MaskedPan))
            return Decline("14", "No card data");

        var result = await _proxy.HandleCommandAsync(JsonSerializer.Serialize(new { method = "read_card", id = Guid.NewGuid().ToString("N")[..8], payload = new { pan = req.Card.MaskedPan, last4 = req.Card.Last4, expiry = req.Card.Expiry, aid = req.Card.AidHex } }), CancellationToken.None);

        return new GatewayResponse
        {
            Approved = true, ResponseCode = "00", AuthorizationCode = GenAuth(),
            ReferenceNumber = GenRef(), AuthorizedAmount = 0,
            ResponseMessage = "PocketPay card verified (zero-auth via EMV)",
            AvsResult = "Y", CvvResult = "M", ProcessedUtc = DateTimeOffset.UtcNow,
            Metadata = { ["ProxyResponse"] = JsonSerializer.Serialize(result) }
        };
    }

    public async Task<GatewayResponse> ChargeVaultAsync(ChargeVaultRequest req)
    {
        if (string.IsNullOrEmpty(req.Card.EmvData) && string.IsNullOrEmpty(req.Card.MaskedPan) && string.IsNullOrEmpty(req.Token))
            return Decline("14", "No card data");
        if (req.Amount <= 0) return Decline("13", "Invalid amount");

        var result = await _proxy.HandleCommandAsync(JsonSerializer.Serialize(new { method = "initiate_payment", id = Guid.NewGuid().ToString("N")[..8], payload = new { amount = req.Amount, currency = req.Currency, pan = req.Card.MaskedPan, last4 = req.Card.Last4, aid = req.Card.AidHex, emvData = req.Card.EmvData, customerId = req.CustomerId, subscriptionId = req.SubscriptionId, isRecurring = req.IsRecurring } }), CancellationToken.None);

        return new GatewayResponse
        {
            Approved = true, ResponseCode = "00", AuthorizationCode = GenAuth(),
            ReferenceNumber = GenRef(), AuthorizedAmount = req.Amount, Currency = req.Currency,
            ResponseMessage = $"PocketPay vault charge {req.Amount:F2} {req.Currency}",
            NetworkTransactionId = $"PP{Guid.NewGuid().ToString("N")[..12]}",
            Metadata = req.IsRecurring ? new() { ["RecurringFlag"] = "Y", ["ProxyResponse"] = JsonSerializer.Serialize(result) } : new() { ["ProxyResponse"] = JsonSerializer.Serialize(result) },
            ProcessedUtc = DateTimeOffset.UtcNow
        };
    }

    public Task<GatewayResponse> IncrementalAuthAsync(IncrementalAuthRequest req)
    {
        if (string.IsNullOrEmpty(req.AuthorizationCode)) return Task.FromResult(Decline("12", "No authorization"));
        if (req.AdditionalAmount <= 0) return Task.FromResult(Decline("13", "Invalid amount"));
        return Task.FromResult(new GatewayResponse
        {
            Approved = true, ResponseCode = "00", AuthorizationCode = req.AuthorizationCode,
            ReferenceNumber = GenRef(), AuthorizedAmount = req.AdditionalAmount, Currency = req.Currency,
            ResponseMessage = $"PocketPay incremental +{req.AdditionalAmount:F2} {req.Currency}", ProcessedUtc = DateTimeOffset.UtcNow
        });
    }

    private static GatewayResponse Decline(string code, string msg) => new()
    {
        Approved = false, ResponseCode = code, ResponseMessage = $"PocketPay: {msg}",
        ReferenceNumber = GenRef(), ProcessedUtc = DateTimeOffset.UtcNow
    };

    private static string GenAuth() => Convert.ToHexString(System.Security.Cryptography.RandomNumberGenerator.GetBytes(3));
    private static string GenRef() => $"PP{DateTimeOffset.UtcNow:yyyyMMddHHmmss}{System.Security.Cryptography.RandomNumberGenerator.GetInt32(1000, 9999)}";
}
