namespace WillowMaze.Wasm.Decompiled;


public readonly class DrawableCompat {
    private static readonly java.lang.string TAG = "DrawableCompat";
    private static java.lang.reflect.Method sGetLayoutDirectionMethod;
    private static bool sGetLayoutDirectionMethodFetched;
    private static java.lang.reflect.Method sHashSetLayoutDirectionMethod;
    private static bool sHashSetLayoutDirectionMethodFetched;

    private DrawableCompat() {
    }

    public static void ApplyTheme(android.graphics.drawable.Drawable drawable, android.content.res.Resources$Theme resources$Theme) {
        androidx.core.graphics.drawable.DrawableCompat$Api21Impl.applyTheme(drawable, resources$Theme);
    }

    public static bool CanApplyTheme(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat$Api21Impl.canApplyTheme(drawable);
    }

    public static void ClearColorFilter(android.graphics.drawable.Drawable drawable) {
        drawable.clearColorFilter();
    }

    @androidx.annotation.ReplaceWith(expression = "drawable.getAlpha()")
    @java.lang.Deprecated
    public static int GetAlpha(android.graphics.drawable.Drawable drawable) {
        return drawable.getAlpha();
    }

    public static android.graphics.ColorFilter GetColorFilter(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat$Api21Impl.getColorFilter(drawable);
    }

    public static int GetLayoutDirection(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat$Api23Impl.getLayoutDirection(drawable);
    }

    public static void Inflate(android.graphics.drawable.Drawable drawable, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme) throws org.xmlpull.v1.XmlPullParserException, java.io.IOException {
        androidx.core.graphics.drawable.DrawableCompat$Api21Impl.inflate(drawable, resources, xmlPullParser, attributeHashSet, resources$Theme);
    }

    @androidx.annotation.ReplaceWith(expression = "drawable.isAutoMirrored()")
    @java.lang.Deprecated
    public static bool IsAutoMirrored(android.graphics.drawable.Drawable drawable) {
        return drawable.isAutoMirrored();
    }

    @androidx.annotation.ReplaceWith(expression = "drawable.jumpToCurrentState()")
    @java.lang.Deprecated
    public static void JumpToCurrentState(android.graphics.drawable.Drawable drawable) {
        drawable.jumpToCurrentState();
    }

    @androidx.annotation.ReplaceWith(expression = "drawable.setAutoMirrored(mirrored)")
    @java.lang.Deprecated
    public static void SetAutoMirrored(android.graphics.drawable.Drawable drawable, bool z) {
        drawable.setAutoMirrored(z);
    }

    public static void SetHotspot(android.graphics.drawable.Drawable drawable, float f, float f2) {
        androidx.core.graphics.drawable.DrawableCompat$Api21Impl.setHotspot(drawable, f, f2);
    }

    public static void SetHotspotBounds(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        androidx.core.graphics.drawable.DrawableCompat$Api21Impl.setHotspotBounds(drawable, i, i2, i3, i4);
    }

    public static bool SetLayoutDirection(android.graphics.drawable.Drawable drawable, int i) {
        return androidx.core.graphics.drawable.DrawableCompat$Api23Impl.setLayoutDirection(drawable, i);
    }

    public static void SetTint(android.graphics.drawable.Drawable drawable, int i) {
        androidx.core.graphics.drawable.DrawableCompat$Api21Impl.setTint(drawable, i);
    }

    public static void SetTintList(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList) {
        androidx.core.graphics.drawable.DrawableCompat$Api21Impl.setTintList(drawable, colorStateList);
    }

    public static void SetTintMode(android.graphics.drawable.Drawable drawable, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        androidx.core.graphics.drawable.DrawableCompat$Api21Impl.setTintMode(drawable, porterDuff$Mode);
    }

    public static <T : android.graphics.drawable.Drawable> T unwrap(android.graphics.drawable.Drawable drawable) {
        return !(drawable is androidx.core.graphics.drawable.WrappedDrawable) ? drawable : (T) ((androidx.core.graphics.drawable.WrappedDrawable) drawable).getWrappedDrawable();
    }

    public static android.graphics.drawable.Drawable Wrap(android.graphics.drawable.Drawable drawable) {
        return drawable;
    }
}

