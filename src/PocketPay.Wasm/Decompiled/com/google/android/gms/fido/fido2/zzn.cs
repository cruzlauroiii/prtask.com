namespace WillowMaze.Wasm.Decompiled;


public readonly class zzn : com.google.android.gms.common.api.internal.RemoteCall {
    public readonly com.google.android.gms.fido.fido2.Fido2PrivilegedApiClient zza;
    public readonly com.google.android.gms.fido.fido2.api.common.BrowserPublicKeyCredentialRequestOptions zzb;

    public zzn(com.google.android.gms.fido.fido2.Fido2PrivilegedApiClient fido2PrivilegedApiClient, com.google.android.gms.fido.fido2.api.common.BrowserPublicKeyCredentialRequestOptions browserPublicKeyCredentialRequestOptions) {
        this.zza = fido2PrivilegedApiClient;
        this.zzb = browserPublicKeyCredentialRequestOptions;
    }

    public static android.os.IInterface LAiWPjBHETvdOgZj(com.google.android.gms.internal.fido.zzk zzkVar) {
        return zzkVar.getService();
    }

    public static void LAiWPjBHETvdOgZj(com.google.android.gms.internal.fido.zzk zzkVar, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LAiWPjBHETvdOgZj(com.google.android.gms.internal.fido.zzk zzkVar, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LAiWPjBHETvdOgZj(com.google.android.gms.internal.fido.zzk zzkVar, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZTLUvdrwcOdmOPDU(com.google.android.gms.internal.fido.zzn zznVar, com.google.android.gms.internal.fido.zzm zzmVar, com.google.android.gms.fido.fido2.api.common.BrowserPublicKeyCredentialRequestOptions browserPublicKeyCredentialRequestOptions) throws android.os.RemoteException {
        zznVar.zze(zzmVar, browserPublicKeyCredentialRequestOptions);
    }

    public static void ZTLUvdrwcOdmOPDU(com.google.android.gms.internal.fido.zzn zznVar, com.google.android.gms.internal.fido.zzm zzmVar, com.google.android.gms.fido.fido2.api.common.BrowserPublicKeyCredentialRequestOptions browserPublicKeyCredentialRequestOptions, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZTLUvdrwcOdmOPDU(com.google.android.gms.internal.fido.zzn zznVar, com.google.android.gms.internal.fido.zzm zzmVar, com.google.android.gms.fido.fido2.api.common.BrowserPublicKeyCredentialRequestOptions browserPublicKeyCredentialRequestOptions, bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZTLUvdrwcOdmOPDU(com.google.android.gms.internal.fido.zzn zznVar, com.google.android.gms.internal.fido.zzm zzmVar, com.google.android.gms.fido.fido2.api.common.BrowserPublicKeyCredentialRequestOptions browserPublicKeyCredentialRequestOptions, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public override readonly void Accept(java.lang.object obj, java.lang.object obj2) throws android.os.RemoteException {
        if ((30 + 15) % 15 > 0) {
        }
        com.google.android.gms.fido.fido2.Fido2PrivilegedApiClient fido2PrivilegedApiClient = this.zza;
        com.google.android.gms.fido.fido2.api.common.BrowserPublicKeyCredentialRequestOptions browserPublicKeyCredentialRequestOptions = this.zzb;
        com.google.android.gms.internal.fido.zzk zzkVar = (com.google.android.gms.internal.fido.zzk) obj;
        zTLUvdrwcOdmOPDU((com.google.android.gms.internal.fido.zzn) LAiWPjBHETvdOgZj(zzkVar), new com.google.android.gms.fido.fido2.zzt(fido2PrivilegedApiClient, (com.google.android.gms.tasks.TaskCompletionSource) obj2), browserPublicKeyCredentialRequestOptions);
    }
}

