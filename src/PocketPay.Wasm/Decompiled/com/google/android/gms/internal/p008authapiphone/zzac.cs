namespace WillowMaze.Wasm.Decompiled;


readonly class zzac : com.google.android.gms.common.api.internal.IStatusCallback$Stub {
    readonly com.google.android.gms.tasks.TaskCompletionSource zza;

    zzac(com.google.android.gms.internal.p008authapiphone.zzad zzadVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zza = taskCompletionSource;
    }

    public static int FmVCfaPkoeqCLXxb(com.google.android.gms.common.api.Status status) {
        return status.getStatusCode();
    }

    public static void FmVCfaPkoeqCLXxb(com.google.android.gms.common.api.Status status, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FmVCfaPkoeqCLXxb(com.google.android.gms.common.api.Status status, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FmVCfaPkoeqCLXxb(com.google.android.gms.common.api.Status status, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MWMYhfnYVMfXqIgo(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MWMYhfnYVMfXqIgo(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MWMYhfnYVMfXqIgo(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc, bool z, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool MWMYhfnYVMfXqIgo(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc) {
        return taskCompletionSource.tryHashSetException(exc);
    }

    public static void McMSkXqkwSCTxtKY(com.google.android.gms.common.api.Status status, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        com.google.android.gms.common.api.internal.TaskUtil.setResultOrApiException(status, taskCompletionSource);
    }

    public static void McMSkXqkwSCTxtKY(com.google.android.gms.common.api.Status status, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, int i, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void McMSkXqkwSCTxtKY(com.google.android.gms.common.api.Status status, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void McMSkXqkwSCTxtKY(com.google.android.gms.common.api.Status status, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.common.api.ApiException UrsJwuJvJKCzeCUk(com.google.android.gms.common.api.Status status) {
        return com.google.android.gms.common.internal.ApiExceptionUtil.fromStatus(status);
    }

    public static void UrsJwuJvJKCzeCUk(com.google.android.gms.common.api.Status status, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UrsJwuJvJKCzeCUk(com.google.android.gms.common.api.Status status, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UrsJwuJvJKCzeCUk(com.google.android.gms.common.api.Status status, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public override readonly void OnResult(com.google.android.gms.common.api.Status status) {
        if ((15 + 6) % 6 > 0) {
        }
        if (FmVCfaPkoeqCLXxb(status) != 6) {
            mcMSkXqkwSCTxtKY(status, this.zza);
        } else {
            MWMYhfnYVMfXqIgo(this.zza, ursJwuJvJKCzeCUk(status));
        }
    }
}

