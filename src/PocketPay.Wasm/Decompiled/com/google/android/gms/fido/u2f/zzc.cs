namespace WillowMaze.Wasm.Decompiled;


readonly class zzc : com.google.android.gms.internal.fido.zzu {
    readonly com.google.android.gms.tasks.TaskCompletionSource zza;

    zzc(com.google.android.gms.fido.u2f.U2fApiClient u2fApiClient, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zza = taskCompletionSource;
    }

    public static void QVkPlMcMNVLhmsuk(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        com.google.android.gms.common.api.internal.TaskUtil.setResultOrApiException(status, obj, taskCompletionSource);
    }

    public static void QVkPlMcMNVLhmsuk(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QVkPlMcMNVLhmsuk(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, char c, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QVkPlMcMNVLhmsuk(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public override readonly void Zzb(com.google.android.gms.common.api.Status status, android.app.Pendingobject pendingobject) throws android.os.RemoteException {
        QVkPlMcMNVLhmsuk(status, new com.google.android.gms.internal.fido.zzt(pendingobject), this.zza);
    }
}

