using System.Text.Json;
using Microsoft.JSInterop;
using WillowMaze.Wasm.Models;

namespace WillowMaze.Wasm.Services;

public sealed class WssNfcWorkbenchService : INfcWorkbenchService, IAsyncDisposable
{
    private readonly IJSRuntime Js;
    private WssInterop? Interop;
    private readonly List<string> CapabilityNotesInternal = [];
    private readonly List<string> AntennaFactsInternal = [];
    private readonly List<string> RawEventsInternal = [];
    private readonly List<string> SessionJsonlEntries = [];
    private readonly List<string> RawJsonlEntries = [];
    private readonly List<string> PollingFilterEntries = [];
    private readonly List<string> PollingPatternFilterEntries = [];

    public WssNfcWorkbenchService(IJSRuntime Js) => this.Js = Js;

    public bool IsSupported { get; private set; }
    public bool IsEnabled { get; private set; }
    public bool IsListening { get; private set; }
    public bool IsForegroundDispatchEnabled { get; private set; }
    public bool SupportsHce { get; private set; }
    public bool SupportsNfcFCardEmulation { get; private set; }
    public bool IsHceFEnabled { get; private set; }
    public bool SupportsObserveMode { get; private set; }
    public bool IsObserveModeEnabled { get; private set; }
    public bool ShouldDefaultToObserveMode { get; private set; }
    public bool SupportsTagIntentPreference { get; private set; }
    public bool? IsTagIntentAllowed { get; private set; }
    public bool SupportsReaderOption { get; private set; }
    public bool IsReaderOptionEnabled { get; private set; }
    public bool SupportsSecureNfc { get; private set; }
    public bool IsSecureNfcEnabled { get; private set; }
    public bool SupportsAidPrefixRegistration { get; private set; }
    public bool AllowsOtherCategoryForegroundPreference { get; private set; }
    public bool IsPreferredService { get; private set; }
    public bool HasCustomDiscoveryTechnology { get; private set; }
    public bool IsWssConnected { get; private set; }
    public bool HasWebNfc { get; private set; }
    public int DefaultNfcSubscriptionId { get; private set; } = -1;
    public string StatusText { get; private set; } = "Connect to a Willow server or use Web NFC to begin.";
    public string LastWriteStatus { get; private set; } = "No write armed yet.";
    public string LastRawStatus { get; private set; } = "Tap a tag, keep it in field, then send a raw hex frame.";
    public string DiscoveryStatusText { get; private set; } = "Default discovery settings.";
    public string PreferredPaymentDescription { get; private set; } = "(none)";
    public string PreferredPaymentRoute { get; private set; } = "(none)";
    public string LastIntentAction { get; private set; } = "(none)";
    public string HceAidHex => FormatHex(HceAppletRuntime.AidHex);
    public string HceStatusText { get; private set; } = "Demo applet is idle.";
    public string HceResponseText { get; private set; } = HceAppletRuntime.ResponseText;
    public string HceFSystemCodeHex => FormatHex(HceFAppletRuntime.SystemCodeHex);
    public string HceFNfcid2Hex => FormatHex(HceFAppletRuntime.Nfcid2Hex);
    public string HceFT3tPmmHex => FormatHex(HceFAppletRuntime.T3tPmmHex);
    public string HceFStatusText { get; private set; } = "Demo NFC-F applet is idle.";
    public string HceFResponseText { get; private set; } = HceFAppletRuntime.ResponseText;
    public string ObserveModeStatusText { get; private set; } = "Observe mode is idle.";
    public NdefWriteDraft? PendingWrite { get; private set; }
    public NfcTagSnapshot? LatestTag { get; private set; }
    public IReadOnlyList<string> CapabilityNotes => CapabilityNotesInternal;
    public IReadOnlyList<string> AntennaFacts => AntennaFactsInternal;
    public IReadOnlyList<string> RawEvents => RawEventsInternal;
    public IReadOnlyList<string> HceEvents { get; private set; } = [];
    public IReadOnlyList<string> HceFEvents { get; private set; } = [];
    public IReadOnlyList<string> RegisteredHceAids => HceAppletRuntime.EffectiveAids;
    public IReadOnlyList<string> PollingFilters => PollingFilterEntries;
    public IReadOnlyList<string> PollingPatternFilters => PollingPatternFilterEntries;
    public string WssUrl { get; private set; } = string.Empty;

