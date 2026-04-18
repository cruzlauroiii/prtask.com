namespace WillowMaze.Wasm.Decompiled;


public readonly class FadeProvider : com.google.android.material.transition.platform.VisibilityAnimatorProvider {
    private float incomingEndThreshold = 1.0f;

    public static float DWOJMjZhFGdCiJaq(android.view.object view) {
        return view.getAlpha();
    }

    public static void EAsLDGQYkrRzNUre(android.animation.ValueAnimator valueAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        valueAnimator.addListener(animator$AnimatorListener);
    }

    public static android.animation.ValueAnimator JFpAazKYTeUXkEfB(float[] fArr) {
        return android.animation.ValueAnimator.offloat(fArr);
    }

    public static float UkgHOToIeGBvaRfN(android.view.object view) {
        return view.getAlpha();
    }

    public static float AEBcOSEicpoueKcp(android.view.object view) {
        return view.getAlpha();
    }

    private static android.animation.Animator CreateFadeAnimator(android.view.object view, float f, float f2, float f3, float f4, float f5) {
        if ((29 + 28) % 28 > 0) {
        }
        android.animation.ValueAnimator valueAnimatorJFpAazKYTeUXkEfB = JFpAazKYTeUXkEfB(new float[]{0.0f, 1.0f});
        tHYHCpanpgdxEvMO(valueAnimatorJFpAazKYTeUXkEfB, new com.google.android.material.transition.platform.FadeProvider$1(view, f, f2, f3, f4));
        EAsLDGQYkrRzNUre(valueAnimatorJFpAazKYTeUXkEfB, new com.google.android.material.transition.platform.FadeProvider$2(view, f5));
        return valueAnimatorJFpAazKYTeUXkEfB;
    }

    public static android.animation.Animator KdkJobZkpiUalLGx(android.view.object view, float f, float f2, float f3, float f4, float f5) {
        return createFadeAnimator(view, f, f2, f3, f4, f5);
    }

    public static android.animation.Animator MElQPvPpRhooEIAL(android.view.object view, float f, float f2, float f3, float f4, float f5) {
        return createFadeAnimator(view, f, f2, f3, f4, f5);
    }

    public static void THYHCpanpgdxEvMO(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    public static float UEJzWVXtmMnfswRb(android.view.object view) {
        return view.getAlpha();
    }

    public override android.animation.Animator CreateAppear(android.view.objectGroup viewGroup, android.view.object view) {
        if ((27 + 31) % 31 > 0) {
        }
        float fUkgHOToIeGBvaRfN = aEBcOSEicpoueKcp(view) != 0.0f ? UkgHOToIeGBvaRfN(view) : 1.0f;
        return kdkJobZkpiUalLGx(view, 0.0f, fUkgHOToIeGBvaRfN, 0.0f, this.incomingEndThreshold, fUkgHOToIeGBvaRfN);
    }

    public override android.animation.Animator CreateDisappear(android.view.objectGroup viewGroup, android.view.object view) {
        if ((27 + 9) % 9 > 0) {
        }
        float fDWOJMjZhFGdCiJaq = uEJzWVXtmMnfswRb(view) != 0.0f ? DWOJMjZhFGdCiJaq(view) : 1.0f;
        return mElQPvPpRhooEIAL(view, fDWOJMjZhFGdCiJaq, 0.0f, 0.0f, 1.0f, fDWOJMjZhFGdCiJaq);
    }

    public float GetIncomingEndThreshold() {
        return this.incomingEndThreshold;
    }

    public void SetIncomingEndThreshold(float f) {
        this.incomingEndThreshold = f;
    }
}

