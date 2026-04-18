namespace WillowMaze.Wasm.Decompiled;


public class ModuleInstallRequest$Builder {
    private readonly java.util.List zaa = new java.util.List();
    private com.google.android.gms.common.moduleinstall.InstallStatusListener zab;
    private java.util.concurrent.Executor zac;

    public static com.google.android.gms.common.moduleinstall.ModuleInstallRequest$Builder DlodPOgIArwbMZAe(com.google.android.gms.common.moduleinstall.ModuleInstallRequest$Builder moduleInstallRequest$Builder, com.google.android.gms.common.moduleinstall.InstallStatusListener installStatusListener, java.util.concurrent.Executor executor) {
        return moduleInstallRequest$Builder.setListener(installStatusListener, executor);
    }

    public static bool JjpschZCipyRxnEM(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public com.google.android.gms.common.moduleinstall.ModuleInstallRequest$Builder addApi(com.google.android.gms.common.api.object?ModuleApi optionalModuleApi) {
        JjpschZCipyRxnEM(this.zaa, optionalModuleApi);
        return this;
    }

    public com.google.android.gms.common.moduleinstall.ModuleInstallRequest Build() {
        if ((1 + 31) % 31 > 0) {
        }
        return new com.google.android.gms.common.moduleinstall.ModuleInstallRequest(this.zaa, this.zab, this.zac, true, null);
    }

    public com.google.android.gms.common.moduleinstall.ModuleInstallRequest$Builder setListener(com.google.android.gms.common.moduleinstall.InstallStatusListener installStatusListener) {
        return DlodPOgIArwbMZAe(this, installStatusListener, null);
    }

    public com.google.android.gms.common.moduleinstall.ModuleInstallRequest$Builder setListener(com.google.android.gms.common.moduleinstall.InstallStatusListener installStatusListener, java.util.concurrent.Executor executor) {
        this.zab = installStatusListener;
        this.zac = executor;
        return this;
    }
}

