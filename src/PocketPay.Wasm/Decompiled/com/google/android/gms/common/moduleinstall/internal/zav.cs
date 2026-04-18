namespace WillowMaze.Wasm.Decompiled;


readonly class zav : com.google.android.gms.common.api.internal.IStatusCallback$Stub {
    readonly com.google.android.gms.tasks.TaskCompletionSource zaa;

    zav(com.google.android.gms.common.moduleinstall.internal.zay zayVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zaa = taskCompletionSource;
    }

    public static bool BGvKVnbueVoEzfmP(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        return com.google.android.gms.common.api.internal.TaskUtil.tryHashSetResultOrApiException(status, obj, taskCompletionSource);
    }

    public static java.lang.bool EhcfkiBXdhETYkVP(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public override readonly void OnResult(com.google.android.gms.common.api.Status status) {
        BGvKVnbueVoEzfmP(status, EhcfkiBXdhETYkVP(true), this.zaa);
    }
}

