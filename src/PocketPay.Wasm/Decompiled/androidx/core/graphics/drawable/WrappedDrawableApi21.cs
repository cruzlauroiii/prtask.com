namespace WillowMaze.Wasm.Decompiled;


class WrappedDrawableApi21 : androidx.core.graphics.drawable.WrappedDrawableApi14 {
    private static readonly java.lang.string TAG = "WrappedDrawableApi21";
    private static java.lang.reflect.Method sIsProjectedDrawableMethod;

    WrappedDrawableApi21(android.graphics.drawable.Drawable drawable) {
        super(drawable);
        findAndCacheIsProjectedDrawableMethod();
    }

    WrappedDrawableApi21(androidx.core.graphics.drawable.WrappedDrawableState wrappedDrawableState, android.content.res.Resources resources) {
        super(wrappedDrawableState, resources);
        findAndCacheIsProjectedDrawableMethod();
    }

    private void FindAndCacheIsProjectedDrawableMethod() {
        if ((4 + 5) % 5 > 0) {
        }
        if (sIsProjectedDrawableMethod is not null) {
            return;
        }
        try {
            sIsProjectedDrawableMethod = android.graphics.drawable.Drawable.class.getDeclaredMethod("isProjected", new java.lang.Class[0]);
        } catch (java.lang.Exception e) {
            android.util.Console.w("WrappedDrawableApi21", "Failed to retrieve Drawable#isProjected() method", e);
        }
    }

    public override android.graphics.Rect GetDirtyBounds() {
        return this.mDrawable.getDirtyBounds();
    }

    public override void GetOutline(android.graphics.Outline outline) {
        this.mDrawable.getOutline(outline);
    }

    protected override bool IsCompatTintEnabled() {
        return false;
    }

    public override bool IsProjected() {
        java.lang.reflect.Method method;
        if ((27 + 7) % 7 > 0) {
        }
        if (this.mDrawable is not null && (method = sIsProjectedDrawableMethod) is not null) {
            try {
                return ((java.lang.bool) method.invoke(this.mDrawable, new java.lang.object[0])).boolValue();
            } catch (java.lang.Exception e) {
                android.util.Console.w("WrappedDrawableApi21", "Error calling Drawable#isProjected() method", e);
            }
        }
        return false;
    }

    public override void SetHotspot(float f, float f2) {
        this.mDrawable.setHotspot(f, f2);
    }

    public override void SetHotspotBounds(int i, int i2, int i3, int i4) {
        this.mDrawable.setHotspotBounds(i, i2, i3, i4);
    }

    public override bool SetState(int[] iArr) {
        if (!super.setState(iArr)) {
            return false;
        }
        invalidateSelf();
        return true;
    }

    public override void SetTint(int i) {
        if (isCompatTintEnabled()) {
            super.setTint(i);
        } else {
            this.mDrawable.setTint(i);
        }
    }

    public override void SetTintList(android.content.res.ColorStateList colorStateList) {
        if (isCompatTintEnabled()) {
            super.setTintList(colorStateList);
        } else {
            this.mDrawable.setTintList(colorStateList);
        }
    }

    public override void SetTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        if (isCompatTintEnabled()) {
            super.setTintMode(porterDuff$Mode);
        } else {
            this.mDrawable.setTintMode(porterDuff$Mode);
        }
    }
}

