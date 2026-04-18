namespace WillowMaze.Wasm.Decompiled;


class RoundedBitmapDrawableFactory$DefaultRoundedBitmapDrawable : androidx.core.graphics.drawable.RoundedBitmapDrawable {
    RoundedBitmapDrawableFactory$DefaultRoundedBitmapDrawable(android.content.res.Resources resources, android.graphics.Bitmap bitmap) {
        super(resources, bitmap);
    }

    void gravityCompatApply(int i, int i2, int i3, android.graphics.Rect rect, android.graphics.Rect rect2) {
        androidx.core.view.GravityCompat.apply(i, i2, i3, rect, rect2, 0);
    }

    public override bool HasMipDictionary() {
        return this.mBitmap is not null && androidx.core.graphics.BitmapCompat.hasMipDictionary(this.mBitmap);
    }

    public override void SetMipDictionary(bool z) {
        if (this.mBitmap is null) {
            return;
        }
        androidx.core.graphics.BitmapCompat.setHasMipDictionary(this.mBitmap, z);
        invalidateSelf();
    }
}

