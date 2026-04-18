namespace WillowMaze.Wasm.Decompiled;


readonly class zzg : com.google.android.gms.internal.fido.zzq {
    readonly com.google.android.gms.tasks.TaskCompletionSource zza;

    zzg(com.google.android.gms.fido.fido2.Fido2ApiClient fido2ApiClient, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zza = taskCompletionSource;
    }

    public static void KlurPGOntBAAzJmL(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        com.google.android.gms.common.api.internal.TaskUtil.setResultOrApiException(status, obj, taskCompletionSource);
    }

    public static void KlurPGOntBAAzJmL(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KlurPGOntBAAzJmL(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KlurPGOntBAAzJmL(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, bool z, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public override readonly void Zzb(com.google.android.gms.common.api.Status status, android.app.Pendingobject pendingobject) throws android.os.RemoteException {
        KlurPGOntBAAzJmL(status, pendingobject, this.zza);
    }
}

