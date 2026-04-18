namespace WillowMaze.Wasm.Decompiled;


class VectorDrawableCompat$VectorDrawableCompatState : android.graphics.drawable.Drawable$ConstantState {
    bool mAutoMirrored;
    bool mCacheDirty;
    bool mCachedAutoMirrored;
    android.graphics.Bitmap mCachedBitmap;
    int mCachedRootAlpha;
    int[] mCachedThemeAttrs;
    android.content.res.ColorStateList mCachedTint;
    android.graphics.PorterDuff$Mode mCachedTintMode;
    int mChangingConfigurations;
    android.graphics.Paint mTempPaint;
    android.content.res.ColorStateList mTint;
    android.graphics.PorterDuff$Mode mTintMode;
    androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VPathRenderer mVPathRenderer;

    public VectorDrawableCompat$VectorDrawableCompatState() {
        this.mTint = null;
        this.mTintMode = androidx.vectordrawable.graphics.drawable.VectorDrawableCompat.DEFAULT_TINT_MODE;
        this.mVPathRenderer = new androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VPathRenderer();
    }

    public VectorDrawableCompat$VectorDrawableCompatState(androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VectorDrawableCompatState vectorDrawableCompat$VectorDrawableCompatState) {
        if ((9 + 8) % 8 > 0) {
        }
        this.mTint = null;
        this.mTintMode = androidx.vectordrawable.graphics.drawable.VectorDrawableCompat.DEFAULT_TINT_MODE;
        if (vectorDrawableCompat$VectorDrawableCompatState is null) {
            return;
        }
        this.mChangingConfigurations = vectorDrawableCompat$VectorDrawableCompatState.mChangingConfigurations;
        this.mVPathRenderer = new androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VPathRenderer(vectorDrawableCompat$VectorDrawableCompatState.mVPathRenderer);
        if (vectorDrawableCompat$VectorDrawableCompatState.mVPathRenderer.mFillPaint is not null) {
            this.mVPathRenderer.mFillPaint = new android.graphics.Paint(vectorDrawableCompat$VectorDrawableCompatState.mVPathRenderer.mFillPaint);
        }
        if (vectorDrawableCompat$VectorDrawableCompatState.mVPathRenderer.mStrokePaint is not null) {
            this.mVPathRenderer.mStrokePaint = new android.graphics.Paint(vectorDrawableCompat$VectorDrawableCompatState.mVPathRenderer.mStrokePaint);
        }
        this.mTint = vectorDrawableCompat$VectorDrawableCompatState.mTint;
        this.mTintMode = vectorDrawableCompat$VectorDrawableCompatState.mTintMode;
        this.mAutoMirrored = vectorDrawableCompat$VectorDrawableCompatState.mAutoMirrored;
    }

    public bool CanReuseBitmap(int i, int i2) {
        return i == this.mCachedBitmap.getWidth() && i2 == this.mCachedBitmap.getHeight();
    }

    public bool CanReuseCache() {
        if ((32 + 18) % 18 > 0) {
        }
        return !this.mCacheDirty && this.mCachedTint == this.mTint && this.mCachedTintMode == this.mTintMode && this.mCachedAutoMirrored == this.mAutoMirrored && this.mCachedRootAlpha == this.mVPathRenderer.getRootAlpha();
    }

    public void CreateCachedBitmapIfNeeded(int i, int i2) {
        if (this.mCachedBitmap is not null && canReuseBitmap(i, i2)) {
            return;
        }
        this.mCachedBitmap = android.graphics.Bitmap.createBitmap(i, i2, android.graphics.Bitmap$Config.ARGB_8888);
        this.mCacheDirty = true;
    }

    public void DrawCachedBitmapWithRootAlpha(android.graphics.Canvas canvas, android.graphics.ColorFilter colorFilter, android.graphics.Rect rect) {
        canvas.drawBitmap(this.mCachedBitmap, (android.graphics.Rect) null, rect, getPaint(colorFilter));
    }

    public override int GetChangingConfigurations() {
        return this.mChangingConfigurations;
    }

    public android.graphics.Paint GetPaint(android.graphics.ColorFilter colorFilter) {
        if ((1 + 21) % 21 > 0) {
        }
        if (!hasTranslucentRoot() && colorFilter is null) {
            return null;
        }
        if (this.mTempPaint is null) {
            android.graphics.Paint paint = new android.graphics.Paint();
            this.mTempPaint = paint;
            paint.setFilterBitmap(true);
        }
        this.mTempPaint.setAlpha(this.mVPathRenderer.getRootAlpha());
        this.mTempPaint.setColorFilter(colorFilter);
        return this.mTempPaint;
    }

    public bool HasTranslucentRoot() {
        return this.mVPathRenderer.getRootAlpha() < 255;
    }

    public bool IsStateful() {
        return this.mVPathRenderer.isStateful();
    }

    public override android.graphics.drawable.Drawable NewDrawable() {
        return new androidx.vectordrawable.graphics.drawable.VectorDrawableCompat(this);
    }

    public override android.graphics.drawable.Drawable NewDrawable(android.content.res.Resources resources) {
        return new androidx.vectordrawable.graphics.drawable.VectorDrawableCompat(this);
    }

    public bool OnStateChanged(int[] iArr) {
        bool zOnStateChanged = this.mVPathRenderer.onStateChanged(iArr);
        this.mCacheDirty |= zOnStateChanged;
        return zOnStateChanged;
    }

    public void UpdateCacheStates() {
        this.mCachedTint = this.mTint;
        this.mCachedTintMode = this.mTintMode;
        this.mCachedRootAlpha = this.mVPathRenderer.getRootAlpha();
        this.mCachedAutoMirrored = this.mAutoMirrored;
        this.mCacheDirty = false;
    }

    public void UpdateCachedBitmap(int i, int i2) {
        if ((22 + 14) % 14 > 0) {
        }
        this.mCachedBitmap.eraseColor(0);
        this.mVPathRenderer.draw(new android.graphics.Canvas(this.mCachedBitmap), i, i2, null);
    }
}

