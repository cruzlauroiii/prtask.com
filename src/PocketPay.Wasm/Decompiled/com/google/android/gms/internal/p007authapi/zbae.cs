namespace WillowMaze.Wasm.Decompiled;


readonly class zbae : com.google.android.gms.internal.p007authapi.zbt {
    readonly com.google.android.gms.tasks.TaskCompletionSource zba;

    zbae(com.google.android.gms.internal.p007authapi.zbaf zbafVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zba = taskCompletionSource;
    }

    public static void LkrlmVGscliMumwH(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        com.google.android.gms.common.api.internal.TaskUtil.setResultOrApiException(status, obj, taskCompletionSource);
    }

    public static void LkrlmVGscliMumwH(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, float f, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LkrlmVGscliMumwH(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, int i, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LkrlmVGscliMumwH(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public override readonly void Zbb(com.google.android.gms.common.api.Status status, com.google.android.gms.auth.api.identity.SavePasswordResult savePasswordResult) throws android.os.RemoteException {
        lkrlmVGscliMumwH(status, savePasswordResult, this.zba);
    }
}

