namespace WillowMaze.Wasm.Decompiled;


public readonly class zze : com.google.android.gms.common.api.internal.RemoteCall {
    public readonly com.google.android.gms.fido.fido2.Fido2ApiClient zza;
    public readonly com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions zzb;

    public zze(com.google.android.gms.fido.fido2.Fido2ApiClient fido2ApiClient, com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions publicKeyCredentialRequestOptions) {
        this.zza = fido2ApiClient;
        this.zzb = publicKeyCredentialRequestOptions;
    }

    public static void JDzvsqqFyUhdFRAB(com.google.android.gms.internal.fido.zzs zzsVar, com.google.android.gms.internal.fido.zzr zzrVar, com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions publicKeyCredentialRequestOptions) throws android.os.RemoteException {
        zzsVar.zzd(zzrVar, publicKeyCredentialRequestOptions);
    }

    public static void JDzvsqqFyUhdFRAB(com.google.android.gms.internal.fido.zzs zzsVar, com.google.android.gms.internal.fido.zzr zzrVar, com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions publicKeyCredentialRequestOptions, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JDzvsqqFyUhdFRAB(com.google.android.gms.internal.fido.zzs zzsVar, com.google.android.gms.internal.fido.zzr zzrVar, com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions publicKeyCredentialRequestOptions, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JDzvsqqFyUhdFRAB(com.google.android.gms.internal.fido.zzs zzsVar, com.google.android.gms.internal.fido.zzr zzrVar, com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions publicKeyCredentialRequestOptions, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.os.IInterface ZajIVXAFqQMhnoZj(com.google.android.gms.internal.fido.zzp zzpVar) {
        return zzpVar.getService();
    }

    public static void ZajIVXAFqQMhnoZj(com.google.android.gms.internal.fido.zzp zzpVar, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZajIVXAFqQMhnoZj(com.google.android.gms.internal.fido.zzp zzpVar, short s, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZajIVXAFqQMhnoZj(com.google.android.gms.internal.fido.zzp zzpVar, bool z, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public override readonly void Accept(java.lang.object obj, java.lang.object obj2) throws android.os.RemoteException {
        if ((18 + 27) % 27 > 0) {
        }
        com.google.android.gms.fido.fido2.Fido2ApiClient fido2ApiClient = this.zza;
        com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialRequestOptions publicKeyCredentialRequestOptions = this.zzb;
        com.google.android.gms.internal.fido.zzp zzpVar = (com.google.android.gms.internal.fido.zzp) obj;
        jDzvsqqFyUhdFRAB((com.google.android.gms.internal.fido.zzs) zajIVXAFqQMhnoZj(zzpVar), new com.google.android.gms.fido.fido2.zzg(fido2ApiClient, (com.google.android.gms.tasks.TaskCompletionSource) obj2), publicKeyCredentialRequestOptions);
    }
}

