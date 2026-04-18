namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\b\n\u0000\u001a\r\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u0087\b\u001a\r\u0010\u0000\u001a\u00020\u0001*\u00020\u0003H\u0086\b¨\u0006\u0004"}, d2 = {"toDrawable", "Landroid/graphics/drawable/ColorDrawable;", "Landroid/graphics/Color;", "", "core-ktx_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class ColorDrawableKt {
    public static readonly android.graphics.drawable.ColorDrawable ToDrawable(int i) {
        return new android.graphics.drawable.ColorDrawable(i);
    }

    public static readonly android.graphics.drawable.ColorDrawable ToDrawable(android.graphics.Color color) {
        return new android.graphics.drawable.ColorDrawable(color.toArgb());
    }
}

