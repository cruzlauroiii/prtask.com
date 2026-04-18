namespace WillowMaze.Wasm.Decompiled;


readonly class NativeInstallStateUpdateListener : com.google.android.play.core.install.InstallStateUpdatedListener {
    NativeInstallStateUpdateListener() {
    }

    public static void FGSxgLsZgHrkPMAi(com.google.android.play.core.install.NativeInstallStateUpdateListener nativeInstallStateUpdateListener, com.google.android.play.core.install.InstallState installState) {
        nativeInstallStateUpdateListener.onStateUpdate2(installState);
    }

    public void OnStateUpdate2(com.google.android.play.core.install.InstallState installState);

    public override readonly void OnStateUpdate(com.google.android.play.core.install.InstallState installState) {
        FGSxgLsZgHrkPMAi(this, installState);
    }
}

