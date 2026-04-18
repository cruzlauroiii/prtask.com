namespace PrTask.Domain.Models;
public class UserEntity
{
    public required string Id { get; init; }
    public long GitHubId { get; init; }
    public string GitHubUsername { get; set; } = string.Empty;
    public string? DisplayName { get; set; }
    public string? AvatarUrl { get; set; }
    public string? Email { get; set; }
    public UserRole Role { get; set; } = UserRole.Developer;
    public string? MayaCustomerId { get; set; }
    public long TotalEarnedCents { get; set; }
    public long TotalSpentCents { get; set; }
    public int Xp { get; set; }
    public int Level { get; set; } = 1;
    public int StreakDays { get; set; }
    public KycStatus KycStatus { get; set; }
    public DateTime? KycVerifiedAt { get; set; }
    public string LinkedProviders { get; set; } = string.Empty;
    public string NotificationPreference { get; set; } = string.Empty;
    public string? NotificationEmail { get; set; }
    public string PayoutMethod { get; set; } = string.Empty;
    public string? PayoutDetails { get; set; }
    public string PaymentMethod { get; set; } = string.Empty;
    public string TwoFactorMethod { get; set; } = string.Empty;
    public string ProfileVisibility { get; set; } = string.Empty;
    public string ActivityVisibility { get; set; } = string.Empty;
    public string Timezone { get; set; } = string.Empty;
    public string InvoiceSetting { get; set; } = string.Empty;
    public string QrPaymentSetting { get; set; } = string.Empty;
    public string? KycDocumentType { get; set; }
    public string? KycDocumentId { get; set; }
    public DateTime? KycSubmittedAt { get; set; }
    public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}
