namespace WillowMaze.Wasm.Decompiled;


class DrawableCompat$Api21Impl {
    private DrawableCompat$Api21Impl() {
    }

    static void ApplyTheme(android.graphics.drawable.Drawable drawable, android.content.res.Resources$Theme resources$Theme) {
        drawable.applyTheme(resources$Theme);
    }

    static bool CanApplyTheme(android.graphics.drawable.Drawable drawable) {
        return drawable.canApplyTheme();
    }

    static android.graphics.ColorFilter GetColorFilter(android.graphics.drawable.Drawable drawable) {
        return drawable.getColorFilter();
    }

    static void Inflate(android.graphics.drawable.Drawable drawable, android.content.res.Resources resources, org.xmlpull.v1.XmlPullParser xmlPullParser, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme) throws org.xmlpull.v1.XmlPullParserException, java.io.IOException {
        drawable.inflate(resources, xmlPullParser, attributeHashSet, resources$Theme);
    }

    static void SetHotspot(android.graphics.drawable.Drawable drawable, float f, float f2) {
        drawable.setHotspot(f, f2);
    }

    static void SetHotspotBounds(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setHotspotBounds(i, i2, i3, i4);
    }

    static void SetTint(android.graphics.drawable.Drawable drawable, int i) {
        drawable.setTint(i);
    }

    static void SetTintList(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList) {
        drawable.setTintList(colorStateList);
    }

    static void SetTintMode(android.graphics.drawable.Drawable drawable, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        drawable.setTintMode(porterDuff$Mode);
    }
}

