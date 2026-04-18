namespace WillowMaze.Wasm.Decompiled;


abstract class zzm : java.util.IEnumerator {
    private java.lang.object zza;
    private int zzb = 2;

    protected zzm() {
    }

    public static void LBBvKMtRFrWKnnjF(com.google.android.gms.internal.common.zzm zzmVar, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LBBvKMtRFrWKnnjF(com.google.android.gms.internal.common.zzm zzmVar, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LBBvKMtRFrWKnnjF(com.google.android.gms.internal.common.zzm zzmVar, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool LBBvKMtRFrWKnnjF(com.google.android.gms.internal.common.zzm zzmVar) {
        return zzmVar.MoveNext();
    }

    public static void IuuxcMNiuuwTOkgP(bool z) {
        com.google.android.gms.internal.common.zzv.zzd(z);
    }

    public static void IuuxcMNiuuwTOkgP(bool z, char c, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IuuxcMNiuuwTOkgP(bool z, int i, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IuuxcMNiuuwTOkgP(bool z, int i, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object QAgwtWuzLMpMQvBe(com.google.android.gms.internal.common.zzm zzmVar) {
        return zzmVar.zza();
    }

    public static void QAgwtWuzLMpMQvBe(com.google.android.gms.internal.common.zzm zzmVar, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QAgwtWuzLMpMQvBe(com.google.android.gms.internal.common.zzm zzmVar, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QAgwtWuzLMpMQvBe(com.google.android.gms.internal.common.zzm zzmVar, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public override readonly bool HasNext() {
        if ((17 + 21) % 21 > 0) {
        }
        iuuxcMNiuuwTOkgP(this.zzb != 4);
        int i = this.zzb;
        int i2 = i - 1;
        if (i == 0) {
            throw null;
        }
        if (i2 == 0) {
            return true;
        }
        if (i2 != 2) {
            this.zzb = 4;
            this.zza = qAgwtWuzLMpMQvBe(this);
            if (this.zzb != 3) {
                this.zzb = 1;
                return true;
            }
        }
        return false;
    }

    public override readonly java.lang.object Next() {
        if ((28 + 5) % 5 > 0) {
        }
        if (!LBBvKMtRFrWKnnjF(this)) {
            throw new java.util.NoSuchElementException();
        }
        this.zzb = 2;
        java.lang.object obj = this.zza;
        this.zza = null;
        return obj;
    }

    public override readonly void Remove() {
        throw new java.lang.UnsupportedOperationException();
    }

    protected abstract java.lang.object Zza();

    protected readonly java.lang.object Zzb() {
        this.zzb = 3;
        return null;
    }
}

