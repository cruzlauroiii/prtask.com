namespace WillowMaze.App.Services;

internal static class StatusReporter
{
    private static bool _started;
    private static bool _timerStarted;
    private static INfcWorkbenchService? _svc;

    public static void SetService(INfcWorkbenchService svc) => _svc = svc;

    public static void Start()
    {
        if (_started) return;
        _started = true;
    }

    public static void StartTimer(IDispatcher dispatcher)
    {
        if (_timerStarted) return;
        _timerStarted = true;
        var timer = dispatcher.CreateTimer();
        timer.Interval = TimeSpan.FromSeconds(5);
        timer.IsRepeating = true;
        timer.Tick += (_, _) => GatherAndSend();
        timer.Start();
    }

    private static void GatherAndSend()
    {
        if (!TapRelayClient.IsConnected) return;
        if (_svc is null) { TapRelayClient.SendStatus(new { Heartbeat = true, SvcNull = true }); return; }

        try
        {
            var s = _svc;
            bool Get(Func<bool> f) { try { return f(); } catch { return false; } }
            string GetS(Func<string> f) { try { return f(); } catch { return ""; } }
            string[] GetA(Func<IReadOnlyList<string>> f) { try { return f().ToArray(); } catch { return []; } }
            int GetI(Func<int> f) { try { return f(); } catch { return 0; } }

            object? tagData = null;
            try
            {
                var tag = s.LatestTag;
                if (tag is not null)
                    tagData = new { tag.Summary, tag.IdentifierHex, tag.CardType, tag.Manufacturer,
                        Technologies = tag.Technologies.ToArray(), HeadlineFacts = tag.HeadlineFacts.ToArray(),
                        tag.WriteOutcome, tag.CapturedAtUtc, RecordCount = tag.Records.Count };
            }
            catch { }

            TapRelayClient.SendStatus(new
            {
                IsSupported = Get(() => s.IsSupported),
                IsEnabled = Get(() => s.IsEnabled),
                IsListening = Get(() => s.IsListening),
                IsForegroundDispatchEnabled = Get(() => s.IsForegroundDispatchEnabled),
                SupportsHce = Get(() => s.SupportsHce),
                SupportsNfcFCardEmulation = Get(() => s.SupportsNfcFCardEmulation),
                SupportsObserveMode = Get(() => s.SupportsObserveMode),
                IsObserveModeEnabled = Get(() => s.IsObserveModeEnabled),
                SupportsSecureNfc = Get(() => s.SupportsSecureNfc),
                IsSecureNfcEnabled = Get(() => s.IsSecureNfcEnabled),
                IsPreferredService = Get(() => s.IsPreferredService),
                IsHceFEnabled = Get(() => s.IsHceFEnabled),
                StatusText = GetS(() => s.StatusText),
                HceStatusText = GetS(() => s.HceStatusText),
                HceAidHex = GetS(() => s.HceAidHex),
                HceResponseText = GetS(() => s.HceResponseText),
                HceFStatusText = GetS(() => s.HceFStatusText),
                HceFSystemCodeHex = GetS(() => s.HceFSystemCodeHex),
                HceFNfcid2Hex = GetS(() => s.HceFNfcid2Hex),
                HceFResponseText = GetS(() => s.HceFResponseText),
                PreferredPaymentDescription = GetS(() => s.PreferredPaymentDescription),
                PreferredPaymentRoute = GetS(() => s.PreferredPaymentRoute),
                LastIntentAction = GetS(() => s.LastIntentAction),
                LastWriteStatus = GetS(() => s.LastWriteStatus),
                LastRawStatus = GetS(() => s.LastRawStatus),
                ObserveModeStatusText = GetS(() => s.ObserveModeStatusText),
                DiscoveryStatusText = GetS(() => s.DiscoveryStatusText),
                IsDefaultServiceForCategory = Get(() => s.IsDefaultServiceForCategory),
                IsDefaultServiceForAid = Get(() => s.IsDefaultServiceForAid),
                SelectionModeForCategory = GetS(() => s.SelectionModeForCategory),
                CapabilityNotes = GetA(() => s.CapabilityNotes),
                AntennaFacts = GetA(() => s.AntennaFacts),
                RegisteredHceAids = GetA(() => s.RegisteredHceAids),
                RegisteredSystemAids = GetA(() => s.RegisteredSystemAids),
                HceEventCount = GetI(() => s.HceEvents.Count),
                HceFEventCount = GetI(() => s.HceFEvents.Count),
                RawEventCount = GetI(() => s.RawEvents.Count),
                LatestTag = tagData
            });
        }
        catch { }
    }
}
