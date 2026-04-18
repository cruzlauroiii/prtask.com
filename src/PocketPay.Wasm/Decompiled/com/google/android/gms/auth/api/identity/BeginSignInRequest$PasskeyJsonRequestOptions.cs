namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public readonly class BeginSignInRequest$PasskeyJsonRequestOptions : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeyJsonRequestOptions> CREATOR = new com.google.android.gms.auth.api.identity.zbk();
    private readonly bool zba;
    private readonly java.lang.string zbb;

    BeginSignInRequest$PasskeyJsonRequestOptions(bool z, java.lang.string str) {
        if (z) {
            ibwSRDQiSXPcwdVm(str);
        }
        this.zba = z;
        this.zbb = str;
    }

    public static bool KkPseUPEFEZUhSiH(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static java.lang.string MfttoGbruVPNiFXZ(com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeyJsonRequestOptions beginSignInRequest$PasskeyJsonRequestOptions) {
        return beginSignInRequest$PasskeyJsonRequestOptions.getRequestJson();
    }

    public static void PlGtHCsSwbfKtIlV(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void TWzknYBiKsOKLROD(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeyJsonRequestOptions$Builder builder() {
        return new com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeyJsonRequestOptions$Builder();
    }

    public static void FEPNfUFEGkYLdSye(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static java.lang.object IbwSRDQiSXPcwdVm(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static int LzNhowSkSxdACbWW(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static bool PHwcgVvpXTazqyOu(com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeyJsonRequestOptions beginSignInRequest$PasskeyJsonRequestOptions) {
        return beginSignInRequest$PasskeyJsonRequestOptions.isSupported();
    }

    public static int SVoUXHMjXXncunAA(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static java.lang.bool XqHdrUIWiilmmdSM(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public bool Equals(java.lang.object obj) {
        if ((23 + 21) % 21 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeyJsonRequestOptions)) {
            return false;
        }
        com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeyJsonRequestOptions beginSignInRequest$PasskeyJsonRequestOptions = (com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeyJsonRequestOptions) obj;
        return this.zba == beginSignInRequest$PasskeyJsonRequestOptions.zba && KkPseUPEFEZUhSiH(this.zbb, beginSignInRequest$PasskeyJsonRequestOptions.zbb);
    }

    public java.lang.string GetRequestJson() {
        return this.zbb;
    }

    public int HashCode() {
        return lzNhowSkSxdACbWW(new java.lang.object[]{xqHdrUIWiilmmdSM(this.zba), this.zbb});
    }

    public bool IsSupported() {
        return this.zba;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((27 + 17) % 17 > 0) {
        }
        int iSVoUXHMjXXncunAA = sVoUXHMjXXncunAA(parcel);
        TWzknYBiKsOKLROD(parcel, 1, pHwcgVvpXTazqyOu(this));
        fEPNfUFEGkYLdSye(parcel, 2, MfttoGbruVPNiFXZ(this), false);
        PlGtHCsSwbfKtIlV(parcel, iSVoUXHMjXXncunAA);
    }
}

