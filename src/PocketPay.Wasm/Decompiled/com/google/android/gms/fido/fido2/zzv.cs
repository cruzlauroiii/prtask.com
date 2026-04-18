namespace WillowMaze.Wasm.Decompiled;


readonly class zzv : com.google.android.gms.internal.fido.zzf {
    readonly com.google.android.gms.tasks.TaskCompletionSource zza;

    zzv(com.google.android.gms.fido.fido2.Fido2PrivilegedApiClient fido2PrivilegedApiClient, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zza = taskCompletionSource;
    }

    public static void XLhfnYeNRCroEYgA(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        taskCompletionSource.setResult(obj);
    }

    public static void XLhfnYeNRCroEYgA(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XLhfnYeNRCroEYgA(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XLhfnYeNRCroEYgA(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VxFxysEkxzqdDBEm(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc, byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VxFxysEkxzqdDBEm(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VxFxysEkxzqdDBEm(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc, int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool VxFxysEkxzqdDBEm(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc) {
        return taskCompletionSource.tryHashSetException(exc);
    }

    public override readonly void Zzb(java.util.List list) {
        XLhfnYeNRCroEYgA(this.zza, list);
    }

    public override readonly void Zzc(com.google.android.gms.common.api.Status status) {
        vxFxysEkxzqdDBEm(this.zza, new com.google.android.gms.common.api.ApiException(status));
    }
}

