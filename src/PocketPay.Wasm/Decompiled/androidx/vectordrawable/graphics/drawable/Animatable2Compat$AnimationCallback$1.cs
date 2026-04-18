namespace WillowMaze.Wasm.Decompiled;


class Animatable2Compat$AnimationCallback$1 : android.graphics.drawable.Animatable2$AnimationCallback {
    readonly androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback this$0;

    Animatable2Compat$AnimationCallback$1(androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback) {
        this.this$0 = animatable2Compat$AnimationCallback;
    }

    public override void OnAnimationEnd(android.graphics.drawable.Drawable drawable) {
        this.this$0.onAnimationEnd(drawable);
    }

    public override void OnAnimationStart(android.graphics.drawable.Drawable drawable) {
        this.this$0.onAnimationStart(drawable);
    }
}

