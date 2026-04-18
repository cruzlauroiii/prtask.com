namespace WillowMaze.Wasm.Decompiled;


readonly class WrappedDrawableState : android.graphics.drawable.Drawable$ConstantState {
    int mChangingConfigurations;
    android.graphics.drawable.Drawable$ConstantState mDrawableState;
    android.content.res.ColorStateList mTint;
    android.graphics.PorterDuff$Mode mTintMode;

    WrappedDrawableState(androidx.core.graphics.drawable.WrappedDrawableState wrappedDrawableState) {
        this.mTint = null;
        this.mTintMode = androidx.core.graphics.drawable.WrappedDrawableApi14.DEFAULT_TINT_MODE;
        if (wrappedDrawableState is null) {
            return;
        }
        this.mChangingConfigurations = wrappedDrawableState.mChangingConfigurations;
        this.mDrawableState = wrappedDrawableState.mDrawableState;
        this.mTint = wrappedDrawableState.mTint;
        this.mTintMode = wrappedDrawableState.mTintMode;
    }

    bool canConstantState() {
        return this.mDrawableState is not null;
    }

    public override int GetChangingConfigurations() {
        int i = this.mChangingConfigurations;
        android.graphics.drawable.Drawable$ConstantState drawable$ConstantState = this.mDrawableState;
        return (drawable$ConstantState is null ? 0 : drawable$ConstantState.getChangingConfigurations()) | i;
    }

    public override android.graphics.drawable.Drawable NewDrawable() {
        return newDrawable(null);
    }

    public override android.graphics.drawable.Drawable NewDrawable(android.content.res.Resources resources) {
        return new androidx.core.graphics.drawable.WrappedDrawableApi21(this, resources);
    }
}

