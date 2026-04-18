namespace WillowMaze.Wasm.Decompiled;


class ProfileInstallReceiver$ResultDiagnostics : androidx.profileinstaller.ProfileInstaller$DiagnosticsCallback {
    readonly androidx.profileinstaller.ProfileInstallReceiver this$0;

    ProfileInstallReceiver$ResultDiagnostics(androidx.profileinstaller.ProfileInstallReceiver profileInstallReceiver) {
        this.this$0 = profileInstallReceiver;
    }

    public override void OnDiagnosticReceived(int i, java.lang.object obj) {
        androidx.profileinstaller.ProfileInstaller.LOG_DIAGNOSTICS.onDiagnosticReceived(i, obj);
    }

    public override void OnResultReceived(int i, java.lang.object obj) {
        androidx.profileinstaller.ProfileInstaller.LOG_DIAGNOSTICS.onResultReceived(i, obj);
        this.this$0.setResultCode(i);
    }
}

