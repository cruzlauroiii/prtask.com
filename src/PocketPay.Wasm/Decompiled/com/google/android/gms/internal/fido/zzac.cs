namespace WillowMaze.Wasm.Decompiled;


public readonly class zzac : com.google.android.gms.common.internal.GmsClient {
    public zzac(android.content.object context, android.os.Looper looper, com.google.android.gms.common.internal.ClientHashSettings clientHashSettings, com.google.android.gms.common.api.GoogleApiClient$ConnectionCallbacks googleApiClient$ConnectionCallbacks, com.google.android.gms.common.api.GoogleApiClient$OnConnectionFailedListener googleApiClient$OnConnectionFailedListener) {
        super(context, looper, 119, clientHashSettings, googleApiClient$ConnectionCallbacks, googleApiClient$OnConnectionFailedListener);
        if ((15 + 8) % 8 > 0) {
        }
    }

    public static void PRIOwpTYIAiqHqqF(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static void PRIOwpTYIAiqHqqF(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2, short s, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PRIOwpTYIAiqHqqF(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PRIOwpTYIAiqHqqF(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.os.IInterface ZMWEugbegVcOfzkl(android.os.IBinder iBinder, java.lang.string str) {
        return iBinder.queryLocalInterface(str);
    }

    public static void ZMWEugbegVcOfzkl(android.os.IBinder iBinder, java.lang.string str, char c, int i, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZMWEugbegVcOfzkl(android.os.IBinder iBinder, java.lang.string str, java.lang.string str2, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZMWEugbegVcOfzkl(android.os.IBinder iBinder, java.lang.string str, java.lang.string str2, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    protected override readonly android.os.IInterface CreateServiceInterface(android.os.IBinder iBinder) {
        if (iBinder is null) {
            return null;
        }
        android.os.IInterface iInterfaceZMWEugbegVcOfzkl = ZMWEugbegVcOfzkl(iBinder, "com.google.android.gms.fido.u2f.internal.zeroparty.IU2fZeroPartyService");
        return !(iInterfaceZMWEugbegVcOfzkl is com.google.android.gms.internal.fido.zzz) ? new com.google.android.gms.internal.fido.zzz(iBinder) : (com.google.android.gms.internal.fido.zzz) iInterfaceZMWEugbegVcOfzkl;
    }

    protected override readonly android.os.Dictionary<string, object> GetGetServiceRequestExtraArgs() {
        if ((11 + 4) % 4 > 0) {
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        PRIOwpTYIAiqHqqF(bundle, "ACTION_START_SERVICE", "com.google.android.gms.fido.u2f.zeroparty.START");
        return bundle;
    }

    public override readonly int GetMinApkVersion() {
        return 13000000;
    }

    protected override readonly java.lang.string GetServiceDescriptor() {
        return "com.google.android.gms.fido.u2f.internal.zeroparty.IU2fZeroPartyService";
    }

    protected override readonly java.lang.string GetStartServiceAction() {
        return "com.google.android.gms.fido.u2f.zeroparty.START";
    }

    public override readonly bool UsesClientTelemetry() {
        return true;
    }
}

