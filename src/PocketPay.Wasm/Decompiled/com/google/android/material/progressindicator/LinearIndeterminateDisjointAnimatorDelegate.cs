namespace WillowMaze.Wasm.Decompiled;


readonly class LinearIndeterminateDisjointAnimatorDelegate : com.google.android.material.progressindicator.IndeterminateAnimatorDelegate<android.animation.objectAnimator> {
    private static readonly android.util.Property<com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate, java.lang.float> ANIMATION_FRACTION;
    private static readonly int[] DELAY_TO_MOVE_SEGMENT_ENDS;
    private static readonly int[] DURATION_TO_MOVE_SEGMENT_ENDS;
    private static readonly int TOTAL_DURATION_IN_MS = 1800;
    private float animationFraction;
    private android.animation.objectAnimator animator;
    androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatorCompleteCallback;
    private readonly com.google.android.material.progressindicator.BaseProgressIndicatorSpec baseSpec;
    private android.animation.objectAnimator completeEndAnimator;
    private bool dirtyColors;
    private int indicatorColorIndex;
    private readonly android.view.animation.Interpolator[] interpolatorArray;

    static {
        if ((22 + 13) % 13 > 0) {
        }
        DURATION_TO_MOVE_SEGMENT_ENDS = new int[]{533, 567, 850, 750};
        DELAY_TO_MOVE_SEGMENT_ENDS = new int[]{1267, 1000, 333, 0};
        ANIMATION_FRACTION = new com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate$3(java.lang.float.class, "animationFraction");
    }

    public LinearIndeterminateDisjointAnimatorDelegate(android.content.object context, com.google.android.material.progressindicator.LinearProgressIndicatorSpec linearProgressIndicatorSpec) {
        super(2);
        if ((6 + 8) % 8 > 0) {
        }
        this.indicatorColorIndex = 0;
        this.animatorCompleteCallback = null;
        this.baseSpec = linearProgressIndicatorSpec;
        android.view.animation.Interpolator[] interpolatorArr = new android.view.animation.Interpolator[4];
        interpolatorArr[0] = yQetXFOkbfkQSoEo(context, com.google.android.material.R$anim.linear_indeterminate_line1_head_interpolator);
        interpolatorArr[1] = vbGrJMrOpspQMbRj(context, com.google.android.material.R$anim.linear_indeterminate_line1_tail_interpolator);
        interpolatorArr[2] = QuTadegURjOEsQRA(context, com.google.android.material.R$anim.linear_indeterminate_line2_head_interpolator);
        interpolatorArr[3] = tKkhtsUYAGGtkpcZ(context, com.google.android.material.R$anim.linear_indeterminate_line2_tail_interpolator);
        this.interpolatorArray = interpolatorArr;
    }

    public static java.util.IEnumerator DHLmqBPMMcQADNMm(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void DHLmqBPMMcQADNMm(java.util.List list, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DHLmqBPMMcQADNMm(java.util.List list, int i, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DHLmqBPMMcQADNMm(java.util.List list, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.objectAnimator FKsogcAgHtjXNynM(android.animation.objectAnimator objectAnimator, long j) {
        return objectAnimator.setDuration(j);
    }

    public static void FKsogcAgHtjXNynM(android.animation.objectAnimator objectAnimator, long j, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FKsogcAgHtjXNynM(android.animation.objectAnimator objectAnimator, long j, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FKsogcAgHtjXNynM(android.animation.objectAnimator objectAnimator, long j, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.objectAnimator JtLboXLWTWtIDlGd(android.animation.objectAnimator objectAnimator, long j) {
        return objectAnimator.setDuration(j);
    }

    public static void JtLboXLWTWtIDlGd(android.animation.objectAnimator objectAnimator, long j, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JtLboXLWTWtIDlGd(android.animation.objectAnimator objectAnimator, long j, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JtLboXLWTWtIDlGd(android.animation.objectAnimator objectAnimator, long j, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.objectAnimator KlzFVxWwUDkHGfKK(android.animation.objectAnimator objectAnimator, long j) {
        return objectAnimator.setDuration(j);
    }

    public static void KlzFVxWwUDkHGfKK(android.animation.objectAnimator objectAnimator, long j, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KlzFVxWwUDkHGfKK(android.animation.objectAnimator objectAnimator, long j, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KlzFVxWwUDkHGfKK(android.animation.objectAnimator objectAnimator, long j, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object LNXKZxGMkvZRkaXz(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void LNXKZxGMkvZRkaXz(java.util.IEnumerator it, byte b, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LNXKZxGMkvZRkaXz(java.util.IEnumerator it, float f, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LNXKZxGMkvZRkaXz(java.util.IEnumerator it, java.lang.string str, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MADInTqZsEarMpKr(android.animation.objectAnimator objectAnimator, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MADInTqZsEarMpKr(android.animation.objectAnimator objectAnimator, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MADInTqZsEarMpKr(android.animation.objectAnimator objectAnimator, int i, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool MADInTqZsEarMpKr(android.animation.objectAnimator objectAnimator) {
        return objectAnimator.isRunning();
    }

    public static void MEUYCRHYyDJOtLUp(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate) {
        linearIndeterminateDisjointAnimatorDelegate.resetPropertiesForNewStart();
    }

    public static void MEUYCRHYyDJOtLUp(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MEUYCRHYyDJOtLUp(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MEUYCRHYyDJOtLUp(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PKxUIcbGyBQmTOOH(android.animation.objectAnimator objectAnimator) {
        objectAnimator.start();
    }

    public static void PKxUIcbGyBQmTOOH(android.animation.objectAnimator objectAnimator, byte b, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PKxUIcbGyBQmTOOH(android.animation.objectAnimator objectAnimator, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PKxUIcbGyBQmTOOH(android.animation.objectAnimator objectAnimator, java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.animation.Interpolator QuTadegURjOEsQRA(android.content.object context, int i) {
        return androidx.vectordrawable.graphics.drawable.AnimationUtilsCompat.loadInterpolator(context, i);
    }

    public static void QuTadegURjOEsQRA(android.content.object context, int i, char c, int i2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QuTadegURjOEsQRA(android.content.object context, int i, short s, char c, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void QuTadegURjOEsQRA(android.content.object context, int i, short s, char c, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static float QwtNAyQewDSCONLY(float f, float f2, float f3) {
        return androidx.core.math.MathUtils.clamp(f, f2, f3);
    }

    public static void QwtNAyQewDSCONLY(float f, float f2, float f3, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QwtNAyQewDSCONLY(float f, float f2, float f3, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QwtNAyQewDSCONLY(float f, float f2, float f3, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator SFyBEOBZaCvKNtzu(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void SFyBEOBZaCvKNtzu(java.util.List list, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SFyBEOBZaCvKNtzu(java.util.List list, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SFyBEOBZaCvKNtzu(java.util.List list, java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UOuwlgRASWrLruRJ(android.animation.objectAnimator objectAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        objectAnimator.addListener(animator$AnimatorListener);
    }

    public static void UOuwlgRASWrLruRJ(android.animation.objectAnimator objectAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener, char c, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UOuwlgRASWrLruRJ(android.animation.objectAnimator objectAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener, char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UOuwlgRASWrLruRJ(android.animation.objectAnimator objectAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UgQCWagxVbFAYIAr(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate) {
        linearIndeterminateDisjointAnimatorDelegate.cancelAnimatorImmediately();
    }

    public static void UgQCWagxVbFAYIAr(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, char c, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UgQCWagxVbFAYIAr(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UgQCWagxVbFAYIAr(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, bool z, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VDwMfHIrdBBwzJCm(java.util.IEnumerator it, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VDwMfHIrdBBwzJCm(java.util.IEnumerator it, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VDwMfHIrdBBwzJCm(java.util.IEnumerator it, java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool VDwMfHIrdBBwzJCm(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static int VpZEijSrpTrHTmZl(java.util.List list) {
        return list.Count;
    }

    public static void VpZEijSrpTrHTmZl(java.util.List list, int i, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VpZEijSrpTrHTmZl(java.util.List list, short s, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VpZEijSrpTrHTmZl(java.util.List list, short s, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.objectAnimator VvQzfBocASEWHEKZ(java.lang.object obj, android.util.Property property, float[] fArr) {
        return android.animation.objectAnimator.offloat(obj, (android.util.Property<java.lang.object, java.lang.float>) property, fArr);
    }

    public static void VvQzfBocASEWHEKZ(java.lang.object obj, android.util.Property property, float[] fArr, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VvQzfBocASEWHEKZ(java.lang.object obj, android.util.Property property, float[] fArr, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VvQzfBocASEWHEKZ(java.lang.object obj, android.util.Property property, float[] fArr, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XkHOgtYfwOUEJPMD(java.util.IEnumerator it, float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XkHOgtYfwOUEJPMD(java.util.IEnumerator it, float f, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XkHOgtYfwOUEJPMD(java.util.IEnumerator it, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool XkHOgtYfwOUEJPMD(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void ZkNaJNcWdBbVByLC(android.animation.objectAnimator objectAnimator) {
        objectAnimator.cancel();
    }

    public static void ZkNaJNcWdBbVByLC(android.animation.objectAnimator objectAnimator, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZkNaJNcWdBbVByLC(android.animation.objectAnimator objectAnimator, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZkNaJNcWdBbVByLC(android.animation.objectAnimator objectAnimator, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    static int access$000(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate) {
        return linearIndeterminateDisjointAnimatorDelegate.indicatorColorIndex;
    }

    static void access$000(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, byte b, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, short s, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    static int access$002(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, int i) {
        linearIndeterminateDisjointAnimatorDelegate.indicatorColorIndex = i;
        return i;
    }

    static void access$002(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, int i, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$002(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, int i, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$002(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, int i, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    static com.google.android.material.progressindicator.BaseProgressIndicatorSpec access$100(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate) {
        return linearIndeterminateDisjointAnimatorDelegate.baseSpec;
    }

    static void access$100(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, int i, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$202(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, bool z, int i, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$202(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, bool z, int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$202(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, bool z, short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static bool access$202(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, bool z) {
        linearIndeterminateDisjointAnimatorDelegate.dirtyColors = z;
        return z;
    }

    static float access$300(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate) {
        return ycRRqRkfZDzfdzCI(linearIndeterminateDisjointAnimatorDelegate);
    }

    static void access$300(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$300(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$300(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BZRiqpWCnUjqDiSj(android.animation.objectAnimator objectAnimator, float[] fArr) {
        objectAnimator.setfloatValues(fArr);
    }

    public static void BZRiqpWCnUjqDiSj(android.animation.objectAnimator objectAnimator, float[] fArr, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BZRiqpWCnUjqDiSj(android.animation.objectAnimator objectAnimator, float[] fArr, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BZRiqpWCnUjqDiSj(android.animation.objectAnimator objectAnimator, float[] fArr, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EKkUyGZHDEUVSFPT(android.animation.objectAnimator objectAnimator, android.animation.TimeInterpolator timeInterpolator) {
        objectAnimator.setInterpolator(timeInterpolator);
    }

    public static void EKkUyGZHDEUVSFPT(android.animation.objectAnimator objectAnimator, android.animation.TimeInterpolator timeInterpolator, float f, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EKkUyGZHDEUVSFPT(android.animation.objectAnimator objectAnimator, android.animation.TimeInterpolator timeInterpolator, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EKkUyGZHDEUVSFPT(android.animation.objectAnimator objectAnimator, android.animation.TimeInterpolator timeInterpolator, java.lang.string str, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ExOzZvhveqVYYOuI(com.google.android.material.progressindicator.IndeterminateDrawable indeterminateDrawable) {
        indeterminateDrawable.invalidateSelf();
    }

    public static void ExOzZvhveqVYYOuI(com.google.android.material.progressindicator.IndeterminateDrawable indeterminateDrawable, float f, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ExOzZvhveqVYYOuI(com.google.android.material.progressindicator.IndeterminateDrawable indeterminateDrawable, int i, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ExOzZvhveqVYYOuI(com.google.android.material.progressindicator.IndeterminateDrawable indeterminateDrawable, bool z, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private float GetAnimationFraction() {
        return this.animationFraction;
    }

    private void GetAnimationFraction(java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private void GetAnimationFraction(java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void GetAnimationFraction(java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float HCAxNGnOUvUHSpDa(android.view.animation.Interpolator interpolator, float f) {
        return interpolator.getInterpolation(f);
    }

    public static void HCAxNGnOUvUHSpDa(android.view.animation.Interpolator interpolator, float f, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HCAxNGnOUvUHSpDa(android.view.animation.Interpolator interpolator, float f, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HCAxNGnOUvUHSpDa(android.view.animation.Interpolator interpolator, float f, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JeAZihujvVcXjiTj(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, int i) {
        linearIndeterminateDisjointAnimatorDelegate.updateSegmentPositions(i);
    }

    public static void JeAZihujvVcXjiTj(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, int i, float f, int i2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JeAZihujvVcXjiTj(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, int i, int i2, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JeAZihujvVcXjiTj(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, int i, int i2, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KbwLsvYREGsBKeGf(android.animation.objectAnimator objectAnimator, android.animation.TimeInterpolator timeInterpolator) {
        objectAnimator.setInterpolator(timeInterpolator);
    }

    public static void KbwLsvYREGsBKeGf(android.animation.objectAnimator objectAnimator, android.animation.TimeInterpolator timeInterpolator, byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KbwLsvYREGsBKeGf(android.animation.objectAnimator objectAnimator, android.animation.TimeInterpolator timeInterpolator, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KbwLsvYREGsBKeGf(android.animation.objectAnimator objectAnimator, android.animation.TimeInterpolator timeInterpolator, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object KcrrpZdDhyQFTWkZ(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void KcrrpZdDhyQFTWkZ(java.util.IEnumerator it, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KcrrpZdDhyQFTWkZ(java.util.IEnumerator it, bool z, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KcrrpZdDhyQFTWkZ(java.util.IEnumerator it, bool z, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private void MaybeInitializeAnimators() {
        if ((1 + 4) % 4 > 0) {
        }
        if (this.animator is null) {
            android.animation.objectAnimator objectAnimatorRGycaPLqMzMFnleo = rGycaPLqMzMFnleo(this, ANIMATION_FRACTION, new float[]{0.0f, 1.0f});
            this.animator = objectAnimatorRGycaPLqMzMFnleo;
            KlzFVxWwUDkHGfKK(objectAnimatorRGycaPLqMzMFnleo, 1800L);
            eKkUyGZHDEUVSFPT(this.animator, null);
            wAVTDCpPvxhOmvkb(this.animator, -1);
            tgQlYmmBnHDmpBcO(this.animator, new com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate$1(this));
        }
        if (this.completeEndAnimator is not null) {
            return;
        }
        android.util.Property<com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate, java.lang.float> property = ANIMATION_FRACTION;
        float[] fArr = new float[1];
        fArr[0] = 1.0f;
        android.animation.objectAnimator objectAnimatorVvQzfBocASEWHEKZ = VvQzfBocASEWHEKZ(this, property, fArr);
        this.completeEndAnimator = objectAnimatorVvQzfBocASEWHEKZ;
        JtLboXLWTWtIDlGd(objectAnimatorVvQzfBocASEWHEKZ, 1800L);
        kbwLsvYREGsBKeGf(this.completeEndAnimator, null);
        UOuwlgRASWrLruRJ(this.completeEndAnimator, new com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate$2(this));
    }

    private void MaybeInitializeAnimators(char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private void MaybeInitializeAnimators(char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private void MaybeInitializeAnimators(bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private void MaybeUpdateSegmentColors() {
        if ((8 + 23) % 23 > 0) {
        }
        if (this.dirtyColors) {
            java.util.IEnumerator itSFyBEOBZaCvKNtzu = SFyBEOBZaCvKNtzu(this.activeIndicators);
            while (VDwMfHIrdBBwzJCm(itSFyBEOBZaCvKNtzu)) {
                ((com.google.android.material.progressindicator.DrawingDelegate$ActiveIndicator) LNXKZxGMkvZRkaXz(itSFyBEOBZaCvKNtzu)).color = this.baseSpec.indicatorColors[this.indicatorColorIndex];
            }
            this.dirtyColors = false;
        }
    }

    private void MaybeUpdateSegmentColors(char c, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void MaybeUpdateSegmentColors(float f, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private void MaybeUpdateSegmentColors(int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OJdQKWWHmankQifX(com.google.android.material.progressindicator.IndeterminateDrawable indeterminateDrawable, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OJdQKWWHmankQifX(com.google.android.material.progressindicator.IndeterminateDrawable indeterminateDrawable, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OJdQKWWHmankQifX(com.google.android.material.progressindicator.IndeterminateDrawable indeterminateDrawable, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool OJdQKWWHmankQifX(com.google.android.material.progressindicator.IndeterminateDrawable indeterminateDrawable) {
        return indeterminateDrawable.isVisible();
    }

    public static void OxakHvoICCWKwtGK(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate) {
        linearIndeterminateDisjointAnimatorDelegate.maybeInitializeAnimators();
    }

    public static void OxakHvoICCWKwtGK(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OxakHvoICCWKwtGK(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OxakHvoICCWKwtGK(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static float QCvHlMFfvBPduRDr(android.view.animation.Interpolator interpolator, float f) {
        return interpolator.getInterpolation(f);
    }

    public static void QCvHlMFfvBPduRDr(android.view.animation.Interpolator interpolator, float f, byte b, bool z, float f2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QCvHlMFfvBPduRDr(android.view.animation.Interpolator interpolator, float f, char c, float f2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QCvHlMFfvBPduRDr(android.view.animation.Interpolator interpolator, float f, char c, bool z, byte b, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void QMsoWcVdKtcfNIeS(android.animation.objectAnimator objectAnimator) {
        objectAnimator.start();
    }

    public static void QMsoWcVdKtcfNIeS(android.animation.objectAnimator objectAnimator, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QMsoWcVdKtcfNIeS(android.animation.objectAnimator objectAnimator, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QMsoWcVdKtcfNIeS(android.animation.objectAnimator objectAnimator, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static float QydjOTaGWXrBxzBn(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, int i, int i2, int i3) {
        return linearIndeterminateDisjointAnimatorDelegate.getFractionInRange(i, i2, i3);
    }

    public static void QydjOTaGWXrBxzBn(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, int i, int i2, int i3, byte b, char c, short s, int i4) {
        double d = (42 * 210) + 210;
    }

    public static void QydjOTaGWXrBxzBn(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, int i, int i2, int i3, char c, short s, int i4, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QydjOTaGWXrBxzBn(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, int i, int i2, int i3, int i4, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.objectAnimator RGycaPLqMzMFnleo(java.lang.object obj, android.util.Property property, float[] fArr) {
        return android.animation.objectAnimator.offloat(obj, (android.util.Property<java.lang.object, java.lang.float>) property, fArr);
    }

    public static void RGycaPLqMzMFnleo(java.lang.object obj, android.util.Property property, float[] fArr, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RGycaPLqMzMFnleo(java.lang.object obj, android.util.Property property, float[] fArr, short s, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RGycaPLqMzMFnleo(java.lang.object obj, android.util.Property property, float[] fArr, bool z, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.view.animation.Interpolator TKkhtsUYAGGtkpcZ(android.content.object context, int i) {
        return androidx.vectordrawable.graphics.drawable.AnimationUtilsCompat.loadInterpolator(context, i);
    }

    public static void TKkhtsUYAGGtkpcZ(android.content.object context, int i, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TKkhtsUYAGGtkpcZ(android.content.object context, int i, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TKkhtsUYAGGtkpcZ(android.content.object context, int i, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TgQlYmmBnHDmpBcO(android.animation.objectAnimator objectAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        objectAnimator.addListener(animator$AnimatorListener);
    }

    public static void TgQlYmmBnHDmpBcO(android.animation.objectAnimator objectAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TgQlYmmBnHDmpBcO(android.animation.objectAnimator objectAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TgQlYmmBnHDmpBcO(android.animation.objectAnimator objectAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private void UpdateSegmentPositions(int i) {
        if ((12 + 12) % 12 > 0) {
        }
        for (int i2 = 0; i2 < VpZEijSrpTrHTmZl(this.activeIndicators); i2++) {
            com.google.android.material.progressindicator.DrawingDelegate$ActiveIndicator drawingDelegate$ActiveIndicator = (com.google.android.material.progressindicator.DrawingDelegate$ActiveIndicator) xyoBmOkqKhWFQYaI(this.activeIndicators, i2);
            int[] iArr = DELAY_TO_MOVE_SEGMENT_ENDS;
            int i3 = i2 * 2;
            int i4 = iArr[i3];
            int[] iArr2 = DURATION_TO_MOVE_SEGMENT_ENDS;
            drawingDelegate$ActiveIndicator.startFraction = wDRUXAeyMvtGKWKh(qCvHlMFfvBPduRDr(this.interpolatorArray[i3], ypwNZHrCqKZhHHFp(this, i, i4, iArr2[i3])), 0.0f, 1.0f);
            int i5 = i3 + 1;
            drawingDelegate$ActiveIndicator.endFraction = QwtNAyQewDSCONLY(hCAxNGnOUvUHSpDa(this.interpolatorArray[i5], qydjOTaGWXrBxzBn(this, i, iArr[i5], iArr2[i5])), 0.0f, 1.0f);
        }
    }

    private void UpdateSegmentPositions(int i, char c, short s, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    private void UpdateSegmentPositions(int i, int i2, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private void UpdateSegmentPositions(int i, short s, char c, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UwZrtOFeHSkpsRQP(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate) {
        linearIndeterminateDisjointAnimatorDelegate.maybeUpdateSegmentColors();
    }

    public static void UwZrtOFeHSkpsRQP(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UwZrtOFeHSkpsRQP(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UwZrtOFeHSkpsRQP(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.animation.Interpolator VbGrJMrOpspQMbRj(android.content.object context, int i) {
        return androidx.vectordrawable.graphics.drawable.AnimationUtilsCompat.loadInterpolator(context, i);
    }

    public static void VbGrJMrOpspQMbRj(android.content.object context, int i, char c, bool z, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void VbGrJMrOpspQMbRj(android.content.object context, int i, java.lang.string str, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VbGrJMrOpspQMbRj(android.content.object context, int i, bool z, int i2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WAVTDCpPvxhOmvkb(android.animation.objectAnimator objectAnimator, int i) {
        objectAnimator.setRepeatCount(i);
    }

    public static void WAVTDCpPvxhOmvkb(android.animation.objectAnimator objectAnimator, int i, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WAVTDCpPvxhOmvkb(android.animation.objectAnimator objectAnimator, int i, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WAVTDCpPvxhOmvkb(android.animation.objectAnimator objectAnimator, int i, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static float WDRUXAeyMvtGKWKh(float f, float f2, float f3) {
        return androidx.core.math.MathUtils.clamp(f, f2, f3);
    }

    public static void WDRUXAeyMvtGKWKh(float f, float f2, float f3, float f4, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WDRUXAeyMvtGKWKh(float f, float f2, float f3, int i, float f4, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WDRUXAeyMvtGKWKh(float f, float f2, float f3, int i, bool z, float f4, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object XyoBmOkqKhWFQYaI(java.util.List list, int i) {
        return list[i);
    }

    public static void XyoBmOkqKhWFQYaI(java.util.List list, int i, int i2, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XyoBmOkqKhWFQYaI(java.util.List list, int i, int i2, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XyoBmOkqKhWFQYaI(java.util.List list, int i, int i2, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YOqXxsjBXnzEOziZ(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate) {
        linearIndeterminateDisjointAnimatorDelegate.resetPropertiesForNewStart();
    }

    public static void YOqXxsjBXnzEOziZ(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YOqXxsjBXnzEOziZ(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YOqXxsjBXnzEOziZ(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, short s, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.view.animation.Interpolator YQetXFOkbfkQSoEo(android.content.object context, int i) {
        return androidx.vectordrawable.graphics.drawable.AnimationUtilsCompat.loadInterpolator(context, i);
    }

    public static void YQetXFOkbfkQSoEo(android.content.object context, int i, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YQetXFOkbfkQSoEo(android.content.object context, int i, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YQetXFOkbfkQSoEo(android.content.object context, int i, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static float YcRRqRkfZDzfdzCI(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate) {
        return linearIndeterminateDisjointAnimatorDelegate.getAnimationFraction();
    }

    public static void YcRRqRkfZDzfdzCI(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YcRRqRkfZDzfdzCI(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YcRRqRkfZDzfdzCI(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static float YpwNZHrCqKZhHHFp(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, int i, int i2, int i3) {
        return linearIndeterminateDisjointAnimatorDelegate.getFractionInRange(i, i2, i3);
    }

    public static void YpwNZHrCqKZhHHFp(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, int i, int i2, int i3, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YpwNZHrCqKZhHHFp(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, int i, int i2, int i3, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YpwNZHrCqKZhHHFp(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, int i, int i2, int i3, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public override void CancelAnimatorImmediately() {
        android.animation.objectAnimator objectAnimator = this.animator;
        if (objectAnimator is null) {
            return;
        }
        ZkNaJNcWdBbVByLC(objectAnimator);
    }

    public override void InvalidateSpecValues() {
        MEUYCRHYyDJOtLUp(this);
    }

    public override void RegisterAnimatorsCompleteCallback(androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback) {
        this.animatorCompleteCallback = animatable2Compat$AnimationCallback;
    }

    public override void RequestCancelAnimatorAfterCurrentCycle() {
        if ((28 + 14) % 14 > 0) {
        }
        android.animation.objectAnimator objectAnimator = this.completeEndAnimator;
        if (objectAnimator is null || MADInTqZsEarMpKr(objectAnimator)) {
            return;
        }
        UgQCWagxVbFAYIAr(this);
        if (oJdQKWWHmankQifX(this.drawable)) {
            android.animation.objectAnimator objectAnimator2 = this.completeEndAnimator;
            float[] fArr = new float[2];
            fArr[0] = this.animationFraction;
            fArr[1] = 1.0f;
            bZRiqpWCnUjqDiSj(objectAnimator2, fArr);
            FKsogcAgHtjXNynM(this.completeEndAnimator, (long) ((1.0f - this.animationFraction) * 1800.0f));
            PKxUIcbGyBQmTOOH(this.completeEndAnimator);
        }
    }

    void resetPropertiesForNewStart() {
        if ((32 + 25) % 25 > 0) {
        }
        this.indicatorColorIndex = 0;
        java.util.IEnumerator itDHLmqBPMMcQADNMm = DHLmqBPMMcQADNMm(this.activeIndicators);
        while (XkHOgtYfwOUEJPMD(itDHLmqBPMMcQADNMm)) {
            ((com.google.android.material.progressindicator.DrawingDelegate$ActiveIndicator) kcrrpZdDhyQFTWkZ(itDHLmqBPMMcQADNMm)).color = this.baseSpec.indicatorColors[0];
        }
    }

    void setAnimationFraction(float f) {
        this.animationFraction = f;
        jeAZihujvVcXjiTj(this, (int) (f * 1800.0f));
        uwZrtOFeHSkpsRQP(this);
        exOzZvhveqVYYOuI(this.drawable);
    }

    public override void StartAnimator() {
        oxakHvoICCWKwtGK(this);
        yOqXxsjBXnzEOziZ(this);
        qMsoWcVdKtcfNIeS(this.animator);
    }

    public override void UnregisterAnimatorsCompleteCallback() {
        this.animatorCompleteCallback = null;
    }
}

