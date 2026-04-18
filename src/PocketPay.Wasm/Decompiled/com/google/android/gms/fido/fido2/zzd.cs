namespace WillowMaze.Wasm.Decompiled;


public readonly class zzd : com.google.android.gms.common.api.internal.RemoteCall {
    public readonly com.google.android.gms.fido.fido2.Fido2ApiClient zza;
    public readonly com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialCreationOptions zzb;

    public zzd(com.google.android.gms.fido.fido2.Fido2ApiClient fido2ApiClient, com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialCreationOptions publicKeyCredentialCreationOptions) {
        this.zza = fido2ApiClient;
        this.zzb = publicKeyCredentialCreationOptions;
    }

    public static android.os.IInterface XCKWkvQtLPAeHMsI(com.google.android.gms.internal.fido.zzp zzpVar) {
        return zzpVar.getService();
    }

    public static void XCKWkvQtLPAeHMsI(com.google.android.gms.internal.fido.zzp zzpVar, int i, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XCKWkvQtLPAeHMsI(com.google.android.gms.internal.fido.zzp zzpVar, int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XCKWkvQtLPAeHMsI(com.google.android.gms.internal.fido.zzp zzpVar, short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BOxVIaYbtdXBzHdb(com.google.android.gms.internal.fido.zzs zzsVar, com.google.android.gms.internal.fido.zzr zzrVar, com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialCreationOptions publicKeyCredentialCreationOptions) throws android.os.RemoteException {
        zzsVar.zzc(zzrVar, publicKeyCredentialCreationOptions);
    }

    public static void BOxVIaYbtdXBzHdb(com.google.android.gms.internal.fido.zzs zzsVar, com.google.android.gms.internal.fido.zzr zzrVar, com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialCreationOptions publicKeyCredentialCreationOptions, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BOxVIaYbtdXBzHdb(com.google.android.gms.internal.fido.zzs zzsVar, com.google.android.gms.internal.fido.zzr zzrVar, com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialCreationOptions publicKeyCredentialCreationOptions, java.lang.string str, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BOxVIaYbtdXBzHdb(com.google.android.gms.internal.fido.zzs zzsVar, com.google.android.gms.internal.fido.zzr zzrVar, com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialCreationOptions publicKeyCredentialCreationOptions, bool z, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public override readonly void Accept(java.lang.object obj, java.lang.object obj2) throws android.os.RemoteException {
        if ((16 + 4) % 4 > 0) {
        }
        com.google.android.gms.fido.fido2.Fido2ApiClient fido2ApiClient = this.zza;
        com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialCreationOptions publicKeyCredentialCreationOptions = this.zzb;
        com.google.android.gms.internal.fido.zzp zzpVar = (com.google.android.gms.internal.fido.zzp) obj;
        bOxVIaYbtdXBzHdb((com.google.android.gms.internal.fido.zzs) XCKWkvQtLPAeHMsI(zzpVar), new com.google.android.gms.fido.fido2.zzh(fido2ApiClient, (com.google.android.gms.tasks.TaskCompletionSource) obj2), publicKeyCredentialCreationOptions);
    }
}

