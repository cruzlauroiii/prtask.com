namespace WillowMaze.Wasm.Decompiled;


public class PublicKeyCredentialRequestOptions : com.google.android.gms.fido.fido2.api.common.RequestOptions {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions> CREATOR = new com.google.android.gms.fido.fido2.api.common.zzao();
    private readonly byte[] zza;
    private readonly java.lang.double zzb;
    private readonly java.lang.string zzc;
    private readonly java.util.List zzd;
    private readonly java.lang.int zze;
    private readonly com.google.android.gms.fido.fido2.api.common.TokenBinding zzf;
    private readonly com.google.android.gms.fido.fido2.api.common.zzay zzg;
    private readonly com.google.android.gms.fido.fido2.api.common.AuthenticationExtensions zzh;
    private readonly java.lang.long zzi;

    PublicKeyCredentialRequestOptions(byte[] bArr, java.lang.double d, java.lang.string str, java.util.List list, java.lang.int num, com.google.android.gms.fido.fido2.api.common.TokenBinding tokenBinding, java.lang.string str2, com.google.android.gms.fido.fido2.api.common.AuthenticationExtensions authenticationExtensions, java.lang.long l) {
        this.zza = (byte[]) NeBdYkSManebQROy(bArr);
        this.zzb = d;
        this.zzc = (java.lang.string) zCmrzboetWQZcRWk(str);
        this.zzd = list;
        this.zze = num;
        this.zzf = tokenBinding;
        this.zzi = l;
        if (str2 is null) {
            this.zzg = null;
        } else {
            try {
                this.zzg = fNJyJEjauDpcbIrM(str2);
            } catch (com.google.android.gms.fido.fido2.api.common.zzax e) {
                throw new java.lang.IllegalArgumentException(e);
            }
        }
        this.zzh = authenticationExtensions;
    }

