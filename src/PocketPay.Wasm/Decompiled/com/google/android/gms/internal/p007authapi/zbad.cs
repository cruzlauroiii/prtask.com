namespace WillowMaze.Wasm.Decompiled;


readonly class zbad : com.google.android.gms.internal.p007authapi.zbr {
    readonly com.google.android.gms.tasks.TaskCompletionSource zba;

    zbad(com.google.android.gms.internal.p007authapi.zbaf zbafVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zba = taskCompletionSource;
    }

    public static void NBWEGxngMgzAvBpc(com.google.android.gms.common.api.Status status, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NBWEGxngMgzAvBpc(com.google.android.gms.common.api.Status status, byte b, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NBWEGxngMgzAvBpc(com.google.android.gms.common.api.Status status, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool NBWEGxngMgzAvBpc(com.google.android.gms.common.api.Status status) {
        return status.isSuccess();
    }

    public static void VpTSXRzmfsOQuLLO(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc) {
        taskCompletionSource.setException(exc);
    }

    public static void VpTSXRzmfsOQuLLO(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc, int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VpTSXRzmfsOQuLLO(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc, int i, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VpTSXRzmfsOQuLLO(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MNIcgSTFgaxRIAvD(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        taskCompletionSource.setResult(obj);
    }

    public static void MNIcgSTFgaxRIAvD(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MNIcgSTFgaxRIAvD(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, short s, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MNIcgSTFgaxRIAvD(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.common.api.ApiException YLIOkIcVLTYXlxsk(com.google.android.gms.common.api.Status status) {
        return com.google.android.gms.common.internal.ApiExceptionUtil.fromStatus(status);
    }

    public static void YLIOkIcVLTYXlxsk(com.google.android.gms.common.api.Status status, int i, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YLIOkIcVLTYXlxsk(com.google.android.gms.common.api.Status status, int i, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YLIOkIcVLTYXlxsk(com.google.android.gms.common.api.Status status, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public override readonly void Zbb(com.google.android.gms.common.api.Status status, com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenResult saveAccountLinkingTokenResult) throws android.os.RemoteException {
        if (NBWEGxngMgzAvBpc(status)) {
            mNIcgSTFgaxRIAvD(this.zba, saveAccountLinkingTokenResult);
        } else {
            VpTSXRzmfsOQuLLO(this.zba, yLIOkIcVLTYXlxsk(status));
        }
    }
}

