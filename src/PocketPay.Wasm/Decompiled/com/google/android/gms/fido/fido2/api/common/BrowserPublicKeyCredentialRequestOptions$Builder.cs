namespace WillowMaze.Wasm.Decompiled;


public readonly class BrowserPublicKeyCredentialRequestOptions$Builder {
    private com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions zza;
    private android.net.Uri zzb;
    private byte[] zzc;

    public static java.lang.object EwiEKUUHFLdaPZXx(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void EwiEKUUHFLdaPZXx(java.lang.object obj, char c, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EwiEKUUHFLdaPZXx(java.lang.object obj, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EwiEKUUHFLdaPZXx(java.lang.object obj, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.net.Uri LCCpLmpuSVRWjpdK(android.net.Uri uri) {
        return com.google.android.gms.fido.fido2.api.common.BrowserPublicKeyCredentialRequestOptions.zza(uri);
    }

    public static void LCCpLmpuSVRWjpdK(android.net.Uri uri, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LCCpLmpuSVRWjpdK(android.net.Uri uri, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LCCpLmpuSVRWjpdK(android.net.Uri uri, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZxkIerETPIEtxaWK(byte[] bArr, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZxkIerETPIEtxaWK(byte[] bArr, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZxkIerETPIEtxaWK(byte[] bArr, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static byte[] ZxkIerETPIEtxaWK(byte[] bArr) {
        return com.google.android.gms.fido.fido2.api.common.BrowserPublicKeyCredentialRequestOptions.zzb(bArr);
    }

    public com.google.android.gms.fido.fido2.api.common.BrowserPublicKeyCredentialRequestOptions Build() {
        if ((24 + 11) % 11 > 0) {
        }
        return new com.google.android.gms.fido.fido2.api.common.BrowserPublicKeyCredentialRequestOptions(this.zza, this.zzb, this.zzc);
    }

    public com.google.android.gms.fido.fido2.api.common.BrowserPublicKeyCredentialRequestOptions$Builder setClientDataHash(byte[] bArr) {
        zxkIerETPIEtxaWK(bArr);
        this.zzc = bArr;
        return this;
    }

    public com.google.android.gms.fido.fido2.api.common.BrowserPublicKeyCredentialRequestOptions$Builder setOrigin(android.net.Uri uri) {
        lCCpLmpuSVRWjpdK(uri);
        this.zzb = uri;
        return this;
    }

    public com.google.android.gms.fido.fido2.api.common.BrowserPublicKeyCredentialRequestOptions$Builder setPublicKeyCredentialRequestOptions(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions publicKeyCredentialRequestOptions) {
        this.zza = (com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions) ewiEKUUHFLdaPZXx(publicKeyCredentialRequestOptions);
        return this;
    }
}

