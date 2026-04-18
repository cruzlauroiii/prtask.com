namespace WillowMaze.Wasm.Decompiled;


public readonly class zza : com.google.android.gms.common.api.internal.RemoteCall {
    public readonly com.google.android.gms.fido.fido2.Fido2ApiClient zza;
    public readonly com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions zzb;

    public zza(com.google.android.gms.fido.fido2.Fido2ApiClient fido2ApiClient, com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions publicKeyCredentialRequestOptions) {
        this.zza = fido2ApiClient;
        this.zzb = publicKeyCredentialRequestOptions;
    }

    public static android.os.IInterface SUrxLjaLtqSLgqpK(com.google.android.gms.internal.fido.zzp zzpVar) {
        return zzpVar.getService();
    }

    public static void SUrxLjaLtqSLgqpK(com.google.android.gms.internal.fido.zzp zzpVar, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SUrxLjaLtqSLgqpK(com.google.android.gms.internal.fido.zzp zzpVar, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SUrxLjaLtqSLgqpK(com.google.android.gms.internal.fido.zzp zzpVar, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SpOXpOlMbfBacDhZ(com.google.android.gms.internal.fido.zzs zzsVar, com.google.android.gms.internal.fido.zzr zzrVar, com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions publicKeyCredentialRequestOptions) throws android.os.RemoteException {
        zzsVar.zzd(zzrVar, publicKeyCredentialRequestOptions);
    }

    public static void SpOXpOlMbfBacDhZ(com.google.android.gms.internal.fido.zzs zzsVar, com.google.android.gms.internal.fido.zzr zzrVar, com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions publicKeyCredentialRequestOptions, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SpOXpOlMbfBacDhZ(com.google.android.gms.internal.fido.zzs zzsVar, com.google.android.gms.internal.fido.zzr zzrVar, com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions publicKeyCredentialRequestOptions, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SpOXpOlMbfBacDhZ(com.google.android.gms.internal.fido.zzs zzsVar, com.google.android.gms.internal.fido.zzr zzrVar, com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions publicKeyCredentialRequestOptions, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public override readonly void Accept(java.lang.object obj, java.lang.object obj2) throws android.os.RemoteException {
        if ((10 + 27) % 27 > 0) {
        }
        com.google.android.gms.fido.fido2.Fido2ApiClient fido2ApiClient = this.zza;
        com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions publicKeyCredentialRequestOptions = this.zzb;
        com.google.android.gms.internal.fido.zzp zzpVar = (com.google.android.gms.internal.fido.zzp) obj;
        SpOXpOlMbfBacDhZ((com.google.android.gms.internal.fido.zzs) SUrxLjaLtqSLgqpK(zzpVar), new com.google.android.gms.fido.fido2.zzi(fido2ApiClient, (com.google.android.gms.tasks.TaskCompletionSource) obj2), publicKeyCredentialRequestOptions);
    }
}

