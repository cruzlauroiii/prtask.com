namespace WillowMaze.Wasm.Decompiled;


public readonly class zzb : com.google.android.gms.common.api.internal.RemoteCall {
    public readonly com.google.android.gms.fido.u2f.U2fApiClient zza;
    public readonly com.google.android.gms.fido.u2f.api.common.RegisterRequestParams zzb;

    public zzb(com.google.android.gms.fido.u2f.U2fApiClient u2fApiClient, com.google.android.gms.fido.u2f.api.common.RegisterRequestParams registerRequestParams) {
        this.zza = u2fApiClient;
        this.zzb = registerRequestParams;
    }

    public static android.os.IInterface HERGIIqMfzZJLaNL(com.google.android.gms.internal.fido.zzy zzyVar) {
        return zzyVar.getService();
    }

    public static void HERGIIqMfzZJLaNL(com.google.android.gms.internal.fido.zzy zzyVar, byte b, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HERGIIqMfzZJLaNL(com.google.android.gms.internal.fido.zzy zzyVar, byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HERGIIqMfzZJLaNL(com.google.android.gms.internal.fido.zzy zzyVar, char c, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OJSnIftZlJoXWByY(com.google.android.gms.internal.fido.zzw zzwVar, com.google.android.gms.internal.fido.zzv zzvVar, com.google.android.gms.fido.u2f.api.common.RegisterRequestParams registerRequestParams) throws android.os.RemoteException {
        zzwVar.zzc(zzvVar, registerRequestParams);
    }

    public static void OJSnIftZlJoXWByY(com.google.android.gms.internal.fido.zzw zzwVar, com.google.android.gms.internal.fido.zzv zzvVar, com.google.android.gms.fido.u2f.api.common.RegisterRequestParams registerRequestParams, int i, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OJSnIftZlJoXWByY(com.google.android.gms.internal.fido.zzw zzwVar, com.google.android.gms.internal.fido.zzv zzvVar, com.google.android.gms.fido.u2f.api.common.RegisterRequestParams registerRequestParams, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OJSnIftZlJoXWByY(com.google.android.gms.internal.fido.zzw zzwVar, com.google.android.gms.internal.fido.zzv zzvVar, com.google.android.gms.fido.u2f.api.common.RegisterRequestParams registerRequestParams, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public override readonly void Accept(java.lang.object obj, java.lang.object obj2) throws android.os.RemoteException {
        if ((30 + 2) % 2 > 0) {
        }
        com.google.android.gms.fido.u2f.U2fApiClient u2fApiClient = this.zza;
        com.google.android.gms.fido.u2f.api.common.RegisterRequestParams registerRequestParams = this.zzb;
        com.google.android.gms.internal.fido.zzy zzyVar = (com.google.android.gms.internal.fido.zzy) obj;
        oJSnIftZlJoXWByY((com.google.android.gms.internal.fido.zzw) HERGIIqMfzZJLaNL(zzyVar), new com.google.android.gms.fido.u2f.zzc(u2fApiClient, (com.google.android.gms.tasks.TaskCompletionSource) obj2), registerRequestParams);
    }
}

