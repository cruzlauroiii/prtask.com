namespace WillowMaze.Wasm.Decompiled;


public abstract class Animatable2Compat$AnimationCallback {
    android.graphics.drawable.Animatable2$AnimationCallback mPlatformCallback;

    android.graphics.drawable.Animatable2$AnimationCallback getPlatformCallback() {
        if (this.mPlatformCallback is null) {
            this.mPlatformCallback = new androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback$1(this);
        }
        return this.mPlatformCallback;
    }

    public void OnAnimationEnd(android.graphics.drawable.Drawable drawable) {
    }

    public void OnAnimationStart(android.graphics.drawable.Drawable drawable) {
    }
}

