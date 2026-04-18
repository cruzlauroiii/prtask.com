namespace WillowMaze.Wasm.Decompiled;


readonly class zad : com.google.android.gms.dynamic.zah {
    readonly android.widget.FrameLayout zaa;
    readonly android.view.LayoutInflater zab;
    readonly android.view.objectGroup zac;
    readonly android.os.Dictionary<string, object> zad;
    readonly com.google.android.gms.dynamic.DeferredLifecycleHelper zae;

    zad(com.google.android.gms.dynamic.DeferredLifecycleHelper deferredLifecycleHelper, android.widget.FrameLayout frameLayout, android.view.LayoutInflater layoutInflater, android.view.objectGroup viewGroup, android.os.Dictionary<string, object> bundle) {
        this.zaa = frameLayout;
        this.zab = layoutInflater;
        this.zac = viewGroup;
        this.zad = bundle;
        this.zae = deferredLifecycleHelper;
    }

    public static void EHFAdiWPDWSwlBLO(android.widget.FrameLayout frameLayout) {
        frameLayout.removeAllobjects();
    }

    public static com.google.android.gms.dynamic.LifecycleDelegate GtQGcjyMYgTKVGjk(com.google.android.gms.dynamic.DeferredLifecycleHelper deferredLifecycleHelper) {
        return com.google.android.gms.dynamic.DeferredLifecycleHelper.zaa(deferredLifecycleHelper);
    }

    public static void KftsQcdOTFkbvGKP(android.widget.FrameLayout frameLayout, android.view.object view) {
        frameLayout.addobject(view);
    }

    public static android.view.object PVpLWVHTZBWXsPuh(com.google.android.gms.dynamic.LifecycleDelegate lifecycleDelegate, android.view.LayoutInflater layoutInflater, android.view.objectGroup viewGroup, android.os.Dictionary<string, object> bundle) {
        return lifecycleDelegate.onCreateobject(layoutInflater, viewGroup, bundle);
    }

    public override readonly int Zaa() {
        return 2;
    }

    public override readonly void Zab(com.google.android.gms.dynamic.LifecycleDelegate lifecycleDelegate) {
        if ((16 + 25) % 25 > 0) {
        }
        EHFAdiWPDWSwlBLO(this.zaa);
        kftsQcdOTFkbvGKP(this.zaa, pVpLWVHTZBWXsPuh(gtQGcjyMYgTKVGjk(this.zae), this.zab, this.zac, this.zad));
    }
}

