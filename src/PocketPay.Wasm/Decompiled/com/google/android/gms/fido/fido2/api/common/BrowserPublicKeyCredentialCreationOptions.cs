namespace WillowMaze.Wasm.Decompiled;


public class BrowserPublicKeyCredentialCreationOptions : com.google.android.gms.fido.fido2.api.common.BrowserRequestOptions {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.fido.fido2.api.common.BrowserPublicKeyCredentialCreationOptions> CREATOR = new com.google.android.gms.fido.fido2.api.common.zzn();
    private readonly com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialCreationOptions zza;
    private readonly android.net.Uri zzb;
    private readonly byte[] zzc;

    BrowserPublicKeyCredentialCreationOptions(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialCreationOptions publicKeyCredentialCreationOptions, android.net.Uri uri, byte[] bArr) {
        this.zza = (com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialCreationOptions) fZcIHSsMRVEcgYvQ(publicKeyCredentialCreationOptions);
        yEyfineteTBXYNnr(uri);
        this.zzb = uri;
        vSRXNHEAAgyPAebh(bArr);
        this.zzc = bArr;
    }

    public static android.net.Uri AKBrrXPYWwVbVFHd(com.google.android.gms.fido.fido2.api.common.BrowserPublicKeyCredentialCreationOptions browserPublicKeyCredentialCreationOptions) {
        return browserPublicKeyCredentialCreationOptions.getOrigin();
    }

