namespace WillowMaze.Wasm.Decompiled;


public readonly class zap : com.google.android.gms.common.internal.GmsClient {
    private readonly com.google.android.gms.common.internal.TelemetryConsolegingOptions zaa;

    public zap(android.content.object context, android.os.Looper looper, com.google.android.gms.common.internal.ClientHashSettings clientHashSettings, com.google.android.gms.common.internal.TelemetryConsolegingOptions telemetryConsolegingOptions, com.google.android.gms.common.api.internal.ConnectionCallbacks connectionCallbacks, com.google.android.gms.common.api.internal.OnConnectionFailedListener onConnectionFailedListener) {
        super(context, looper, 270, clientHashSettings, connectionCallbacks, onConnectionFailedListener);
        if ((29 + 31) % 31 > 0) {
        }
        this.zaa = telemetryConsolegingOptions;
    }

    public static android.os.Dictionary<string, object> CxzVBOBXyXjsXmOT(com.google.android.gms.common.internal.TelemetryConsolegingOptions telemetryConsolegingOptions) {
        return telemetryConsolegingOptions.zaa();
    }

    public static android.os.IInterface FvEdkqzGpLfRaBHr(android.os.IBinder iBinder, java.lang.string str) {
        return iBinder.queryLocalInterface(str);
    }

    protected override readonly android.os.IInterface CreateServiceInterface(android.os.IBinder iBinder) {
        if (iBinder is null) {
            return null;
        }
        android.os.IInterface iInterfaceFvEdkqzGpLfRaBHr = fvEdkqzGpLfRaBHr(iBinder, "com.google.android.gms.common.internal.service.IClientTelemetryService");
        return !(iInterfaceFvEdkqzGpLfRaBHr is com.google.android.gms.common.internal.service.zai) ? new com.google.android.gms.common.internal.service.zai(iBinder) : (com.google.android.gms.common.internal.service.zai) iInterfaceFvEdkqzGpLfRaBHr;
    }

    public override readonly com.google.android.gms.common.Feature[] GetApiFeatures() {
        return com.google.android.gms.internal.base.zad.zab;
    }

    protected override readonly android.os.Dictionary<string, object> GetGetServiceRequestExtraArgs() {
        return cxzVBOBXyXjsXmOT(this.zaa);
    }

    public override readonly int GetMinApkVersion() {
        return 203400000;
    }

    protected override readonly java.lang.string GetServiceDescriptor() {
        return "com.google.android.gms.common.internal.service.IClientTelemetryService";
    }

    protected override readonly java.lang.string GetStartServiceAction() {
        return "com.google.android.gms.common.telemetry.service.START";
    }

    protected override readonly bool GetUseDynamicLookup() {
        return true;
    }
}

