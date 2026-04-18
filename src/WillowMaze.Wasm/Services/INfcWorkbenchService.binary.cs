using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

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
    Nullable<bool> IsTagIntentAllowed { get; }
    bool SupportsReaderOption { get; }
    bool IsReaderOptionEnabled { get; }
    bool SupportsSecureNfc { get; }
    bool IsSecureNfcEnabled { get; }
    bool SupportsAidPrefixRegistration { get; }
    bool AllowsOtherCategoryForegroundPreference { get; }
    bool IsPreferredService { get; }
    bool HasCustomDiscoveryTechnology { get; }
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
    NdefWriteDraft PendingWrite { get; }
    NfcTagSnapshot LatestTag { get; }
    Tag LatestNfcTag { get; }
    IReadOnlyList<string> CapabilityNotes { get; }
    IReadOnlyList<string> AntennaFacts { get; }
    IReadOnlyList<string> RawEvents { get; }
    IReadOnlyList<string> HceEvents { get; }
    IReadOnlyList<string> HceFEvents { get; }
    IReadOnlyList<string> RegisteredHceAids { get; }
    IReadOnlyList<string> PollingFilters { get; }
    IReadOnlyList<string> PollingPatternFilters { get; }
    string MifareClassicDumpJsonl { get; }
    string MifareUltralightDumpJsonl { get; }
    string ForegroundDispatchJsonl { get; }
    string AdapterStateJsonl { get; }
    string SeTransactionJsonl { get; }
    string NfcEventCallbackJsonl { get; }
    string AidManagementJsonl { get; }
    bool IsDefaultServiceForCategory { get; }
    bool IsDefaultServiceForAid { get; }
    string SelectionModeForCategory { get; }
    IReadOnlyList<string> RegisteredSystemAids { get; }
    IReadOnlyList<string> AdapterStateEvents { get; }
    IReadOnlyList<string> SeTransactionEvents { get; }

    event EventHandler Changed;

    Task ArmWriteAsync(NdefWriteDraft draft);
    Task ClearWriteAsync();
    Task OpenNfcSettingsAsync();
    Task OpenTagRoutingAsync();
    Task RefreshAsync();
    Task SendRawAsync(string technologyName, string commandHex);
    Task IgnoreCurrentTagAsync(int debounceMs);
    Task SetObserveModeEnabledAsync(bool enabled);
    Task SetDefaultObserveModeAsync(bool enabled);
    Task SetPreferredServiceAsync(bool prefer);
    Task SetHceFEnabledAsync(bool enabled);
    Task SetDiscoveryTechnologyAsync(NfcReaderFlags pollFlags, NfcListenFlags listenFlags);
    Task ResetDiscoveryTechnologyAsync();
    Task RegisterHceAidsAsync(string rawAidText);
    Task ClearHceAidsAsync();
    Task AddPollingFilterAsync(string filterHex, bool autoTransact);
    Task RemovePollingFilterAsync(string filterHex);
    Task AddPollingPatternFilterAsync(string pattern, bool autoTransact);
    Task RemovePollingPatternFilterAsync(string pattern);
    Task StartReaderAsync();
    Task StopReaderAsync();
    Task UpdateHceResponseAsync(string responseText);
    Task UpdateHceFResponseAsync(string responseText);
    Task FormatTagAsync();
    Task ToggleForegroundDispatchAsync(bool enabled);
    Task ReadMifareClassicSectorAsync(int sectorIndex, string keyHex, bool useKeyB);
    Task ReadMifareUltralightPageRangeAsync(int startPage, int count);
    Task MifareClassicWriteBlockAsync(int blockIndex, string dataHex, int authSector, string keyHex, bool useKeyB);
    Task MifareClassicIncrementAsync(int blockIndex, int value, int authSector, string keyHex, bool useKeyB);
    Task MifareClassicDecrementAsync(int blockIndex, int value, int authSector, string keyHex, bool useKeyB);
    Task MifareClassicTransferAsync(int blockIndex, int authSector, string keyHex, bool useKeyB);
    Task MifareClassicRestoreAsync(int blockIndex, int authSector, string keyHex, bool useKeyB);
    Task MifareUltralightWritePageAsync(int pageIndex, string dataHex);
    Task MifareUltralightPwdAuthAsync(string passwordHex);
    Task SetTechTimeoutAsync(string technologyName, int timeoutMs);
    Task RegisterSystemAidsAsync(string category, string aidListText);
    Task RemoveSystemAidsAsync(string category);
    Task QuerySystemAidsAsync(string category);
}
