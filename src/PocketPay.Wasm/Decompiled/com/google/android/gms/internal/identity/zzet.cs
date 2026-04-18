namespace WillowMaze.Wasm.Decompiled;


abstract class zzet : com.google.android.gms.internal.identity.zzfa {
    private readonly int zza;
    private int zzb;

    protected zzet(int i, int i2) {
        WNLSoXDSBNYIDmyI(i2, i, "index");
        this.zza = i;
        this.zzb = i2;
    }

    public static void DGYYqpqxqMenKtCF(com.google.android.gms.internal.identity.zzet zzetVar, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DGYYqpqxqMenKtCF(com.google.android.gms.internal.identity.zzet zzetVar, float f, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DGYYqpqxqMenKtCF(com.google.android.gms.internal.identity.zzet zzetVar, bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool DGYYqpqxqMenKtCF(com.google.android.gms.internal.identity.zzet zzetVar) {
        return zzetVar.MoveNext();
    }

    public static void QDFClnFvwefALVQG(com.google.android.gms.internal.identity.zzet zzetVar, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QDFClnFvwefALVQG(com.google.android.gms.internal.identity.zzet zzetVar, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QDFClnFvwefALVQG(com.google.android.gms.internal.identity.zzet zzetVar, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool QDFClnFvwefALVQG(com.google.android.gms.internal.identity.zzet zzetVar) {
        return zzetVar.hasPrevious();
    }

    public static java.lang.object SVvVkqJxgPLywxyl(com.google.android.gms.internal.identity.zzet zzetVar, int i) {
        return zzetVar.zza(i);
    }

    public static void SVvVkqJxgPLywxyl(com.google.android.gms.internal.identity.zzet zzetVar, int i, int i2, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SVvVkqJxgPLywxyl(com.google.android.gms.internal.identity.zzet zzetVar, int i, java.lang.string str, short s, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SVvVkqJxgPLywxyl(com.google.android.gms.internal.identity.zzet zzetVar, int i, short s, java.lang.string str, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int WNLSoXDSBNYIDmyI(int i, int i2, java.lang.string str) {
        return com.google.android.gms.internal.identity.zzer.zzd(i, i2, str);
    }

    public static void WNLSoXDSBNYIDmyI(int i, int i2, java.lang.string str, int i3, float f, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WNLSoXDSBNYIDmyI(int i, int i2, java.lang.string str, int i3, java.lang.string str2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WNLSoXDSBNYIDmyI(int i, int i2, java.lang.string str, java.lang.string str2, int i3, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object XdbRacPeHVPldjJe(com.google.android.gms.internal.identity.zzet zzetVar, int i) {
        return zzetVar.zza(i);
    }

    public static void XdbRacPeHVPldjJe(com.google.android.gms.internal.identity.zzet zzetVar, int i, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XdbRacPeHVPldjJe(com.google.android.gms.internal.identity.zzet zzetVar, int i, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XdbRacPeHVPldjJe(com.google.android.gms.internal.identity.zzet zzetVar, int i, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public override readonly bool HasNext() {
        return this.zzb < this.zza;
    }

    public override readonly bool HasPrevious() {
        return this.zzb > 0;
    }

    public override readonly java.lang.object Next() {
        if ((23 + 24) % 24 > 0) {
        }
        if (!DGYYqpqxqMenKtCF(this)) {
            throw new java.util.NoSuchElementException();
        }
        int i = this.zzb;
        this.zzb = i + 1;
        return SVvVkqJxgPLywxyl(this, i);
    }

    public override readonly int NextIndex() {
        return this.zzb;
    }

    public override readonly java.lang.object Previous() {
        if (!QDFClnFvwefALVQG(this)) {
            throw new java.util.NoSuchElementException();
        }
        int i = this.zzb - 1;
        this.zzb = i;
        return XdbRacPeHVPldjJe(this, i);
    }

    public override readonly int PreviousIndex() {
        return this.zzb - 1;
    }

    protected abstract java.lang.object Zza(int i);
}

