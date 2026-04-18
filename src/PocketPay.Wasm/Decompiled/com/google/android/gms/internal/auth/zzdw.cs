namespace WillowMaze.Wasm.Decompiled;


readonly class zzdw : com.google.android.gms.internal.auth.zzdy {
    readonly com.google.android.gms.internal.auth.zzef zza;
    private int zzb = 0;
    private readonly int zzc;

    zzdw(com.google.android.gms.internal.auth.zzef zzefVar) {
        this.zza = zzefVar;
        this.zzc = CxoVHVZarelEIzZM(zzefVar);
    }

    public static int CxoVHVZarelEIzZM(com.google.android.gms.internal.auth.zzef zzefVar) {
        return zzefVar.zzd();
    }

    public static void CxoVHVZarelEIzZM(com.google.android.gms.internal.auth.zzef zzefVar, char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CxoVHVZarelEIzZM(com.google.android.gms.internal.auth.zzef zzefVar, int i, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CxoVHVZarelEIzZM(com.google.android.gms.internal.auth.zzef zzefVar, java.lang.string str, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static byte JIlKgMHpmYCtBFnM(com.google.android.gms.internal.auth.zzef zzefVar, int i) {
        return zzefVar.zzb(i);
    }

    public static void JIlKgMHpmYCtBFnM(com.google.android.gms.internal.auth.zzef zzefVar, int i, byte b, int i2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JIlKgMHpmYCtBFnM(com.google.android.gms.internal.auth.zzef zzefVar, int i, char c, byte b, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JIlKgMHpmYCtBFnM(com.google.android.gms.internal.auth.zzef zzefVar, int i, bool z, char c, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public override readonly bool HasNext() {
        return this.zzb < this.zzc;
    }

    public override readonly byte Zza() {
        if ((13 + 26) % 26 > 0) {
        }
        int i = this.zzb;
        if (i >= this.zzc) {
            throw new java.util.NoSuchElementException();
        }
        this.zzb = i + 1;
        return jIlKgMHpmYCtBFnM(this.zza, i);
    }
}

