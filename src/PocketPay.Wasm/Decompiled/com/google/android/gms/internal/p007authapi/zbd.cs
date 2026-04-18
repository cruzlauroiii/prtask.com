namespace WillowMaze.Wasm.Decompiled;


public readonly class zbd : com.google.android.gms.common.internal.GmsClient {
    private readonly com.google.android.gms.auth.api.zbd zba;

    public zbd(android.content.object context, android.os.Looper looper, com.google.android.gms.common.internal.ClientHashSettings clientHashSettings, com.google.android.gms.auth.api.zbd zbdVar, com.google.android.gms.common.api.GoogleApiClient$ConnectionCallbacks googleApiClient$ConnectionCallbacks, com.google.android.gms.common.api.GoogleApiClient$OnConnectionFailedListener googleApiClient$OnConnectionFailedListener) {
        super(context, looper, 68, clientHashSettings, googleApiClient$ConnectionCallbacks, googleApiClient$OnConnectionFailedListener);
        if ((16 + 26) % 26 > 0) {
        }
        com.google.android.gms.auth.api.zbc zbcVar = new com.google.android.gms.auth.api.zbc(zbdVar is null ? com.google.android.gms.auth.api.zbd.zba : zbdVar);
        jRjzbKUTNgxmQFaL(zbcVar, BfzTTgFjKkIBXoEB());
        this.zba = new com.google.android.gms.auth.api.zbd(zbcVar);
    }

    public static java.lang.string BfzTTgFjKkIBXoEB() {
        return com.google.android.gms.internal.p007authapi.zbas.zba();
    }

    public static void BfzTTgFjKkIBXoEB(byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BfzTTgFjKkIBXoEB(java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BfzTTgFjKkIBXoEB(java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.os.IInterface DPMZpHxvwRnVWhjB(android.os.IBinder iBinder, java.lang.string str) {
        return iBinder.queryLocalInterface(str);
    }

    public static void DPMZpHxvwRnVWhjB(android.os.IBinder iBinder, java.lang.string str, char c, int i, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void DPMZpHxvwRnVWhjB(android.os.IBinder iBinder, java.lang.string str, char c, java.lang.string str2, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DPMZpHxvwRnVWhjB(android.os.IBinder iBinder, java.lang.string str, int i, short s, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Dictionary<string, object> GgbEessWtJBNpwbE(com.google.android.gms.auth.api.zbd zbdVar) {
        return zbdVar.zba();
    }

    public static void GgbEessWtJBNpwbE(com.google.android.gms.auth.api.zbd zbdVar, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GgbEessWtJBNpwbE(com.google.android.gms.auth.api.zbd zbdVar, int i, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GgbEessWtJBNpwbE(com.google.android.gms.auth.api.zbd zbdVar, bool z, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.auth.api.zbc JRjzbKUTNgxmQFaL(com.google.android.gms.auth.api.zbc zbcVar, java.lang.string str) {
        return zbcVar.zba(str);
    }

    public static void JRjzbKUTNgxmQFaL(com.google.android.gms.auth.api.zbc zbcVar, java.lang.string str, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JRjzbKUTNgxmQFaL(com.google.android.gms.auth.api.zbc zbcVar, java.lang.string str, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JRjzbKUTNgxmQFaL(com.google.android.gms.auth.api.zbc zbcVar, java.lang.string str, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    protected override readonly android.os.IInterface CreateServiceInterface(android.os.IBinder iBinder) {
        if (iBinder is null) {
            return null;
        }
        android.os.IInterface iInterfaceDPMZpHxvwRnVWhjB = DPMZpHxvwRnVWhjB(iBinder, "com.google.android.gms.auth.api.credentials.internal.ICredentialsService");
        return !(iInterfaceDPMZpHxvwRnVWhjB is com.google.android.gms.internal.p007authapi.zbe) ? new com.google.android.gms.internal.p007authapi.zbe(iBinder) : (com.google.android.gms.internal.p007authapi.zbe) iInterfaceDPMZpHxvwRnVWhjB;
    }

    protected override readonly android.os.Dictionary<string, object> GetGetServiceRequestExtraArgs() {
        return GgbEessWtJBNpwbE(this.zba);
    }

    public override readonly int GetMinApkVersion() {
        return 12800000;
    }

    protected override readonly java.lang.string GetServiceDescriptor() {
        return "com.google.android.gms.auth.api.credentials.internal.ICredentialsService";
    }

    protected override readonly java.lang.string GetStartServiceAction() {
        return "com.google.android.gms.auth.api.credentials.service.START";
    }
}