    public string AdapterSnapshotJson => NfcJson.Serialize(new
    {
        IsSupported, IsEnabled, IsListening, SupportsHce, SupportsNfcFCardEmulation,
        IsHceFEnabled, SupportsObserveMode, IsObserveModeEnabled, SupportsSecureNfc,
        IsSecureNfcEnabled, IsPreferredService, HasCustomDiscoveryTechnology, IsWssConnected, HasWebNfc,
        HceAidHex, HceFSystemCodeHex, HceFNfcid2Hex, HceFT3tPmmHex, CapabilityNotes, AntennaFacts
    });

    public string LatestTagJsonl => LatestTag is not null
        ? NfcJson.Line("tag", "snapshot", new
        {
            LatestTag.Summary, LatestTag.IdentifierHex, LatestTag.Technologies,
            Records = LatestTag.Records.Select(static R => new { R.Icon, R.Kind, R.Summary, R.PayloadHex }),
            LatestTag.Details, LatestTag.WriteOutcome, LatestTag.CapturedAtUtc
        })
        : string.Empty;

    public string SessionJsonl => NfcJson.Join(SessionJsonlEntries);
    public string HceJsonl => HceAppletRuntime.Jsonl;
    public string HceFJsonl => HceFAppletRuntime.Jsonl;
    public string RawJsonl => NfcJson.Join(RawJsonlEntries);

    public event EventHandler? Changed;

    public async Task InitializeAsync()
    {
        Interop = new WssInterop(Js);
        HasWebNfc = await Interop.HasWebNfcAsync();
        HceAppletRuntime.Changed += HandleHceChanged;
        HceFAppletRuntime.Changed += HandleHceChanged;
        SyncHceState();

        if (HasWebNfc)
        {
            IsSupported = true;
            IsEnabled = true;
            StatusText = "Web NFC is available. Start reader to scan tags.";
            CapabilityNotesInternal.Add("Web NFC API detected in this browser.");
        }
        else
        {
            StatusText = "No Web NFC. Connect to a Willow server (WSS) for full NFC access.";
            CapabilityNotesInternal.Add("Web NFC not available. Use WSS proxy to an Android device.");
        }

        CapabilityNotesInternal.Add("HCE APDU applet runs in-process (browser WASM).");
        CapabilityNotesInternal.Add("HCE NFC-F applet runs in-process (browser WASM).");
        RaiseChanged();
    }

    public async Task ConnectWssAsync(string Url)
    {
        Interop ??= new WssInterop(Js);
        WssUrl = Url;
        var Connected = await Interop.ConnectAsync(Url, this);
        if (!Connected)
        {
            StatusText = $"Failed to connect to {Url}";
            RaiseChanged();
        }
    }

    public async Task DisconnectWssAsync()
    {
        if (Interop is not null) await Interop.DisconnectAsync();
        IsWssConnected = false;
        StatusText = "WSS disconnected.";
        LogSession("wss", "disconnected", null);
        RaiseChanged();
    }

    [JSInvokable] public Task OnWssOpen()
    {
        IsWssConnected = true;
        IsSupported = true;
        IsEnabled = true;
        StatusText = $"Connected to Willow server at {WssUrl}";
        CapabilityNotesInternal.Insert(0, $"WSS connected to {WssUrl}");
        LogSession("wss", "connected", new { url = WssUrl });
        RaiseChanged();
        return Task.CompletedTask;
    }

