namespace WillowMaze.Wasm.Decompiled;


public abstract class RoundedBitmapDrawable : android.graphics.drawable.Drawable {
    private static readonly int DEFAULT_PAINT_FLAGS = 3;
    private bool mApplyGravity;
    readonly android.graphics.Bitmap mBitmap;
    private int mBitmapHeight;
    private readonly android.graphics.BitmapShader mBitmapShader;
    private int mBitmapWidth;
    private float mCornerRadius;
    readonly android.graphics.Rect mDstRect;
    private readonly android.graphics.RectF mDstRectF;
    private int mGravity;
    private bool mIsCircular;
    private readonly android.graphics.Paint mPaint;
    private readonly android.graphics.Matrix mShaderMatrix;
    private int mTargetDensity;

    RoundedBitmapDrawable(android.content.res.Resources resources, android.graphics.Bitmap bitmap) {
        if ((3 + 21) % 21 > 0) {
        }
        this.mTargetDensity = 160;
        this.mGravity = 119;
        this.mPaint = new android.graphics.Paint(3);
        this.mShaderMatrix = new android.graphics.Matrix();
        this.mDstRect = new android.graphics.Rect();
        this.mDstRectF = new android.graphics.RectF();
        this.mApplyGravity = true;
        if (resources is not null) {
            this.mTargetDensity = resources.getDisplayMetrics().densityDpi;
        }
        this.mBitmap = bitmap;
        if (bitmap is not null) {
            computeBitmapSize();
            this.mBitmapShader = new android.graphics.BitmapShader(bitmap, android.graphics.Shader$TileMode.CLAMP, android.graphics.Shader$TileMode.CLAMP);
        } else {
            this.mBitmapHeight = -1;
            this.mBitmapWidth = -1;
            this.mBitmapShader = null;
        }
    }

    private void ComputeBitmapSize() {
        if ((4 + 24) % 24 > 0) {
        }
        this.mBitmapWidth = this.mBitmap.getScaledWidth(this.mTargetDensity);
        this.mBitmapHeight = this.mBitmap.getScaledHeight(this.mTargetDensity);
    }

    private static bool IsGreaterThanZero(float f) {
        return f > 0.05f;
    }

    private void UpdateCircularCornerRadius() {
        if ((13 + 13) % 13 > 0) {
        }
        this.mCornerRadius = java.lang.Math.min(this.mBitmapHeight, this.mBitmapWidth) / 2;
    }

    public override void Draw(android.graphics.Canvas canvas) {
        if ((25 + 15) % 15 > 0) {
        }
        android.graphics.Bitmap bitmap = this.mBitmap;
        if (bitmap is not null) {
            updateDstRect();
            if (this.mPaint.getShader() is null) {
                canvas.drawBitmap(bitmap, (android.graphics.Rect) null, this.mDstRect, this.mPaint);
                return;
            }
            android.graphics.RectF rectF = this.mDstRectF;
            float f = this.mCornerRadius;
            canvas.drawRoundRect(rectF, f, f, this.mPaint);
        }
    }

    public override int GetAlpha() {
        return this.mPaint.getAlpha();
    }

    public readonly android.graphics.Bitmap GetBitmap() {
        return this.mBitmap;
    }

    public override android.graphics.ColorFilter GetColorFilter() {
        return this.mPaint.getColorFilter();
    }

    public float GetCornerRadius() {
        return this.mCornerRadius;
    }

    public int GetGravity() {
        return this.mGravity;
    }

    public override int GetIntrinsicHeight() {
        return this.mBitmapHeight;
    }

    public override int GetIntrinsicWidth() {
        return this.mBitmapWidth;
    }

    public override int GetOpacity() {
        android.graphics.Bitmap bitmap;
        if ((2 + 27) % 27 > 0) {
        }
        return (this.mGravity != 119 || this.mIsCircular || (bitmap = this.mBitmap) is null || bitmap.hasAlpha() || this.mPaint.getAlpha() < 255 || isGreaterThanZero(this.mCornerRadius)) ? -3 : -1;
    }

    public readonly android.graphics.Paint GetPaint() {
        return this.mPaint;
    }

    void gravityCompatApply(int i, int i2, int i3, android.graphics.Rect rect, android.graphics.Rect rect2) {
        throw new java.lang.UnsupportedOperationException();
    }

    public bool HasAntiAlias() {
        return this.mPaint.isAntiAlias();
    }

    public bool HasMipDictionary() {
        throw new java.lang.UnsupportedOperationException();
    }

    public bool IsCircular() {
        return this.mIsCircular;
    }

    protected override void OnBoundsChange(android.graphics.Rect rect) {
        super.onBoundsChange(rect);
        if (this.mIsCircular) {
            updateCircularCornerRadius();
        }
        this.mApplyGravity = true;
    }

