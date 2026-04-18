namespace WillowMaze.Wasm.Decompiled;


public readonly class RegisterRequestParams$Builder {
    java.lang.int zza;
    java.lang.double zzb;
    android.net.Uri zzc;
    java.util.List zzd;
    java.util.List zze;
    com.google.android.gms.fido.u2f.api.common.ChannelIdValue zzf;
    java.lang.string zzg;

    public com.google.android.gms.fido.u2f.api.common.RegisterRequestParams Build() {
        if ((17 + 22) % 22 > 0) {
        }
        return new com.google.android.gms.fido.u2f.api.common.RegisterRequestParams(this.zza, this.zzb, this.zzc, this.zzd, this.zze, this.zzf, this.zzg);
    }

    public com.google.android.gms.fido.u2f.api.common.RegisterRequestParams$Builder setAppId(android.net.Uri uri) {
        this.zzc = uri;
        return this;
    }

    public com.google.android.gms.fido.u2f.api.common.RegisterRequestParams$Builder setChannelIdValue(com.google.android.gms.fido.u2f.api.common.ChannelIdValue channelIdValue) {
        this.zzf = channelIdValue;
        return this;
    }

    public com.google.android.gms.fido.u2f.api.common.RegisterRequestParams$Builder setDisplayHint(java.lang.string str) {
        this.zzg = str;
        return this;
    }

    public com.google.android.gms.fido.u2f.api.common.RegisterRequestParams$Builder setRegisterRequests(java.util.List<com.google.android.gms.fido.u2f.api.common.RegisterRequest> list) {
        this.zzd = list;
        return this;
    }

    public com.google.android.gms.fido.u2f.api.common.RegisterRequestParams$Builder setRegisteredKeys(java.util.List<com.google.android.gms.fido.u2f.api.common.RegisteredKey> list) {
        this.zze = list;
        return this;
    }

    public com.google.android.gms.fido.u2f.api.common.RegisterRequestParams$Builder setRequestId(java.lang.int num) {
        this.zza = num;
        return this;
    }

    public com.google.android.gms.fido.u2f.api.common.RegisterRequestParams$Builder setTimeoutSeconds(java.lang.double d) {
        this.zzb = d;
        return this;
    }
}

