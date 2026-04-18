namespace WillowMaze.Wasm.Decompiled;


public readonly class zza : com.google.android.gms.common.api.internal.RemoteCall {
    public readonly com.google.android.gms.fido.u2f.U2fApiClient zza;
    public readonly com.google.android.gms.fido.u2f.api.common.SignRequestParams zzb;

    public zza(com.google.android.gms.fido.u2f.U2fApiClient u2fApiClient, com.google.android.gms.fido.u2f.api.common.SignRequestParams signRequestParams) {
        this.zza = u2fApiClient;
        this.zzb = signRequestParams;
    }

    public static android.os.IInterface CRdpounTSTzJYynb(com.google.android.gms.internal.fido.zzy zzyVar) {
        return zzyVar.getService();
    }

    public static void CRdpounTSTzJYynb(com.google.android.gms.internal.fido.zzy zzyVar, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CRdpounTSTzJYynb(com.google.android.gms.internal.fido.zzy zzyVar, float f, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CRdpounTSTzJYynb(com.google.android.gms.internal.fido.zzy zzyVar, float f, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZhXZrzDIxxUUIGJW(com.google.android.gms.internal.fido.zzw zzwVar, com.google.android.gms.internal.fido.zzv zzvVar, com.google.android.gms.fido.u2f.api.common.SignRequestParams signRequestParams) throws android.os.RemoteException {
        zzwVar.zzd(zzvVar, signRequestParams);
    }

    public static void ZhXZrzDIxxUUIGJW(com.google.android.gms.internal.fido.zzw zzwVar, com.google.android.gms.internal.fido.zzv zzvVar, com.google.android.gms.fido.u2f.api.common.SignRequestParams signRequestParams, byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZhXZrzDIxxUUIGJW(com.google.android.gms.internal.fido.zzw zzwVar, com.google.android.gms.internal.fido.zzv zzvVar, com.google.android.gms.fido.u2f.api.common.SignRequestParams signRequestParams, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZhXZrzDIxxUUIGJW(com.google.android.gms.internal.fido.zzw zzwVar, com.google.android.gms.internal.fido.zzv zzvVar, com.google.android.gms.fido.u2f.api.common.SignRequestParams signRequestParams, int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public override readonly void Accept(java.lang.object obj, java.lang.object obj2) throws android.os.RemoteException {
        if ((15 + 19) % 19 > 0) {
        }
        com.google.android.gms.fido.u2f.U2fApiClient u2fApiClient = this.zza;
        com.google.android.gms.fido.u2f.api.common.SignRequestParams signRequestParams = this.zzb;
        com.google.android.gms.internal.fido.zzy zzyVar = (com.google.android.gms.internal.fido.zzy) obj;
        zhXZrzDIxxUUIGJW((com.google.android.gms.internal.fido.zzw) cRdpounTSTzJYynb(zzyVar), new com.google.android.gms.fido.u2f.zzd(u2fApiClient, (com.google.android.gms.tasks.TaskCompletionSource) obj2), signRequestParams);
    }
}

