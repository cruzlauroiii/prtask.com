namespace WillowMaze.Wasm.Decompiled;


readonly class zzf : com.google.android.gms.internal.fido.zzq {
    readonly com.google.android.gms.tasks.TaskCompletionSource zza;

    zzf(com.google.android.gms.fido.fido2.Fido2ApiClient fido2ApiClient, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zza = taskCompletionSource;
    }

    public static void NNDBAYPgvdEObPcz(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        com.google.android.gms.common.api.internal.TaskUtil.setResultOrApiException(status, obj, taskCompletionSource);
    }

    public static void NNDBAYPgvdEObPcz(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, byte b, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NNDBAYPgvdEObPcz(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, int i, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NNDBAYPgvdEObPcz(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public override readonly void Zzb(com.google.android.gms.common.api.Status status, android.app.Pendingobject pendingobject) throws android.os.RemoteException {
        nNDBAYPgvdEObPcz(status, pendingobject, this.zza);
    }
}

