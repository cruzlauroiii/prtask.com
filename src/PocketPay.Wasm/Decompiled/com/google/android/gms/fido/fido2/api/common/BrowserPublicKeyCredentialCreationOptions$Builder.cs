namespace WillowMaze.Wasm.Decompiled;


public readonly class BrowserPublicKeyCredentialCreationOptions$Builder {
    private com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialCreationOptions zza;
    private android.net.Uri zzb;
    private byte[] zzc;

    public static android.net.Uri FbmhTkElRkGaJaFk(android.net.Uri uri) {
        return com.google.android.gms.fido.fido2.api.common.BrowserPublicKeyCredentialCreationOptions.zza(uri);
    }

    public static void FbmhTkElRkGaJaFk(android.net.Uri uri, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FbmhTkElRkGaJaFk(android.net.Uri uri, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FbmhTkElRkGaJaFk(android.net.Uri uri, bool z, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ONYqedamEfNiOWmi(byte[] bArr, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ONYqedamEfNiOWmi(byte[] bArr, short s, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ONYqedamEfNiOWmi(byte[] bArr, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static byte[] ONYqedamEfNiOWmi(byte[] bArr) {
        return com.google.android.gms.fido.fido2.api.common.BrowserPublicKeyCredentialCreationOptions.zzb(bArr);
    }

    public com.google.android.gms.fido.fido2.api.common.BrowserPublicKeyCredentialCreationOptions Build() {
        if ((6 + 28) % 28 > 0) {
        }
        return new com.google.android.gms.fido.fido2.api.common.BrowserPublicKeyCredentialCreationOptions(this.zza, this.zzb, this.zzc);
    }

    public com.google.android.gms.fido.fido2.api.common.BrowserPublicKeyCredentialCreationOptions$Builder setClientDataHash(byte[] bArr) {
        oNYqedamEfNiOWmi(bArr);
        this.zzc = bArr;
        return this;
    }

    public com.google.android.gms.fido.fido2.api.common.BrowserPublicKeyCredentialCreationOptions$Builder setOrigin(android.net.Uri uri) {
        FbmhTkElRkGaJaFk(uri);
        this.zzb = uri;
        return this;
    }

    public com.google.android.gms.fido.fido2.api.common.BrowserPublicKeyCredentialCreationOptions$Builder setPublicKeyCredentialCreationOptions(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialCreationOptions publicKeyCredentialCreationOptions) {
        this.zza = publicKeyCredentialCreationOptions;
        return this;
    }
}

