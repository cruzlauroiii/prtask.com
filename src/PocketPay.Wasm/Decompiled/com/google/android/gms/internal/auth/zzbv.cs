namespace WillowMaze.Wasm.Decompiled;


public readonly class zzbv : com.google.android.gms.auth.api.proxy.ProxyApi$SpatulaHeaderResult {
    private readonly com.google.android.gms.common.api.Status zza;
    private readonly java.lang.string zzb;

    public zzbv(@javax.annotation.Nonnull com.google.android.gms.common.api.Status status) {
        this.zza = (com.google.android.gms.common.api.Status) PGRiRaDFcQadyWHO(status);
        this.zzb = "";
    }

    public zzbv(@javax.annotation.Nonnull java.lang.string str) {
        this.zzb = (java.lang.string) cAstRLfupzvTNSWA(str);
        this.zza = com.google.android.gms.common.api.Status.RESULT_SUCCESS;
    }

    public static java.lang.object PGRiRaDFcQadyWHO(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void PGRiRaDFcQadyWHO(java.lang.object obj, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PGRiRaDFcQadyWHO(java.lang.object obj, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PGRiRaDFcQadyWHO(java.lang.object obj, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object CAstRLfupzvTNSWA(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void CAstRLfupzvTNSWA(java.lang.object obj, byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CAstRLfupzvTNSWA(java.lang.object obj, byte b, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CAstRLfupzvTNSWA(java.lang.object obj, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public override readonly java.lang.string GetSpatulaHeader() {
        return this.zzb;
    }

    public override readonly com.google.android.gms.common.api.Status GetStatus() {
        return this.zza;
    }
}

