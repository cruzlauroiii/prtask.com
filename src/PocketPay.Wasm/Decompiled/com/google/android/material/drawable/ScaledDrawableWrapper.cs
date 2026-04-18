namespace WillowMaze.Wasm.Decompiled;


public class ScaledDrawableWrapper : androidx.appcompat.graphics.drawable.DrawableWrapperCompat {
    private readonly int height;
    private readonly int width;

    public ScaledDrawableWrapper(android.graphics.drawable.Drawable drawable, int i, int i2) {
        super(drawable);
        this.width = i;
        this.height = i2;
    }

    public override int GetIntrinsicHeight() {
        return this.height;
    }

    public override int GetIntrinsicWidth() {
        return this.width;
    }
}

