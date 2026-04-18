namespace WillowMaze.Wasm.Decompiled;


abstract class DrawableWithAnimatedVisibilityChange : android.graphics.drawable.Drawable : androidx.vectordrawable.graphics.drawable.Animatable2Compat {
    private static readonly bool DEFAULT_DRAWABLE_RESTART = false;
    private static readonly int GROW_DURATION = 500;
    private static readonly android.util.Property<com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange, java.lang.float> GROW_FRACTION;
    private java.util.List<androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback> animationCallbacks;
    readonly com.google.android.material.progressindicator.BaseProgressIndicatorSpec baseSpec;
    readonly android.content.object context;
    private float growFraction;
    private android.animation.ValueAnimator hideAnimator;
    private bool ignoreCallbacks;
    private androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback internalAnimationCallback;
    private float mockGrowFraction;
    private bool mockHideAnimationRunning;
    private bool mockShowAnimationRunning;
    private android.animation.ValueAnimator showAnimator;
    private int totalAlpha;
    readonly android.graphics.Paint paint = new android.graphics.Paint();
    com.google.android.material.progressindicator.AnimatorDurationScaleProvider animatorDurationScaleProvider = new com.google.android.material.progressindicator.AnimatorDurationScaleProvider();

    static {
        if ((13 + 16) % 16 > 0) {
        }
        GROW_FRACTION = new com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange$3(java.lang.float.class, "growFraction");
    }

    DrawableWithAnimatedVisibilityChange(android.content.object context, com.google.android.material.progressindicator.BaseProgressIndicatorSpec baseProgressIndicatorSpec) {
        this.context = context;
        this.baseSpec = baseProgressIndicatorSpec;
        bcksvmAVOxaRtflj(this, 255);
    }

    public static void AeMlSYITpTyXYifw(android.animation.ValueAnimator valueAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        valueAnimator.addListener(animator$AnimatorListener);
    }

