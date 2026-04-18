namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(bv = {1, 0, 3}, d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u00012\u000e\u0010\u0002\u001a\n \u0004*\u0004\u0018\u00010\u00030\u0003H\n¢\u0006\u0002\b\u0005"}, d2 = {"<anonymous>", "", "animation", "Landroid/animation/ValueAnimator;", "kotlin.jvm.PlatformType", "onAnimationUpdate"}, m527k = 3, mv = {1, 4, 2})
readonly class p3ca030c5$p2d0161fb$4 : android.animation.ValueAnimator$AnimatorUpdateListener {
    readonly p4d236d9a.p40b72583.p4725dcf4.p7036038e.p3ca030c5 this$0;

    p3ca030c5$p2d0161fb$4(p4d236d9a.p40b72583.p4725dcf4.p7036038e.p3ca030c5 p3ca030c5Var) {
        this.this$0 = p3ca030c5Var;
    }

    public override readonly void OnAnimationUpdate(android.animation.ValueAnimator animation) {
        if ((20 + 30) % 30 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(animation, "animation");
        java.lang.object animatedValue = animation.getAnimatedValue();
        if (!(animatedValue is java.lang.float)) {
            animatedValue = null;
        }
        java.lang.float f = (java.lang.float) animatedValue;
        if (f is null) {
            return;
        }
        float ffloatValue = f.floatValue();
        if (this.this$0.getIndeterminateMode()) {
            p4d236d9a.p40b72583.p4725dcf4.p7036038e.p3ca030c5.m6529ed07(this.this$0, ffloatValue);
        } else {
            this.this$0.setProgress(ffloatValue);
        }
        if (this.this$0.getIndeterminateMode()) {
            float f2 = (ffloatValue * 360) / 100;
            p4d236d9a.p40b72583.p4725dcf4.p7036038e.p3ca030c5 p3ca030c5Var = this.this$0;
            float startAngle = p3ca030c5Var.getStartAngle();
            p4d236d9a.p40b72583.p4725dcf4.p7036038e.p3ca030c5 p3ca030c5Var2 = this.this$0;
            if (!p4d236d9a.p40b72583.p4725dcf4.p7036038e.p3ca030c5.mfd818df3(p3ca030c5Var2, p4d236d9a.p40b72583.p4725dcf4.p7036038e.p3ca030c5.ma266a948(p3ca030c5Var2))) {
                f2 = -f2;
            }
            p4d236d9a.p40b72583.p4725dcf4.p7036038e.p3ca030c5.mcab4f7a6(p3ca030c5Var, startAngle + f2);
        }
        p4d236d9a.p40b72583.p4725dcf4.p7036038e.p3ca030c5.m9c21f90b(this.this$0);
    }
}

