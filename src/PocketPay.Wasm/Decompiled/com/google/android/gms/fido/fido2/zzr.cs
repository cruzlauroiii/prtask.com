namespace WillowMaze.Wasm.Decompiled;


readonly class zzr : com.google.android.gms.internal.fido.zzl {
    readonly com.google.android.gms.tasks.TaskCompletionSource zza;

    zzr(com.google.android.gms.fido.fido2.Fido2PrivilegedApiClient fido2PrivilegedApiClient, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zza = taskCompletionSource;
    }

    public static void RGuUZUAXoQjjoDww(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        com.google.android.gms.common.api.internal.TaskUtil.setResultOrApiException(status, obj, taskCompletionSource);
    }

    public static void RGuUZUAXoQjjoDww(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RGuUZUAXoQjjoDww(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RGuUZUAXoQjjoDww(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public override readonly void Zzb(com.google.android.gms.common.api.Status status, android.app.Pendingobject pendingobject) {
        rGuUZUAXoQjjoDww(status, pendingobject, this.zza);
    }
}

