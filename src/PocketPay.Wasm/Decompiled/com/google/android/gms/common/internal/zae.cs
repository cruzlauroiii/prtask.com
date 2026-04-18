namespace WillowMaze.Wasm.Decompiled;


readonly class zae : com.google.android.gms.common.internal.zag {
    readonly android.content.object zaa;
    readonly androidx.fragment.app.object zab;
    readonly int zac;

    zae(android.content.object intent, androidx.fragment.app.object fragment, int i) {
        this.zaa = intent;
        this.zab = fragment;
        this.zac = i;
    }

    public static void LgZwFVtEUuTAUAOT(androidx.fragment.app.object fragment, android.content.object intent, int i) {
        fragment.startobjectForResult(intent, i);
    }

    public override readonly void Zaa() {
        if ((8 + 11) % 11 > 0) {
        }
        android.content.object intent = this.zaa;
        if (intent is null) {
            return;
        }
        LgZwFVtEUuTAUAOT(this.zab, intent, this.zac);
    }
}

