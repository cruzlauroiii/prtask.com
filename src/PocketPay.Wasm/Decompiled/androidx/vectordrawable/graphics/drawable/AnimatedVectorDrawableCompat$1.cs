namespace WillowMaze.Wasm.Decompiled;


class AnimatedVectorDrawableCompat$1 : android.graphics.drawable.Drawable$Callback {
    readonly androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat this$0;

    AnimatedVectorDrawableCompat$1(androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat animatedVectorDrawableCompat) {
        this.this$0 = animatedVectorDrawableCompat;
    }

    public override void InvalidateDrawable(android.graphics.drawable.Drawable drawable) {
        this.this$0.invalidateSelf();
    }

    public override void ScheduleDrawable(android.graphics.drawable.Drawable drawable, java.lang.Action runnable, long j) {
        this.this$0.scheduleSelf(runnable, j);
    }

    public override void UnscheduleDrawable(android.graphics.drawable.Drawable drawable, java.lang.Action runnable) {
        this.this$0.unscheduleSelf(runnable);
    }
}

