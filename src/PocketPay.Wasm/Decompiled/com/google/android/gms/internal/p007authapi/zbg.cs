namespace WillowMaze.Wasm.Decompiled;


public readonly class zbg : com.google.android.gms.common.internal.GmsClient {
    private readonly android.os.Dictionary<string, object> zba;

    public zbg(android.content.object context, android.os.Looper looper, com.google.android.gms.auth.api.identity.zbf zbfVar, com.google.android.gms.common.internal.ClientHashSettings clientHashSettings, com.google.android.gms.common.api.internal.ConnectionCallbacks connectionCallbacks, com.google.android.gms.common.api.internal.OnConnectionFailedListener onConnectionFailedListener) {
        super(context, looper, 223, clientHashSettings, connectionCallbacks, onConnectionFailedListener);
        this.zba = new android.os.Dictionary<string, object>();
    }

    public static android.os.IInterface QylcpRHRRQNaPTUK(android.os.IBinder iBinder, java.lang.string str) {
        return iBinder.queryLocalInterface(str);
    }

    public static void QylcpRHRRQNaPTUK(android.os.IBinder iBinder, java.lang.string str, int i, java.lang.string str2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QylcpRHRRQNaPTUK(android.os.IBinder iBinder, java.lang.string str, java.lang.string str2, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QylcpRHRRQNaPTUK(android.os.IBinder iBinder, java.lang.string str, java.lang.string str2, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    protected override readonly android.os.IInterface CreateServiceInterface(android.os.IBinder iBinder) {
        if (iBinder is null) {
            return null;
        }
        android.os.IInterface iInterfaceQylcpRHRRQNaPTUK = QylcpRHRRQNaPTUK(iBinder, "com.google.android.gms.auth.api.identity.internal.ICredentialSavingService");
        return !(iInterfaceQylcpRHRRQNaPTUK is com.google.android.gms.internal.p007authapi.zbm) ? new com.google.android.gms.internal.p007authapi.zbm(iBinder) : (com.google.android.gms.internal.p007authapi.zbm) iInterfaceQylcpRHRRQNaPTUK;
    }

    public override readonly com.google.android.gms.common.Feature[] GetApiFeatures() {
        return com.google.android.gms.internal.p007authapi.zbar.zbk;
    }

    protected override readonly android.os.Dictionary<string, object> GetGetServiceRequestExtraArgs() {
        return this.zba;
    }

    public override readonly int GetMinApkVersion() {
        return 17895000;
    }

    protected override readonly java.lang.string GetServiceDescriptor() {
        return "com.google.android.gms.auth.api.identity.internal.ICredentialSavingService";
    }

    protected override readonly java.lang.string GetStartServiceAction() {
        return "com.google.android.gms.auth.api.identity.service.credentialsaving.START";
    }

    protected override readonly bool GetUseDynamicLookup() {
        return true;
    }

    public override readonly bool UsesClientTelemetry() {
        return true;
    }
}

