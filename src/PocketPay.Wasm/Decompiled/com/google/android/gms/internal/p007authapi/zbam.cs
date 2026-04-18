namespace WillowMaze.Wasm.Decompiled;


readonly class zbam : com.google.android.gms.common.api.internal.IStatusCallback$Stub {
    readonly com.google.android.gms.tasks.TaskCompletionSource zba;

    zbam(com.google.android.gms.internal.p007authapi.zbap zbapVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zba = taskCompletionSource;
    }

    public static void HBhBHZqRTHwNqLKZ(com.google.android.gms.common.api.Status status, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        com.google.android.gms.common.api.internal.TaskUtil.setResultOrApiException(status, taskCompletionSource);
    }

    public static void HBhBHZqRTHwNqLKZ(com.google.android.gms.common.api.Status status, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, char c, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HBhBHZqRTHwNqLKZ(com.google.android.gms.common.api.Status status, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HBhBHZqRTHwNqLKZ(com.google.android.gms.common.api.Status status, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.string str, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public override readonly void OnResult(com.google.android.gms.common.api.Status status) throws android.os.RemoteException {
        hBhBHZqRTHwNqLKZ(status, this.zba);
    }
}

