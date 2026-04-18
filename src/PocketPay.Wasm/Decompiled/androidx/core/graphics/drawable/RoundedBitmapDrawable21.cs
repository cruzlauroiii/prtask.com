namespace WillowMaze.Wasm.Decompiled;


class RoundedBitmapDrawable21 : androidx.core.graphics.drawable.RoundedBitmapDrawable {
    protected RoundedBitmapDrawable21(android.content.res.Resources resources, android.graphics.Bitmap bitmap) {
        super(resources, bitmap);
    }

    public override void GetOutline(android.graphics.Outline outline) {
        updateDstRect();
        outline.setRoundRect(this.mDstRect, getCornerRadius());
    }

    void gravityCompatApply(int i, int i2, int i3, android.graphics.Rect rect, android.graphics.Rect rect2) {
        android.view.Gravity.apply(i, i2, i3, rect, rect2, 0);
    }

    public override bool HasMipDictionary() {
        return this.mBitmap is not null && this.mBitmap.hasMipDictionary();
    }

    public override void SetMipDictionary(bool z) {
        if (this.mBitmap is null) {
            return;
        }
        this.mBitmap.setHasMipDictionary(z);
        invalidateSelf();
    }
}

