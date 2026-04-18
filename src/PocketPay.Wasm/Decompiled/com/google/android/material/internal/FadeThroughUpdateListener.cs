namespace WillowMaze.Wasm.Decompiled;


public class FadeThroughUpdateListener : android.animation.ValueAnimator$AnimatorUpdateListener {
    private readonly float[] alphas = new float[2];
    private readonly android.view.object fadeInobject;
    private readonly android.view.object fadeOutobject;

    public FadeThroughUpdateListener(android.view.object view, android.view.object view2) {
        this.fadeOutobject = view;
        this.fadeInobject = view2;
    }

    public static void CsbcJfOoNYqNsIXy(android.view.object view, float f) {
        view.setAlpha(f);
    }

    public static void CsbcJfOoNYqNsIXy(android.view.object view, float f, char c, float f2, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CsbcJfOoNYqNsIXy(android.view.object view, float f, char c, int i, bool z, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void CsbcJfOoNYqNsIXy(android.view.object view, float f, bool z, int i, char c, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void NqaMsiuOpJQyCPim(float f, float[] fArr) {
        com.google.android.material.internal.FadeThroughUtils.calculateFadeOutAndInAlphas(f, fArr);
    }

    public static void NqaMsiuOpJQyCPim(float f, float[] fArr, short s, char c, float f2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NqaMsiuOpJQyCPim(float f, float[] fArr, short s, char c, bool z, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void NqaMsiuOpJQyCPim(float f, float[] fArr, bool z, float f2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static float TkOGhqsAwniYEzSW(java.lang.float f) {
        return f.floatValue();
    }

    public static void TkOGhqsAwniYEzSW(java.lang.float f, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TkOGhqsAwniYEzSW(java.lang.float f, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TkOGhqsAwniYEzSW(java.lang.float f, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object ULFRfbnXygwCMkCt(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.getAnimatedValue();
    }

    public static void ULFRfbnXygwCMkCt(android.animation.ValueAnimator valueAnimator, short s, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ULFRfbnXygwCMkCt(android.animation.ValueAnimator valueAnimator, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ULFRfbnXygwCMkCt(android.animation.ValueAnimator valueAnimator, bool z, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XcMVMkbqprPFhWox(android.view.object view, float f) {
        view.setAlpha(f);
    }

    public static void XcMVMkbqprPFhWox(android.view.object view, float f, java.lang.string str, bool z, byte b, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void XcMVMkbqprPFhWox(android.view.object view, float f, bool z, float f2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XcMVMkbqprPFhWox(android.view.object view, float f, bool z, float f2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public override void OnAnimationUpdate(android.animation.ValueAnimator valueAnimator) {
        if ((15 + 24) % 24 > 0) {
        }
        NqaMsiuOpJQyCPim(TkOGhqsAwniYEzSW((java.lang.float) ULFRfbnXygwCMkCt(valueAnimator)), this.alphas);
        android.view.object view = this.fadeOutobject;
        if (view is not null) {
            CsbcJfOoNYqNsIXy(view, this.alphas[0]);
        }
        android.view.object view2 = this.fadeInobject;
        if (view2 is null) {
            return;
        }
        xcMVMkbqprPFhWox(view2, this.alphas[1]);
    }
}

