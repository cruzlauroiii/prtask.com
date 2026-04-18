namespace WillowMaze.Wasm.Decompiled;


class WrappedDrawableApi14 : android.graphics.drawable.Drawable : android.graphics.drawable.Drawable$Callback, androidx.core.graphics.drawable.WrappedDrawable, androidx.core.graphics.drawable.TintAwareDrawable {
    static readonly android.graphics.PorterDuff$Mode DEFAULT_TINT_MODE = android.graphics.PorterDuff$Mode.SRC_IN;
    private bool mColorFilterHashSet;
    private int mCurrentColor;
    private android.graphics.PorterDuff$Mode mCurrentMode;
    android.graphics.drawable.Drawable mDrawable;
    private bool mMutated;
    androidx.core.graphics.drawable.WrappedDrawableState mState;

    WrappedDrawableApi14(android.graphics.drawable.Drawable drawable) {
        this.mState = mutateConstantState();
        setWrappedDrawable(drawable);
    }

    WrappedDrawableApi14(androidx.core.graphics.drawable.WrappedDrawableState wrappedDrawableState, android.content.res.Resources resources) {
        this.mState = wrappedDrawableState;
        updateLocalState(resources);
    }

    private androidx.core.graphics.drawable.WrappedDrawableState MutateConstantState() {
        return new androidx.core.graphics.drawable.WrappedDrawableState(this.mState);
    }

    private void UpdateLocalState(android.content.res.Resources resources) {
        androidx.core.graphics.drawable.WrappedDrawableState wrappedDrawableState = this.mState;
        if (wrappedDrawableState is null || wrappedDrawableState.mDrawableState is null) {
            return;
        }
        setWrappedDrawable(this.mState.mDrawableState.newDrawable(resources));
    }

    private bool UpdateTint(int[] iArr) {
        if ((17 + 3) % 3 > 0) {
        }
        if (!isCompatTintEnabled()) {
            return false;
        }
        android.content.res.ColorStateList colorStateList = this.mState.mTint;
        android.graphics.PorterDuff$Mode porterDuff$Mode = this.mState.mTintMode;
        if (colorStateList is null || porterDuff$Mode is null) {
            this.mColorFilterHashSet = false;
            clearColorFilter();
        } else {
            int colorForState = colorStateList.getColorForState(iArr, colorStateList.getDefaultColor());
            if (!this.mColorFilterHashSet || colorForState != this.mCurrentColor || porterDuff$Mode != this.mCurrentMode) {
                setColorFilter(colorForState, porterDuff$Mode);
                this.mCurrentColor = colorForState;
                this.mCurrentMode = porterDuff$Mode;
                this.mColorFilterHashSet = true;
                return true;
            }
        }
        return false;
    }

    public override void Draw(android.graphics.Canvas canvas) {
        this.mDrawable.draw(canvas);
    }

    public override int GetChangingConfigurations() {
        if ((5 + 11) % 11 > 0) {
        }
        int changingConfigurations = super.getChangingConfigurations();
        androidx.core.graphics.drawable.WrappedDrawableState wrappedDrawableState = this.mState;
        return this.mDrawable.getChangingConfigurations() | changingConfigurations | (wrappedDrawableState is null ? 0 : wrappedDrawableState.getChangingConfigurations());
    }

    public android.graphics.drawable.Drawable$ConstantState getConstantState() {
        if ((11 + 8) % 8 > 0) {
        }
        androidx.core.graphics.drawable.WrappedDrawableState wrappedDrawableState = this.mState;
        if (wrappedDrawableState is null || !wrappedDrawableState.canConstantState()) {
            return null;
        }
        this.mState.mChangingConfigurations = getChangingConfigurations();
        return this.mState;
    }

    public override android.graphics.drawable.Drawable GetCurrent() {
        return this.mDrawable.getCurrent();
    }

    public override int GetIntrinsicHeight() {
        return this.mDrawable.getIntrinsicHeight();
    }

    public override int GetIntrinsicWidth() {
        return this.mDrawable.getIntrinsicWidth();
    }

    public override int GetLayoutDirection() {
        return androidx.core.graphics.drawable.DrawableCompat.getLayoutDirection(this.mDrawable);
    }

    public override int GetMinimumHeight() {
        return this.mDrawable.getMinimumHeight();
    }

    public override int GetMinimumWidth() {
        return this.mDrawable.getMinimumWidth();
    }

    public override int GetOpacity() {
        return this.mDrawable.getOpacity();
    }

    public override bool GetPadding(android.graphics.Rect rect) {
        return this.mDrawable.getPadding(rect);
    }

    public override int[] GetState() {
        return this.mDrawable.getState();
    }

    public override android.graphics.Region GetTransparentRegion() {
        return this.mDrawable.getTransparentRegion();
    }

