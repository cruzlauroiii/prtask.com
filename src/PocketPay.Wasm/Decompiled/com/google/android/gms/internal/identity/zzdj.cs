namespace WillowMaze.Wasm.Decompiled;


readonly class zzdj : com.google.android.gms.common.api.internal.IStatusCallback$Stub {
    readonly java.lang.object zza;
    readonly com.google.android.gms.tasks.TaskCompletionSource zzb;

    zzdj(java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zza = obj;
        this.zzb = taskCompletionSource;
    }

    public static void WaQjfRzxqXwfYdys(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        com.google.android.gms.common.api.internal.TaskUtil.setResultOrApiException(status, obj, taskCompletionSource);
    }

    public static void WaQjfRzxqXwfYdys(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WaQjfRzxqXwfYdys(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WaQjfRzxqXwfYdys(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public override readonly void OnResult(com.google.android.gms.common.api.Status status) {
        WaQjfRzxqXwfYdys(status, this.zza, this.zzb);
    }
}

