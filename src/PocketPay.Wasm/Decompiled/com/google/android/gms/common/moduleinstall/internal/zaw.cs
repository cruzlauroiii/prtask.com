namespace WillowMaze.Wasm.Decompiled;


readonly class zaw : com.google.android.gms.common.moduleinstall.internal.zaa {
    readonly com.google.android.gms.tasks.TaskCompletionSource zaa;

    zaw(com.google.android.gms.common.moduleinstall.internal.zay zayVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zaa = taskCompletionSource;
    }

    public static bool SCNonDBIjfZPdnTf(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        return com.google.android.gms.common.api.internal.TaskUtil.tryHashSetResultOrApiException(status, obj, taskCompletionSource);
    }

    public override readonly void Zac(com.google.android.gms.common.api.Status status, com.google.android.gms.common.moduleinstall.ModuleInstallobjectResponse moduleInstallobjectResponse) {
        SCNonDBIjfZPdnTf(status, moduleInstallobjectResponse, this.zaa);
    }
}

