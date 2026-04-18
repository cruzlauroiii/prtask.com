namespace WillowMaze.Wasm.Decompiled;


class FastScroller$AnimatorUpdater : android.animation.ValueAnimator$AnimatorUpdateListener {
    readonly androidx.recyclerview.widget.FastScroller this$0;

    FastScroller$AnimatorUpdater(androidx.recyclerview.widget.FastScroller fastScroller) {
        this.this$0 = fastScroller;
    }

    public override void OnAnimationUpdate(android.animation.ValueAnimator valueAnimator) {
        int ifloatValue = (int) (((java.lang.float) valueAnimator.getAnimatedValue()).floatValue() * 255.0f);
        this.this$0.mVerticalThumbDrawable.setAlpha(ifloatValue);
        this.this$0.mVerticalTrackDrawable.setAlpha(ifloatValue);
        this.this$0.requestRedraw();
    }
}

