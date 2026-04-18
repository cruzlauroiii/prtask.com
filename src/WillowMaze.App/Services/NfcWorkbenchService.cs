using System.Text;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Nfc;
using Android.Nfc.CardEmulators;
using Android.Nfc.Tech;
using Android.OS;
using Android.Provider;
using Microsoft.Maui.ApplicationModel;
using WillowMaze.App.Models;

namespace WillowMaze.App.Services;

internal sealed class NfcWorkbenchService : Java.Lang.Object, INfcWorkbenchService, NfcAdapter.IReaderCallback
{
    private const NfcReaderFlags ReaderFlags =
        NfcReaderFlags.NfcA
        | NfcReaderFlags.NfcB
        | NfcReaderFlags.NfcF
        | NfcReaderFlags.NfcV
        | NfcReaderFlags.NfcBarcode
        | NfcReaderFlags.SkipNdefCheck
        | NfcReaderFlags.NoPlatformSounds;

    private static readonly string[] UriPrefixes =
    [
        string.Empty, "http://www.", "https://www.", "http://", "https://", "tel:", "mailto:",
        "ftp://anonymous:anonymous@", "ftp://ftp.", "ftps://", "sftp://", "smb://", "nfs://", "ftp://",
        "dav://", "news:", "telnet://", "imap:", "rtsp://", "urn:", "pop:", "sip:", "sips:", "tftp:",
        "btspp://", "btl2cap://", "btgoep://", "tcpobex://", "irdaobex://", "file://", "urn:epc:id:",
        "urn:epc:tag:", "urn:epc:pat:", "urn:epc:raw:", "urn:epc:", "urn:nfc:"
    ];

    private static readonly byte[] MifareKeyDefault = [0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF];
    private static readonly byte[] MifareKeyMad = [0xA0, 0xA1, 0xA2, 0xA3, 0xA4, 0xA5];
    private static readonly byte[] MifareKeyNfcForum = [0xD3, 0xF7, 0xD3, 0xF7, 0xD3, 0xF7];

    private readonly Bundle readerOptions = new();
    private readonly List<string> capabilityNotes = [];
    private readonly List<string> antennaFacts = [];
    private readonly List<string> rawEvents = [];
    private readonly SemaphoreSlim ioGate = new(1, 1);
    private readonly List<string> sessionJsonlEntries = [];
    private readonly List<string> rawJsonlEntries = [];
    private readonly List<string> mifareClassicJsonlEntries = [];
    private readonly List<string> mifareUltralightJsonlEntries = [];
    private readonly List<string> foregroundDispatchJsonlEntries = [];
    private readonly List<string> pollingFilterEntries = [];
    private readonly List<string> pollingPatternFilterEntries = [];
    private NfcAdapter? adapter;
    private CardEmulation? cardEmulationInstance;
    private NfcFCardEmulation? nfcFCardEmulation;
    private Tag? latestTagHandle;
    private bool hasCustomDiscoveryTechnology;
    private PendingIntent? foregroundPendingIntent;
    private IntentFilter[]? foregroundIntentFilters;
    private string[][]? foregroundTechLists;
    private readonly List<string> adapterStateJsonlEntries = [];
    private readonly List<string> seTransactionJsonlEntries = [];
    private readonly List<string> nfcEventCallbackJsonlEntries = [];
    private readonly List<string> aidManagementJsonlEntries = [];
    private readonly List<string> adapterStateEvents = [];
    private readonly List<string> seTransactionEvents = [];
    private BroadcastReceiver? adapterStateReceiver;
    private BroadcastReceiver? seTransactionReceiver;
    private BroadcastReceiver? preferredPaymentReceiver;

    public NfcWorkbenchService()
    {
        readerOptions.PutInt(NfcAdapter.ExtraReaderPresenceCheckDelay, 150);
        StatusText = "🧭 Refresh the board, then start reader mode when you want to scan.";
        LastWriteStatus = "✍️ No write armed yet.";
        LastRawStatus = "🧪 Tap a tag, keep it in field, then send a raw hex frame.";
        HceStatusText = "🪪 Demo applet is idle.";
        HceFStatusText = "🧩 Demo NFC-F applet is idle.";
        ObserveModeStatusText = "👀 Observe mode is idle.";
        RegisterBroadcastReceivers();
        HceAppletRuntime.Changed += HandleHceChanged;
        HceFAppletRuntime.Changed += HandleHceChanged;
        SyncHceState();
    }

    public bool IsSupported { get; private set; }
    public bool IsEnabled { get; private set; }
    public bool IsListening { get; private set; }
    public bool SupportsHce { get; private set; }
    public bool SupportsNfcFCardEmulation { get; private set; }
    public bool IsHceFEnabled { get; private set; }
    public bool SupportsObserveMode { get; private set; }
    public bool IsObserveModeEnabled { get; private set; }
    public bool SupportsTagIntentPreference { get; private set; }
    public bool? IsTagIntentAllowed { get; private set; }
    public bool IsPreferredService { get; private set; }
    public string StatusText { get; private set; }
    public string LastWriteStatus { get; private set; }
    public string LastRawStatus { get; private set; }
    public string HceAidHex => FormatHex(HceAppletRuntime.AidHex);
    public string HceStatusText { get; private set; }
    public string HceResponseText { get; private set; } = HceAppletRuntime.ResponseText;
    public string HceFSystemCodeHex => FormatHex(HceFAppletRuntime.SystemCodeHex);
    public string HceFNfcid2Hex => FormatHex(HceFAppletRuntime.Nfcid2Hex);
    public string HceFStatusText { get; private set; }
    public string HceFResponseText { get; private set; } = HceFAppletRuntime.ResponseText;
    public string ObserveModeStatusText { get; private set; }
    public NdefWriteDraft? PendingWrite { get; private set; }
    public NfcTagSnapshot? LatestTag { get; private set; }
    public Tag? LatestNfcTag { get; private set; }
    public IReadOnlyList<string> CapabilityNotes => capabilityNotes;
    public IReadOnlyList<string> AntennaFacts => antennaFacts;
    public IReadOnlyList<string> RawEvents => rawEvents;
    public IReadOnlyList<string> HceEvents { get; private set; } = [];
    public IReadOnlyList<string> HceFEvents { get; private set; } = [];
    public bool IsForegroundDispatchEnabled { get; private set; }
    public bool ShouldDefaultToObserveMode { get; private set; }
    public bool SupportsReaderOption { get; private set; }
    public bool IsReaderOptionEnabled { get; private set; }
    public bool SupportsSecureNfc { get; private set; }
    public bool IsSecureNfcEnabled { get; private set; }
    public bool SupportsAidPrefixRegistration { get; private set; }
    public bool AllowsOtherCategoryForegroundPreference { get; private set; }
    public bool HasCustomDiscoveryTechnology => hasCustomDiscoveryTechnology;
    public int DefaultNfcSubscriptionId { get; private set; }
    public string DiscoveryStatusText { get; private set; } = "🔍 Default discovery settings are active.";
    public string PreferredPaymentDescription { get; private set; } = "(none)";
    public string PreferredPaymentRoute { get; private set; } = "(none)";
    public string LastIntentAction { get; private set; } = "(none)";
    public string HceFT3tPmmHex => FormatHex(HceFAppletRuntime.T3tPmmHex);

    public string AdapterSnapshotJson => BuildAdapterSnapshotJson();

    public string LatestTagJsonl => LatestTag is not null
        ? NfcJson.Line("tag", "snapshot", new
        {
            LatestTag.Summary,
            LatestTag.IdentifierHex,
            LatestTag.CardType,
            LatestTag.Manufacturer,
            LatestTag.Technologies,
            Records = LatestTag.Records.Select(static r => new
            {
                r.Icon,
                r.Kind,
                r.Summary,
                r.PayloadHex,
                r.LanguageCode,
                r.Encoding,
                r.TypeHex,
                r.IdHex,
                r.Tnf,
                SubRecords = r.SubRecords.Select(static s => new { s.Icon, s.Kind, s.Summary, s.PayloadHex })
            }),
            LatestTag.Details,
            MifareClassicSectors = LatestTag.MifareClassicSectors.Select(static s => new
            {
                s.SectorIndex,
                s.FirstBlock,
                s.KeyUsed,
                Blocks = s.Blocks.Select(static b => new { b.BlockIndex, b.DataHex, b.Plaintext, b.BlockType })
            }),
            MifareUltralightPages = LatestTag.MifareUltralightPages.Select(static p => new
            {
                p.PageIndex,
                p.DataHex,
                p.Plaintext,
                p.PageType
            }),
            LatestTag.WriteOutcome,
            LatestTag.CapturedAtUtc
        })
        : string.Empty;

    public string SessionJsonl => NfcJson.Join(sessionJsonlEntries);
    public string HceJsonl => HceAppletRuntime.Jsonl;
    public string HceFJsonl => HceFAppletRuntime.Jsonl;
    public string RawJsonl => NfcJson.Join(rawJsonlEntries);
    public string MifareClassicDumpJsonl => NfcJson.Join(mifareClassicJsonlEntries);
    public string MifareUltralightDumpJsonl => NfcJson.Join(mifareUltralightJsonlEntries);
    public string ForegroundDispatchJsonl => NfcJson.Join(foregroundDispatchJsonlEntries);
    public IReadOnlyList<string> RegisteredHceAids => HceAppletRuntime.EffectiveAids;
    public IReadOnlyList<string> PollingFilters => pollingFilterEntries;
    public IReadOnlyList<string> PollingPatternFilters => pollingPatternFilterEntries;
    public string AdapterStateJsonl => NfcJson.Join(adapterStateJsonlEntries);
    public string SeTransactionJsonl => NfcJson.Join(seTransactionJsonlEntries);
    public string NfcEventCallbackJsonl => NfcJson.Join(nfcEventCallbackJsonlEntries);
    public string AidManagementJsonl => NfcJson.Join(aidManagementJsonlEntries);
    public bool IsDefaultServiceForCategory { get; private set; }
    public bool IsDefaultServiceForAid { get; private set; }
    public string SelectionModeForCategory { get; private set; } = "(none)";
    public IReadOnlyList<string> RegisteredSystemAids { get; private set; } = [];
    public IReadOnlyList<string> AdapterStateEvents => adapterStateEvents;
    public IReadOnlyList<string> SeTransactionEvents => seTransactionEvents;

    public event EventHandler? Changed;

    public Task RefreshAsync()
    {
        return MainThread.InvokeOnMainThreadAsync(() =>
        {
            adapter = ResolveAdapter();
            var packageManager = Platform.AppContext.PackageManager;

            IsSupported = adapter is not null;
            IsEnabled = adapter?.IsEnabled ?? false;
            SupportsHce = packageManager?.HasSystemFeature(PackageManager.FeatureNfcHostCardEmulation) ?? false;
            SupportsNfcFCardEmulation = packageManager?.HasSystemFeature(PackageManager.FeatureNfcHostCardEmulationNfcf) ?? false;
            SupportsObserveMode = adapter?.IsObserveModeSupported ?? false;
            IsObserveModeEnabled = adapter?.IsObserveModeEnabled ?? false;
            SupportsTagIntentPreference = adapter?.IsTagIntentAppPreferenceSupported ?? false;
            IsTagIntentAllowed = SupportsTagIntentPreference ? adapter?.IsTagIntentAllowed : null;
            nfcFCardEmulation = SupportsNfcFCardEmulation && adapter is not null ? NfcFCardEmulation.GetInstance(adapter) : null;
            SupportsSecureNfc = adapter?.IsSecureNfcSupported ?? false;
            IsSecureNfcEnabled = SupportsSecureNfc && (adapter?.IsSecureNfcEnabled ?? false);
            SupportsReaderOption = adapter?.IsReaderOptionSupported ?? false;
            IsReaderOptionEnabled = SupportsReaderOption && (adapter?.IsReaderOptionEnabled ?? false);

            cardEmulationInstance = SupportsHce && adapter is not null ? CardEmulation.GetInstance(adapter) : null;
            SupportsAidPrefixRegistration = cardEmulationInstance is not null && cardEmulationInstance.SupportsAidPrefixRegistration();
            AllowsOtherCategoryForegroundPreference = cardEmulationInstance is not null && cardEmulationInstance.CategoryAllowsForegroundPreference(CardEmulation.CategoryOther);

            try
            {
                DefaultNfcSubscriptionId = cardEmulationInstance?.DefaultNfcSubscriptionId ?? -1;
            }
            catch
            {
                DefaultNfcSubscriptionId = -1;
            }

            try
            {
                var paymentDesc = cardEmulationInstance?.DescriptionForPreferredPaymentService;
                PreferredPaymentDescription = paymentDesc?.ToString() ?? "(none)";
            }
            catch
            {
                PreferredPaymentDescription = "(unavailable)";
            }

            try
            {
                if (cardEmulationInstance is not null)
                {
                    var route = cardEmulationInstance.RouteDestinationForPreferredPaymentService;
                    PreferredPaymentRoute = route switch
                    {
                        "DH" or "0" => "DH (device host)",
                        "UICC" or "1" => "UICC",
                        "ESE" or "2" => "eSE",
                        _ => route?.ToString() ?? "(none)"
                    };
                }
                else
                {
                    PreferredPaymentRoute = "(none)";
                }
            }
            catch
            {
                PreferredPaymentRoute = "(unavailable)";
            }

            capabilityNotes.Clear();
            antennaFacts.Clear();

            if (!IsSupported)
            {
                IsListening = false;
                StatusText = "🚫 This device does not expose Android NFC.";
                capabilityNotes.Add("📵 No default NFC adapter was found.");
            }
            else if (!IsEnabled)
            {
                IsListening = false;
                StatusText = "⚠️ NFC is off in system settings.";
                capabilityNotes.Add("⚡ Turn NFC on before starting reader mode.");
            }
            else if (IsListening)
            {
                StatusText = "📡 Reader mode is live. Tap a tag near the antenna.";
            }
            else
            {
                StatusText = "⏸️ Reader mode is paused. Card emulation can answer while paused.";
            }

            capabilityNotes.Add(SupportsHce
                ? "🪪 Host card emulation is available for custom protocols."
                : "🚫 Host card emulation is not available on this device.");
            capabilityNotes.Add(SupportsNfcFCardEmulation
                ? "🇯🇵 NFC-F host card emulation is available for your own protocol."
                : "🧩 NFC-F host card emulation is not reported by the device.");
            capabilityNotes.Add(SupportsObserveMode
                ? "👀 Observe mode is supported by the adapter."
                : "🫥 Observe mode is not reported by the adapter.");

            if (SupportsTagIntentPreference)
            {
                capabilityNotes.Add(IsTagIntentAllowed == true
                    ? "🛣️ Tag intent delivery is currently allowed."
                    : "🚧 Tag intent delivery is currently restricted by user preference.");
            }
            else
            {
                capabilityNotes.Add("🧭 Tag intent preference controls are not exposed here.");
            }

            capabilityNotes.Add(SupportsSecureNfc
                ? IsSecureNfcEnabled
                    ? "🔐 Secure NFC is supported and currently enabled."
                    : "🔓 Secure NFC is supported but currently disabled."
                : "🔐 Secure NFC is not reported by this adapter.");

            capabilityNotes.Add(SupportsReaderOption
                ? IsReaderOptionEnabled
                    ? "📖 Reader option is supported and currently enabled."
                    : "📖 Reader option is supported but currently disabled."
                : "📖 Reader option is not reported by this adapter.");

            if (SupportsAidPrefixRegistration)
            {
                capabilityNotes.Add("🔀 AID prefix registration is supported (wildcard AID matching).");
            }

            if (AllowsOtherCategoryForegroundPreference)
            {
                capabilityNotes.Add("🪪 The 'other' AID category allows foreground preference on this device.");
            }

            if (DefaultNfcSubscriptionId >= 0)
            {
                capabilityNotes.Add($"📡 Default NFC subscription ID • {DefaultNfcSubscriptionId}");
            }

            if (packageManager?.HasSystemFeature(PackageManager.FeatureNfcOffHostCardEmulationEse) == true
                || packageManager?.HasSystemFeature(PackageManager.FeatureNfcOffHostCardEmulationUicc) == true)
            {
                capabilityNotes.Add("🔐 Off-host secure element hardware exists, but normal apps cannot directly drive it.");
            }

            if (IsForegroundDispatchEnabled)
            {
                capabilityNotes.Add("📡 Foreground dispatch is enabled alongside reader mode.");
            }

            AppendAntennaFacts(adapter);

            SyncHceState();
            RaiseChanged();
        });
    }