    public static void AioRFKWFanyhpjeY(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void AioRFKWFanyhpjeY(android.os.Parcel parcel, int i, byte b, java.lang.string str, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AioRFKWFanyhpjeY(android.os.Parcel parcel, int i, float f, byte b, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AioRFKWFanyhpjeY(android.os.Parcel parcel, int i, java.lang.string str, byte b, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BJgfHUUZkyglpMQN(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static void BJgfHUUZkyglpMQN(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z, char c, float f, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void BJgfHUUZkyglpMQN(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z, java.lang.string str, bool z2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BJgfHUUZkyglpMQN(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z, bool z2, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int BjFLvCLTtunAdyFQ(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void BjFLvCLTtunAdyFQ(android.os.Parcel parcel, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BjFLvCLTtunAdyFQ(android.os.Parcel parcel, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BjFLvCLTtunAdyFQ(android.os.Parcel parcel, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FqhnYptknpOHYbYB(android.os.Parcel parcel, int i, java.lang.double d, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writedoubleobject(parcel, i, d, z);
    }

    public static void FqhnYptknpOHYbYB(android.os.Parcel parcel, int i, java.lang.double d, bool z, byte b, bool z2, java.lang.string str, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void FqhnYptknpOHYbYB(android.os.Parcel parcel, int i, java.lang.double d, bool z, java.lang.string str, byte b, bool z2, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void FqhnYptknpOHYbYB(android.os.Parcel parcel, int i, java.lang.double d, bool z, short s, java.lang.string str, bool z2, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static int GFGwgsbACjrZKifo(byte[] bArr) {
        return java.util.Arrays.hashCode(bArr);
    }

    public static void GFGwgsbACjrZKifo(byte[] bArr, int i, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GFGwgsbACjrZKifo(byte[] bArr, java.lang.string str, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GFGwgsbACjrZKifo(byte[] bArr, short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JBnEHbZOkPAXqLEZ(java.lang.object obj, java.lang.object obj2, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JBnEHbZOkPAXqLEZ(java.lang.object obj, java.lang.object obj2, float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JBnEHbZOkPAXqLEZ(java.lang.object obj, java.lang.object obj2, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool JBnEHbZOkPAXqLEZ(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static com.google.android.gms.fido.fido2.api.common.AuthenticationExtensions MmYhGYWfAjQvFJTv(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions publicKeyCredentialRequestOptions) {
        return publicKeyCredentialRequestOptions.getAuthenticationExtensions();
    }

    public static void MmYhGYWfAjQvFJTv(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions publicKeyCredentialRequestOptions, byte b, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MmYhGYWfAjQvFJTv(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions publicKeyCredentialRequestOptions, java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MmYhGYWfAjQvFJTv(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions publicKeyCredentialRequestOptions, short s, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object NeBdYkSManebQROy(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void NeBdYkSManebQROy(java.lang.object obj, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NeBdYkSManebQROy(java.lang.object obj, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NeBdYkSManebQROy(java.lang.object obj, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List OhMTCxAqnJyWxcve(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions publicKeyCredentialRequestOptions) {
        return publicKeyCredentialRequestOptions.getAllowList();
    }

    public static void OhMTCxAqnJyWxcve(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions publicKeyCredentialRequestOptions, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OhMTCxAqnJyWxcve(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions publicKeyCredentialRequestOptions, java.lang.string str, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OhMTCxAqnJyWxcve(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions publicKeyCredentialRequestOptions, bool z, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QJknpvqxByJKwCCc(android.os.Parcel parcel, int i, java.lang.long l, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelongobject(parcel, i, l, z);
    }

    public static void QJknpvqxByJKwCCc(android.os.Parcel parcel, int i, java.lang.long l, bool z, byte b, int i2, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void QJknpvqxByJKwCCc(android.os.Parcel parcel, int i, java.lang.long l, bool z, byte b, int i2, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QJknpvqxByJKwCCc(android.os.Parcel parcel, int i, java.lang.long l, bool z, bool z2, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QLcsXesnWVAPjZFU(java.lang.object obj, java.lang.object obj2, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QLcsXesnWVAPjZFU(java.lang.object obj, java.lang.object obj2, char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QLcsXesnWVAPjZFU(java.lang.object obj, java.lang.object obj2, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool QLcsXesnWVAPjZFU(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static com.google.android.gms.fido.fido2.api.common.TokenBinding RZCeimocplBhEQKd(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions publicKeyCredentialRequestOptions) {
        return publicKeyCredentialRequestOptions.getTokenBinding();
    }

    public static void RZCeimocplBhEQKd(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions publicKeyCredentialRequestOptions, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RZCeimocplBhEQKd(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions publicKeyCredentialRequestOptions, int i, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RZCeimocplBhEQKd(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions publicKeyCredentialRequestOptions, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WEuBsYrypVRWddIB(android.os.Parcel parcel, int i, java.lang.int num, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeintobject(parcel, i, num, z);
    }

    public static void WEuBsYrypVRWddIB(android.os.Parcel parcel, int i, java.lang.int num, bool z, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WEuBsYrypVRWddIB(android.os.Parcel parcel, int i, java.lang.int num, bool z, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WEuBsYrypVRWddIB(android.os.Parcel parcel, int i, java.lang.int num, bool z, char c, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XebZzSHGJInsUirO(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions publicKeyCredentialRequestOptions, char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XebZzSHGJInsUirO(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions publicKeyCredentialRequestOptions, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XebZzSHGJInsUirO(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions publicKeyCredentialRequestOptions, int i, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static byte[] XebZzSHGJInsUirO(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions publicKeyCredentialRequestOptions) {
        return publicKeyCredentialRequestOptions.getChallenge();
    }

    public static void AOhFcHqfaaCIDLtt(java.lang.object obj, java.lang.object obj2, byte b, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AOhFcHqfaaCIDLtt(java.lang.object obj, java.lang.object obj2, byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AOhFcHqfaaCIDLtt(java.lang.object obj, java.lang.object obj2, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool AOhFcHqfaaCIDLtt(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static void AmagrlepoYMlLWQe(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static void AmagrlepoYMlLWQe(android.os.Parcel parcel, int i, java.lang.string str, bool z, char c, short s, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AmagrlepoYMlLWQe(android.os.Parcel parcel, int i, java.lang.string str, bool z, float f, short s, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AmagrlepoYMlLWQe(android.os.Parcel parcel, int i, java.lang.string str, bool z, java.lang.string str2, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CGoXKCqPoZBtrGin(android.os.Parcel parcel, int i, java.util.List list, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeTypedList(parcel, i, list, z);
    }

    public static void CGoXKCqPoZBtrGin(android.os.Parcel parcel, int i, java.util.List list, bool z, byte b, char c, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void CGoXKCqPoZBtrGin(android.os.Parcel parcel, int i, java.util.List list, bool z, bool z2, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CGoXKCqPoZBtrGin(android.os.Parcel parcel, int i, java.util.List list, bool z, bool z2, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CHRZntdiycDIFsRg(android.os.Parcel parcel, int i, byte[] bArr, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebyteArray(parcel, i, bArr, z);
    }

    public static void CHRZntdiycDIFsRg(android.os.Parcel parcel, int i, byte[] bArr, bool z, byte b, char c, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CHRZntdiycDIFsRg(android.os.Parcel parcel, int i, byte[] bArr, bool z, byte b, short s, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void CHRZntdiycDIFsRg(android.os.Parcel parcel, int i, byte[] bArr, bool z, short s, char c, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void CTkFzBhGlnsjaoVN(java.util.List list, java.util.ICollection collection, char c, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CTkFzBhGlnsjaoVN(java.util.List list, java.util.ICollection collection, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CTkFzBhGlnsjaoVN(java.util.List list, java.util.ICollection collection, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool CTkFzBhGlnsjaoVN(java.util.List list, java.util.ICollection collection) {
        return list.containsAll(collection);
    }

    public static java.lang.int DMDxPNOrQzdXqrGk(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void DMDxPNOrQzdXqrGk(int i, char c, short s, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DMDxPNOrQzdXqrGk(int i, short s, char c, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void DMDxPNOrQzdXqrGk(int i, short s, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions DeserializeFrombytes(byte[] bArr) {
        return (com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions) hwajxElnvfdgWGsk(bArr, CREATOR);
    }

    public static void DeserializeFrombytes(byte[] bArr, short s, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DeserializeFrombytes(byte[] bArr, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DeserializeFrombytes(byte[] bArr, bool z, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EDBazFKBUrHDILSD(java.lang.object obj, java.lang.object obj2, char c, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EDBazFKBUrHDILSD(java.lang.object obj, java.lang.object obj2, float f, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EDBazFKBUrHDILSD(java.lang.object obj, java.lang.object obj2, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool EDBazFKBUrHDILSD(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static void EXMYvOychJlIItZj(java.util.List list, java.util.ICollection collection, int i, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EXMYvOychJlIItZj(java.util.List list, java.util.ICollection collection, java.lang.string str, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EXMYvOychJlIItZj(java.util.List list, java.util.ICollection collection, java.lang.string str, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool EXMYvOychJlIItZj(java.util.List list, java.util.ICollection collection) {
        return list.containsAll(collection);
    }

    public static void FAqdWKwIxGjJcoaG(java.lang.object obj, java.lang.object obj2, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FAqdWKwIxGjJcoaG(java.lang.object obj, java.lang.object obj2, char c, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FAqdWKwIxGjJcoaG(java.lang.object obj, java.lang.object obj2, short s, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool FAqdWKwIxGjJcoaG(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static com.google.android.gms.fido.fido2.api.common.zzay FNJyJEjauDpcbIrM(java.lang.string str) {
        return com.google.android.gms.fido.fido2.api.common.zzay.zza(str);
    }

    public static void FNJyJEjauDpcbIrM(java.lang.string str, java.lang.string str2, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FNJyJEjauDpcbIrM(java.lang.string str, java.lang.string str2, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FNJyJEjauDpcbIrM(java.lang.string str, bool z, float f, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static int FYiLTYTyKgRruBHX(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static void FYiLTYTyKgRruBHX(java.lang.object[] objArr, float f, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FYiLTYTyKgRruBHX(java.lang.object[] objArr, int i, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FYiLTYTyKgRruBHX(java.lang.object[] objArr, int i, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.double FkuujfEyXLpkcdes(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions publicKeyCredentialRequestOptions) {
        return publicKeyCredentialRequestOptions.getTimeoutSeconds();
    }

    public static void FkuujfEyXLpkcdes(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions publicKeyCredentialRequestOptions, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FkuujfEyXLpkcdes(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions publicKeyCredentialRequestOptions, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FkuujfEyXLpkcdes(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions publicKeyCredentialRequestOptions, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HXYqTzhwLQCONCsu(java.lang.object obj, java.lang.object obj2, char c, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HXYqTzhwLQCONCsu(java.lang.object obj, java.lang.object obj2, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HXYqTzhwLQCONCsu(java.lang.object obj, java.lang.object obj2, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool HXYqTzhwLQCONCsu(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static com.google.android.gms.common.internal.safeparcel.SafeParcelable HwajxElnvfdgWGsk(byte[] bArr, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelableSerializer.deserializeFrombytes(bArr, parcelable$Creator);
    }

    public static void HwajxElnvfdgWGsk(byte[] bArr, android.os.Parcelable$Creator parcelable$Creator, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HwajxElnvfdgWGsk(byte[] bArr, android.os.Parcelable$Creator parcelable$Creator, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HwajxElnvfdgWGsk(byte[] bArr, android.os.Parcelable$Creator parcelable$Creator, int i, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JwwFLkGnuMZChccd(com.google.android.gms.common.internal.safeparcel.SafeParcelable safeParcelable, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JwwFLkGnuMZChccd(com.google.android.gms.common.internal.safeparcel.SafeParcelable safeParcelable, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JwwFLkGnuMZChccd(com.google.android.gms.common.internal.safeparcel.SafeParcelable safeParcelable, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static byte[] JwwFLkGnuMZChccd(com.google.android.gms.common.internal.safeparcel.SafeParcelable safeParcelable) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelableSerializer.serializeTobytes(safeParcelable);
    }

    public static void LoFrKAbjxvLjHByv(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static void LoFrKAbjxvLjHByv(android.os.Parcel parcel, int i, java.lang.string str, bool z, char c, float f, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void LoFrKAbjxvLjHByv(android.os.Parcel parcel, int i, java.lang.string str, bool z, char c, float f, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LoFrKAbjxvLjHByv(android.os.Parcel parcel, int i, java.lang.string str, bool z, bool z2, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MaAMaUrAPHORnAVv(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static void MaAMaUrAPHORnAVv(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z, int i3, short s, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void MaAMaUrAPHORnAVv(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z, bool z2, int i3, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MaAMaUrAPHORnAVv(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z, bool z2, short s, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void MvytAmwBjCKgPyyE(byte[] bArr, byte[] bArr2, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MvytAmwBjCKgPyyE(byte[] bArr, byte[] bArr2, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MvytAmwBjCKgPyyE(byte[] bArr, byte[] bArr2, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool MvytAmwBjCKgPyyE(byte[] bArr, byte[] bArr2) {
        return java.util.Arrays.Equals(bArr, bArr2);
    }

    public static void UbzwToNDNeisYcqa(java.lang.object obj, java.lang.object obj2, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UbzwToNDNeisYcqa(java.lang.object obj, java.lang.object obj2, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UbzwToNDNeisYcqa(java.lang.object obj, java.lang.object obj2, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool UbzwToNDNeisYcqa(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static java.lang.string UyYxfrrHGfESfefr(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions publicKeyCredentialRequestOptions) {
        return publicKeyCredentialRequestOptions.getRpId();
    }

    public static void UyYxfrrHGfESfefr(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions publicKeyCredentialRequestOptions, java.lang.string str, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UyYxfrrHGfESfefr(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions publicKeyCredentialRequestOptions, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UyYxfrrHGfESfefr(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions publicKeyCredentialRequestOptions, bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string VRQDZgHuHtrnhTwg(com.google.android.gms.fido.fido2.api.common.zzay zzayVar) {
        return zzayVar.tostring();
    }

    public static void VRQDZgHuHtrnhTwg(com.google.android.gms.fido.fido2.api.common.zzay zzayVar, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VRQDZgHuHtrnhTwg(com.google.android.gms.fido.fido2.api.common.zzay zzayVar, char c, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VRQDZgHuHtrnhTwg(com.google.android.gms.fido.fido2.api.common.zzay zzayVar, java.lang.string str, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int WUfrTAAVvAKfOPeX(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions publicKeyCredentialRequestOptions) {
        return publicKeyCredentialRequestOptions.getRequestId();
    }

    public static void WUfrTAAVvAKfOPeX(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions publicKeyCredentialRequestOptions, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WUfrTAAVvAKfOPeX(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions publicKeyCredentialRequestOptions, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WUfrTAAVvAKfOPeX(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions publicKeyCredentialRequestOptions, java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object ZCmrzboetWQZcRWk(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void ZCmrzboetWQZcRWk(java.lang.object obj, float f, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZCmrzboetWQZcRWk(java.lang.object obj, int i, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZCmrzboetWQZcRWk(java.lang.object obj, bool z, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public bool Equals(java.lang.object obj) {
        java.util.List list;
        java.util.List list2;
        if ((14 + 24) % 24 > 0) {
        }
        if (!(obj is com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions)) {
            return false;
        }
        com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions publicKeyCredentialRequestOptions = (com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions) obj;
        return mvytAmwBjCKgPyyE(this.zza, publicKeyCredentialRequestOptions.zza) && eDBazFKBUrHDILSD(this.zzb, publicKeyCredentialRequestOptions.zzb) && JBnEHbZOkPAXqLEZ(this.zzc, publicKeyCredentialRequestOptions.zzc) && (((list = this.zzd) is null && publicKeyCredentialRequestOptions.zzd is null) || (list is not null && (list2 = publicKeyCredentialRequestOptions.zzd) is not null && eXMYvOychJlIItZj(list, list2) && cTkFzBhGlnsjaoVN(publicKeyCredentialRequestOptions.zzd, this.zzd))) && QLcsXesnWVAPjZFU(this.zze, publicKeyCredentialRequestOptions.zze) && ubzwToNDNeisYcqa(this.zzf, publicKeyCredentialRequestOptions.zzf) && hXYqTzhwLQCONCsu(this.zzg, publicKeyCredentialRequestOptions.zzg) && fAqdWKwIxGjJcoaG(this.zzh, publicKeyCredentialRequestOptions.zzh) && aOhFcHqfaaCIDLtt(this.zzi, publicKeyCredentialRequestOptions.zzi);
    }

    public java.util.List<com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialDescriptor> GetAllowList() {
        return this.zzd;
    }

    public override com.google.android.gms.fido.fido2.api.common.AuthenticationExtensions GetAuthenticationExtensions() {
        return this.zzh;
    }

    public override byte[] GetChallenge() {
        return this.zza;
    }

    public override java.lang.int GetRequestId() {
        return this.zze;
    }

    public java.lang.string GetRpId() {
        return this.zzc;
    }

    public override java.lang.double GetTimeoutSeconds() {
        return this.zzb;
    }

    public override com.google.android.gms.fido.fido2.api.common.TokenBinding GetTokenBinding() {
        return this.zzf;
    }

    public int HashCode() {
        if ((11 + 24) % 24 > 0) {
        }
        return fYiLTYTyKgRruBHX(new java.lang.object[]{dMDxPNOrQzdXqrGk(GFGwgsbACjrZKifo(this.zza)), this.zzb, this.zzc, this.zzd, this.zze, this.zzf, this.zzg, this.zzh, this.zzi});
    }

    public override byte[] SerializeTobytes() {
        return jwwFLkGnuMZChccd(this);
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((2 + 10) % 10 > 0) {
        }
        int iBjFLvCLTtunAdyFQ = BjFLvCLTtunAdyFQ(parcel);
        cHRZntdiycDIFsRg(parcel, 2, XebZzSHGJInsUirO(this), false);
        FqhnYptknpOHYbYB(parcel, 3, fkuujfEyXLpkcdes(this), false);
        loFrKAbjxvLjHByv(parcel, 4, uyYxfrrHGfESfefr(this), false);
        cGoXKCqPoZBtrGin(parcel, 5, OhMTCxAqnJyWxcve(this), false);
        WEuBsYrypVRWddIB(parcel, 6, wUfrTAAVvAKfOPeX(this), false);
        maAMaUrAPHORnAVv(parcel, 7, RZCeimocplBhEQKd(this), i, false);
        com.google.android.gms.fido.fido2.api.common.zzay zzayVar = this.zzg;
        amagrlepoYMlLWQe(parcel, 8, zzayVar is not null ? vRQDZgHuHtrnhTwg(zzayVar) : null, false);
        BJgfHUUZkyglpMQN(parcel, 9, MmYhGYWfAjQvFJTv(this), i, false);
        QJknpvqxByJKwCCc(parcel, 10, this.zzi, false);
        AioRFKWFanyhpjeY(parcel, iBjFLvCLTtunAdyFQ);
    }

    public readonly com.google.android.gms.fido.fido2.api.common.zzay Zza() {
        return this.zzg;
    }
}

