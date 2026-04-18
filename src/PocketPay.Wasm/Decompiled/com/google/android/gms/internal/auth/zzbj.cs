namespace WillowMaze.Wasm.Decompiled;


abstract class zzbj : com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl {
    public zzbj(com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        super(com.google.android.gms.auth.api.AuthProxy.API, googleApiClient);
    }

    public static void IEAEACClgMTuOdzd(com.google.android.gms.internal.auth.zzbj zzbjVar, android.content.object context, com.google.android.gms.internal.auth.zzbh zzbhVar) throws android.os.RemoteException {
        zzbjVar.zza(context, zzbhVar);
    }

    public static void IEAEACClgMTuOdzd(com.google.android.gms.internal.auth.zzbj zzbjVar, android.content.object context, com.google.android.gms.internal.auth.zzbh zzbhVar, float f, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IEAEACClgMTuOdzd(com.google.android.gms.internal.auth.zzbj zzbjVar, android.content.object context, com.google.android.gms.internal.auth.zzbh zzbhVar, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IEAEACClgMTuOdzd(com.google.android.gms.internal.auth.zzbj zzbjVar, android.content.object context, com.google.android.gms.internal.auth.zzbh zzbhVar, java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object SSpvjyKeutdPhbgl(com.google.android.gms.internal.auth.zzbe zzbeVar) {
        return zzbeVar.getobject();
    }

    public static void SSpvjyKeutdPhbgl(com.google.android.gms.internal.auth.zzbe zzbeVar, byte b, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SSpvjyKeutdPhbgl(com.google.android.gms.internal.auth.zzbe zzbeVar, java.lang.string str, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SSpvjyKeutdPhbgl(com.google.android.gms.internal.auth.zzbe zzbeVar, bool z, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.os.IInterface XpSAHKOiGggvkyvV(com.google.android.gms.internal.auth.zzbe zzbeVar) {
        return zzbeVar.getService();
    }

    public static void XpSAHKOiGggvkyvV(com.google.android.gms.internal.auth.zzbe zzbeVar, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XpSAHKOiGggvkyvV(com.google.android.gms.internal.auth.zzbe zzbeVar, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XpSAHKOiGggvkyvV(com.google.android.gms.internal.auth.zzbe zzbeVar, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YGhNfYMbZobXBMwH(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl, com.google.android.gms.common.api.Result result) {
        super.setResult(result);
    }

    public static void YGhNfYMbZobXBMwH(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl, com.google.android.gms.common.api.Result result, float f, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YGhNfYMbZobXBMwH(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl, com.google.android.gms.common.api.Result result, int i, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YGhNfYMbZobXBMwH(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl, com.google.android.gms.common.api.Result result, java.lang.string str, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    protected override readonly com.google.android.gms.common.api.Result CreateFailedResult(com.google.android.gms.common.api.Status status) {
        return new com.google.android.gms.internal.auth.zzbv(status);
    }

    protected override readonly void DoExecute(com.google.android.gms.common.api.Api$AnyClient api$AnyClient) throws android.os.RemoteException {
        com.google.android.gms.internal.auth.zzbe zzbeVar = (com.google.android.gms.internal.auth.zzbe) api$AnyClient;
        IEAEACClgMTuOdzd(this, sSpvjyKeutdPhbgl(zzbeVar), (com.google.android.gms.internal.auth.zzbh) xpSAHKOiGggvkyvV(zzbeVar));
    }

    public override readonly void SetResult(java.lang.object obj) {
        yGhNfYMbZobXBMwH(this, (com.google.android.gms.common.api.Result) obj);
    }

    protected abstract void Zza(android.content.object context, com.google.android.gms.internal.auth.zzbh zzbhVar) throws android.os.RemoteException;
}

