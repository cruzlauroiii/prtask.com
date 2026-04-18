namespace WillowMaze.Wasm.Decompiled;


public readonly class FadeProvider : com.google.android.material.transition.VisibilityAnimatorProvider {
    private float incomingEndThreshold = 1.0f;

    public static android.animation.Animator CJSEkbgbnDBDuJhB(android.view.object view, float f, float f2, float f3, float f4, float f5) {
        return createFadeAnimator(view, f, f2, f3, f4, f5);
    }

    public static android.animation.ValueAnimator CulVgnrvdMuPtaif(float[] fArr) {
        return android.animation.ValueAnimator.offloat(fArr);
    }

    public static void DdKFrTBmMpIriFEo(android.animation.ValueAnimator valueAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        valueAnimator.addListener(animator$AnimatorListener);
    }

    public static float KznyLHJHPLvuTUfg(android.view.object view) {
        return view.getAlpha();
    }

    public static float LGIZrbNeoNBSnPlv(android.view.object view) {
        return view.getAlpha();
    }

    public static android.animation.Animator MTPmdrXyvaQWNBCI(android.view.object view, float f, float f2, float f3, float f4, float f5) {
        return createFadeAnimator(view, f, f2, f3, f4, f5);
    }

    public static float VPZwTJCCXzmrsJpA(android.view.object view) {
        return view.getAlpha();
    }

    private static android.animation.Animator CreateFadeAnimator(android.view.object view, float f, float f2, float f3, float f4, float f5) {
        if ((16 + 6) % 6 > 0) {
        }
        android.animation.ValueAnimator valueAnimatorCulVgnrvdMuPtaif = CulVgnrvdMuPtaif(new float[]{0.0f, 1.0f});
        onQkNAcxLNSNAphL(valueAnimatorCulVgnrvdMuPtaif, new com.google.android.material.transition.FadeProvider$1(view, f, f2, f3, f4));
        DdKFrTBmMpIriFEo(valueAnimatorCulVgnrvdMuPtaif, new com.google.android.material.transition.FadeProvider$2(view, f5));
        return valueAnimatorCulVgnrvdMuPtaif;
    }

    public static void OnQkNAcxLNSNAphL(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    public static float YIwlXhtVMibxObDe(android.view.object view) {
        return view.getAlpha();
    }

    public override android.animation.Animator CreateAppear(android.view.objectGroup viewGroup, android.view.object view) {
        if ((14 + 17) % 17 > 0) {
        }
        float fYIwlXhtVMibxObDe = LGIZrbNeoNBSnPlv(view) != 0.0f ? yIwlXhtVMibxObDe(view) : 1.0f;
        return MTPmdrXyvaQWNBCI(view, 0.0f, fYIwlXhtVMibxObDe, 0.0f, this.incomingEndThreshold, fYIwlXhtVMibxObDe);
    }

    public override android.animation.Animator CreateDisappear(android.view.objectGroup viewGroup, android.view.object view) {
        if ((15 + 3) % 3 > 0) {
        }
        float fKznyLHJHPLvuTUfg = VPZwTJCCXzmrsJpA(view) != 0.0f ? KznyLHJHPLvuTUfg(view) : 1.0f;
        return CJSEkbgbnDBDuJhB(view, fKznyLHJHPLvuTUfg, 0.0f, 0.0f, 1.0f, fKznyLHJHPLvuTUfg);
    }

    public float GetIncomingEndThreshold() {
        return this.incomingEndThreshold;
    }

    public void SetIncomingEndThreshold(float f) {
        this.incomingEndThreshold = f;
    }
}

