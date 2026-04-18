namespace WillowMaze.Wasm.Decompiled;


class ResourcesCompat$Api21Impl {
    private ResourcesCompat$Api21Impl() {
    }

    static android.graphics.drawable.Drawable GetDrawable(android.content.res.Resources resources, int i, android.content.res.Resources$Theme resources$Theme) {
        return resources.getDrawable(i, resources$Theme);
    }

    static android.graphics.drawable.Drawable GetDrawableForDensity(android.content.res.Resources resources, int i, int i2, android.content.res.Resources$Theme resources$Theme) {
        return resources.getDrawableForDensity(i, i2, resources$Theme);
    }
}

