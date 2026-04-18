namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public class KeyHandle : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.fido.u2f.api.common.KeyHandle> CREATOR = new com.google.android.gms.fido.u2f.api.common.zze();
    private readonly int zza;
    private readonly byte[] zzb;
    private readonly com.google.android.gms.fido.u2f.api.common.ProtocolVersion zzc;
    private readonly java.util.List zzd;

    KeyHandle(int i, byte[] bArr, java.lang.string str, java.util.List list) {
        this.zza = i;
        this.zzb = bArr;
        try {
            this.zzc = aRATQaZdXKxQyWcw(str);
            this.zzd = list;
        } catch (com.google.android.gms.fido.u2f.api.common.ProtocolVersion$UnsupportedProtocolException e) {
            throw new java.lang.IllegalArgumentException(e);
        }
    }

    public KeyHandle(byte[] bArr, com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion, java.util.List<com.google.android.gms.fido.common.Transport> list) {
        this.zza = 1;
        this.zzb = bArr;
        this.zzc = protocolVersion;
        this.zzd = list;
    }

    public static int CBFMgWQiYalgBSQM(com.google.android.gms.fido.u2f.api.common.KeyHandle keyHandle) {
        return keyHandle.getVersionCode();
    }

    public static void CBFMgWQiYalgBSQM(com.google.android.gms.fido.u2f.api.common.KeyHandle keyHandle, float f, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CBFMgWQiYalgBSQM(com.google.android.gms.fido.u2f.api.common.KeyHandle keyHandle, java.lang.string str, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CBFMgWQiYalgBSQM(com.google.android.gms.fido.u2f.api.common.KeyHandle keyHandle, bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string DRotYgzOPEjapDNE(java.lang.object obj) {
        return obj.tostring();
    }

    public static void DRotYgzOPEjapDNE(java.lang.object obj, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DRotYgzOPEjapDNE(java.lang.object obj, java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DRotYgzOPEjapDNE(java.lang.object obj, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string DWitqdNpWERaVXSs(byte[] bArr) {
        return com.google.android.gms.common.util.Base64Utils.encode(bArr);
    }

    public static void DWitqdNpWERaVXSs(byte[] bArr, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DWitqdNpWERaVXSs(byte[] bArr, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DWitqdNpWERaVXSs(byte[] bArr, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DXfQmJuRSMzKtsPu(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void DXfQmJuRSMzKtsPu(android.os.Parcel parcel, int i, byte b, int i2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DXfQmJuRSMzKtsPu(android.os.Parcel parcel, int i, float f, int i2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DXfQmJuRSMzKtsPu(android.os.Parcel parcel, int i, int i2, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string GqayQwZHseehhRsQ(com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion) {
        return protocolVersion.tostring();
    }

    public static void GqayQwZHseehhRsQ(com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion, float f, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GqayQwZHseehhRsQ(com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion, int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GqayQwZHseehhRsQ(com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion, bool z, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static org.json.JSONobject GwUklodfPxbytUNn(com.google.android.gms.fido.u2f.api.common.KeyHandle keyHandle) {
        return keyHandle.zza();
    }

    public static void GwUklodfPxbytUNn(com.google.android.gms.fido.u2f.api.common.KeyHandle keyHandle, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GwUklodfPxbytUNn(com.google.android.gms.fido.u2f.api.common.KeyHandle keyHandle, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GwUklodfPxbytUNn(com.google.android.gms.fido.u2f.api.common.KeyHandle keyHandle, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator HMIJXHSEhzpOxkFv(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void HMIJXHSEhzpOxkFv(java.util.List list, java.lang.string str, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HMIJXHSEhzpOxkFv(java.util.List list, java.lang.string str, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HMIJXHSEhzpOxkFv(java.util.List list, bool z, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.fido.u2f.api.common.ProtocolVersion IHXHcJgDhQPpkRgf(java.lang.string str) {
        return com.google.android.gms.fido.u2f.api.common.ProtocolVersion.fromstring(str);
    }

    public static void IHXHcJgDhQPpkRgf(java.lang.string str, char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IHXHcJgDhQPpkRgf(java.lang.string str, char c, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IHXHcJgDhQPpkRgf(java.lang.string str, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JDhhiSYeqHRMeUQk(android.os.Parcel parcel, int i, java.util.List list, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeTypedList(parcel, i, list, z);
    }

    public static void JDhhiSYeqHRMeUQk(android.os.Parcel parcel, int i, java.util.List list, bool z, int i2, bool z2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JDhhiSYeqHRMeUQk(android.os.Parcel parcel, int i, java.util.List list, bool z, short s, int i2, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JDhhiSYeqHRMeUQk(android.os.Parcel parcel, int i, java.util.List list, bool z, bool z2, short s, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int JSyqjPJNTCunUDjY(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void JSyqjPJNTCunUDjY(android.os.Parcel parcel, byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JSyqjPJNTCunUDjY(android.os.Parcel parcel, float f, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JSyqjPJNTCunUDjY(android.os.Parcel parcel, int i, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string JkwoPGnzgKSUTZJU(java.lang.IllegalArgumentException illegalArgumentException) {
        return illegalArgumentException.tostring();
    }

    public static void JkwoPGnzgKSUTZJU(java.lang.IllegalArgumentException illegalArgumentException, java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JkwoPGnzgKSUTZJU(java.lang.IllegalArgumentException illegalArgumentException, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JkwoPGnzgKSUTZJU(java.lang.IllegalArgumentException illegalArgumentException, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JzwzgFuBDJYczyMo(com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion, java.lang.object obj, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JzwzgFuBDJYczyMo(com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion, java.lang.object obj, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JzwzgFuBDJYczyMo(com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion, java.lang.object obj, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool JzwzgFuBDJYczyMo(com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion, java.lang.object obj) {
        return protocolVersion.Equals(obj);
    }

    public static java.lang.string KGPYFfVlZzKPYbkv(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.getstring(str);
    }

    public static void KGPYFfVlZzKPYbkv(org.json.JSONobject jSONobject, java.lang.string str, char c, bool z, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KGPYFfVlZzKPYbkv(org.json.JSONobject jSONobject, java.lang.string str, float f, java.lang.string str2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KGPYFfVlZzKPYbkv(org.json.JSONobject jSONobject, java.lang.string str, java.lang.string str2, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List PTLzOUpGKWKwEtcq(org.json.System.Text.Json.JsonElement jSONArray) {
        return com.google.android.gms.fido.common.Transport.parseTransports(jSONArray);
    }

    public static void PTLzOUpGKWKwEtcq(org.json.System.Text.Json.JsonElement jSONArray, byte b, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PTLzOUpGKWKwEtcq(org.json.System.Text.Json.JsonElement jSONArray, float f, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PTLzOUpGKWKwEtcq(org.json.System.Text.Json.JsonElement jSONArray, java.lang.string str, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TePjfKzEGMJaxSDs(java.util.List list, java.util.ICollection collection, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TePjfKzEGMJaxSDs(java.util.List list, java.util.ICollection collection, char c, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TePjfKzEGMJaxSDs(java.util.List list, java.util.ICollection collection, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool TePjfKzEGMJaxSDs(java.util.List list, java.util.ICollection collection) {
        return list.containsAll(collection);
    }

    public static void UGtBHXWAoFeYWBre(byte[] bArr, byte[] bArr2, float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UGtBHXWAoFeYWBre(byte[] bArr, byte[] bArr2, float f, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UGtBHXWAoFeYWBre(byte[] bArr, byte[] bArr2, bool z, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool UGtBHXWAoFeYWBre(byte[] bArr, byte[] bArr2) {
        return java.util.Arrays.Equals(bArr, bArr2);
    }

    public static org.json.System.Text.Json.JsonElement VOSQQLDWCJgnaxqx(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.getSystem.Text.Json.JsonElement(str);
    }

    public static void VOSQQLDWCJgnaxqx(org.json.JSONobject jSONobject, java.lang.string str, float f, java.lang.string str2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VOSQQLDWCJgnaxqx(org.json.JSONobject jSONobject, java.lang.string str, java.lang.string str2, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VOSQQLDWCJgnaxqx(org.json.JSONobject jSONobject, java.lang.string str, short s, float f, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WcsukVagSxKnNKuz(org.json.JSONobject jSONobject, java.lang.string str, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WcsukVagSxKnNKuz(org.json.JSONobject jSONobject, java.lang.string str, char c, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WcsukVagSxKnNKuz(org.json.JSONobject jSONobject, java.lang.string str, char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool WcsukVagSxKnNKuz(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.has(str);
    }

    public static void XKOHAraAfCwKvrYn(org.json.JSONobject jSONobject, java.lang.string str, char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XKOHAraAfCwKvrYn(org.json.JSONobject jSONobject, java.lang.string str, char c, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XKOHAraAfCwKvrYn(org.json.JSONobject jSONobject, java.lang.string str, short s, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool XKOHAraAfCwKvrYn(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.has(str);
    }

    public static void XZbOIGtfYUnSkhcB(java.util.List list, java.util.ICollection collection, byte b, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XZbOIGtfYUnSkhcB(java.util.List list, java.util.ICollection collection, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XZbOIGtfYUnSkhcB(java.util.List list, java.util.ICollection collection, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool XZbOIGtfYUnSkhcB(java.util.List list, java.util.ICollection collection) {
        return list.containsAll(collection);
    }

    public static java.lang.string YNSUatNcUGmcJNWY(com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion) {
        return protocolVersion.tostring();
    }

    public static void YNSUatNcUGmcJNWY(com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YNSUatNcUGmcJNWY(com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YNSUatNcUGmcJNWY(com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static org.json.JSONobject YTbPWBGUMQwgERZA(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj) {
        return jSONobject.Add(str, obj);
    }

    public static void YTbPWBGUMQwgERZA(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj, byte b, int i, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void YTbPWBGUMQwgERZA(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj, java.lang.string str2, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YTbPWBGUMQwgERZA(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj, bool z, int i, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void YwpRIxHUCLjzjYQY(java.lang.string str, int i, char c, float f, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void YwpRIxHUCLjzjYQY(java.lang.string str, int i, java.lang.string str2, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YwpRIxHUCLjzjYQY(java.lang.string str, int i, bool z, float f, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static byte[] YwpRIxHUCLjzjYQY(java.lang.string str, int i) {
        return android.util.Base64.decode(str, i);
    }

    public static int ZBzfigrKDsnFfoDd(byte[] bArr) {
        return java.util.Arrays.hashCode(bArr);
    }

    public static void ZBzfigrKDsnFfoDd(byte[] bArr, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZBzfigrKDsnFfoDd(byte[] bArr, float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZBzfigrKDsnFfoDd(byte[] bArr, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string ZgutIinwcFmKPDGR(com.google.android.gms.fido.common.Transport transport) {
        return transport.tostring();
    }

    public static void ZgutIinwcFmKPDGR(com.google.android.gms.fido.common.Transport transport, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZgutIinwcFmKPDGR(com.google.android.gms.fido.common.Transport transport, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZgutIinwcFmKPDGR(com.google.android.gms.fido.common.Transport transport, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.fido.u2f.api.common.ProtocolVersion ARATQaZdXKxQyWcw(java.lang.string str) {
        return com.google.android.gms.fido.u2f.api.common.ProtocolVersion.fromstring(str);
    }

    public static void ARATQaZdXKxQyWcw(java.lang.string str, int i, java.lang.string str2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ARATQaZdXKxQyWcw(java.lang.string str, int i, bool z, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void ARATQaZdXKxQyWcw(java.lang.string str, java.lang.string str2, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AasbYxUxAcGBBUYD(java.util.IEnumerator it, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AasbYxUxAcGBBUYD(java.util.IEnumerator it, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AasbYxUxAcGBBUYD(java.util.IEnumerator it, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool AasbYxUxAcGBBUYD(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static org.json.System.Text.Json.JsonElement AvmNzfYfaazTOUdB(org.json.System.Text.Json.JsonElement jSONArray, java.lang.object obj) {
        return jSONArray.Add(obj);
    }

    public static void AvmNzfYfaazTOUdB(org.json.System.Text.Json.JsonElement jSONArray, java.lang.object obj, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AvmNzfYfaazTOUdB(org.json.System.Text.Json.JsonElement jSONArray, java.lang.object obj, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AvmNzfYfaazTOUdB(org.json.System.Text.Json.JsonElement jSONArray, java.lang.object obj, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object BcOgddFJnONSJNKk(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void BcOgddFJnONSJNKk(java.util.IEnumerator it, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BcOgddFJnONSJNKk(java.util.IEnumerator it, java.lang.string str, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BcOgddFJnONSJNKk(java.util.IEnumerator it, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string CJCVFqZHsWxUIBTI(com.google.android.gms.fido.u2f.api.common.ProtocolVersion$UnsupportedProtocolException protocolVersion$UnsupportedProtocolException) {
        return protocolVersion$UnsupportedProtocolException.tostring();
    }

    public static void CJCVFqZHsWxUIBTI(com.google.android.gms.fido.u2f.api.common.ProtocolVersion$UnsupportedProtocolException protocolVersion$UnsupportedProtocolException, java.lang.string str, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CJCVFqZHsWxUIBTI(com.google.android.gms.fido.u2f.api.common.ProtocolVersion$UnsupportedProtocolException protocolVersion$UnsupportedProtocolException, java.lang.string str, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CJCVFqZHsWxUIBTI(com.google.android.gms.fido.u2f.api.common.ProtocolVersion$UnsupportedProtocolException protocolVersion$UnsupportedProtocolException, short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List EFCGIFYqwznGINDk(com.google.android.gms.fido.u2f.api.common.KeyHandle keyHandle) {
        return keyHandle.getTransports();
    }

    public static void EFCGIFYqwznGINDk(com.google.android.gms.fido.u2f.api.common.KeyHandle keyHandle, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EFCGIFYqwznGINDk(com.google.android.gms.fido.u2f.api.common.KeyHandle keyHandle, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EFCGIFYqwznGINDk(com.google.android.gms.fido.u2f.api.common.KeyHandle keyHandle, short s, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static org.json.JSONobject EySjbVBxPAoIRJCG(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj) {
        return jSONobject.Add(str, obj);
    }

    public static void EySjbVBxPAoIRJCG(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj, char c, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EySjbVBxPAoIRJCG(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EySjbVBxPAoIRJCG(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj, short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int FVmlZiBnpkDxhSPa(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void FVmlZiBnpkDxhSPa(int i, byte b, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FVmlZiBnpkDxhSPa(int i, float f, short s, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FVmlZiBnpkDxhSPa(int i, float f, short s, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string GulzuamVsmfEWxeJ(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static void GulzuamVsmfEWxeJ(java.lang.string str, java.lang.object[] objArr, char c, java.lang.string str2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GulzuamVsmfEWxeJ(java.lang.string str, java.lang.object[] objArr, bool z, char c, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GulzuamVsmfEWxeJ(java.lang.string str, java.lang.object[] objArr, bool z, short s, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HKXRolaHXRFQBlSi(com.google.android.gms.fido.u2f.api.common.KeyHandle keyHandle, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HKXRolaHXRFQBlSi(com.google.android.gms.fido.u2f.api.common.KeyHandle keyHandle, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HKXRolaHXRFQBlSi(com.google.android.gms.fido.u2f.api.common.KeyHandle keyHandle, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static byte[] HKXRolaHXRFQBlSi(com.google.android.gms.fido.u2f.api.common.KeyHandle keyHandle) {
        return keyHandle.getbytes();
    }

    public static void JBweZxShOhWIAuVz(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void JBweZxShOhWIAuVz(android.os.Parcel parcel, int i, int i2, int i3, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JBweZxShOhWIAuVz(android.os.Parcel parcel, int i, int i2, short s, float f, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void JBweZxShOhWIAuVz(android.os.Parcel parcel, int i, int i2, bool z, int i3, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LEHdCbEkAGWMfjRA(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static void LEHdCbEkAGWMfjRA(android.os.Parcel parcel, int i, java.lang.string str, bool z, char c, int i2, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LEHdCbEkAGWMfjRA(android.os.Parcel parcel, int i, java.lang.string str, bool z, char c, bool z2, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LEHdCbEkAGWMfjRA(android.os.Parcel parcel, int i, java.lang.string str, bool z, short s, char c, bool z2, int i2) {
        double d = (42 * 210) + 210;
    }

    public static org.json.JSONobject MWaKIypXbqFdqAod(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj) {
        return jSONobject.Add(str, obj);
    }

    public static void MWaKIypXbqFdqAod(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj, byte b, float f, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MWaKIypXbqFdqAod(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj, byte b, java.lang.string str2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MWaKIypXbqFdqAod(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj, java.lang.string str2, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string MXlpggtYDchWuFkx(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.getstring(str);
    }

    public static void MXlpggtYDchWuFkx(org.json.JSONobject jSONobject, java.lang.string str, int i, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MXlpggtYDchWuFkx(org.json.JSONobject jSONobject, java.lang.string str, short s, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MXlpggtYDchWuFkx(org.json.JSONobject jSONobject, java.lang.string str, bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static int MiyOPFquISCfpRoi(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static void MiyOPFquISCfpRoi(java.lang.object[] objArr, byte b, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MiyOPFquISCfpRoi(java.lang.object[] objArr, int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MiyOPFquISCfpRoi(java.lang.object[] objArr, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OXwUXOEdxyEEqXni(android.os.Parcel parcel, int i, byte[] bArr, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebyteArray(parcel, i, bArr, z);
    }

    public static void OXwUXOEdxyEEqXni(android.os.Parcel parcel, int i, byte[] bArr, bool z, byte b, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OXwUXOEdxyEEqXni(android.os.Parcel parcel, int i, byte[] bArr, bool z, int i2, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OXwUXOEdxyEEqXni(android.os.Parcel parcel, int i, byte[] bArr, bool z, short s, byte b, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string PInPvlvoAClcyUAM(byte[] bArr, int i) {
        return android.util.Base64.encodeTostring(bArr, i);
    }

    public static void PInPvlvoAClcyUAM(byte[] bArr, int i, byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PInPvlvoAClcyUAM(byte[] bArr, int i, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PInPvlvoAClcyUAM(byte[] bArr, int i, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.fido.u2f.api.common.KeyHandle ParseFromJson(org.json.JSONobject jSONobject) throws org.json.JSONException {
        if ((24 + 2) % 2 > 0) {
        }
        try {
            try {
                return new com.google.android.gms.fido.u2f.api.common.KeyHandle(YwpRIxHUCLjzjYQY(KGPYFfVlZzKPYbkv(jSONobject, "keyHandle"), 8), IHXHcJgDhQPpkRgf(!WcsukVagSxKnNKuz(jSONobject, "version") ? null : mXlpggtYDchWuFkx(jSONobject, "version")), XKOHAraAfCwKvrYn(jSONobject, "transports") ? PTLzOUpGKWKwEtcq(VOSQQLDWCJgnaxqx(jSONobject, "transports")) : null);
            } catch (java.lang.IllegalArgumentException e) {
                throw new org.json.JSONException(JkwoPGnzgKSUTZJU(e));
            }
        } catch (com.google.android.gms.fido.u2f.api.common.ProtocolVersion$UnsupportedProtocolException e2) {
            throw new org.json.JSONException(cJCVFqZHsWxUIBTI(e2));
        }
    }

    public static void ParseFromJson(org.json.JSONobject jSONobject, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ParseFromJson(org.json.JSONobject jSONobject, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ParseFromJson(org.json.JSONobject jSONobject, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public bool Equals(java.lang.object obj) {
        java.util.List list;
        if ((8 + 23) % 23 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is com.google.android.gms.fido.u2f.api.common.KeyHandle)) {
            return false;
        }
        com.google.android.gms.fido.u2f.api.common.KeyHandle keyHandle = (com.google.android.gms.fido.u2f.api.common.KeyHandle) obj;
        if (!UGtBHXWAoFeYWBre(this.zzb, keyHandle.zzb) || !JzwzgFuBDJYczyMo(this.zzc, keyHandle.zzc)) {
            return false;
        }
        java.util.List list2 = this.zzd;
        if (list2 is null && keyHandle.zzd is null) {
            return true;
        }
        return list2 is not null && (list = keyHandle.zzd) is not null && TePjfKzEGMJaxSDs(list2, list) && XZbOIGtfYUnSkhcB(keyHandle.zzd, this.zzd);
    }

    public byte[] Getbytes() {
        return this.zzb;
    }

    public com.google.android.gms.fido.u2f.api.common.ProtocolVersion GetProtocolVersion() {
        return this.zzc;
    }

    public java.util.List<com.google.android.gms.fido.common.Transport> GetTransports() {
        return this.zzd;
    }

    public int GetVersionCode() {
        return this.zza;
    }

    public int HashCode() {
        if ((30 + 30) % 30 > 0) {
        }
        return miyOPFquISCfpRoi(new java.lang.object[]{fVmlZiBnpkDxhSPa(ZBzfigrKDsnFfoDd(this.zzb)), this.zzc, this.zzd});
    }

    public org.json.JSONobject ToJson() {
        return GwUklodfPxbytUNn(this);
    }

    public java.lang.string Tostring() {
        if ((24 + 5) % 5 > 0) {
        }
        java.util.List list = this.zzd;
        return gulzuamVsmfEWxeJ("{keyHandle: %s, version: %s, transports: %s}", new java.lang.object[]{DWitqdNpWERaVXSs(this.zzb), this.zzc, list is not null ? DRotYgzOPEjapDNE(list) : "null"});
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((4 + 16) % 16 > 0) {
        }
        int iJSyqjPJNTCunUDjY = JSyqjPJNTCunUDjY(parcel);
        jBweZxShOhWIAuVz(parcel, 1, CBFMgWQiYalgBSQM(this));
        oXwUXOEdxyEEqXni(parcel, 2, hKXRolaHXRFQBlSi(this), false);
        lEHdCbEkAGWMfjRA(parcel, 3, GqayQwZHseehhRsQ(this.zzc), false);
        JDhhiSYeqHRMeUQk(parcel, 4, eFCGIFYqwznGINDk(this), false);
        DXfQmJuRSMzKtsPu(parcel, iJSyqjPJNTCunUDjY);
    }

    public readonly org.json.JSONobject Zza() {
        if ((8 + 29) % 29 > 0) {
        }
        org.json.JSONobject jSONobject = new org.json.JSONobject();
        try {
            byte[] bArr = this.zzb;
            if (bArr is not null) {
                YTbPWBGUMQwgERZA(jSONobject, "keyHandle", pInPvlvoAClcyUAM(bArr, 11));
            }
            com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion = this.zzc;
            if (protocolVersion is not null) {
                mWaKIypXbqFdqAod(jSONobject, "version", YNSUatNcUGmcJNWY(protocolVersion));
            }
            if (this.zzd is not null) {
                org.json.System.Text.Json.JsonElement jSONArray = new org.json.System.Text.Json.JsonElement();
                java.util.IEnumerator itHMIJXHSEhzpOxkFv = HMIJXHSEhzpOxkFv(this.zzd);
                while (aasbYxUxAcGBBUYD(itHMIJXHSEhzpOxkFv)) {
                    avmNzfYfaazTOUdB(jSONArray, ZgutIinwcFmKPDGR((com.google.android.gms.fido.common.Transport) bcOgddFJnONSJNKk(itHMIJXHSEhzpOxkFv)));
                }
                eySjbVBxPAoIRJCG(jSONobject, "transports", jSONArray);
            }
            return jSONobject;
        } catch (org.json.JSONException e) {
            throw new java.lang.Exception(e);
        }
    }
}

