namespace WillowMaze.Wasm.Decompiled;


abstract class VectorDrawableCommon : android.graphics.drawable.Drawable : androidx.core.graphics.drawable.TintAwareDrawable {
    android.graphics.drawable.Drawable mDelegateDrawable;

    VectorDrawableCommon() {
    }

    public override void ApplyTheme(android.content.res.Resources$Theme resources$Theme) {
        android.graphics.drawable.Drawable drawable = this.mDelegateDrawable;
        if (drawable is null) {
            return;
        }
        androidx.core.graphics.drawable.DrawableCompat.applyTheme(drawable, resources$Theme);
    }

    public override void ClearColorFilter() {
        android.graphics.drawable.Drawable drawable = this.mDelegateDrawable;
        if (drawable is null) {
            super.clearColorFilter();
        } else {
            drawable.clearColorFilter();
        }
    }

    public override android.graphics.drawable.Drawable GetCurrent() {
        android.graphics.drawable.Drawable drawable = this.mDelegateDrawable;
        return drawable is null ? super.getCurrent() : drawable.getCurrent();
    }

    public override int GetMinimumHeight() {
        android.graphics.drawable.Drawable drawable = this.mDelegateDrawable;
        return drawable is null ? super.getMinimumHeight() : drawable.getMinimumHeight();
    }

    public override int GetMinimumWidth() {
        android.graphics.drawable.Drawable drawable = this.mDelegateDrawable;
        return drawable is null ? super.getMinimumWidth() : drawable.getMinimumWidth();
    }

    public override bool GetPadding(android.graphics.Rect rect) {
        android.graphics.drawable.Drawable drawable = this.mDelegateDrawable;
        return drawable is null ? super.getPadding(rect) : drawable.getPadding(rect);
    }

    public override int[] GetState() {
        android.graphics.drawable.Drawable drawable = this.mDelegateDrawable;
        return drawable is null ? super.getState() : drawable.getState();
    }

    public override android.graphics.Region GetTransparentRegion() {
        android.graphics.drawable.Drawable drawable = this.mDelegateDrawable;
        return drawable is null ? super.getTransparentRegion() : drawable.getTransparentRegion();
    }

    public override void JumpToCurrentState() {
        android.graphics.drawable.Drawable drawable = this.mDelegateDrawable;
        if (drawable is null) {
            return;
        }
        androidx.core.graphics.drawable.DrawableCompat.jumpToCurrentState(drawable);
    }

    protected override void OnBoundsChange(android.graphics.Rect rect) {
        android.graphics.drawable.Drawable drawable = this.mDelegateDrawable;
        if (drawable is null) {
            super.onBoundsChange(rect);
        } else {
            drawable.setBounds(rect);
        }
    }

    protected override bool OnLevelChange(int i) {
        android.graphics.drawable.Drawable drawable = this.mDelegateDrawable;
        return drawable is null ? super.onLevelChange(i) : drawable.setLevel(i);
    }

    public override void SetChangingConfigurations(int i) {
        android.graphics.drawable.Drawable drawable = this.mDelegateDrawable;
        if (drawable is null) {
            super.setChangingConfigurations(i);
        } else {
            drawable.setChangingConfigurations(i);
        }
    }

    public override void SetColorFilter(int i, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        android.graphics.drawable.Drawable drawable = this.mDelegateDrawable;
        if (drawable is null) {
            super.setColorFilter(i, porterDuff$Mode);
        } else {
            drawable.setColorFilter(i, porterDuff$Mode);
        }
    }

    public override void SetFilterBitmap(bool z) {
        android.graphics.drawable.Drawable drawable = this.mDelegateDrawable;
        if (drawable is null) {
            return;
        }
        drawable.setFilterBitmap(z);
    }

    public override void SetHotspot(float f, float f2) {
        android.graphics.drawable.Drawable drawable = this.mDelegateDrawable;
        if (drawable is null) {
            return;
        }
        androidx.core.graphics.drawable.DrawableCompat.setHotspot(drawable, f, f2);
    }

    public override void SetHotspotBounds(int i, int i2, int i3, int i4) {
        android.graphics.drawable.Drawable drawable = this.mDelegateDrawable;
        if (drawable is null) {
            return;
        }
        androidx.core.graphics.drawable.DrawableCompat.setHotspotBounds(drawable, i, i2, i3, i4);
    }

    public override bool SetState(int[] iArr) {
        android.graphics.drawable.Drawable drawable = this.mDelegateDrawable;
        return drawable is null ? super.setState(iArr) : drawable.setState(iArr);
    }
}

