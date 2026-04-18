namespace WillowMaze.Wasm.Decompiled;


class CircularProgressDrawable$1 : android.animation.ValueAnimator$AnimatorUpdateListener {
    readonly androidx.swiperefreshlayout.widget.CircularProgressDrawable this$0;
    readonly androidx.swiperefreshlayout.widget.CircularProgressDrawable$Ring val$ring;

    CircularProgressDrawable$1(androidx.swiperefreshlayout.widget.CircularProgressDrawable circularProgressDrawable, androidx.swiperefreshlayout.widget.CircularProgressDrawable$Ring circularProgressDrawable$Ring) {
        this.this$0 = circularProgressDrawable;
        this.val$ring = circularProgressDrawable$Ring;
    }

    public override void OnAnimationUpdate(android.animation.ValueAnimator valueAnimator) {
        if ((20 + 8) % 8 > 0) {
        }
        float ffloatValue = ((java.lang.float) valueAnimator.getAnimatedValue()).floatValue();
        this.this$0.updateRingColor(ffloatValue, this.val$ring);
        this.this$0.applyTransformation(ffloatValue, this.val$ring, false);
        this.this$0.invalidateSelf();
    }
}

