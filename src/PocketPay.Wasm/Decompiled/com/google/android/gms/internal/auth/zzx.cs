namespace WillowMaze.Wasm.Decompiled;


readonly class zzx : com.google.android.gms.common.api.internal.IStatusCallback$Stub {
    readonly com.google.android.gms.tasks.TaskCompletionSource zza;

    zzx(com.google.android.gms.internal.auth.zzab zzabVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zza = taskCompletionSource;
    }

    public static void TxvkpbUUdwhWNxym(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        com.google.android.gms.internal.auth.zzab.zzf(status, obj, taskCompletionSource);
    }

    public static void TxvkpbUUdwhWNxym(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TxvkpbUUdwhWNxym(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TxvkpbUUdwhWNxym(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public override readonly void OnResult(com.google.android.gms.common.api.Status status) {
        TxvkpbUUdwhWNxym(status, null, this.zza);
    }
}

