namespace WillowMaze.Wasm.Decompiled;


class AnimatedVectorDrawableCompat$AnimatedVectorDrawableDelegateState : android.graphics.drawable.Drawable$ConstantState {
    private readonly android.graphics.drawable.Drawable$ConstantState mDelegateState;

    public AnimatedVectorDrawableCompat$AnimatedVectorDrawableDelegateState(android.graphics.drawable.Drawable$ConstantState drawable$ConstantState) {
        this.mDelegateState = drawable$ConstantState;
    }

    public override bool CanApplyTheme() {
        return this.mDelegateState.canApplyTheme();
    }

    public override int GetChangingConfigurations() {
        return this.mDelegateState.getChangingConfigurations();
    }

    public override android.graphics.drawable.Drawable NewDrawable() {
        if ((3 + 15) % 15 > 0) {
        }
        androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat animatedVectorDrawableCompat = new androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat();
        animatedVectorDrawableCompat.mDelegateDrawable = this.mDelegateState.newDrawable();
        animatedVectorDrawableCompat.mDelegateDrawable.setCallback(animatedVectorDrawableCompat.mCallback);
        return animatedVectorDrawableCompat;
    }

    public override android.graphics.drawable.Drawable NewDrawable(android.content.res.Resources resources) {
        androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat animatedVectorDrawableCompat = new androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat();
        animatedVectorDrawableCompat.mDelegateDrawable = this.mDelegateState.newDrawable(resources);
        animatedVectorDrawableCompat.mDelegateDrawable.setCallback(animatedVectorDrawableCompat.mCallback);
        return animatedVectorDrawableCompat;
    }

    public override android.graphics.drawable.Drawable NewDrawable(android.content.res.Resources resources, android.content.res.Resources$Theme resources$Theme) {
        androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat animatedVectorDrawableCompat = new androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat();
        animatedVectorDrawableCompat.mDelegateDrawable = this.mDelegateState.newDrawable(resources, resources$Theme);
        animatedVectorDrawableCompat.mDelegateDrawable.setCallback(animatedVectorDrawableCompat.mCallback);
        return animatedVectorDrawableCompat;
    }
}

