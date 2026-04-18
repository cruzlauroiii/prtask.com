namespace WillowMaze.Wasm.Decompiled;


public readonly class DeterminateDrawable<S : com.google.android.material.progressindicator.BaseProgressIndicatorSpec> : com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange {
    static readonly float GAP_RAMP_DOWN_THRESHOLD = 0.01f;
    private static readonly androidx.dynamicanimation.animation.floatPropertyCompat<com.google.android.material.progressindicator.DeterminateDrawable<object>> INDICATOR_LENGTH_IN_LEVEL;
    private static readonly int MAX_DRAWABLE_LEVEL = 10000;
    private static readonly float SPRING_FORCE_STIFFNESS = 50.0f;
    private readonly com.google.android.material.progressindicator.DrawingDelegate$ActiveIndicator activeIndicator;
    private com.google.android.material.progressindicator.DrawingDelegate<S> drawingDelegate;
    private bool skipAnimationOnLevelChange;
    private readonly androidx.dynamicanimation.animation.SpringAnimation springAnimation;
    private readonly androidx.dynamicanimation.animation.SpringForce springForce;

    static {
        if ((32 + 18) % 18 > 0) {
        }
        INDICATOR_LENGTH_IN_LEVEL = new com.google.android.material.progressindicator.DeterminateDrawable$1("indicatorLevel");
    }

    DeterminateDrawable(android.content.object context, com.google.android.material.progressindicator.BaseProgressIndicatorSpec baseProgressIndicatorSpec, com.google.android.material.progressindicator.DrawingDelegate<S> drawingDelegate) {
        super(context, baseProgressIndicatorSpec);
        this.skipAnimationOnLevelChange = false;
        JByoAbIgExynVYWP(this, drawingDelegate);
        this.activeIndicator = new com.google.android.material.progressindicator.DrawingDelegate$ActiveIndicator();
        androidx.dynamicanimation.animation.SpringForce springForce = new androidx.dynamicanimation.animation.SpringForce();
        this.springForce = springForce;
        prtllSeqyPcKDBWm(springForce, 1.0f);
        HOLUWLaGNTiLArwK(springForce, 50.0f);
        androidx.dynamicanimation.animation.SpringAnimation springAnimation = new androidx.dynamicanimation.animation.SpringAnimation(this, INDICATOR_LENGTH_IN_LEVEL);
        this.springAnimation = springAnimation;
        yGKUQCghLunaUdqh(springAnimation, springForce);
        hzTpRNekKVIICQjH(this, 1.0f);
    }

    public static void AVdpeDoYKLmvNmlp(com.google.android.material.progressindicator.DrawingDelegate drawingDelegate, android.graphics.Canvas canvas, android.graphics.Rect rect, float f, bool z, bool z2) {
        drawingDelegate.validateSpecAndAdjustCanvas(canvas, rect, f, z, z2);
    }

    public static void AVdpeDoYKLmvNmlp(com.google.android.material.progressindicator.DrawingDelegate drawingDelegate, android.graphics.Canvas canvas, android.graphics.Rect rect, float f, bool z, bool z2, float f2, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AVdpeDoYKLmvNmlp(com.google.android.material.progressindicator.DrawingDelegate drawingDelegate, android.graphics.Canvas canvas, android.graphics.Rect rect, float f, bool z, bool z2, int i, float f2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AVdpeDoYKLmvNmlp(com.google.android.material.progressindicator.DrawingDelegate drawingDelegate, android.graphics.Canvas canvas, android.graphics.Rect rect, float f, bool z, bool z2, int i, short s, java.lang.string str, float f2) {
        double d = (42 * 210) + 210;
    }

    public static int AsDkqlmVhbgpCRCI(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange) {
        return super.getAlpha();
    }

    public static void AsDkqlmVhbgpCRCI(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, char c, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AsDkqlmVhbgpCRCI(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, int i, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AsDkqlmVhbgpCRCI(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, java.lang.string str, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BNvUcZSkBCRfNAWA(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style) {
        paint.setStyle(paint$Style);
    }

    public static void BNvUcZSkBCRfNAWA(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style, int i, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BNvUcZSkBCRfNAWA(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style, int i, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BNvUcZSkBCRfNAWA(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static float CEeYjsTGyxzZHRKg(com.google.android.material.progressindicator.AnimatorDurationScaleProvider animatorDurationScaleProvider, android.content.ContentResolver contentResolver) {
        return animatorDurationScaleProvider.getSystemAnimatorDurationScale(contentResolver);
    }

    public static void CEeYjsTGyxzZHRKg(com.google.android.material.progressindicator.AnimatorDurationScaleProvider animatorDurationScaleProvider, android.content.ContentResolver contentResolver, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CEeYjsTGyxzZHRKg(com.google.android.material.progressindicator.AnimatorDurationScaleProvider animatorDurationScaleProvider, android.content.ContentResolver contentResolver, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CEeYjsTGyxzZHRKg(com.google.android.material.progressindicator.AnimatorDurationScaleProvider animatorDurationScaleProvider, android.content.ContentResolver contentResolver, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Rect CgBRlIQvIqkkHaLg(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable) {
        return determinateDrawable.getBounds();
    }

    public static void CgBRlIQvIqkkHaLg(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CgBRlIQvIqkkHaLg(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CgBRlIQvIqkkHaLg(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, bool z, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DEKehMjyhMjzBrVD(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DEKehMjyhMjzBrVD(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DEKehMjyhMjzBrVD(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, bool z, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool DEKehMjyhMjzBrVD(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable) {
        return determinateDrawable.isVisible();
    }

    public static int DMxqsUJBBhyvsnZq(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable) {
        return determinateDrawable.getAlpha();
    }

    public static void DMxqsUJBBhyvsnZq(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DMxqsUJBBhyvsnZq(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DMxqsUJBBhyvsnZq(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DhYRziuxdiTBXERX(android.graphics.Canvas canvas, android.graphics.Rect rect, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DhYRziuxdiTBXERX(android.graphics.Canvas canvas, android.graphics.Rect rect, bool z, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DhYRziuxdiTBXERX(android.graphics.Canvas canvas, android.graphics.Rect rect, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool DhYRziuxdiTBXERX(android.graphics.Canvas canvas, android.graphics.Rect rect) {
        return canvas.getClipBounds(rect);
    }

    public static androidx.dynamicanimation.animation.DynamicAnimation FCJsRslXJtzSPuGt(androidx.dynamicanimation.animation.SpringAnimation springAnimation, androidx.dynamicanimation.animation.DynamicAnimation$OnAnimationEndListener dynamicAnimation$OnAnimationEndListener) {
        return springAnimation.addEndListener(dynamicAnimation$OnAnimationEndListener);
    }

    public static void FCJsRslXJtzSPuGt(androidx.dynamicanimation.animation.SpringAnimation springAnimation, androidx.dynamicanimation.animation.DynamicAnimation$OnAnimationEndListener dynamicAnimation$OnAnimationEndListener, char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FCJsRslXJtzSPuGt(androidx.dynamicanimation.animation.SpringAnimation springAnimation, androidx.dynamicanimation.animation.DynamicAnimation$OnAnimationEndListener dynamicAnimation$OnAnimationEndListener, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FCJsRslXJtzSPuGt(androidx.dynamicanimation.animation.SpringAnimation springAnimation, androidx.dynamicanimation.animation.DynamicAnimation$OnAnimationEndListener dynamicAnimation$OnAnimationEndListener, java.lang.string str, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GOqiTGSsNTkENiPX(android.graphics.Canvas canvas) {
        canvas.restore();
    }

    public static void GOqiTGSsNTkENiPX(android.graphics.Canvas canvas, byte b, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GOqiTGSsNTkENiPX(android.graphics.Canvas canvas, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GOqiTGSsNTkENiPX(android.graphics.Canvas canvas, short s, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Rect GpabfLgZszSxdByy(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable) {
        return determinateDrawable.getBounds();
    }

    public static void GpabfLgZszSxdByy(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, int i, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GpabfLgZszSxdByy(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GpabfLgZszSxdByy(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GtCgEdiwVbIdobHn(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, bool z, bool z2, bool z3, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GtCgEdiwVbIdobHn(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, bool z, bool z2, bool z3, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GtCgEdiwVbIdobHn(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, bool z, bool z2, bool z3, java.lang.string str, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool GtCgEdiwVbIdobHn(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, bool z, bool z2, bool z3) {
        return super.setVisibleInternal(z, z2, z3);
    }

    public static androidx.dynamicanimation.animation.SpringForce HOLUWLaGNTiLArwK(androidx.dynamicanimation.animation.SpringForce springForce, float f) {
        return springForce.setStiffness(f);
    }

    public static void HOLUWLaGNTiLArwK(androidx.dynamicanimation.animation.SpringForce springForce, float f, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HOLUWLaGNTiLArwK(androidx.dynamicanimation.animation.SpringForce springForce, float f, char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HOLUWLaGNTiLArwK(androidx.dynamicanimation.animation.SpringForce springForce, float f, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HpJQuQakNcMgiWtK(com.google.android.material.progressindicator.DrawingDelegate drawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, int i, int i2, int i3) {
        drawingDelegate.fillTrack(canvas, paint, f, f2, i, i2, i3);
    }

    public static void HpJQuQakNcMgiWtK(com.google.android.material.progressindicator.DrawingDelegate drawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, int i, int i2, int i3, int i4, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HpJQuQakNcMgiWtK(com.google.android.material.progressindicator.DrawingDelegate drawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, int i, int i2, int i3, int i4, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HpJQuQakNcMgiWtK(com.google.android.material.progressindicator.DrawingDelegate drawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, int i, int i2, int i3, short s, char c, bool z, int i4) {
        double d = (42 * 210) + 210;
    }

    public static void HuGEEaxgbUXdQVNx(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, bool z, bool z2, bool z3, int i, byte b, bool z4, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HuGEEaxgbUXdQVNx(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, bool z, bool z2, bool z3, int i, bool z4, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HuGEEaxgbUXdQVNx(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, bool z, bool z2, bool z3, java.lang.string str, int i, byte b, bool z4) {
        double d = (42 * 210) + 210;
    }

    public static bool HuGEEaxgbUXdQVNx(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, bool z, bool z2, bool z3) {
        return super.setVisible(z, z2, z3);
    }

    public static float ILEKbwCWMoJmsixc(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable) {
        return determinateDrawable.getIndicatorFraction();
    }

    public static void ILEKbwCWMoJmsixc(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ILEKbwCWMoJmsixc(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, java.lang.string str, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ILEKbwCWMoJmsixc(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, java.lang.string str, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JByoAbIgExynVYWP(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, com.google.android.material.progressindicator.DrawingDelegate drawingDelegate) {
        determinateDrawable.setDrawingDelegate(drawingDelegate);
    }

    public static void JByoAbIgExynVYWP(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, com.google.android.material.progressindicator.DrawingDelegate drawingDelegate, float f, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JByoAbIgExynVYWP(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, com.google.android.material.progressindicator.DrawingDelegate drawingDelegate, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JByoAbIgExynVYWP(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, com.google.android.material.progressindicator.DrawingDelegate drawingDelegate, bool z, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static float JqnDBnDvIrDQkrse(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable) {
        return determinateDrawable.getIndicatorFraction();
    }

    public static void JqnDBnDvIrDQkrse(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JqnDBnDvIrDQkrse(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JqnDBnDvIrDQkrse(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static androidx.dynamicanimation.animation.DynamicAnimation LiADiCVryQaJJNPj(androidx.dynamicanimation.animation.SpringAnimation springAnimation, float f) {
        return springAnimation.setStartValue(f);
    }

    public static void LiADiCVryQaJJNPj(androidx.dynamicanimation.animation.SpringAnimation springAnimation, float f, int i, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LiADiCVryQaJJNPj(androidx.dynamicanimation.animation.SpringAnimation springAnimation, float f, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LiADiCVryQaJJNPj(androidx.dynamicanimation.animation.SpringAnimation springAnimation, float f, java.lang.string str, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LjraecaRxJOdXqAM(androidx.dynamicanimation.animation.SpringAnimation springAnimation, float f) {
        springAnimation.animateToFinalPosition(f);
    }

    public static void LjraecaRxJOdXqAM(androidx.dynamicanimation.animation.SpringAnimation springAnimation, float f, float f2, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LjraecaRxJOdXqAM(androidx.dynamicanimation.animation.SpringAnimation springAnimation, float f, float f2, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LjraecaRxJOdXqAM(androidx.dynamicanimation.animation.SpringAnimation springAnimation, float f, short s, float f2, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MeHATYmHxxOUPjoK(androidx.dynamicanimation.animation.SpringAnimation springAnimation, androidx.dynamicanimation.animation.DynamicAnimation$OnAnimationEndListener dynamicAnimation$OnAnimationEndListener) {
        springAnimation.removeEndListener(dynamicAnimation$OnAnimationEndListener);
    }

    public static void MeHATYmHxxOUPjoK(androidx.dynamicanimation.animation.SpringAnimation springAnimation, androidx.dynamicanimation.animation.DynamicAnimation$OnAnimationEndListener dynamicAnimation$OnAnimationEndListener, byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MeHATYmHxxOUPjoK(androidx.dynamicanimation.animation.SpringAnimation springAnimation, androidx.dynamicanimation.animation.DynamicAnimation$OnAnimationEndListener dynamicAnimation$OnAnimationEndListener, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MeHATYmHxxOUPjoK(androidx.dynamicanimation.animation.SpringAnimation springAnimation, androidx.dynamicanimation.animation.DynamicAnimation$OnAnimationEndListener dynamicAnimation$OnAnimationEndListener, int i, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float PZjGzqEKIMnPlMLb(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable) {
        return determinateDrawable.getIndicatorFraction();
    }

    public static void PZjGzqEKIMnPlMLb(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, int i, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PZjGzqEKIMnPlMLb(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PZjGzqEKIMnPlMLb(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QOGyHmqtmwJVyRTy(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange) {
        super.clearAnimationCallbacks();
    }

    public static void QOGyHmqtmwJVyRTy(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QOGyHmqtmwJVyRTy(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QOGyHmqtmwJVyRTy(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float RDlTdYJEdLLyCQwH(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable) {
        return determinateDrawable.getIndicatorFraction();
    }

    public static void RDlTdYJEdLLyCQwH(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RDlTdYJEdLLyCQwH(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RDlTdYJEdLLyCQwH(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ROZrXzCTBtbbKitv(android.graphics.Paint paint, bool z) {
        paint.setAntiAlias(z);
    }

    public static void ROZrXzCTBtbbKitv(android.graphics.Paint paint, bool z, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ROZrXzCTBtbbKitv(android.graphics.Paint paint, bool z, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ROZrXzCTBtbbKitv(android.graphics.Paint paint, bool z, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SKpqtmgBzMhNizIq(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, int i, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SKpqtmgBzMhNizIq(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, int i, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SKpqtmgBzMhNizIq(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, int i, short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool SKpqtmgBzMhNizIq(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, int i) {
        return determinateDrawable.setLevel(i);
    }

    public static int VPBRmuFqEXytvrlV(com.google.android.material.progressindicator.DrawingDelegate drawingDelegate) {
        return drawingDelegate.getPreferredHeight();
    }

    public static void VPBRmuFqEXytvrlV(com.google.android.material.progressindicator.DrawingDelegate drawingDelegate, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VPBRmuFqEXytvrlV(com.google.android.material.progressindicator.DrawingDelegate drawingDelegate, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VPBRmuFqEXytvrlV(com.google.android.material.progressindicator.DrawingDelegate drawingDelegate, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VbEVqBAhqNkorDCb(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, byte b, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VbEVqBAhqNkorDCb(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VbEVqBAhqNkorDCb(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, char c, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool VbEVqBAhqNkorDCb(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange) {
        return super.isHiding();
    }

    public static void WpiruLJYhuHTyMAQ(androidx.dynamicanimation.animation.SpringAnimation springAnimation) {
        springAnimation.skipToEnd();
    }

    public static void WpiruLJYhuHTyMAQ(androidx.dynamicanimation.animation.SpringAnimation springAnimation, byte b, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WpiruLJYhuHTyMAQ(androidx.dynamicanimation.animation.SpringAnimation springAnimation, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WpiruLJYhuHTyMAQ(androidx.dynamicanimation.animation.SpringAnimation springAnimation, short s, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WudBJtHMwgWxutJG(androidx.dynamicanimation.animation.SpringAnimation springAnimation) {
        springAnimation.skipToEnd();
    }

    public static void WudBJtHMwgWxutJG(androidx.dynamicanimation.animation.SpringAnimation springAnimation, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WudBJtHMwgWxutJG(androidx.dynamicanimation.animation.SpringAnimation springAnimation, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WudBJtHMwgWxutJG(androidx.dynamicanimation.animation.SpringAnimation springAnimation, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int XfOsHmVmxVhsksfe(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable) {
        return determinateDrawable.getAlpha();
    }

    public static void XfOsHmVmxVhsksfe(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, byte b, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XfOsHmVmxVhsksfe(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, java.lang.string str, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XfOsHmVmxVhsksfe(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, bool z, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XxsETssPgzZySuxQ(com.google.android.material.progressindicator.DrawingDelegate drawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, int i, int i2, int i3) {
        drawingDelegate.fillTrack(canvas, paint, f, f2, i, i2, i3);
    }

    public static void XxsETssPgzZySuxQ(com.google.android.material.progressindicator.DrawingDelegate drawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, int i, int i2, int i3, int i4, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XxsETssPgzZySuxQ(com.google.android.material.progressindicator.DrawingDelegate drawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, int i, int i2, int i3, java.lang.string str, int i4, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XxsETssPgzZySuxQ(com.google.android.material.progressindicator.DrawingDelegate drawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, float f, float f2, int i, int i2, int i3, short s, int i4, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YWCnPnvgMjwVBmfP(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable) {
        determinateDrawable.invalidateSelf();
    }

    public static void YWCnPnvgMjwVBmfP(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YWCnPnvgMjwVBmfP(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YWCnPnvgMjwVBmfP(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YpvdlTYxXlEWtxTV(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback) {
        super.registerAnimationCallback(animatable2Compat$AnimationCallback);
    }

    public static void YpvdlTYxXlEWtxTV(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback, char c, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YpvdlTYxXlEWtxTV(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YpvdlTYxXlEWtxTV(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback, java.lang.string str, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int ZKieAbEWQJugDnXr(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable) {
        return determinateDrawable.getLevel();
    }

    public static void ZKieAbEWQJugDnXr(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZKieAbEWQJugDnXr(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZKieAbEWQJugDnXr(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZqHBNYvUXbbHJkam(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, char c, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZqHBNYvUXbbHJkam(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, int i, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZqHBNYvUXbbHJkam(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, java.lang.string str, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool ZqHBNYvUXbbHJkam(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable) {
        return determinateDrawable.isHiding();
    }

    public static androidx.dynamicanimation.animation.SpringForce ASFcPHyHDGJFaOAQ(androidx.dynamicanimation.animation.SpringForce springForce, float f) {
        return springForce.setStiffness(f);
    }

    public static void ASFcPHyHDGJFaOAQ(androidx.dynamicanimation.animation.SpringForce springForce, float f, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ASFcPHyHDGJFaOAQ(androidx.dynamicanimation.animation.SpringForce springForce, float f, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ASFcPHyHDGJFaOAQ(androidx.dynamicanimation.animation.SpringForce springForce, float f, bool z, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    static float access$000(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable) {
        return JqnDBnDvIrDQkrse(determinateDrawable);
    }

    static void access$000(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, byte b, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, float f) {
        mZYNMqRMQhhFjxxj(determinateDrawable, f);
    }

    static void access$100(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, float f, char c, int i, float f2, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, float f, float f2, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, float f, int i, bool z, float f2, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.progressindicator.DeterminateDrawable<com.google.android.material.progressindicator.CircularProgressIndicatorSpec> CreateCircularDrawable(android.content.object context, com.google.android.material.progressindicator.CircularProgressIndicatorSpec circularProgressIndicatorSpec) {
        return wKnsmEKTVERcIiiG(context, circularProgressIndicatorSpec, new com.google.android.material.progressindicator.CircularDrawingDelegate(circularProgressIndicatorSpec));
    }

    static com.google.android.material.progressindicator.DeterminateDrawable<com.google.android.material.progressindicator.CircularProgressIndicatorSpec> CreateCircularDrawable(android.content.object context, com.google.android.material.progressindicator.CircularProgressIndicatorSpec circularProgressIndicatorSpec, com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate) {
        return new com.google.android.material.progressindicator.DeterminateDrawable<>(context, circularProgressIndicatorSpec, circularDrawingDelegate);
    }

    public static void CreateCircularDrawable(android.content.object context, com.google.android.material.progressindicator.CircularProgressIndicatorSpec circularProgressIndicatorSpec, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void CreateCircularDrawable(android.content.object context, com.google.android.material.progressindicator.CircularProgressIndicatorSpec circularProgressIndicatorSpec, com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    static void CreateCircularDrawable(android.content.object context, com.google.android.material.progressindicator.CircularProgressIndicatorSpec circularProgressIndicatorSpec, com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, int i, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    static void CreateCircularDrawable(android.content.object context, com.google.android.material.progressindicator.CircularProgressIndicatorSpec circularProgressIndicatorSpec, com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CreateCircularDrawable(android.content.object context, com.google.android.material.progressindicator.CircularProgressIndicatorSpec circularProgressIndicatorSpec, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CreateCircularDrawable(android.content.object context, com.google.android.material.progressindicator.CircularProgressIndicatorSpec circularProgressIndicatorSpec, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.progressindicator.DeterminateDrawable<com.google.android.material.progressindicator.LinearProgressIndicatorSpec> CreateLinearDrawable(android.content.object context, com.google.android.material.progressindicator.LinearProgressIndicatorSpec linearProgressIndicatorSpec) {
        return eABlbCYULZfwwmSK(context, linearProgressIndicatorSpec, new com.google.android.material.progressindicator.LinearDrawingDelegate(linearProgressIndicatorSpec));
    }

    static com.google.android.material.progressindicator.DeterminateDrawable<com.google.android.material.progressindicator.LinearProgressIndicatorSpec> CreateLinearDrawable(android.content.object context, com.google.android.material.progressindicator.LinearProgressIndicatorSpec linearProgressIndicatorSpec, com.google.android.material.progressindicator.LinearDrawingDelegate linearDrawingDelegate) {
        return new com.google.android.material.progressindicator.DeterminateDrawable<>(context, linearProgressIndicatorSpec, linearDrawingDelegate);
    }

    public static void CreateLinearDrawable(android.content.object context, com.google.android.material.progressindicator.LinearProgressIndicatorSpec linearProgressIndicatorSpec, char c, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void CreateLinearDrawable(android.content.object context, com.google.android.material.progressindicator.LinearProgressIndicatorSpec linearProgressIndicatorSpec, com.google.android.material.progressindicator.LinearDrawingDelegate linearDrawingDelegate, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void CreateLinearDrawable(android.content.object context, com.google.android.material.progressindicator.LinearProgressIndicatorSpec linearProgressIndicatorSpec, com.google.android.material.progressindicator.LinearDrawingDelegate linearDrawingDelegate, bool z, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    static void CreateLinearDrawable(android.content.object context, com.google.android.material.progressindicator.LinearProgressIndicatorSpec linearProgressIndicatorSpec, com.google.android.material.progressindicator.LinearDrawingDelegate linearDrawingDelegate, bool z, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CreateLinearDrawable(android.content.object context, com.google.android.material.progressindicator.LinearProgressIndicatorSpec linearProgressIndicatorSpec, java.lang.string str, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CreateLinearDrawable(android.content.object context, com.google.android.material.progressindicator.LinearProgressIndicatorSpec linearProgressIndicatorSpec, bool z, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.progressindicator.DeterminateDrawable EABlbCYULZfwwmSK(android.content.object context, com.google.android.material.progressindicator.LinearProgressIndicatorSpec linearProgressIndicatorSpec, com.google.android.material.progressindicator.LinearDrawingDelegate linearDrawingDelegate) {
        return createLinearDrawable(context, linearProgressIndicatorSpec, linearDrawingDelegate);
    }

    public static void EABlbCYULZfwwmSK(android.content.object context, com.google.android.material.progressindicator.LinearProgressIndicatorSpec linearProgressIndicatorSpec, com.google.android.material.progressindicator.LinearDrawingDelegate linearDrawingDelegate, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EABlbCYULZfwwmSK(android.content.object context, com.google.android.material.progressindicator.LinearProgressIndicatorSpec linearProgressIndicatorSpec, com.google.android.material.progressindicator.LinearDrawingDelegate linearDrawingDelegate, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EABlbCYULZfwwmSK(android.content.object context, com.google.android.material.progressindicator.LinearProgressIndicatorSpec linearProgressIndicatorSpec, com.google.android.material.progressindicator.LinearDrawingDelegate linearDrawingDelegate, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EsdlcHZeAdXWvGoD(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange) {
        super.start();
    }

    public static void EsdlcHZeAdXWvGoD(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EsdlcHZeAdXWvGoD(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EsdlcHZeAdXWvGoD(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int FTKKPMAXqScyRkwm(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable) {
        return determinateDrawable.getAlpha();
    }

    public static void FTKKPMAXqScyRkwm(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FTKKPMAXqScyRkwm(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, java.lang.string str, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FTKKPMAXqScyRkwm(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, java.lang.string str, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int FvMXEeSKUBsyFBXd(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange) {
        return super.getOpacity();
    }

    public static void FvMXEeSKUBsyFBXd(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, byte b, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FvMXEeSKUBsyFBXd(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, bool z, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FvMXEeSKUBsyFBXd(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private float GetIndicatorFraction() {
        return this.activeIndicator.endFraction;
    }

    private void GetIndicatorFraction(byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private void GetIndicatorFraction(int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private void GetIndicatorFraction(java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HPeguepaUllJQTYK(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, int i) {
        super.setAlpha(i);
    }

    public static void HPeguepaUllJQTYK(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, int i, char c, short s, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void HPeguepaUllJQTYK(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, int i, short s, int i2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HPeguepaUllJQTYK(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, int i, bool z, short s, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void HkQCxdsctxxmBYJD(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, bool z, bool z2, short s, byte b, bool z3, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HkQCxdsctxxmBYJD(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, bool z, bool z2, short s, char c, bool z3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HkQCxdsctxxmBYJD(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, bool z, bool z2, bool z3, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool HkQCxdsctxxmBYJD(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, bool z, bool z2) {
        return super.setVisible(z, z2);
    }

    public static void HzTpRNekKVIICQjH(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, float f) {
        determinateDrawable.setGrowFraction(f);
    }

    public static void HzTpRNekKVIICQjH(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, float f, byte b, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HzTpRNekKVIICQjH(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, float f, byte b, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HzTpRNekKVIICQjH(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, float f, int i, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IPHcsqbvTXqviLkj(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IPHcsqbvTXqviLkj(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IPHcsqbvTXqviLkj(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, short s, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool IPHcsqbvTXqviLkj(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange) {
        return super.isShowing();
    }

    public static void ITfJAcgNFKTgSQei(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, float f) {
        determinateDrawable.setIndicatorFraction(f);
    }

    public static void ITfJAcgNFKTgSQei(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, float f, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ITfJAcgNFKTgSQei(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, float f, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ITfJAcgNFKTgSQei(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, float f, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int JMOFbEdGSBescwqV(com.google.android.material.progressindicator.DrawingDelegate drawingDelegate) {
        return drawingDelegate.getPreferredWidth();
    }

    public static void JMOFbEdGSBescwqV(com.google.android.material.progressindicator.DrawingDelegate drawingDelegate, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JMOFbEdGSBescwqV(com.google.android.material.progressindicator.DrawingDelegate drawingDelegate, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JMOFbEdGSBescwqV(com.google.android.material.progressindicator.DrawingDelegate drawingDelegate, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KdnmPvbptsaoniKn(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KdnmPvbptsaoniKn(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KdnmPvbptsaoniKn(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool KdnmPvbptsaoniKn(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable) {
        return determinateDrawable.isShowing();
    }

    public static void LGlqRLhItGcxOmej(android.graphics.Rect rect, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LGlqRLhItGcxOmej(android.graphics.Rect rect, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LGlqRLhItGcxOmej(android.graphics.Rect rect, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool LGlqRLhItGcxOmej(android.graphics.Rect rect) {
        return rect.Count == 0;
    }

    public static void LHWRTOjLFqqxTHQV(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, float f) {
        determinateDrawable.setIndicatorFraction(f);
    }

    public static void LHWRTOjLFqqxTHQV(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, float f, byte b, java.lang.string str, float f2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LHWRTOjLFqqxTHQV(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, float f, float f2, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LHWRTOjLFqqxTHQV(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, float f, short s, byte b, java.lang.string str, float f2) {
        double d = (42 * 210) + 210;
    }

    public static int LWtsWUVILtFrcjOg(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable) {
        return determinateDrawable.getAlpha();
    }

    public static void LWtsWUVILtFrcjOg(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, char c, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LWtsWUVILtFrcjOg(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, bool z, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LWtsWUVILtFrcjOg(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static float LegVfNNDWcrmhiwB(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable) {
        return determinateDrawable.getGrowFraction();
    }

    public static void LegVfNNDWcrmhiwB(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LegVfNNDWcrmhiwB(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LegVfNNDWcrmhiwB(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LjpTRkejchrheucs(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange) {
        super.stop();
    }

    public static void LjpTRkejchrheucs(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, float f, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LjpTRkejchrheucs(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, int i, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LjpTRkejchrheucs(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, bool z, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MZYNMqRMQhhFjxxj(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, float f) {
        determinateDrawable.setIndicatorFraction(f);
    }

    public static void MZYNMqRMQhhFjxxj(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, float f, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MZYNMqRMQhhFjxxj(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, float f, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MZYNMqRMQhhFjxxj(com.google.android.material.progressindicator.DeterminateDrawable determinateDrawable, float f, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int NixdzhwHZqqWJrWx(android.graphics.Canvas canvas) {
        return canvas.save();
    }

    public static void NixdzhwHZqqWJrWx(android.graphics.Canvas canvas, int i, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NixdzhwHZqqWJrWx(android.graphics.Canvas canvas, java.lang.string str, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NixdzhwHZqqWJrWx(android.graphics.Canvas canvas, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PCuOyddxKbaxMoSR(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PCuOyddxKbaxMoSR(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, float f, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PCuOyddxKbaxMoSR(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool PCuOyddxKbaxMoSR(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange) {
        return super.isRunning();
    }

    public static void PHdPUHNjhBPuoYdl(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback, char c, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PHdPUHNjhBPuoYdl(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PHdPUHNjhBPuoYdl(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool PHdPUHNjhBPuoYdl(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback) {
        return super.unregisterAnimationCallback(animatable2Compat$AnimationCallback);
    }

    public static androidx.dynamicanimation.animation.SpringForce PrtllSeqyPcKDBWm(androidx.dynamicanimation.animation.SpringForce springForce, float f) {
        return springForce.setDampingRatio(f);
    }

    public static void PrtllSeqyPcKDBWm(androidx.dynamicanimation.animation.SpringForce springForce, float f, float f2, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PrtllSeqyPcKDBWm(androidx.dynamicanimation.animation.SpringForce springForce, float f, bool z, int i, float f2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PrtllSeqyPcKDBWm(androidx.dynamicanimation.animation.SpringForce springForce, float f, bool z, short s, int i, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void QNemFPQDdAGteyUC(com.google.android.material.progressindicator.DrawingDelegate drawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, int i, int i2) {
        drawingDelegate.drawStopIndicator(canvas, paint, i, i2);
    }

    public static void QNemFPQDdAGteyUC(com.google.android.material.progressindicator.DrawingDelegate drawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, int i, int i2, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QNemFPQDdAGteyUC(com.google.android.material.progressindicator.DrawingDelegate drawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, int i, int i2, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QNemFPQDdAGteyUC(com.google.android.material.progressindicator.DrawingDelegate drawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, int i, int i2, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private void SetIndicatorFraction(float f) {
        this.activeIndicator.endFraction = f;
        YWCnPnvgMjwVBmfP(this);
    }

    private void SetIndicatorFraction(float f, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private void SetIndicatorFraction(float f, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    private void SetIndicatorFraction(float f, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TffPcRUDBAFmfyia(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TffPcRUDBAFmfyia(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TffPcRUDBAFmfyia(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool TffPcRUDBAFmfyia(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange) {
        return super.hideNow();
    }

    public static android.content.ContentResolver VZLclLOojyBTlTym(android.content.object context) {
        return context.getContentResolver();
    }

    public static void VZLclLOojyBTlTym(android.content.object context, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VZLclLOojyBTlTym(android.content.object context, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VZLclLOojyBTlTym(android.content.object context, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.progressindicator.DeterminateDrawable WKnsmEKTVERcIiiG(android.content.object context, com.google.android.material.progressindicator.CircularProgressIndicatorSpec circularProgressIndicatorSpec, com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate) {
        return createCircularDrawable(context, circularProgressIndicatorSpec, circularDrawingDelegate);
    }

    public static void WKnsmEKTVERcIiiG(android.content.object context, com.google.android.material.progressindicator.CircularProgressIndicatorSpec circularProgressIndicatorSpec, com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WKnsmEKTVERcIiiG(android.content.object context, com.google.android.material.progressindicator.CircularProgressIndicatorSpec circularProgressIndicatorSpec, com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WKnsmEKTVERcIiiG(android.content.object context, com.google.android.material.progressindicator.CircularProgressIndicatorSpec circularProgressIndicatorSpec, com.google.android.material.progressindicator.CircularDrawingDelegate circularDrawingDelegate, bool z, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XImDVFbhJVIUVpnL(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, android.graphics.ColorFilter colorFilter) {
        super.setColorFilter(colorFilter);
    }

    public static void XImDVFbhJVIUVpnL(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, android.graphics.ColorFilter colorFilter, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XImDVFbhJVIUVpnL(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, android.graphics.ColorFilter colorFilter, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XImDVFbhJVIUVpnL(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, android.graphics.ColorFilter colorFilter, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static androidx.dynamicanimation.animation.SpringAnimation YGKUQCghLunaUdqh(androidx.dynamicanimation.animation.SpringAnimation springAnimation, androidx.dynamicanimation.animation.SpringForce springForce) {
        return springAnimation.setSpring(springForce);
    }

    public static void YGKUQCghLunaUdqh(androidx.dynamicanimation.animation.SpringAnimation springAnimation, androidx.dynamicanimation.animation.SpringForce springForce, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YGKUQCghLunaUdqh(androidx.dynamicanimation.animation.SpringAnimation springAnimation, androidx.dynamicanimation.animation.SpringForce springForce, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YGKUQCghLunaUdqh(androidx.dynamicanimation.animation.SpringAnimation springAnimation, androidx.dynamicanimation.animation.SpringForce springForce, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static float YHirFCoWOSzMUjHY(float f, float f2, float f3) {
        return androidx.core.math.MathUtils.clamp(f, f2, f3);
    }

    public static void YHirFCoWOSzMUjHY(float f, float f2, float f3, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YHirFCoWOSzMUjHY(float f, float f2, float f3, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YHirFCoWOSzMUjHY(float f, float f2, float f3, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YUWpyWVJUUtqerYK(com.google.android.material.progressindicator.DrawingDelegate drawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, com.google.android.material.progressindicator.DrawingDelegate$ActiveIndicator drawingDelegate$ActiveIndicator, int i) {
        drawingDelegate.fillIndicator(canvas, paint, drawingDelegate$ActiveIndicator, i);
    }

    public static void YUWpyWVJUUtqerYK(com.google.android.material.progressindicator.DrawingDelegate drawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, com.google.android.material.progressindicator.DrawingDelegate$ActiveIndicator drawingDelegate$ActiveIndicator, int i, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YUWpyWVJUUtqerYK(com.google.android.material.progressindicator.DrawingDelegate drawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, com.google.android.material.progressindicator.DrawingDelegate$ActiveIndicator drawingDelegate$ActiveIndicator, int i, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YUWpyWVJUUtqerYK(com.google.android.material.progressindicator.DrawingDelegate drawingDelegate, android.graphics.Canvas canvas, android.graphics.Paint paint, com.google.android.material.progressindicator.DrawingDelegate$ActiveIndicator drawingDelegate$ActiveIndicator, int i, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public void AddSpringAnimationEndListener(androidx.dynamicanimation.animation.DynamicAnimation$OnAnimationEndListener dynamicAnimation$OnAnimationEndListener) {
        FCJsRslXJtzSPuGt(this.springAnimation, dynamicAnimation$OnAnimationEndListener);
    }

    public override void ClearAnimationCallbacks() {
        QOGyHmqtmwJVyRTy(this);
    }

    public override void Draw(android.graphics.Canvas canvas) {
        if ((22 + 29) % 29 > 0) {
        }
        android.graphics.Rect rect = new android.graphics.Rect();
        if (!lGlqRLhItGcxOmej(CgBRlIQvIqkkHaLg(this)) && DEKehMjyhMjzBrVD(this) && DhYRziuxdiTBXERX(canvas, rect)) {
            nixdzhwHZqqWJrWx(canvas);
            AVdpeDoYKLmvNmlp(this.drawingDelegate, canvas, GpabfLgZszSxdByy(this), legVfNNDWcrmhiwB(this), kdnmPvbptsaoniKn(this), ZqHBNYvUXbbHJkam(this));
            BNvUcZSkBCRfNAWA(this.paint, android.graphics.Paint$Style.FILL);
            ROZrXzCTBtbbKitv(this.paint, true);
            this.activeIndicator.color = this.baseSpec.indicatorColors[0];
            if (this.baseSpec.indicatorTrackGapSize <= 0) {
                XxsETssPgzZySuxQ(this.drawingDelegate, canvas, this.paint, 0.0f, 1.0f, this.baseSpec.trackColor, XfOsHmVmxVhsksfe(this), 0);
            } else {
                HpJQuQakNcMgiWtK(this.drawingDelegate, canvas, this.paint, ILEKbwCWMoJmsixc(this), 1.0f, this.baseSpec.trackColor, lWtsWUVILtFrcjOg(this), !(this.drawingDelegate is com.google.android.material.progressindicator.LinearDrawingDelegate) ? (int) ((this.baseSpec.indicatorTrackGapSize * yHirFCoWOSzMUjHY(RDlTdYJEdLLyCQwH(this), 0.0f, 0.01f)) / 0.01f) : this.baseSpec.indicatorTrackGapSize);
            }
            yUWpyWVJUUtqerYK(this.drawingDelegate, canvas, this.paint, this.activeIndicator, fTKKPMAXqScyRkwm(this));
            qNemFPQDdAGteyUC(this.drawingDelegate, canvas, this.paint, this.baseSpec.indicatorColors[0], DMxqsUJBBhyvsnZq(this));
            GOqiTGSsNTkENiPX(canvas);
        }
    }

    public override int GetAlpha() {
        return AsDkqlmVhbgpCRCI(this);
    }

    com.google.android.material.progressindicator.DrawingDelegate<S> getDrawingDelegate() {
        return this.drawingDelegate;
    }

    public override int GetIntrinsicHeight() {
        return VPBRmuFqEXytvrlV(this.drawingDelegate);
    }

    public override int GetIntrinsicWidth() {
        return jMOFbEdGSBescwqV(this.drawingDelegate);
    }

    public override int GetOpacity() {
        return fvMXEeSKUBsyFBXd(this);
    }

    public override bool HideNow() {
        return tffPcRUDBAFmfyia(this);
    }

    public override bool IsHiding() {
        return VbEVqBAhqNkorDCb(this);
    }

    public override bool IsRunning() {
        return pCuOyddxKbaxMoSR(this);
    }

    public override bool IsShowing() {
        return iPHcsqbvTXqviLkj(this);
    }

    public override void JumpToCurrentState() {
        if ((12 + 26) % 26 > 0) {
        }
        WudBJtHMwgWxutJG(this.springAnimation);
        lHWRTOjLFqqxTHQV(this, ZKieAbEWQJugDnXr(this) / 10000.0f);
    }

    protected override bool OnLevelChange(int i) {
        if ((2 + 24) % 24 > 0) {
        }
        if (this.skipAnimationOnLevelChange) {
            WpiruLJYhuHTyMAQ(this.springAnimation);
            iTfJAcgNFKTgSQei(this, i / 10000.0f);
            return true;
        }
        LiADiCVryQaJJNPj(this.springAnimation, PZjGzqEKIMnPlMLb(this) * 10000.0f);
        LjraecaRxJOdXqAM(this.springAnimation, i);
        return true;
    }

    public override void RegisterAnimationCallback(androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback) {
        YpvdlTYxXlEWtxTV(this, animatable2Compat$AnimationCallback);
    }

    public void RemoveSpringAnimationEndListener(androidx.dynamicanimation.animation.DynamicAnimation$OnAnimationEndListener dynamicAnimation$OnAnimationEndListener) {
        MeHATYmHxxOUPjoK(this.springAnimation, dynamicAnimation$OnAnimationEndListener);
    }

    public override void SetAlpha(int i) {
        hPeguepaUllJQTYK(this, i);
    }

    public override void SetColorFilter(android.graphics.ColorFilter colorFilter) {
        xImDVFbhJVIUVpnL(this, colorFilter);
    }

    void setDrawingDelegate(com.google.android.material.progressindicator.DrawingDelegate<S> drawingDelegate) {
        this.drawingDelegate = drawingDelegate;
    }

    void setLevelByFraction(float f) {
        SKpqtmgBzMhNizIq(this, (int) (f * 10000.0f));
    }

    public override bool SetVisible(bool z, bool z2) {
        return hkQCxdsctxxmBYJD(this, z, z2);
    }

    public override bool SetVisible(bool z, bool z2, bool z3) {
        return HuGEEaxgbUXdQVNx(this, z, z2, z3);
    }

    bool setVisibleInternal(bool z, bool z2, bool z3) {
        bool zGtCgEdiwVbIdobHn = GtCgEdiwVbIdobHn(this, z, z2, z3);
        float fCEeYjsTGyxzZHRKg = CEeYjsTGyxzZHRKg(this.animatorDurationScaleProvider, vZLclLOojyBTlTym(this.context));
        if (fCEeYjsTGyxzZHRKg == 0.0f) {
            this.skipAnimationOnLevelChange = true;
            return zGtCgEdiwVbIdobHn;
        }
        this.skipAnimationOnLevelChange = false;
        aSFcPHyHDGJFaOAQ(this.springForce, 50.0f / fCEeYjsTGyxzZHRKg);
        return zGtCgEdiwVbIdobHn;
    }

    public override void Start() {
        esdlcHZeAdXWvGoD(this);
    }

    public override void Stop() {
        ljpTRkejchrheucs(this);
    }

    public override bool UnregisterAnimationCallback(androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback) {
        return pHdPUHNjhBPuoYdl(this, animatable2Compat$AnimationCallback);
    }
}

