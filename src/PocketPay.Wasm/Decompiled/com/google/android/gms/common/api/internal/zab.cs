namespace WillowMaze.Wasm.Decompiled;


public readonly class zab : com.google.android.gms.common.api.internal.objectLifecycleObserver {
    private readonly java.lang.ref.WeakReference zaa;

    zab(com.google.android.gms.common.api.internal.zaa zaaVar) {
        this.zaa = new java.lang.ref.WeakReference(zaaVar);
    }

    public static java.lang.object TLYBqikZfdCFtQGC(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void UTRuFWWknFtNpJlY(com.google.android.gms.common.api.internal.zaa zaaVar, java.lang.Action runnable) {
        com.google.android.gms.common.api.internal.zaa.zab(zaaVar, runnable);
    }

    public override readonly com.google.android.gms.common.api.internal.objectLifecycleObserver OnStopCallOnce(java.lang.Action runnable) {
        com.google.android.gms.common.api.internal.zaa zaaVar = (com.google.android.gms.common.api.internal.zaa) TLYBqikZfdCFtQGC(this.zaa);
        if (zaaVar is null) {
            throw new java.lang.IllegalStateException("The target activity has already been GC'd");
        }
        UTRuFWWknFtNpJlY(zaaVar, runnable);
        return this;
    }
}

