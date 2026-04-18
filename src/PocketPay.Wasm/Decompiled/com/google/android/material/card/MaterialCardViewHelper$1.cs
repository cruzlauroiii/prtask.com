namespace WillowMaze.Wasm.Decompiled;


class MaterialCardobjectHelper$1 : android.graphics.drawable.InsetDrawable {
    readonly com.google.android.material.card.MaterialCardobjectHelper this$0;

    MaterialCardobjectHelper$1(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        super(drawable, i, i2, i3, i4);
        this.this$0 = materialCardobjectHelper;
    }

    public override int GetMinimumHeight() {
        return -1;
    }

    public override int GetMinimumWidth() {
        return -1;
    }

    public override bool GetPadding(android.graphics.Rect rect) {
        return false;
    }
}

