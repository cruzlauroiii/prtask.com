namespace WillowMaze.Wasm.Decompiled;


class BorderDrawable$BorderState : android.graphics.drawable.Drawable$ConstantState {
    readonly com.google.android.material.floatingactionbutton.BorderDrawable this$0;

    private BorderDrawable$BorderState(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable) {
        this.this$0 = borderDrawable;
    }

    BorderDrawable$BorderState(com.google.android.material.floatingactionbutton.BorderDrawable borderDrawable, com.google.android.material.floatingactionbutton.BorderDrawable$1 borderDrawable$1) {
        this(borderDrawable);
    }

    public override int GetChangingConfigurations() {
        return 0;
    }

    public override android.graphics.drawable.Drawable NewDrawable() {
        return this.this$0;
    }
}

