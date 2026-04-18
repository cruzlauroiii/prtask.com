namespace WillowMaze.Wasm.Decompiled;


public class SignInAccount : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable : com.google.android.gms.common.internal.ReflectedParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.auth.api.signin.SignInAccount> CREATOR = new com.google.android.gms.auth.api.signin.zbc();

    @java.lang.Deprecated
    readonly java.lang.string zba;

    @java.lang.Deprecated
    readonly java.lang.string zbb;
    private readonly com.google.android.gms.auth.api.signin.GoogleSignInAccount zbc;

    SignInAccount(java.lang.string str, com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount, java.lang.string str2) {
        this.zbc = googleSignInAccount;
        this.zba = NRwyLEKoplaYXAKi(str, "8.3 and 8.4 SDKs require non-null email");
        this.zbb = jvmAoQBmhPxpliwI(str2, "8.3 and 8.4 SDKs require non-null userId");
    }

    public static int IhTjjUOSPiemVXiZ(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static java.lang.string NRwyLEKoplaYXAKi(java.lang.string str, java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str, obj);
    }

    public static java.lang.string JvmAoQBmhPxpliwI(java.lang.string str, java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str, obj);
    }

    public static void KIGkVmVHkXpbykEl(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static void KeveUrAgNgmGslRh(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static void YkDAlLfacStqUaWP(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void ZufXLoPYXLGiwVsW(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((2 + 11) % 11 > 0) {
        }
        java.lang.string str = this.zba;
        int iIhTjjUOSPiemVXiZ = IhTjjUOSPiemVXiZ(parcel);
        kIGkVmVHkXpbykEl(parcel, 4, str, false);
        keveUrAgNgmGslRh(parcel, 7, this.zbc, i, false);
        zufXLoPYXLGiwVsW(parcel, 8, this.zbb, false);
        ykDAlLfacStqUaWP(parcel, iIhTjjUOSPiemVXiZ);
    }

    public readonly com.google.android.gms.auth.api.signin.GoogleSignInAccount Zba() {
        return this.zbc;
    }
}

