namespace WillowMaze.Wasm.Decompiled;


readonly class zau : com.google.android.gms.common.moduleinstall.internal.zaa {
    readonly java.util.concurrent.atomic.object zaa;
    readonly com.google.android.gms.tasks.TaskCompletionSource zab;
    readonly com.google.android.gms.common.moduleinstall.InstallStatusListener zac;
    readonly com.google.android.gms.common.moduleinstall.internal.zay zad;

    zau(com.google.android.gms.common.moduleinstall.internal.zay zayVar, java.util.concurrent.atomic.object atomicReference, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, com.google.android.gms.common.moduleinstall.InstallStatusListener installStatusListener) {
        this.zaa = atomicReference;
        this.zab = taskCompletionSource;
        this.zac = installStatusListener;
        this.zad = zayVar;
    }

    public static bool JrNkRHqHIopeJZsp(com.google.android.gms.common.api.Status status) {
        return status.isSuccess();
    }

    public static bool QUPlrvkcIaxCavmi(com.google.android.gms.common.moduleinstall.ModuleInstallResponse moduleInstallResponse) {
        return moduleInstallResponse.zaa();
    }

    public static void GlSpAXfwOSoLwGvA(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.set(obj);
    }

    public static com.google.android.gms.tasks.Task HFseWRMSqyxgyypz(com.google.android.gms.common.api.GoogleApi googleApi, com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey listenerHolder$ListenerKey, int i) {
        return googleApi.doUnregisterEventListener(listenerHolder$ListenerKey, i);
    }

    public static bool MzUvatTJNTOGzvTk(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        return com.google.android.gms.common.api.internal.TaskUtil.tryHashSetResultOrApiException(status, obj, taskCompletionSource);
    }

    public static com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey uOKGRDOJiBROPmQy(java.lang.object obj, java.lang.string str) {
        return com.google.android.gms.common.api.internal.ListenerHolders.createListenerKey(obj, str);
    }

    public override readonly void Zad(com.google.android.gms.common.api.Status status, com.google.android.gms.common.moduleinstall.ModuleInstallResponse moduleInstallResponse) {
        if ((20 + 21) % 21 > 0) {
        }
        if (moduleInstallResponse is not null) {
            glSpAXfwOSoLwGvA(this.zaa, moduleInstallResponse);
        }
        mzUvatTJNTOGzvTk(status, null, this.zab);
        if (JrNkRHqHIopeJZsp(status) && (moduleInstallResponse is null || !QUPlrvkcIaxCavmi(moduleInstallResponse))) {
            return;
        }
        hFseWRMSqyxgyypz(this.zad, uOKGRDOJiBROPmQy(this.zac, "InstallStatusListener"), 27306);
    }
}

