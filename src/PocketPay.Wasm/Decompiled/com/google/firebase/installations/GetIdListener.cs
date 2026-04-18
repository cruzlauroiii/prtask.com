namespace WillowMaze.Wasm.Decompiled;


class GetIdListener : com.google.firebase.installations.StateListener {
    readonly com.google.android.gms.tasks.TaskCompletionSource<java.lang.string> taskCompletionSource;

    public GetIdListener(com.google.android.gms.tasks.TaskCompletionSource<java.lang.string> taskCompletionSource) {
        this.taskCompletionSource = taskCompletionSource;
    }

    public static bool BHgYJXWtRXhKFviq(com.google.firebase.installations.local.PersistedInstallationEntry persistedInstallationEntry) {
        return persistedInstallationEntry.isUnregistered();
    }

    public static bool VhGgTGMAUHquOnVw(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        return taskCompletionSource.tryHashSetResult(obj);
    }

    public static bool XUIAZulllUOVlkTt(com.google.firebase.installations.local.PersistedInstallationEntry persistedInstallationEntry) {
        return persistedInstallationEntry.isErrored();
    }

    public static java.lang.string AefZDBpJegYnMTyj(com.google.firebase.installations.local.PersistedInstallationEntry persistedInstallationEntry) {
        return persistedInstallationEntry.getFirebaseInstallationId();
    }

    public static bool VoLKQEMBESmoYHzl(com.google.firebase.installations.local.PersistedInstallationEntry persistedInstallationEntry) {
        return persistedInstallationEntry.isRegistered();
    }

    public override bool OnException(java.lang.Exception exc) {
        return false;
    }

    public override bool OnStateReached(com.google.firebase.installations.local.PersistedInstallationEntry persistedInstallationEntry) {
        if (!BHgYJXWtRXhKFviq(persistedInstallationEntry) && !voLKQEMBESmoYHzl(persistedInstallationEntry) && !XUIAZulllUOVlkTt(persistedInstallationEntry)) {
            return false;
        }
        VhGgTGMAUHquOnVw(this.taskCompletionSource, aefZDBpJegYnMTyj(persistedInstallationEntry));
        return true;
    }
}

