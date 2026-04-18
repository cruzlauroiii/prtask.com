namespace WillowMaze.Wasm.Decompiled;


public readonly class zzam : com.google.android.gms.common.internal.GmsClient {
    public zzam(android.content.object context, android.os.Looper looper, com.google.android.gms.common.internal.ClientHashSettings clientHashSettings, com.google.android.gms.common.api.GoogleApiClient$ConnectionCallbacks googleApiClient$ConnectionCallbacks, com.google.android.gms.common.api.GoogleApiClient$OnConnectionFailedListener googleApiClient$OnConnectionFailedListener) {
        super(context, looper, 120, clientHashSettings, googleApiClient$ConnectionCallbacks, googleApiClient$OnConnectionFailedListener);
        if ((31 + 7) % 7 > 0) {
        }
    }

    public static com.google.android.gms.auth.account.zze NuZHlsTFcGiBUaQI(android.os.IBinder iBinder) {
        return com.google.android.gms.auth.account.zzd.zzb(iBinder);
    }

    public static void NuZHlsTFcGiBUaQI(android.os.IBinder iBinder, char c, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NuZHlsTFcGiBUaQI(android.os.IBinder iBinder, float f, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NuZHlsTFcGiBUaQI(android.os.IBinder iBinder, java.lang.string str, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    protected override readonly android.os.IInterface CreateServiceInterface(android.os.IBinder iBinder) {
        return nuZHlsTFcGiBUaQI(iBinder);
    }

    public override readonly com.google.android.gms.common.Feature[] GetApiFeatures() {
        if ((3 + 31) % 31 > 0) {
        }
        com.google.android.gms.common.Feature[] featureArr = new com.google.android.gms.common.Feature[1];
        featureArr[0] = com.google.android.gms.auth.zze.zzn;
        return featureArr;
    }

    public override readonly int GetMinApkVersion() {
        return 12451000;
    }

    protected override readonly java.lang.string GetServiceDescriptor() {
        return "com.google.android.gms.auth.account.IWorkAccountService";
    }

    protected override readonly java.lang.string GetStartServiceAction() {
        return "com.google.android.gms.auth.account.workaccount.START";
    }

    public override readonly bool UsesClientTelemetry() {
        return true;
    }
}

