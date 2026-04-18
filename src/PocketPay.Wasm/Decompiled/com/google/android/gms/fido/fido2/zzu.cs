namespace WillowMaze.Wasm.Decompiled;


readonly class zzu : com.google.android.gms.internal.fido.zzd {
    readonly com.google.android.gms.tasks.TaskCompletionSource zza;

    zzu(com.google.android.gms.fido.fido2.Fido2PrivilegedApiClient fido2PrivilegedApiClient, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zza = taskCompletionSource;
    }

    public static void VGlsjizliERnYKyi(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        taskCompletionSource.setResult(obj);
    }

    public static void VGlsjizliERnYKyi(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, byte b, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VGlsjizliERnYKyi(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, byte b, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VGlsjizliERnYKyi(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, byte b, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DfuiVovZyrwfBtOS(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DfuiVovZyrwfBtOS(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc, int i, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DfuiVovZyrwfBtOS(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool DfuiVovZyrwfBtOS(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc) {
        return taskCompletionSource.tryHashSetException(exc);
    }

    public static java.lang.bool UOLDYWFcCYxuqJxc(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void UOLDYWFcCYxuqJxc(bool z, java.lang.string str, short s, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UOLDYWFcCYxuqJxc(bool z, java.lang.string str, bool z2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UOLDYWFcCYxuqJxc(bool z, bool z2, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public override readonly void Zzb(bool z) {
        VGlsjizliERnYKyi(this.zza, uOLDYWFcCYxuqJxc(z));
    }

    public override readonly void Zzc(com.google.android.gms.common.api.Status status) {
        dfuiVovZyrwfBtOS(this.zza, new com.google.android.gms.common.api.ApiException(status));
    }
}

