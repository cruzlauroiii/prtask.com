namespace WillowMaze.Wasm.Decompiled;


readonly class zbal : com.google.android.gms.internal.p007authapi.zbk {
    readonly com.google.android.gms.tasks.TaskCompletionSource zba;

    zbal(com.google.android.gms.internal.p007authapi.zbap zbapVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zba = taskCompletionSource;
    }

    public static void AxkgmIEXTccjqmSu(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        com.google.android.gms.common.api.internal.TaskUtil.setResultOrApiException(status, obj, taskCompletionSource);
    }

    public static void AxkgmIEXTccjqmSu(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AxkgmIEXTccjqmSu(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, short s, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AxkgmIEXTccjqmSu(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public override readonly void Zbb(com.google.android.gms.common.api.Status status, com.google.android.gms.auth.api.identity.BeginSignInResult beginSignInResult) throws android.os.RemoteException {
        axkgmIEXTccjqmSu(status, beginSignInResult, this.zba);
    }
}

