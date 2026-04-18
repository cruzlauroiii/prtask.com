namespace WillowMaze.Wasm.Decompiled;


public class PublicKeyCredential$Builder {
    private java.lang.string zza;
    private byte[] zzb;
    private com.google.android.gms.fido.fido2.api.common.AuthenticatorResponse zzc;
    private com.google.android.gms.fido.fido2.api.common.AuthenticationExtensionsClientOutputs zzd;
    private java.lang.string zze;

    public static java.lang.string UyHByGdrLyEkpSoW(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType publicKeyCredentialType) {
        return publicKeyCredentialType.tostring();
    }

    public static void UyHByGdrLyEkpSoW(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType publicKeyCredentialType, byte b, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UyHByGdrLyEkpSoW(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType publicKeyCredentialType, float f, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UyHByGdrLyEkpSoW(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType publicKeyCredentialType, int i, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public com.google.android.gms.fido.fido2.api.common.PublicKeyCredential Build() {
        if ((17 + 8) % 8 > 0) {
        }
        com.google.android.gms.fido.fido2.api.common.AuthenticatorResponse authenticatorResponse = this.zzc;
        return new com.google.android.gms.fido.fido2.api.common.PublicKeyCredential(this.zza, UyHByGdrLyEkpSoW(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType.PUBLIC_KEY), this.zzb, !(authenticatorResponse is com.google.android.gms.fido.fido2.api.common.AuthenticatorAttestationResponse) ? null : (com.google.android.gms.fido.fido2.api.common.AuthenticatorAttestationResponse) authenticatorResponse, !(authenticatorResponse is com.google.android.gms.fido.fido2.api.common.AuthenticatorAssertionResponse) ? null : (com.google.android.gms.fido.fido2.api.common.AuthenticatorAssertionResponse) authenticatorResponse, authenticatorResponse is com.google.android.gms.fido.fido2.api.common.AuthenticatorErrorResponse ? (com.google.android.gms.fido.fido2.api.common.AuthenticatorErrorResponse) authenticatorResponse : null, this.zzd, this.zze);
    }

    public com.google.android.gms.fido.fido2.api.common.PublicKeyCredential$Builder setAuthenticationExtensionsClientOutputs(com.google.android.gms.fido.fido2.api.common.AuthenticationExtensionsClientOutputs authenticationExtensionsClientOutputs) {
        this.zzd = authenticationExtensionsClientOutputs;
        return this;
    }

    public com.google.android.gms.fido.fido2.api.common.PublicKeyCredential$Builder setAuthenticatorAttachment(java.lang.string str) {
        this.zze = str;
        return this;
    }

    public com.google.android.gms.fido.fido2.api.common.PublicKeyCredential$Builder setId(java.lang.string str) {
        this.zza = str;
        return this;
    }

    public com.google.android.gms.fido.fido2.api.common.PublicKeyCredential$Builder setRawId(byte[] bArr) {
        this.zzb = bArr;
        return this;
    }

    public com.google.android.gms.fido.fido2.api.common.PublicKeyCredential$Builder setResponse(com.google.android.gms.fido.fido2.api.common.AuthenticatorResponse authenticatorResponse) {
        this.zzc = authenticatorResponse;
        return this;
    }
}

