namespace WillowMaze.Wasm.Decompiled;


readonly class zban : com.google.android.gms.internal.p007authapi.zbp {
    readonly com.google.android.gms.tasks.TaskCompletionSource zba;

    zban(com.google.android.gms.internal.p007authapi.zbap zbapVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zba = taskCompletionSource;
    }

    public static void AurMUNoYKavpeKFS(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        com.google.android.gms.common.api.internal.TaskUtil.setResultOrApiException(status, obj, taskCompletionSource);
    }

    public static void AurMUNoYKavpeKFS(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, char c, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AurMUNoYKavpeKFS(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, char c, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AurMUNoYKavpeKFS(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.string str, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public override readonly void Zbb(com.google.android.gms.common.api.Status status, android.app.Pendingobject pendingobject) throws android.os.RemoteException {
        aurMUNoYKavpeKFS(status, pendingobject, this.zba);
    }
}

