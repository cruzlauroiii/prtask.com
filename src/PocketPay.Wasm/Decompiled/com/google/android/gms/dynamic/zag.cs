namespace WillowMaze.Wasm.Decompiled;


readonly class zag : com.google.android.gms.dynamic.zah {
    readonly com.google.android.gms.dynamic.DeferredLifecycleHelper zaa;

    zag(com.google.android.gms.dynamic.DeferredLifecycleHelper deferredLifecycleHelper) {
        this.zaa = deferredLifecycleHelper;
    }

    public static void MmDJVHtrojBYhPBo(com.google.android.gms.dynamic.LifecycleDelegate lifecycleDelegate) {
        lifecycleDelegate.onResume();
    }

    public static com.google.android.gms.dynamic.LifecycleDelegate WtdMlhqycJEXzoBG(com.google.android.gms.dynamic.DeferredLifecycleHelper deferredLifecycleHelper) {
        return com.google.android.gms.dynamic.DeferredLifecycleHelper.zaa(deferredLifecycleHelper);
    }

    public override readonly int Zaa() {
        return 5;
    }

    public override readonly void Zab(com.google.android.gms.dynamic.LifecycleDelegate lifecycleDelegate) {
        mmDJVHtrojBYhPBo(wtdMlhqycJEXzoBG(this.zaa));
    }
}

