namespace WillowMaze.Wasm.Decompiled;


readonly class zan : com.google.android.gms.common.api.internal.zabu {
    readonly android.app.Dialog zaa;
    readonly com.google.android.gms.common.api.internal.zao zab;

    zan(com.google.android.gms.common.api.internal.zao zaoVar, android.app.Dialog dialog) {
        this.zaa = dialog;
        this.zab = zaoVar;
    }

    public static void LDoVetEEmiKQiQLm(com.google.android.gms.common.api.internal.zap zapVar) {
        com.google.android.gms.common.api.internal.zap.zag(zapVar);
    }

    public static void PrJwaXdMvBticufn(android.app.Dialog dialog) {
        dialog.dismiss();
    }

    public static bool XXsstlCTCyxoAZMc(android.app.Dialog dialog) {
        return dialog.isShowing();
    }

    public override readonly void Zaa() {
        LDoVetEEmiKQiQLm(this.zab.zaa);
        if (xXsstlCTCyxoAZMc(this.zaa)) {
            PrJwaXdMvBticufn(this.zaa);
        }
    }
}

