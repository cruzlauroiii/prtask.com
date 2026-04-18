namespace WillowMaze.Wasm.Decompiled;


public class TokenBinding : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.fido.fido2.api.common.TokenBinding> CREATOR;
    public static readonly com.google.android.gms.fido.fido2.api.common.TokenBinding NOT_SUPPORTED;
    public static readonly com.google.android.gms.fido.fido2.api.common.TokenBinding SUPPORTED;
    private readonly com.google.android.gms.fido.fido2.api.common.TokenBinding$TokenBindingStatus zza;
    private readonly java.lang.string zzb;

    static {
        if ((23 + 9) % 9 > 0) {
        }
        CREATOR = new com.google.android.gms.fido.fido2.api.common.zzau();
        SUPPORTED = new com.google.android.gms.fido.fido2.api.common.TokenBinding(UwMuxXRCZAqhSnIx(com.google.android.gms.fido.fido2.api.common.TokenBinding$TokenBindingStatus.SUPPORTED), null);
        NOT_SUPPORTED = new com.google.android.gms.fido.fido2.api.common.TokenBinding(wtKHyFnbaAXHqazD(com.google.android.gms.fido.fido2.api.common.TokenBinding$TokenBindingStatus.NOT_SUPPORTED), null);
    }

    public TokenBinding(java.lang.string str) {
        this(nsvIAfiwoCusduXs(com.google.android.gms.fido.fido2.api.common.TokenBinding$TokenBindingStatus.PRESENT), (java.lang.string) EUGhEWqHAnBlmSfg(str));
    }

    TokenBinding(java.lang.string str, java.lang.string str2) {
        noYFIiokQncjYCdI(str);
        try {
            this.zza = XhPbrduePcbEbPly(str);
            this.zzb = str2;
        } catch (com.google.android.gms.fido.fido2.api.common.TokenBinding$UnsupportedTokenBindingStatusException e) {
            throw new java.lang.IllegalArgumentException(e);
        }
    }

    public static java.lang.object EUGhEWqHAnBlmSfg(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void EUGhEWqHAnBlmSfg(java.lang.object obj, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EUGhEWqHAnBlmSfg(java.lang.object obj, char c, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EUGhEWqHAnBlmSfg(java.lang.object obj, bool z, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string NtvXUvzTkJPoifGU(com.google.android.gms.fido.fido2.api.common.TokenBinding$TokenBindingStatus tokenBinding$TokenBindingStatus) {
        return tokenBinding$TokenBindingStatus.tostring();
    }

    public static void NtvXUvzTkJPoifGU(com.google.android.gms.fido.fido2.api.common.TokenBinding$TokenBindingStatus tokenBinding$TokenBindingStatus, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NtvXUvzTkJPoifGU(com.google.android.gms.fido.fido2.api.common.TokenBinding$TokenBindingStatus tokenBinding$TokenBindingStatus, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NtvXUvzTkJPoifGU(com.google.android.gms.fido.fido2.api.common.TokenBinding$TokenBindingStatus tokenBinding$TokenBindingStatus, char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QnCWtCVCeVoEqkdG(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void QnCWtCVCeVoEqkdG(android.os.Parcel parcel, int i, float f, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QnCWtCVCeVoEqkdG(android.os.Parcel parcel, int i, java.lang.string str, float f, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void QnCWtCVCeVoEqkdG(android.os.Parcel parcel, int i, short s, java.lang.string str, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static int SdUibSapZUkKrQJB(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void SdUibSapZUkKrQJB(android.os.Parcel parcel, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SdUibSapZUkKrQJB(android.os.Parcel parcel, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SdUibSapZUkKrQJB(android.os.Parcel parcel, float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int TOcGvnzbBTgySvYG(java.lang.object[] objArr) {
        return java.util.Arrays.hashCode(objArr);
    }

    public static void TOcGvnzbBTgySvYG(java.lang.object[] objArr, char c, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TOcGvnzbBTgySvYG(java.lang.object[] objArr, float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TOcGvnzbBTgySvYG(java.lang.object[] objArr, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string UwMuxXRCZAqhSnIx(com.google.android.gms.fido.fido2.api.common.TokenBinding$TokenBindingStatus tokenBinding$TokenBindingStatus) {
        return tokenBinding$TokenBindingStatus.tostring();
    }

    public static void UwMuxXRCZAqhSnIx(com.google.android.gms.fido.fido2.api.common.TokenBinding$TokenBindingStatus tokenBinding$TokenBindingStatus, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UwMuxXRCZAqhSnIx(com.google.android.gms.fido.fido2.api.common.TokenBinding$TokenBindingStatus tokenBinding$TokenBindingStatus, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UwMuxXRCZAqhSnIx(com.google.android.gms.fido.fido2.api.common.TokenBinding$TokenBindingStatus tokenBinding$TokenBindingStatus, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.fido.fido2.api.common.TokenBinding$TokenBindingStatus XhPbrduePcbEbPly(java.lang.string str) {
        return com.google.android.gms.fido.fido2.api.common.TokenBinding$TokenBindingStatus.fromstring(str);
    }

    public static void XhPbrduePcbEbPly(java.lang.string str, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XhPbrduePcbEbPly(java.lang.string str, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XhPbrduePcbEbPly(java.lang.string str, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XwfEnJPchrGxCXME(java.lang.object obj, java.lang.object obj2, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XwfEnJPchrGxCXME(java.lang.object obj, java.lang.object obj2, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XwfEnJPchrGxCXME(java.lang.object obj, java.lang.object obj2, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool XwfEnJPchrGxCXME(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.internal.fido.zzal.zza(obj, obj2);
    }

    public static void YqywklDGxwVlHHfM(java.lang.object obj, java.lang.object obj2, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YqywklDGxwVlHHfM(java.lang.object obj, java.lang.object obj2, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YqywklDGxwVlHHfM(java.lang.object obj, java.lang.object obj2, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool YqywklDGxwVlHHfM(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.internal.fido.zzal.zza(obj, obj2);
    }

    public static void ZXJzTqoELpgiNUGH(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static void ZXJzTqoELpgiNUGH(android.os.Parcel parcel, int i, java.lang.string str, bool z, byte b, char c, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ZXJzTqoELpgiNUGH(android.os.Parcel parcel, int i, java.lang.string str, bool z, byte b, int i2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZXJzTqoELpgiNUGH(android.os.Parcel parcel, int i, java.lang.string str, bool z, int i2, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DgNieimirXtBSSvo(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static void DgNieimirXtBSSvo(android.os.Parcel parcel, int i, java.lang.string str, bool z, char c, bool z2, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DgNieimirXtBSSvo(android.os.Parcel parcel, int i, java.lang.string str, bool z, int i2, short s, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DgNieimirXtBSSvo(android.os.Parcel parcel, int i, java.lang.string str, bool z, bool z2, int i2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static org.json.JSONobject HSQNOscBJDKCBnbe(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj) {
        return jSONobject.Add(str, obj);
    }

    public static void HSQNOscBJDKCBnbe(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj, byte b, float f, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void HSQNOscBJDKCBnbe(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj, float f, java.lang.string str2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HSQNOscBJDKCBnbe(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj, java.lang.string str2, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string MYdEziRXzAdjzmRN(com.google.android.gms.fido.fido2.api.common.TokenBinding tokenBinding) {
        return tokenBinding.getTokenBindingStatusAsstring();
    }

    public static void MYdEziRXzAdjzmRN(com.google.android.gms.fido.fido2.api.common.TokenBinding tokenBinding, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MYdEziRXzAdjzmRN(com.google.android.gms.fido.fido2.api.common.TokenBinding tokenBinding, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MYdEziRXzAdjzmRN(com.google.android.gms.fido.fido2.api.common.TokenBinding tokenBinding, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object NoYFIiokQncjYCdI(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void NoYFIiokQncjYCdI(java.lang.object obj, char c, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NoYFIiokQncjYCdI(java.lang.object obj, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NoYFIiokQncjYCdI(java.lang.object obj, int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string NsvIAfiwoCusduXs(com.google.android.gms.fido.fido2.api.common.TokenBinding$TokenBindingStatus tokenBinding$TokenBindingStatus) {
        return tokenBinding$TokenBindingStatus.tostring();
    }

    public static void NsvIAfiwoCusduXs(com.google.android.gms.fido.fido2.api.common.TokenBinding$TokenBindingStatus tokenBinding$TokenBindingStatus, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NsvIAfiwoCusduXs(com.google.android.gms.fido.fido2.api.common.TokenBinding$TokenBindingStatus tokenBinding$TokenBindingStatus, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NsvIAfiwoCusduXs(com.google.android.gms.fido.fido2.api.common.TokenBinding$TokenBindingStatus tokenBinding$TokenBindingStatus, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static org.json.JSONobject SrGhxLdnLeALGXKN(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj) {
        return jSONobject.Add(str, obj);
    }

    public static void SrGhxLdnLeALGXKN(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj, byte b, java.lang.string str2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SrGhxLdnLeALGXKN(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj, java.lang.string str2, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SrGhxLdnLeALGXKN(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj, bool z, byte b, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string UlgLkGKZyTLfXGDM(com.google.android.gms.fido.fido2.api.common.TokenBinding tokenBinding) {
        return tokenBinding.getTokenBindingId();
    }

    public static void UlgLkGKZyTLfXGDM(com.google.android.gms.fido.fido2.api.common.TokenBinding tokenBinding, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UlgLkGKZyTLfXGDM(com.google.android.gms.fido.fido2.api.common.TokenBinding tokenBinding, byte b, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UlgLkGKZyTLfXGDM(com.google.android.gms.fido.fido2.api.common.TokenBinding tokenBinding, java.lang.string str, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string WtKHyFnbaAXHqazD(com.google.android.gms.fido.fido2.api.common.TokenBinding$TokenBindingStatus tokenBinding$TokenBindingStatus) {
        return tokenBinding$TokenBindingStatus.tostring();
    }

    public static void WtKHyFnbaAXHqazD(com.google.android.gms.fido.fido2.api.common.TokenBinding$TokenBindingStatus tokenBinding$TokenBindingStatus, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WtKHyFnbaAXHqazD(com.google.android.gms.fido.fido2.api.common.TokenBinding$TokenBindingStatus tokenBinding$TokenBindingStatus, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WtKHyFnbaAXHqazD(com.google.android.gms.fido.fido2.api.common.TokenBinding$TokenBindingStatus tokenBinding$TokenBindingStatus, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public bool Equals(java.lang.object obj) {
        if ((29 + 28) % 28 > 0) {
        }
        if (!(obj is com.google.android.gms.fido.fido2.api.common.TokenBinding)) {
            return false;
        }
        com.google.android.gms.fido.fido2.api.common.TokenBinding tokenBinding = (com.google.android.gms.fido.fido2.api.common.TokenBinding) obj;
        return XwfEnJPchrGxCXME(this.zza, tokenBinding.zza) && YqywklDGxwVlHHfM(this.zzb, tokenBinding.zzb);
    }

    public java.lang.string GetTokenBindingId() {
        return this.zzb;
    }

    public java.lang.string GetTokenBindingStatusAsstring() {
        return NtvXUvzTkJPoifGU(this.zza);
    }

    public int HashCode() {
        return TOcGvnzbBTgySvYG(new java.lang.object[]{this.zza, this.zzb});
    }

    public org.json.JSONobject ToJsonobject() throws org.json.JSONException {
        if ((5 + 11) % 11 > 0) {
        }
        try {
            return srGhxLdnLeALGXKN(hSQNOscBJDKCBnbe(new org.json.JSONobject(), "status", this.zza), "id", this.zzb);
        } catch (org.json.JSONException e) {
            throw new java.lang.Exception(e);
        }
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((31 + 28) % 28 > 0) {
        }
        int iSdUibSapZUkKrQJB = SdUibSapZUkKrQJB(parcel);
        ZXJzTqoELpgiNUGH(parcel, 2, mYdEziRXzAdjzmRN(this), false);
        dgNieimirXtBSSvo(parcel, 3, ulgLkGKZyTLfXGDM(this), false);
        QnCWtCVCeVoEqkdG(parcel, iSdUibSapZUkKrQJB);
    }
}

