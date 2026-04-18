namespace WillowMaze.Wasm.Decompiled;


readonly class zby : com.google.android.gms.internal.p007authapi.zbh {
    readonly com.google.android.gms.tasks.TaskCompletionSource zba;

    zby(com.google.android.gms.internal.p007authapi.zbz zbzVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zba = taskCompletionSource;
    }

    public static void CLZZsdGQOdXredSf(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc) {
        taskCompletionSource.setException(exc);
    }

    public static void CLZZsdGQOdXredSf(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc, char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CLZZsdGQOdXredSf(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc, int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CLZZsdGQOdXredSf(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc, short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CcVIuTMZKLimIUnB(com.google.android.gms.common.api.Status status, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CcVIuTMZKLimIUnB(com.google.android.gms.common.api.Status status, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CcVIuTMZKLimIUnB(com.google.android.gms.common.api.Status status, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool CcVIuTMZKLimIUnB(com.google.android.gms.common.api.Status status) {
        return status.isSuccess();
    }

    public static com.google.android.gms.common.api.ApiException HGhmRxFZQZmfDQRs(com.google.android.gms.common.api.Status status) {
        return com.google.android.gms.common.internal.ApiExceptionUtil.fromStatus(status);
    }

    public static void HGhmRxFZQZmfDQRs(com.google.android.gms.common.api.Status status, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HGhmRxFZQZmfDQRs(com.google.android.gms.common.api.Status status, byte b, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HGhmRxFZQZmfDQRs(com.google.android.gms.common.api.Status status, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PDIxZSsxNCykYXBi(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        taskCompletionSource.setResult(obj);
    }

    public static void PDIxZSsxNCykYXBi(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PDIxZSsxNCykYXBi(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PDIxZSsxNCykYXBi(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public override readonly void Zbb(com.google.android.gms.common.api.Status status, com.google.android.gms.auth.api.identity.AuthorizationResult authorizationResult) throws android.os.RemoteException {
        if (CcVIuTMZKLimIUnB(status)) {
            pDIxZSsxNCykYXBi(this.zba, authorizationResult);
        } else {
            CLZZsdGQOdXredSf(this.zba, HGhmRxFZQZmfDQRs(status));
        }
    }
}

