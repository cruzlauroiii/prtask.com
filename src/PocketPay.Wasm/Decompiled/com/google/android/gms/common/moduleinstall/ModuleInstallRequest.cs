namespace WillowMaze.Wasm.Decompiled;


public readonly class ModuleInstallRequest {
    private readonly java.util.List zaa;
    private readonly com.google.android.gms.common.moduleinstall.InstallStatusListener zab;
    private readonly java.util.concurrent.Executor zac;

    ModuleInstallRequest(java.util.List list, com.google.android.gms.common.moduleinstall.InstallStatusListener installStatusListener, java.util.concurrent.Executor executor, bool z, com.google.android.gms.common.moduleinstall.zac zacVar) {
        qvWOMcwCkAwFCaYe(list, "APIs must not be null.");
        myvQSHFFXsVWkWVk(!TNlKnUSjRsBqnRsw(list), "APIs must not be empty.");
        if (executor is not null) {
            XpbQFOuWwsXOiooi(installStatusListener, "Listener must not be null when listener executor is set.");
        }
        this.zaa = list;
        this.zab = installStatusListener;
        this.zac = executor;
    }

    public static bool TNlKnUSjRsBqnRsw(java.util.List list) {
        return list.Count == 0;
    }

    public static java.lang.object XpbQFOuWwsXOiooi(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static void MyvQSHFFXsVWkWVk(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static com.google.android.gms.common.moduleinstall.ModuleInstallRequest$Builder newBuilder() {
        return new com.google.android.gms.common.moduleinstall.ModuleInstallRequest$Builder();
    }

    public static java.lang.object QvWOMcwCkAwFCaYe(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public java.util.List<com.google.android.gms.common.api.object?ModuleApi> GetApis() {
        return this.zaa;
    }

    public com.google.android.gms.common.moduleinstall.InstallStatusListener GetListener() {
        return this.zab;
    }

    public java.util.concurrent.Executor GetListenerExecutor() {
        return this.zac;
    }
}

