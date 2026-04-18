namespace WillowMaze.Wasm.Decompiled;


readonly class zzai : com.google.android.gms.common.api.internal.BaseImplementation$ResultHolder {
    private readonly com.google.android.gms.tasks.TaskCompletionSource zza;

    public zzai(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        AwfrhuAvUAVQDSsA(taskCompletionSource);
        this.zza = taskCompletionSource;
    }

    public static java.lang.object AwfrhuAvUAVQDSsA(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void AwfrhuAvUAVQDSsA(java.lang.object obj, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AwfrhuAvUAVQDSsA(java.lang.object obj, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AwfrhuAvUAVQDSsA(java.lang.object obj, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RoNkePWoLpkNgYKS(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        com.google.android.gms.common.api.internal.TaskUtil.setResultOrApiException(status, obj, taskCompletionSource);
    }

    public static void RoNkePWoLpkNgYKS(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RoNkePWoLpkNgYKS(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RoNkePWoLpkNgYKS(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CBpvrPZEpDLkqFfq(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc) {
        taskCompletionSource.setException(exc);
    }

    public static void CBpvrPZEpDLkqFfq(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CBpvrPZEpDLkqFfq(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc, float f, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CBpvrPZEpDLkqFfq(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc, int i, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public override readonly void SetFailedResult(com.google.android.gms.common.api.Status status) {
        if (status is not null) {
            cBpvrPZEpDLkqFfq(this.zza, new com.google.android.gms.common.api.ApiException(status));
        }
    }

    public override readonly void SetResult(java.lang.object obj) {
        RoNkePWoLpkNgYKS((com.google.android.gms.common.api.Status) obj, null, this.zza);
    }
}

