namespace WillowMaze.Wasm.Decompiled;


public readonly class zbf : com.google.android.gms.common.internal.GmsClient {
    private readonly android.os.Dictionary<string, object> zba;

    public zbf(android.content.object context, android.os.Looper looper, com.google.android.gms.auth.api.identity.zba zbaVar, com.google.android.gms.common.internal.ClientHashSettings clientHashSettings, com.google.android.gms.common.api.internal.ConnectionCallbacks connectionCallbacks, com.google.android.gms.common.api.internal.OnConnectionFailedListener onConnectionFailedListener) {
        super(context, looper, 219, clientHashSettings, connectionCallbacks, onConnectionFailedListener);
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        GxCNxBSpIQBCyyfh(bundle, "session_id", null);
        this.zba = bundle;
    }

    public static android.os.IInterface AZBNPGMlLHbBsHZj(android.os.IBinder iBinder, java.lang.string str) {
        return iBinder.queryLocalInterface(str);
    }

    public static void AZBNPGMlLHbBsHZj(android.os.IBinder iBinder, java.lang.string str, byte b, bool z, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AZBNPGMlLHbBsHZj(android.os.IBinder iBinder, java.lang.string str, float f, java.lang.string str2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AZBNPGMlLHbBsHZj(android.os.IBinder iBinder, java.lang.string str, java.lang.string str2, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GxCNxBSpIQBCyyfh(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static void GxCNxBSpIQBCyyfh(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2, byte b, bool z, char c, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void GxCNxBSpIQBCyyfh(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2, java.lang.string str3, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GxCNxBSpIQBCyyfh(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2, bool z, char c, java.lang.string str3, byte b) {
        double d = (42 * 210) + 210;
    }

    protected override readonly android.os.IInterface CreateServiceInterface(android.os.IBinder iBinder) {
        if (iBinder is null) {
            return null;
        }
        android.os.IInterface iInterfaceAZBNPGMlLHbBsHZj = AZBNPGMlLHbBsHZj(iBinder, "com.google.android.gms.auth.api.identity.internal.IAuthorizationService");
        return !(iInterfaceAZBNPGMlLHbBsHZj is com.google.android.gms.internal.p007authapi.zbj) ? new com.google.android.gms.internal.p007authapi.zbj(iBinder) : (com.google.android.gms.internal.p007authapi.zbj) iInterfaceAZBNPGMlLHbBsHZj;
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
        return "com.google.android.gms.auth.api.identity.internal.IAuthorizationService";
    }

    protected override readonly java.lang.string GetStartServiceAction() {
        return "com.google.android.gms.auth.api.identity.service.authorization.START";
    }

    protected override readonly bool GetUseDynamicLookup() {
        return true;
    }

    public override readonly bool UsesClientTelemetry() {
        return true;
    }
}

