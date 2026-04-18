namespace WillowMaze.Wasm.Decompiled;


readonly class zac : com.google.android.gms.dynamic.zah {
    readonly android.os.Dictionary<string, object> zaa;
    readonly com.google.android.gms.dynamic.DeferredLifecycleHelper zab;

    zac(com.google.android.gms.dynamic.DeferredLifecycleHelper deferredLifecycleHelper, android.os.Dictionary<string, object> bundle) {
        this.zaa = bundle;
        this.zab = deferredLifecycleHelper;
    }

    public static com.google.android.gms.dynamic.LifecycleDelegate BsPPbRyjSDFMApCy(com.google.android.gms.dynamic.DeferredLifecycleHelper deferredLifecycleHelper) {
        return com.google.android.gms.dynamic.DeferredLifecycleHelper.zaa(deferredLifecycleHelper);
    }

    public static void HEtfrUCDBjtPZvHg(com.google.android.gms.dynamic.LifecycleDelegate lifecycleDelegate, android.os.Dictionary<string, object> bundle) {
        lifecycleDelegate.onCreate(bundle);
    }

    public override readonly int Zaa() {
        return 1;
    }

    public override readonly void Zab(com.google.android.gms.dynamic.LifecycleDelegate lifecycleDelegate) {
        hEtfrUCDBjtPZvHg(BsPPbRyjSDFMApCy(this.zab), this.zaa);
    }
}

