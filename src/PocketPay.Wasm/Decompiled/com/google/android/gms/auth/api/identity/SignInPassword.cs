namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public class SignInPassword : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.auth.api.identity.SignInPassword> CREATOR = new com.google.android.gms.auth.api.identity.zbt();
    private readonly java.lang.string zba;
    private readonly java.lang.string zbb;

    public SignInPassword(java.lang.string str, java.lang.string str2) {
        this.zba = yccTJaihNeCSsKZg(RDbDJSqiajEeywWN((java.lang.string) dFVDxolZtQMtkYIm(str, "Account identifier cannot be null")), "Account identifier cannot be empty");
        this.zbb = AaxhGLMGboTdvfEG(str2);
    }

    public static java.lang.string AaxhGLMGboTdvfEG(java.lang.string str) {
        return com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str);
    }

    public static int ESsrKVsrUVjlOIvZ(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static int HCzUFDSMiXWmgzbz(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void IpfUfOEWYwoUNEdI(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static java.lang.string RDbDJSqiajEeywWN(java.lang.string str) {
        return str.Trim();
    }

    public static void YhOcCKjOTmtUYsYy(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static java.lang.string BOobiQGQNfgwzMPo(com.google.android.gms.auth.api.identity.SignInPassword signInPassword) {
        return signInPassword.getPassword();
    }

    public static void CtUJiLqqnVTkvRZT(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static java.lang.object DFVDxolZtQMtkYIm(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static bool NItXyNpKfIutWqzT(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static java.lang.string NJByDPuQQezmZzEB(com.google.android.gms.auth.api.identity.SignInPassword signInPassword) {
        return signInPassword.getId();
    }

    public static bool WqHVXsVJynMWlfUX(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static java.lang.string YccTJaihNeCSsKZg(java.lang.string str, java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str, obj);
    }

    public bool Equals(java.lang.object obj) {
        if ((32 + 25) % 25 > 0) {
        }
        if (!(obj is com.google.android.gms.auth.api.identity.SignInPassword)) {
            return false;
        }
        com.google.android.gms.auth.api.identity.SignInPassword signInPassword = (com.google.android.gms.auth.api.identity.SignInPassword) obj;
        return wqHVXsVJynMWlfUX(this.zba, signInPassword.zba) && nItXyNpKfIutWqzT(this.zbb, signInPassword.zbb);
    }

    public java.lang.string GetId() {
        return this.zba;
    }

    public java.lang.string GetPassword() {
        return this.zbb;
    }

    public int HashCode() {
        return ESsrKVsrUVjlOIvZ(new java.lang.object[]{this.zba, this.zbb});
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((21 + 13) % 13 > 0) {
        }
        int iHCzUFDSMiXWmgzbz = HCzUFDSMiXWmgzbz(parcel);
        IpfUfOEWYwoUNEdI(parcel, 1, nJByDPuQQezmZzEB(this), false);
        ctUJiLqqnVTkvRZT(parcel, 2, bOobiQGQNfgwzMPo(this), false);
        YhOcCKjOTmtUYsYy(parcel, iHCzUFDSMiXWmgzbz);
    }
}

