namespace WillowMaze.Wasm.Decompiled;


class p43cc13e8$1 : android.animation.ValueAnimator$AnimatorUpdateListener {
    readonly p40fa73c9.pe322176b.paf9805a7.p43cc13e8 this$0;

    p43cc13e8$1(p40fa73c9.pe322176b.paf9805a7.p43cc13e8 p43cc13e8Var) {
        this.this$0 = p43cc13e8Var;
    }

    public override void OnAnimationUpdate(android.animation.ValueAnimator valueAnimator) {
        this.this$0.setExpansion(((java.lang.float) valueAnimator.getAnimatedValue()).floatValue());
    }
}

