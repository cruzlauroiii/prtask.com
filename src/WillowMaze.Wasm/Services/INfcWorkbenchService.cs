using WillowMaze.Wasm.Models;

namespace WillowMaze.Wasm.Services;

public interface INfcWorkbenchService
{
    bool IsSupported { get; }
    bool IsEnabled { get; }
    bool IsListening { get; }
    bool IsForegroundDispatchEnabled { get; }
    bool SupportsHce { get; }
    bool SupportsNfcFCardEmulation { get; }
    bool IsHceFEnabled { get; }
    bool SupportsObserveMode { get; }
    bool IsObserveModeEnabled { get; }
    bool ShouldDefaultToObserveMode { get; }
    bool SupportsTagIntentPreference { get; }
    bool? IsTagIntentAllowed { get; }
    bool SupportsReaderOption { get; }
    bool IsReaderOptionEnabled { get; }
    bool SupportsSecureNfc { get; }
    bool IsSecureNfcEnabled { get; }
    bool SupportsAidPrefixRegistration { get; }
    bool AllowsOtherCategoryForegroundPreference { get; }
    bool IsPreferredService { get; }
    bool HasCustomDiscoveryTechnology { get; }
    bool IsWssConnected { get; }
    bool HasWebNfc { get; }
    int DefaultNfcSubscriptionId { get; }
    string StatusText { get; }
    string LastWriteStatus { get; }
    string LastRawStatus { get; }
    string DiscoveryStatusText { get; }
    string PreferredPaymentDescription { get; }
    string PreferredPaymentRoute { get; }
    string LastIntentAction { get; }
    string HceAidHex { get; }
    string HceStatusText { get; }
    string HceResponseText { get; }
    string HceFSystemCodeHex { get; }
    string HceFNfcid2Hex { get; }
    string HceFT3tPmmHex { get; }
    string HceFStatusText { get; }
    string HceFResponseText { get; }
    string ObserveModeStatusText { get; }
    string AdapterSnapshotJson { get; }
    string LatestTagJsonl { get; }
    string SessionJsonl { get; }
    string HceJsonl { get; }
    string HceFJsonl { get; }
    string RawJsonl { get; }
    string WssUrl { get; }
    NdefWriteDraft? PendingWrite { get; }
    NfcTagSnapshot? LatestTag { get; }
    IReadOnlyList<string> CapabilityNotes { get; }
    IReadOnlyList<string> AntennaFacts { get; }
    IReadOnlyList<string> RawEvents { get; }
    IReadOnlyList<string> HceEvents { get; }
    IReadOnlyList<string> HceFEvents { get; }
    IReadOnlyList<string> RegisteredHceAids { get; }
    IReadOnlyList<string> PollingFilters { get; }
    IReadOnlyList<string> PollingPatternFilters { get; }
    event EventHandler? Changed;
    Task InitializeAsync();
    Task ArmWriteAsync(NdefWriteDraft Draft);
    Task ClearWriteAsync();
    Task OpenNfcSettingsAsync();
    Task OpenTagRoutingAsync();
    Task RefreshAsync();
    Task SendRawAsync(string TechnologyName, string CommandHex);
    Task IgnoreCurrentTagAsync(int DebounceMs);
    Task SetObserveModeEnabledAsync(bool Enabled);
    Task SetDefaultObserveModeAsync(bool Enabled);
    Task SetPreferredServiceAsync(bool Prefer);
    Task SetHceFEnabledAsync(bool Enabled);
    Task SetDiscoveryTechnologyAsync(int PollFlags, int ListenFlags);
    Task ResetDiscoveryTechnologyAsync();
    Task RegisterHceAidsAsync(string RawAidText);
    Task ClearHceAidsAsync();
    Task AddPollingFilterAsync(string FilterHex, bool AutoTransact);
    Task RemovePollingFilterAsync(string FilterHex);
    Task AddPollingPatternFilterAsync(string Pattern, bool AutoTransact);
    Task RemovePollingPatternFilterAsync(string Pattern);
    Task StartReaderAsync();
    Task StopReaderAsync();
    Task UpdateHceResponseAsync(string ResponseText);
    Task UpdateHceFResponseAsync(string ResponseText);
    Task ConnectWssAsync(string Url);
    Task DisconnectWssAsync();
}
