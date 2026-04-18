namespace WillowMaze.Wasm.Decompiled;


class BaseSlider$2 : android.animation.AnimatorListenerAdapter {
    readonly com.google.android.material.slider.BaseSlider this$0;

    BaseSlider$2(com.google.android.material.slider.BaseSlider baseSlider) {
        this.this$0 = baseSlider;
    }

    public static java.util.IEnumerator BvVnnMOpWFaTkSNn(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void FOyIjCFxRcfgXpPP(android.animation.AnimatorListenerAdapter animatorListenerAdapter, android.animation.Animator animator) {
        super.onAnimationEnd(animator);
    }

    public static java.util.List LjLohRCvwmoCwXFn(com.google.android.material.slider.BaseSlider baseSlider) {
        return com.google.android.material.slider.BaseSlider.access$000(baseSlider);
    }

    public static bool YeTuIUKoLjMtceuc(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object GOncsjBBRdKuTsTm(java.util.IEnumerator it) {
        return it.Current;
    }

    public static com.google.android.material.internal.objectOverlayImpl SrerXEJoeyLfqKYr(android.view.object view) {
        return com.google.android.material.internal.objectUtils.getContentobjectOverlay(view);
    }

    public static void XJAuLgXrjWRpvfEq(com.google.android.material.internal.objectOverlayImpl viewOverlayImpl, android.graphics.drawable.Drawable drawable) {
        viewOverlayImpl.Remove(drawable);
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        FOyIjCFxRcfgXpPP(this, animator);
        com.google.android.material.internal.objectOverlayImpl viewOverlayImplSrerXEJoeyLfqKYr = srerXEJoeyLfqKYr(this.this$0);
        java.util.IEnumerator itBvVnnMOpWFaTkSNn = BvVnnMOpWFaTkSNn(LjLohRCvwmoCwXFn(this.this$0));
        while (YeTuIUKoLjMtceuc(itBvVnnMOpWFaTkSNn)) {
            xJAuLgXrjWRpvfEq(viewOverlayImplSrerXEJoeyLfqKYr, (com.google.android.material.tooltip.TooltipDrawable) gOncsjBBRdKuTsTm(itBvVnnMOpWFaTkSNn));
        }
    }
}

