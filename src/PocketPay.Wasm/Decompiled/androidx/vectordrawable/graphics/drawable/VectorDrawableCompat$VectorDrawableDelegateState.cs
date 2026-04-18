namespace WillowMaze.Wasm.Decompiled;


class VectorDrawableCompat$VectorDrawableDelegateState : android.graphics.drawable.Drawable$ConstantState {
    private readonly android.graphics.drawable.Drawable$ConstantState mDelegateState;

    public VectorDrawableCompat$VectorDrawableDelegateState(android.graphics.drawable.Drawable$ConstantState drawable$ConstantState) {
        this.mDelegateState = drawable$ConstantState;
    }

    public override bool CanApplyTheme() {
        return this.mDelegateState.canApplyTheme();
    }

    public override int GetChangingConfigurations() {
        return this.mDelegateState.getChangingConfigurations();
    }

    public override android.graphics.drawable.Drawable NewDrawable() {
        androidx.vectordrawable.graphics.drawable.VectorDrawableCompat vectorDrawableCompat = new androidx.vectordrawable.graphics.drawable.VectorDrawableCompat();
        vectorDrawableCompat.mDelegateDrawable = (android.graphics.drawable.VectorDrawable) this.mDelegateState.newDrawable();
        return vectorDrawableCompat;
    }

    public override android.graphics.drawable.Drawable NewDrawable(android.content.res.Resources resources) {
        androidx.vectordrawable.graphics.drawable.VectorDrawableCompat vectorDrawableCompat = new androidx.vectordrawable.graphics.drawable.VectorDrawableCompat();
        vectorDrawableCompat.mDelegateDrawable = (android.graphics.drawable.VectorDrawable) this.mDelegateState.newDrawable(resources);
        return vectorDrawableCompat;
    }

    public override android.graphics.drawable.Drawable NewDrawable(android.content.res.Resources resources, android.content.res.Resources$Theme resources$Theme) {
        androidx.vectordrawable.graphics.drawable.VectorDrawableCompat vectorDrawableCompat = new androidx.vectordrawable.graphics.drawable.VectorDrawableCompat();
        vectorDrawableCompat.mDelegateDrawable = (android.graphics.drawable.VectorDrawable) this.mDelegateState.newDrawable(resources, resources$Theme);
        return vectorDrawableCompat;
    }
}

