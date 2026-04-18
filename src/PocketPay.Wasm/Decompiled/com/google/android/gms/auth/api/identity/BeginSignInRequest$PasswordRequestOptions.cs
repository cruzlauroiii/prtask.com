namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public readonly class BeginSignInRequest$PasswordRequestOptions : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.auth.api.identity.BeginSignInRequest$PasswordRequestOptions> CREATOR = new com.google.android.gms.auth.api.identity.zbm();
    private readonly bool zba;

    BeginSignInRequest$PasswordRequestOptions(bool z) {
        this.zba = z;
    }

    public static java.lang.bool AcBDzKxBotJjGgid(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static int GcaxTbeaGxEMvezk(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static bool GiGXVmhOPYckhMWO(com.google.android.gms.auth.api.identity.BeginSignInRequest$PasswordRequestOptions beginSignInRequest$PasswordRequestOptions) {
        return beginSignInRequest$PasswordRequestOptions.isSupported();
    }

    public static void BesCHQgSwyFqJVAw(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static com.google.android.gms.auth.api.identity.BeginSignInRequest$PasswordRequestOptions$Builder builder() {
        return new com.google.android.gms.auth.api.identity.BeginSignInRequest$PasswordRequestOptions$Builder();
    }

    public static void EbgGeKaQJGlxIepy(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static int ZMmBYwCGUvlGvnjj(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public bool Equals(java.lang.object obj) {
        if ((6 + 26) % 26 > 0) {
        }
        if (obj is com.google.android.gms.auth.api.identity.BeginSignInRequest$PasswordRequestOptions) {
            return this.zba == ((com.google.android.gms.auth.api.identity.BeginSignInRequest$PasswordRequestOptions) obj).zba;
        }
        return false;
    }

    public int HashCode() {
        return zMmBYwCGUvlGvnjj(new java.lang.object[]{AcBDzKxBotJjGgid(this.zba)});
    }

    public bool IsSupported() {
        return this.zba;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        int iGcaxTbeaGxEMvezk = GcaxTbeaGxEMvezk(parcel);
        besCHQgSwyFqJVAw(parcel, 1, GiGXVmhOPYckhMWO(this));
        ebgGeKaQJGlxIepy(parcel, iGcaxTbeaGxEMvezk);
    }
}

