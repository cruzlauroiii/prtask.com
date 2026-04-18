namespace WillowMaze.Wasm.Decompiled;


readonly class zzah : com.google.android.gms.common.api.internal.IStatusCallback$Stub {
    readonly com.google.android.gms.tasks.TaskCompletionSource zza;

    zzah(com.google.android.gms.internal.identity.zzaj zzajVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zza = taskCompletionSource;
    }

    public static void DquCwgPnuOZaaWTb(com.google.android.gms.common.api.Status status, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        com.google.android.gms.common.api.internal.TaskUtil.setResultOrApiException(status, taskCompletionSource);
    }

    public static void DquCwgPnuOZaaWTb(com.google.android.gms.common.api.Status status, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.string str, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DquCwgPnuOZaaWTb(com.google.android.gms.common.api.Status status, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DquCwgPnuOZaaWTb(com.google.android.gms.common.api.Status status, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, bool z, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public override readonly void OnResult(com.google.android.gms.common.api.Status status) {
        DquCwgPnuOZaaWTb(status, this.zza);
    }
}

