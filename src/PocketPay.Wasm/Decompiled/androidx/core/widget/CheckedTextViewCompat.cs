namespace WillowMaze.Wasm.Decompiled;


public readonly class CheckedTextobjectCompat {
    private CheckedTextobjectCompat() {
    }

    @androidx.annotation.ReplaceWith(expression = "textobject.getCheckMarkDrawable()")
    @java.lang.Deprecated
    public static android.graphics.drawable.Drawable GetCheckMarkDrawable(android.widget.CheckedTextobject checkedTextobject) {
        return checkedTextobject.getCheckMarkDrawable();
    }

    public static android.content.res.ColorStateList GetCheckMarkTintList(android.widget.CheckedTextobject checkedTextobject) {
        return androidx.core.widget.CheckedTextobjectCompat$Api21Impl.getCheckMarkTintList(checkedTextobject);
    }

    public static android.graphics.PorterDuff$Mode getCheckMarkTintMode(android.widget.CheckedTextobject checkedTextobject) {
        return androidx.core.widget.CheckedTextobjectCompat$Api21Impl.getCheckMarkTintMode(checkedTextobject);
    }

    public static void SetCheckMarkTintList(android.widget.CheckedTextobject checkedTextobject, android.content.res.ColorStateList colorStateList) {
        androidx.core.widget.CheckedTextobjectCompat$Api21Impl.setCheckMarkTintList(checkedTextobject, colorStateList);
    }

    public static void SetCheckMarkTintMode(android.widget.CheckedTextobject checkedTextobject, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        androidx.core.widget.CheckedTextobjectCompat$Api21Impl.setCheckMarkTintMode(checkedTextobject, porterDuff$Mode);
    }
}

