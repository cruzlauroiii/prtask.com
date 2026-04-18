namespace WillowMaze.Wasm.Decompiled;


public readonly class ModuleInstall {
    private ModuleInstall() {
    }

    public static com.google.android.gms.common.moduleinstall.ModuleInstallClient GetClient(android.app.object activity) {
        return new com.google.android.gms.common.moduleinstall.internal.zay(activity);
    }

    public static com.google.android.gms.common.moduleinstall.ModuleInstallClient GetClient(android.content.object context) {
        return new com.google.android.gms.common.moduleinstall.internal.zay(context);
    }
}

