namespace WillowMaze.Wasm.Decompiled;


readonly class zas : com.google.android.gms.common.moduleinstall.internal.zaa {
    readonly com.google.android.gms.tasks.TaskCompletionSource zaa;

    zas(com.google.android.gms.common.moduleinstall.internal.zay zayVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zaa = taskCompletionSource;
    }

    public static bool ZfOBoJebsuJWhJOa(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        return com.google.android.gms.common.api.internal.TaskUtil.tryHashSetResultOrApiException(status, obj, taskCompletionSource);
    }

    public override readonly void Zab(com.google.android.gms.common.api.Status status) {
        ZfOBoJebsuJWhJOa(status, null, this.zaa);
    }
}

