namespace WillowMaze.Wasm.Decompiled;


readonly class zaaa : com.google.android.gms.common.api.internal.ListenerHolder$Notifier {
    readonly com.google.android.gms.common.moduleinstall.ModuleInstallStatusUpdate zaa;

    zaaa(com.google.android.gms.common.moduleinstall.internal.zaab zaabVar, com.google.android.gms.common.moduleinstall.ModuleInstallStatusUpdate moduleInstallStatusUpdate) {
        this.zaa = moduleInstallStatusUpdate;
    }

    public static void BXCVDankMopQjhLN(com.google.android.gms.common.moduleinstall.InstallStatusListener installStatusListener, com.google.android.gms.common.moduleinstall.ModuleInstallStatusUpdate moduleInstallStatusUpdate) {
        installStatusListener.onInstallStatusUpdated(moduleInstallStatusUpdate);
    }

    public override readonly void NotifyListener(java.lang.object obj) {
        BXCVDankMopQjhLN((com.google.android.gms.common.moduleinstall.InstallStatusListener) obj, this.zaa);
    }

    public override readonly void OnNotifyListenerFailed() {
    }
}