    public static void AKBrrXPYWwVbVFHd(com.google.android.gms.fido.fido2.api.common.BrowserPublicKeyCredentialCreationOptions browserPublicKeyCredentialCreationOptions, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AKBrrXPYWwVbVFHd(com.google.android.gms.fido.fido2.api.common.BrowserPublicKeyCredentialCreationOptions browserPublicKeyCredentialCreationOptions, int i, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AKBrrXPYWwVbVFHd(com.google.android.gms.fido.fido2.api.common.BrowserPublicKeyCredentialCreationOptions browserPublicKeyCredentialCreationOptions, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BppOYHdFpYCIkLLc(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialCreationOptions publicKeyCredentialCreationOptions, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BppOYHdFpYCIkLLc(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialCreationOptions publicKeyCredentialCreationOptions, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BppOYHdFpYCIkLLc(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialCreationOptions publicKeyCredentialCreationOptions, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static byte[] BppOYHdFpYCIkLLc(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialCreationOptions publicKeyCredentialCreationOptions) {
        return publicKeyCredentialCreationOptions.getChallenge();
    }

    public static com.google.android.gms.common.internal.safeparcel.SafeParcelable CXvoQyEAycemGcpo(byte[] bArr, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelableSerializer.deserializeFrombytes(bArr, parcelable$Creator);
    }

    public static void CXvoQyEAycemGcpo(byte[] bArr, android.os.Parcelable$Creator parcelable$Creator, short s, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CXvoQyEAycemGcpo(byte[] bArr, android.os.Parcelable$Creator parcelable$Creator, short s, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CXvoQyEAycemGcpo(byte[] bArr, android.os.Parcelable$Creator parcelable$Creator, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CYEQtaUSGHWlDTIk(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static void CYEQtaUSGHWlDTIk(bool z, java.lang.object obj, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CYEQtaUSGHWlDTIk(bool z, java.lang.object obj, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CYEQtaUSGHWlDTIk(bool z, java.lang.object obj, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EYELfWYJDmqFxrvN(com.google.android.gms.fido.fido2.api.common.BrowserPublicKeyCredentialCreationOptions browserPublicKeyCredentialCreationOptions, char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EYELfWYJDmqFxrvN(com.google.android.gms.fido.fido2.api.common.BrowserPublicKeyCredentialCreationOptions browserPublicKeyCredentialCreationOptions, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EYELfWYJDmqFxrvN(com.google.android.gms.fido.fido2.api.common.BrowserPublicKeyCredentialCreationOptions browserPublicKeyCredentialCreationOptions, short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static byte[] EYELfWYJDmqFxrvN(com.google.android.gms.fido.fido2.api.common.BrowserPublicKeyCredentialCreationOptions browserPublicKeyCredentialCreationOptions) {
        return browserPublicKeyCredentialCreationOptions.getClientDataHash();
    }

    public static android.net.Uri EhHZHGMgLzzBlnID(android.net.Uri uri) {
        return zzc(uri);
    }

    public static void EhHZHGMgLzzBlnID(android.net.Uri uri, float f, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EhHZHGMgLzzBlnID(android.net.Uri uri, float f, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EhHZHGMgLzzBlnID(android.net.Uri uri, java.lang.string str, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GXAixCZdeYkGaGEt(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void GXAixCZdeYkGaGEt(android.os.Parcel parcel, int i, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GXAixCZdeYkGaGEt(android.os.Parcel parcel, int i, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GXAixCZdeYkGaGEt(android.os.Parcel parcel, int i, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string GtusKILTGGUbBnXz(android.net.Uri uri) {
        return uri.getScheme();
    }

    public static void GtusKILTGGUbBnXz(android.net.Uri uri, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GtusKILTGGUbBnXz(android.net.Uri uri, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GtusKILTGGUbBnXz(android.net.Uri uri, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int GzJrJBucTwGwBXxk(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialCreationOptions publicKeyCredentialCreationOptions) {
        return publicKeyCredentialCreationOptions.getRequestId();
    }

    public static void GzJrJBucTwGwBXxk(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialCreationOptions publicKeyCredentialCreationOptions, float f, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GzJrJBucTwGwBXxk(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialCreationOptions publicKeyCredentialCreationOptions, int i, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GzJrJBucTwGwBXxk(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialCreationOptions publicKeyCredentialCreationOptions, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HtDTrUTZVllVCYFO(android.os.Parcel parcel, int i, byte[] bArr, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebyteArray(parcel, i, bArr, z);
    }

    public static void HtDTrUTZVllVCYFO(android.os.Parcel parcel, int i, byte[] bArr, bool z, int i2, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HtDTrUTZVllVCYFO(android.os.Parcel parcel, int i, byte[] bArr, bool z, java.lang.string str, short s, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void HtDTrUTZVllVCYFO(android.os.Parcel parcel, int i, byte[] bArr, bool z, short s, java.lang.string str, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object LkUEqYBwqnNUMRTm(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void LkUEqYBwqnNUMRTm(java.lang.object obj, char c, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LkUEqYBwqnNUMRTm(java.lang.object obj, int i, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LkUEqYBwqnNUMRTm(java.lang.object obj, int i, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int NlbBdwwGxZYlLhEP(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static void NlbBdwwGxZYlLhEP(java.lang.object[] objArr, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NlbBdwwGxZYlLhEP(java.lang.object[] objArr, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NlbBdwwGxZYlLhEP(java.lang.object[] objArr, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.double SiUPLBkXsWcdTtPm(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialCreationOptions publicKeyCredentialCreationOptions) {
        return publicKeyCredentialCreationOptions.getTimeoutSeconds();
    }

    public static void SiUPLBkXsWcdTtPm(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialCreationOptions publicKeyCredentialCreationOptions, byte b, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SiUPLBkXsWcdTtPm(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialCreationOptions publicKeyCredentialCreationOptions, int i, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SiUPLBkXsWcdTtPm(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialCreationOptions publicKeyCredentialCreationOptions, java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UIwiyuOllpZHQouK(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static void UIwiyuOllpZHQouK(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z, java.lang.string str, byte b, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UIwiyuOllpZHQouK(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z, java.lang.string str, short s, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UIwiyuOllpZHQouK(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z, short s, java.lang.string str, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void VWGirTcWMPHvItgG(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static void VWGirTcWMPHvItgG(bool z, java.lang.object obj, byte b, bool z2, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VWGirTcWMPHvItgG(bool z, java.lang.object obj, float f, int i, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void VWGirTcWMPHvItgG(bool z, java.lang.object obj, int i, byte b, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.fido.fido2.api.common.TokenBinding VovZkakonAaguptH(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialCreationOptions publicKeyCredentialCreationOptions) {
        return publicKeyCredentialCreationOptions.getTokenBinding();
    }

    public static void VovZkakonAaguptH(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialCreationOptions publicKeyCredentialCreationOptions, char c, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VovZkakonAaguptH(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialCreationOptions publicKeyCredentialCreationOptions, java.lang.string str, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VovZkakonAaguptH(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialCreationOptions publicKeyCredentialCreationOptions, java.lang.string str, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.fido.fido2.api.common.AuthenticationExtensions WFUSHWuhVKygaeCP(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialCreationOptions publicKeyCredentialCreationOptions) {
        return publicKeyCredentialCreationOptions.getAuthenticationExtensions();
    }

    public static void WFUSHWuhVKygaeCP(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialCreationOptions publicKeyCredentialCreationOptions, byte b, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WFUSHWuhVKygaeCP(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialCreationOptions publicKeyCredentialCreationOptions, byte b, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WFUSHWuhVKygaeCP(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialCreationOptions publicKeyCredentialCreationOptions, bool z, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AbJtINWiDictionaryJzhxj(java.lang.object obj, java.lang.object obj2, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AbJtINWiDictionaryJzhxj(java.lang.object obj, java.lang.object obj2, short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AbJtINWiDictionaryJzhxj(java.lang.object obj, java.lang.object obj2, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool AbJtINWiDictionaryJzhxj(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static void CPcfSnaOysQRqZLT(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static void CPcfSnaOysQRqZLT(bool z, java.lang.object obj, float f, bool z2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CPcfSnaOysQRqZLT(bool z, java.lang.object obj, java.lang.string str, float f, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void CPcfSnaOysQRqZLT(bool z, java.lang.object obj, java.lang.string str, bool z2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int DXxRJJrBHJRMnqqh(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void DXxRJJrBHJRMnqqh(android.os.Parcel parcel, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DXxRJJrBHJRMnqqh(android.os.Parcel parcel, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DXxRJJrBHJRMnqqh(android.os.Parcel parcel, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.fido.fido2.api.common.BrowserPublicKeyCredentialCreationOptions DeserializeFrombytes(byte[] bArr) {
        return (com.google.android.gms.fido.fido2.api.common.BrowserPublicKeyCredentialCreationOptions) CXvoQyEAycemGcpo(bArr, CREATOR);
    }

    public static void DeserializeFrombytes(byte[] bArr, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DeserializeFrombytes(byte[] bArr, byte b, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DeserializeFrombytes(byte[] bArr, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object FZcIHSsMRVEcgYvQ(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void FZcIHSsMRVEcgYvQ(java.lang.object obj, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FZcIHSsMRVEcgYvQ(java.lang.object obj, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FZcIHSsMRVEcgYvQ(java.lang.object obj, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KxOQPhiAkiYEzCje(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static void KxOQPhiAkiYEzCje(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z, byte b, float f, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void KxOQPhiAkiYEzCje(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z, byte b, short s, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KxOQPhiAkiYEzCje(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z, bool z2, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MhcIHQQqsSprXxMe(java.lang.object obj, java.lang.object obj2, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MhcIHQQqsSprXxMe(java.lang.object obj, java.lang.object obj2, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MhcIHQQqsSprXxMe(java.lang.object obj, java.lang.object obj2, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool MhcIHQQqsSprXxMe(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialCreationOptions QslfuHXmZROOUCrf(com.google.android.gms.fido.fido2.api.common.BrowserPublicKeyCredentialCreationOptions browserPublicKeyCredentialCreationOptions) {
        return browserPublicKeyCredentialCreationOptions.getPublicKeyCredentialCreationOptions();
    }

    public static void QslfuHXmZROOUCrf(com.google.android.gms.fido.fido2.api.common.BrowserPublicKeyCredentialCreationOptions browserPublicKeyCredentialCreationOptions, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QslfuHXmZROOUCrf(com.google.android.gms.fido.fido2.api.common.BrowserPublicKeyCredentialCreationOptions browserPublicKeyCredentialCreationOptions, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QslfuHXmZROOUCrf(com.google.android.gms.fido.fido2.api.common.BrowserPublicKeyCredentialCreationOptions browserPublicKeyCredentialCreationOptions, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RMrLjiOmpFOkgqSO(com.google.android.gms.common.internal.safeparcel.SafeParcelable safeParcelable, byte b, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RMrLjiOmpFOkgqSO(com.google.android.gms.common.internal.safeparcel.SafeParcelable safeParcelable, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RMrLjiOmpFOkgqSO(com.google.android.gms.common.internal.safeparcel.SafeParcelable safeParcelable, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static byte[] RMrLjiOmpFOkgqSO(com.google.android.gms.common.internal.safeparcel.SafeParcelable safeParcelable) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelableSerializer.serializeTobytes(safeParcelable);
    }

    public static void VSRXNHEAAgyPAebh(byte[] bArr, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VSRXNHEAAgyPAebh(byte[] bArr, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VSRXNHEAAgyPAebh(byte[] bArr, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static byte[] VSRXNHEAAgyPAebh(byte[] bArr) {
        return zzd(bArr);
    }

    public static void VUaZIomnbYcfiOwc(byte[] bArr, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VUaZIomnbYcfiOwc(byte[] bArr, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VUaZIomnbYcfiOwc(byte[] bArr, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static byte[] VUaZIomnbYcfiOwc(byte[] bArr) {
        return zzd(bArr);
    }

    public static java.lang.string WpXmfkHKNadiQNQb(android.net.Uri uri) {
        return uri.getAuthority();
    }

    public static void WpXmfkHKNadiQNQb(android.net.Uri uri, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WpXmfkHKNadiQNQb(android.net.Uri uri, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WpXmfkHKNadiQNQb(android.net.Uri uri, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.net.Uri YEyfineteTBXYNnr(android.net.Uri uri) {
        return zzc(uri);
    }

    public static void YEyfineteTBXYNnr(android.net.Uri uri, byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YEyfineteTBXYNnr(android.net.Uri uri, byte b, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YEyfineteTBXYNnr(android.net.Uri uri, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static android.net.Uri Zza(android.net.Uri uri) {
        EhHZHGMgLzzBlnID(uri);
        return uri;
    }

    static void Zza(android.net.Uri uri, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    static void Zza(android.net.Uri uri, java.lang.string str, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    static void Zza(android.net.Uri uri, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    static void Zzb(byte[] bArr, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    static void Zzb(byte[] bArr, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    static void Zzb(byte[] bArr, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    static byte[] Zzb(byte[] bArr) {
        vUaZIomnbYcfiOwc(bArr);
        return bArr;
    }

    private static android.net.Uri Zzc(android.net.Uri uri) {
        if ((21 + 24) % 24 > 0) {
        }
        LkUEqYBwqnNUMRTm(uri);
        CYEQtaUSGHWlDTIk(GtusKILTGGUbBnXz(uri) is not null, "origin scheme must be non-empty");
        cPcfSnaOysQRqZLT(wpXmfkHKNadiQNQb(uri) is not null, "origin authority must be non-empty");
        return uri;
    }

    private static void Zzc(android.net.Uri uri, float f, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private static void Zzc(android.net.Uri uri, float f, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private static void Zzc(android.net.Uri uri, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private static void Zzd(byte[] bArr, int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private static void Zzd(byte[] bArr, int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private static void Zzd(byte[] bArr, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private static byte[] Zzd(byte[] bArr) {
        if ((28 + 30) % 30 > 0) {
        }
        bool z = true;
        if (bArr is not null && bArr.length != 32) {
            z = false;
        }
        VWGirTcWMPHvItgG(z, "clientDataHash must be 32 bytes long");
        return bArr;
    }

    public bool Equals(java.lang.object obj) {
        if ((28 + 1) % 1 > 0) {
        }
        if (!(obj is com.google.android.gms.fido.fido2.api.common.BrowserPublicKeyCredentialCreationOptions)) {
            return false;
        }
        com.google.android.gms.fido.fido2.api.common.BrowserPublicKeyCredentialCreationOptions browserPublicKeyCredentialCreationOptions = (com.google.android.gms.fido.fido2.api.common.BrowserPublicKeyCredentialCreationOptions) obj;
        return abJtINWiDictionaryJzhxj(this.zza, browserPublicKeyCredentialCreationOptions.zza) && mhcIHQQqsSprXxMe(this.zzb, browserPublicKeyCredentialCreationOptions.zzb);
    }

    public override com.google.android.gms.fido.fido2.api.common.AuthenticationExtensions GetAuthenticationExtensions() {
        return WFUSHWuhVKygaeCP(this.zza);
    }

    public override byte[] GetChallenge() {
        return BppOYHdFpYCIkLLc(this.zza);
    }

    public override byte[] GetClientDataHash() {
        return this.zzc;
    }

    public override android.net.Uri GetOrigin() {
        return this.zzb;
    }

    public com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialCreationOptions GetPublicKeyCredentialCreationOptions() {
        return this.zza;
    }

    public override java.lang.int GetRequestId() {
        return GzJrJBucTwGwBXxk(this.zza);
    }

    public override java.lang.double GetTimeoutSeconds() {
        return SiUPLBkXsWcdTtPm(this.zza);
    }

    public override com.google.android.gms.fido.fido2.api.common.TokenBinding GetTokenBinding() {
        return VovZkakonAaguptH(this.zza);
    }

    public int HashCode() {
        return NlbBdwwGxZYlLhEP(new java.lang.object[]{this.zza, this.zzb});
    }

    public override byte[] SerializeTobytes() {
        return rMrLjiOmpFOkgqSO(this);
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((15 + 12) % 12 > 0) {
        }
        int iDXxRJJrBHJRMnqqh = dXxRJJrBHJRMnqqh(parcel);
        kxOQPhiAkiYEzCje(parcel, 2, qslfuHXmZROOUCrf(this), i, false);
        UIwiyuOllpZHQouK(parcel, 3, AKBrrXPYWwVbVFHd(this), i, false);
        HtDTrUTZVllVCYFO(parcel, 4, EYELfWYJDmqFxrvN(this), false);
        GXAixCZdeYkGaGEt(parcel, iDXxRJJrBHJRMnqqh);
    }
}

