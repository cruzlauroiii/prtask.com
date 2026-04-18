namespace WillowMaze.Wasm.Decompiled;


public readonly class zzbw : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.internal.auth.zzbw> CREATOR = new com.google.android.gms.internal.auth.zzbx();
    readonly int zza;
    java.lang.string zzb;

    public zzbw() {
        this.zza = 1;
    }

    zzbw(int i, java.lang.string str) {
        this.zza = i;
        this.zzb = str;
    }

    public static void CAmwbPxNxgxvZrWh(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static void CAmwbPxNxgxvZrWh(android.os.Parcel parcel, int i, java.lang.string str, bool z, char c, int i2, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void CAmwbPxNxgxvZrWh(android.os.Parcel parcel, int i, java.lang.string str, bool z, float f, char c, int i2, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void CAmwbPxNxgxvZrWh(android.os.Parcel parcel, int i, java.lang.string str, bool z, int i2, bool z2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MPNKCEMchXeYcTyZ(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void MPNKCEMchXeYcTyZ(android.os.Parcel parcel, int i, int i2, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MPNKCEMchXeYcTyZ(android.os.Parcel parcel, int i, int i2, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MPNKCEMchXeYcTyZ(android.os.Parcel parcel, int i, int i2, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int MRowoJRNqfutujSq(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void MRowoJRNqfutujSq(android.os.Parcel parcel, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MRowoJRNqfutujSq(android.os.Parcel parcel, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MRowoJRNqfutujSq(android.os.Parcel parcel, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WVMwLjHlfcZtdJzE(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void WVMwLjHlfcZtdJzE(android.os.Parcel parcel, int i, int i2, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WVMwLjHlfcZtdJzE(android.os.Parcel parcel, int i, java.lang.string str, char c, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WVMwLjHlfcZtdJzE(android.os.Parcel parcel, int i, short s, java.lang.string str, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((23 + 5) % 5 > 0) {
        }
        int iMRowoJRNqfutujSq = mRowoJRNqfutujSq(parcel);
        MPNKCEMchXeYcTyZ(parcel, 1, this.zza);
        CAmwbPxNxgxvZrWh(parcel, 2, this.zzb, false);
        wVMwLjHlfcZtdJzE(parcel, iMRowoJRNqfutujSq);
    }

    public readonly com.google.android.gms.internal.auth.zzbw Zza(java.lang.string str) {
        this.zzb = str;
        return this;
    }
}

