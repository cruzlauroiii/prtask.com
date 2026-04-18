namespace WillowMaze.Wasm.Decompiled;


readonly class zzq : com.google.android.gms.internal.fido.zzl {
    readonly com.google.android.gms.tasks.TaskCompletionSource zza;

    zzq(com.google.android.gms.fido.fido2.Fido2PrivilegedApiClient fido2PrivilegedApiClient, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zza = taskCompletionSource;
    }

    public static void ZNdKyXeZZQuaqRfP(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        com.google.android.gms.common.api.internal.TaskUtil.setResultOrApiException(status, obj, taskCompletionSource);
    }

    public static void ZNdKyXeZZQuaqRfP(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZNdKyXeZZQuaqRfP(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZNdKyXeZZQuaqRfP(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public override readonly void Zzb(com.google.android.gms.common.api.Status status, android.app.Pendingobject pendingobject) {
        zNdKyXeZZQuaqRfP(status, pendingobject, this.zza);
    }
}

