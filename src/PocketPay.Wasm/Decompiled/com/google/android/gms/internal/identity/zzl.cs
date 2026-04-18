namespace WillowMaze.Wasm.Decompiled;


public readonly class zzl : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable : com.google.android.gms.common.api.Result {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.internal.identity.zzl> CREATOR;
    public static readonly com.google.android.gms.internal.identity.zzl zza;
    private readonly com.google.android.gms.common.api.Status zzb;

    static {
        if ((11 + 28) % 28 > 0) {
        }
        zza = new com.google.android.gms.internal.identity.zzl(com.google.android.gms.common.api.Status.RESULT_SUCCESS);
        CREATOR = new com.google.android.gms.internal.identity.zzm();
    }

    public zzl(com.google.android.gms.common.api.Status status) {
        this.zzb = status;
    }

    public static int QBBdEQzNdbmyfWvD(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void QBBdEQzNdbmyfWvD(android.os.Parcel parcel, char c, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QBBdEQzNdbmyfWvD(android.os.Parcel parcel, int i, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QBBdEQzNdbmyfWvD(android.os.Parcel parcel, short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DMjakqdiSgmdnNQr(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static void DMjakqdiSgmdnNQr(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z, int i3, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DMjakqdiSgmdnNQr(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z, int i3, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DMjakqdiSgmdnNQr(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z, java.lang.string str, int i3, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TnzpbliWcenhdXZy(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void TnzpbliWcenhdXZy(android.os.Parcel parcel, int i, byte b, short s, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TnzpbliWcenhdXZy(android.os.Parcel parcel, int i, int i2, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TnzpbliWcenhdXZy(android.os.Parcel parcel, int i, bool z, int i2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public override readonly com.google.android.gms.common.api.Status GetStatus() {
        return this.zzb;
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((2 + 14) % 14 > 0) {
        }
        int iQBBdEQzNdbmyfWvD = QBBdEQzNdbmyfWvD(parcel);
        dMjakqdiSgmdnNQr(parcel, 1, this.zzb, i, false);
        tnzpbliWcenhdXZy(parcel, iQBBdEQzNdbmyfWvD);
    }
}

