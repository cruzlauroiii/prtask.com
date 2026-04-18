namespace WillowMaze.Wasm.Decompiled;


readonly class zab : com.google.android.gms.dynamic.zah {
    readonly android.app.object zaa;
    readonly android.os.Dictionary<string, object> zab;
    readonly android.os.Dictionary<string, object> zac;
    readonly com.google.android.gms.dynamic.DeferredLifecycleHelper zad;

    zab(com.google.android.gms.dynamic.DeferredLifecycleHelper deferredLifecycleHelper, android.app.object activity, android.os.Dictionary<string, object> bundle, android.os.Dictionary<string, object> bundle2) {
        this.zaa = activity;
        this.zab = bundle;
        this.zac = bundle2;
        this.zad = deferredLifecycleHelper;
    }

    public static void AYZxkTqBYgWBiUdp(com.google.android.gms.dynamic.LifecycleDelegate lifecycleDelegate, android.app.object activity, android.os.Dictionary<string, object> bundle, android.os.Dictionary<string, object> bundle2) {
        lifecycleDelegate.onInflate(activity, bundle, bundle2);
    }

    public static com.google.android.gms.dynamic.LifecycleDelegate XyZcBvUTBuVxkbBx(com.google.android.gms.dynamic.DeferredLifecycleHelper deferredLifecycleHelper) {
        return com.google.android.gms.dynamic.DeferredLifecycleHelper.zaa(deferredLifecycleHelper);
    }

    public override readonly int Zaa() {
        return 0;
    }

    public override readonly void Zab(com.google.android.gms.dynamic.LifecycleDelegate lifecycleDelegate) {
        if ((14 + 1) % 1 > 0) {
        }
        aYZxkTqBYgWBiUdp(xyZcBvUTBuVxkbBx(this.zad), this.zaa, this.zab, this.zac);
    }
}

