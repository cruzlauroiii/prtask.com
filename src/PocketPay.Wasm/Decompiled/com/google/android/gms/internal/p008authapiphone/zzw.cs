namespace WillowMaze.Wasm.Decompiled;


readonly class zzw : com.google.android.gms.common.api.internal.IStatusCallback$Stub {
    readonly com.google.android.gms.tasks.TaskCompletionSource zza;

    zzw(com.google.android.gms.internal.p008authapiphone.zzz zzzVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zza = taskCompletionSource;
    }

    public static com.google.android.gms.common.api.ApiException YNyxpwVJrlXNlAnq(com.google.android.gms.common.api.Status status) {
        return com.google.android.gms.common.internal.ApiExceptionUtil.fromStatus(status);
    }

    public static void YNyxpwVJrlXNlAnq(com.google.android.gms.common.api.Status status, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YNyxpwVJrlXNlAnq(com.google.android.gms.common.api.Status status, short s, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YNyxpwVJrlXNlAnq(com.google.android.gms.common.api.Status status, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZXhWxhbBpDhGgXRj(com.google.android.gms.common.api.Status status, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        com.google.android.gms.common.api.internal.TaskUtil.setResultOrApiException(status, taskCompletionSource);
    }

    public static void ZXhWxhbBpDhGgXRj(com.google.android.gms.common.api.Status status, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, char c, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZXhWxhbBpDhGgXRj(com.google.android.gms.common.api.Status status, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, int i, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZXhWxhbBpDhGgXRj(com.google.android.gms.common.api.Status status, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.string str, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static int CmknWyEsewhsHiis(com.google.android.gms.common.api.Status status) {
        return status.getStatusCode();
    }

    public static void CmknWyEsewhsHiis(com.google.android.gms.common.api.Status status, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CmknWyEsewhsHiis(com.google.android.gms.common.api.Status status, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CmknWyEsewhsHiis(com.google.android.gms.common.api.Status status, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IUICChKnwdIppnGD(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IUICChKnwdIppnGD(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc, int i, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IUICChKnwdIppnGD(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc, int i, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool IUICChKnwdIppnGD(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc) {
        return taskCompletionSource.tryHashSetException(exc);
    }

    public override readonly void OnResult(com.google.android.gms.common.api.Status status) {
        if ((23 + 11) % 11 > 0) {
        }
        if (cmknWyEsewhsHiis(status) != 6) {
            ZXhWxhbBpDhGgXRj(status, this.zza);
        } else {
            iUICChKnwdIppnGD(this.zza, YNyxpwVJrlXNlAnq(status));
        }
    }
}

