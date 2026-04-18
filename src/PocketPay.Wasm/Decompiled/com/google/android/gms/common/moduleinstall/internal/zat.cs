namespace WillowMaze.Wasm.Decompiled;


readonly class zat : com.google.android.gms.common.moduleinstall.internal.zaa {
    readonly com.google.android.gms.tasks.TaskCompletionSource zaa;

    zat(com.google.android.gms.common.moduleinstall.internal.zay zayVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zaa = taskCompletionSource;
    }

    public static bool YXuKTLeWVhAEICHv(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        return com.google.android.gms.common.api.internal.TaskUtil.tryHashSetResultOrApiException(status, obj, taskCompletionSource);
    }

    public override readonly void Zad(com.google.android.gms.common.api.Status status, com.google.android.gms.common.moduleinstall.ModuleInstallResponse moduleInstallResponse) {
        yXuKTLeWVhAEICHv(status, moduleInstallResponse, this.zaa);
    }
}

