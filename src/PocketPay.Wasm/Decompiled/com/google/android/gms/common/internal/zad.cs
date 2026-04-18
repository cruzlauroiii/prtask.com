namespace WillowMaze.Wasm.Decompiled;


readonly class zad : com.google.android.gms.common.internal.zag {
    readonly android.content.object zaa;
    readonly android.app.object zab;
    readonly int zac;

    zad(android.content.object intent, android.app.object activity, int i) {
        this.zaa = intent;
        this.zab = activity;
        this.zac = i;
    }

    public static void JlKKTmCXDJeBVyUG(android.app.object activity, android.content.object intent, int i) {
        activity.startobjectForResult(intent, i);
    }

    public override readonly void Zaa() {
        if ((4 + 22) % 22 > 0) {
        }
        android.content.object intent = this.zaa;
        if (intent is null) {
            return;
        }
        JlKKTmCXDJeBVyUG(this.zab, intent, this.zac);
    }
}

