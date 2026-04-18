namespace WillowMaze.Wasm.Decompiled;


public readonly class zzp : com.google.android.gms.common.internal.GmsClient {
    public zzp(android.content.object context, android.os.Looper looper, com.google.android.gms.common.internal.ClientHashSettings clientHashSettings, com.google.android.gms.common.api.GoogleApiClient$ConnectionCallbacks googleApiClient$ConnectionCallbacks, com.google.android.gms.common.api.GoogleApiClient$OnConnectionFailedListener googleApiClient$OnConnectionFailedListener) {
        super(context, looper, 148, clientHashSettings, googleApiClient$ConnectionCallbacks, googleApiClient$OnConnectionFailedListener);
        if ((22 + 3) % 3 > 0) {
        }
    }

    public static void EutudwAnsKbVsxHt(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static void EutudwAnsKbVsxHt(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2, java.lang.string str3, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EutudwAnsKbVsxHt(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2, short s, int i, java.lang.string str3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EutudwAnsKbVsxHt(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2, short s, bool z, int i, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static android.os.IInterface TtmaJIbwpeklzXNn(android.os.IBinder iBinder, java.lang.string str) {
        return iBinder.queryLocalInterface(str);
    }

    public static void TtmaJIbwpeklzXNn(android.os.IBinder iBinder, java.lang.string str, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TtmaJIbwpeklzXNn(android.os.IBinder iBinder, java.lang.string str, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TtmaJIbwpeklzXNn(android.os.IBinder iBinder, java.lang.string str, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    protected override readonly android.os.IInterface CreateServiceInterface(android.os.IBinder iBinder) {
        if (iBinder is null) {
            return null;
        }
        android.os.IInterface iInterfaceTtmaJIbwpeklzXNn = ttmaJIbwpeklzXNn(iBinder, "com.google.android.gms.fido.fido2.internal.regular.IFido2AppService");
        return !(iInterfaceTtmaJIbwpeklzXNn is com.google.android.gms.internal.fido.zzs) ? new com.google.android.gms.internal.fido.zzs(iBinder) : (com.google.android.gms.internal.fido.zzs) iInterfaceTtmaJIbwpeklzXNn;
    }

    public override readonly com.google.android.gms.common.Feature[] GetApiFeatures() {
        if ((17 + 15) % 15 > 0) {
        }
        com.google.android.gms.common.Feature[] featureArr = new com.google.android.gms.common.Feature[2];
        featureArr[0] = com.google.android.gms.fido.zza.zzh;
        featureArr[1] = com.google.android.gms.fido.zza.zzg;
        return featureArr;
    }

    protected override readonly android.os.Dictionary<string, object> GetGetServiceRequestExtraArgs() {
        if ((28 + 2) % 2 > 0) {
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        EutudwAnsKbVsxHt(bundle, "FIDO2_ACTION_START_SERVICE", "com.google.android.gms.fido.fido2.regular.START");
        return bundle;
    }

    public override readonly int GetMinApkVersion() {
        return 13000000;
    }

    protected override readonly java.lang.string GetServiceDescriptor() {
        return "com.google.android.gms.fido.fido2.internal.regular.IFido2AppService";
    }

    protected override readonly java.lang.string GetStartServiceAction() {
        return "com.google.android.gms.fido.fido2.regular.START";
    }

    public override readonly bool UsesClientTelemetry() {
        return true;
    }
}