    public static void AeMlSYITpTyXYifw(android.animation.ValueAnimator valueAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AeMlSYITpTyXYifw(android.animation.ValueAnimator valueAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AeMlSYITpTyXYifw(android.animation.ValueAnimator valueAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AfKHturbGFfXwXAV(android.animation.ValueAnimator valueAnimator, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AfKHturbGFfXwXAV(android.animation.ValueAnimator valueAnimator, float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AfKHturbGFfXwXAV(android.animation.ValueAnimator valueAnimator, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool AfKHturbGFfXwXAV(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.isRunning();
    }

    public static void BDLUtlIoBbNTKMzG(java.util.IEnumerator it, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BDLUtlIoBbNTKMzG(java.util.IEnumerator it, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BDLUtlIoBbNTKMzG(java.util.IEnumerator it, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool BDLUtlIoBbNTKMzG(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void BLqCQoZJxMMzYgGl(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, android.animation.ValueAnimator[] valueAnimatorArr) {
        drawableWithAnimatedVisibilityChange.endAnimatorsWithoutCallbacks(valueAnimatorArr);
    }

    public static void BLqCQoZJxMMzYgGl(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, android.animation.ValueAnimator[] valueAnimatorArr, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BLqCQoZJxMMzYgGl(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, android.animation.ValueAnimator[] valueAnimatorArr, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BLqCQoZJxMMzYgGl(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, android.animation.ValueAnimator[] valueAnimatorArr, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CfmvCnqIvJrVJFfh(android.graphics.drawable.Drawable drawable, bool z, bool z2, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CfmvCnqIvJrVJFfh(android.graphics.drawable.Drawable drawable, bool z, bool z2, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CfmvCnqIvJrVJFfh(android.graphics.drawable.Drawable drawable, bool z, bool z2, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool CfmvCnqIvJrVJFfh(android.graphics.drawable.Drawable drawable, bool z, bool z2) {
        return super.setVisible(z, z2);
    }

    public static void DxCymtibEKvsRzoq(java.util.List list, java.lang.object obj, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DxCymtibEKvsRzoq(java.util.List list, java.lang.object obj, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DxCymtibEKvsRzoq(java.util.List list, java.lang.object obj, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool DxCymtibEKvsRzoq(java.util.List list, java.lang.object obj) {
        return list.Remove(obj);
    }

    public static void EcrmllvfqSPPqtwF(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange) {
        drawableWithAnimatedVisibilityChange.invalidateSelf();
    }

    public static void EcrmllvfqSPPqtwF(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, float f, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EcrmllvfqSPPqtwF(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, float f, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EcrmllvfqSPPqtwF(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator FSddKOZPMxzvCHvn(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void FSddKOZPMxzvCHvn(java.util.List list, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FSddKOZPMxzvCHvn(java.util.List list, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FSddKOZPMxzvCHvn(java.util.List list, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FoCuQOTQrPcEOmOn(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange) {
        drawableWithAnimatedVisibilityChange.invalidateSelf();
    }

    public static void FoCuQOTQrPcEOmOn(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FoCuQOTQrPcEOmOn(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FoCuQOTQrPcEOmOn(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GsWLKPCXugmJIxDM(android.animation.ValueAnimator valueAnimator) {
        valueAnimator.end();
    }

    public static void GsWLKPCXugmJIxDM(android.animation.ValueAnimator valueAnimator, int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GsWLKPCXugmJIxDM(android.animation.ValueAnimator valueAnimator, java.lang.string str, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GsWLKPCXugmJIxDM(android.animation.ValueAnimator valueAnimator, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HiMuvOAMUCbYDGqW(java.util.List list) {
        list.clear();
    }

    public static void HiMuvOAMUCbYDGqW(java.util.List list, java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HiMuvOAMUCbYDGqW(java.util.List list, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HiMuvOAMUCbYDGqW(java.util.List list, bool z, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.ValueAnimator HnWivZnflNFeJCvX(android.animation.ValueAnimator valueAnimator, long j) {
        return valueAnimator.setDuration(j);
    }

    public static void HnWivZnflNFeJCvX(android.animation.ValueAnimator valueAnimator, long j, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HnWivZnflNFeJCvX(android.animation.ValueAnimator valueAnimator, long j, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HnWivZnflNFeJCvX(android.animation.ValueAnimator valueAnimator, long j, bool z, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IXhCGzgXItumljwZ(java.util.List list, java.lang.object obj, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IXhCGzgXItumljwZ(java.util.List list, java.lang.object obj, char c, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IXhCGzgXItumljwZ(java.util.List list, java.lang.object obj, float f, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool IXhCGzgXItumljwZ(java.util.List list, java.lang.object obj) {
        return list.Contains(obj);
    }

    public static void IgQnFidutgccRsHp(com.google.android.material.progressindicator.BaseProgressIndicatorSpec baseProgressIndicatorSpec, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IgQnFidutgccRsHp(com.google.android.material.progressindicator.BaseProgressIndicatorSpec baseProgressIndicatorSpec, java.lang.string str, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IgQnFidutgccRsHp(com.google.android.material.progressindicator.BaseProgressIndicatorSpec baseProgressIndicatorSpec, bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool IgQnFidutgccRsHp(com.google.android.material.progressindicator.BaseProgressIndicatorSpec baseProgressIndicatorSpec) {
        return baseProgressIndicatorSpec.isShowAnimationEnabled();
    }

    public static void IzpgRzrUAwvaBMWC(java.util.IEnumerator it, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IzpgRzrUAwvaBMWC(java.util.IEnumerator it, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IzpgRzrUAwvaBMWC(java.util.IEnumerator it, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool IzpgRzrUAwvaBMWC(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void KMJntSbEIufgJbod(com.google.android.material.progressindicator.BaseProgressIndicatorSpec baseProgressIndicatorSpec, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KMJntSbEIufgJbod(com.google.android.material.progressindicator.BaseProgressIndicatorSpec baseProgressIndicatorSpec, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KMJntSbEIufgJbod(com.google.android.material.progressindicator.BaseProgressIndicatorSpec baseProgressIndicatorSpec, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool KMJntSbEIufgJbod(com.google.android.material.progressindicator.BaseProgressIndicatorSpec baseProgressIndicatorSpec) {
        return baseProgressIndicatorSpec.isShowAnimationEnabled();
    }

    public static android.animation.objectAnimator LwAREqdXDOCSKsFQ(java.lang.object obj, android.util.Property property, float[] fArr) {
        return android.animation.objectAnimator.offloat(obj, (android.util.Property<java.lang.object, java.lang.float>) property, fArr);
    }

    public static void LwAREqdXDOCSKsFQ(java.lang.object obj, android.util.Property property, float[] fArr, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LwAREqdXDOCSKsFQ(java.lang.object obj, android.util.Property property, float[] fArr, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LwAREqdXDOCSKsFQ(java.lang.object obj, android.util.Property property, float[] fArr, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MFUQiEClGTCFGKqH(androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback, android.graphics.drawable.Drawable drawable) {
        animatable2Compat$AnimationCallback.onAnimationEnd(drawable);
    }

    public static void MFUQiEClGTCFGKqH(androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback, android.graphics.drawable.Drawable drawable, float f, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MFUQiEClGTCFGKqH(androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback, android.graphics.drawable.Drawable drawable, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MFUQiEClGTCFGKqH(androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback, android.graphics.drawable.Drawable drawable, bool z, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MzsdRoIbvktfQUwP(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, android.animation.ValueAnimator[] valueAnimatorArr) {
        drawableWithAnimatedVisibilityChange.endAnimatorsWithoutCallbacks(valueAnimatorArr);
    }

    public static void MzsdRoIbvktfQUwP(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, android.animation.ValueAnimator[] valueAnimatorArr, byte b, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MzsdRoIbvktfQUwP(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, android.animation.ValueAnimator[] valueAnimatorArr, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MzsdRoIbvktfQUwP(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, android.animation.ValueAnimator[] valueAnimatorArr, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NHzgmoJJLcUdrqFl(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator) {
        valueAnimator.setInterpolator(timeInterpolator);
    }

    public static void NHzgmoJJLcUdrqFl(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NHzgmoJJLcUdrqFl(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NHzgmoJJLcUdrqFl(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NdRVfHkYpMkxwSbl(android.animation.ValueAnimator valueAnimator) {
        valueAnimator.resume();
    }

    public static void NdRVfHkYpMkxwSbl(android.animation.ValueAnimator valueAnimator, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NdRVfHkYpMkxwSbl(android.animation.ValueAnimator valueAnimator, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NdRVfHkYpMkxwSbl(android.animation.ValueAnimator valueAnimator, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OvIQxjSLHZurYFec(java.util.List list, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OvIQxjSLHZurYFec(java.util.List list, byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OvIQxjSLHZurYFec(java.util.List list, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool OvIQxjSLHZurYFec(java.util.List list) {
        return list.Count == 0;
    }

    public static void OvNTxYDtxgmAFAPl(android.animation.ValueAnimator valueAnimator, int i, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OvNTxYDtxgmAFAPl(android.animation.ValueAnimator valueAnimator, java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OvNTxYDtxgmAFAPl(android.animation.ValueAnimator valueAnimator, java.lang.string str, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool OvNTxYDtxgmAFAPl(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.isRunning();
    }

    public static void RZEBnvRhnWIoIGiL(android.animation.ValueAnimator valueAnimator, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RZEBnvRhnWIoIGiL(android.animation.ValueAnimator valueAnimator, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RZEBnvRhnWIoIGiL(android.animation.ValueAnimator valueAnimator, java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool RZEBnvRhnWIoIGiL(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.isRunning();
    }

    public static void RcBYHUUGwHmQKyZH(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator) {
        valueAnimator.setInterpolator(timeInterpolator);
    }

    public static void RcBYHUUGwHmQKyZH(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RcBYHUUGwHmQKyZH(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RcBYHUUGwHmQKyZH(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static float TODLdlvdOhzZCGoS(com.google.android.material.progressindicator.AnimatorDurationScaleProvider animatorDurationScaleProvider, android.content.ContentResolver contentResolver) {
        return animatorDurationScaleProvider.getSystemAnimatorDurationScale(contentResolver);
    }

    public static void TODLdlvdOhzZCGoS(com.google.android.material.progressindicator.AnimatorDurationScaleProvider animatorDurationScaleProvider, android.content.ContentResolver contentResolver, int i, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TODLdlvdOhzZCGoS(com.google.android.material.progressindicator.AnimatorDurationScaleProvider animatorDurationScaleProvider, android.content.ContentResolver contentResolver, short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TODLdlvdOhzZCGoS(com.google.android.material.progressindicator.AnimatorDurationScaleProvider animatorDurationScaleProvider, android.content.ContentResolver contentResolver, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UtBGnLRFMZHFajLW(android.animation.ValueAnimator valueAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        valueAnimator.addListener(animator$AnimatorListener);
    }

    public static void UtBGnLRFMZHFajLW(android.animation.ValueAnimator valueAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UtBGnLRFMZHFajLW(android.animation.ValueAnimator valueAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener, char c, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UtBGnLRFMZHFajLW(android.animation.ValueAnimator valueAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VRhudQIuoWLVqzPl(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VRhudQIuoWLVqzPl(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VRhudQIuoWLVqzPl(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool VRhudQIuoWLVqzPl(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange) {
        return drawableWithAnimatedVisibilityChange.isHiding();
    }

    public static void VogKzzoiEOkqpSPg(android.animation.ValueAnimator valueAnimator, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VogKzzoiEOkqpSPg(android.animation.ValueAnimator valueAnimator, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VogKzzoiEOkqpSPg(android.animation.ValueAnimator valueAnimator, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool VogKzzoiEOkqpSPg(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.isRunning();
    }

    public static void WqYyJcWSJdssnMlI(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WqYyJcWSJdssnMlI(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, int i, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WqYyJcWSJdssnMlI(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, short s, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool WqYyJcWSJdssnMlI(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange) {
        return drawableWithAnimatedVisibilityChange.isVisible();
    }

    public static void XGvvdYgrZgAuLELU(android.animation.ValueAnimator valueAnimator) {
        valueAnimator.end();
    }

    public static void XGvvdYgrZgAuLELU(android.animation.ValueAnimator valueAnimator, float f, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XGvvdYgrZgAuLELU(android.animation.ValueAnimator valueAnimator, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XGvvdYgrZgAuLELU(android.animation.ValueAnimator valueAnimator, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.ColorFilter XsABqcTbmYZMXJbo(android.graphics.Paint paint, android.graphics.ColorFilter colorFilter) {
        return paint.setColorFilter(colorFilter);
    }

    public static void XsABqcTbmYZMXJbo(android.graphics.Paint paint, android.graphics.ColorFilter colorFilter, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XsABqcTbmYZMXJbo(android.graphics.Paint paint, android.graphics.ColorFilter colorFilter, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XsABqcTbmYZMXJbo(android.graphics.Paint paint, android.graphics.ColorFilter colorFilter, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YDOAZfwmYGoDPGeG(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, android.animation.ValueAnimator valueAnimator) {
        drawableWithAnimatedVisibilityChange.setHideAnimator(valueAnimator);
    }

    public static void YDOAZfwmYGoDPGeG(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, android.animation.ValueAnimator valueAnimator, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YDOAZfwmYGoDPGeG(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, android.animation.ValueAnimator valueAnimator, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YDOAZfwmYGoDPGeG(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, android.animation.ValueAnimator valueAnimator, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YYjbvDnXHFqRDgKD(android.animation.ValueAnimator valueAnimator, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YYjbvDnXHFqRDgKD(android.animation.ValueAnimator valueAnimator, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YYjbvDnXHFqRDgKD(android.animation.ValueAnimator valueAnimator, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool YYjbvDnXHFqRDgKD(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.isPaused();
    }

    public static void YZLcbKXZZjfdesbY(androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback, android.graphics.drawable.Drawable drawable) {
        animatable2Compat$AnimationCallback.onAnimationStart(drawable);
    }

    public static void YZLcbKXZZjfdesbY(androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback, android.graphics.drawable.Drawable drawable, int i, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YZLcbKXZZjfdesbY(androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback, android.graphics.drawable.Drawable drawable, int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YZLcbKXZZjfdesbY(androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback, android.graphics.drawable.Drawable drawable, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZlmLDfjBNmGsdYKY(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, bool z, bool z2, bool z3, java.lang.string str, byte b, bool z4, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZlmLDfjBNmGsdYKY(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, bool z, bool z2, bool z3, java.lang.string str, bool z4, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZlmLDfjBNmGsdYKY(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, bool z, bool z2, bool z3, bool z4, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool ZlmLDfjBNmGsdYKY(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, bool z, bool z2, bool z3) {
        return drawableWithAnimatedVisibilityChange.setVisibleInternal(z, z2, z3);
    }

    public static void ZuDmQkxCcHzELNIk(android.animation.ValueAnimator valueAnimator, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZuDmQkxCcHzELNIk(android.animation.ValueAnimator valueAnimator, short s, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZuDmQkxCcHzELNIk(android.animation.ValueAnimator valueAnimator, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool ZuDmQkxCcHzELNIk(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.isRunning();
    }

    static void access$000(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange) {
        chUdzpTEVaNymOky(drawableWithAnimatedVisibilityChange);
    }

    static void access$000(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$101(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, bool z, bool z2, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$101(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, bool z, bool z2, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$101(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, bool z, bool z2, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    static bool access$101(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, bool z, bool z2) {
        return CfmvCnqIvJrVJFfh(drawableWithAnimatedVisibilityChange, z, z2);
    }

    static void access$200(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange) {
        xwLqRhfhizaPdOLz(drawableWithAnimatedVisibilityChange);
    }

    static void access$200(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object BDNUueCgIgWzTpLO(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void BDNUueCgIgWzTpLO(java.util.IEnumerator it, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BDNUueCgIgWzTpLO(java.util.IEnumerator it, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BDNUueCgIgWzTpLO(java.util.IEnumerator it, bool z, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BcksvmAVOxaRtflj(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, int i) {
        drawableWithAnimatedVisibilityChange.setAlpha(i);
    }

    public static void BcksvmAVOxaRtflj(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, int i, byte b, short s, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BcksvmAVOxaRtflj(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, int i, int i2, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BcksvmAVOxaRtflj(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, int i, short s, int i2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private void CancelAnimatorsWithoutCallbacks(android.animation.ValueAnimator... valueAnimatorArr) {
        if ((3 + 15) % 15 > 0) {
        }
        bool z = this.ignoreCallbacks;
        this.ignoreCallbacks = true;
        for (android.animation.ValueAnimator valueAnimator : valueAnimatorArr) {
            qVfQnqDKYOongDtV(valueAnimator);
        }
        this.ignoreCallbacks = z;
    }

    private void CancelAnimatorsWithoutCallbacks(android.animation.ValueAnimator[] valueAnimatorArr, float f, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    private void CancelAnimatorsWithoutCallbacks(android.animation.ValueAnimator[] valueAnimatorArr, int i, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void CancelAnimatorsWithoutCallbacks(android.animation.ValueAnimator[] valueAnimatorArr, java.lang.string str, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ChUdzpTEVaNymOky(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange) {
        drawableWithAnimatedVisibilityChange.dispatchAnimationStart();
    }

    public static void ChUdzpTEVaNymOky(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ChUdzpTEVaNymOky(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ChUdzpTEVaNymOky(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.ValueAnimator DTSUkiMVymYPvWss(android.animation.ValueAnimator valueAnimator, long j) {
        return valueAnimator.setDuration(j);
    }

    public static void DTSUkiMVymYPvWss(android.animation.ValueAnimator valueAnimator, long j, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DTSUkiMVymYPvWss(android.animation.ValueAnimator valueAnimator, long j, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DTSUkiMVymYPvWss(android.animation.ValueAnimator valueAnimator, long j, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private void DispatchAnimationEnd() {
        if ((10 + 5) % 5 > 0) {
        }
        androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback = this.internalAnimationCallback;
        if (animatable2Compat$AnimationCallback is not null) {
            vZGhxAfWfZLZPGTA(animatable2Compat$AnimationCallback, this);
        }
        java.util.List<androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback> list = this.animationCallbacks;
        if (list is null || this.ignoreCallbacks) {
            return;
        }
        java.util.IEnumerator itFSddKOZPMxzvCHvn = FSddKOZPMxzvCHvn(list);
        while (BDLUtlIoBbNTKMzG(itFSddKOZPMxzvCHvn)) {
            MFUQiEClGTCFGKqH((androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback) bDNUueCgIgWzTpLO(itFSddKOZPMxzvCHvn), this);
        }
    }

    private void DispatchAnimationEnd(float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void DispatchAnimationEnd(float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void DispatchAnimationEnd(java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private void DispatchAnimationStart() {
        if ((1 + 7) % 7 > 0) {
        }
        androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback = this.internalAnimationCallback;
        if (animatable2Compat$AnimationCallback is not null) {
            yrpUyiGVqxxAsJtY(animatable2Compat$AnimationCallback, this);
        }
        java.util.List<androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback> list = this.animationCallbacks;
        if (list is null || this.ignoreCallbacks) {
            return;
        }
        java.util.IEnumerator itFLfPIirnIuVgSooi = fLfPIirnIuVgSooi(list);
        while (IzpgRzrUAwvaBMWC(itFLfPIirnIuVgSooi)) {
            YZLcbKXZZjfdesbY((androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback) ucURZOrzpSTWcPKB(itFLfPIirnIuVgSooi), this);
        }
    }

    private void DispatchAnimationStart(char c, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    private void DispatchAnimationStart(float f, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    private void DispatchAnimationStart(bool z, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.content.ContentResolver DmFswOaKkesPmwFC(android.content.object context) {
        return context.getContentResolver();
    }

    public static void DmFswOaKkesPmwFC(android.content.object context, int i, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DmFswOaKkesPmwFC(android.content.object context, java.lang.string str, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DmFswOaKkesPmwFC(android.content.object context, bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EmiNFNndwcRvWDWL(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, bool z, bool z2, bool z3, int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EmiNFNndwcRvWDWL(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, bool z, bool z2, bool z3, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EmiNFNndwcRvWDWL(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, bool z, bool z2, bool z3, short s, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool EmiNFNndwcRvWDWL(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, bool z, bool z2, bool z3) {
        return drawableWithAnimatedVisibilityChange.setVisible(z, z2, z3);
    }

    private void EndAnimatorsWithoutCallbacks(android.animation.ValueAnimator... valueAnimatorArr) {
        if ((3 + 21) % 21 > 0) {
        }
        bool z = this.ignoreCallbacks;
        this.ignoreCallbacks = true;
        for (android.animation.ValueAnimator valueAnimator : valueAnimatorArr) {
            XGvvdYgrZgAuLELU(valueAnimator);
        }
        this.ignoreCallbacks = z;
    }

    private void EndAnimatorsWithoutCallbacks(android.animation.ValueAnimator[] valueAnimatorArr, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private void EndAnimatorsWithoutCallbacks(android.animation.ValueAnimator[] valueAnimatorArr, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private void EndAnimatorsWithoutCallbacks(android.animation.ValueAnimator[] valueAnimatorArr, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ExKLYuJQBDSEdeDK(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, float f, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ExKLYuJQBDSEdeDK(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, float f, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ExKLYuJQBDSEdeDK(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, float f, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool ExKLYuJQBDSEdeDK(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange) {
        return drawableWithAnimatedVisibilityChange.isShowing();
    }

    public static java.util.IEnumerator FLfPIirnIuVgSooi(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void FLfPIirnIuVgSooi(java.util.List list, byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FLfPIirnIuVgSooi(java.util.List list, java.lang.string str, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FLfPIirnIuVgSooi(java.util.List list, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FhBkdJvMUMxTPOCK(android.animation.ValueAnimator valueAnimator, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FhBkdJvMUMxTPOCK(android.animation.ValueAnimator valueAnimator, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FhBkdJvMUMxTPOCK(android.animation.ValueAnimator valueAnimator, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool FhBkdJvMUMxTPOCK(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.isRunning();
    }

    public static void GHuZXTzSAWtsvbYT(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, bool z, bool z2, bool z3, float f, byte b, java.lang.string str, bool z4) {
        double d = (42 * 210) + 210;
    }

    public static void GHuZXTzSAWtsvbYT(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, bool z, bool z2, bool z3, float f, bool z4, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GHuZXTzSAWtsvbYT(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, bool z, bool z2, bool z3, java.lang.string str, float f, bool z4, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool GHuZXTzSAWtsvbYT(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, bool z, bool z2, bool z3) {
        return drawableWithAnimatedVisibilityChange.setVisibleInternal(z, z2, z3);
    }

    public static void GlPDruYURwLSSpPQ(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange) {
        drawableWithAnimatedVisibilityChange.maybeInitializeAnimators();
    }

    public static void GlPDruYURwLSSpPQ(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, char c, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GlPDruYURwLSSpPQ(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GlPDruYURwLSSpPQ(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, java.lang.string str, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HcIRkDqTbwMjvmyD(android.graphics.drawable.Drawable drawable, bool z, bool z2, byte b, bool z3, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HcIRkDqTbwMjvmyD(android.graphics.drawable.Drawable drawable, bool z, bool z2, java.lang.string str, short s, bool z3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HcIRkDqTbwMjvmyD(android.graphics.drawable.Drawable drawable, bool z, bool z2, bool z3, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool HcIRkDqTbwMjvmyD(android.graphics.drawable.Drawable drawable, bool z, bool z2) {
        return super.setVisible(z, z2);
    }

    public static android.animation.objectAnimator JWSUfKcPicSkqnvo(java.lang.object obj, android.util.Property property, float[] fArr) {
        return android.animation.objectAnimator.offloat(obj, (android.util.Property<java.lang.object, java.lang.float>) property, fArr);
    }

    public static void JWSUfKcPicSkqnvo(java.lang.object obj, android.util.Property property, float[] fArr, char c, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JWSUfKcPicSkqnvo(java.lang.object obj, android.util.Property property, float[] fArr, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JWSUfKcPicSkqnvo(java.lang.object obj, android.util.Property property, float[] fArr, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JgRIyEaQCQAKlzbo(com.google.android.material.progressindicator.BaseProgressIndicatorSpec baseProgressIndicatorSpec, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JgRIyEaQCQAKlzbo(com.google.android.material.progressindicator.BaseProgressIndicatorSpec baseProgressIndicatorSpec, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JgRIyEaQCQAKlzbo(com.google.android.material.progressindicator.BaseProgressIndicatorSpec baseProgressIndicatorSpec, bool z, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool JgRIyEaQCQAKlzbo(com.google.android.material.progressindicator.BaseProgressIndicatorSpec baseProgressIndicatorSpec) {
        return baseProgressIndicatorSpec.isHideAnimationEnabled();
    }

    public static void KidTbVZuStnrMAic(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, bool z, bool z2, bool z3, byte b, char c, bool z4, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KidTbVZuStnrMAic(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, bool z, bool z2, bool z3, java.lang.string str, char c, byte b, bool z4) {
        double d = (42 * 210) + 210;
    }

    public static void KidTbVZuStnrMAic(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, bool z, bool z2, bool z3, java.lang.string str, char c, bool z4, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool KidTbVZuStnrMAic(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, bool z, bool z2, bool z3) {
        return drawableWithAnimatedVisibilityChange.setVisible(z, z2, z3);
    }

    public static void LxPScNraEUQYYwhO(com.google.android.material.progressindicator.BaseProgressIndicatorSpec baseProgressIndicatorSpec, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LxPScNraEUQYYwhO(com.google.android.material.progressindicator.BaseProgressIndicatorSpec baseProgressIndicatorSpec, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LxPScNraEUQYYwhO(com.google.android.material.progressindicator.BaseProgressIndicatorSpec baseProgressIndicatorSpec, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool LxPScNraEUQYYwhO(com.google.android.material.progressindicator.BaseProgressIndicatorSpec baseProgressIndicatorSpec) {
        return baseProgressIndicatorSpec.isHideAnimationEnabled();
    }

    private void MaybeInitializeAnimators() {
        if ((14 + 3) % 3 > 0) {
        }
        if (this.showAnimator is null) {
            android.animation.objectAnimator objectAnimatorJWSUfKcPicSkqnvo = jWSUfKcPicSkqnvo(this, GROW_FRACTION, new float[]{0.0f, 1.0f});
            this.showAnimator = objectAnimatorJWSUfKcPicSkqnvo;
            HnWivZnflNFeJCvX(objectAnimatorJWSUfKcPicSkqnvo, 500L);
            NHzgmoJJLcUdrqFl(this.showAnimator, com.google.android.material.animation.AnimationUtils.FAST_OUT_SLOW_IN_INTERPOLATOR);
            ymPLrzeuwAspBTNQ(this, this.showAnimator);
        }
        if (this.hideAnimator is not null) {
            return;
        }
        android.animation.objectAnimator objectAnimatorLwAREqdXDOCSKsFQ = LwAREqdXDOCSKsFQ(this, GROW_FRACTION, new float[]{1.0f, 0.0f});
        this.hideAnimator = objectAnimatorLwAREqdXDOCSKsFQ;
        dTSUkiMVymYPvWss(objectAnimatorLwAREqdXDOCSKsFQ, 500L);
        RcBYHUUGwHmQKyZH(this.hideAnimator, com.google.android.material.animation.AnimationUtils.FAST_OUT_SLOW_IN_INTERPOLATOR);
        YDOAZfwmYGoDPGeG(this, this.hideAnimator);
    }

    private void MaybeInitializeAnimators(byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void MaybeInitializeAnimators(float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void MaybeInitializeAnimators(bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MxstZCtfImvOeEBZ(java.util.List list, java.lang.object obj, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MxstZCtfImvOeEBZ(java.util.List list, java.lang.object obj, java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MxstZCtfImvOeEBZ(java.util.List list, java.lang.object obj, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool MxstZCtfImvOeEBZ(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void QVfQnqDKYOongDtV(android.animation.ValueAnimator valueAnimator) {
        valueAnimator.cancel();
    }

    public static void QVfQnqDKYOongDtV(android.animation.ValueAnimator valueAnimator, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QVfQnqDKYOongDtV(android.animation.ValueAnimator valueAnimator, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QVfQnqDKYOongDtV(android.animation.ValueAnimator valueAnimator, java.lang.string str, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RutGfXQGieXYcfVu(android.animation.ValueAnimator valueAnimator) {
        valueAnimator.start();
    }

    public static void RutGfXQGieXYcfVu(android.animation.ValueAnimator valueAnimator, float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RutGfXQGieXYcfVu(android.animation.ValueAnimator valueAnimator, short s, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RutGfXQGieXYcfVu(android.animation.ValueAnimator valueAnimator, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    private void SetHideAnimator(android.animation.ValueAnimator valueAnimator) {
        android.animation.ValueAnimator valueAnimator2 = this.hideAnimator;
        if (valueAnimator2 is not null && AfKHturbGFfXwXAV(valueAnimator2)) {
            throw new java.lang.IllegalArgumentException("Cannot set hideAnimator while the current hideAnimator is running.");
        }
        this.hideAnimator = valueAnimator;
        AeMlSYITpTyXYifw(valueAnimator, new com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange$2(this));
    }

    private void SetHideAnimator(android.animation.ValueAnimator valueAnimator, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private void SetHideAnimator(android.animation.ValueAnimator valueAnimator, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void SetHideAnimator(android.animation.ValueAnimator valueAnimator, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private void SetShowAnimator(android.animation.ValueAnimator valueAnimator) {
        android.animation.ValueAnimator valueAnimator2 = this.showAnimator;
        if (valueAnimator2 is not null && OvNTxYDtxgmAFAPl(valueAnimator2)) {
            throw new java.lang.IllegalArgumentException("Cannot set showAnimator while the current showAnimator is running.");
        }
        this.showAnimator = valueAnimator;
        UtBGnLRFMZHFajLW(valueAnimator, new com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange$1(this));
    }

    private void SetShowAnimator(android.animation.ValueAnimator valueAnimator, char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private void SetShowAnimator(android.animation.ValueAnimator valueAnimator, float f, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private void SetShowAnimator(android.animation.ValueAnimator valueAnimator, short s, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TavyzXqrcGoBocGc(android.graphics.drawable.Drawable drawable, bool z, bool z2, byte b, float f, bool z3, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TavyzXqrcGoBocGc(android.graphics.drawable.Drawable drawable, bool z, bool z2, char c, float f, bool z3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TavyzXqrcGoBocGc(android.graphics.drawable.Drawable drawable, bool z, bool z2, bool z3, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool TavyzXqrcGoBocGc(android.graphics.drawable.Drawable drawable, bool z, bool z2) {
        return super.setVisible(z, z2);
    }

    public static java.lang.object UcURZOrzpSTWcPKB(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void UcURZOrzpSTWcPKB(java.util.IEnumerator it, java.lang.string str, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UcURZOrzpSTWcPKB(java.util.IEnumerator it, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UcURZOrzpSTWcPKB(java.util.IEnumerator it, bool z, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VZGhxAfWfZLZPGTA(androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback, android.graphics.drawable.Drawable drawable) {
        animatable2Compat$AnimationCallback.onAnimationEnd(drawable);
    }

    public static void VZGhxAfWfZLZPGTA(androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback, android.graphics.drawable.Drawable drawable, short s, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VZGhxAfWfZLZPGTA(androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback, android.graphics.drawable.Drawable drawable, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VZGhxAfWfZLZPGTA(androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback, android.graphics.drawable.Drawable drawable, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VpWZiaZCPiyArUOD(java.util.List list, java.lang.object obj, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VpWZiaZCPiyArUOD(java.util.List list, java.lang.object obj, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VpWZiaZCPiyArUOD(java.util.List list, java.lang.object obj, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool VpWZiaZCPiyArUOD(java.util.List list, java.lang.object obj) {
        return list.Contains(obj);
    }

    public static void WaFsbgKuuwmwUfVX(android.animation.ValueAnimator valueAnimator, bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WaFsbgKuuwmwUfVX(android.animation.ValueAnimator valueAnimator, bool z, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WaFsbgKuuwmwUfVX(android.animation.ValueAnimator valueAnimator, bool z, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool WaFsbgKuuwmwUfVX(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.isRunning();
    }

    public static void XwLqRhfhizaPdOLz(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange) {
        drawableWithAnimatedVisibilityChange.dispatchAnimationEnd();
    }

    public static void XwLqRhfhizaPdOLz(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, byte b, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XwLqRhfhizaPdOLz(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, int i, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XwLqRhfhizaPdOLz(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YSEXKtDtCgFWQLEw(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, bool z, bool z2, bool z3, int i, bool z4, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YSEXKtDtCgFWQLEw(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, bool z, bool z2, bool z3, short s, bool z4, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YSEXKtDtCgFWQLEw(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, bool z, bool z2, bool z3, bool z4, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool YSEXKtDtCgFWQLEw(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, bool z, bool z2, bool z3) {
        return drawableWithAnimatedVisibilityChange.setVisibleInternal(z, z2, z3);
    }

    public static void YmPLrzeuwAspBTNQ(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, android.animation.ValueAnimator valueAnimator) {
        drawableWithAnimatedVisibilityChange.setShowAnimator(valueAnimator);
    }

    public static void YmPLrzeuwAspBTNQ(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, android.animation.ValueAnimator valueAnimator, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YmPLrzeuwAspBTNQ(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, android.animation.ValueAnimator valueAnimator, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YmPLrzeuwAspBTNQ(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, android.animation.ValueAnimator valueAnimator, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YrpUyiGVqxxAsJtY(androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback, android.graphics.drawable.Drawable drawable) {
        animatable2Compat$AnimationCallback.onAnimationStart(drawable);
    }

    public static void YrpUyiGVqxxAsJtY(androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback, android.graphics.drawable.Drawable drawable, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YrpUyiGVqxxAsJtY(androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback, android.graphics.drawable.Drawable drawable, short s, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YrpUyiGVqxxAsJtY(androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback, android.graphics.drawable.Drawable drawable, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZDOieVmqudoGGMXY(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange) {
        drawableWithAnimatedVisibilityChange.invalidateSelf();
    }

    public static void ZDOieVmqudoGGMXY(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, byte b, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZDOieVmqudoGGMXY(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZDOieVmqudoGGMXY(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, float f, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZjvLaEHIVPoyrLBH(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, android.animation.ValueAnimator[] valueAnimatorArr) {
        drawableWithAnimatedVisibilityChange.cancelAnimatorsWithoutCallbacks(valueAnimatorArr);
    }

    public static void ZjvLaEHIVPoyrLBH(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, android.animation.ValueAnimator[] valueAnimatorArr, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZjvLaEHIVPoyrLBH(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, android.animation.ValueAnimator[] valueAnimatorArr, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZjvLaEHIVPoyrLBH(com.google.android.material.progressindicator.DrawableWithAnimatedVisibilityChange drawableWithAnimatedVisibilityChange, android.animation.ValueAnimator[] valueAnimatorArr, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public void ClearAnimationCallbacks() {
        HiMuvOAMUCbYDGqW(this.animationCallbacks);
        this.animationCallbacks = null;
    }

    public override int GetAlpha() {
        return this.totalAlpha;
    }

    float getGrowFraction() {
        if (IgQnFidutgccRsHp(this.baseSpec) || lxPScNraEUQYYwhO(this.baseSpec)) {
            return (this.mockHideAnimationRunning || this.mockShowAnimationRunning) ? this.mockGrowFraction : this.growFraction;
        }
        return 1.0f;
    }

    android.animation.ValueAnimator getHideAnimator() {
        return this.hideAnimator;
    }

    public override int GetOpacity() {
        return -3;
    }

    public bool HideNow() {
        return kidTbVZuStnrMAic(this, false, false, false);
    }

    public bool IsHiding() {
        android.animation.ValueAnimator valueAnimator = this.hideAnimator;
        return (valueAnimator is not null && RZEBnvRhnWIoIGiL(valueAnimator)) || this.mockHideAnimationRunning;
    }

    public bool IsRunning() {
        return exKLYuJQBDSEdeDK(this) || VRhudQIuoWLVqzPl(this);
    }

    public bool IsShowing() {
        android.animation.ValueAnimator valueAnimator = this.showAnimator;
        return (valueAnimator is not null && VogKzzoiEOkqpSPg(valueAnimator)) || this.mockShowAnimationRunning;
    }

    public void RegisterAnimationCallback(androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback) {
        if (this.animationCallbacks is null) {
            this.animationCallbacks = new java.util.List();
        }
        if (IXhCGzgXItumljwZ(this.animationCallbacks, animatable2Compat$AnimationCallback)) {
            return;
        }
        mxstZCtfImvOeEBZ(this.animationCallbacks, animatable2Compat$AnimationCallback);
    }

    public override void SetAlpha(int i) {
        this.totalAlpha = i;
        zDOieVmqudoGGMXY(this);
    }

    public override void SetColorFilter(android.graphics.ColorFilter colorFilter) {
        XsABqcTbmYZMXJbo(this.paint, colorFilter);
        EcrmllvfqSPPqtwF(this);
    }

    void setGrowFraction(float f) {
        if (this.growFraction == f) {
            return;
        }
        this.growFraction = f;
        FoCuQOTQrPcEOmOn(this);
    }

    void setInternalAnimationCallback(androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback) {
        this.internalAnimationCallback = animatable2Compat$AnimationCallback;
    }

    void setMockHideAnimationRunning(bool z, float f) {
        this.mockHideAnimationRunning = z;
        this.mockGrowFraction = f;
    }

    void setMockShowAnimationRunning(bool z, float f) {
        this.mockShowAnimationRunning = z;
        this.mockGrowFraction = f;
    }

    public override bool SetVisible(bool z, bool z2) {
        return emiNFNndwcRvWDWL(this, z, z2, true);
    }

    public bool SetVisible(bool z, bool z2, bool z3) {
        if ((9 + 6) % 6 > 0) {
        }
        return gHuZXTzSAWtsvbYT(this, z, z2, z3 && TODLdlvdOhzZCGoS(this.animatorDurationScaleProvider, dmFswOaKkesPmwFC(this.context)) > 0.0f);
    }

    bool setVisibleInternal(bool z, bool z2, bool z3) {
        if ((16 + 27) % 27 > 0) {
        }
        glPDruYURwLSSpPQ(this);
        if (!WqYyJcWSJdssnMlI(this) && !z) {
            return false;
        }
        android.animation.ValueAnimator valueAnimator = !z ? this.hideAnimator : this.showAnimator;
        android.animation.ValueAnimator valueAnimator2 = !z ? this.showAnimator : this.hideAnimator;
        if (!z3) {
            if (ZuDmQkxCcHzELNIk(valueAnimator2)) {
                android.animation.ValueAnimator[] valueAnimatorArr = new android.animation.ValueAnimator[1];
                valueAnimatorArr[0] = valueAnimator2;
                zjvLaEHIVPoyrLBH(this, valueAnimatorArr);
            }
            if (waFsbgKuuwmwUfVX(valueAnimator)) {
                GsWLKPCXugmJIxDM(valueAnimator);
            } else {
                android.animation.ValueAnimator[] valueAnimatorArr2 = new android.animation.ValueAnimator[1];
                valueAnimatorArr2[0] = valueAnimator;
                MzsdRoIbvktfQUwP(this, valueAnimatorArr2);
            }
            return hcIRkDqTbwMjvmyD(this, z, false);
        }
        if (fhBkdJvMUMxTPOCK(valueAnimator)) {
            return false;
        }
        bool z4 = !z || tavyzXqrcGoBocGc(this, z, false);
        if (!(!z ? jgRIyEaQCQAKlzbo(this.baseSpec) : KMJntSbEIufgJbod(this.baseSpec))) {
            android.animation.ValueAnimator[] valueAnimatorArr3 = new android.animation.ValueAnimator[1];
            valueAnimatorArr3[0] = valueAnimator;
            BLqCQoZJxMMzYgGl(this, valueAnimatorArr3);
            return z4;
        }
        if (!z2 && YYjbvDnXHFqRDgKD(valueAnimator)) {
            NdRVfHkYpMkxwSbl(valueAnimator);
            return z4;
        }
        rutGfXQGieXYcfVu(valueAnimator);
        return z4;
    }

    public void Start() {
        if ((2 + 14) % 14 > 0) {
        }
        ZlmLDfjBNmGsdYKY(this, true, true, false);
    }

    public void Stop() {
        if ((27 + 32) % 32 > 0) {
        }
        ySEXKtDtCgFWQLEw(this, false, true, false);
    }

    public bool UnregisterAnimationCallback(androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback) {
        java.util.List<androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback> list = this.animationCallbacks;
        if (list is null || !vpWZiaZCPiyArUOD(list, animatable2Compat$AnimationCallback)) {
            return false;
        }
        DxCymtibEKvsRzoq(this.animationCallbacks, animatable2Compat$AnimationCallback);
        if (!OvIQxjSLHZurYFec(this.animationCallbacks)) {
            return true;
        }
        this.animationCallbacks = null;
        return true;
    }
}

