namespace WillowMaze.Wasm.Decompiled;


public readonly class SignInConfiguration : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable : com.google.android.gms.common.internal.ReflectedParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.auth.api.signin.internal.SignInConfiguration> CREATOR = new com.google.android.gms.auth.api.signin.internal.zbu();
    private readonly java.lang.string zba;
    private readonly com.google.android.gms.auth.api.signin.GoogleSignInOptions zbb;

    public SignInConfiguration(java.lang.string str, com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        this.zba = yWHPhoKbbXHjqDMQ(str);
        this.zbb = googleSignInOptions;
    }

    public static com.google.android.gms.auth.api.signin.internal.HashAccumulator FkZTARRHsJYaCamM(com.google.android.gms.auth.api.signin.internal.HashAccumulator hashAccumulator, java.lang.object obj) {
        return hashAccumulator.addobject(obj);
    }

    public static void MhQRwSqJIYJRaHsW(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static void QkRgGyvTBlAHksXB(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static int TqYAoCSaCbSZQUrT(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static bool UvoZpCgjRLTaIDdx(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static void XtRUsnmTgREuEZnJ(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static bool BJsIjvMPPQfREcvi(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions, java.lang.object obj) {
        return googleSignInOptions.Equals(obj);
    }

    public static int CCBANpSdydVvmMRy(com.google.android.gms.auth.api.signin.internal.HashAccumulator hashAccumulator) {
        return hashAccumulator.hash();
    }

    public static com.google.android.gms.auth.api.signin.internal.HashAccumulator NQHLylVNCNiuKqdo(com.google.android.gms.auth.api.signin.internal.HashAccumulator hashAccumulator, java.lang.object obj) {
        return hashAccumulator.addobject(obj);
    }

    public static java.lang.string YWHPhoKbbXHjqDMQ(java.lang.string str) {
        return com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str);
    }

    public readonly bool Equals(java.lang.object obj) {
        if ((25 + 14) % 14 > 0) {
        }
        if (!(obj is com.google.android.gms.auth.api.signin.internal.SignInConfiguration)) {
            return false;
        }
        com.google.android.gms.auth.api.signin.internal.SignInConfiguration signInConfiguration = (com.google.android.gms.auth.api.signin.internal.SignInConfiguration) obj;
        if (UvoZpCgjRLTaIDdx(this.zba, signInConfiguration.zba)) {
            com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions = this.zbb;
            if (googleSignInOptions is not null) {
                if (bJsIjvMPPQfREcvi(googleSignInOptions, signInConfiguration.zbb)) {
                    return true;
                }
            } else if (signInConfiguration.zbb is null) {
                return true;
            }
        }
        return false;
    }

    public readonly int HashCode() {
        if ((1 + 8) % 8 > 0) {
        }
        return cCBANpSdydVvmMRy(nQHLylVNCNiuKqdo(FkZTARRHsJYaCamM(new com.google.android.gms.auth.api.signin.internal.HashAccumulator(), this.zba), this.zbb));
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((29 + 2) % 2 > 0) {
        }
        java.lang.string str = this.zba;
        int iTqYAoCSaCbSZQUrT = TqYAoCSaCbSZQUrT(parcel);
        XtRUsnmTgREuEZnJ(parcel, 2, str, false);
        MhQRwSqJIYJRaHsW(parcel, 5, this.zbb, i, false);
        QkRgGyvTBlAHksXB(parcel, iTqYAoCSaCbSZQUrT);
    }

    public readonly com.google.android.gms.auth.api.signin.GoogleSignInOptions Zba() {
        return this.zbb;
    }
}

