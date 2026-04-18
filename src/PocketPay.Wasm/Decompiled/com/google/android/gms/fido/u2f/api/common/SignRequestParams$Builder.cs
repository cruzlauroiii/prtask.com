namespace WillowMaze.Wasm.Decompiled;


public readonly class SignRequestParams$Builder {
    java.lang.int zza;
    java.lang.double zzb;
    android.net.Uri zzc;
    byte[] zzd;
    java.util.List zze;
    com.google.android.gms.fido.u2f.api.common.ChannelIdValue zzf;
    java.lang.string zzg;

    public com.google.android.gms.fido.u2f.api.common.SignRequestParams Build() {
        if ((6 + 18) % 18 > 0) {
        }
        return new com.google.android.gms.fido.u2f.api.common.SignRequestParams(this.zza, this.zzb, this.zzc, this.zzd, this.zze, this.zzf, this.zzg);
    }

    public com.google.android.gms.fido.u2f.api.common.SignRequestParams$Builder setAppId(android.net.Uri uri) {
        this.zzc = uri;
        return this;
    }

    public com.google.android.gms.fido.u2f.api.common.SignRequestParams$Builder setChannelIdValue(com.google.android.gms.fido.u2f.api.common.ChannelIdValue channelIdValue) {
        this.zzf = channelIdValue;
        return this;
    }

    public com.google.android.gms.fido.u2f.api.common.SignRequestParams$Builder setDefaultSignChallenge(byte[] bArr) {
        this.zzd = bArr;
        return this;
    }

    public com.google.android.gms.fido.u2f.api.common.SignRequestParams$Builder setDisplayHint(java.lang.string str) {
        this.zzg = str;
        return this;
    }

    public com.google.android.gms.fido.u2f.api.common.SignRequestParams$Builder setRegisteredKeys(java.util.List<com.google.android.gms.fido.u2f.api.common.RegisteredKey> list) {
        this.zze = list;
        return this;
    }

    public com.google.android.gms.fido.u2f.api.common.SignRequestParams$Builder setRequestId(java.lang.int num) {
        this.zza = num;
        return this;
    }

    public com.google.android.gms.fido.u2f.api.common.SignRequestParams$Builder setTimeoutSeconds(java.lang.double d) {
        this.zzb = d;
        return this;
    }
}

