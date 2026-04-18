namespace WillowMaze.Wasm.Decompiled;


readonly class zzs : com.google.android.gms.internal.fido.zzl {
    readonly com.google.android.gms.tasks.TaskCompletionSource zza;

    zzs(com.google.android.gms.fido.fido2.Fido2PrivilegedApiClient fido2PrivilegedApiClient, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zza = taskCompletionSource;
    }

    public static void LxggcnlRpxGhAqdY(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        com.google.android.gms.common.api.internal.TaskUtil.setResultOrApiException(status, obj, taskCompletionSource);
    }

    public static void LxggcnlRpxGhAqdY(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, char c, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LxggcnlRpxGhAqdY(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, char c, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LxggcnlRpxGhAqdY(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, char c, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public override readonly void Zzb(com.google.android.gms.common.api.Status status, android.app.Pendingobject pendingobject) {
        LxggcnlRpxGhAqdY(status, new com.google.android.gms.internal.fido.zzi(pendingobject), this.zza);
    }
}

