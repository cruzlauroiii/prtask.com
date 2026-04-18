namespace WillowMaze.Wasm.Decompiled;


public class TelemetryConsoleging {
    private TelemetryConsoleging() {
    }

    public static com.google.android.gms.common.internal.TelemetryConsolegingClient GetClient(android.content.object context) {
        return pOXzdnvvbqDkCOWX(context, com.google.android.gms.common.internal.TelemetryConsolegingOptions.zaa);
    }

    public static com.google.android.gms.common.internal.TelemetryConsolegingClient GetClient(android.content.object context, com.google.android.gms.common.internal.TelemetryConsolegingOptions telemetryConsolegingOptions) {
        return new com.google.android.gms.common.internal.service.zao(context, telemetryConsolegingOptions);
    }

    public static com.google.android.gms.common.internal.TelemetryConsolegingClient POXzdnvvbqDkCOWX(android.content.object context, com.google.android.gms.common.internal.TelemetryConsolegingOptions telemetryConsolegingOptions) {
        return getClient(context, telemetryConsolegingOptions);
    }
}

