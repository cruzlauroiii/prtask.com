namespace WillowMaze.Server;

internal class Transaction : IHasId
{
    public string Id { get; set; } = "";
    public string DeviceId { get; set; } = "";
    public string EventType { get; set; } = "";
    public string? AidHex { get; set; }
    public string? ResponsePreview { get; set; }
    public string? DeviceTimestamp { get; set; }
    public string? RawJson { get; set; }
    public string Status { get; set; } = "Pending";
    public string? CardBrand { get; set; }
    public decimal? Amount { get; set; }
    public string? Currency { get; set; }
    public string? CustomerId { get; set; }
    public string? SubscriptionId { get; set; }
    public string? VaultId { get; set; }
    public string? AuthorizationCode { get; set; }
    public string? ReferenceNumber { get; set; }
    public string? GatewayResponseCode { get; set; }
    public string? GatewayResponseMessage { get; set; }
    public string? GatewayToken { get; set; }
    public DateTimeOffset CreatedUtc { get; set; }
    public DateTimeOffset? UpdatedUtc { get; set; }
    public List<string> History { get; set; } = [];
}

internal class VaultedCard : IHasId
{
    public string Id { get; set; } = "";
    public string? TransactionId { get; set; }
    public string? AidHex { get; set; }
    public string? TokenMask { get; set; }
    public string? Fingerprint { get; set; }
    public string? CardBrand { get; set; }
    public string? Last4 { get; set; }
    public string? Expiry { get; set; }
    public string? CardholderName { get; set; }
    public string? GatewayToken { get; set; }
    public string? EmvData { get; set; }
    public string? CustomerId { get; set; }
    public string Status { get; set; } = "Active";
    public DateTimeOffset CreatedUtc { get; set; }
    public DateTimeOffset? UpdatedUtc { get; set; }
    public List<string> History { get; set; } = [];
}

internal class Customer : IHasId
{
    public string Id { get; set; } = "";
    public string Name { get; set; } = "";
    public string Email { get; set; } = "";
    public string Phone { get; set; } = "";
    public DateTimeOffset CreatedUtc { get; set; }
    public DateTimeOffset? UpdatedUtc { get; set; }
    public List<string> History { get; set; } = [];
}

internal class Subscription : IHasId
{
    public string Id { get; set; } = "";
    public string CustomerId { get; set; } = "";
    public string VaultId { get; set; } = "";
    public decimal Amount { get; set; }
    public string Currency { get; set; } = "PHP";
    public string Interval { get; set; } = "Monthly";
    public string Description { get; set; } = "";
    public string Status { get; set; } = "Active";
    public int ChargeCount { get; set; }
    public DateTimeOffset? NextChargeUtc { get; set; }
    public DateTimeOffset? LastChargedUtc { get; set; }
    public DateTimeOffset CreatedUtc { get; set; }
    public DateTimeOffset? UpdatedUtc { get; set; }
    public List<string> History { get; set; } = [];
}

internal class AuditEntry : IHasId
{
    public string Id { get; set; } = "";
    public string EntityType { get; set; } = "";
    public string EntityId { get; set; } = "";
    public string Action { get; set; } = "";
    public string? OldValue { get; set; }
    public string? NewValue { get; set; }
    public DateTimeOffset CreatedUtc { get; set; }
}
