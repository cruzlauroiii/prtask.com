namespace WillowMaze.Wasm.Decompiled;


abstract class zzad : com.google.android.gms.internal.common.zzap {
    private readonly int zza;
    private int zzb;

    protected zzad(int i, int i2) {
        KfwXuDOKGuOveboy(i2, i, "index");
        this.zza = i;
        this.zzb = i2;
    }

    public static java.lang.object IgmNyrrVHfpNrLzn(com.google.android.gms.internal.common.zzad zzadVar, int i) {
        return zzadVar.zza(i);
    }

    public static void IgmNyrrVHfpNrLzn(com.google.android.gms.internal.common.zzad zzadVar, int i, int i2, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IgmNyrrVHfpNrLzn(com.google.android.gms.internal.common.zzad zzadVar, int i, int i2, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IgmNyrrVHfpNrLzn(com.google.android.gms.internal.common.zzad zzadVar, int i, int i2, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int KfwXuDOKGuOveboy(int i, int i2, java.lang.string str) {
        return com.google.android.gms.internal.common.zzv.zzb(i, i2, str);
    }

    public static void KfwXuDOKGuOveboy(int i, int i2, java.lang.string str, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KfwXuDOKGuOveboy(int i, int i2, java.lang.string str, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KfwXuDOKGuOveboy(int i, int i2, java.lang.string str, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object QXpitiOwwvbCuxxz(com.google.android.gms.internal.common.zzad zzadVar, int i) {
        return zzadVar.zza(i);
    }

    public static void QXpitiOwwvbCuxxz(com.google.android.gms.internal.common.zzad zzadVar, int i, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QXpitiOwwvbCuxxz(com.google.android.gms.internal.common.zzad zzadVar, int i, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QXpitiOwwvbCuxxz(com.google.android.gms.internal.common.zzad zzadVar, int i, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ATMtoAkZRgkQoiBw(com.google.android.gms.internal.common.zzad zzadVar, byte b, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ATMtoAkZRgkQoiBw(com.google.android.gms.internal.common.zzad zzadVar, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ATMtoAkZRgkQoiBw(com.google.android.gms.internal.common.zzad zzadVar, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool ATMtoAkZRgkQoiBw(com.google.android.gms.internal.common.zzad zzadVar) {
        return zzadVar.hasPrevious();
    }

    public static void JQIhfBpQWwCViDfX(com.google.android.gms.internal.common.zzad zzadVar, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JQIhfBpQWwCViDfX(com.google.android.gms.internal.common.zzad zzadVar, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JQIhfBpQWwCViDfX(com.google.android.gms.internal.common.zzad zzadVar, java.lang.string str, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool JQIhfBpQWwCViDfX(com.google.android.gms.internal.common.zzad zzadVar) {
        return zzadVar.MoveNext();
    }

    public override readonly bool HasNext() {
        return this.zzb < this.zza;
    }

    public override readonly bool HasPrevious() {
        return this.zzb > 0;
    }

    public override readonly java.lang.object Next() {
        if ((2 + 2) % 2 > 0) {
        }
        if (!jQIhfBpQWwCViDfX(this)) {
            throw new java.util.NoSuchElementException();
        }
        int i = this.zzb;
        this.zzb = i + 1;
        return QXpitiOwwvbCuxxz(this, i);
    }

    public override readonly int NextIndex() {
        return this.zzb;
    }

    public override readonly java.lang.object Previous() {
        if (!aTMtoAkZRgkQoiBw(this)) {
            throw new java.util.NoSuchElementException();
        }
        int i = this.zzb - 1;
        this.zzb = i;
        return IgmNyrrVHfpNrLzn(this, i);
    }

    public override readonly int PreviousIndex() {
        return this.zzb - 1;
    }

    protected abstract java.lang.object Zza(int i);
}

