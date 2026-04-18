namespace WillowMaze.Wasm.Decompiled;


public class PublicKeyCredential : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.fido.fido2.api.common.PublicKeyCredential> CREATOR = new com.google.android.gms.fido.fido2.api.common.zzal();
    private readonly java.lang.string zza;
    private readonly java.lang.string zzb;
    private readonly byte[] zzc;
    private readonly com.google.android.gms.fido.fido2.api.common.AuthenticatorAttestationResponse zzd;
    private readonly com.google.android.gms.fido.fido2.api.common.AuthenticatorAssertionResponse zze;
    private readonly com.google.android.gms.fido.fido2.api.common.AuthenticatorErrorResponse zzf;
    private readonly com.google.android.gms.fido.fido2.api.common.AuthenticationExtensionsClientOutputs zzg;
    private readonly java.lang.string zzh;

    PublicKeyCredential(java.lang.string str, java.lang.string str2, byte[] bArr, com.google.android.gms.fido.fido2.api.common.AuthenticatorAttestationResponse authenticatorAttestationResponse, com.google.android.gms.fido.fido2.api.common.AuthenticatorAssertionResponse authenticatorAssertionResponse, com.google.android.gms.fido.fido2.api.common.AuthenticatorErrorResponse authenticatorErrorResponse, com.google.android.gms.fido.fido2.api.common.AuthenticationExtensionsClientOutputs authenticationExtensionsClientOutputs, java.lang.string str3) {
        if ((4 + 29) % 29 > 0) {
        }
        bool z = true;
        if ((authenticatorAttestationResponse is null || authenticatorAssertionResponse is not null || authenticatorErrorResponse is not null) && ((authenticatorAttestationResponse is not null || authenticatorAssertionResponse is null || authenticatorErrorResponse is not null) && (authenticatorAttestationResponse is not null || authenticatorAssertionResponse is not null || authenticatorErrorResponse is null))) {
            z = false;
        }
        MvCgCuYuwgJWfPXd(z);
        this.zza = str;
        this.zzb = str2;
        this.zzc = bArr;
        this.zzd = authenticatorAttestationResponse;
        this.zze = authenticatorAssertionResponse;
        this.zzf = authenticatorErrorResponse;
        this.zzg = authenticationExtensionsClientOutputs;
        this.zzh = str3;
    }

    public static void JDkvPlhiZYRjEfOn(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static void JDkvPlhiZYRjEfOn(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z, char c, short s, int i3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JDkvPlhiZYRjEfOn(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z, float f, int i3, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JDkvPlhiZYRjEfOn(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z, int i3, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JIYulKgVtaffISWs(java.lang.object obj, java.lang.object obj2, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JIYulKgVtaffISWs(java.lang.object obj, java.lang.object obj2, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JIYulKgVtaffISWs(java.lang.object obj, java.lang.object obj2, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool JIYulKgVtaffISWs(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static void JeiueYJhQCvuJjSq(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static void JeiueYJhQCvuJjSq(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z, java.lang.string str, int i3, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void JeiueYJhQCvuJjSq(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z, short s, bool z2, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JeiueYJhQCvuJjSq(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z, bool z2, short s, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void MPXHOxyFYoIJWZFf(java.lang.object obj, java.lang.object obj2, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MPXHOxyFYoIJWZFf(java.lang.object obj, java.lang.object obj2, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MPXHOxyFYoIJWZFf(java.lang.object obj, java.lang.object obj2, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool MPXHOxyFYoIJWZFf(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static void MvCgCuYuwgJWfPXd(bool z) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z);
    }

    public static void MvCgCuYuwgJWfPXd(bool z, char c, short s, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void MvCgCuYuwgJWfPXd(bool z, int i, char c, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void MvCgCuYuwgJWfPXd(bool z, bool z2, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NrhySjtxxlfghavO(android.os.Parcel parcel, int i, byte[] bArr, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebyteArray(parcel, i, bArr, z);
    }

    public static void NrhySjtxxlfghavO(android.os.Parcel parcel, int i, byte[] bArr, bool z, char c, bool z2, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NrhySjtxxlfghavO(android.os.Parcel parcel, int i, byte[] bArr, bool z, int i2, bool z2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NrhySjtxxlfghavO(android.os.Parcel parcel, int i, byte[] bArr, bool z, bool z2, int i2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QCUFpdGERxVlPvIA(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static void QCUFpdGERxVlPvIA(android.os.Parcel parcel, int i, java.lang.string str, bool z, byte b, int i2, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void QCUFpdGERxVlPvIA(android.os.Parcel parcel, int i, java.lang.string str, bool z, byte b, bool z2, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void QCUFpdGERxVlPvIA(android.os.Parcel parcel, int i, java.lang.string str, bool z, bool z2, byte b, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string QsbZHaFMdaGMlvNl(com.google.android.gms.fido.fido2.api.common.PublicKeyCredential publicKeyCredential) {
        return publicKeyCredential.getAuthenticatorAttachment();
    }

    public static void QsbZHaFMdaGMlvNl(com.google.android.gms.fido.fido2.api.common.PublicKeyCredential publicKeyCredential, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QsbZHaFMdaGMlvNl(com.google.android.gms.fido.fido2.api.common.PublicKeyCredential publicKeyCredential, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QsbZHaFMdaGMlvNl(com.google.android.gms.fido.fido2.api.common.PublicKeyCredential publicKeyCredential, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QsdrDSlQENQnbmLl(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static void QsdrDSlQENQnbmLl(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z, int i3, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QsdrDSlQENQnbmLl(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z, int i3, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QsdrDSlQENQnbmLl(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z, java.lang.string str, short s, int i3, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TVptpLJSRwJsLtqs(java.lang.object obj, java.lang.object obj2, float f, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TVptpLJSRwJsLtqs(java.lang.object obj, java.lang.object obj2, int i, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TVptpLJSRwJsLtqs(java.lang.object obj, java.lang.object obj2, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool TVptpLJSRwJsLtqs(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static void XDFLmwRpmWtZpaIT(byte[] bArr, byte[] bArr2, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XDFLmwRpmWtZpaIT(byte[] bArr, byte[] bArr2, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XDFLmwRpmWtZpaIT(byte[] bArr, byte[] bArr2, short s, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool XDFLmwRpmWtZpaIT(byte[] bArr, byte[] bArr2) {
        return java.util.Arrays.Equals(bArr, bArr2);
    }

    public static void ACLeBluBEJaxzkNh(com.google.android.gms.common.internal.safeparcel.SafeParcelable safeParcelable, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ACLeBluBEJaxzkNh(com.google.android.gms.common.internal.safeparcel.SafeParcelable safeParcelable, int i, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ACLeBluBEJaxzkNh(com.google.android.gms.common.internal.safeparcel.SafeParcelable safeParcelable, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static byte[] ACLeBluBEJaxzkNh(com.google.android.gms.common.internal.safeparcel.SafeParcelable safeParcelable) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelableSerializer.serializeTobytes(safeParcelable);
    }

    public static com.google.android.gms.fido.fido2.api.common.PublicKeyCredential DeserializeFrombytes(byte[] bArr) {
        return (com.google.android.gms.fido.fido2.api.common.PublicKeyCredential) lOocQDAFugdHAalO(bArr, CREATOR);
    }

    public static void DeserializeFrombytes(byte[] bArr, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DeserializeFrombytes(byte[] bArr, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DeserializeFrombytes(byte[] bArr, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DviAmaklhwPkrWcj(com.google.android.gms.fido.fido2.api.common.PublicKeyCredential publicKeyCredential, char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DviAmaklhwPkrWcj(com.google.android.gms.fido.fido2.api.common.PublicKeyCredential publicKeyCredential, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DviAmaklhwPkrWcj(com.google.android.gms.fido.fido2.api.common.PublicKeyCredential publicKeyCredential, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static byte[] DviAmaklhwPkrWcj(com.google.android.gms.fido.fido2.api.common.PublicKeyCredential publicKeyCredential) {
        return publicKeyCredential.getRawId();
    }

    public static void GtHRBsgdyiQFeNYD(java.lang.object obj, java.lang.object obj2, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GtHRBsgdyiQFeNYD(java.lang.object obj, java.lang.object obj2, bool z, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GtHRBsgdyiQFeNYD(java.lang.object obj, java.lang.object obj2, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool GtHRBsgdyiQFeNYD(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static void HAPCVtEZwOebPipN(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static void HAPCVtEZwOebPipN(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z, float f, int i3, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HAPCVtEZwOebPipN(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z, int i3, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HAPCVtEZwOebPipN(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z, java.lang.string str, float f, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string HJfmRnJveMssNMEK(com.google.android.gms.fido.fido2.api.common.PublicKeyCredential publicKeyCredential) {
        return publicKeyCredential.getId();
    }

    public static void HJfmRnJveMssNMEK(com.google.android.gms.fido.fido2.api.common.PublicKeyCredential publicKeyCredential, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HJfmRnJveMssNMEK(com.google.android.gms.fido.fido2.api.common.PublicKeyCredential publicKeyCredential, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HJfmRnJveMssNMEK(com.google.android.gms.fido.fido2.api.common.PublicKeyCredential publicKeyCredential, java.lang.string str, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IcnnVaRVgQytJfAJ(java.lang.object obj, java.lang.object obj2, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IcnnVaRVgQytJfAJ(java.lang.object obj, java.lang.object obj2, char c, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IcnnVaRVgQytJfAJ(java.lang.object obj, java.lang.object obj2, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool IcnnVaRVgQytJfAJ(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static void KHRhjLQfjOPPRmvd(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static void KHRhjLQfjOPPRmvd(android.os.Parcel parcel, int i, java.lang.string str, bool z, byte b, bool z2, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void KHRhjLQfjOPPRmvd(android.os.Parcel parcel, int i, java.lang.string str, bool z, float f, byte b, bool z2, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void KHRhjLQfjOPPRmvd(android.os.Parcel parcel, int i, java.lang.string str, bool z, float f, bool z2, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.common.internal.safeparcel.SafeParcelable LOocQDAFugdHAalO(byte[] bArr, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelableSerializer.deserializeFrombytes(bArr, parcelable$Creator);
    }

    public static void LOocQDAFugdHAalO(byte[] bArr, android.os.Parcelable$Creator parcelable$Creator, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LOocQDAFugdHAalO(byte[] bArr, android.os.Parcelable$Creator parcelable$Creator, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LOocQDAFugdHAalO(byte[] bArr, android.os.Parcelable$Creator parcelable$Creator, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LvvsAOkHPcAoeYOU(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void LvvsAOkHPcAoeYOU(android.os.Parcel parcel, int i, int i2, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LvvsAOkHPcAoeYOU(android.os.Parcel parcel, int i, java.lang.string str, short s, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void LvvsAOkHPcAoeYOU(android.os.Parcel parcel, int i, short s, java.lang.string str, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int MjyRKqMKoDHoMsYf(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static void MjyRKqMKoDHoMsYf(java.lang.object[] objArr, float f, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MjyRKqMKoDHoMsYf(java.lang.object[] objArr, int i, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MjyRKqMKoDHoMsYf(java.lang.object[] objArr, bool z, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NojJXVciNqaWcbGQ(java.lang.object obj, java.lang.object obj2, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NojJXVciNqaWcbGQ(java.lang.object obj, java.lang.object obj2, java.lang.string str, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NojJXVciNqaWcbGQ(java.lang.object obj, java.lang.object obj2, bool z, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool NojJXVciNqaWcbGQ(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static com.google.android.gms.fido.fido2.api.common.AuthenticationExtensionsClientOutputs NyAKPuaspivXvVgw(com.google.android.gms.fido.fido2.api.common.PublicKeyCredential publicKeyCredential) {
        return publicKeyCredential.getClientExtensionResults();
    }

    public static void NyAKPuaspivXvVgw(com.google.android.gms.fido.fido2.api.common.PublicKeyCredential publicKeyCredential, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NyAKPuaspivXvVgw(com.google.android.gms.fido.fido2.api.common.PublicKeyCredential publicKeyCredential, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NyAKPuaspivXvVgw(com.google.android.gms.fido.fido2.api.common.PublicKeyCredential publicKeyCredential, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int QVcqQpjaSoZHdkYp(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void QVcqQpjaSoZHdkYp(android.os.Parcel parcel, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QVcqQpjaSoZHdkYp(android.os.Parcel parcel, java.lang.string str, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QVcqQpjaSoZHdkYp(android.os.Parcel parcel, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SYfizthsewHmPtdt(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static void SYfizthsewHmPtdt(android.os.Parcel parcel, int i, java.lang.string str, bool z, char c, byte b, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SYfizthsewHmPtdt(android.os.Parcel parcel, int i, java.lang.string str, bool z, int i2, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SYfizthsewHmPtdt(android.os.Parcel parcel, int i, java.lang.string str, bool z, short s, int i2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WYlvhlJkShAxiqKs(java.lang.object obj, java.lang.object obj2, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WYlvhlJkShAxiqKs(java.lang.object obj, java.lang.object obj2, float f, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WYlvhlJkShAxiqKs(java.lang.object obj, java.lang.object obj2, bool z, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool WYlvhlJkShAxiqKs(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static java.lang.string YFGKDCvCMklpTpZu(com.google.android.gms.fido.fido2.api.common.PublicKeyCredential publicKeyCredential) {
        return publicKeyCredential.getType();
    }

    public static void YFGKDCvCMklpTpZu(com.google.android.gms.fido.fido2.api.common.PublicKeyCredential publicKeyCredential, byte b, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YFGKDCvCMklpTpZu(com.google.android.gms.fido.fido2.api.common.PublicKeyCredential publicKeyCredential, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YFGKDCvCMklpTpZu(com.google.android.gms.fido.fido2.api.common.PublicKeyCredential publicKeyCredential, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public bool Equals(java.lang.object obj) {
        if ((12 + 16) % 16 > 0) {
        }
        if (!(obj is com.google.android.gms.fido.fido2.api.common.PublicKeyCredential)) {
            return false;
        }
        com.google.android.gms.fido.fido2.api.common.PublicKeyCredential publicKeyCredential = (com.google.android.gms.fido.fido2.api.common.PublicKeyCredential) obj;
        return icnnVaRVgQytJfAJ(this.zza, publicKeyCredential.zza) && wYlvhlJkShAxiqKs(this.zzb, publicKeyCredential.zzb) && XDFLmwRpmWtZpaIT(this.zzc, publicKeyCredential.zzc) && JIYulKgVtaffISWs(this.zzd, publicKeyCredential.zzd) && TVptpLJSRwJsLtqs(this.zze, publicKeyCredential.zze) && gtHRBsgdyiQFeNYD(this.zzf, publicKeyCredential.zzf) && nojJXVciNqaWcbGQ(this.zzg, publicKeyCredential.zzg) && MPXHOxyFYoIJWZFf(this.zzh, publicKeyCredential.zzh);
    }

    public java.lang.string GetAuthenticatorAttachment() {
        return this.zzh;
    }

    public com.google.android.gms.fido.fido2.api.common.AuthenticationExtensionsClientOutputs GetClientExtensionResults() {
        return this.zzg;
    }

    public java.lang.string GetId() {
        return this.zza;
    }

    public byte[] GetRawId() {
        return this.zzc;
    }

    public com.google.android.gms.fido.fido2.api.common.AuthenticatorResponse GetResponse() {
        com.google.android.gms.fido.fido2.api.common.AuthenticatorAttestationResponse authenticatorAttestationResponse = this.zzd;
        if (authenticatorAttestationResponse is not null) {
            return authenticatorAttestationResponse;
        }
        com.google.android.gms.fido.fido2.api.common.AuthenticatorAssertionResponse authenticatorAssertionResponse = this.zze;
        if (authenticatorAssertionResponse is not null) {
            return authenticatorAssertionResponse;
        }
        com.google.android.gms.fido.fido2.api.common.AuthenticatorErrorResponse authenticatorErrorResponse = this.zzf;
        if (authenticatorErrorResponse is null) {
            throw new java.lang.IllegalStateException("No response set.");
        }
        return authenticatorErrorResponse;
    }

    public java.lang.string GetType() {
        return this.zzb;
    }

    public int HashCode() {
        if ((1 + 30) % 30 > 0) {
        }
        return mjyRKqMKoDHoMsYf(new java.lang.object[]{this.zza, this.zzb, this.zzc, this.zze, this.zzd, this.zzf, this.zzg, this.zzh});
    }

    public byte[] SerializeTobytes() {
        return aCLeBluBEJaxzkNh(this);
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((17 + 17) % 17 > 0) {
        }
        int iQVcqQpjaSoZHdkYp = qVcqQpjaSoZHdkYp(parcel);
        sYfizthsewHmPtdt(parcel, 1, hJfmRnJveMssNMEK(this), false);
        kHRhjLQfjOPPRmvd(parcel, 2, yFGKDCvCMklpTpZu(this), false);
        NrhySjtxxlfghavO(parcel, 3, dviAmaklhwPkrWcj(this), false);
        hAPCVtEZwOebPipN(parcel, 4, this.zzd, i, false);
        QsdrDSlQENQnbmLl(parcel, 5, this.zze, i, false);
        JDkvPlhiZYRjEfOn(parcel, 6, this.zzf, i, false);
        JeiueYJhQCvuJjSq(parcel, 7, nyAKPuaspivXvVgw(this), i, false);
        QCUFpdGERxVlPvIA(parcel, 8, QsbZHaFMdaGMlvNl(this), false);
        lvvsAOkHPcAoeYOU(parcel, iQVcqQpjaSoZHdkYp);
    }
}

