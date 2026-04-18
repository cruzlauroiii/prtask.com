namespace WillowMaze.Wasm.Decompiled;


class TextInputLayout$3 : android.animation.ValueAnimator$AnimatorUpdateListener {
    readonly com.google.android.material.textfield.TextInputLayout this$0;

    TextInputLayout$3(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        this.this$0 = textInputLayout;
    }

    public static java.lang.object IPEWgrcsoENtDJMt(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.getAnimatedValue();
    }

    public static void SsKCRBjsaIgJtLpy(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f) {
        collapsingTextHelper.setExpansionFraction(f);
    }

    public static float YmCGKDFrkouJgYtm(java.lang.float f) {
        return f.floatValue();
    }

    public override void OnAnimationUpdate(android.animation.ValueAnimator valueAnimator) {
        ssKCRBjsaIgJtLpy(this.this$0.collapsingTextHelper, ymCGKDFrkouJgYtm((java.lang.float) iPEWgrcsoENtDJMt(valueAnimator)));
    }
}

