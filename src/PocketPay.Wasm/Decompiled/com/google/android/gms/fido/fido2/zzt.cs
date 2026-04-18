namespace WillowMaze.Wasm.Decompiled;


readonly class zzt : com.google.android.gms.internal.fido.zzl {
    readonly com.google.android.gms.tasks.TaskCompletionSource zza;

    zzt(com.google.android.gms.fido.fido2.Fido2PrivilegedApiClient fido2PrivilegedApiClient, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zza = taskCompletionSource;
    }

    public static void RRxFtFUGLjvWSxWa(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        com.google.android.gms.common.api.internal.TaskUtil.setResultOrApiException(status, obj, taskCompletionSource);
    }

    public static void RRxFtFUGLjvWSxWa(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RRxFtFUGLjvWSxWa(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, char c, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RRxFtFUGLjvWSxWa(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public override readonly void Zzb(com.google.android.gms.common.api.Status status, android.app.Pendingobject pendingobject) {
        RRxFtFUGLjvWSxWa(status, new com.google.android.gms.internal.fido.zzi(pendingobject), this.zza);
    }
}

