using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.SharedUI.Pages;
public partial class SettingsPage
{
    [Inject]
    private IUserService UserService { get; set; } = null!;
    [Inject]
    private IKycVerificationService KycService { get; set; } = null!;
    [Inject]
    private ISubscriptionService SubscriptionService { get; set; } = null!;
    [Inject]
    private IInvoiceService InvoiceService { get; set; } = null!;
    [Inject]
    private IJSRuntime JsRuntime { get; set; } = null!;
    private string UserIdInput { get; set; } = string.Empty;
    private string DisplayName { get; set; } = string.Empty;
    private string AvatarUrl { get; set; } = string.Empty;
    private string Email { get; set; } = string.Empty;
    private string SaveStatus { get; set; } = string.Empty;
    private string NotificationPreference { get; set; } = SettingsConstants.DefaultNotificationPreference;
    private string NotificationEmail { get; set; } = string.Empty;
    private string PayoutMethod { get; set; } = SettingsConstants.DefaultPayoutMethod;
    private string PayoutDetails { get; set; } = string.Empty;
    private string PaymentMethod { get; set; } = SettingsConstants.DefaultPaymentMethod;
    private string TwoFactorMethod { get; set; } = SettingsConstants.DefaultTwoFactor;
    private string ProfileVisibility { get; set; } = SettingsConstants.DefaultVisibilityPublic;
    private string ActivityVisibility { get; set; } = SettingsConstants.DefaultVisibilityPublic;
    private string Timezone { get; set; } = SettingsConstants.DefaultTimezone;
    private string InvoiceSetting { get; set; } = SettingsConstants.DefaultEnabled;
    private string QrPaymentSetting { get; set; } = SettingsConstants.DefaultEnabled;
    private string KycDocumentType { get; set; } = string.Empty;
    private string KycDocumentId { get; set; } = string.Empty;
    private string KycMessage { get; set; } = string.Empty;
    private string KycStatusText => CurrentUser?.KycStatus.ToString() ?? SettingsConstants.KycNotVerified;
    private UserEntity? CurrentUser { get; set; }
    private IReadOnlyList<SubscriptionEntity> Subscriptions { get; set; } = [];
    private IReadOnlyList<InvoiceEntity> Invoices { get; set; } = [];
    private string DiditSessionId { get; set; } = string.Empty;
    private string DiditVerificationUrl { get; set; } = string.Empty;
    private string DiditStatus { get; set; } = string.Empty;
    protected override async Task OnAfterRenderAsync(bool FirstRender)
    {
        if (FirstRender)
        {
            var StoredId = await JsRuntime.InvokeAsync<string>(JsInteropConstants.GetUserId);
            if (string.IsNullOrEmpty(StoredId))
            {
                _ = await JsRuntime.InvokeAsync<string>(JsInteropConstants.CheckAuth);
                StoredId = await JsRuntime.InvokeAsync<string>(JsInteropConstants.GetUserId);
            }
            if (!string.IsNullOrEmpty(StoredId))
            {
                UserIdInput = StoredId;
                await LoadProfileAsync();
                StateHasChanged();
            }
            SaveStatus = string.Format(SettingsConstants.DebugFormat, StoredId ?? string.Empty, CurrentUser?.Id ?? string.Empty, CurrentUser?.LinkedProviders ?? string.Empty);
            StateHasChanged();
        }
    }
    private async Task LoadProfileAsync()
    {
        if (string.IsNullOrWhiteSpace(UserIdInput)) { return; }
        try
        {
            var Json = await JsRuntime.InvokeAsync<string>(JsInteropConstants.FetchUserById, UserIdInput);
            if (!string.IsNullOrEmpty(Json))
            {
                CurrentUser = System.Text.Json.JsonSerializer.Deserialize<UserEntity>(Json,
                    new System.Text.Json.JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            }
        }
        catch
        {
            CurrentUser = null;
        }
        if (CurrentUser is not null)
        {
            DisplayName = CurrentUser.DisplayName ?? string.Empty;
            AvatarUrl = CurrentUser.AvatarUrl ?? string.Empty;
            Email = CurrentUser.Email ?? string.Empty;
            NotificationPreference = CurrentUser.NotificationPreference;
            NotificationEmail = CurrentUser.NotificationEmail ?? string.Empty;
            PayoutMethod = CurrentUser.PayoutMethod;
            PayoutDetails = CurrentUser.PayoutDetails ?? string.Empty;
            PaymentMethod = CurrentUser.PaymentMethod;
            TwoFactorMethod = CurrentUser.TwoFactorMethod;
            ProfileVisibility = CurrentUser.ProfileVisibility;
            ActivityVisibility = CurrentUser.ActivityVisibility;
            Timezone = CurrentUser.Timezone;
            InvoiceSetting = CurrentUser.InvoiceSetting;
            QrPaymentSetting = CurrentUser.QrPaymentSetting;
            SaveStatus = string.Empty;
        }
        else
        {
            SaveStatus = SettingsConstants.UserNotFound;
            return;
        }
        Subscriptions = await SubscriptionService.ListSubscriptionsAsync(CurrentUser.Id, string.Empty);
        Invoices = await InvoiceService.ListInvoicesAsync(CurrentUser.Id);
    }
    private async Task SubmitKycAsync()
    {
        if (string.IsNullOrWhiteSpace(KycDocumentType) || string.IsNullOrWhiteSpace(KycDocumentId))
        {
            KycMessage = SettingsConstants.KycSelectDocumentAndId;
            return;
        }
        if (CurrentUser is not null)
        {
            CurrentUser.KycDocumentType = KycDocumentType;
            CurrentUser.KycDocumentId = KycDocumentId;
            CurrentUser.KycStatus = KycStatus.Pending;
            CurrentUser.KycSubmittedAt = DateTime.UtcNow;
            await UserService.UpdateAsync(CurrentUser);
        }
        KycMessage = SettingsConstants.KycSubmitted;
    }
    private async Task SaveSettingsAsync()
    {
        if (CurrentUser is null) { SaveStatus = SettingsConstants.LoadProfileFirst; return; }
        CurrentUser.DisplayName = string.IsNullOrWhiteSpace(DisplayName) ? null : DisplayName;
        CurrentUser.AvatarUrl = string.IsNullOrWhiteSpace(AvatarUrl) ? null : AvatarUrl;
        CurrentUser.Email = string.IsNullOrWhiteSpace(Email) ? null : Email;
        CurrentUser.NotificationPreference = NotificationPreference;
        CurrentUser.NotificationEmail = string.IsNullOrWhiteSpace(NotificationEmail) ? null : NotificationEmail;
        CurrentUser.PayoutMethod = PayoutMethod;
        CurrentUser.PayoutDetails = string.IsNullOrWhiteSpace(PayoutDetails) ? null : PayoutDetails;
        CurrentUser.PaymentMethod = PaymentMethod;
        CurrentUser.TwoFactorMethod = TwoFactorMethod;
        CurrentUser.ProfileVisibility = ProfileVisibility;
        CurrentUser.ActivityVisibility = ActivityVisibility;
        CurrentUser.Timezone = Timezone;
        CurrentUser.InvoiceSetting = InvoiceSetting;
        CurrentUser.QrPaymentSetting = QrPaymentSetting;
        await UserService.UpdateAsync(CurrentUser);
        SaveStatus = SettingsConstants.SettingsSaved;
    }
    private async Task StartDigitalVerificationAsync()
    {
        if (CurrentUser is null) { KycMessage = SettingsConstants.LoadProfileFirst; return; }
        var (Sid, Url) = await KycService.CreateSessionAsync(CurrentUser.Id, null);
        DiditSessionId = Sid; DiditVerificationUrl = Url;
        KycMessage = string.IsNullOrEmpty(Sid) ? SettingsConstants.DiditSessionFailed : SettingsConstants.DiditSessionCreated;
    }
    private async Task CheckDigitalStatusAsync()
    {
        if (string.IsNullOrEmpty(DiditSessionId)) { return; }
        var (Status, Name) = await KycService.GetSessionStatusAsync(DiditSessionId);
        DiditStatus = Status;
        KycMessage = string.IsNullOrEmpty(Name) ? Status : Name;
    }
    private string GoogleStatus => GetProviderStatus(SsoConstants.ProviderGoogle);
    private string GitHubStatus => GetProviderStatus(SsoConstants.ProviderGitHub);
    private string AzureStatus => GetProviderStatus(SsoConstants.ProviderAzure);
    private string OktaStatus => GetProviderStatus(SsoConstants.ProviderOkta);
    private string GoogleStatusClass => IsProviderLinked(SsoConstants.ProviderGoogle) ? SsoConstants.CssConnected : string.Empty;
    private string GitHubStatusClass => IsProviderLinked(SsoConstants.ProviderGitHub) ? SsoConstants.CssConnected : string.Empty;
    private string AzureStatusClass => IsProviderLinked(SsoConstants.ProviderAzure) ? SsoConstants.CssConnected : string.Empty;
    private string OktaStatusClass => IsProviderLinked(SsoConstants.ProviderOkta) ? SsoConstants.CssConnected : string.Empty;
    private bool IsProviderLinked(string Provider) =>
        CurrentUser?.LinkedProviders?.Contains(Provider, StringComparison.OrdinalIgnoreCase) == true;
    private string GetProviderStatus(string Provider) =>
        IsProviderLinked(Provider) ? SsoConstants.StatusConnected : SsoConstants.StatusNotConnected;
    private string GatewayQrPh { get; set; } = SettingsConstants.DefaultEnabled;
    private string GatewayCard { get; set; } = SettingsConstants.DefaultEnabled;
    private string GatewayGcash { get; set; } = SettingsConstants.DefaultDisabled;
    private string GatewayGrabPay { get; set; } = SettingsConstants.DefaultDisabled;
    private string GatewayMaya { get; set; } = SettingsConstants.DefaultDisabled;
    private string GatewayBank { get; set; } = SettingsConstants.DefaultEnabled;
    private string NewCardNumber { get; set; } = string.Empty;
    private int NewCardExpMonth { get; set; } = SettingsConstants.DefaultCardExpMonth;
    private int NewCardExpYear { get; set; } = SettingsConstants.DefaultCardExpYear;
    private string NewCardCvc { get; set; } = string.Empty;
    private string CardStatus { get; set; } = string.Empty;
    private List<SavedCardInfo> SavedCards { get; set; } = [];
    private Task AddCardAsync()
    {
        if (string.IsNullOrWhiteSpace(NewCardNumber) || string.IsNullOrWhiteSpace(NewCardCvc))
        {
            CardStatus = SettingsConstants.CardNumberCvcRequired;
            return Task.CompletedTask;
        }
        CardStatus = SettingsConstants.CardSavedSuccess;
        var Last4 = NewCardNumber.Length >= SettingsConstants.CardLast4Length
            ? NewCardNumber[^SettingsConstants.CardLast4Length..]
            : NewCardNumber;
        var Brand = NewCardNumber.StartsWith(SettingsConstants.VisaPrefix)
            ? SettingsConstants.VisaBrand
            : SettingsConstants.MastercardBrand;
        SavedCards.Add(new SavedCardInfo(Guid.NewGuid().ToString(), Last4, NewCardExpMonth, NewCardExpYear, Brand));
        NewCardNumber = string.Empty;
        NewCardCvc = string.Empty;
        return Task.CompletedTask;
    }
    private Task RemoveSavedCard(string CardId)
    {
        SavedCards.RemoveAll(C => C.Id == CardId);
        CardStatus = SettingsConstants.CardRemovedSuccess;
        return Task.CompletedTask;
    }
    internal sealed record SavedCardInfo(string Id, string Last4, int ExpMonth, int ExpYear, string Brand);
}
