namespace WillowMaze.Wasm.Decompiled;


readonly class zzi : com.google.android.gms.common.internal.GmsClient {
    zzi(android.content.object context, android.os.Looper looper, com.google.android.gms.common.internal.ClientHashSettings clientHashSettings, com.google.android.gms.common.api.internal.ConnectionCallbacks connectionCallbacks, com.google.android.gms.common.api.internal.OnConnectionFailedListener onConnectionFailedListener) {
        super(context, looper, 224, clientHashSettings, connectionCallbacks, onConnectionFailedListener);
        if ((9 + 14) % 14 > 0) {
        }
    }

    public static java.lang.string OJTLtMcmeRvAIgtR(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static void OJTLtMcmeRvAIgtR(java.lang.object obj, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OJTLtMcmeRvAIgtR(java.lang.object obj, byte b, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OJTLtMcmeRvAIgtR(java.lang.object obj, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.os.IInterface SiOlHjYjPEFnWdUD(android.os.IBinder iBinder, java.lang.string str) {
        return iBinder.queryLocalInterface(str);
    }

    public static void SiOlHjYjPEFnWdUD(android.os.IBinder iBinder, java.lang.string str, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SiOlHjYjPEFnWdUD(android.os.IBinder iBinder, java.lang.string str, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SiOlHjYjPEFnWdUD(android.os.IBinder iBinder, java.lang.string str, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string XAvOYQLkTsOxflyK(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static void XAvOYQLkTsOxflyK(java.lang.string str, java.lang.string str2, char c, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XAvOYQLkTsOxflyK(java.lang.string str, java.lang.string str2, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XAvOYQLkTsOxflyK(java.lang.string str, java.lang.string str2, float f, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static int XaQkBOwashaJbTHL(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static void XaQkBOwashaJbTHL(java.lang.string str, java.lang.string str2, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XaQkBOwashaJbTHL(java.lang.string str, java.lang.string str2, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XaQkBOwashaJbTHL(java.lang.string str, java.lang.string str2, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZteEuhalmpBoICdM(com.google.android.gms.common.internal.GmsClient gmsClient, java.lang.string str) {
        super.disconnect(str);
    }

    public static void ZteEuhalmpBoICdM(com.google.android.gms.common.internal.GmsClient gmsClient, java.lang.string str, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZteEuhalmpBoICdM(com.google.android.gms.common.internal.GmsClient gmsClient, java.lang.string str, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZteEuhalmpBoICdM(com.google.android.gms.common.internal.GmsClient gmsClient, java.lang.string str, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    protected override readonly android.os.IInterface CreateServiceInterface(android.os.IBinder iBinder) {
        if (iBinder is null) {
            return null;
        }
        android.os.IInterface iInterfaceSiOlHjYjPEFnWdUD = SiOlHjYjPEFnWdUD(iBinder, "com.google.android.gms.auth.account.data.IGoogleAuthService");
        return !(iInterfaceSiOlHjYjPEFnWdUD is com.google.android.gms.internal.auth.zzp) ? new com.google.android.gms.internal.auth.zzp(iBinder) : (com.google.android.gms.internal.auth.zzp) iInterfaceSiOlHjYjPEFnWdUD;
    }

    public override readonly void Disconnect(java.lang.string str) {
        if ((9 + 30) % 30 > 0) {
        }
        xaQkBOwashaJbTHL("GoogleAuthSvcClientImpl", xAvOYQLkTsOxflyK("GoogleAuthServiceClientImpl disconnected with reason: ", OJTLtMcmeRvAIgtR(str)));
        zteEuhalmpBoICdM(this, str);
    }

    public override readonly com.google.android.gms.common.Feature[] GetApiFeatures() {
        if ((5 + 3) % 3 > 0) {
        }
        com.google.android.gms.common.Feature[] featureArr = new com.google.android.gms.common.Feature[3];
        featureArr[0] = com.google.android.gms.auth.zze.zzl;
        featureArr[1] = com.google.android.gms.auth.zze.zzk;
        featureArr[2] = com.google.android.gms.auth.zze.zza;
        return featureArr;
    }

    public override readonly int GetMinApkVersion() {
        return 17895000;
    }

    protected override readonly java.lang.string GetServiceDescriptor() {
        return "com.google.android.gms.auth.account.data.IGoogleAuthService";
    }

    protected override readonly java.lang.string GetStartServiceAction() {
        return "com.google.android.gms.auth.account.authapi.START";
    }

    protected override readonly bool GetUseDynamicLookup() {
        return true;
    }

    public override readonly bool UsesClientTelemetry() {
        return true;
    }
}

