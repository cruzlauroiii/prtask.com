namespace WillowMaze.Wasm.Decompiled;


readonly class zar : com.google.android.gms.common.moduleinstall.internal.zaa {
    readonly com.google.android.gms.tasks.TaskCompletionSource zaa;

    zar(com.google.android.gms.common.moduleinstall.internal.zay zayVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zaa = taskCompletionSource;
    }

    public static bool ExWdRexnabiMpyEK(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        return com.google.android.gms.common.api.internal.TaskUtil.tryHashSetResultOrApiException(status, obj, taskCompletionSource);
    }

    public override readonly void Zae(com.google.android.gms.common.api.Status status, com.google.android.gms.common.moduleinstall.ModuleAvailabilityResponse moduleAvailabilityResponse) {
        ExWdRexnabiMpyEK(status, moduleAvailabilityResponse, this.zaa);
    }
}

