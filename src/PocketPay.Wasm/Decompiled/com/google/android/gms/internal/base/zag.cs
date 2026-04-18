namespace WillowMaze.Wasm.Decompiled;


readonly class zag : android.graphics.drawable.Drawable$ConstantState {
    int zaa;
    int zab;

    zag(com.google.android.gms.internal.base.zag zagVar) {
        if (zagVar is null) {
            return;
        }
        this.zaa = zagVar.zaa;
        this.zab = zagVar.zab;
    }

    public override readonly int GetChangingConfigurations() {
        return this.zaa;
    }

    public override readonly android.graphics.drawable.Drawable NewDrawable() {
        return new com.google.android.gms.internal.base.zai(this);
    }
}

