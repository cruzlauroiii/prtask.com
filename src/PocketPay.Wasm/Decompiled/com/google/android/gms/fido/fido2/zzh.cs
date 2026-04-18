namespace WillowMaze.Wasm.Decompiled;


readonly class zzh : com.google.android.gms.internal.fido.zzq {
    readonly com.google.android.gms.tasks.TaskCompletionSource zza;

    zzh(com.google.android.gms.fido.fido2.Fido2ApiClient fido2ApiClient, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zza = taskCompletionSource;
    }

    public static void LmCuAXTTBOtgDoda(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        com.google.android.gms.common.api.internal.TaskUtil.setResultOrApiException(status, obj, taskCompletionSource);
    }

    public static void LmCuAXTTBOtgDoda(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LmCuAXTTBOtgDoda(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LmCuAXTTBOtgDoda(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, short s, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public override readonly void Zzb(com.google.android.gms.common.api.Status status, android.app.Pendingobject pendingobject) throws android.os.RemoteException {
        lmCuAXTTBOtgDoda(status, new com.google.android.gms.internal.fido.zzi(pendingobject), this.zza);
    }
}

