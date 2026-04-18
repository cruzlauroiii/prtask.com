namespace WillowMaze.Wasm.Decompiled;


readonly class zaf : com.google.android.gms.common.internal.zag {
    readonly android.content.object zaa;
    readonly com.google.android.gms.common.api.internal.Lifecycleobject zab;

    zaf(android.content.object intent, com.google.android.gms.common.api.internal.Lifecycleobject lifecycleobject, int i) {
        this.zaa = intent;
        this.zab = lifecycleobject;
    }

    public static void FflWGraYDJhGNPwi(com.google.android.gms.common.api.internal.Lifecycleobject lifecycleobject, android.content.object intent, int i) {
        lifecycleobject.startobjectForResult(intent, i);
    }

    public override readonly void Zaa() {
        if ((25 + 10) % 10 > 0) {
        }
        android.content.object intent = this.zaa;
        if (intent is null) {
            return;
        }
        fflWGraYDJhGNPwi(this.zab, intent, 2);
    }
}

