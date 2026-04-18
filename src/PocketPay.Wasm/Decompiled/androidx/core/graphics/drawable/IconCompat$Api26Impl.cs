namespace WillowMaze.Wasm.Decompiled;


class IconCompat$Api26Impl {
    private IconCompat$Api26Impl() {
    }

    static android.graphics.drawable.Drawable CreateAdaptiveIconDrawable(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2) {
        return new android.graphics.drawable.AdaptiveIconDrawable(drawable, drawable2);
    }

    static android.graphics.drawable.Icon CreateWithAdaptiveBitmap(android.graphics.Bitmap bitmap) {
        return android.graphics.drawable.Icon.createWithAdaptiveBitmap(bitmap);
    }
}

