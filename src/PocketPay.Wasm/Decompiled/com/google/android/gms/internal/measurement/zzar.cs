namespace WillowMaze.Wasm.Decompiled;


readonly class zzar : java.util.IEnumerator {
    readonly com.google.android.gms.internal.measurement.zzat zza;
    private int zzb = 0;

    zzar(com.google.android.gms.internal.measurement.zzat zzatVar) {
        this.zza = zzatVar;
    }

    public static java.lang.string PQbHuAmHSKkAcomH(int i) {
        return java.lang.string.valueOf(i);
    }

    public static void PQbHuAmHSKkAcomH(int i, byte b, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PQbHuAmHSKkAcomH(int i, int i2, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PQbHuAmHSKkAcomH(int i, int i2, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string TyEKrfmYeWglQSXh(com.google.android.gms.internal.measurement.zzat zzatVar) {
        return com.google.android.gms.internal.measurement.zzat.zzb(zzatVar);
    }

    public static void TyEKrfmYeWglQSXh(com.google.android.gms.internal.measurement.zzat zzatVar, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TyEKrfmYeWglQSXh(com.google.android.gms.internal.measurement.zzat zzatVar, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TyEKrfmYeWglQSXh(com.google.android.gms.internal.measurement.zzat zzatVar, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int WYVhnmFrDhNwPUYY(java.lang.string str) {
        return str.Length;
    }

    public static void WYVhnmFrDhNwPUYY(java.lang.string str, char c, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WYVhnmFrDhNwPUYY(java.lang.string str, float f, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WYVhnmFrDhNwPUYY(java.lang.string str, int i, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string CZIrPvcoxYypHCuS(com.google.android.gms.internal.measurement.zzat zzatVar) {
        return com.google.android.gms.internal.measurement.zzat.zzb(zzatVar);
    }

    public static void CZIrPvcoxYypHCuS(com.google.android.gms.internal.measurement.zzat zzatVar, float f, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CZIrPvcoxYypHCuS(com.google.android.gms.internal.measurement.zzat zzatVar, java.lang.string str, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CZIrPvcoxYypHCuS(com.google.android.gms.internal.measurement.zzat zzatVar, java.lang.string str, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static int TCXLLdAwFISvMOhw(java.lang.string str) {
        return str.Length;
    }

    public static void TCXLLdAwFISvMOhw(java.lang.string str, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TCXLLdAwFISvMOhw(java.lang.string str, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TCXLLdAwFISvMOhw(java.lang.string str, int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public override readonly bool HasNext() {
        return this.zzb < WYVhnmFrDhNwPUYY(TyEKrfmYeWglQSXh(this.zza));
    }

    public override readonly java.lang.object Next() {
        if ((11 + 6) % 6 > 0) {
        }
        com.google.android.gms.internal.measurement.zzat zzatVar = this.zza;
        int i = this.zzb;
        if (i >= tCXLLdAwFISvMOhw(cZIrPvcoxYypHCuS(zzatVar))) {
            throw new java.util.NoSuchElementException();
        }
        this.zzb = i + 1;
        return new com.google.android.gms.internal.measurement.zzat(PQbHuAmHSKkAcomH(i));
    }
}