    [JSInvokable] public Task OnWssClose(int Code, string Reason)
    {
        IsWssConnected = false;
        StatusText = $"WSS closed ({Code}: {Reason})";
        LogSession("wss", "closed", new { code = Code, reason = Reason });
        RaiseChanged();
        return Task.CompletedTask;
    }

    [JSInvokable] public Task OnWssError(string Error)
    {
        StatusText = $"WSS error: {Error}";
        LogSession("wss", "error", new { error = Error });
        RaiseChanged();
        return Task.CompletedTask;
    }

    [JSInvokable] public Task OnWssMessage(string Json)
    {
        try
        {
            var Msg = JsonSerializer.Deserialize<WssMessage>(Json);
            if (Msg is null) return Task.CompletedTask;

            if (Msg.Type == "tag_discovered" && Msg.Data.HasValue)
            {
                var Tag = JsonSerializer.Deserialize<NfcTagSnapshot>(Msg.Data.Value.GetRawText());
                if (Tag is not null)
                {
                    LatestTag = Tag;
                    StatusText = $"{Tag.Summary} via WSS";
                    AppendEvent(RawEventsInternal, $"Tag captured via WSS: {Tag.Summary}");
                    LogSession("tag", "discovered_wss", new { Tag.Summary, Tag.IdentifierHex });
                }
            }
            else if (Msg.Type == "state_update" && Msg.Data.HasValue)
            {
                ApplyStateUpdate(Msg.Data.Value);
            }
            else if (Msg.Type == "raw_response" && Msg.Data.HasValue)
            {
                var ResponseHex = Msg.Data.Value.GetProperty("responseHex").GetString() ?? "";
                var Tech = Msg.Data.Value.GetProperty("technology").GetString() ?? "";
                LastRawStatus = $"{Tech} via WSS: {FormatHex(ResponseHex)}";
                AppendEvent(RawEventsInternal, LastRawStatus);
            }
            else if (Msg.Type == "error")
            {
                StatusText = $"WSS error: {Msg.Error}";
            }

            RaiseChanged();
        }
        catch { }
        return Task.CompletedTask;
    }

    [JSInvokable] public Task OnWebNfcTag(string SerialNumber, string RecordsJson)
    {
        var Records = new List<NdefRecordSnapshot>();
        try
        {
            using var Doc = JsonDocument.Parse(RecordsJson);
            foreach (var Elem in Doc.RootElement.EnumerateArray())
            {
                var RecordType = Elem.GetProperty("recordType").GetString() ?? "unknown";
                var Data = Elem.GetProperty("data").GetString() ?? "";
                Records.Add(new NdefRecordSnapshot(
                    RecordType == "url" ? "link" : "text",
                    RecordType,
                    Data.Length > 0 ? System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(Data)) : "(empty)",
                    Data, string.Empty, string.Empty, string.Empty, string.Empty, 0, []));
            }
        }
        catch { }

        LatestTag = new NfcTagSnapshot(
            "NFC tag discovered (Web NFC)",
            SerialNumber,
            string.Empty,
            string.Empty,
            ["WebNFC"],
            [$"ID: {SerialNumber}", $"Records: {Records.Count}"],
            Records,
            ["Scanned via Web NFC API"],
            [],
            [],
            PendingWrite is null ? "Inspect only." : "Web NFC write pending.",
            DateTimeOffset.UtcNow);

