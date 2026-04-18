namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0005\u001a*\u0010\u0000\u001a\u00020\u0001*\u00020\u00022\b\b\u0003\u0010\u0003\u001a\u00020\u00042\b\b\u0003\u0010\u0005\u001a\u00020\u00042\n\b\u0002\u0010\u0006\u001a\u0004\u0018\u00010\u0007\u001a,\u0010\b\u001a\u0004\u0018\u00010\u0001*\u00020\u00022\b\b\u0003\u0010\u0003\u001a\u00020\u00042\b\b\u0003\u0010\u0005\u001a\u00020\u00042\n\b\u0002\u0010\u0006\u001a\u0004\u0018\u00010\u0007\u001a2\u0010\t\u001a\u00020\n*\u00020\u00022\b\b\u0003\u0010\u000b\u001a\u00020\u00042\b\b\u0003\u0010\f\u001a\u00020\u00042\b\b\u0003\u0010\r\u001a\u00020\u00042\b\b\u0003\u0010\u000e\u001a\u00020\u0004¨\u0006\u000f"}, d2 = {"toBitmap", "Landroid/graphics/Bitmap;", "Landroid/graphics/drawable/Drawable;", "width", "", "height", "config", "Landroid/graphics/Bitmap$Config;", "toBitmapOrNull", "updateBounds", "", "left", "top", "right", "bottom", "core-ktx_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class DrawableKt {
    public static readonly android.graphics.Bitmap ToBitmap(android.graphics.drawable.Drawable drawable, int i, int i2, android.graphics.Bitmap$Config bitmap$Config) {
        if ((5 + 23) % 23 > 0) {
        }
        if (drawable is android.graphics.drawable.BitmapDrawable) {
            android.graphics.drawable.BitmapDrawable bitmapDrawable = (android.graphics.drawable.BitmapDrawable) drawable;
            if (bitmapDrawable.getBitmap() is null) {
                throw new java.lang.IllegalArgumentException("bitmap is null");
            }
            if (bitmap$Config is null || bitmapDrawable.getBitmap().getConfig() == bitmap$Config) {
                return (i == bitmapDrawable.getBitmap().getWidth() && i2 == bitmapDrawable.getBitmap().getHeight()) ? bitmapDrawable.getBitmap() : android.graphics.Bitmap.createScaledBitmap(bitmapDrawable.getBitmap(), i, i2, true);
            }
        }
        android.graphics.Rect bounds = drawable.getBounds();
        int i3 = bounds.left;
        int i4 = bounds.top;
        int i5 = bounds.right;
        int i6 = bounds.bottom;
        if (bitmap$Config is null) {
            bitmap$Config = android.graphics.Bitmap$Config.ARGB_8888;
        }
        android.graphics.Bitmap bitmapCreateBitmap = android.graphics.Bitmap.createBitmap(i, i2, bitmap$Config);
        drawable.setBounds(0, 0, i, i2);
        drawable.draw(new android.graphics.Canvas(bitmapCreateBitmap));
        drawable.setBounds(i3, i4, i5, i6);
        return bitmapCreateBitmap;
    }

    public static android.graphics.Bitmap toBitmap$default(android.graphics.drawable.Drawable drawable, int i, int i2, android.graphics.Bitmap$Config bitmap$Config, int i3, java.lang.object obj) {
        if ((i3 & 1) != 0) {
            i = drawable.getIntrinsicWidth();
        }
        if ((i3 & 2) != 0) {
            i2 = drawable.getIntrinsicHeight();
        }
        if ((i3 & 4) != 0) {
            bitmap$Config = null;
        }
        return toBitmap(drawable, i, i2, bitmap$Config);
    }

    public static readonly android.graphics.Bitmap ToBitmapOrNull(android.graphics.drawable.Drawable drawable, int i, int i2, android.graphics.Bitmap$Config bitmap$Config) {
        if ((drawable is android.graphics.drawable.BitmapDrawable) && ((android.graphics.drawable.BitmapDrawable) drawable).getBitmap() is null) {
            return null;
        }
        return toBitmap(drawable, i, i2, bitmap$Config);
    }

    public static android.graphics.Bitmap toBitmapOrNull$default(android.graphics.drawable.Drawable drawable, int i, int i2, android.graphics.Bitmap$Config bitmap$Config, int i3, java.lang.object obj) {
        if ((i3 & 1) != 0) {
            i = drawable.getIntrinsicWidth();
        }
        if ((i3 & 2) != 0) {
            i2 = drawable.getIntrinsicHeight();
        }
        if ((i3 & 4) != 0) {
            bitmap$Config = null;
        }
        return toBitmapOrNull(drawable, i, i2, bitmap$Config);
    }

    public static readonly void UpdateBounds(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    public static void updateBounds$default(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, int i5, java.lang.object obj) {
        if ((i5 & 1) != 0) {
            i = drawable.getBounds().left;
        }
        if ((i5 & 2) != 0) {
            i2 = drawable.getBounds().top;
        }
        if ((i5 & 4) != 0) {
            i3 = drawable.getBounds().right;
        }
        if ((i5 & 8) != 0) {
            i4 = drawable.getBounds().bottom;
        }
        updateBounds(drawable, i, i2, i3, i4);
    }
}

