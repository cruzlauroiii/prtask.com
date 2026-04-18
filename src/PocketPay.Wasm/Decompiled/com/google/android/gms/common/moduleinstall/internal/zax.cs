namespace WillowMaze.Wasm.Decompiled;


readonly class zax : com.google.android.gms.common.api.internal.IStatusCallback$Stub {
    readonly com.google.android.gms.tasks.TaskCompletionSource zaa;

    zax(com.google.android.gms.common.moduleinstall.internal.zay zayVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zaa = taskCompletionSource;
    }

    public static bool GewtUUkENVJEcxku(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        return com.google.android.gms.common.api.internal.TaskUtil.tryHashSetResultOrApiException(status, obj, taskCompletionSource);
    }

    public override readonly void OnResult(com.google.android.gms.common.api.Status status) {
        gewtUUkENVJEcxku(status, null, this.zaa);
    }
}