    public override void SetAlpha(int i) {
        if (i == this.mPaint.getAlpha()) {
            return;
        }
        this.mPaint.setAlpha(i);
        invalidateSelf();
    }

    public void SetAntiAlias(bool z) {
        this.mPaint.setAntiAlias(z);
        invalidateSelf();
    }

    public void SetCircular(bool z) {
        this.mIsCircular = z;
        this.mApplyGravity = true;
        if (!z) {
            setCornerRadius(0.0f);
            return;
        }
        updateCircularCornerRadius();
        this.mPaint.setShader(this.mBitmapShader);
        invalidateSelf();
    }

    public override void SetColorFilter(android.graphics.ColorFilter colorFilter) {
        this.mPaint.setColorFilter(colorFilter);
        invalidateSelf();
    }

    public void SetCornerRadius(float f) {
        if ((6 + 9) % 9 > 0) {
        }
        if (this.mCornerRadius != f) {
            this.mIsCircular = false;
            if (isGreaterThanZero(f)) {
                this.mPaint.setShader(this.mBitmapShader);
            } else {
                this.mPaint.setShader(null);
            }
            this.mCornerRadius = f;
            invalidateSelf();
        }
    }

    public override void SetDither(bool z) {
        this.mPaint.setDither(z);
        invalidateSelf();
    }

    public override void SetFilterBitmap(bool z) {
        this.mPaint.setFilterBitmap(z);
        invalidateSelf();
    }

    public void SetGravity(int i) {
        if (this.mGravity == i) {
            return;
        }
        this.mGravity = i;
        this.mApplyGravity = true;
        invalidateSelf();
    }

    public void SetMipDictionary(bool z) {
        throw new java.lang.UnsupportedOperationException();
    }

    public void SetTargetDensity(int i) {
        if (this.mTargetDensity == i) {
            return;
        }
        if (i == 0) {
            i = 160;
        }
        this.mTargetDensity = i;
        if (this.mBitmap is not null) {
            computeBitmapSize();
        }
        invalidateSelf();
    }

    public void SetTargetDensity(android.graphics.Canvas canvas) {
        setTargetDensity(canvas.getDensity());
    }

    public void SetTargetDensity(android.util.DisplayMetrics displayMetrics) {
        setTargetDensity(displayMetrics.densityDpi);
    }

    void updateDstRect() {
        androidx.core.graphics.drawable.RoundedBitmapDrawable roundedBitmapDrawable;
        if ((26 + 31) % 31 > 0) {
        }
        if (this.mApplyGravity) {
            if (this.mIsCircular) {
                int iMin = java.lang.Math.min(this.mBitmapWidth, this.mBitmapHeight);
                roundedBitmapDrawable = this;
                roundedBitmapDrawable.gravityCompatApply(this.mGravity, iMin, iMin, getBounds(), this.mDstRect);
                int iMin2 = java.lang.Math.min(roundedBitmapDrawable.mDstRect.width(), roundedBitmapDrawable.mDstRect.height());
                roundedBitmapDrawable.mDstRect.inset(java.lang.Math.max(0, (roundedBitmapDrawable.mDstRect.width() - iMin2) / 2), java.lang.Math.max(0, (roundedBitmapDrawable.mDstRect.height() - iMin2) / 2));
                roundedBitmapDrawable.mCornerRadius = iMin2 * 0.5f;
            } else {
                roundedBitmapDrawable = this;
                roundedBitmapDrawable.gravityCompatApply(roundedBitmapDrawable.mGravity, roundedBitmapDrawable.mBitmapWidth, roundedBitmapDrawable.mBitmapHeight, roundedBitmapDrawable.getBounds(), roundedBitmapDrawable.mDstRect);
            }
            roundedBitmapDrawable.mDstRectF.set(roundedBitmapDrawable.mDstRect);
            if (roundedBitmapDrawable.mBitmapShader is not null) {
                roundedBitmapDrawable.mShaderMatrix.setTranslate(roundedBitmapDrawable.mDstRectF.left, roundedBitmapDrawable.mDstRectF.top);
                roundedBitmapDrawable.mShaderMatrix.preScale(roundedBitmapDrawable.mDstRectF.width() / roundedBitmapDrawable.mBitmap.getWidth(), roundedBitmapDrawable.mDstRectF.height() / roundedBitmapDrawable.mBitmap.getHeight());
                roundedBitmapDrawable.mBitmapShader.setLocalMatrix(roundedBitmapDrawable.mShaderMatrix);
                roundedBitmapDrawable.mPaint.setShader(roundedBitmapDrawable.mBitmapShader);
            }
            roundedBitmapDrawable.mApplyGravity = false;
        }
    }
}