    public Task StartReaderAsync()
    {
        return MainThread.InvokeOnMainThreadAsync(() =>
        {
            adapter = ResolveAdapter();
            IsSupported = adapter is not null;
            IsEnabled = adapter?.IsEnabled ?? false;

            if (!IsSupported)
            {
                IsListening = false;
                StatusText = "🚫 NFC hardware is unavailable.";
                RaiseChanged();
                return;
            }

            if (!IsEnabled)
            {
                IsListening = false;
                StatusText = "⚠️ NFC is off. Open Android settings and turn it on first.";
                RaiseChanged();
                return;
            }

            if (Platform.CurrentActivity is not Activity activity)
            {
                IsListening = false;
                StatusText = "⌛ The Android activity is not ready yet.";
                RaiseChanged();
                return;
            }

            var currentAdapter = adapter!;

            if (IsObserveModeEnabled)
            {
                _ = currentAdapter.SetObserveModeEnabled(false);
                IsObserveModeEnabled = false;
            }

            currentAdapter.EnableReaderMode(activity, this, ReaderFlags, readerOptions);
            IsListening = true;
            StatusText = PendingWrite is null
                ? "📡 Reader mode is live. Tap a tag to inspect it."
                : $"🪄 Reader mode is live. Next tap will try to write: {PendingWrite.Summary}";
            if (IsPreferredService)
            {
                HceStatusText = "🪪 Preferred HCE service is set, but reader mode temporarily suppresses card emulation.";
            }

            RaiseChanged();
        });
    }

    public Task StopReaderAsync()
    {
        return MainThread.InvokeOnMainThreadAsync(() =>
        {
            adapter ??= ResolveAdapter();
            if (adapter is not null && Platform.CurrentActivity is Activity activity)
            {
                adapter.DisableReaderMode(activity);
            }

            IsListening = false;
            StatusText = IsSupported && IsEnabled
                ? "⏸️ Reader mode paused."
                : "⚠️ Reader mode stopped.";
            SyncHceState();
            RaiseChanged();
        });
    }

    public Task OpenNfcSettingsAsync() => LaunchIntentAsync(new Intent(Settings.ActionNfcSettings));
    public Task OpenTagRoutingAsync() => LaunchIntentAsync(new Intent(NfcAdapter.ActionChangeTagIntentPreference));

    public Task ArmWriteAsync(NdefWriteDraft draft)
    {
        return MainThread.InvokeOnMainThreadAsync(() =>
        {
            PendingWrite = draft with { Content = draft.Content.Trim(), MimeType = draft.NormalizedMimeType };
            LastWriteStatus = $"🪄 Armed next write • {PendingWrite.Summary}";
            if (IsListening)
            {
                StatusText = $"📡 Reader mode is live. Next tap will try to write: {PendingWrite.Summary}";
            }

            RaiseChanged();
        });
    }

    public Task ClearWriteAsync()
    {
        return MainThread.InvokeOnMainThreadAsync(() =>
        {
            PendingWrite = null;
            LastWriteStatus = "🧹 Pending write cleared.";
            if (IsListening)
            {
                StatusText = "📡 Reader mode is live. Tap a tag to inspect it.";
            }

            RaiseChanged();
        });
    }

    public Task UpdateHceResponseAsync(string responseText)
    {
        return MainThread.InvokeOnMainThreadAsync(() =>
        {
            HceAppletRuntime.UpdateResponseText(responseText);
            SyncHceState();
            RaiseChanged();
        });
    }

    public Task UpdateHceFResponseAsync(string responseText)
    {
        return MainThread.InvokeOnMainThreadAsync(() =>
        {
            HceFAppletRuntime.UpdateResponseText(responseText);
            SyncHceState();
            RaiseChanged();
        });
    }

    public Task SetPreferredServiceAsync(bool prefer)
    {
        return MainThread.InvokeOnMainThreadAsync(() =>
        {
            adapter ??= ResolveAdapter();
            if (!SupportsHce || adapter is null)
            {
                HceStatusText = "🚫 HCE is not available on this device.";
                RaiseChanged();
                return;
            }

            if (Platform.CurrentActivity is not Activity activity)
            {
                HceStatusText = "⌛ Foreground activity is unavailable.";
                RaiseChanged();
                return;
            }

            var cardEmulation = CardEmulation.GetInstance(adapter);
            if (cardEmulation is null)
            {
                HceStatusText = "🚫 Android did not return a card-emulation manager.";
                RaiseChanged();
                return;
            }

            var component = new ComponentName(activity, Java.Lang.Class.FromType(typeof(GlowGlyphService)));

            if (prefer)
            {
                if (IsListening)
                {
                    adapter.DisableReaderMode(activity);
                    IsListening = false;
                    StatusText = "⏸️ Reader paused so the APDU applet can answer readers.";
                }

                IsPreferredService = cardEmulation.SetPreferredService(activity, component);
                HceStatusText = IsPreferredService
                    ? "🪪 Demo service is preferred while this activity stays foreground."
                    : "⚠️ Android declined the preferred-service request.";
            }
            else
            {
                if (SupportsObserveMode && IsObserveModeEnabled)
                {
                    _ = adapter.SetObserveModeEnabled(false);
                    IsObserveModeEnabled = false;
                }

                IsPreferredService = false;
                _ = cardEmulation.UnsetPreferredService(activity);
                HceStatusText = "🫶 Demo service preference released.";
            }

            SyncHceState();
            RaiseChanged();
        });
    }

    public Task SetHceFEnabledAsync(bool enabled)
    {
        return MainThread.InvokeOnMainThreadAsync(() =>
        {
            adapter ??= ResolveAdapter();
            if (!SupportsNfcFCardEmulation || adapter is null)
            {
                IsHceFEnabled = false;
                HceFStatusText = "🚫 NFC-F card emulation hardware is not reported on this device.";
                HceFAppletRuntime.LogStatus(HceFStatusText);
                SyncHceState();
                RaiseChanged();
                return;
            }

            if (Platform.CurrentActivity is not Activity activity)
            {
                HceFStatusText = "⌛ Foreground activity is unavailable.";
                HceFAppletRuntime.LogStatus(HceFStatusText);
                SyncHceState();
                RaiseChanged();
                return;
            }

            nfcFCardEmulation ??= NfcFCardEmulation.GetInstance(adapter);
            if (nfcFCardEmulation is null)
            {
                IsHceFEnabled = false;
                HceFStatusText = "🚫 Android did not return an NFC-F card-emulation manager.";
                HceFAppletRuntime.LogStatus(HceFStatusText);
                SyncHceState();
                RaiseChanged();
                return;
            }

            var component = new ComponentName(activity, Java.Lang.Class.FromType(typeof(MossPulseService)));

            if (enabled)
            {
                if (IsListening)
                {
                    adapter.DisableReaderMode(activity);
                    IsListening = false;
                    StatusText = "⏸️ Reader paused so the NFC-F applet can answer readers.";
                }

                var systemCodeRegistered = nfcFCardEmulation.RegisterSystemCodeForService(component, HceFAppletRuntime.SystemCodeHex);
                var nfcid2Registered = nfcFCardEmulation.SetNfcid2ForService(component, HceFAppletRuntime.Nfcid2Hex);
                var serviceEnabled = systemCodeRegistered && nfcid2Registered && nfcFCardEmulation.EnableService(activity, component);

                IsHceFEnabled = serviceEnabled;
                HceFStatusText = serviceEnabled
                    ? "🧩 Demo NFC-F service is enabled for this foreground activity."
                    : $"⚠️ NFC-F enable failed • systemCode={systemCodeRegistered} • nfcid2={nfcid2Registered}";
                HceFAppletRuntime.LogStatus(HceFStatusText);
            }
            else
            {
                var disabled = nfcFCardEmulation.DisableService(activity);
                _ = nfcFCardEmulation.UnregisterSystemCodeForService(component);
                IsHceFEnabled = false;
                HceFStatusText = disabled
                    ? "🫶 Demo NFC-F service released."
                    : "🫶 Demo NFC-F service is no longer enabled.";
                HceFAppletRuntime.LogStatus(HceFStatusText);
            }

            SyncHceState();
            RaiseChanged();
        });
    }

    public Task SetObserveModeEnabledAsync(bool enabled)
    {
        return MainThread.InvokeOnMainThreadAsync(() =>
        {
            adapter ??= ResolveAdapter();
            if (!SupportsObserveMode || adapter is null)
            {
                IsObserveModeEnabled = false;
                ObserveModeStatusText = "🚫 Observe mode is not reported by this adapter.";
                RaiseChanged();
                return;
            }

            if (enabled)
            {
                if (!SupportsHce)
                {
                    ObserveModeStatusText = "🚫 Observe mode needs an HCE-capable device.";
                    RaiseChanged();
                    return;
                }

                if (!IsPreferredService)
                {
                    ObserveModeStatusText = "🪪 Prefer the APDU service first, then enable observe mode.";
                    RaiseChanged();
                    return;
                }

                if (IsListening && Platform.CurrentActivity is Activity listeningActivity)
                {
                    adapter.DisableReaderMode(listeningActivity);
                    IsListening = false;
                    StatusText = "⏸️ Reader paused so observe mode can watch polling frames.";
                }
            }

            var success = adapter.SetObserveModeEnabled(enabled);
            IsObserveModeEnabled = success && enabled;
            ObserveModeStatusText = success
                ? enabled
                    ? "👀 Observe mode is enabled. Polling frames will be logged without answering the reader."
                    : "🫶 Observe mode is disabled. Transactions may proceed normally again."
                : enabled
                    ? "⚠️ Observe mode enable failed. Keep the APDU service preferred and foreground."
                    : "⚠️ Observe mode disable request failed.";

            SyncHceState();
            RaiseChanged();
        });
    }

    public Task IgnoreCurrentTagAsync(int debounceMs)
    {
        return MainThread.InvokeOnMainThreadAsync(() =>
        {
            adapter ??= ResolveAdapter();
            var tag = latestTagHandle;
            if (adapter is null || tag is null)
            {
                StatusText = "⚠️ No adapter or tag available to ignore.";
                RaiseChanged();
                return;
            }

            var ignored = adapter.Ignore(tag, debounceMs, null, null);
            if (ignored)
            {
                latestTagHandle = null;
                StatusText = $"🚫 Tag ignored for {debounceMs} ms debounce.";
                LogSession("tag", "ignored", new { debounceMs });
            }
            else
            {
                StatusText = "⚠️ Android declined the ignore request.";
            }

            RaiseChanged();
        });
    }

    public Task SetDefaultObserveModeAsync(bool enabled)
    {
        return MainThread.InvokeOnMainThreadAsync(() =>
        {
            adapter ??= ResolveAdapter();
            if (!SupportsHce || adapter is null)
            {
                ObserveModeStatusText = "🚫 HCE is required for default observe mode.";
                RaiseChanged();
                return;
            }

            if (Platform.CurrentActivity is not Activity activity)
            {
                ObserveModeStatusText = "⌛ Foreground activity is unavailable.";
                RaiseChanged();
                return;
            }

            cardEmulationInstance ??= CardEmulation.GetInstance(adapter);
            if (cardEmulationInstance is null)
            {
                ObserveModeStatusText = "🚫 Card emulation manager is unavailable.";
                RaiseChanged();
                return;
            }

            var component = new ComponentName(activity, Java.Lang.Class.FromType(typeof(GlowGlyphService)));

            try
            {
                cardEmulationInstance.SetShouldDefaultToObserveModeForService(component, enabled);
                ShouldDefaultToObserveMode = enabled;
                ObserveModeStatusText = enabled
                    ? "👀 Default observe mode is now set. The APDU service will start in observe mode."
                    : "▶️ Default observe mode is cleared. The APDU service will transact normally.";
                LogSession("observe", "default_mode_changed", new { enabled });
            }
            catch (Exception ex)
            {
                ObserveModeStatusText = $"⚠️ Failed to set default observe mode • {ex.Message}";
            }

            SyncHceState();
            RaiseChanged();
        });
    }

    public Task SetDiscoveryTechnologyAsync(NfcReaderFlags pollFlags, NfcListenFlags listenFlags)
    {
        return MainThread.InvokeOnMainThreadAsync(() =>
        {
            adapter ??= ResolveAdapter();
            if (adapter is null)
            {
                DiscoveryStatusText = "🚫 NFC adapter is unavailable.";
                RaiseChanged();
                return;
            }

            if (Platform.CurrentActivity is not Activity activity)
            {
                DiscoveryStatusText = "⌛ Foreground activity is unavailable.";
                RaiseChanged();
                return;
            }

            try
            {
                adapter.SetDiscoveryTechnology(activity, pollFlags, listenFlags);
                hasCustomDiscoveryTechnology = true;
                DiscoveryStatusText = $"🔍 Custom discovery set • poll={pollFlags} • listen={listenFlags}";
                LogSession("discovery", "technology_set", new
                {
                    pollFlags = pollFlags.ToString(),
                    listenFlags = listenFlags.ToString()
                });
            }
            catch (Exception ex)
            {
                DiscoveryStatusText = $"⚠️ SetDiscoveryTechnology failed • {ex.Message}";
            }

            RaiseChanged();
        });
    }

    public Task ResetDiscoveryTechnologyAsync()
    {
        return MainThread.InvokeOnMainThreadAsync(() =>
        {
            adapter ??= ResolveAdapter();
            if (adapter is null)
            {
                DiscoveryStatusText = "🚫 NFC adapter is unavailable.";
                RaiseChanged();
                return;
            }

            if (Platform.CurrentActivity is not Activity activity)
            {
                DiscoveryStatusText = "⌛ Foreground activity is unavailable.";
                RaiseChanged();
                return;
            }

            try
            {
                adapter.ResetDiscoveryTechnology(activity);
                hasCustomDiscoveryTechnology = false;
                DiscoveryStatusText = "🔍 Discovery technology reset to system defaults.";
                LogSession("discovery", "technology_reset", null);
            }
            catch (Exception ex)
            {
                DiscoveryStatusText = $"⚠️ ResetDiscoveryTechnology failed • {ex.Message}";
            }

            RaiseChanged();
        });
    }

