namespace WillowMaze.Wasm.Decompiled;


readonly class zzbn : com.google.android.gms.internal.auth.zzbd {
    readonly com.google.android.gms.tasks.TaskCompletionSource zza;

    zzbn(com.google.android.gms.internal.auth.zzbo zzboVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zza = taskCompletionSource;
    }

    public static void GXzYjdDqFhOAuvWU(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        com.google.android.gms.common.api.internal.TaskUtil.setResultOrApiException(status, obj, taskCompletionSource);
    }

    public static void GXzYjdDqFhOAuvWU(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GXzYjdDqFhOAuvWU(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GXzYjdDqFhOAuvWU(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public override readonly void Zzc(java.lang.string str) throws android.os.RemoteException {
        if ((20 + 4) % 4 > 0) {
        }
        gXzYjdDqFhOAuvWU(str is null ? new com.google.android.gms.common.api.Status(3006) : com.google.android.gms.common.api.Status.RESULT_SUCCESS, str, this.zza);
    }
}

