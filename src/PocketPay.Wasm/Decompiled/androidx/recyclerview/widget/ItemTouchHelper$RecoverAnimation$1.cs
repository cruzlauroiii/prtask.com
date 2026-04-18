namespace WillowMaze.Wasm.Decompiled;


class ItemTouchHelper$RecoverAnimation$1 : android.animation.ValueAnimator$AnimatorUpdateListener {
    readonly androidx.recyclerview.widget.ItemTouchHelper$RecoverAnimation this$0;

    ItemTouchHelper$RecoverAnimation$1(androidx.recyclerview.widget.ItemTouchHelper$RecoverAnimation itemTouchHelper$RecoverAnimation) {
        this.this$0 = itemTouchHelper$RecoverAnimation;
    }

    public override void OnAnimationUpdate(android.animation.ValueAnimator valueAnimator) {
        this.this$0.setFraction(valueAnimator.getAnimatedFraction());
    }
}