        StatusText = $"Tag scanned: {SerialNumber}";
        LogSession("tag", "discovered_webnfc", new { serialNumber = SerialNumber, recordCount = Records.Count });
        RaiseChanged();
        return Task.CompletedTask;
    }

    [JSInvokable] public Task OnWebNfcError(string Error)
    {
        StatusText = $"Web NFC error: {Error}";
        RaiseChanged();
        return Task.CompletedTask;
    }

    public async Task StartReaderAsync()
    {
        if (HasWebNfc && Interop is not null)
        {
            var Started = await Interop.StartWebNfcScanAsync(this);
            IsListening = Started;
            StatusText = Started ? "Reader mode is live (Web NFC). Tap a tag." : "Failed to start Web NFC reader.";
        }
        else if (IsWssConnected)
        {
            await SendWssAsync("start_reader");
            IsListening = true;
            StatusText = "Reader mode started via WSS.";
        }
        else
        {
            StatusText = "No NFC source available. Connect WSS or use a Web NFC-capable browser.";
        }
        RaiseChanged();
    }

    public async Task StopReaderAsync()
    {
        if (IsWssConnected) await SendWssAsync("stop_reader");
        IsListening = false;
        StatusText = "Reader mode paused.";
        RaiseChanged();
    }

    public Task RefreshAsync()
    {
        SyncHceState();
        if (IsWssConnected) return SendWssAsync("refresh");
        RaiseChanged();
        return Task.CompletedTask;
    }

    public async Task ArmWriteAsync(NdefWriteDraft Draft)
    {
        PendingWrite = Draft with { Content = Draft.Content.Trim() };
        LastWriteStatus = $"Armed next write: {PendingWrite.Summary}";

        if (HasWebNfc && Interop is not null && PendingWrite is not null)
        {
            var Error = await Interop.WriteWebNfcAsync(PendingWrite.Content, PendingWrite.Kind == NdefPayloadKind.Uri);
            if (string.IsNullOrEmpty(Error))
            {
                LastWriteStatus = $"Wrote via Web NFC: {PendingWrite.Summary}";
                PendingWrite = null;
            }
            else
            {
                LastWriteStatus = $"Web NFC write failed: {Error}";
            }
        }
        else if (IsWssConnected)
        {
            await SendWssAsync("arm_write", new { kind = Draft.Kind.ToString(), content = Draft.Content, mimeType = Draft.MimeType, makeReadOnly = Draft.MakeReadOnly });
        }

        RaiseChanged();
    }

    public async Task ClearWriteAsync()
    {
        PendingWrite = null;
        LastWriteStatus = "Pending write cleared.";
        if (IsWssConnected) await SendWssAsync("clear_write");
        RaiseChanged();
    }

    public async Task SendRawAsync(string TechnologyName, string CommandHex)
    {
        if (IsWssConnected)
        {
            await SendWssAsync("send_raw", new { technology = TechnologyName, commandHex = CommandHex });
            LastRawStatus = $"Sent {TechnologyName} command via WSS...";
        }
        else
        {
            LastRawStatus = "Raw I/O requires WSS connection to Android device.";
        }
        AppendEvent(RawEventsInternal, LastRawStatus);
        RaiseChanged();
    }

    public Task OpenNfcSettingsAsync() => IsWssConnected ? SendWssAsync("open_nfc_settings") : Task.CompletedTask;
    public Task OpenTagRoutingAsync() => IsWssConnected ? SendWssAsync("open_tag_routing") : Task.CompletedTask;
    public Task IgnoreCurrentTagAsync(int DebounceMs) => IsWssConnected ? SendWssAsync("ignore_tag", new { debounceMs = DebounceMs }) : Task.CompletedTask;
    public Task SetObserveModeEnabledAsync(bool Enabled) => IsWssConnected ? SendWssAsync("set_observe_mode", new { enabled = Enabled }) : Task.CompletedTask;
    public Task SetDefaultObserveModeAsync(bool Enabled) => IsWssConnected ? SendWssAsync("set_default_observe", new { enabled = Enabled }) : Task.CompletedTask;
    public Task SetPreferredServiceAsync(bool Prefer) => IsWssConnected ? SendWssAsync("set_preferred_service", new { prefer = Prefer }) : Task.CompletedTask;
    public Task SetHceFEnabledAsync(bool Enabled) => IsWssConnected ? SendWssAsync("set_hcef_enabled", new { enabled = Enabled }) : Task.CompletedTask;
    public Task SetDiscoveryTechnologyAsync(int PollFlags, int ListenFlags) => IsWssConnected ? SendWssAsync("set_discovery", new { pollFlags = PollFlags, listenFlags = ListenFlags }) : Task.CompletedTask;
    public Task ResetDiscoveryTechnologyAsync() => IsWssConnected ? SendWssAsync("reset_discovery") : Task.CompletedTask;

    public Task RegisterHceAidsAsync(string RawAidText)
    {
        var Aids = RawAidText.Split([',', ';', ' ', '\n', '\r'], StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
            .Select(static V => new string(V.Where(Uri.IsHexDigit).ToArray()).ToUpperInvariant())
            .Where(static V => V.Length >= 10).ToArray();
        if (Aids.Length == 0) { HceStatusText = "No valid AID hex values found."; RaiseChanged(); return Task.CompletedTask; }
        HceAppletRuntime.SetDynamicAids(Aids);
        HceStatusText = $"Registered {Aids.Length} dynamic AID(s).";
        SyncHceState();
        RaiseChanged();
        return Task.CompletedTask;
    }

    public Task ClearHceAidsAsync()
    {
        HceAppletRuntime.SetDynamicAids([]);
        HceStatusText = "Dynamic AIDs cleared.";
        SyncHceState();
        RaiseChanged();
        return Task.CompletedTask;
    }

    public Task AddPollingFilterAsync(string FilterHex, bool AutoTransact)
    {
        var Cleaned = new string(FilterHex.Where(Uri.IsHexDigit).ToArray()).ToUpperInvariant();
        if (!string.IsNullOrWhiteSpace(Cleaned) && !PollingFilterEntries.Contains(Cleaned)) PollingFilterEntries.Add(Cleaned);
        if (IsWssConnected) return SendWssAsync("add_polling_filter", new { filterHex = Cleaned, autoTransact = AutoTransact });
        RaiseChanged();
        return Task.CompletedTask;
    }

    public Task RemovePollingFilterAsync(string FilterHex)
    {
        var Cleaned = new string(FilterHex.Where(Uri.IsHexDigit).ToArray()).ToUpperInvariant();
        PollingFilterEntries.RemoveAll(V => string.Equals(V, Cleaned, StringComparison.OrdinalIgnoreCase));
        if (IsWssConnected) return SendWssAsync("remove_polling_filter", new { filterHex = Cleaned });
        RaiseChanged();
        return Task.CompletedTask;
    }

    public Task AddPollingPatternFilterAsync(string Pattern, bool AutoTransact)
    {
        var Trimmed = Pattern.Trim();
        if (!string.IsNullOrWhiteSpace(Trimmed) && !PollingPatternFilterEntries.Contains(Trimmed)) PollingPatternFilterEntries.Add(Trimmed);
        if (IsWssConnected) return SendWssAsync("add_polling_pattern", new { pattern = Trimmed, autoTransact = AutoTransact });
        RaiseChanged();
        return Task.CompletedTask;
    }

    public Task RemovePollingPatternFilterAsync(string Pattern)
    {
        PollingPatternFilterEntries.RemoveAll(V => string.Equals(V, Pattern.Trim(), StringComparison.Ordinal));
        if (IsWssConnected) return SendWssAsync("remove_polling_pattern", new { pattern = Pattern.Trim() });
        RaiseChanged();
        return Task.CompletedTask;
    }

    public Task UpdateHceResponseAsync(string Text)
    {
        HceAppletRuntime.UpdateResponseText(Text);
        SyncHceState();
        RaiseChanged();
        return Task.CompletedTask;
    }

    public Task UpdateHceFResponseAsync(string Text)
    {
        HceFAppletRuntime.UpdateResponseText(Text);
        SyncHceState();
        RaiseChanged();
        return Task.CompletedTask;
    }

    private async Task SendWssAsync(string Method, object? Payload = null)
    {
        if (Interop is null) return;
        var Msg = new { type = "command", method = Method, id = Guid.NewGuid().ToString("N"), payload = Payload };
        var Json = JsonSerializer.Serialize(Msg);
        await Interop.SendAsync(Json);
        LogSession("wss", Method, Payload);
    }

    private void ApplyStateUpdate(JsonElement Data)
    {
        if (Data.TryGetProperty("isSupported", out var V1)) IsSupported = V1.GetBoolean();
        if (Data.TryGetProperty("isEnabled", out var V2)) IsEnabled = V2.GetBoolean();
        if (Data.TryGetProperty("isListening", out var V3)) IsListening = V3.GetBoolean();
        if (Data.TryGetProperty("supportsHce", out var V4)) SupportsHce = V4.GetBoolean();
        if (Data.TryGetProperty("supportsNfcFCardEmulation", out var V5)) SupportsNfcFCardEmulation = V5.GetBoolean();
        if (Data.TryGetProperty("isHceFEnabled", out var V6)) IsHceFEnabled = V6.GetBoolean();
        if (Data.TryGetProperty("supportsObserveMode", out var V7)) SupportsObserveMode = V7.GetBoolean();
        if (Data.TryGetProperty("isObserveModeEnabled", out var V8)) IsObserveModeEnabled = V8.GetBoolean();
        if (Data.TryGetProperty("supportsSecureNfc", out var V9)) SupportsSecureNfc = V9.GetBoolean();
        if (Data.TryGetProperty("isSecureNfcEnabled", out var V10)) IsSecureNfcEnabled = V10.GetBoolean();
        if (Data.TryGetProperty("isPreferredService", out var V11)) IsPreferredService = V11.GetBoolean();
        if (Data.TryGetProperty("supportsReaderOption", out var V12)) SupportsReaderOption = V12.GetBoolean();
        if (Data.TryGetProperty("isReaderOptionEnabled", out var V13)) IsReaderOptionEnabled = V13.GetBoolean();
        if (Data.TryGetProperty("supportsTagIntentPreference", out var V14)) SupportsTagIntentPreference = V14.GetBoolean();
        if (Data.TryGetProperty("supportsAidPrefixRegistration", out var V15)) SupportsAidPrefixRegistration = V15.GetBoolean();
        if (Data.TryGetProperty("statusText", out var V16)) StatusText = V16.GetString() ?? StatusText;
    }

    private void SyncHceState()
    {
        HceResponseText = HceAppletRuntime.ResponseText;
        HceEvents = HceAppletRuntime.EventEntries;
        HceFResponseText = HceFAppletRuntime.ResponseText;
        HceFEvents = HceFAppletRuntime.EventEntries;
    }

    private void HandleHceChanged(object? Sender, EventArgs E)
    {
        SyncHceState();
        RaiseChanged();
    }

    private void LogSession(string Stream, string EventType, object? Payload)
    {
        NfcJson.Append(SessionJsonlEntries, 500, $"session.{Stream}", EventType, Payload);
    }

    private static void AppendEvent(List<string> Target, string Value)
    {
        Target.Insert(0, $"{DateTimeOffset.Now:HH:mm:ss} {Value}");
        if (Target.Count > 14) Target.RemoveRange(14, Target.Count - 14);
    }

    private static string FormatHex(string Hex) => string.Join(' ', Enumerable.Range(0, Hex.Length / 2).Select(I => Hex.Substring(I * 2, 2)));

    private void RaiseChanged() => Changed?.Invoke(this, EventArgs.Empty);

    public async ValueTask DisposeAsync()
    {
        HceAppletRuntime.Changed -= HandleHceChanged;
        HceFAppletRuntime.Changed -= HandleHceChanged;
        if (Interop is not null) await Interop.DisposeAsync();
    }
}