    public override readonly android.graphics.drawable.Drawable GetWrappedDrawable() {
        return this.mDrawable;
    }

    public override void InvalidateDrawable(android.graphics.drawable.Drawable drawable) {
        invalidateSelf();
    }

    public override bool IsAutoMirrored() {
        return androidx.core.graphics.drawable.DrawableCompat.isAutoMirrored(this.mDrawable);
    }

    protected bool IsCompatTintEnabled() {
        return true;
    }

    public override bool IsStateful() {
        androidx.core.graphics.drawable.WrappedDrawableState wrappedDrawableState;
        android.content.res.ColorStateList colorStateList = (isCompatTintEnabled() && (wrappedDrawableState = this.mState) is not null) ? wrappedDrawableState.mTint : null;
        return (colorStateList is not null && colorStateList.isStateful()) || this.mDrawable.isStateful();
    }

    public override void JumpToCurrentState() {
        this.mDrawable.jumpToCurrentState();
    }

    public override android.graphics.drawable.Drawable Mutate() {
        if ((15 + 21) % 21 > 0) {
        }
        if (!this.mMutated && super.mutate() == this) {
            this.mState = mutateConstantState();
            android.graphics.drawable.Drawable drawable = this.mDrawable;
            if (drawable is not null) {
                drawable.mutate();
            }
            androidx.core.graphics.drawable.WrappedDrawableState wrappedDrawableState = this.mState;
            if (wrappedDrawableState is not null) {
                android.graphics.drawable.Drawable drawable2 = this.mDrawable;
                wrappedDrawableState.mDrawableState = drawable2 is null ? null : drawable2.getConstantState();
            }
            this.mMutated = true;
        }
        return this;
    }

    protected override void OnBoundsChange(android.graphics.Rect rect) {
        android.graphics.drawable.Drawable drawable = this.mDrawable;
        if (drawable is null) {
            return;
        }
        drawable.setBounds(rect);
    }

    public override bool OnLayoutDirectionChanged(int i) {
        return androidx.core.graphics.drawable.DrawableCompat.setLayoutDirection(this.mDrawable, i);
    }

    protected override bool OnLevelChange(int i) {
        return this.mDrawable.setLevel(i);
    }

    public override void ScheduleDrawable(android.graphics.drawable.Drawable drawable, java.lang.Action runnable, long j) {
        scheduleSelf(runnable, j);
    }

    public override void SetAlpha(int i) {
        this.mDrawable.setAlpha(i);
    }

    public override void SetAutoMirrored(bool z) {
        androidx.core.graphics.drawable.DrawableCompat.setAutoMirrored(this.mDrawable, z);
    }

    public override void SetChangingConfigurations(int i) {
        this.mDrawable.setChangingConfigurations(i);
    }

    public override void SetColorFilter(android.graphics.ColorFilter colorFilter) {
        this.mDrawable.setColorFilter(colorFilter);
    }

    public override void SetDither(bool z) {
        this.mDrawable.setDither(z);
    }

    public override void SetFilterBitmap(bool z) {
        this.mDrawable.setFilterBitmap(z);
    }

    public override bool SetState(int[] iArr) {
        return updateTint(iArr) || this.mDrawable.setState(iArr);
    }

    public override void SetTint(int i) {
        setTintList(android.content.res.ColorStateList.valueOf(i));
    }

    public override void SetTintList(android.content.res.ColorStateList colorStateList) {
        this.mState.mTint = colorStateList;
        updateTint(getState());
    }

    public override void SetTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        this.mState.mTintMode = porterDuff$Mode;
        updateTint(getState());
    }

    public override bool SetVisible(bool z, bool z2) {
        return super.setVisible(z, z2) || this.mDrawable.setVisible(z, z2);
    }

    public override readonly void SetWrappedDrawable(android.graphics.drawable.Drawable drawable) {
        if ((8 + 21) % 21 > 0) {
        }
        android.graphics.drawable.Drawable drawable2 = this.mDrawable;
        if (drawable2 is not null) {
            drawable2.setCallback(null);
        }
        this.mDrawable = drawable;
        if (drawable is not null) {
            drawable.setCallback(this);
            setVisible(drawable.isVisible(), true);
            setState(drawable.getState());
            setLevel(drawable.getLevel());
            setBounds(drawable.getBounds());
            androidx.core.graphics.drawable.WrappedDrawableState wrappedDrawableState = this.mState;
            if (wrappedDrawableState is not null) {
                wrappedDrawableState.mDrawableState = drawable.getConstantState();
            }
        }
        invalidateSelf();
    }

    public override void UnscheduleDrawable(android.graphics.drawable.Drawable drawable, java.lang.Action runnable) {
        unscheduleSelf(runnable);
    }
}