    public Task RegisterHceAidsAsync(string rawAidText)
    {
        return MainThread.InvokeOnMainThreadAsync(() =>
        {
            if (string.IsNullOrWhiteSpace(rawAidText))
            {
                HceStatusText = "⚠️ Provide at least one AID hex value.";
                RaiseChanged();
                return;
            }

            var aids = rawAidText
                .Split([',', ';', ' ', '\n', '\r'], StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
                .Select(static value => new string(value.Where(Uri.IsHexDigit).ToArray()).ToUpperInvariant())
                .Where(static value => value.Length >= 10)
                .ToArray();

            if (aids.Length == 0)
            {
                HceStatusText = "⚠️ No valid AID hex values found. An AID must have at least 5 bytes (10 hex digits).";
                RaiseChanged();
                return;
            }

            HceAppletRuntime.SetDynamicAids(aids);
            HceStatusText = $"🪪 Registered {aids.Length} dynamic AID(s) in the runtime applet.";
            LogSession("hce", "aids_registered", new { aids });
            SyncHceState();
            RaiseChanged();
        });
    }

    public Task ClearHceAidsAsync()
    {
        return MainThread.InvokeOnMainThreadAsync(() =>
        {
            HceAppletRuntime.SetDynamicAids([]);
            HceStatusText = "🧹 Dynamic AIDs cleared. Only the built-in AID remains.";
            LogSession("hce", "aids_cleared", null);
            SyncHceState();
            RaiseChanged();
        });
    }

    public Task AddPollingFilterAsync(string filterHex, bool autoTransact)
    {
        return MainThread.InvokeOnMainThreadAsync(() =>
        {
            adapter ??= ResolveAdapter();
            if (!SupportsHce || adapter is null)
            {
                HceStatusText = "🚫 HCE is required for polling filters.";
                RaiseChanged();
                return;
            }

            if (Platform.CurrentActivity is not Activity activity)
            {
                HceStatusText = "⌛ Foreground activity is unavailable.";
                RaiseChanged();
                return;
            }

            cardEmulationInstance ??= CardEmulation.GetInstance(adapter);
            if (cardEmulationInstance is null)
            {
                HceStatusText = "🚫 Card emulation manager is unavailable.";
                RaiseChanged();
                return;
            }

            var cleanedHex = new string(filterHex.Where(Uri.IsHexDigit).ToArray()).ToUpperInvariant();
            if (string.IsNullOrWhiteSpace(cleanedHex))
            {
                HceStatusText = "⚠️ Provide a valid hex polling filter.";
                RaiseChanged();
                return;
            }

            var component = new ComponentName(activity, Java.Lang.Class.FromType(typeof(GlowGlyphService)));

            try
            {
                cardEmulationInstance.RegisterPollingLoopFilterForService(component, cleanedHex, autoTransact);
                if (!pollingFilterEntries.Contains(cleanedHex, StringComparer.OrdinalIgnoreCase))
                {
                    pollingFilterEntries.Add(cleanedHex);
                }

                HceStatusText = $"📡 Polling filter {FormatHex(cleanedHex)} registered • autoTransact={autoTransact}";
                LogSession("polling", "filter_added", new { filterHex = cleanedHex, autoTransact });
            }
            catch (Exception ex)
            {
                HceStatusText = $"⚠️ Polling filter registration failed • {ex.Message}";
            }

            SyncHceState();
            RaiseChanged();
        });
    }

    public Task RemovePollingFilterAsync(string filterHex)
    {
        return MainThread.InvokeOnMainThreadAsync(() =>
        {
            adapter ??= ResolveAdapter();
            if (!SupportsHce || adapter is null || Platform.CurrentActivity is not Activity activity)
            {
                RaiseChanged();
                return;
            }

            cardEmulationInstance ??= CardEmulation.GetInstance(adapter);
            if (cardEmulationInstance is null)
            {
                RaiseChanged();
                return;
            }

            var cleanedHex = new string(filterHex.Where(Uri.IsHexDigit).ToArray()).ToUpperInvariant();
            var component = new ComponentName(activity, Java.Lang.Class.FromType(typeof(GlowGlyphService)));

            try
            {
                cardEmulationInstance.RemovePollingLoopFilterForService(component, cleanedHex);
                pollingFilterEntries.RemoveAll(value => string.Equals(value, cleanedHex, StringComparison.OrdinalIgnoreCase));
                HceStatusText = $"🧹 Polling filter {FormatHex(cleanedHex)} removed.";
                LogSession("polling", "filter_removed", new { filterHex = cleanedHex });
            }
            catch (Exception ex)
            {
                HceStatusText = $"⚠️ Polling filter removal failed • {ex.Message}";
            }

            SyncHceState();
            RaiseChanged();
        });
    }

    public Task AddPollingPatternFilterAsync(string pattern, bool autoTransact)
    {
        return MainThread.InvokeOnMainThreadAsync(() =>
        {
            adapter ??= ResolveAdapter();
            if (!SupportsHce || adapter is null)
            {
                HceStatusText = "🚫 HCE is required for polling pattern filters.";
                RaiseChanged();
                return;
            }

            if (Platform.CurrentActivity is not Activity activity)
            {
                HceStatusText = "⌛ Foreground activity is unavailable.";
                RaiseChanged();
                return;
            }

            cardEmulationInstance ??= CardEmulation.GetInstance(adapter);
            if (cardEmulationInstance is null)
            {
                HceStatusText = "🚫 Card emulation manager is unavailable.";
                RaiseChanged();
                return;
            }

            if (string.IsNullOrWhiteSpace(pattern))
            {
                HceStatusText = "⚠️ Provide a valid regex pattern for polling filter.";
                RaiseChanged();
                return;
            }

            var component = new ComponentName(activity, Java.Lang.Class.FromType(typeof(GlowGlyphService)));

            try
            {
                cardEmulationInstance.RegisterPollingLoopPatternFilterForService(component, pattern.Trim(), autoTransact);
                var trimmed = pattern.Trim();
                if (!pollingPatternFilterEntries.Contains(trimmed, StringComparer.Ordinal))
                {
                    pollingPatternFilterEntries.Add(trimmed);
                }

                HceStatusText = $"📡 Polling pattern filter '{trimmed}' registered • autoTransact={autoTransact}";
                LogSession("polling", "pattern_filter_added", new { pattern = trimmed, autoTransact });
            }
            catch (Exception ex)
            {
                HceStatusText = $"⚠️ Polling pattern filter registration failed • {ex.Message}";
            }

            SyncHceState();
            RaiseChanged();
        });
    }

    public Task RemovePollingPatternFilterAsync(string pattern)
    {
        return MainThread.InvokeOnMainThreadAsync(() =>
        {
            adapter ??= ResolveAdapter();
            if (!SupportsHce || adapter is null || Platform.CurrentActivity is not Activity activity)
            {
                RaiseChanged();
                return;
            }

            cardEmulationInstance ??= CardEmulation.GetInstance(adapter);
            if (cardEmulationInstance is null)
            {
                RaiseChanged();
                return;
            }

            var component = new ComponentName(activity, Java.Lang.Class.FromType(typeof(GlowGlyphService)));
            var trimmed = pattern.Trim();

            try
            {
                cardEmulationInstance.RemovePollingLoopPatternFilterForService(component, trimmed);
                pollingPatternFilterEntries.RemoveAll(value => string.Equals(value, trimmed, StringComparison.Ordinal));
                HceStatusText = $"🧹 Polling pattern filter '{trimmed}' removed.";
                LogSession("polling", "pattern_filter_removed", new { pattern = trimmed });
            }
            catch (Exception ex)
            {
                HceStatusText = $"⚠️ Polling pattern filter removal failed • {ex.Message}";
            }

            SyncHceState();
            RaiseChanged();
        });
    }

    public async Task SendRawAsync(string technologyName, string commandHex)
    {
        var tag = latestTagHandle;
        if (tag is null)
        {
            LastRawStatus = "⚠️ Tap a tag first, then keep it near the antenna for raw I/O.";
            AppendEvent(rawEvents, LastRawStatus);
            RaiseChanged();
            return;
        }

        byte[] command;
        try
        {
            command = ParseHex(commandHex);
        }
        catch (Exception ex)
        {
            LastRawStatus = $"⚠️ Invalid hex command • {ex.Message}";
            AppendEvent(rawEvents, LastRawStatus);
            RaiseChanged();
            return;
        }

        var techName = ShortName(technologyName);

        try
        {
            await ioGate.WaitAsync().ConfigureAwait(false);
            try
            {
                var response = techName switch
                {
                    nameof(NfcA) => Transceive(NfcA.Get(tag), command, nameof(NfcA)),
                    nameof(NfcB) => Transceive(NfcB.Get(tag), command, nameof(NfcB)),
                    nameof(NfcF) => Transceive(NfcF.Get(tag), command, nameof(NfcF)),
                    nameof(NfcV) => Transceive(NfcV.Get(tag), command, nameof(NfcV)),
                    nameof(IsoDep) => Transceive(IsoDep.Get(tag), command, nameof(IsoDep)),
                    nameof(MifareClassic) => Transceive(MifareClassic.Get(tag), command, nameof(MifareClassic)),
                    nameof(MifareUltralight) => Transceive(MifareUltralight.Get(tag), command, nameof(MifareUltralight)),
                    _ => throw new InvalidOperationException($"Unknown technology: {techName}")
                };

                var responsePlaintext = TryDecodeUtf8Inline(response);
                LastRawStatus = $"✅ {techName} • {FormatBytesWithSpaces(command)} → {FormatBytesWithSpaces(response)}";
                AppendEvent(rawEvents, LastRawStatus);
                NfcJson.Append(rawJsonlEntries, 200, "raw", "transceive_ok", new
                {
                    technology = techName,
                    commandHex = Convert.ToHexString(command),
                    responseHex = Convert.ToHexString(response),
                    responsePlaintext,
                    responseLength = response.Length
                });
                LogSession("raw", "transceive_ok", new { technology = techName, commandHex = Convert.ToHexString(command) });
            }
            finally
            {
                ioGate.Release();
            }
        }
        catch (Exception ex)
        {
            LastRawStatus = $"⚠️ {techName} failed • {ex.Message}";
            AppendEvent(rawEvents, LastRawStatus);
            NfcJson.Append(rawJsonlEntries, 200, "raw", "transceive_error", new
            {
                technology = techName,
                error = ex.Message
            });
            LogSession("raw", "transceive_error", new { technology = techName, error = ex.Message });
        }

        RaiseChanged();
    }

    public Task FormatTagAsync()
    {
        return Task.Run(async () =>
        {
            var tag = latestTagHandle;
            if (tag is null)
            {
                LastWriteStatus = "⚠️ No tag available. Tap a tag first.";
                RaiseChanged();
                return;
            }

            await ioGate.WaitAsync().ConfigureAwait(false);
            try
            {
                var formatable = NdefFormatable.Get(tag);
                if (formatable is null)
                {
                    LastWriteStatus = "📭 This tag does not support NdefFormatable.";
                    RaiseChanged();
                    return;
                }

                try
                {
                    formatable.Connect();
                    var emptyRecord = NdefRecord.CreateTextRecord("en", string.Empty);
                    formatable.Format(new NdefMessage([emptyRecord!]));
                    LastWriteStatus = "✅ Tag formatted as NDEF with empty text record.";
                    LogSession("tag", "formatted", null);
                }
                finally
                {
                    SafeClose(formatable);
                }
            }
            catch (Exception ex)
            {
                LastWriteStatus = $"⚠️ Format failed • {ex.Message}";
            }
            finally
            {
                ioGate.Release();
            }

            RaiseChanged();
        });
    }

    public Task ToggleForegroundDispatchAsync(bool enabled)
    {
        return MainThread.InvokeOnMainThreadAsync(() =>
        {
            adapter ??= ResolveAdapter();
            if (adapter is null || Platform.CurrentActivity is not Activity activity)
            {
                IsForegroundDispatchEnabled = false;
                NfcJson.Append(foregroundDispatchJsonlEntries, 100, "foreground_dispatch", "toggle_failed", new
                {
                    reason = adapter is null ? "no_adapter" : "no_activity"
                });
                RaiseChanged();
                return;
            }

            if (enabled)
            {
                EnsureForegroundDispatchResources(activity);
                adapter.EnableForegroundDispatch(activity, foregroundPendingIntent, foregroundIntentFilters, foregroundTechLists);
                IsForegroundDispatchEnabled = true;
                NfcJson.Append(foregroundDispatchJsonlEntries, 100, "foreground_dispatch", "enabled", null);
            }
            else
            {
                adapter.DisableForegroundDispatch(activity);
                IsForegroundDispatchEnabled = false;
                NfcJson.Append(foregroundDispatchJsonlEntries, 100, "foreground_dispatch", "disabled", null);
            }

            RaiseChanged();
        });
    }

    public async Task ReadMifareClassicSectorAsync(int sectorIndex, string keyHex, bool useKeyB)
    {
        var tag = latestTagHandle;
        if (tag is null)
        {
            LastRawStatus = "⚠️ No tag available for MifareClassic read.";
            RaiseChanged();
            return;
        }

        var mifare = MifareClassic.Get(tag);
        if (mifare is null)
        {
            LastRawStatus = "⚠️ This tag does not support MifareClassic.";
            RaiseChanged();
            return;
        }

        byte[] key;
        try
        {
            key = string.IsNullOrWhiteSpace(keyHex) ? MifareKeyDefault : ParseHex(keyHex);
            if (key.Length != 6)
            {
                LastRawStatus = "⚠️ MIFARE key must be exactly 6 bytes (12 hex digits).";
                RaiseChanged();
                return;
            }
        }
        catch
        {
            key = MifareKeyDefault;
        }

        await ioGate.WaitAsync().ConfigureAwait(false);
        try
        {
            mifare.Connect();
            var authenticated = useKeyB
                ? mifare.AuthenticateSectorWithKeyB(sectorIndex, key)
                : mifare.AuthenticateSectorWithKeyA(sectorIndex, key);

            if (!authenticated)
            {
                LastRawStatus = $"🔒 Auth failed sector {sectorIndex} with key {(useKeyB ? "B" : "A")} {Convert.ToHexString(key)}";
                NfcJson.Append(mifareClassicJsonlEntries, 200, "mifare_classic", "auth_failed", new
                {
                    sectorIndex,
                    keyType = useKeyB ? "B" : "A",
                    keyHex = Convert.ToHexString(key)
                });
                RaiseChanged();
                return;
            }

            var firstBlock = mifare.SectorToBlock(sectorIndex);
            var blockCount = mifare.GetBlockCountInSector(sectorIndex);
            var blocks = new List<object>();

            for (var i = 0; i < blockCount; i++)
            {
                var blockIndex = firstBlock + i;
                try
                {
                    var data = mifare.ReadBlock(blockIndex) ?? [];
                    var blockType = ClassifyMifareBlock(sectorIndex, i, blockCount);
                    blocks.Add(new
                    {
                        blockIndex,
                        dataHex = Convert.ToHexString(data),
                        plaintext = SafeDecodePrintable(data),
                        blockType
                    });
                }
                catch (Exception ex)
                {
                    blocks.Add(new
                    {
                        blockIndex,
                        dataHex = string.Empty,
                        plaintext = string.Empty,
                        blockType = $"read_error: {ex.Message}"
                    });
                }
            }

            LastRawStatus = $"✅ Read sector {sectorIndex} ({blockCount} blocks) with key {(useKeyB ? "B" : "A")}";
            NfcJson.Append(mifareClassicJsonlEntries, 200, "mifare_classic", "sector_read", new
            {
                sectorIndex,
                firstBlock,
                keyType = useKeyB ? "B" : "A",
                keyHex = Convert.ToHexString(key),
                blocks
            });
            LogSession("mifare_classic", "sector_read", new { sectorIndex, blockCount });
        }
        catch (Exception ex)
        {
            LastRawStatus = $"⚠️ MifareClassic read failed • {ex.Message}";
            NfcJson.Append(mifareClassicJsonlEntries, 200, "mifare_classic", "read_error", new
            {
                sectorIndex,
                error = ex.Message
            });
        }
        finally
        {
            SafeClose(mifare);
            ioGate.Release();
        }

        RaiseChanged();
    }

    public async Task ReadMifareUltralightPageRangeAsync(int startPage, int count)
    {
        var tag = latestTagHandle;
        if (tag is null)
        {
            LastRawStatus = "⚠️ No tag available for MifareUltralight read.";
            RaiseChanged();
            return;
        }

        var ultralight = MifareUltralight.Get(tag);
        if (ultralight is null)
        {
            LastRawStatus = "⚠️ This tag does not support MifareUltralight.";
            RaiseChanged();
            return;
        }

        await ioGate.WaitAsync().ConfigureAwait(false);
        try
        {
            ultralight.Connect();
            var pages = new List<object>();
            var endPage = startPage + count;

            for (var page = startPage; page < endPage; page += 4)
            {
                try
                {
                    var data = ultralight.ReadPages(page) ?? [];
                    for (var offset = 0; offset < data.Length && offset < 16 && page + offset / 4 < endPage; offset += 4)
                    {
                        var pageIndex = page + offset / 4;
                        var pageData = data.Skip(offset).Take(4).ToArray();
                        pages.Add(new
                        {
                            pageIndex,
                            dataHex = Convert.ToHexString(pageData),
                            plaintext = SafeDecodePrintable(pageData),
                            pageType = ClassifyUltralightPage(pageIndex)
                        });
                    }
                }
                catch (Exception ex)
                {
                    pages.Add(new
                    {
                        pageIndex = page,
                        dataHex = string.Empty,
                        plaintext = string.Empty,
                        pageType = $"read_error: {ex.Message}"
                    });
                    break;
                }
            }

            LastRawStatus = $"✅ Read {pages.Count} Ultralight pages starting at page {startPage}";
            NfcJson.Append(mifareUltralightJsonlEntries, 200, "mifare_ultralight", "pages_read", new
            {
                startPage,
                count = pages.Count,
                pages
            });
            LogSession("mifare_ultralight", "pages_read", new { startPage, pageCount = pages.Count });
        }
        catch (Exception ex)
        {
            LastRawStatus = $"⚠️ MifareUltralight read failed • {ex.Message}";
            NfcJson.Append(mifareUltralightJsonlEntries, 200, "mifare_ultralight", "read_error", new
            {
                startPage,
                error = ex.Message
            });
        }
        finally
        {
            SafeClose(ultralight);
            ioGate.Release();
        }

        RaiseChanged();
    }

    public void OnTagDiscovered(Tag? tag)
    {
        if (tag is null)
        {
            return;
        }

        _ = Task.Run(() => ProcessTagAsync(tag));
    }

    public void HandleForegroundDispatchIntent(Intent? intent)
    {
        if (intent is null)
        {
            return;
        }

        var action = intent.Action ?? "(none)";
        LastIntentAction = action;

        NfcJson.Append(foregroundDispatchJsonlEntries, 100, "foreground_dispatch", "intent_received", new
        {
            action,
            categories = intent.Categories?.ToArray() ?? [],
            dataString = intent.DataString ?? "(none)"
        });

        if (action is NfcAdapter.ActionNdefDiscovered or NfcAdapter.ActionTechDiscovered or NfcAdapter.ActionTagDiscovered)
        {
            if (intent.GetParcelableExtra(NfcAdapter.ExtraTag) is Tag tag)
            {
                _ = Task.Run(() => ProcessTagAsync(tag));
            }

            var ndefMessages = intent.GetParcelableArrayExtra(NfcAdapter.ExtraNdefMessages);
            if (ndefMessages is { Length: > 0 })
            {
                foreach (var raw in ndefMessages)
                {
                    if (raw is NdefMessage msg)
                    {
                        var records = (msg.GetRecords() ?? []).Select(DescribeRecord).ToArray();
                        NfcJson.Append(foregroundDispatchJsonlEntries, 100, "foreground_dispatch", "ndef_message", new
                        {
                            recordCount = records.Length,
                            records = records.Select(static r => new { r.Icon, r.Kind, r.Summary, r.PayloadHex })
                        });
                    }
                }
            }
        }

        RaiseChanged();
    }

    public async Task MifareClassicWriteBlockAsync(int blockIndex, string dataHex, int authSector, string keyHex, bool useKeyB)
    {
        var tag = latestTagHandle;
        if (tag is null)
        {
            LastRawStatus = "⚠️ No tag available for MifareClassic write.";
            RaiseChanged();
            return;
        }

        var mifare = MifareClassic.Get(tag);
        if (mifare is null)
        {
            LastRawStatus = "⚠️ This tag does not support MifareClassic.";
            RaiseChanged();
            return;
        }

        byte[] data;
        byte[] key;
        try
        {
            data = ParseHex(dataHex);
            key = string.IsNullOrWhiteSpace(keyHex) ? MifareKeyDefault : ParseHex(keyHex);
        }
        catch (Exception ex)
        {
            LastRawStatus = $"⚠️ Invalid hex • {ex.Message}";
            RaiseChanged();
            return;
        }

        if (data.Length != 16)
        {
            LastRawStatus = "⚠️ MifareClassic block must be exactly 16 bytes (32 hex digits).";
            RaiseChanged();
            return;
        }

        await ioGate.WaitAsync().ConfigureAwait(false);
        try
        {
            mifare.Connect();
            var auth = useKeyB
                ? mifare.AuthenticateSectorWithKeyB(authSector, key)
                : mifare.AuthenticateSectorWithKeyA(authSector, key);

            if (!auth)
            {
                LastRawStatus = $"🔒 Auth failed sector {authSector}";
                RaiseChanged();
                return;
            }

            mifare.WriteBlock(blockIndex, data);
            LastRawStatus = $"✅ Wrote block {blockIndex} • {Convert.ToHexString(data)}";
            NfcJson.Append(mifareClassicJsonlEntries, 200, "mifare_classic", "block_written", new
            {
                blockIndex,
                dataHex = Convert.ToHexString(data),
                plaintext = SafeDecodePrintable(data)
            });
            LogSession("mifare_classic", "block_written", new { blockIndex });
        }
        catch (Exception ex)
        {
            LastRawStatus = $"⚠️ MifareClassic write failed • {ex.Message}";
        }
        finally
        {
            SafeClose(mifare);
            ioGate.Release();
        }

        RaiseChanged();
    }

    public async Task MifareClassicIncrementAsync(int blockIndex, int value, int authSector, string keyHex, bool useKeyB)
    {
        await MifareClassicValueOpAsync("increment", blockIndex, value, authSector, keyHex, useKeyB,
            static (mifare, block, val) => { mifare.Increment(block, val); mifare.Transfer(block); });
    }

    public async Task MifareClassicDecrementAsync(int blockIndex, int value, int authSector, string keyHex, bool useKeyB)
    {
        await MifareClassicValueOpAsync("decrement", blockIndex, value, authSector, keyHex, useKeyB,
            static (mifare, block, val) => { mifare.Decrement(block, val); mifare.Transfer(block); });
    }

    public async Task MifareClassicTransferAsync(int blockIndex, int authSector, string keyHex, bool useKeyB)
    {
        await MifareClassicValueOpAsync("transfer", blockIndex, 0, authSector, keyHex, useKeyB,
            static (mifare, block, _) => mifare.Transfer(block));
    }

    public async Task MifareClassicRestoreAsync(int blockIndex, int authSector, string keyHex, bool useKeyB)
    {
        await MifareClassicValueOpAsync("restore", blockIndex, 0, authSector, keyHex, useKeyB,
            static (mifare, block, _) => mifare.Restore(block));
    }

    private async Task MifareClassicValueOpAsync(string opName, int blockIndex, int value, int authSector, string keyHex, bool useKeyB, Action<MifareClassic, int, int> operation)
    {
        var tag = latestTagHandle;
        if (tag is null)
        {
            LastRawStatus = $"⚠️ No tag available for MifareClassic {opName}.";
            RaiseChanged();
            return;
        }

        var mifare = MifareClassic.Get(tag);
        if (mifare is null)
        {
            LastRawStatus = "⚠️ This tag does not support MifareClassic.";
            RaiseChanged();
            return;
        }

        byte[] key;
        try
        {
            key = string.IsNullOrWhiteSpace(keyHex) ? MifareKeyDefault : ParseHex(keyHex);
        }
        catch
        {
            key = MifareKeyDefault;
        }

        await ioGate.WaitAsync().ConfigureAwait(false);
        try
        {
            mifare.Connect();
            var auth = useKeyB
                ? mifare.AuthenticateSectorWithKeyB(authSector, key)
                : mifare.AuthenticateSectorWithKeyA(authSector, key);

            if (!auth)
            {
                LastRawStatus = $"🔒 Auth failed sector {authSector} for {opName}";
                RaiseChanged();
                return;
            }

            operation(mifare, blockIndex, value);
            LastRawStatus = $"✅ {opName} on block {blockIndex} • value={value}";
            NfcJson.Append(mifareClassicJsonlEntries, 200, "mifare_classic", $"value_{opName}", new
            {
                blockIndex,
                value,
                operation = opName
            });
            LogSession("mifare_classic", $"value_{opName}", new { blockIndex, value });
        }
        catch (Exception ex)
        {
            LastRawStatus = $"⚠️ MifareClassic {opName} failed • {ex.Message}";
        }
        finally
        {
            SafeClose(mifare);
            ioGate.Release();
        }

        RaiseChanged();
    }

    public async Task MifareUltralightWritePageAsync(int pageIndex, string dataHex)
    {
        var tag = latestTagHandle;
        if (tag is null)
        {
            LastRawStatus = "⚠️ No tag available for MifareUltralight write.";
            RaiseChanged();
            return;
        }

        var ultralight = MifareUltralight.Get(tag);
        if (ultralight is null)
        {
            LastRawStatus = "⚠️ This tag does not support MifareUltralight.";
            RaiseChanged();
            return;
        }

        byte[] data;
        try
        {
            data = ParseHex(dataHex);
        }
        catch (Exception ex)
        {
            LastRawStatus = $"⚠️ Invalid hex • {ex.Message}";
            RaiseChanged();
            return;
        }

        if (data.Length != 4)
        {
            LastRawStatus = "⚠️ MifareUltralight page must be exactly 4 bytes (8 hex digits).";
            RaiseChanged();
            return;
        }

        await ioGate.WaitAsync().ConfigureAwait(false);
        try
        {
            ultralight.Connect();
            ultralight.WritePage(pageIndex, data);
            LastRawStatus = $"✅ Wrote page {pageIndex} • {Convert.ToHexString(data)}";
            NfcJson.Append(mifareUltralightJsonlEntries, 200, "mifare_ultralight", "page_written", new
            {
                pageIndex,
                dataHex = Convert.ToHexString(data),
                plaintext = SafeDecodePrintable(data)
            });
            LogSession("mifare_ultralight", "page_written", new { pageIndex });
        }
        catch (Exception ex)
        {
            LastRawStatus = $"⚠️ MifareUltralight write failed • {ex.Message}";
        }
        finally
        {
            SafeClose(ultralight);
            ioGate.Release();
        }

        RaiseChanged();
    }

    public async Task MifareUltralightPwdAuthAsync(string passwordHex)
    {
        var tag = latestTagHandle;
        if (tag is null)
        {
            LastRawStatus = "⚠️ No tag available for PWD_AUTH.";
            RaiseChanged();
            return;
        }

        var ultralight = MifareUltralight.Get(tag);
        if (ultralight is null)
        {
            LastRawStatus = "⚠️ This tag does not support MifareUltralight.";
            RaiseChanged();
            return;
        }

        byte[] password;
        try
        {
            password = ParseHex(passwordHex);
        }
        catch (Exception ex)
        {
            LastRawStatus = $"⚠️ Invalid hex • {ex.Message}";
            RaiseChanged();
            return;
        }

        if (password.Length != 4)
        {
            LastRawStatus = "⚠️ NTAG PWD_AUTH password must be exactly 4 bytes (8 hex digits).";
            RaiseChanged();
            return;
        }

        await ioGate.WaitAsync().ConfigureAwait(false);
        try
        {
            ultralight.Connect();
            var command = new byte[5];
            command[0] = 0x1B;
            Buffer.BlockCopy(password, 0, command, 1, 4);
            var response = ultralight.Transceive(command) ?? [];
            var packHex = Convert.ToHexString(response);
            LastRawStatus = $"✅ PWD_AUTH success • PACK={packHex}";
            NfcJson.Append(mifareUltralightJsonlEntries, 200, "mifare_ultralight", "pwd_auth_ok", new
            {
                passwordHex = Convert.ToHexString(password),
                packHex,
                packPlaintext = SafeDecodePrintable(response)
            });
            LogSession("mifare_ultralight", "pwd_auth_ok", new { packHex });
        }
        catch (Exception ex)
        {
            LastRawStatus = $"⚠️ PWD_AUTH failed • {ex.Message}";
            NfcJson.Append(mifareUltralightJsonlEntries, 200, "mifare_ultralight", "pwd_auth_failed", new
            {
                error = ex.Message
            });
        }
        finally
        {
            SafeClose(ultralight);
            ioGate.Release();
        }

        RaiseChanged();
    }

    public async Task SetTechTimeoutAsync(string technologyName, int timeoutMs)
    {
        var tag = latestTagHandle;
        if (tag is null)
        {
            LastRawStatus = "⚠️ No tag available for timeout setting.";
            RaiseChanged();
            return;
        }

        var techName = ShortName(technologyName);

        await ioGate.WaitAsync().ConfigureAwait(false);
        try
        {
            switch (techName)
            {
                case nameof(NfcA):
                    var nfcA = NfcA.Get(tag);
                    if (nfcA is not null) { nfcA.Connect(); nfcA.Timeout = timeoutMs; SafeClose(nfcA); }
                    break;
                case nameof(NfcF):
                    var nfcF = NfcF.Get(tag);
                    if (nfcF is not null) { nfcF.Connect(); nfcF.Timeout = timeoutMs; SafeClose(nfcF); }
                    break;
                case nameof(IsoDep):
                    var isoDep = IsoDep.Get(tag);
                    if (isoDep is not null) { isoDep.Connect(); isoDep.Timeout = timeoutMs; SafeClose(isoDep); }
                    break;
                case nameof(MifareClassic):
                    var mc = MifareClassic.Get(tag);
                    if (mc is not null) { mc.Connect(); mc.Timeout = timeoutMs; SafeClose(mc); }
                    break;
                case nameof(MifareUltralight):
                    var mu = MifareUltralight.Get(tag);
                    if (mu is not null) { mu.Connect(); mu.Timeout = timeoutMs; SafeClose(mu); }
                    break;
                default:
                    LastRawStatus = $"⚠️ Timeout not supported for {techName}.";
                    RaiseChanged();
                    return;
            }

            LastRawStatus = $"✅ {techName} timeout set to {timeoutMs} ms";
            NfcJson.Append(rawJsonlEntries, 200, "raw", "timeout_set", new { technology = techName, timeoutMs });
            LogSession("raw", "timeout_set", new { technology = techName, timeoutMs });
        }
        catch (Exception ex)
        {
            LastRawStatus = $"⚠️ Timeout set failed • {ex.Message}";
        }
        finally
        {
            ioGate.Release();
        }

        RaiseChanged();
    }

    public Task RegisterSystemAidsAsync(string category, string aidListText)
    {
        return MainThread.InvokeOnMainThreadAsync(() =>
        {
            adapter ??= ResolveAdapter();
            if (!SupportsHce || adapter is null || Platform.CurrentActivity is not Activity activity)
            {
                HceStatusText = "🚫 HCE required for AID registration.";
                RaiseChanged();
                return;
            }

            cardEmulationInstance ??= CardEmulation.GetInstance(adapter);
            if (cardEmulationInstance is null)
            {
                HceStatusText = "🚫 Card emulation manager unavailable.";
                RaiseChanged();
                return;
            }

            var aids = aidListText
                .Split([',', ';', ' ', '\n', '\r'], StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
                .Select(static v => new string(v.Where(Uri.IsHexDigit).ToArray()).ToUpperInvariant())
                .Where(static v => v.Length >= 10)
                .ToList();

            if (aids.Count == 0)
            {
                HceStatusText = "⚠️ No valid AIDs. Each must be at least 5 bytes.";
                RaiseChanged();
                return;
            }

            var component = new ComponentName(activity, Java.Lang.Class.FromType(typeof(GlowGlyphService)));
            var cat = string.Equals(category, "payment", StringComparison.OrdinalIgnoreCase) ? CardEmulation.CategoryPayment : CardEmulation.CategoryOther;

            try
            {
                var registered = cardEmulationInstance.RegisterAidsForService(component, cat, aids);
                HceStatusText = registered
                    ? $"✅ Registered {aids.Count} AID(s) for category '{cat}'"
                    : $"⚠️ AID registration failed for category '{cat}'";
                NfcJson.Append(aidManagementJsonlEntries, 100, "aid_mgmt", "registered", new { category = cat, aids, success = registered });
                QuerySystemAidsInternal(cat, activity, component);
            }
            catch (Exception ex)
            {
                HceStatusText = $"⚠️ AID registration error • {ex.Message}";
            }

            RaiseChanged();
        });
    }

    public Task RemoveSystemAidsAsync(string category)
    {
        return MainThread.InvokeOnMainThreadAsync(() =>
        {
            adapter ??= ResolveAdapter();
            if (!SupportsHce || adapter is null || Platform.CurrentActivity is not Activity activity)
            {
                RaiseChanged();
                return;
            }

            cardEmulationInstance ??= CardEmulation.GetInstance(adapter);
            if (cardEmulationInstance is null)
            {
                RaiseChanged();
                return;
            }

            var component = new ComponentName(activity, Java.Lang.Class.FromType(typeof(GlowGlyphService)));
            var cat = string.Equals(category, "payment", StringComparison.OrdinalIgnoreCase) ? CardEmulation.CategoryPayment : CardEmulation.CategoryOther;

            try
            {
                var removed = cardEmulationInstance.RemoveAidsForService(component, cat);
                HceStatusText = removed ? $"✅ Removed AIDs for category '{cat}'" : $"⚠️ AID removal failed for '{cat}'";
                NfcJson.Append(aidManagementJsonlEntries, 100, "aid_mgmt", "removed", new { category = cat, success = removed });
                QuerySystemAidsInternal(cat, activity, component);
            }
            catch (Exception ex)
            {
                HceStatusText = $"⚠️ AID removal error • {ex.Message}";
            }

            RaiseChanged();
        });
    }

    public Task QuerySystemAidsAsync(string category)
    {
        return MainThread.InvokeOnMainThreadAsync(() =>
        {
            adapter ??= ResolveAdapter();
            if (!SupportsHce || adapter is null || Platform.CurrentActivity is not Activity activity)
            {
                RaiseChanged();
                return;
            }

            cardEmulationInstance ??= CardEmulation.GetInstance(adapter);
            if (cardEmulationInstance is null)
            {
                RaiseChanged();
                return;
            }

            var component = new ComponentName(activity, Java.Lang.Class.FromType(typeof(GlowGlyphService)));
            var cat = string.Equals(category, "payment", StringComparison.OrdinalIgnoreCase) ? CardEmulation.CategoryPayment : CardEmulation.CategoryOther;
            QuerySystemAidsInternal(cat, activity, component);
            RaiseChanged();
        });
    }

    private void QuerySystemAidsInternal(string category, Activity activity, ComponentName component)
    {
        try
        {
            var aids = cardEmulationInstance?.GetAidsForService(component, category);
            RegisteredSystemAids = aids?.ToArray() ?? [];
            IsDefaultServiceForCategory = cardEmulationInstance?.IsDefaultServiceForCategory(component, category) ?? false;

            try
            {
                var selectionMode = cardEmulationInstance?.GetSelectionModeForCategory(category);
                SelectionModeForCategory = selectionMode?.ToString() switch
                {
                    "AlwaysAsk" => "always ask",
                    "AlwaysDefault" => "always default",
                    "AskIfConflict" => "ask if conflict",
                    _ => $"mode {selectionMode}"
                };
            }
            catch
            {
                SelectionModeForCategory = "(unavailable)";
            }

            if (RegisteredSystemAids.Count > 0)
            {
                IsDefaultServiceForAid = cardEmulationInstance?.IsDefaultServiceForAid(component, RegisteredSystemAids[0]) ?? false;
            }

            NfcJson.Append(aidManagementJsonlEntries, 100, "aid_mgmt", "query", new
            {
                category,
                aids = RegisteredSystemAids,
                isDefaultForCategory = IsDefaultServiceForCategory,
                isDefaultForAid = IsDefaultServiceForAid,
                selectionMode = SelectionModeForCategory
            });
        }
        catch (Exception ex)
        {
            NfcJson.Append(aidManagementJsonlEntries, 100, "aid_mgmt", "query_error", new { error = ex.Message });
        }
    }

    private void RegisterBroadcastReceivers()
    {
        var context = Platform.AppContext;

        adapterStateReceiver = new NfcBroadcastReceiver((_, intent) =>
        {
            var state = intent?.GetIntExtra(NfcAdapter.ExtraAdapterState, 0) ?? 0;
            var stateName = state switch
            {
                1 => "OFF",
                2 => "TURNING_ON",
                3 => "ON",
                4 => "TURNING_OFF",
                _ => $"UNKNOWN ({state})"
            };

            AppendEvent(adapterStateEvents, $"📡 Adapter state → {stateName}");
            NfcJson.Append(adapterStateJsonlEntries, 100, "adapter_state", "changed", new { state, stateName });
            IsEnabled = state == 3;
            RaiseChanged();
        });
        context.RegisterReceiver(adapterStateReceiver, new IntentFilter(NfcAdapter.ActionAdapterStateChanged));

        seTransactionReceiver = new NfcBroadcastReceiver((_, intent) =>
        {
            var aidBytes = intent?.GetByteArrayExtra(NfcAdapter.ExtraAid);
            var dataBytes = intent?.GetByteArrayExtra(NfcAdapter.ExtraData);
            var seName = intent?.GetStringExtra(NfcAdapter.ExtraSecureElementName) ?? "(unknown)";
            var aidHex = aidBytes is { Length: > 0 } ? Convert.ToHexString(aidBytes) : "(none)";
            var dataHex = dataBytes is { Length: > 0 } ? Convert.ToHexString(dataBytes) : "(none)";

            AppendEvent(seTransactionEvents, $"🔐 SE transaction • {seName} • AID={aidHex}");
            NfcJson.Append(seTransactionJsonlEntries, 100, "se_transaction", "detected", new
            {
                securElement = seName,
                aidHex,
                dataHex,
                dataPlaintext = dataBytes is { Length: > 0 } ? SafeDecodePrintable(dataBytes) : "(empty)"
            });
            RaiseChanged();
        });
        context.RegisterReceiver(seTransactionReceiver, new IntentFilter(NfcAdapter.ActionTransactionDetected));

        preferredPaymentReceiver = new NfcBroadcastReceiver((_, intent) =>
        {
            var reason = intent?.GetIntExtra(NfcAdapter.ExtraPreferredPaymentChangedReason, -1) ?? -1;
            var reasonName = reason switch
            {
                1 => "LOADED",
                2 => "CHANGED",
                3 => "UPDATED",
                _ => $"UNKNOWN ({reason})"
            };

            NfcJson.Append(adapterStateJsonlEntries, 100, "adapter_state", "preferred_payment_changed", new { reason, reasonName });
            RaiseChanged();
        });
        context.RegisterReceiver(preferredPaymentReceiver, new IntentFilter(NfcAdapter.ActionPreferredPaymentChanged));
    }

    private sealed class NfcBroadcastReceiver(Action<Context?, Intent?> handler) : BroadcastReceiver
    {
        public override void OnReceive(Context? context, Intent? intent) => handler(context, intent);
    }

    private async Task ProcessTagAsync(Tag tag)
    {
        try
        {
            await ioGate.WaitAsync().ConfigureAwait(false);
            try
            {
                latestTagHandle = tag;

                var wroteTag = false;
                var draft = PendingWrite;
                var writeOutcome = draft is null
                    ? "🧪 Inspect only. No write was armed."
                    : TryWriteTag(tag, draft, out wroteTag);

                if (wroteTag)
                {
                    PendingWrite = null;
                }

                LatestTag = BuildSnapshot(tag, writeOutcome);
                LatestNfcTag = tag;
                LastWriteStatus = writeOutcome;
                AppendEvent(rawEvents, $"🏷️ Captured tag • {LatestTag.Summary} • {string.Join(", ", LatestTag.Technologies)}");
                StatusText = $"{LatestTag.Summary} • {LatestTag.CapturedAtUtc.ToLocalTime():HH:mm:ss}";
                LogSession("tag", "discovered", new
                {
                    LatestTag.Summary,
                    LatestTag.IdentifierHex,
                    LatestTag.CardType,
                    LatestTag.Manufacturer,
                    LatestTag.Technologies,
                    RecordCount = LatestTag.Records.Count,
                    LatestTag.WriteOutcome,
                    LatestTag.CapturedAtUtc
                });
                SyncHceState();
            }
            finally
            {
                ioGate.Release();
            }
        }
        catch (Exception ex)
        {
            StatusText = $"⚠️ Tag processing failed • {ex.Message}";
        }

        RaiseChanged();
    }

    private static NfcTagSnapshot BuildSnapshot(Tag tag, string writeOutcome)
    {
        var technologies = (tag.GetTechList() ?? Array.Empty<string>())
            .Select(ShortName)
            .Distinct(StringComparer.Ordinal)
            .OrderBy(value => value, StringComparer.Ordinal)
            .ToArray();

        var uid = tag.GetId();
        var identifierHex = uid is { Length: > 0 } ? Convert.ToHexString(uid) : "(none)";
        var manufacturer = DecodeManufacturer(uid);
        var cardType = "(unknown)";

        var nfcATech = NfcA.Get(tag);
        if (nfcATech is not null)
        {
            cardType = DecodeCardType(nfcATech.Sak, nfcATech.GetAtqa());
        }
        else if (technologies.Contains(nameof(NfcB), StringComparer.Ordinal))
        {
            cardType = "ISO 14443-3B tag";
        }
        else if (technologies.Contains(nameof(NfcF), StringComparer.Ordinal))
        {
            cardType = "FeliCa / NFC-F tag";
        }
        else if (technologies.Contains(nameof(NfcV), StringComparer.Ordinal))
        {
            cardType = "ISO 15693 / NFC-V tag";
        }

        var summary = technologies.Contains(nameof(IsoDep), StringComparer.Ordinal)
            ? $"💳 ISO-DEP smart tag • {cardType}"
            : technologies.Contains(nameof(NfcF), StringComparer.Ordinal)
                ? $"🌊 NFC-F tag • {cardType}"
                : technologies.Contains(nameof(MifareClassic), StringComparer.Ordinal)
                    ? $"🧱 MIFARE Classic • {cardType}"
                    : technologies.Contains(nameof(MifareUltralight), StringComparer.Ordinal)
                        ? $"🌿 MIFARE Ultralight / NTAG • {cardType}"
                        : $"🏷️ NFC tag • {cardType}";

        var headlineFacts = new List<string>
        {
            $"🧬 ID • {identifierHex}",
            $"🏭 Manufacturer • {manufacturer}",
            $"🪪 Card type • {cardType}",
            $"🧩 Tech • {string.Join(", ", technologies)}"
        };

        var details = new List<string>();
        var records = new List<NdefRecordSnapshot>();
        var mifareClassicSectors = new List<MifareClassicSectorDump>();
        var mifareUltralightPages = new List<MifareUltralightPageDump>();

        AppendNfcADetails(tag, headlineFacts, details);
        AppendNfcBDetails(tag, details);
        AppendNfcFDetails(tag, details);
        AppendNfcVDetails(tag, details);
        AppendIsoDepDetails(tag, headlineFacts, details);
        AppendMifareClassicDetails(tag, details, mifareClassicSectors);
        AppendMifareUltralightDetails(tag, details, mifareUltralightPages);
        AppendBarcodeDetails(tag, details);
        AppendNdefDetails(tag, headlineFacts, records, details);

        if (records.Count == 0)
        {
            details.Add("📭 No NDEF records were decoded from this tag.");
        }

        return new NfcTagSnapshot(summary, identifierHex, cardType, manufacturer, technologies, headlineFacts, records, details, mifareClassicSectors, mifareUltralightPages, writeOutcome, DateTimeOffset.UtcNow);
    }

    private static string DecodeCardType(short sak, byte[]? atqa)
    {
        if (atqa is [0x44, 0x03] && sak == 0x20)
        {
            return "MIFARE DESFire / Plus SL3";
        }

        if (atqa is [0x44, 0x00] && sak == 0x20)
        {
            return "MIFARE Plus SL0/SL3";
        }

        return sak switch
        {
            0x00 => "MIFARE Ultralight / NTAG",
            0x01 => "TNP3xxx (NXP proprietary)",
            0x08 => "MIFARE Classic 1K / Plus SE 1K",
            0x09 => "MIFARE Mini 320 bytes",
            0x10 => "MIFARE Plus 2K SL2",
            0x11 => "MIFARE Plus 4K SL2",
            0x18 => "MIFARE Classic 4K / Plus S 4K",
            0x19 => "MIFARE Classic 4K (emulated)",
            0x20 => "MIFARE Plus / DESFire / JCOP",
            0x24 => "MIFARE DESFire CL2",
            0x28 => "Smart MX with MIFARE Classic 1K",
            0x38 => "Smart MX with MIFARE Classic 4K",
            0x88 => "MIFARE Classic 1K (Infineon)",
            0x98 => "MIFARE PRO X",
            0xB8 => "MIFARE PRO X",
            _ => $"Unknown (SAK 0x{sak:X2})"
        };
    }

    private static string DecodeManufacturer(byte[]? uid)
    {
        if (uid is null || uid.Length == 0)
        {
            return "Unknown";
        }

        return uid[0] switch
        {
            0x01 => "Motorola",
            0x02 => "STMicroelectronics",
            0x03 => "Hitachi",
            0x04 => "NXP Semiconductors",
            0x05 => "Infineon Technologies",
            0x06 => "Cylink",
            0x07 => "Texas Instruments",
            0x08 => "Fujitsu",
            0x09 => "Matsushita (Panasonic)",
            0x0A => "NEC",
            0x0B => "Oki Electric",
            0x0C => "Toshiba",
            0x0D => "Mitsubishi Electric",
            0x0E => "Samsung Electronics",
            0x0F => "Hyundai Electronics",
            0x10 => "LG Semiconductors",
            0x11 => "Emosyn-EM Microelectronics",
            0x12 => "INSIDE Technology",
            0x13 => "ORGA Kartensysteme",
            0x14 => "SHARP",
            0x15 => "ATMEL",
            0x16 => "EM Microelectronic-Marin",
            0x17 => "SMARTRAC Technology",
            0x18 => "ZMD AG",
            0x19 => "XICOR",
            0x1A => "Sony",
            0x1B => "Malaysia Microelectronic Solutions",
            0x1C => "Emosyn",
            0x1D => "Shanghai Fudan Microelectronics",
            0x1E => "Magellan Technology",
            0x1F => "Melexis",
            0x20 => "Renesas Technology",
            0x21 => "TAGSYS",
            0x22 => "Transcore",
            0x23 => "Shanghai belling",
            0x24 => "Masktech",
            0x25 => "Innovision Research and Technology",
            0x26 => "Hitachi ULSI Systems",
            0x27 => "Yubico",
            0x28 => "Ricoh",
            0x29 => "ASK",
            0x2A => "Unicore Microsystems",
            0x2B => "Dallas Semiconductor/Maxim",
            0x2C => "Impinj",
            0x2D => "RightPlug Alliance",
            0x2E => "Broadcom",
            0x2F => "MStar Semiconductor",
            0x30 => "BeeDar Technology",
            0x31 => "RFIDsec",
            0x32 => "Schweizer Electronic",
            0x33 => "AMIC Technology",
            0x34 => "Mikron JSC",
            0x35 => "Fraunhofer IMS",
            0x36 => "IDS Microchip",
            0x37 => "Thinfilm (formerly Kovio)",
            0x38 => "HMT Microelectronics",
            0x39 => "Silicon Craft Technology",
            0x3A => "Advanced Film Device",
            0x3B => "Nitecrest",
            0x3C => "Verayo",
            0x3D => "HID Global",
            0x3E => "Productivity Engineering",
            0x3F => "Austriamicrosystems",
            0x40 => "Gemalto / Thales",
            0x41 => "Renesas Electronics",
            0x42 => "3Alogics",
            0x43 => "Top TroniQ Asia",
            0x44 => "Gentag",
            0x45 => "Invengo Information Technology",
            0x46 => "Guangzhou Sysur Microelectronics",
            0x47 => "CEITEC",
            0x48 => "Shanghai Quanray Electronics",
            0x49 => "MediaTek",
            0x4A => "Angstrem",
            0x4B => "Celisic Semiconductor",
            0x4C => "LEGIC Identsystems",
            0x4D => "Balluff",
            0x4E => "Oberthur Technologies",
            0x4F => "Silterra Malaysia",
            0x50 => "DELTA Danish Electronics",
            0x51 => "Giesecke & Devrient",
            0x52 => "Shenzhen China Vision Microelectronics",
            0x53 => "Shanghai Feiju Microelectronics",
            0x54 => "Intel",
            0x55 => "Microsensys",
            0x56 => "Sonix Technology",
            0x57 => "Qualcomm",
            0x58 => "Realtek Semiconductor",
            0x59 => "Freevision Technologies",
            0x5A => "Giantec Semiconductor",
            0x5B => "JSC Angstrem-T",
            0x5C => "STARCHIP France",
            0x5D => "SPIRTECH",
            0x5E => "GANTNER Electronic",
            0x5F => "Nordic Semiconductor",
            0x60 => "Verisiti",
            0x61 => "Wearlinks Technology",
            0x62 => "UserStar Information Systems",
            0x63 => "Pragmatic Printing",
            0x64 => "Associação do Laboratório de Sistemas Integráveis Tecnológico",
            0x65 => "Tendyron",
            0x66 => "MUTO Smart",
            0x67 => "ON Semiconductor",
            0x68 => "TÜBİTAK BİLGEM",
            0x69 => "Huada Semiconductor",
            0x6A => "SEVENEY",
            0x6B => "ISSM",
            0x6C => "Wisesec",
            0x88 => "Infineon Technologies (legacy NFC)",
            _ => $"Vendor 0x{uid[0]:X2}"
        };
    }

    private static void AppendNfcADetails(Tag tag, List<string> headlineFacts, List<string> details)
    {
        var tech = NfcA.Get(tag);
        if (tech is null)
        {
            return;
        }

        var atqa = tech.GetAtqa();
        var sak = tech.Sak;
        var cardType = DecodeCardType(sak, atqa);

        details.Add($"🅰️ NfcA SAK • 0x{sak:X2} → {cardType}");
        details.Add($"🅰️ NfcA ATQA • {FormatBytes(atqa)} → anticollision={DecodeAtqa(atqa)}");
        details.Add($"🅰️ NfcA max transceive • {tech.MaxTransceiveLength} bytes");
        if (sak != 0)
        {
            headlineFacts.Add($"🪄 SAK • 0x{sak:X2} → {cardType}");
        }
    }

    private static string DecodeAtqa(byte[]? atqa)
    {
        if (atqa is null || atqa.Length < 2)
        {
            return "(none)";
        }

        var bitFrame = atqa[0] & 0x1F;
        var anticollision = (atqa[1] >> 6) & 0x03;
        return $"bitFrame={bitFrame}, uid_size={anticollision switch { 0 => "single", 1 => "double", 2 => "triple", _ => "rfu" }}";
    }

    private static void AppendNfcBDetails(Tag tag, List<string> details)
    {
        var tech = NfcB.Get(tag);
        if (tech is null)
        {
            return;
        }

        var appData = tech.GetApplicationData();
        var protocolInfo = tech.GetProtocolInfo();

        details.Add($"🅱️ NfcB app data • {FormatBytes(appData)} → {SafeDecodePrintable(appData)}");
        details.Add($"🅱️ NfcB protocol info • {FormatBytes(protocolInfo)} → bitRate={DecodeNfcBProtocol(protocolInfo)}");
        details.Add($"🅱️ NfcB max transceive • {tech.MaxTransceiveLength} bytes");
    }

    private static string DecodeNfcBProtocol(byte[]? protocolInfo)
    {
        if (protocolInfo is null || protocolInfo.Length < 3)
        {
            return "(none)";
        }

        var dr = (protocolInfo[0] >> 4) & 0x07;
        var ds = protocolInfo[0] & 0x07;
        var fwi = (protocolInfo[2] >> 4) & 0x0F;
        return $"DR={dr}, DS={ds}, FWI={fwi}";
    }

    private static void AppendNfcFDetails(Tag tag, List<string> details)
    {
        var tech = NfcF.Get(tag);
        if (tech is null)
        {
            return;
        }

        var systemCode = tech.GetSystemCode();
        var manufacturer = tech.GetManufacturer();

        details.Add($"🇯🇵 NfcF system code • {FormatBytes(systemCode)} → {DecodeFeliCaSystemCode(systemCode)}");
        details.Add($"🏭 NfcF manufacturer (IDm) • {FormatBytes(manufacturer)} → {DecodeFeliCaIdm(manufacturer)}");
        details.Add($"🇯🇵 NfcF max transceive • {tech.MaxTransceiveLength} bytes");
    }

    private static string DecodeFeliCaSystemCode(byte[]? systemCode)
    {
        if (systemCode is null || systemCode.Length < 2)
        {
            return "(none)";
        }

        var code = (systemCode[0] << 8) | systemCode[1];
        return code switch
        {
            0x0003 => "NDEF on FeliCa Lite",
            0x88B4 => "FeliCa Lite / Lite-S",
            0x8FC1 => "Common Area (Suica/PASMO/IC card)",
            0xFE00 => "Common Area (wildcard)",
            0x8008 => "Edy (electronic money)",
            0x86A7 => "WAON",
            _ => $"system 0x{code:X4}"
        };
    }

    private static string DecodeFeliCaIdm(byte[]? manufacturer)
    {
        if (manufacturer is null || manufacturer.Length < 2)
        {
            return "(none)";
        }

        return manufacturer[0] switch
        {
            0x01 => "Sony (FeliCa Standard)",
            0x02 => "Sony (FeliCa Lite)",
            0x03 => "Sony (FeliCa Link)",
            0x06 => "Sony (FeliCa Plug)",
            0x88 => "NXP (FeliCa compatibility)",
            _ => $"maker 0x{manufacturer[0]:X2}"
        };
    }

    private static void AppendNfcVDetails(Tag tag, List<string> details)
    {
        var tech = NfcV.Get(tag);
        if (tech is null)
        {
            return;
        }

        details.Add($"🛰️ NfcV DSFID • 0x{(byte)tech.DsfId:X2} → {DecodeNfcVDsfId((byte)tech.DsfId)}");
        details.Add($"🛰️ NfcV response flags • 0x{(byte)tech.ResponseFlags:X2}");
        details.Add($"🛰️ NfcV max transceive • {tech.MaxTransceiveLength} bytes");
    }

    private static string DecodeNfcVDsfId(byte dsfId)
    {
        return dsfId switch
        {
            0x00 => "not supported",
            _ => $"format code {dsfId}"
        };
    }

    private static void AppendIsoDepDetails(Tag tag, List<string> headlineFacts, List<string> details)
    {
        var tech = IsoDep.Get(tag);
        if (tech is null)
        {
            return;
        }

        var historicalBytes = tech.GetHistoricalBytes();
        var hiLayerResponse = tech.GetHiLayerResponse();

        headlineFacts.Add($"📦 ISO-DEP max transceive • {tech.MaxTransceiveLength} bytes");
        details.Add($"💬 Extended APDU support • {(tech.IsExtendedLengthApduSupported ? "yes" : "no")}");
        details.Add($"📚 Historical bytes • {FormatBytes(historicalBytes)} → {SafeDecodePrintable(historicalBytes)}");
        details.Add($"🛰️ Hi-layer response • {FormatBytes(hiLayerResponse)} → {SafeDecodePrintable(hiLayerResponse)}");
        details.Add($"⏱️ Timeout • {tech.Timeout} ms");

        if (historicalBytes is { Length: > 0 })
        {
            DecodeHistoricalBytes(historicalBytes, details);
        }
    }

    private static void DecodeHistoricalBytes(byte[] historical, List<string> details)
    {
        if (historical.Length == 0)
        {
            return;
        }

        var category = historical[0];
        details.Add($"📋 Historical bytes category indicator • 0x{category:X2} → {category switch
        {
            0x00 => "status info at end only",
            0x10 => "DIR data reference",
            0x80 => "COMPACT-TLV objects follow",
            _ => "proprietary"
        }}");

        if (category == 0x80 && historical.Length > 1)
        {
            var offset = 1;
            while (offset < historical.Length - 2)
            {
                var tagByte = historical[offset];
                var tagType = (tagByte >> 4) & 0x0F;
                var length = tagByte & 0x0F;
                if (offset + 1 + length > historical.Length)
                {
                    break;
                }

                var value = historical.Skip(offset + 1).Take(length).ToArray();
                details.Add($"📋 COMPACT-TLV tag=0x{tagByte:X2} ({tagType switch
                {
                    1 => "country code",
                    2 => "issuer id",
                    3 => "card service data",
                    4 => "initial access data",
                    5 => "card issuer data",
                    6 => "pre-issuing data",
                    7 => "card capabilities",
                    _ => "unknown"
                }}) • {FormatBytes(value)}");

                offset += 1 + length;
            }
        }
    }

    private static void AppendMifareClassicDetails(Tag tag, List<string> details, List<MifareClassicSectorDump> sectorDumps)
    {
        var tech = MifareClassic.Get(tag);
        if (tech is null)
        {
            return;
        }

        var typeName = tech.Type switch
        {
            MifareClassicType.Classic => "Classic",
            MifareClassicType.Plus => "Plus",
            MifareClassicType.Pro => "Pro",
            _ => $"Unknown ({tech.Type})"
        };

        var sizeName = tech.Size switch
        {
            320 => "Mini (320 bytes)",
            1024 => "1K (1024 bytes)",
            2048 => "2K (2048 bytes)",
            4096 => "4K (4096 bytes)",
            _ => $"{tech.Size} bytes"
        };

        details.Add($"🧱 MIFARE Classic type • {typeName}");
        details.Add($"🧱 MIFARE Classic size • {sizeName}");
        details.Add($"🧱 MIFARE Classic sectors • {tech.SectorCount}");
        details.Add($"🧱 MIFARE Classic blocks • {tech.BlockCount}");
        details.Add($"🧱 MIFARE Classic max transceive • {tech.MaxTransceiveLength} bytes");

        try
        {
            tech.Connect();
            var keys = new[] { MifareKeyDefault, MifareKeyMad, MifareKeyNfcForum };
            var keyNames = new[] { "FF (default)", "MAD", "NFC Forum" };

            for (var sector = 0; sector < tech.SectorCount; sector++)
            {
                var authenticated = false;
                var usedKeyName = "(none)";

                for (var keyIndex = 0; keyIndex < keys.Length; keyIndex++)
                {
                    if (tech.AuthenticateSectorWithKeyA(sector, keys[keyIndex]))
                    {
                        authenticated = true;
                        usedKeyName = $"A:{keyNames[keyIndex]}";
                        break;
                    }

                    if (tech.AuthenticateSectorWithKeyB(sector, keys[keyIndex]))
                    {
                        authenticated = true;
                        usedKeyName = $"B:{keyNames[keyIndex]}";
                        break;
                    }
                }

                if (!authenticated)
                {
                    details.Add($"🔒 Sector {sector} • authentication failed with all default keys");
                    continue;
                }

                var firstBlock = tech.SectorToBlock(sector);
                var blockCount = tech.GetBlockCountInSector(sector);
                var blocks = new List<MifareClassicBlockDump>();

                for (var blockOffset = 0; blockOffset < blockCount; blockOffset++)
                {
                    var blockIndex = firstBlock + blockOffset;
                    try
                    {
                        var data = tech.ReadBlock(blockIndex) ?? [];
                        var blockType = ClassifyMifareBlock(sector, blockOffset, blockCount);
                        var plaintext = SafeDecodePrintable(data);
                        blocks.Add(new MifareClassicBlockDump(blockIndex, Convert.ToHexString(data), plaintext, blockType));
                        details.Add($"🧱 Block {blockIndex} [{blockType}] • {FormatBytes(data)} → {plaintext}");
                    }
                    catch (Exception ex)
                    {
                        blocks.Add(new MifareClassicBlockDump(blockIndex, string.Empty, string.Empty, $"read_error: {ex.Message}"));
                        details.Add($"🧱 Block {blockIndex} • read error: {ex.Message}");
                    }
                }

                sectorDumps.Add(new MifareClassicSectorDump(sector, firstBlock, usedKeyName, blocks));
            }
        }
        catch (Exception ex)
        {
            details.Add($"⚠️ MIFARE Classic dump failed • {ex.Message}");
        }
        finally
        {
            SafeClose(tech);
        }
    }

    private static void AppendMifareUltralightDetails(Tag tag, List<string> details, List<MifareUltralightPageDump> pageDumps)
    {
        var tech = MifareUltralight.Get(tag);
        if (tech is null)
        {
            return;
        }

        var typeName = tech.Type switch
        {
            MifareUltralightType.Ultralight => "Ultralight",
            MifareUltralightType.UltralightC => "Ultralight C",
            _ => $"Unknown ({tech.Type})"
        };

        details.Add($"🌿 MIFARE Ultralight type • {typeName}");
        details.Add($"🌿 MIFARE Ultralight max transceive • {tech.MaxTransceiveLength} bytes");

        try
        {
            tech.Connect();

            var maxPages = typeName switch
            {
                "Ultralight" => 16,
                "Ultralight C" => 48,
                _ => 64
            };

            for (var page = 0; page < maxPages; page += 4)
            {
                byte[] data;
                try
                {
                    data = tech.ReadPages(page) ?? [];
                }
                catch
                {
                    details.Add($"🌿 Page {page}+ • read stopped (end of readable area or auth required)");
                    break;
                }

                for (var offset = 0; offset < data.Length && offset < 16 && page + offset / 4 < maxPages; offset += 4)
                {
                    var pageIndex = page + offset / 4;
                    var pageData = data.Skip(offset).Take(4).ToArray();
                    var pageType = ClassifyUltralightPage(pageIndex);
                    var plaintext = SafeDecodePrintable(pageData);
                    pageDumps.Add(new MifareUltralightPageDump(pageIndex, Convert.ToHexString(pageData), plaintext, pageType));
                    details.Add($"🌿 Page {pageIndex} [{pageType}] • {FormatBytes(pageData)} → {plaintext}");
                }
            }
        }
        catch (Exception ex)
        {
            details.Add($"⚠️ MIFARE Ultralight dump failed • {ex.Message}");
        }
        finally
        {
            SafeClose(tech);
        }
    }

    private static void AppendBarcodeDetails(Tag tag, List<string> details)
    {
        var tech = NfcBarcode.Get(tag);
        if (tech is null)
        {
            return;
        }

        var barcodeData = tech.GetBarcode();
        details.Add($"🧾 Barcode type • {tech.Type}");
        details.Add($"🧾 Barcode bytes • {FormatBytes(barcodeData)} → {SafeDecodePrintable(barcodeData)}");
    }

    private static void AppendNdefDetails(Tag tag, List<string> headlineFacts, List<NdefRecordSnapshot> records, List<string> details)
    {
        var ndef = Ndef.Get(tag);
        if (ndef is null)
        {
            if (NdefFormatable.Get(tag) is not null)
            {
                details.Add("🧪 Tag is NDEF-formatable but not currently formatted.");
            }

            return;
        }

        try
        {
            if (!ndef.IsConnected)
            {
                ndef.Connect();
            }

            headlineFacts.Add($"📦 NDEF max size • {ndef.MaxSize} bytes");
            headlineFacts.Add(ndef.IsWritable ? "✍️ NDEF writable" : "🔒 NDEF read-only");
            details.Add($"📦 NDEF type • {ndef.Type} → {DecodeNdefType(ndef.Type)}");
            details.Add($"📦 Can make read-only • {(ndef.CanMakeReadOnly() ? "yes" : "no")}");

            var message = ndef.CachedNdefMessage ?? ndef.NdefMessage;
            if (message is not null)
            {
                var rawBytes = message.ToByteArray() ?? [];
                details.Add($"📦 NDEF message size • {rawBytes.Length} bytes of {ndef.MaxSize} max ({rawBytes.Length * 100 / Math.Max(ndef.MaxSize, 1)}% used)");
            }

            foreach (var record in message?.GetRecords() ?? [])
            {
                records.Add(DescribeRecord(record));
            }
        }
        catch (System.Exception ex)
        {
            details.Add($"⚠️ NDEF read failed • {ex.Message}");
        }
        finally
        {
            SafeClose(ndef);
        }
    }

    private static string DecodeNdefType(string? type)
    {
        return type switch
        {
            "org.nfcforum.ndef.type1" => "NFC Forum Type 1 (Topaz/Broadcom)",
            "org.nfcforum.ndef.type2" => "NFC Forum Type 2 (NTAG/Ultralight)",
            "org.nfcforum.ndef.type3" => "NFC Forum Type 3 (FeliCa)",
            "org.nfcforum.ndef.type4" => "NFC Forum Type 4 (DESFire/ISO-DEP)",
            "com.nxp.ndef.mifareclassic" => "MIFARE Classic (NXP proprietary NDEF)",
            _ => type ?? "(unknown)"
        };
    }

    private static NdefRecordSnapshot DescribeRecord(NdefRecord record)
    {
        var payload = record.GetPayload() ?? [];
        var typeInfo = record.GetTypeInfo() ?? [];
        var recordId = record.GetId() ?? [];
        var payloadHex = Convert.ToHexString(payload);
        var typeHex = Convert.ToHexString(typeInfo);
        var idHex = recordId.Length > 0 ? Convert.ToHexString(recordId) : string.Empty;

        if (record.Tnf == NdefRecord.TnfEmpty)
        {
            return new NdefRecordSnapshot("⬜", "Empty", "(empty record)", payloadHex, string.Empty, string.Empty, typeHex, idHex, record.Tnf, []);
        }

        if (record.Tnf == NdefRecord.TnfWellKnown)
        {
            if (typeInfo.SequenceEqual(NdefRecord.RtdText ?? []))
            {
                var (text, lang, enc) = DecodeTextPayloadFull(payload);
                return new NdefRecordSnapshot("📝", "Text", text, payloadHex, lang, enc, typeHex, idHex, record.Tnf, []);
            }

            if (typeInfo.SequenceEqual(NdefRecord.RtdUri ?? []))
            {
                return new NdefRecordSnapshot("🔗", "URI", DecodeUriPayload(payload), payloadHex, string.Empty, "UTF-8", typeHex, idHex, record.Tnf, []);
            }

            if (typeInfo.SequenceEqual(NdefRecord.RtdSmartPoster ?? []))
            {
                var (summary, subRecords) = DecodeSmartPoster(payload);
                return new NdefRecordSnapshot("📲", "Smart Poster", summary, payloadHex, string.Empty, string.Empty, typeHex, idHex, record.Tnf, subRecords);
            }

            var wellKnownType = Encoding.ASCII.GetString(typeInfo);

            if (wellKnownType is "Hs")
            {
                return new NdefRecordSnapshot("🤝", "Handover Select", DecodeHandover(payload), payloadHex, string.Empty, string.Empty, typeHex, idHex, record.Tnf, []);
            }

            if (wellKnownType is "Hr")
            {
                return new NdefRecordSnapshot("🤝", "Handover Request", DecodeHandover(payload), payloadHex, string.Empty, string.Empty, typeHex, idHex, record.Tnf, []);
            }

            if (wellKnownType is "Hm")
            {
                return new NdefRecordSnapshot("🤝", "Handover Mediation", DecodeHandover(payload), payloadHex, string.Empty, string.Empty, typeHex, idHex, record.Tnf, []);
            }

            if (wellKnownType is "Hi")
            {
                return new NdefRecordSnapshot("🤝", "Handover Initiate", DecodeHandover(payload), payloadHex, string.Empty, string.Empty, typeHex, idHex, record.Tnf, []);
            }

            if (wellKnownType is "Hc")
            {
                return new NdefRecordSnapshot("📡", "Handover Carrier", TryDecodeUtf8(payload), payloadHex, string.Empty, string.Empty, typeHex, idHex, record.Tnf, []);
            }

            if (wellKnownType is "ac")
            {
                return new NdefRecordSnapshot("🔀", "Alternative Carrier", DecodeAlternativeCarrier(payload), payloadHex, string.Empty, string.Empty, typeHex, idHex, record.Tnf, []);
            }

            if (wellKnownType is "cr")
            {
                var collision = payload.Length >= 2 ? $"random={((payload[0] << 8) | payload[1])}" : TryDecodeUtf8(payload);
                return new NdefRecordSnapshot("🎲", "Collision Resolution", collision, payloadHex, string.Empty, string.Empty, typeHex, idHex, record.Tnf, []);
            }

            if (wellKnownType is "Sig")
            {
                return new NdefRecordSnapshot("🔏", "Signature", DecodeSignature(payload), payloadHex, string.Empty, string.Empty, typeHex, idHex, record.Tnf, []);
            }

            return new NdefRecordSnapshot("🧬", $"Well-Known • {wellKnownType}", TryDecodeUtf8(payload), payloadHex, string.Empty, string.Empty, typeHex, idHex, record.Tnf, []);
        }

        if (record.Tnf == NdefRecord.TnfMimeMedia)
        {
            var mimeType = Encoding.ASCII.GetString(typeInfo);
            var mimeText = TryDecodeUtf8(payload);

            if (mimeType.StartsWith("application/vnd.bluetooth", StringComparison.OrdinalIgnoreCase))
            {
                mimeText = DecodeBluetoothOob(payload);
            }
            else if (mimeType.Equals("application/vnd.wfa.wsc", StringComparison.OrdinalIgnoreCase))
            {
                mimeText = DecodeWifiSimpleConfig(payload);
            }

            return new NdefRecordSnapshot("📦", $"MIME • {mimeType}", mimeText, payloadHex, string.Empty, string.Empty, typeHex, idHex, record.Tnf, []);
        }

        if (record.Tnf == NdefRecord.TnfAbsoluteUri)
        {
            var uri = Encoding.UTF8.GetString(typeInfo);
            return new NdefRecordSnapshot("🌐", "Absolute URI", uri, payloadHex, string.Empty, "UTF-8", typeHex, idHex, record.Tnf, []);
        }

        if (record.Tnf == NdefRecord.TnfExternalType)
        {
            var externalType = Encoding.ASCII.GetString(typeInfo);
            if (string.Equals(externalType, "android.com:pkg", StringComparison.OrdinalIgnoreCase))
            {
                var packageName = Encoding.UTF8.GetString(payload);
                return new NdefRecordSnapshot("📱", "Android App Record", packageName, payloadHex, string.Empty, "UTF-8", typeHex, idHex, record.Tnf, []);
            }

            return new NdefRecordSnapshot("🌐", $"External • {externalType}", TryDecodeUtf8(payload), payloadHex, string.Empty, string.Empty, typeHex, idHex, record.Tnf, []);
        }

        if (record.Tnf == NdefRecord.TnfUnknown)
        {
            return new NdefRecordSnapshot("❓", "Unknown", TryDecodeUtf8(payload), payloadHex, string.Empty, string.Empty, typeHex, idHex, record.Tnf, []);
        }

        return new NdefRecordSnapshot("🧬", $"TNF {record.Tnf}", TryDecodeUtf8(payload), payloadHex, string.Empty, string.Empty, typeHex, idHex, record.Tnf, []);
    }

    private static (string Text, string LanguageCode, string Encoding) DecodeTextPayloadFull(byte[] payload)
    {
        if (payload.Length == 0)
        {
            return ("(empty)", string.Empty, "UTF-8");
        }

        var status = payload[0];
        var isUtf16 = (status & 0x80) != 0;
        var langLen = status & 0x3F;
        var textOffset = 1 + langLen;
        if (textOffset >= payload.Length)
        {
            return ("(empty)", string.Empty, isUtf16 ? "UTF-16" : "UTF-8");
        }

        var lang = Encoding.ASCII.GetString(payload, 1, langLen);
        var encoding = isUtf16 ? System.Text.Encoding.Unicode : System.Text.Encoding.UTF8;
        var text = encoding.GetString(payload, textOffset, payload.Length - textOffset);
        return (text, lang, isUtf16 ? "UTF-16" : "UTF-8");
    }

    private static string DecodeUriPayload(byte[] payload)
    {
        if (payload.Length == 0)
        {
            return "(empty)";
        }

        var prefix = payload[0] < UriPrefixes.Length ? UriPrefixes[payload[0]] : string.Empty;
        return prefix + Encoding.UTF8.GetString(payload, 1, payload.Length - 1);
    }

    private static (string Summary, IReadOnlyList<NdefRecordSnapshot> SubRecords) DecodeSmartPoster(byte[] payload)
    {
        if (payload.Length == 0)
        {
            return ("(empty)", []);
        }

        try
        {
            var inner = new NdefMessage(payload);
            var subRecords = (inner.GetRecords() ?? []).Select(DescribeRecord).ToArray();
            var parts = subRecords.Select(static r => $"{r.Kind}: {r.Summary}");
            return (string.Join(" | ", parts), subRecords);
        }
        catch
        {
            return (TryDecodeUtf8(payload), []);
        }
    }

    private static string DecodeHandover(byte[] payload)
    {
        if (payload.Length == 0)
        {
            return "(empty)";
        }

        var parts = new List<string>();
        if (payload.Length >= 1)
        {
            parts.Add($"version={payload[0] >> 4}.{payload[0] & 0x0F}");
        }

        if (payload.Length > 1)
        {
            try
            {
                var inner = new NdefMessage(payload.Skip(1).ToArray());
                var records = (inner.GetRecords() ?? []).Select(DescribeRecord).ToArray();
                parts.AddRange(records.Select(static r => $"{r.Kind}: {r.Summary}"));
            }
            catch
            {
                parts.Add($"raw: {SafeDecodePrintable(payload.Skip(1).ToArray())}");
            }
        }

        return string.Join(" | ", parts);
    }

    private static string DecodeAlternativeCarrier(byte[] payload)
    {
        if (payload.Length < 2)
        {
            return TryDecodeUtf8(payload);
        }

        var cps = payload[0];
        var cpsText = cps switch
        {
            0 => "inactive",
            1 => "active",
            2 => "activating",
            _ => $"0x{cps:X2}"
        };

        var carrierRefLen = payload[1];
        var carrierRef = payload.Length >= 2 + carrierRefLen
            ? Encoding.UTF8.GetString(payload, 2, carrierRefLen)
            : "(truncated)";

        return $"cps={cpsText}, carrier={carrierRef}";
    }

    private static string DecodeSignature(byte[] payload)
    {
        if (payload.Length < 2)
        {
            return TryDecodeUtf8(payload);
        }

        var version = payload[0];
        var sigType = payload[1] & 0x7F;
        var sigTypeName = sigType switch
        {
            0 => "no signature",
            1 => "RSASSA-PSS-1024",
            2 => "RSASSA-PKCS1-v1_5-1024",
            3 => "DSA-1024",
            4 => "ECDSA-P192",
            5 => "RSASSA-PSS-2048",
            6 => "RSASSA-PKCS1-v1_5-2048",
            7 => "DSA-2048",
            8 => "ECDSA-P256",
            _ => $"0x{sigType:X2}"
        };

        return $"version={version}, type={sigTypeName}, length={payload.Length} bytes";
    }

    private static string DecodeBluetoothOob(byte[] payload)
    {
        if (payload.Length < 8)
        {
            return TryDecodeUtf8(payload);
        }

        var parts = new List<string>();
        var oobLength = payload[0] | (payload[1] << 8);
        parts.Add($"OOB length={oobLength}");

        if (payload.Length >= 8)
        {
            var mac = string.Join(":", payload.Skip(2).Take(6).Reverse().Select(static b => $"{b:X2}"));
            parts.Add($"MAC={mac}");
        }

        if (payload.Length > 8)
        {
            var offset = 8;
            while (offset + 1 < payload.Length)
            {
                var eirLength = payload[offset];
                if (eirLength == 0 || offset + 1 + eirLength > payload.Length)
                {
                    break;
                }

                var eirType = payload[offset + 1];
                var eirData = payload.Skip(offset + 2).Take(eirLength - 1).ToArray();
                var eirName = eirType switch
                {
                    0x08 or 0x09 => $"name=\"{Encoding.UTF8.GetString(eirData)}\"",
                    0x0D => $"class=0x{Convert.ToHexString(eirData)}",
                    0x10 => "security_manager_tk",
                    0x11 => "security_manager_oob_flags",
                    0x22 => "LE_secure_confirm",
                    0x23 => "LE_secure_random",
                    _ => $"EIR_0x{eirType:X2}={Convert.ToHexString(eirData)}"
                };
                parts.Add(eirName);
                offset += 1 + eirLength;
            }
        }

        return string.Join(" | ", parts);
    }

    private static string DecodeWifiSimpleConfig(byte[] payload)
    {
        if (payload.Length < 4)
        {
            return TryDecodeUtf8(payload);
        }

        var parts = new List<string>();
        var offset = 0;
        while (offset + 4 <= payload.Length)
        {
            var attrId = (payload[offset] << 8) | payload[offset + 1];
            var attrLen = (payload[offset + 2] << 8) | payload[offset + 3];
            if (offset + 4 + attrLen > payload.Length)
            {
                break;
            }

            var attrData = payload.Skip(offset + 4).Take(attrLen).ToArray();
            var attrName = attrId switch
            {
                0x1045 => $"SSID=\"{Encoding.UTF8.GetString(attrData)}\"",
                0x1003 => $"auth_type=0x{Convert.ToHexString(attrData)}",
                0x100F => $"encryption_type=0x{Convert.ToHexString(attrData)}",
                0x1027 => $"network_key=\"{Encoding.UTF8.GetString(attrData)}\"",
                0x1020 => $"MAC={string.Join(":", attrData.Select(static b => $"{b:X2}"))}",
                _ => $"WSC_0x{attrId:X4}={Convert.ToHexString(attrData)}"
            };
            parts.Add(attrName);
            offset += 4 + attrLen;
        }

        return parts.Count > 0 ? string.Join(" | ", parts) : TryDecodeUtf8(payload);
    }

    private static string TryDecodeUtf8(byte[] payload)
    {
        if (payload.Length == 0)
        {
            return "(empty)";
        }

        try
        {
            var text = Encoding.UTF8.GetString(payload);
            return string.IsNullOrWhiteSpace(text) ? "(binary payload)" : text;
        }
        catch
        {
            return "(binary payload)";
        }
    }

    private static string TryDecodeUtf8Inline(byte[]? payload)
    {
        if (payload is null || payload.Length == 0)
        {
            return string.Empty;
        }

        try
        {
            var text = Encoding.UTF8.GetString(payload);
            var printable = text.All(static c => !char.IsControl(c) || c is '\n' or '\r' or '\t');
            return printable ? text : string.Empty;
        }
        catch
        {
            return string.Empty;
        }
    }

    private static string SafeDecodePrintable(byte[]? data)
    {
        if (data is null || data.Length == 0)
        {
            return "(empty)";
        }

        var sb = new StringBuilder(data.Length);
        foreach (var b in data)
        {
            sb.Append(b is >= 0x20 and <= 0x7E ? (char)b : '.');
        }

        return sb.ToString();
    }

    private static string ClassifyMifareBlock(int sector, int blockOffset, int blockCount)
    {
        if (sector == 0 && blockOffset == 0)
        {
            return "manufacturer";
        }

        if (blockOffset == blockCount - 1)
        {
            return "sector_trailer (KeyA + access_bits + KeyB)";
        }

        if (sector == 0 && blockOffset is 1 or 2)
        {
            return "MAD (MIFARE Application Directory)";
        }

        return "data";
    }

    private static string ClassifyUltralightPage(int pageIndex)
    {
        return pageIndex switch
        {
            0 => "UID bytes 0-2 + BCC0",
            1 => "UID bytes 3-6",
            2 => "BCC1 + internal + lock bytes",
            3 => "OTP (one-time programmable)",
            4 => "user data / CC (capability container)",
            >= 5 and <= 39 => "user data",
            40 => "NTAG dynamic lock bytes",
            41 => "NTAG config 0 (MIRROR/AUTH0)",
            42 => "NTAG config 1 (ACCESS/PWD)",
            43 => "NTAG PWD (password)",
            44 => "NTAG PACK (password ack)",
            _ => "user data / config"
        };
    }

    private static string TryWriteTag(Tag tag, NdefWriteDraft draft, out bool wroteTag)
    {
        wroteTag = false;

        try
        {
            var message = CreateMessage(draft);
            var messageLength = (message.ToByteArray() ?? []).Length;
            var ndef = Ndef.Get(tag);

            if (ndef is not null)
            {
                try
                {
                    ndef.Connect();
                    if (!ndef.IsWritable)
                    {
                        return "🔒 Tag exposes NDEF but is read-only. Pending write stays armed.";
                    }

                    if (ndef.MaxSize < messageLength)
                    {
                        return $"📏 Tag is too small for {messageLength} bytes. Pending write stays armed.";
                    }

                    ndef.WriteNdefMessage(message);
                    if (draft.MakeReadOnly)
                    {
                        if (ndef.CanMakeReadOnly())
                        {
                            ndef.MakeReadOnly();
                            wroteTag = true;
                            return $"✅ Wrote {messageLength} bytes and locked the tag • {draft.Summary}";
                        }

                        wroteTag = true;
                        return $"✅ Wrote {messageLength} bytes, but this tag cannot be locked • {draft.Summary}";
                    }

                    wroteTag = true;
                    return $"✅ Wrote {messageLength} bytes • {draft.Summary}";
                }
                finally
                {
                    SafeClose(ndef);
                }
            }

            var formatable = NdefFormatable.Get(tag);
            if (formatable is not null)
            {
                try
                {
                    formatable.Connect();
                    if (draft.MakeReadOnly)
                    {
                        formatable.FormatReadOnly(message);
                        wroteTag = true;
                        return $"✅ Formatted tag as NDEF and locked it • {draft.Summary}";
                    }

                    formatable.Format(message);
                    wroteTag = true;
                    return $"✅ Formatted tag as NDEF and wrote {messageLength} bytes • {draft.Summary}";
                }
                finally
                {
                    SafeClose(formatable);
                }
            }

            return "📭 This tag does not expose NDEF or NdefFormatable support. Pending write stays armed.";
        }
        catch (System.Exception ex)
        {
            return $"⚠️ Write failed • {ex.Message}. Pending write stays armed.";
        }
    }

    private static NdefMessage CreateMessage(NdefWriteDraft draft)
    {
        var record = draft.Kind switch
        {
            NdefPayloadKind.Uri => NdefRecord.CreateUri(draft.Content.Trim()),
            NdefPayloadKind.Mime => NdefRecord.CreateMime(draft.NormalizedMimeType, Encoding.UTF8.GetBytes(draft.Content)),
            NdefPayloadKind.External => NdefRecord.CreateExternal(draft.NormalizedExternalDomain, draft.NormalizedExternalType, Encoding.UTF8.GetBytes(draft.Content)),
            NdefPayloadKind.Aar => NdefRecord.CreateApplicationRecord(draft.Content.Trim()),
            NdefPayloadKind.SmartPoster => CreateSmartPosterRecord(draft.Content.Trim()),
            NdefPayloadKind.Handover => CreateHandoverSelectRecord(draft.Content.Trim()),
            _ => NdefRecord.CreateTextRecord("en", draft.Content)
        } ?? throw new System.InvalidOperationException("Failed to create an NDEF record.");

        return new NdefMessage([record]);
    }

    private static NdefRecord CreateSmartPosterRecord(string uri)
    {
        var uriRecord = NdefRecord.CreateUri(uri) ?? throw new InvalidOperationException("Failed to create URI record for Smart Poster.");
        var titleRecord = NdefRecord.CreateTextRecord("en", uri) ?? throw new InvalidOperationException("Failed to create title record for Smart Poster.");
        var innerMessage = new NdefMessage([uriRecord, titleRecord]);
        var innerBytes = innerMessage.ToByteArray() ?? [];
        return new NdefRecord(NdefRecord.TnfWellKnown, NdefRecord.RtdSmartPoster?.ToArray(), [], innerBytes);
    }

    private static NdefRecord CreateHandoverSelectRecord(string payload)
    {
        var versionByte = new byte[] { 0x15 };
        var carrierRecord = NdefRecord.CreateMime("application/vnd.bluetooth.ep.oob", Encoding.UTF8.GetBytes(payload));
        var acPayload = new byte[] { 0x01, 0x01, 0x00, 0x00 };
        var acRecord = new NdefRecord(NdefRecord.TnfWellKnown, Encoding.ASCII.GetBytes("ac"), [], acPayload);
        var innerMessage = new NdefMessage([acRecord!]);
        var innerBytes = innerMessage.ToByteArray() ?? [];
        var fullPayload = new byte[versionByte.Length + innerBytes.Length];
        versionByte.CopyTo(fullPayload, 0);
        innerBytes.CopyTo(fullPayload, versionByte.Length);
        return new NdefRecord(NdefRecord.TnfWellKnown, Encoding.ASCII.GetBytes("Hs"), [], fullPayload);
    }

    private static byte[] Transceive(NfcA? technology, byte[] command, string techName)
    {
        return TransceiveInternal(technology, command, techName, static (tech, frame) => tech.Transceive(frame) ?? []);
    }

    private static byte[] Transceive(NfcB? technology, byte[] command, string techName)
    {
        return TransceiveInternal(technology, command, techName, static (tech, frame) => tech.Transceive(frame) ?? []);
    }

    private static byte[] Transceive(NfcF? technology, byte[] command, string techName)
    {
        return TransceiveInternal(technology, command, techName, static (tech, frame) => tech.Transceive(frame) ?? []);
    }

    private static byte[] Transceive(NfcV? technology, byte[] command, string techName)
    {
        return TransceiveInternal(technology, command, techName, static (tech, frame) => tech.Transceive(frame) ?? []);
    }

    private static byte[] Transceive(IsoDep? technology, byte[] command, string techName)
    {
        return TransceiveInternal(technology, command, techName, static (tech, frame) => tech.Transceive(frame) ?? []);
    }

    private static byte[] Transceive(MifareClassic? technology, byte[] command, string techName)
    {
        return TransceiveInternal(technology, command, techName, static (tech, frame) => tech.Transceive(frame) ?? []);
    }

    private static byte[] Transceive(MifareUltralight? technology, byte[] command, string techName)
    {
        return TransceiveInternal(technology, command, techName, static (tech, frame) => tech.Transceive(frame) ?? []);
    }

    private static byte[] TransceiveInternal<TTechnology>(TTechnology? technology, byte[] command, string techName, Func<TTechnology, byte[], byte[]> send)
        where TTechnology : Java.Lang.Object, Java.IO.ICloseable, ITagTechnology
    {
        if (technology is null)
        {
            throw new InvalidOperationException($"{techName} is not available for the latest tag.");
        }

        try
        {
            technology.Connect();
            return send(technology, command) ?? [];
        }
        finally
        {
            SafeClose(technology);
        }
    }

    private static byte[] ParseHex(string value)
    {
        var cleaned = new string(value.Where(Uri.IsHexDigit).ToArray());
        if (string.IsNullOrWhiteSpace(cleaned))
        {
            throw new InvalidOperationException("Provide at least one byte.");
        }

        if ((cleaned.Length & 1) != 0)
        {
            throw new InvalidOperationException("Hex input must contain an even number of digits.");
        }

        return Convert.FromHexString(cleaned);
    }

    private static string ShortName(string technologyName)
    {
        var lastDot = technologyName.LastIndexOf('.');
        return lastDot >= 0 ? technologyName[(lastDot + 1)..] : technologyName;
    }

    private static string FormatBytes(byte[]? bytes) => bytes is { Length: > 0 } ? Convert.ToHexString(bytes) : "(none)";

    private static string FormatBytesWithSpaces(byte[]? bytes)
    {
        return bytes is { Length: > 0 } ? FormatHex(Convert.ToHexString(bytes)) : "(none)";
    }

    private static string FormatHex(string hex)
    {
        return string.Join(' ', Enumerable.Range(0, hex.Length / 2).Select(index => hex.Substring(index * 2, 2)));
    }

    private static void SafeClose(Java.IO.ICloseable? closeable)
    {
        try
        {
            closeable?.Close();
        }
        catch
        {
        }
    }

    private NfcAdapter? ResolveAdapter()
    {
        var context = Platform.CurrentActivity ?? Platform.AppContext;
        return (context.GetSystemService(Context.NfcService) as NfcManager)?.DefaultAdapter;
    }

    private void EnsureForegroundDispatchResources(Activity activity)
    {
        if (foregroundPendingIntent is not null)
        {
            return;
        }

        foregroundPendingIntent = PendingIntent.GetActivity(
            activity, 0,
            new Intent(activity, activity.GetType()).AddFlags(ActivityFlags.SingleTop),
            PendingIntentFlags.Mutable);

        var ndefFilter = new IntentFilter(NfcAdapter.ActionNdefDiscovered);
        try
        {
            ndefFilter.AddDataType("*/*");
        }
        catch
        {
        }

        foregroundIntentFilters =
        [
            ndefFilter,
            new IntentFilter(NfcAdapter.ActionTechDiscovered),
            new IntentFilter(NfcAdapter.ActionTagDiscovered)
        ];

        foregroundTechLists =
        [
            [Java.Lang.Class.FromType(typeof(Ndef)).Name!],
            [Java.Lang.Class.FromType(typeof(NdefFormatable)).Name!],
            [Java.Lang.Class.FromType(typeof(NfcA)).Name!],
            [Java.Lang.Class.FromType(typeof(NfcB)).Name!],
            [Java.Lang.Class.FromType(typeof(NfcF)).Name!],
            [Java.Lang.Class.FromType(typeof(NfcV)).Name!],
            [Java.Lang.Class.FromType(typeof(IsoDep)).Name!],
            [Java.Lang.Class.FromType(typeof(MifareClassic)).Name!],
            [Java.Lang.Class.FromType(typeof(MifareUltralight)).Name!],
            [Java.Lang.Class.FromType(typeof(NfcBarcode)).Name!]
        ];
    }

    private string BuildAdapterSnapshotJson()
    {
        return NfcJson.Serialize(new
        {
            IsSupported,
            IsEnabled,
            IsListening,
            IsForegroundDispatchEnabled,
            SupportsHce,
            SupportsNfcFCardEmulation,
            IsHceFEnabled,
            SupportsObserveMode,
            IsObserveModeEnabled,
            ShouldDefaultToObserveMode,
            SupportsTagIntentPreference,
            IsTagIntentAllowed,
            SupportsReaderOption,
            IsReaderOptionEnabled,
            SupportsSecureNfc,
            IsSecureNfcEnabled,
            SupportsAidPrefixRegistration,
            AllowsOtherCategoryForegroundPreference,
            IsPreferredService,
            HasCustomDiscoveryTechnology,
            DefaultNfcSubscriptionId,
            PreferredPaymentDescription,
            PreferredPaymentRoute,
            LastIntentAction,
            HceAidHex,
            HceFSystemCodeHex,
            HceFNfcid2Hex,
            HceFT3tPmmHex,
            RegisteredHceAids,
            PollingFilters,
            PollingPatternFilters,
            AntennaFacts,
            CapabilityNotes
        });
    }

    private void LogSession(string stream, string eventType, object? payload)
    {
        NfcJson.Append(sessionJsonlEntries, 500, $"session.{stream}", eventType, payload);
    }

    private void AppendAntennaFacts(NfcAdapter? currentAdapter)
    {
        antennaFacts.Clear();

        var antennaInfo = currentAdapter?.NfcAntennaInfo;
        if (antennaInfo is null)
        {
            antennaFacts.Add("📍 Antenna placement details are not exposed by this device.");
            return;
        }

        antennaFacts.Add($"📐 Device size • {antennaInfo.DeviceWidth} × {antennaInfo.DeviceHeight}");
        antennaFacts.Add(antennaInfo.IsDeviceFoldable
            ? "🪭 Device reports foldable antenna geometry."
            : "📱 Device reports a single-body antenna layout.");

        var antennas = antennaInfo.AvailableNfcAntennas;
        if (antennas is null || antennas.Count == 0)
        {
            antennaFacts.Add("📡 No individual antenna coordinates were returned.");
            return;
        }

        var index = 1;
        foreach (var antenna in antennas)
        {
            antennaFacts.Add($"📍 Antenna {index} • x={antenna.LocationX}, y={antenna.LocationY}");
            index++;
        }
    }

    private Task LaunchIntentAsync(Intent intent)
    {
        return MainThread.InvokeOnMainThreadAsync(() =>
        {
            if (Platform.CurrentActivity is Activity activity)
            {
                activity.StartActivity(intent);
                return;
            }

            intent.AddFlags(ActivityFlags.NewTask);
            Platform.AppContext.StartActivity(intent);
        });
    }

    private void HandleHceChanged(object? sender, EventArgs e)
    {
        SyncHceState();
        RaiseChanged();
    }

    private void SyncHceState()
    {
        HceResponseText = HceAppletRuntime.ResponseText;
        HceEvents = HceAppletRuntime.Entries;
        HceFResponseText = HceFAppletRuntime.ResponseText;
        HceFEvents = HceFAppletRuntime.Entries;
        ObserveModeStatusText = !SupportsObserveMode
            ? "🚫 Observe mode is not reported by this adapter."
            : IsObserveModeEnabled
                ? "👀 Observe mode is enabled. Polling frames will be logged without answering the reader."
                : IsPreferredService
                    ? "🪪 APDU service is preferred. You can enable observe mode now."
                    : "👀 Observe mode is ready, but Android requires the APDU service to be preferred first.";
        HceStatusText = !SupportsHce
            ? "🚫 HCE is unavailable on this device."
            : IsObserveModeEnabled
                ? "👀 Observe mode is active. Polling frames are logged and transactions are held."
            : IsPreferredService
                ? "🪪 Demo APDU service is preferred for this foreground activity."
                : IsListening
                    ? "📡 Reader mode is active, so local APDU card emulation is temporarily suppressed."
                    : "🪪 Demo APDU service is ready. Pause reader mode before testing it.";
        HceFStatusText = !SupportsNfcFCardEmulation
            ? "🚫 NFC-F card emulation hardware is not reported on this device."
            : IsHceFEnabled
                ? "🧩 Demo NFC-F service is enabled for this foreground activity."
                : IsListening
                    ? "📡 Reader mode is active, so local NFC-F card emulation is temporarily suppressed."
                    : "🧩 Demo NFC-F service is ready. Pause reader mode before testing it.";
    }

    private void RaiseChanged()
    {
        MainThread.BeginInvokeOnMainThread(() => Changed?.Invoke(this, EventArgs.Empty));
    }

    private static void AppendEvent(List<string> target, string value)
    {
        target.Insert(0, $"{DateTimeOffset.Now:HH:mm:ss} • {value}");
        if (target.Count > 14)
        {
            target.RemoveRange(14, target.Count - 14);
        }
    }
}
