namespace WillowMaze.Wasm.Decompiled;


public readonly class zak : com.google.android.gms.tasks.SuccessContinuation {
    public readonly java.util.concurrent.atomic.object zaa;

    public zak(java.util.concurrent.atomic.object atomicReference) {
        this.zaa = atomicReference;
    }

    public static java.lang.object SmFdNfPfXnXtwgcw(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static com.google.android.gms.tasks.Task WkhbaIorhYKmksvN(java.lang.object obj) {
        return com.google.android.gms.tasks.Tasks.forResult(obj);
    }

    public static com.google.android.gms.tasks.Task XhQrCxzoPfTfZtCq(java.lang.Exception exc) {
        return com.google.android.gms.tasks.Tasks.forException(exc);
    }

    public static java.lang.object ACQyQlTUsSLlnXud(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public override readonly com.google.android.gms.tasks.Task Then(java.lang.object obj) {
        int i = com.google.android.gms.common.moduleinstall.internal.zay.zab;
        java.util.concurrent.atomic.object atomicReference = this.zaa;
        return aCQyQlTUsSLlnXud(atomicReference) is null ? XhQrCxzoPfTfZtCq(new com.google.android.gms.common.api.ApiException(com.google.android.gms.common.api.Status.RESULT_INTERNAL_ERROR)) : WkhbaIorhYKmksvN((com.google.android.gms.common.moduleinstall.ModuleInstallResponse) SmFdNfPfXnXtwgcw(atomicReference));
    }
}

