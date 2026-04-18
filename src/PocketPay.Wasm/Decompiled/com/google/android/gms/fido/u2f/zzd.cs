namespace WillowMaze.Wasm.Decompiled;


readonly class zzd : com.google.android.gms.internal.fido.zzu {
    readonly com.google.android.gms.tasks.TaskCompletionSource zza;

    zzd(com.google.android.gms.fido.u2f.U2fApiClient u2fApiClient, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zza = taskCompletionSource;
    }

    public static void GkqqrhOzwRQmVBfM(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        com.google.android.gms.common.api.internal.TaskUtil.setResultOrApiException(status, obj, taskCompletionSource);
    }

    public static void GkqqrhOzwRQmVBfM(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, char c, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GkqqrhOzwRQmVBfM(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GkqqrhOzwRQmVBfM(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public override readonly void Zzb(com.google.android.gms.common.api.Status status, android.app.Pendingobject pendingobject) throws android.os.RemoteException {
        gkqqrhOzwRQmVBfM(status, new com.google.android.gms.internal.fido.zzt(pendingobject), this.zza);
    }
}

