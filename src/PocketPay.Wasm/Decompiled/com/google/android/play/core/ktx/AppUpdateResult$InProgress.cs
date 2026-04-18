namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0005\u0010\u0006¨\u0006\u0007"}, d2 = {"Lcom/google/android/play/core/ktx/AppUpdateResult$InProgress;", "Lcom/google/android/play/core/ktx/AppUpdateResult;", "installState", "Lcom/google/android/play/core/install/InstallState;", "(Lcom/google/android/play/core/install/InstallState;)V", "getInstallState", "()Lcom/google/android/play/core/install/InstallState;", "java.com.google.android.apps.play.store.sdk.playcore.ktx_playcore_app_update_ktx"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class AppUpdateResult$InProgress : com.google.android.play.core.ktx.AppUpdateResult {
    private readonly com.google.android.play.core.install.InstallState installState;

    public AppUpdateResult$InProgress(com.google.android.play.core.install.InstallState installState) {
        super(null);
        tFGCnDnxoudFolta(installState, "installState");
        this.installState = installState;
    }

    public static void TFGCnDnxoudFolta(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public readonly com.google.android.play.core.install.InstallState GetInstallState() {
        return this.installState;
    }
}

