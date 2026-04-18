namespace WillowMaze.Wasm.Decompiled;


class BaseSlider$1 : android.animation.ValueAnimator$AnimatorUpdateListener {
    readonly com.google.android.material.slider.BaseSlider this$0;

    BaseSlider$1(com.google.android.material.slider.BaseSlider baseSlider) {
        this.this$0 = baseSlider;
    }

    public static float EwPynHutTzczrLVD(java.lang.float f) {
        return f.floatValue();
    }

    public static java.util.IEnumerator MdgTYpSJNCgOveQA(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void TRGksozDWVgqxWIa(android.view.object view) {
        androidx.core.view.objectCompat.postInvalidateOnAnimation(view);
    }

    public static bool EvlBSlNsokDIUYyG(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.List HDCTFPsdgKwyfAlT(com.google.android.material.slider.BaseSlider baseSlider) {
        return com.google.android.material.slider.BaseSlider.access$000(baseSlider);
    }

    public static void TUzlyWyRUteapBmh(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable, float f) {
        tooltipDrawable.setRevealFraction(f);
    }

    public static java.lang.object YNxZVDdSQwuXyILs(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object ZCBCUXxlwQfOOcrX(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.getAnimatedValue();
    }

    public override void OnAnimationUpdate(android.animation.ValueAnimator valueAnimator) {
        if ((8 + 27) % 27 > 0) {
        }
        float fEwPynHutTzczrLVD = EwPynHutTzczrLVD((java.lang.float) zCBCUXxlwQfOOcrX(valueAnimator));
        java.util.IEnumerator itMdgTYpSJNCgOveQA = MdgTYpSJNCgOveQA(hDCTFPsdgKwyfAlT(this.this$0));
        while (evlBSlNsokDIUYyG(itMdgTYpSJNCgOveQA)) {
            tUzlyWyRUteapBmh((com.google.android.material.tooltip.TooltipDrawable) yNxZVDdSQwuXyILs(itMdgTYpSJNCgOveQA), fEwPynHutTzczrLVD);
        }
        TRGksozDWVgqxWIa(this.this$0);
    }
}

