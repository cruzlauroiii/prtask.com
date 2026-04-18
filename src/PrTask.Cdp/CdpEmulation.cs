using System.Text.Json.Nodes;

namespace PrTask.Cdp;

#pragma warning disable SA1600
public static class CdpEmulation
{
    public static async Task SetDeviceMetricsOverrideAsync(CdpClient Client, string SessionId, int Width, int Height, double DeviceScaleFactor = 1.0, bool Mobile = false, CancellationToken Cancel = default)
    {
        await Client.SendToTargetAsync(SessionId, "Emulation.setDeviceMetricsOverride", new JsonObject
        {
            ["width"] = Width,
            ["height"] = Height,
            ["deviceScaleFactor"] = DeviceScaleFactor,
            ["mobile"] = Mobile,
        }, Cancel).ConfigureAwait(false);
    }

    public static async Task ClearDeviceMetricsOverrideAsync(CdpClient Client, string SessionId, CancellationToken Cancel = default)
    {
        await Client.SendToTargetAsync(SessionId, "Emulation.clearDeviceMetricsOverride", null, Cancel).ConfigureAwait(false);
    }

    public static async Task SetScriptExecutionDisabledAsync(CdpClient Client, string SessionId, bool Value, CancellationToken Cancel = default)
    {
        await Client.SendToTargetAsync(SessionId, "Emulation.setScriptExecutionDisabled", new JsonObject
        {
            ["value"] = Value,
        }, Cancel).ConfigureAwait(false);
    }

    public static async Task SetTouchEmulationEnabledAsync(CdpClient Client, string SessionId, bool Enabled, int MaxTouchPoints = 1, CancellationToken Cancel = default)
    {
        await Client.SendToTargetAsync(SessionId, "Emulation.setTouchEmulationEnabled", new JsonObject
        {
            ["enabled"] = Enabled,
            ["maxTouchPoints"] = MaxTouchPoints,
        }, Cancel).ConfigureAwait(false);
    }

    public static async Task SetGeolocationOverrideAsync(CdpClient Client, string SessionId, double Latitude, double Longitude, double Accuracy = 1.0, CancellationToken Cancel = default)
    {
        await Client.SendToTargetAsync(SessionId, "Emulation.setGeolocationOverride", new JsonObject
        {
            ["latitude"] = Latitude,
            ["longitude"] = Longitude,
            ["accuracy"] = Accuracy,
        }, Cancel).ConfigureAwait(false);
    }

    public static async Task ClearGeolocationOverrideAsync(CdpClient Client, string SessionId, CancellationToken Cancel = default)
    {
        await Client.SendToTargetAsync(SessionId, "Emulation.clearGeolocationOverride", null, Cancel).ConfigureAwait(false);
    }

    public static async Task SetTimezoneOverrideAsync(CdpClient Client, string SessionId, string TimezoneId, CancellationToken Cancel = default)
    {
        await Client.SendToTargetAsync(SessionId, "Emulation.setTimezoneOverride", new JsonObject
        {
            ["timezoneId"] = TimezoneId,
        }, Cancel).ConfigureAwait(false);
    }

    public static async Task SetLocaleOverrideAsync(CdpClient Client, string SessionId, string Locale, CancellationToken Cancel = default)
    {
        await Client.SendToTargetAsync(SessionId, "Emulation.setLocaleOverride", new JsonObject
        {
            ["locale"] = Locale,
        }, Cancel).ConfigureAwait(false);
    }

    public static async Task SetCpuThrottlingRateAsync(CdpClient Client, string SessionId, double Rate, CancellationToken Cancel = default)
    {
        await Client.SendToTargetAsync(SessionId, "Emulation.setCPUThrottlingRate", new JsonObject
        {
            ["rate"] = Rate,
        }, Cancel).ConfigureAwait(false);
    }

    public static async Task SetEmulatedMediaAsync(CdpClient Client, string SessionId, string? Media = null, CancellationToken Cancel = default)
    {
        var Params = new JsonObject();
        if (Media is not null)
        {
            Params["media"] = Media;
        }

        await Client.SendToTargetAsync(SessionId, "Emulation.setEmulatedMedia", Params, Cancel).ConfigureAwait(false);
    }
}
#pragma warning restore SA1600
