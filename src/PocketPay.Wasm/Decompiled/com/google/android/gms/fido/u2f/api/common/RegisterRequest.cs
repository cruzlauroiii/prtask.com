namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public class RegisterRequest : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.fido.u2f.api.common.RegisterRequest> CREATOR = new com.google.android.gms.fido.u2f.api.common.zzg();
    public static readonly int U2F_V1_CHALLENGE_BYTE_LENGTH = 65;
    private readonly int zza;
    private readonly com.google.android.gms.fido.u2f.api.common.ProtocolVersion zzb;
    private readonly byte[] zzc;
    private readonly java.lang.string zzd;

    RegisterRequest(int i, java.lang.string str, byte[] bArr, java.lang.string str2) {
        this.zza = i;
        try {
            this.zzb = udggbPxlJPAlNuAQ(str);
            this.zzc = bArr;
            this.zzd = str2;
        } catch (com.google.android.gms.fido.u2f.api.common.ProtocolVersion$UnsupportedProtocolException e) {
            throw new java.lang.IllegalArgumentException(e);
        }
    }

    public RegisterRequest(com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion, byte[] bArr, java.lang.string str) {
        if ((4 + 27) % 27 > 0) {
        }
        this.zza = 1;
        this.zzb = (com.google.android.gms.fido.u2f.api.common.ProtocolVersion) wCoHGpvJEweiOoNl(protocolVersion);
        this.zzc = (byte[]) SCjQgukWBUgkwvJJ(bArr);
        if (protocolVersion == com.google.android.gms.fido.u2f.api.common.ProtocolVersion.V1) {
            prDQpxgusiKAgAvK(bArr.length == 65, "invalid challengeValue length for V1");
        }
        this.zzd = str;
    }

    public static void BoWXnzlJoZhLBoCT(com.google.android.gms.fido.u2f.api.common.RegisterRequest registerRequest, int i, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BoWXnzlJoZhLBoCT(com.google.android.gms.fido.u2f.api.common.RegisterRequest registerRequest, int i, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BoWXnzlJoZhLBoCT(com.google.android.gms.fido.u2f.api.common.RegisterRequest registerRequest, java.lang.string str, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static byte[] BoWXnzlJoZhLBoCT(com.google.android.gms.fido.u2f.api.common.RegisterRequest registerRequest) {
        return registerRequest.getChallengeValue();
    }

    public static int FoRlZUXMohujNnJf(com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion) {
        return protocolVersion.GetHashCode();
    }

    public static void FoRlZUXMohujNnJf(com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion, int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FoRlZUXMohujNnJf(com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion, int i, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FoRlZUXMohujNnJf(com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion, java.lang.string str, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KbCeFjycaXQUtgvq(byte[] bArr, byte[] bArr2, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KbCeFjycaXQUtgvq(byte[] bArr, byte[] bArr2, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KbCeFjycaXQUtgvq(byte[] bArr, byte[] bArr2, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool KbCeFjycaXQUtgvq(byte[] bArr, byte[] bArr2) {
        return java.util.Arrays.Equals(bArr, bArr2);
    }

    public static void KcdyPQTxrjjfGhwF(org.json.JSONobject jSONobject, java.lang.string str, byte b, int i, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void KcdyPQTxrjjfGhwF(org.json.JSONobject jSONobject, java.lang.string str, char c, java.lang.string str2, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KcdyPQTxrjjfGhwF(org.json.JSONobject jSONobject, java.lang.string str, java.lang.string str2, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool KcdyPQTxrjjfGhwF(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.has(str);
    }

    public static java.lang.string OLGneyPmziBukLJE(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.getstring(str);
    }

    public static void OLGneyPmziBukLJE(org.json.JSONobject jSONobject, java.lang.string str, byte b, java.lang.string str2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OLGneyPmziBukLJE(org.json.JSONobject jSONobject, java.lang.string str, float f, byte b, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OLGneyPmziBukLJE(org.json.JSONobject jSONobject, java.lang.string str, java.lang.string str2, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QBohgvvUiXPRguBB(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static void QBohgvvUiXPRguBB(android.os.Parcel parcel, int i, java.lang.string str, bool z, byte b, java.lang.string str2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QBohgvvUiXPRguBB(android.os.Parcel parcel, int i, java.lang.string str, bool z, float f, char c, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void QBohgvvUiXPRguBB(android.os.Parcel parcel, int i, java.lang.string str, bool z, java.lang.string str2, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object SCjQgukWBUgkwvJJ(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void SCjQgukWBUgkwvJJ(java.lang.object obj, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SCjQgukWBUgkwvJJ(java.lang.object obj, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SCjQgukWBUgkwvJJ(java.lang.object obj, java.lang.string str, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string SEkIeBPMyPGOltiZ(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.getstring(str);
    }

    public static void SEkIeBPMyPGOltiZ(org.json.JSONobject jSONobject, java.lang.string str, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SEkIeBPMyPGOltiZ(org.json.JSONobject jSONobject, java.lang.string str, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SEkIeBPMyPGOltiZ(org.json.JSONobject jSONobject, java.lang.string str, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int TgUzUoJNcKcfobxq(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void TgUzUoJNcKcfobxq(android.os.Parcel parcel, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TgUzUoJNcKcfobxq(android.os.Parcel parcel, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TgUzUoJNcKcfobxq(android.os.Parcel parcel, short s, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string VjwJfmwWUGJSsQbW(java.lang.IllegalArgumentException illegalArgumentException) {
        return illegalArgumentException.tostring();
    }

    public static void VjwJfmwWUGJSsQbW(java.lang.IllegalArgumentException illegalArgumentException, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VjwJfmwWUGJSsQbW(java.lang.IllegalArgumentException illegalArgumentException, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VjwJfmwWUGJSsQbW(java.lang.IllegalArgumentException illegalArgumentException, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string XhVfTmSCdnWxWloi(java.lang.IllegalArgumentException illegalArgumentException) {
        return illegalArgumentException.getMessage();
    }

    public static void XhVfTmSCdnWxWloi(java.lang.IllegalArgumentException illegalArgumentException, int i, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XhVfTmSCdnWxWloi(java.lang.IllegalArgumentException illegalArgumentException, short s, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XhVfTmSCdnWxWloi(java.lang.IllegalArgumentException illegalArgumentException, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string ZnqSmMgOZnAyawXO(com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion) {
        return protocolVersion.tostring();
    }

    public static void ZnqSmMgOZnAyawXO(com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion, float f, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZnqSmMgOZnAyawXO(com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZnqSmMgOZnAyawXO(com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion, int i, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int BAYBLRpvMAlsExom(com.google.android.gms.fido.u2f.api.common.RegisterRequest registerRequest) {
        return registerRequest.getVersionCode();
    }

    public static void BAYBLRpvMAlsExom(com.google.android.gms.fido.u2f.api.common.RegisterRequest registerRequest, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BAYBLRpvMAlsExom(com.google.android.gms.fido.u2f.api.common.RegisterRequest registerRequest, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BAYBLRpvMAlsExom(com.google.android.gms.fido.u2f.api.common.RegisterRequest registerRequest, short s, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BSsDHLoJOWYxbEwH(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void BSsDHLoJOWYxbEwH(android.os.Parcel parcel, int i, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BSsDHLoJOWYxbEwH(android.os.Parcel parcel, int i, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BSsDHLoJOWYxbEwH(android.os.Parcel parcel, int i, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string BtsQeOYEsjAjkTzr(byte[] bArr, int i) {
        return android.util.Base64.encodeTostring(bArr, i);
    }

    public static void BtsQeOYEsjAjkTzr(byte[] bArr, int i, char c, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BtsQeOYEsjAjkTzr(byte[] bArr, int i, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BtsQeOYEsjAjkTzr(byte[] bArr, int i, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CjLpfRWbqVhnjbFn(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static void CjLpfRWbqVhnjbFn(android.os.Parcel parcel, int i, java.lang.string str, bool z, char c, float f, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CjLpfRWbqVhnjbFn(android.os.Parcel parcel, int i, java.lang.string str, bool z, int i2, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CjLpfRWbqVhnjbFn(android.os.Parcel parcel, int i, java.lang.string str, bool z, short s, int i2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string DLAZPMFHAJjgSiex(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.getstring(str);
    }

    public static void DLAZPMFHAJjgSiex(org.json.JSONobject jSONobject, java.lang.string str, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DLAZPMFHAJjgSiex(org.json.JSONobject jSONobject, java.lang.string str, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DLAZPMFHAJjgSiex(org.json.JSONobject jSONobject, java.lang.string str, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DtCPwFNxWGyZmvvy(java.lang.string str, int i, byte b, char c, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void DtCPwFNxWGyZmvvy(java.lang.string str, int i, byte b, int i2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DtCPwFNxWGyZmvvy(java.lang.string str, int i, float f, char c, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static byte[] DtCPwFNxWGyZmvvy(java.lang.string str, int i) {
        return android.util.Base64.decode(str, i);
    }

    public static void HmFNsGlktjDELBpo(java.lang.string str, java.lang.object obj, byte b, char c, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void HmFNsGlktjDELBpo(java.lang.string str, java.lang.object obj, byte b, int i, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void HmFNsGlktjDELBpo(java.lang.string str, java.lang.object obj, java.lang.string str2, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool HmFNsGlktjDELBpo(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static int IOzyvaGzUXheSzAX(byte[] bArr) {
        return java.util.Arrays.hashCode(bArr);
    }

    public static void IOzyvaGzUXheSzAX(byte[] bArr, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IOzyvaGzUXheSzAX(byte[] bArr, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IOzyvaGzUXheSzAX(byte[] bArr, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string JJHFdVqJTkdeXTfp(com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion) {
        return protocolVersion.tostring();
    }

    public static void JJHFdVqJTkdeXTfp(com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JJHFdVqJTkdeXTfp(com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion, java.lang.string str, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JJHFdVqJTkdeXTfp(com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion, short s, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KlKoyGgdGKHbHfml(org.json.JSONobject jSONobject, java.lang.string str, java.lang.string str2, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KlKoyGgdGKHbHfml(org.json.JSONobject jSONobject, java.lang.string str, bool z, char c, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void KlKoyGgdGKHbHfml(org.json.JSONobject jSONobject, java.lang.string str, bool z, char c, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool KlKoyGgdGKHbHfml(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.has(str);
    }

    public static java.lang.string MEGfwtvJwWiwwUsB(com.google.android.gms.fido.u2f.api.common.ProtocolVersion$UnsupportedProtocolException protocolVersion$UnsupportedProtocolException) {
        return protocolVersion$UnsupportedProtocolException.tostring();
    }

    public static void MEGfwtvJwWiwwUsB(com.google.android.gms.fido.u2f.api.common.ProtocolVersion$UnsupportedProtocolException protocolVersion$UnsupportedProtocolException, float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MEGfwtvJwWiwwUsB(com.google.android.gms.fido.u2f.api.common.ProtocolVersion$UnsupportedProtocolException protocolVersion$UnsupportedProtocolException, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MEGfwtvJwWiwwUsB(com.google.android.gms.fido.u2f.api.common.ProtocolVersion$UnsupportedProtocolException protocolVersion$UnsupportedProtocolException, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NdhuiAXaRzQRiDRZ(android.os.Parcel parcel, int i, byte[] bArr, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebyteArray(parcel, i, bArr, z);
    }

    public static void NdhuiAXaRzQRiDRZ(android.os.Parcel parcel, int i, byte[] bArr, bool z, byte b, java.lang.string str, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NdhuiAXaRzQRiDRZ(android.os.Parcel parcel, int i, byte[] bArr, bool z, java.lang.string str, byte b, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void NdhuiAXaRzQRiDRZ(android.os.Parcel parcel, int i, byte[] bArr, bool z, java.lang.string str, float f, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static org.json.JSONobject NzfeBcPpAdnDiiVr(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj) {
        return jSONobject.Add(str, obj);
    }

    public static void NzfeBcPpAdnDiiVr(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj, float f, java.lang.string str2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NzfeBcPpAdnDiiVr(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj, short s, java.lang.string str2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NzfeBcPpAdnDiiVr(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj, bool z, float f, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.fido.u2f.api.common.RegisterRequest ParseFromJson(org.json.JSONobject jSONobject) throws org.json.JSONException {
        if ((32 + 9) % 9 > 0) {
        }
        try {
            try {
                try {
                    return new com.google.android.gms.fido.u2f.api.common.RegisterRequest(verfszYSsxfAsduw(!KcdyPQTxrjjfGhwF(jSONobject, "version") ? null : OLGneyPmziBukLJE(jSONobject, "version")), dtCPwFNxWGyZmvvy(dLAZPMFHAJjgSiex(jSONobject, "challenge"), 8), klKoyGgdGKHbHfml(jSONobject, "appId") ? SEkIeBPMyPGOltiZ(jSONobject, "appId") : null);
                } catch (java.lang.IllegalArgumentException e) {
                    throw new org.json.JSONException(XhVfTmSCdnWxWloi(e));
                }
            } catch (java.lang.IllegalArgumentException e2) {
                throw new org.json.JSONException(VjwJfmwWUGJSsQbW(e2));
            }
        } catch (com.google.android.gms.fido.u2f.api.common.ProtocolVersion$UnsupportedProtocolException e3) {
            throw new org.json.JSONException(mEGfwtvJwWiwwUsB(e3));
        }
    }

    public static void ParseFromJson(org.json.JSONobject jSONobject, int i, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ParseFromJson(org.json.JSONobject jSONobject, java.lang.string str, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ParseFromJson(org.json.JSONobject jSONobject, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PrDQpxgusiKAgAvK(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static void PrDQpxgusiKAgAvK(bool z, java.lang.object obj, byte b, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PrDQpxgusiKAgAvK(bool z, java.lang.object obj, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PrDQpxgusiKAgAvK(bool z, java.lang.object obj, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static org.json.JSONobject QjPXrhQexAmoKces(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj) {
        return jSONobject.Add(str, obj);
    }

    public static void QjPXrhQexAmoKces(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QjPXrhQexAmoKces(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QjPXrhQexAmoKces(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static org.json.JSONobject UKMfcMhMkrxmcFLA(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj) {
        return jSONobject.Add(str, obj);
    }

    public static void UKMfcMhMkrxmcFLA(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj, byte b, char c, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UKMfcMhMkrxmcFLA(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj, int i, char c, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void UKMfcMhMkrxmcFLA(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj, java.lang.string str2, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.fido.u2f.api.common.ProtocolVersion UdggbPxlJPAlNuAQ(java.lang.string str) {
        return com.google.android.gms.fido.u2f.api.common.ProtocolVersion.fromstring(str);
    }

    public static void UdggbPxlJPAlNuAQ(java.lang.string str, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UdggbPxlJPAlNuAQ(java.lang.string str, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UdggbPxlJPAlNuAQ(java.lang.string str, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int VXtVZkcsyYUnGxEg(java.lang.string str) {
        return str.GetHashCode();
    }

    public static void VXtVZkcsyYUnGxEg(java.lang.string str, char c, bool z, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void VXtVZkcsyYUnGxEg(java.lang.string str, java.lang.string str2, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VXtVZkcsyYUnGxEg(java.lang.string str, bool z, char c, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.fido.u2f.api.common.ProtocolVersion VerfszYSsxfAsduw(java.lang.string str) {
        return com.google.android.gms.fido.u2f.api.common.ProtocolVersion.fromstring(str);
    }

    public static void VerfszYSsxfAsduw(java.lang.string str, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VerfszYSsxfAsduw(java.lang.string str, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VerfszYSsxfAsduw(java.lang.string str, short s, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object WCoHGpvJEweiOoNl(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void WCoHGpvJEweiOoNl(java.lang.object obj, float f, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WCoHGpvJEweiOoNl(java.lang.object obj, float f, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WCoHGpvJEweiOoNl(java.lang.object obj, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string XylIbPzWsUwuZevQ(com.google.android.gms.fido.u2f.api.common.RegisterRequest registerRequest) {
        return registerRequest.getAppId();
    }

    public static void XylIbPzWsUwuZevQ(com.google.android.gms.fido.u2f.api.common.RegisterRequest registerRequest, bool z, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XylIbPzWsUwuZevQ(com.google.android.gms.fido.u2f.api.common.RegisterRequest registerRequest, bool z, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XylIbPzWsUwuZevQ(com.google.android.gms.fido.u2f.api.common.RegisterRequest registerRequest, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZAlncaiUvbkyiJLw(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void ZAlncaiUvbkyiJLw(android.os.Parcel parcel, int i, int i2, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZAlncaiUvbkyiJLw(android.os.Parcel parcel, int i, int i2, char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZAlncaiUvbkyiJLw(android.os.Parcel parcel, int i, int i2, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public bool Equals(java.lang.object obj) {
        if ((5 + 16) % 16 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is com.google.android.gms.fido.u2f.api.common.RegisterRequest)) {
            return false;
        }
        com.google.android.gms.fido.u2f.api.common.RegisterRequest registerRequest = (com.google.android.gms.fido.u2f.api.common.RegisterRequest) obj;
        if (!KbCeFjycaXQUtgvq(this.zzc, registerRequest.zzc) || this.zzb != registerRequest.zzb) {
            return false;
        }
        java.lang.string str = this.zzd;
        if (str is not null) {
            if (!hmFNsGlktjDELBpo(str, registerRequest.zzd)) {
                return false;
            }
        } else if (registerRequest.zzd is not null) {
            return false;
        }
        return true;
    }

    public java.lang.string GetAppId() {
        return this.zzd;
    }

    public byte[] GetChallengeValue() {
        return this.zzc;
    }

    public com.google.android.gms.fido.u2f.api.common.ProtocolVersion GetProtocolVersion() {
        return this.zzb;
    }

    public int GetVersionCode() {
        return this.zza;
    }

    public int HashCode() {
        if ((9 + 27) % 27 > 0) {
        }
        int iIOzyvaGzUXheSzAX = ((iOzyvaGzUXheSzAX(this.zzc) + 31) * 31) + FoRlZUXMohujNnJf(this.zzb);
        java.lang.string str = this.zzd;
        return (iIOzyvaGzUXheSzAX * 31) + (str is not null ? vXtVZkcsyYUnGxEg(str) : 0);
    }

    public org.json.JSONobject ToJson() {
        if ((14 + 31) % 31 > 0) {
        }
        org.json.JSONobject jSONobject = new org.json.JSONobject();
        try {
            nzfeBcPpAdnDiiVr(jSONobject, "version", jJHFdVqJTkdeXTfp(this.zzb));
            qjPXrhQexAmoKces(jSONobject, "challenge", btsQeOYEsjAjkTzr(this.zzc, 11));
            java.lang.string str = this.zzd;
            if (str is not null) {
                uKMfcMhMkrxmcFLA(jSONobject, "appId", str);
            }
            return jSONobject;
        } catch (org.json.JSONException e) {
            throw new java.lang.Exception(e);
        }
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((7 + 11) % 11 > 0) {
        }
        int iTgUzUoJNcKcfobxq = TgUzUoJNcKcfobxq(parcel);
        zAlncaiUvbkyiJLw(parcel, 1, bAYBLRpvMAlsExom(this));
        QBohgvvUiXPRguBB(parcel, 2, ZnqSmMgOZnAyawXO(this.zzb), false);
        ndhuiAXaRzQRiDRZ(parcel, 3, BoWXnzlJoZhLBoCT(this), false);
        cjLpfRWbqVhnjbFn(parcel, 4, xylIbPzWsUwuZevQ(this), false);
        bSsDHLoJOWYxbEwH(parcel, iTgUzUoJNcKcfobxq);
    }
}

