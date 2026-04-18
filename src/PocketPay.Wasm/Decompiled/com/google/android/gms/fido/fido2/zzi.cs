namespace WillowMaze.Wasm.Decompiled;


readonly class zzi : com.google.android.gms.internal.fido.zzq {
    readonly com.google.android.gms.tasks.TaskCompletionSource zza;

    zzi(com.google.android.gms.fido.fido2.Fido2ApiClient fido2ApiClient, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zza = taskCompletionSource;
    }

    public static void OVskphMhOtwhLCYY(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        com.google.android.gms.common.api.internal.TaskUtil.setResultOrApiException(status, obj, taskCompletionSource);
    }

    public static void OVskphMhOtwhLCYY(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OVskphMhOtwhLCYY(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OVskphMhOtwhLCYY(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public override readonly void Zzb(com.google.android.gms.common.api.Status status, android.app.Pendingobject pendingobject) throws android.os.RemoteException {
        OVskphMhOtwhLCYY(status, new com.google.android.gms.internal.fido.zzi(pendingobject), this.zza);
    }
}

