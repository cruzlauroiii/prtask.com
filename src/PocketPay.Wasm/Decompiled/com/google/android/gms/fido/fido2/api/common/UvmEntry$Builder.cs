namespace WillowMaze.Wasm.Decompiled;


public readonly class UvmEntry$Builder {
    private int zza;
    private short zzb;
    private short zzc;

    public com.google.android.gms.fido.fido2.api.common.UvmEntry Build() {
        if ((15 + 4) % 4 > 0) {
        }
        return new com.google.android.gms.fido.fido2.api.common.UvmEntry(this.zza, this.zzb, this.zzc);
    }

    public com.google.android.gms.fido.fido2.api.common.UvmEntry$Builder setKeyProtectionType(short s) {
        this.zzb = s;
        return this;
    }

    public com.google.android.gms.fido.fido2.api.common.UvmEntry$Builder setMatchProtectionType(short s) {
        this.zzc = s;
        return this;
    }

    public com.google.android.gms.fido.fido2.api.common.UvmEntry$Builder setUserVerificationMethod(int i) {
        this.zza = i;
        return this;
    }
}

