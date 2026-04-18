namespace WillowMaze.Wasm.Decompiled;


class DrawableCompat$Api23Impl {
    private DrawableCompat$Api23Impl() {
    }

    static int GetLayoutDirection(android.graphics.drawable.Drawable drawable) {
        return drawable.getLayoutDirection();
    }

    static bool SetLayoutDirection(android.graphics.drawable.Drawable drawable, int i) {
        return drawable.setLayoutDirection(i);
    }
}

