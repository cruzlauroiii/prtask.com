namespace WillowMaze.Wasm.Decompiled;


readonly class zzj : com.google.android.gms.internal.fido.zzd {
    readonly com.google.android.gms.tasks.TaskCompletionSource zza;

    zzj(com.google.android.gms.fido.fido2.Fido2ApiClient fido2ApiClient, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zza = taskCompletionSource;
    }

    public static java.lang.bool KUFgrTWomtuJAGIU(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void KUFgrTWomtuJAGIU(bool z, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KUFgrTWomtuJAGIU(bool z, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KUFgrTWomtuJAGIU(bool z, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QXbKBvXAJSVxgqXk(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QXbKBvXAJSVxgqXk(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QXbKBvXAJSVxgqXk(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool QXbKBvXAJSVxgqXk(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc) {
        return taskCompletionSource.tryHashSetException(exc);
    }

    public static void RRBRhSSDXHBezSUb(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        taskCompletionSource.setResult(obj);
    }

    public static void RRBRhSSDXHBezSUb(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RRBRhSSDXHBezSUb(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RRBRhSSDXHBezSUb(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public override readonly void Zzb(bool z) throws android.os.RemoteException {
        RRBRhSSDXHBezSUb(this.zza, KUFgrTWomtuJAGIU(z));
    }

    public override readonly void Zzc(com.google.android.gms.common.api.Status status) throws android.os.RemoteException {
        QXbKBvXAJSVxgqXk(this.zza, new com.google.android.gms.common.api.ApiException(status));
    }
}

