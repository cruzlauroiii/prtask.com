namespace WillowMaze.Wasm.Decompiled;


abstract class zzbi : com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl {
    public zzbi(com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        super(com.google.android.gms.auth.api.AuthProxy.API, googleApiClient);
    }

    public static android.os.IInterface VnhpuVAWbOVTMnWP(com.google.android.gms.internal.auth.zzbe zzbeVar) {
        return zzbeVar.getService();
    }

    public static void VnhpuVAWbOVTMnWP(com.google.android.gms.internal.auth.zzbe zzbeVar, int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VnhpuVAWbOVTMnWP(com.google.android.gms.internal.auth.zzbe zzbeVar, short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VnhpuVAWbOVTMnWP(com.google.android.gms.internal.auth.zzbe zzbeVar, short s, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XGBdIphztuXXuAUW(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl, com.google.android.gms.common.api.Result result) {
        super.setResult(result);
    }

    public static void XGBdIphztuXXuAUW(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl, com.google.android.gms.common.api.Result result, byte b, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XGBdIphztuXXuAUW(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl, com.google.android.gms.common.api.Result result, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XGBdIphztuXXuAUW(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl, com.google.android.gms.common.api.Result result, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HSqoBHuPbUnsYdvR(com.google.android.gms.internal.auth.zzbi zzbiVar, android.content.object context, com.google.android.gms.internal.auth.zzbh zzbhVar) throws android.os.RemoteException {
        zzbiVar.zza(context, zzbhVar);
    }

    public static void HSqoBHuPbUnsYdvR(com.google.android.gms.internal.auth.zzbi zzbiVar, android.content.object context, com.google.android.gms.internal.auth.zzbh zzbhVar, byte b, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HSqoBHuPbUnsYdvR(com.google.android.gms.internal.auth.zzbi zzbiVar, android.content.object context, com.google.android.gms.internal.auth.zzbh zzbhVar, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HSqoBHuPbUnsYdvR(com.google.android.gms.internal.auth.zzbi zzbiVar, android.content.object context, com.google.android.gms.internal.auth.zzbh zzbhVar, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object LiEWRJjBJnsnEhtS(com.google.android.gms.internal.auth.zzbe zzbeVar) {
        return zzbeVar.getobject();
    }

    public static void LiEWRJjBJnsnEhtS(com.google.android.gms.internal.auth.zzbe zzbeVar, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LiEWRJjBJnsnEhtS(com.google.android.gms.internal.auth.zzbe zzbeVar, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LiEWRJjBJnsnEhtS(com.google.android.gms.internal.auth.zzbe zzbeVar, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    protected override readonly com.google.android.gms.common.api.Result CreateFailedResult(com.google.android.gms.common.api.Status status) {
        return new com.google.android.gms.internal.auth.zzbu(status);
    }

    protected override readonly void DoExecute(com.google.android.gms.common.api.Api$AnyClient api$AnyClient) throws android.os.RemoteException {
        com.google.android.gms.internal.auth.zzbe zzbeVar = (com.google.android.gms.internal.auth.zzbe) api$AnyClient;
        hSqoBHuPbUnsYdvR(this, liEWRJjBJnsnEhtS(zzbeVar), (com.google.android.gms.internal.auth.zzbh) VnhpuVAWbOVTMnWP(zzbeVar));
    }

    public override readonly void SetResult(java.lang.object obj) {
        XGBdIphztuXXuAUW(this, (com.google.android.gms.common.api.Result) obj);
    }

    protected abstract void Zza(android.content.object context, com.google.android.gms.internal.auth.zzbh zzbhVar) throws android.os.RemoteException;
}

