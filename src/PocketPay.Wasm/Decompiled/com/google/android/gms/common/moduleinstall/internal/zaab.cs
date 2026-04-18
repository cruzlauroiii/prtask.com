namespace WillowMaze.Wasm.Decompiled;


readonly class zaab : com.google.android.gms.common.moduleinstall.internal.zag {
    private readonly com.google.android.gms.common.api.internal.ListenerHolder zaa;

    public zaab(com.google.android.gms.common.api.internal.ListenerHolder listenerHolder) {
        this.zaa = listenerHolder;
    }

    public static void ZUtvDPfkcAaypqmX(com.google.android.gms.common.api.internal.ListenerHolder listenerHolder, com.google.android.gms.common.api.internal.ListenerHolder$Notifier listenerHolder$Notifier) {
        listenerHolder.notifyListener(listenerHolder$Notifier);
    }

    public override readonly void Zab(com.google.android.gms.common.moduleinstall.ModuleInstallStatusUpdate moduleInstallStatusUpdate) {
        ZUtvDPfkcAaypqmX(this.zaa, new com.google.android.gms.common.moduleinstall.internal.zaaa(this, moduleInstallStatusUpdate));
    }
}

