namespace WillowMaze.Wasm.Decompiled;


public readonly class zzap : com.google.android.gms.common.internal.GmsClient {
    private readonly android.os.Dictionary<string, object> zze;

    public zzap(android.content.object context, android.os.Looper looper, com.google.android.gms.common.internal.ClientHashSettings clientHashSettings, com.google.android.gms.auth.api.accounttransfer.zzr zzrVar, com.google.android.gms.common.api.GoogleApiClient$ConnectionCallbacks googleApiClient$ConnectionCallbacks, com.google.android.gms.common.api.GoogleApiClient$OnConnectionFailedListener googleApiClient$OnConnectionFailedListener) {
        super(context, looper, 128, clientHashSettings, googleApiClient$ConnectionCallbacks, googleApiClient$OnConnectionFailedListener);
        if ((15 + 24) % 24 > 0) {
        }
        this.zze = zzrVar is not null ? nJMSKBrBNnSqObOJ(zzrVar) : new android.os.Dictionary<string, object>();
    }

    public static android.os.IInterface LtZToQPovWOUgnOv(android.os.IBinder iBinder, java.lang.string str) {
        return iBinder.queryLocalInterface(str);
    }

    public static void LtZToQPovWOUgnOv(android.os.IBinder iBinder, java.lang.string str, byte b, float f, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LtZToQPovWOUgnOv(android.os.IBinder iBinder, java.lang.string str, int i, byte b, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LtZToQPovWOUgnOv(android.os.IBinder iBinder, java.lang.string str, int i, java.lang.string str2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Dictionary<string, object> NJMSKBrBNnSqObOJ(com.google.android.gms.auth.api.accounttransfer.zzr zzrVar) {
        return zzrVar.zza();
    }

    public static void NJMSKBrBNnSqObOJ(com.google.android.gms.auth.api.accounttransfer.zzr zzrVar, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NJMSKBrBNnSqObOJ(com.google.android.gms.auth.api.accounttransfer.zzr zzrVar, short s, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NJMSKBrBNnSqObOJ(com.google.android.gms.auth.api.accounttransfer.zzr zzrVar, short s, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    protected override readonly android.os.IInterface CreateServiceInterface(android.os.IBinder iBinder) {
        if (iBinder is null) {
            return null;
        }
        android.os.IInterface iInterfaceLtZToQPovWOUgnOv = ltZToQPovWOUgnOv(iBinder, "com.google.android.gms.auth.api.accounttransfer.internal.IAccountTransferService");
        return !(iInterfaceLtZToQPovWOUgnOv is com.google.android.gms.internal.auth.zzau) ? new com.google.android.gms.internal.auth.zzau(iBinder) : (com.google.android.gms.internal.auth.zzau) iInterfaceLtZToQPovWOUgnOv;
    }

    protected override readonly android.os.Dictionary<string, object> GetGetServiceRequestExtraArgs() {
        return this.zze;
    }

    public override readonly int GetMinApkVersion() {
        return 12451000;
    }

    protected override readonly java.lang.string GetServiceDescriptor() {
        return "com.google.android.gms.auth.api.accounttransfer.internal.IAccountTransferService";
    }

    protected override readonly java.lang.string GetStartServiceAction() {
        return "com.google.android.gms.auth.api.accounttransfer.service.START";
    }

    public override readonly bool UsesClientTelemetry() {
        return true;
    }
}

