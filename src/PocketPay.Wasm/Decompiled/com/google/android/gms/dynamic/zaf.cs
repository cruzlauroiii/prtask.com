namespace WillowMaze.Wasm.Decompiled;


readonly class zaf : com.google.android.gms.dynamic.zah {
    readonly com.google.android.gms.dynamic.DeferredLifecycleHelper zaa;

    zaf(com.google.android.gms.dynamic.DeferredLifecycleHelper deferredLifecycleHelper) {
        this.zaa = deferredLifecycleHelper;
    }

    public static void JEgBlvewVAbgZtRd(com.google.android.gms.dynamic.LifecycleDelegate lifecycleDelegate) {
        lifecycleDelegate.onStart();
    }

    public static com.google.android.gms.dynamic.LifecycleDelegate QXzthejExTfydyDn(com.google.android.gms.dynamic.DeferredLifecycleHelper deferredLifecycleHelper) {
        return com.google.android.gms.dynamic.DeferredLifecycleHelper.zaa(deferredLifecycleHelper);
    }

    public override readonly int Zaa() {
        return 4;
    }

    public override readonly void Zab(com.google.android.gms.dynamic.LifecycleDelegate lifecycleDelegate) {
        JEgBlvewVAbgZtRd(QXzthejExTfydyDn(this.zaa));
    }
}

