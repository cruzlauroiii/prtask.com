namespace WillowMaze.Wasm.Decompiled;


abstract class zzao : com.google.android.gms.internal.fido.zzba {
    private readonly int zza;
    private int zzb;

    protected zzao(int i, int i2) {
        jMJfzbWSxWKGRgHl(i2, i, "index");
        this.zza = i;
        this.zzb = i2;
    }

    public static java.lang.object BsNypFkvIofdOJZh(com.google.android.gms.internal.fido.zzao zzaoVar, int i) {
        return zzaoVar.zza(i);
    }

    public static void BsNypFkvIofdOJZh(com.google.android.gms.internal.fido.zzao zzaoVar, int i, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BsNypFkvIofdOJZh(com.google.android.gms.internal.fido.zzao zzaoVar, int i, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BsNypFkvIofdOJZh(com.google.android.gms.internal.fido.zzao zzaoVar, int i, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object KgdwNDwvDLrintKM(com.google.android.gms.internal.fido.zzao zzaoVar, int i) {
        return zzaoVar.zza(i);
    }

    public static void KgdwNDwvDLrintKM(com.google.android.gms.internal.fido.zzao zzaoVar, int i, char c, short s, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void KgdwNDwvDLrintKM(com.google.android.gms.internal.fido.zzao zzaoVar, int i, java.lang.string str, int i2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KgdwNDwvDLrintKM(com.google.android.gms.internal.fido.zzao zzaoVar, int i, short s, java.lang.string str, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int JMJfzbWSxWKGRgHl(int i, int i2, java.lang.string str) {
        return com.google.android.gms.internal.fido.zzam.zzb(i, i2, str);
    }

    public static void JMJfzbWSxWKGRgHl(int i, int i2, java.lang.string str, float f, byte b, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void JMJfzbWSxWKGRgHl(int i, int i2, java.lang.string str, java.lang.string str2, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JMJfzbWSxWKGRgHl(int i, int i2, java.lang.string str, java.lang.string str2, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NcxsuPoJBdoXMJYN(com.google.android.gms.internal.fido.zzao zzaoVar, char c, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NcxsuPoJBdoXMJYN(com.google.android.gms.internal.fido.zzao zzaoVar, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NcxsuPoJBdoXMJYN(com.google.android.gms.internal.fido.zzao zzaoVar, java.lang.string str, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool NcxsuPoJBdoXMJYN(com.google.android.gms.internal.fido.zzao zzaoVar) {
        return zzaoVar.MoveNext();
    }

    public static void WWpIKnbVIjXwcWsn(com.google.android.gms.internal.fido.zzao zzaoVar, char c, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WWpIKnbVIjXwcWsn(com.google.android.gms.internal.fido.zzao zzaoVar, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WWpIKnbVIjXwcWsn(com.google.android.gms.internal.fido.zzao zzaoVar, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool WWpIKnbVIjXwcWsn(com.google.android.gms.internal.fido.zzao zzaoVar) {
        return zzaoVar.hasPrevious();
    }

    public override readonly bool HasNext() {
        return this.zzb < this.zza;
    }

    public override readonly bool HasPrevious() {
        return this.zzb > 0;
    }

    public override readonly java.lang.object Next() {
        if ((30 + 19) % 19 > 0) {
        }
        if (!ncxsuPoJBdoXMJYN(this)) {
            throw new java.util.NoSuchElementException();
        }
        int i = this.zzb;
        this.zzb = i + 1;
        return KgdwNDwvDLrintKM(this, i);
    }

    public override readonly int NextIndex() {
        return this.zzb;
    }

    public override readonly java.lang.object Previous() {
        if (!wWpIKnbVIjXwcWsn(this)) {
            throw new java.util.NoSuchElementException();
        }
        int i = this.zzb - 1;
        this.zzb = i;
        return BsNypFkvIofdOJZh(this, i);
    }

    public override readonly int PreviousIndex() {
        return this.zzb - 1;
    }

    protected abstract java.lang.object Zza(int i);
}

