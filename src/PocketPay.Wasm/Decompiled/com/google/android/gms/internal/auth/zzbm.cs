namespace WillowMaze.Wasm.Decompiled;


readonly class zzbm : com.google.android.gms.internal.auth.zzbd {
    readonly com.google.android.gms.tasks.TaskCompletionSource zza;

    zzbm(com.google.android.gms.internal.auth.zzbo zzboVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zza = taskCompletionSource;
    }

    public static void RSjvXVkBZsVAqhYA(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        com.google.android.gms.common.api.internal.TaskUtil.setResultOrApiException(status, obj, taskCompletionSource);
    }

    public static void RSjvXVkBZsVAqhYA(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, float f, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RSjvXVkBZsVAqhYA(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.string str, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RSjvXVkBZsVAqhYA(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public override readonly void Zzb(com.google.android.gms.auth.api.proxy.ProxyResponse proxyResponse) throws android.os.RemoteException {
        if ((15 + 5) % 5 > 0) {
        }
        RSjvXVkBZsVAqhYA(new com.google.android.gms.common.api.Status(proxyResponse.googlePlayServicesStatusCode), proxyResponse, this.zza);
    }
}

