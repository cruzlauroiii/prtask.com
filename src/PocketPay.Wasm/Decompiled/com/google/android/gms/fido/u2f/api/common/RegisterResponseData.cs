namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public class RegisterResponseData : com.google.android.gms.fido.u2f.api.common.ResponseData {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.fido.u2f.api.common.RegisterResponseData> CREATOR = new com.google.android.gms.fido.u2f.api.common.zzi();
    private readonly byte[] zza;
    private readonly com.google.android.gms.fido.u2f.api.common.ProtocolVersion zzb;
    private readonly java.lang.string zzc;

    public RegisterResponseData(byte[] bArr) {
        this.zza = (byte[]) xxwWSaqfDQhABpYJ(bArr);
        this.zzb = com.google.android.gms.fido.u2f.api.common.ProtocolVersion.V1;
        this.zzc = null;
    }

    public RegisterResponseData(byte[] bArr, com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion, java.lang.string str) {
        if ((5 + 25) % 25 > 0) {
        }
        this.zza = (byte[]) wkUNypdIGWwuIPCG(bArr);
        this.zzb = (com.google.android.gms.fido.u2f.api.common.ProtocolVersion) RHwAdbdBUDuWvZIJ(protocolVersion);
        RCPYcSyoytZwYUZU(protocolVersion != com.google.android.gms.fido.u2f.api.common.ProtocolVersion.UNKNOWN);
        if (protocolVersion != com.google.android.gms.fido.u2f.api.common.ProtocolVersion.V1) {
            this.zzc = (java.lang.string) yxpfjZZItacOJeis(str);
        } else {
            IyukTUbDRnWSgFQW(str is null);
            this.zzc = null;
        }
    }

    RegisterResponseData(byte[] bArr, java.lang.string str, java.lang.string str2) {
        this.zza = bArr;
        try {
            this.zzb = eSOCooZLCNUAztev(str);
            this.zzc = str2;
        } catch (com.google.android.gms.fido.u2f.api.common.ProtocolVersion$UnsupportedProtocolException e) {
            throw new java.lang.IllegalArgumentException(e);
        }
    }

    public static void AEjBCjrFuwBtgtSt(byte[] bArr, byte[] bArr2, byte b, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AEjBCjrFuwBtgtSt(byte[] bArr, byte[] bArr2, char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AEjBCjrFuwBtgtSt(byte[] bArr, byte[] bArr2, int i, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool AEjBCjrFuwBtgtSt(byte[] bArr, byte[] bArr2) {
        return java.util.Arrays.Equals(bArr, bArr2);
    }

    public static org.json.JSONobject CqrEvsyDAXyKuITy(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj) {
        return jSONobject.Add(str, obj);
    }

    public static void CqrEvsyDAXyKuITy(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj, char c, int i, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void CqrEvsyDAXyKuITy(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj, char c, java.lang.string str2, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CqrEvsyDAXyKuITy(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj, java.lang.string str2, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.internal.fido.zzaj DKWmYTBzuiGJwORv(com.google.android.gms.internal.fido.zzaj zzajVar, java.lang.string str, java.lang.object obj) {
        return zzajVar.zzb(str, obj);
    }

    public static void DKWmYTBzuiGJwORv(com.google.android.gms.internal.fido.zzaj zzajVar, java.lang.string str, java.lang.object obj, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DKWmYTBzuiGJwORv(com.google.android.gms.internal.fido.zzaj zzajVar, java.lang.string str, java.lang.object obj, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DKWmYTBzuiGJwORv(com.google.android.gms.internal.fido.zzaj zzajVar, java.lang.string str, java.lang.object obj, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GRexVYGDyZsRkmmf(java.lang.object obj, java.lang.object obj2, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GRexVYGDyZsRkmmf(java.lang.object obj, java.lang.object obj2, bool z, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GRexVYGDyZsRkmmf(java.lang.object obj, java.lang.object obj2, bool z, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool GRexVYGDyZsRkmmf(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static int HAtVRiWvROpkrJqy(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void HAtVRiWvROpkrJqy(android.os.Parcel parcel, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HAtVRiWvROpkrJqy(android.os.Parcel parcel, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HAtVRiWvROpkrJqy(android.os.Parcel parcel, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IyukTUbDRnWSgFQW(bool z) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z);
    }

    public static void IyukTUbDRnWSgFQW(bool z, float f, int i, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void IyukTUbDRnWSgFQW(bool z, int i, short s, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IyukTUbDRnWSgFQW(bool z, short s, float f, bool z2, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string JHEkhuMEtXtxKlze(byte[] bArr, int i) {
        return android.util.Base64.encodeTostring(bArr, i);
    }

    public static void JHEkhuMEtXtxKlze(byte[] bArr, int i, byte b, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JHEkhuMEtXtxKlze(byte[] bArr, int i, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JHEkhuMEtXtxKlze(byte[] bArr, int i, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string KhMFTwDOtJpHqxTO(com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion) {
        return protocolVersion.tostring();
    }

    public static void KhMFTwDOtJpHqxTO(com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KhMFTwDOtJpHqxTO(com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KhMFTwDOtJpHqxTO(com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int KoTGsyCOjLUYTmVa(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void KoTGsyCOjLUYTmVa(int i, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KoTGsyCOjLUYTmVa(int i, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KoTGsyCOjLUYTmVa(int i, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int McHOZPKfRFJXqMyq(byte[] bArr) {
        return java.util.Arrays.hashCode(bArr);
    }

    public static void McHOZPKfRFJXqMyq(byte[] bArr, byte b, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void McHOZPKfRFJXqMyq(byte[] bArr, int i, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void McHOZPKfRFJXqMyq(byte[] bArr, int i, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.internal.fido.zzbf OdCWCNyiARBPBipE() {
        return com.google.android.gms.internal.fido.zzbf.zzd();
    }

    public static void OdCWCNyiARBPBipE(int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OdCWCNyiARBPBipE(short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OdCWCNyiARBPBipE(short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static org.json.JSONobject PGGghUVAtJgJKWHA(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj) {
        return jSONobject.Add(str, obj);
    }

    public static void PGGghUVAtJgJKWHA(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PGGghUVAtJgJKWHA(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PGGghUVAtJgJKWHA(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RCPYcSyoytZwYUZU(bool z) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z);
    }

    public static void RCPYcSyoytZwYUZU(bool z, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RCPYcSyoytZwYUZU(bool z, short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RCPYcSyoytZwYUZU(bool z, short s, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RHqcbrOVoQETAlsV(android.os.Parcel parcel, int i, byte[] bArr, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebyteArray(parcel, i, bArr, z);
    }

    public static void RHqcbrOVoQETAlsV(android.os.Parcel parcel, int i, byte[] bArr, bool z, java.lang.string str, char c, bool z2, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void RHqcbrOVoQETAlsV(android.os.Parcel parcel, int i, byte[] bArr, bool z, java.lang.string str, int i2, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void RHqcbrOVoQETAlsV(android.os.Parcel parcel, int i, byte[] bArr, bool z, java.lang.string str, bool z2, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object RHwAdbdBUDuWvZIJ(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void RHwAdbdBUDuWvZIJ(java.lang.object obj, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RHwAdbdBUDuWvZIJ(java.lang.object obj, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RHwAdbdBUDuWvZIJ(java.lang.object obj, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.internal.fido.zzaj VtloSPcKaCSTdJWN(com.google.android.gms.internal.fido.zzaj zzajVar, java.lang.string str, java.lang.object obj) {
        return zzajVar.zzb(str, obj);
    }

    public static void VtloSPcKaCSTdJWN(com.google.android.gms.internal.fido.zzaj zzajVar, java.lang.string str, java.lang.object obj, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VtloSPcKaCSTdJWN(com.google.android.gms.internal.fido.zzaj zzajVar, java.lang.string str, java.lang.object obj, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VtloSPcKaCSTdJWN(com.google.android.gms.internal.fido.zzaj zzajVar, java.lang.string str, java.lang.object obj, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string WbhGYMKOqYDDUjRZ(com.google.android.gms.internal.fido.zzbf zzbfVar, byte[] bArr, int i, int i2) {
        return zzbfVar.zze(bArr, i, i2);
    }

    public static void WbhGYMKOqYDDUjRZ(com.google.android.gms.internal.fido.zzbf zzbfVar, byte[] bArr, int i, int i2, int i3, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WbhGYMKOqYDDUjRZ(com.google.android.gms.internal.fido.zzbf zzbfVar, byte[] bArr, int i, int i2, int i3, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WbhGYMKOqYDDUjRZ(com.google.android.gms.internal.fido.zzbf zzbfVar, byte[] bArr, int i, int i2, java.lang.string str, int i3, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int ZXexDyhzjuJkzOEm(com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion) {
        return protocolVersion.ordinal();
    }

    public static void ZXexDyhzjuJkzOEm(com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion, float f, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZXexDyhzjuJkzOEm(com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZXexDyhzjuJkzOEm(com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion, bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AkVjPKVrFIHeVAAn(com.google.android.gms.fido.u2f.api.common.RegisterResponseData registerResponseData, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AkVjPKVrFIHeVAAn(com.google.android.gms.fido.u2f.api.common.RegisterResponseData registerResponseData, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AkVjPKVrFIHeVAAn(com.google.android.gms.fido.u2f.api.common.RegisterResponseData registerResponseData, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static byte[] AkVjPKVrFIHeVAAn(com.google.android.gms.fido.u2f.api.common.RegisterResponseData registerResponseData) {
        return registerResponseData.getRegisterData();
    }

    public static java.lang.string DZGOSDIoPjBmRyiA(byte[] bArr, int i) {
        return android.util.Base64.encodeTostring(bArr, i);
    }

    public static void DZGOSDIoPjBmRyiA(byte[] bArr, int i, char c, float f, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void DZGOSDIoPjBmRyiA(byte[] bArr, int i, int i2, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DZGOSDIoPjBmRyiA(byte[] bArr, int i, short s, float f, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.fido.u2f.api.common.ProtocolVersion ESOCooZLCNUAztev(java.lang.string str) {
        return com.google.android.gms.fido.u2f.api.common.ProtocolVersion.fromstring(str);
    }

    public static void ESOCooZLCNUAztev(java.lang.string str, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ESOCooZLCNUAztev(java.lang.string str, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ESOCooZLCNUAztev(java.lang.string str, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HvmoZUMqCsHMGFUr(java.lang.object obj, java.lang.object obj2, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HvmoZUMqCsHMGFUr(java.lang.object obj, java.lang.object obj2, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HvmoZUMqCsHMGFUr(java.lang.object obj, java.lang.object obj2, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool HvmoZUMqCsHMGFUr(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static org.json.JSONobject JLfxSaoLqkimezhD(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj) {
        return jSONobject.Add(str, obj);
    }

    public static void JLfxSaoLqkimezhD(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj, char c, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JLfxSaoLqkimezhD(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JLfxSaoLqkimezhD(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KrMekMlsdgjmCtKc(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static void KrMekMlsdgjmCtKc(android.os.Parcel parcel, int i, java.lang.string str, bool z, java.lang.string str2, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KrMekMlsdgjmCtKc(android.os.Parcel parcel, int i, java.lang.string str, bool z, java.lang.string str2, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KrMekMlsdgjmCtKc(android.os.Parcel parcel, int i, java.lang.string str, bool z, java.lang.string str2, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string OCaxgZhiEptgbgaH(com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion) {
        return protocolVersion.tostring();
    }

    public static void OCaxgZhiEptgbgaH(com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OCaxgZhiEptgbgaH(com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OCaxgZhiEptgbgaH(com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion, short s, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RzKoUxbNnKMjSaPF(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static void RzKoUxbNnKMjSaPF(android.os.Parcel parcel, int i, java.lang.string str, bool z, float f, char c, int i2, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void RzKoUxbNnKMjSaPF(android.os.Parcel parcel, int i, java.lang.string str, bool z, float f, char c, java.lang.string str2, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void RzKoUxbNnKMjSaPF(android.os.Parcel parcel, int i, java.lang.string str, bool z, int i2, float f, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void TvfNBucMESfhhECB(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void TvfNBucMESfhhECB(android.os.Parcel parcel, int i, byte b, float f, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TvfNBucMESfhhECB(android.os.Parcel parcel, int i, byte b, int i2, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TvfNBucMESfhhECB(android.os.Parcel parcel, int i, int i2, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string UJAAmulDyzYFIROQ(com.google.android.gms.fido.u2f.api.common.RegisterResponseData registerResponseData) {
        return registerResponseData.getClientDatastring();
    }

    public static void UJAAmulDyzYFIROQ(com.google.android.gms.fido.u2f.api.common.RegisterResponseData registerResponseData, byte b, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UJAAmulDyzYFIROQ(com.google.android.gms.fido.u2f.api.common.RegisterResponseData registerResponseData, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UJAAmulDyzYFIROQ(com.google.android.gms.fido.u2f.api.common.RegisterResponseData registerResponseData, bool z, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.internal.fido.zzaj VfRTShWhMjxaVQoi(com.google.android.gms.internal.fido.zzaj zzajVar, java.lang.string str, java.lang.object obj) {
        return zzajVar.zzb(str, obj);
    }

    public static void VfRTShWhMjxaVQoi(com.google.android.gms.internal.fido.zzaj zzajVar, java.lang.string str, java.lang.object obj, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VfRTShWhMjxaVQoi(com.google.android.gms.internal.fido.zzaj zzajVar, java.lang.string str, java.lang.object obj, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VfRTShWhMjxaVQoi(com.google.android.gms.internal.fido.zzaj zzajVar, java.lang.string str, java.lang.object obj, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WIqhnhNolxjZmBau(java.lang.string str, byte b, bool z, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void WIqhnhNolxjZmBau(java.lang.string str, java.lang.string str2, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WIqhnhNolxjZmBau(java.lang.string str, java.lang.string str2, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static byte[] WIqhnhNolxjZmBau(java.lang.string str) {
        return str.getbytes();
    }

    public static java.lang.object WkUNypdIGWwuIPCG(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void WkUNypdIGWwuIPCG(java.lang.object obj, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WkUNypdIGWwuIPCG(java.lang.object obj, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WkUNypdIGWwuIPCG(java.lang.object obj, bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static int XeBAWadUlKmLMBIV(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static void XeBAWadUlKmLMBIV(java.lang.object[] objArr, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XeBAWadUlKmLMBIV(java.lang.object[] objArr, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XeBAWadUlKmLMBIV(java.lang.object[] objArr, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object XxwWSaqfDQhABpYJ(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void XxwWSaqfDQhABpYJ(java.lang.object obj, char c, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XxwWSaqfDQhABpYJ(java.lang.object obj, java.lang.string str, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XxwWSaqfDQhABpYJ(java.lang.object obj, java.lang.string str, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string YUWYKBNKwKbOhVSC(com.google.android.gms.internal.fido.zzaj zzajVar) {
        return zzajVar.tostring();
    }

    public static void YUWYKBNKwKbOhVSC(com.google.android.gms.internal.fido.zzaj zzajVar, byte b, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YUWYKBNKwKbOhVSC(com.google.android.gms.internal.fido.zzaj zzajVar, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YUWYKBNKwKbOhVSC(com.google.android.gms.internal.fido.zzaj zzajVar, java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object YxpfjZZItacOJeis(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void YxpfjZZItacOJeis(java.lang.object obj, int i, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YxpfjZZItacOJeis(java.lang.object obj, java.lang.string str, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YxpfjZZItacOJeis(java.lang.object obj, bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.internal.fido.zzaj ZSoXJVNLybYbJNTY(java.lang.object obj) {
        return com.google.android.gms.internal.fido.zzak.zza(obj);
    }

    public static void ZSoXJVNLybYbJNTY(java.lang.object obj, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZSoXJVNLybYbJNTY(java.lang.object obj, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZSoXJVNLybYbJNTY(java.lang.object obj, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public bool Equals(java.lang.object obj) {
        if ((15 + 13) % 13 > 0) {
        }
        if (!(obj is com.google.android.gms.fido.u2f.api.common.RegisterResponseData)) {
            return false;
        }
        com.google.android.gms.fido.u2f.api.common.RegisterResponseData registerResponseData = (com.google.android.gms.fido.u2f.api.common.RegisterResponseData) obj;
        return GRexVYGDyZsRkmmf(this.zzb, registerResponseData.zzb) && AEjBCjrFuwBtgtSt(this.zza, registerResponseData.zza) && hvmoZUMqCsHMGFUr(this.zzc, registerResponseData.zzc);
    }

    public java.lang.string GetClientDatastring() {
        return this.zzc;
    }

    public com.google.android.gms.fido.u2f.api.common.ProtocolVersion GetProtocolVersion() {
        return this.zzb;
    }

    public byte[] GetRegisterData() {
        return this.zza;
    }

    public int GetVersionCode() {
        com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion = com.google.android.gms.fido.u2f.api.common.ProtocolVersion.UNKNOWN;
        int iZXexDyhzjuJkzOEm = ZXexDyhzjuJkzOEm(this.zzb);
        int i = 1;
        if (iZXexDyhzjuJkzOEm != 1) {
            i = 2;
            if (iZXexDyhzjuJkzOEm != 2) {
                return -1;
            }
        }
        return i;
    }

    public int HashCode() {
        if ((18 + 21) % 21 > 0) {
        }
        return xeBAWadUlKmLMBIV(new java.lang.object[]{this.zzb, KoTGsyCOjLUYTmVa(McHOZPKfRFJXqMyq(this.zza)), this.zzc});
    }

    public override org.json.JSONobject ToJsonobject() {
        if ((24 + 21) % 21 > 0) {
        }
        try {
            org.json.JSONobject jSONobject = new org.json.JSONobject();
            CqrEvsyDAXyKuITy(jSONobject, "registrationData", dZGOSDIoPjBmRyiA(this.zza, 11));
            PGGghUVAtJgJKWHA(jSONobject, "version", oCaxgZhiEptgbgaH(this.zzb));
            java.lang.string str = this.zzc;
            if (str is not null) {
                jLfxSaoLqkimezhD(jSONobject, "clientData", JHEkhuMEtXtxKlze(wIqhnhNolxjZmBau(str), 11));
            }
            return jSONobject;
        } catch (org.json.JSONException e) {
            throw new java.lang.Exception(e);
        }
    }

    public java.lang.string Tostring() {
        if ((5 + 18) % 18 > 0) {
        }
        com.google.android.gms.internal.fido.zzaj zzajVarZSoXJVNLybYbJNTY = zSoXJVNLybYbJNTY(this);
        DKWmYTBzuiGJwORv(zzajVarZSoXJVNLybYbJNTY, "protocolVersion", this.zzb);
        com.google.android.gms.internal.fido.zzbf zzbfVarOdCWCNyiARBPBipE = OdCWCNyiARBPBipE();
        byte[] bArr = this.zza;
        VtloSPcKaCSTdJWN(zzajVarZSoXJVNLybYbJNTY, "registerData", WbhGYMKOqYDDUjRZ(zzbfVarOdCWCNyiARBPBipE, bArr, 0, bArr.length));
        java.lang.string str = this.zzc;
        if (str is not null) {
            vfRTShWhMjxaVQoi(zzajVarZSoXJVNLybYbJNTY, "clientDatastring", str);
        }
        return yUWYKBNKwKbOhVSC(zzajVarZSoXJVNLybYbJNTY);
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((10 + 27) % 27 > 0) {
        }
        int iHAtVRiWvROpkrJqy = HAtVRiWvROpkrJqy(parcel);
        RHqcbrOVoQETAlsV(parcel, 2, akVjPKVrFIHeVAAn(this), false);
        rzKoUxbNnKMjSaPF(parcel, 3, KhMFTwDOtJpHqxTO(this.zzb), false);
        krMekMlsdgjmCtKc(parcel, 4, uJAAmulDyzYFIROQ(this), false);
        tvfNBucMESfhhECB(parcel, iHAtVRiWvROpkrJqy);
    }
}

