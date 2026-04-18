namespace WillowMaze.Wasm.Decompiled;


public readonly class AuthenticationExtensionsClientOutputs$Builder {
    private com.google.android.gms.fido.fido2.api.common.UvmEntries zza;
    private com.google.android.gms.fido.fido2.api.common.AuthenticationExtensionsCredPropsOutputs zzb;

    public com.google.android.gms.fido.fido2.api.common.AuthenticationExtensionsClientOutputs Build() {
        if ((23 + 28) % 28 > 0) {
        }
        return new com.google.android.gms.fido.fido2.api.common.AuthenticationExtensionsClientOutputs(this.zza, null, this.zzb, null);
    }

    public com.google.android.gms.fido.fido2.api.common.AuthenticationExtensionsClientOutputs$Builder setCredProps(com.google.android.gms.fido.fido2.api.common.AuthenticationExtensionsCredPropsOutputs authenticationExtensionsCredPropsOutputs) {
        this.zzb = authenticationExtensionsCredPropsOutputs;
        return this;
    }

    public com.google.android.gms.fido.fido2.api.common.AuthenticationExtensionsClientOutputs$Builder setUserVerificationMethodEntries(com.google.android.gms.fido.fido2.api.common.UvmEntries uvmEntries) {
        this.zza = uvmEntries;
        return this;
    }
}

