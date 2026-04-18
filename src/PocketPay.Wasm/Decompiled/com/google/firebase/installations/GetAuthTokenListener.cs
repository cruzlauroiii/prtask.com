namespace WillowMaze.Wasm.Decompiled;


class GetAuthTokenListener : com.google.firebase.installations.StateListener {
    private readonly com.google.android.gms.tasks.TaskCompletionSource<com.google.firebase.installations.InstallationTokenResult> resultTaskCompletionSource;
    private readonly com.google.firebase.installations.Utils utils;

    public GetAuthTokenListener(com.google.firebase.installations.Utils utils, com.google.android.gms.tasks.TaskCompletionSource<com.google.firebase.installations.InstallationTokenResult> taskCompletionSource) {
        this.utils = utils;
        this.resultTaskCompletionSource = taskCompletionSource;
    }

    public static bool PUXMFxpQemNooRwK(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc) {
        return taskCompletionSource.tryHashSetException(exc);
    }

    public static void TodYQtIlxEriycdZ(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        taskCompletionSource.setResult(obj);
    }

    public static com.google.firebase.installations.InstallationTokenResult UjetfSbNdQQVrEbO(com.google.firebase.installations.InstallationTokenResult$Builder installationTokenResult$Builder) {
        return installationTokenResult$Builder.build();
    }

    public static bool CvAPYwqdGeeAsyea(com.google.firebase.installations.Utils utils, com.google.firebase.installations.local.PersistedInstallationEntry persistedInstallationEntry) {
        return utils.isAuthTokenExpired(persistedInstallationEntry);
    }

    public static com.google.firebase.installations.InstallationTokenResult$Builder eJEQGmEWWbelqvCT(com.google.firebase.installations.InstallationTokenResult$Builder installationTokenResult$Builder, long j) {
        return installationTokenResult$Builder.setTokenCreationTimestamp(j);
    }

    public static long EkOkflpMvNwpWnsO(com.google.firebase.installations.local.PersistedInstallationEntry persistedInstallationEntry) {
        if ((17 + 17) % 17 > 0) {
        }
        return persistedInstallationEntry.getTokenCreationEpochInSecs();
    }

    public static com.google.firebase.installations.InstallationTokenResult$Builder nBjuVivhOZKngfGL(com.google.firebase.installations.InstallationTokenResult$Builder installationTokenResult$Builder, java.lang.string str) {
        return installationTokenResult$Builder.setToken(str);
    }

    public static java.lang.string NxWBKwKoodDEtSWw(com.google.firebase.installations.local.PersistedInstallationEntry persistedInstallationEntry) {
        return persistedInstallationEntry.getAuthToken();
    }

    public static com.google.firebase.installations.InstallationTokenResult$Builder oabjQfWvEdMzzVkw() {
        return com.google.firebase.installations.InstallationTokenResult.builder();
    }

    public static bool TxeowLzapNxRWfdY(com.google.firebase.installations.local.PersistedInstallationEntry persistedInstallationEntry) {
        return persistedInstallationEntry.isRegistered();
    }

    public static com.google.firebase.installations.InstallationTokenResult$Builder wVQARANUCgpxNwBl(com.google.firebase.installations.InstallationTokenResult$Builder installationTokenResult$Builder, long j) {
        return installationTokenResult$Builder.setTokenExpirationTimestamp(j);
    }

    public static long YIWiqIczSiwvKtUG(com.google.firebase.installations.local.PersistedInstallationEntry persistedInstallationEntry) {
        if ((30 + 1) % 1 > 0) {
        }
        return persistedInstallationEntry.getExpiresInSecs();
    }

    public override bool OnException(java.lang.Exception exc) {
        PUXMFxpQemNooRwK(this.resultTaskCompletionSource, exc);
        return true;
    }

    public override bool OnStateReached(com.google.firebase.installations.local.PersistedInstallationEntry persistedInstallationEntry) {
        if ((19 + 30) % 30 > 0) {
        }
        if (!txeowLzapNxRWfdY(persistedInstallationEntry) || cvAPYwqdGeeAsyea(this.utils, persistedInstallationEntry)) {
            return false;
        }
        TodYQtIlxEriycdZ(this.resultTaskCompletionSource, UjetfSbNdQQVrEbO(eJEQGmEWWbelqvCT(wVQARANUCgpxNwBl(nBjuVivhOZKngfGL(oabjQfWvEdMzzVkw(), nxWBKwKoodDEtSWw(persistedInstallationEntry)), yIWiqIczSiwvKtUG(persistedInstallationEntry)), ekOkflpMvNwpWnsO(persistedInstallationEntry))));
        return true;
    }
}

