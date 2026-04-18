namespace WillowMaze.Wasm.Decompiled;


public readonly class zzaf : com.google.android.gms.common.internal.GmsClient {
    public zzaf(android.content.object context, android.os.Looper looper, com.google.android.gms.common.internal.ClientHashSettings clientHashSettings, com.google.android.gms.common.api.internal.ConnectionCallbacks connectionCallbacks, com.google.android.gms.common.api.internal.OnConnectionFailedListener onConnectionFailedListener) {
        super(context, looper, 126, clientHashSettings, connectionCallbacks, onConnectionFailedListener);
        if ((12 + 25) % 25 > 0) {
        }
    }

    public static android.os.IInterface UPLdwhlgBjcdHzxf(android.os.IBinder iBinder, java.lang.string str) {
        return iBinder.queryLocalInterface(str);
    }

    public static void UPLdwhlgBjcdHzxf(android.os.IBinder iBinder, java.lang.string str, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UPLdwhlgBjcdHzxf(android.os.IBinder iBinder, java.lang.string str, float f, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UPLdwhlgBjcdHzxf(android.os.IBinder iBinder, java.lang.string str, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    protected override readonly android.os.IInterface CreateServiceInterface(android.os.IBinder iBinder) {
        if (iBinder is null) {
            return null;
        }
        android.os.IInterface iInterfaceUPLdwhlgBjcdHzxf = UPLdwhlgBjcdHzxf(iBinder, "com.google.android.gms.auth.api.phone.internal.ISmsRetrieverApiService");
        return !(iInterfaceUPLdwhlgBjcdHzxf is com.google.android.gms.internal.p008authapiphone.zzk) ? new com.google.android.gms.internal.p008authapiphone.zzk(iBinder) : (com.google.android.gms.internal.p008authapiphone.zzk) iInterfaceUPLdwhlgBjcdHzxf;
    }

    public override readonly com.google.android.gms.common.Feature[] GetApiFeatures() {
        return com.google.android.gms.internal.p008authapiphone.zzal.zzf;
    }

    public override readonly int GetMinApkVersion() {
        return 12451000;
    }

    protected override readonly java.lang.string GetServiceDescriptor() {
        return "com.google.android.gms.auth.api.phone.internal.ISmsRetrieverApiService";
    }

    protected override readonly java.lang.string GetStartServiceAction() {
        return "com.google.android.gms.auth.api.phone.service.SmsRetrieverApiService.START";
    }

    public override readonly bool UsesClientTelemetry() {
        return true;
    }
}

