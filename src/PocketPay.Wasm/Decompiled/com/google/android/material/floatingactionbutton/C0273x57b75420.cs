namespace WillowMaze.Wasm.Decompiled;


class C0273x57b75420 : com.google.android.material.floatingactionbutton.floatingActionButtonImpl$ShadowAnimatorImpl {
    readonly com.google.android.material.floatingactionbutton.floatingActionButtonImpl this$0;

    C0273x57b75420(com.google.android.material.floatingactionbutton.floatingActionButtonImpl floatingActionButtonImpl) {
        super(floatingActionButtonImpl, null);
        this.this$0 = floatingActionButtonImpl;
    }

    protected override float GetTargetShadowSize() {
        return this.this$0.elevation + this.this$0.hoveredFocusedTranslationZ;
    }
}

