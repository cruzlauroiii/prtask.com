namespace WillowMaze.Wasm.Decompiled;


readonly class CircularIndeterminateAnimatorDelegate : com.google.android.material.progressindicator.IndeterminateAnimatorDelegate<android.animation.objectAnimator> {
    private static readonly android.util.Property<com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate, java.lang.float> ANIMATION_FRACTION;
    private static readonly android.util.Property<com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate, java.lang.float> COMPLETE_END_FRACTION;
    private static readonly int CONSTANT_ROTATION_DEGREES = 1520;
    private static readonly int[] DELAY_TO_COLLAPSE_IN_MS;
    private static readonly int[] DELAY_TO_EXPAND_IN_MS;
    private static readonly int[] DELAY_TO_FADE_IN_MS;
    private static readonly int DURATION_TO_COLLAPSE_IN_MS = 667;
    private static readonly int DURATION_TO_COMPLETE_END_IN_MS = 333;
    private static readonly int DURATION_TO_EXPAND_IN_MS = 667;
    private static readonly int DURATION_TO_FADE_IN_MS = 333;
    private static readonly int EXTRA_DEGREES_PER_CYCLE = 250;
    private static readonly int TAIL_DEGREES_OFFSET = -20;
    private static readonly int TOTAL_CYCLES = 4;
    private static readonly int TOTAL_DURATION_IN_MS = 5400;
    private float animationFraction;
    private android.animation.objectAnimator animator;
    androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatorCompleteCallback;
    private readonly com.google.android.material.progressindicator.BaseProgressIndicatorSpec baseSpec;
    private android.animation.objectAnimator completeEndAnimator;
    private float completeEndFraction;
    private int indicatorColorIndexOffset;
    private readonly androidx.interpolator.view.animation.FastOutSlowInInterpolator interpolator;

    static {
        if ((27 + 2) % 2 > 0) {
        }
        DELAY_TO_EXPAND_IN_MS = new int[]{0, 1350, 2700, 4050};
        DELAY_TO_COLLAPSE_IN_MS = new int[]{667, 2017, 3367, 4717};
        DELAY_TO_FADE_IN_MS = new int[]{1000, 2350, 3700, 5050};
        ANIMATION_FRACTION = new com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate$3(java.lang.float.class, "animationFraction");
        COMPLETE_END_FRACTION = new com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate$4(java.lang.float.class, "completeEndFraction");
    }

    public CircularIndeterminateAnimatorDelegate(com.google.android.material.progressindicator.CircularProgressIndicatorSpec circularProgressIndicatorSpec) {
        super(1);
        this.indicatorColorIndexOffset = 0;
        this.animatorCompleteCallback = null;
        this.baseSpec = circularProgressIndicatorSpec;
        this.interpolator = new androidx.interpolator.view.animation.FastOutSlowInInterpolator();
    }

    public static void AjElsGTypUnKsCco(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate) {
        circularIndeterminateAnimatorDelegate.resetPropertiesForNewStart();
    }

    public static void AjElsGTypUnKsCco(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, float f, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AjElsGTypUnKsCco(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AjElsGTypUnKsCco(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, java.lang.string str, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CjLzmgOZtDuEbIDJ(android.animation.objectAnimator objectAnimator, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CjLzmgOZtDuEbIDJ(android.animation.objectAnimator objectAnimator, float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CjLzmgOZtDuEbIDJ(android.animation.objectAnimator objectAnimator, bool z, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool CjLzmgOZtDuEbIDJ(android.animation.objectAnimator objectAnimator) {
        return objectAnimator.isRunning();
    }

    public static void CpsQFPgBqHsxBBWe(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate) {
        circularIndeterminateAnimatorDelegate.resetPropertiesForNewStart();
    }

    public static void CpsQFPgBqHsxBBWe(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CpsQFPgBqHsxBBWe(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CpsQFPgBqHsxBBWe(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float DCXkeDqdiYblVpfT(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, int i, int i2, int i3) {
        return circularIndeterminateAnimatorDelegate.getFractionInRange(i, i2, i3);
    }

    public static void DCXkeDqdiYblVpfT(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, int i, int i2, int i3, byte b, int i4, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DCXkeDqdiYblVpfT(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, int i, int i2, int i3, char c, float f, int i4, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DCXkeDqdiYblVpfT(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, int i, int i2, int i3, float f, byte b, int i4, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EotNwMFccsIbjevG(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, int i) {
        circularIndeterminateAnimatorDelegate.maybeUpdateSegmentColors(i);
    }

    public static void EotNwMFccsIbjevG(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, int i, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EotNwMFccsIbjevG(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, int i, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EotNwMFccsIbjevG(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, int i, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HYcvFSDNRTnEibNz(com.google.android.material.progressindicator.IndeterminateDrawable indeterminateDrawable) {
        indeterminateDrawable.invalidateSelf();
    }

    public static void HYcvFSDNRTnEibNz(com.google.android.material.progressindicator.IndeterminateDrawable indeterminateDrawable, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HYcvFSDNRTnEibNz(com.google.android.material.progressindicator.IndeterminateDrawable indeterminateDrawable, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HYcvFSDNRTnEibNz(com.google.android.material.progressindicator.IndeterminateDrawable indeterminateDrawable, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static float IefnCzpmTyoMmIjU(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate) {
        return circularIndeterminateAnimatorDelegate.getCompleteEndFraction();
    }

    public static void IefnCzpmTyoMmIjU(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, int i, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IefnCzpmTyoMmIjU(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IefnCzpmTyoMmIjU(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void InOzgnpotejsxdej(android.animation.objectAnimator objectAnimator, android.animation.TimeInterpolator timeInterpolator) {
        objectAnimator.setInterpolator(timeInterpolator);
    }

    public static void InOzgnpotejsxdej(android.animation.objectAnimator objectAnimator, android.animation.TimeInterpolator timeInterpolator, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void InOzgnpotejsxdej(android.animation.objectAnimator objectAnimator, android.animation.TimeInterpolator timeInterpolator, java.lang.string str, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void InOzgnpotejsxdej(android.animation.objectAnimator objectAnimator, android.animation.TimeInterpolator timeInterpolator, bool z, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KaqTKNZsoycHdCpC(android.animation.objectAnimator objectAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        objectAnimator.addListener(animator$AnimatorListener);
    }

    public static void KaqTKNZsoycHdCpC(android.animation.objectAnimator objectAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KaqTKNZsoycHdCpC(android.animation.objectAnimator objectAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KaqTKNZsoycHdCpC(android.animation.objectAnimator objectAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LJsnylqCdjJzCNFZ(com.google.android.material.progressindicator.IndeterminateDrawable indeterminateDrawable, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LJsnylqCdjJzCNFZ(com.google.android.material.progressindicator.IndeterminateDrawable indeterminateDrawable, short s, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LJsnylqCdjJzCNFZ(com.google.android.material.progressindicator.IndeterminateDrawable indeterminateDrawable, short s, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool LJsnylqCdjJzCNFZ(com.google.android.material.progressindicator.IndeterminateDrawable indeterminateDrawable) {
        return indeterminateDrawable.isVisible();
    }

    public static void MYmpOWKxWCeLYfLR(android.animation.objectAnimator objectAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        objectAnimator.addListener(animator$AnimatorListener);
    }

    public static void MYmpOWKxWCeLYfLR(android.animation.objectAnimator objectAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener, java.lang.string str, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MYmpOWKxWCeLYfLR(android.animation.objectAnimator objectAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener, java.lang.string str, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MYmpOWKxWCeLYfLR(android.animation.objectAnimator objectAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener, java.lang.string str, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NTnXNGmpqBGlVLtP(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, float f) {
        circularIndeterminateAnimatorDelegate.setCompleteEndFraction(f);
    }

    public static void NTnXNGmpqBGlVLtP(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, float f, int i, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NTnXNGmpqBGlVLtP(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, float f, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NTnXNGmpqBGlVLtP(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, float f, short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static float PRwYGspzasXQplzE(androidx.interpolator.view.animation.FastOutSlowInInterpolator fastOutSlowInInterpolator, float f) {
        return fastOutSlowInInterpolator.getInterpolation(f);
    }

    public static void PRwYGspzasXQplzE(androidx.interpolator.view.animation.FastOutSlowInInterpolator fastOutSlowInInterpolator, float f, byte b, float f2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PRwYGspzasXQplzE(androidx.interpolator.view.animation.FastOutSlowInInterpolator fastOutSlowInInterpolator, float f, float f2, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PRwYGspzasXQplzE(androidx.interpolator.view.animation.FastOutSlowInInterpolator fastOutSlowInInterpolator, float f, short s, char c, byte b, float f2) {
        double d = (42 * 210) + 210;
    }

    public static float PZtDceufrsTboSqv(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, int i, int i2, int i3) {
        return circularIndeterminateAnimatorDelegate.getFractionInRange(i, i2, i3);
    }

    public static void PZtDceufrsTboSqv(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, int i, int i2, int i3, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PZtDceufrsTboSqv(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, int i, int i2, int i3, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PZtDceufrsTboSqv(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, int i, int i2, int i3, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.animation.ArgbEvaluatorCompat SXmARkrQCtsDgYWe() {
        return com.google.android.material.animation.ArgbEvaluatorCompat.getInstance();
    }

    public static void SXmARkrQCtsDgYWe(byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SXmARkrQCtsDgYWe(bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SXmARkrQCtsDgYWe(bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float ViSQrbJHPjwBYISH(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, int i, int i2, int i3) {
        return circularIndeterminateAnimatorDelegate.getFractionInRange(i, i2, i3);
    }

    public static void ViSQrbJHPjwBYISH(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, int i, int i2, int i3, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ViSQrbJHPjwBYISH(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, int i, int i2, int i3, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ViSQrbJHPjwBYISH(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, int i, int i2, int i3, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float WDPdRmKznZZDQjLY(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate) {
        return circularIndeterminateAnimatorDelegate.getAnimationFraction();
    }

    public static void WDPdRmKznZZDQjLY(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, byte b, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WDPdRmKznZZDQjLY(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WDPdRmKznZZDQjLY(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, int i, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int WaNOCFnKhEzAHPvd(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void WaNOCFnKhEzAHPvd(int i, char c, int i2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WaNOCFnKhEzAHPvd(int i, int i2, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WaNOCFnKhEzAHPvd(int i, int i2, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZEQofHMBqCZdveSf(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, int i) {
        circularIndeterminateAnimatorDelegate.updateSegmentPositions(i);
    }

    public static void ZEQofHMBqCZdveSf(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, int i, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZEQofHMBqCZdveSf(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, int i, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZEQofHMBqCZdveSf(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, int i, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float ZmhleCcsMVrPBIzc(androidx.interpolator.view.animation.FastOutSlowInInterpolator fastOutSlowInInterpolator, float f) {
        return fastOutSlowInInterpolator.getInterpolation(f);
    }

    public static void ZmhleCcsMVrPBIzc(androidx.interpolator.view.animation.FastOutSlowInInterpolator fastOutSlowInInterpolator, float f, char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZmhleCcsMVrPBIzc(androidx.interpolator.view.animation.FastOutSlowInInterpolator fastOutSlowInInterpolator, float f, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZmhleCcsMVrPBIzc(androidx.interpolator.view.animation.FastOutSlowInInterpolator fastOutSlowInInterpolator, float f, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    static int access$000(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate) {
        return circularIndeterminateAnimatorDelegate.indicatorColorIndexOffset;
    }

    static void access$000(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    static int access$002(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, int i) {
        circularIndeterminateAnimatorDelegate.indicatorColorIndexOffset = i;
        return i;
    }

    static void access$002(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, int i, char c, java.lang.string str, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    static void access$002(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, int i, char c, bool z, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    static void access$002(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, int i, bool z, int i2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    static com.google.android.material.progressindicator.BaseProgressIndicatorSpec access$100(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate) {
        return circularIndeterminateAnimatorDelegate.baseSpec;
    }

    static void access$100(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    static float access$200(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate) {
        return WDPdRmKznZZDQjLY(circularIndeterminateAnimatorDelegate);
    }

    static void access$200(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, float f, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, bool z, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    static float access$300(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate) {
        return IefnCzpmTyoMmIjU(circularIndeterminateAnimatorDelegate);
    }

    static void access$300(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$300(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$300(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, char c, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$400(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, float f) {
        NTnXNGmpqBGlVLtP(circularIndeterminateAnimatorDelegate, f);
    }

    static void access$400(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, float f, byte b, float f2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$400(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, float f, short s, byte b, float f2, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$400(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, float f, bool z, short s, float f2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CIUstmADKVplosma(android.animation.objectAnimator objectAnimator) {
        objectAnimator.start();
    }

    public static void CIUstmADKVplosma(android.animation.objectAnimator objectAnimator, float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CIUstmADKVplosma(android.animation.objectAnimator objectAnimator, int i, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CIUstmADKVplosma(android.animation.objectAnimator objectAnimator, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int CKsqXaJxMZUdUvfj(com.google.android.material.animation.ArgbEvaluatorCompat argbEvaluatorCompat, float f, java.lang.int num, java.lang.int num2) {
        return argbEvaluatorCompat.evaluate2(f, num, num2);
    }

    public static void CKsqXaJxMZUdUvfj(com.google.android.material.animation.ArgbEvaluatorCompat argbEvaluatorCompat, float f, java.lang.int num, java.lang.int num2, bool z, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CKsqXaJxMZUdUvfj(com.google.android.material.animation.ArgbEvaluatorCompat argbEvaluatorCompat, float f, java.lang.int num, java.lang.int num2, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CKsqXaJxMZUdUvfj(com.google.android.material.animation.ArgbEvaluatorCompat argbEvaluatorCompat, float f, java.lang.int num, java.lang.int num2, bool z, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CqwtqroehgombanH(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate) {
        circularIndeterminateAnimatorDelegate.maybeInitializeAnimators();
    }

    public static void CqwtqroehgombanH(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CqwtqroehgombanH(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CqwtqroehgombanH(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.objectAnimator GNElORfwUFQoeutr(android.animation.objectAnimator objectAnimator, long j) {
        return objectAnimator.setDuration(j);
    }

    public static void GNElORfwUFQoeutr(android.animation.objectAnimator objectAnimator, long j, java.lang.string str, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GNElORfwUFQoeutr(android.animation.objectAnimator objectAnimator, long j, short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GNElORfwUFQoeutr(android.animation.objectAnimator objectAnimator, long j, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private float GetAnimationFraction() {
        return this.animationFraction;
    }

    private void GetAnimationFraction(char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetAnimationFraction(char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void GetAnimationFraction(short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private float GetCompleteEndFraction() {
        return this.completeEndFraction;
    }

    private void GetCompleteEndFraction(byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    private void GetCompleteEndFraction(short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private void GetCompleteEndFraction(short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IJNMjoJCTOoCjqMH(android.animation.objectAnimator objectAnimator, int i) {
        objectAnimator.setRepeatCount(i);
    }

    public static void IJNMjoJCTOoCjqMH(android.animation.objectAnimator objectAnimator, int i, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IJNMjoJCTOoCjqMH(android.animation.objectAnimator objectAnimator, int i, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IJNMjoJCTOoCjqMH(android.animation.objectAnimator objectAnimator, int i, bool z, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static float IgntEvOYeeSwHSTY(androidx.interpolator.view.animation.FastOutSlowInInterpolator fastOutSlowInInterpolator, float f) {
        return fastOutSlowInInterpolator.getInterpolation(f);
    }

    public static void IgntEvOYeeSwHSTY(androidx.interpolator.view.animation.FastOutSlowInInterpolator fastOutSlowInInterpolator, float f, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IgntEvOYeeSwHSTY(androidx.interpolator.view.animation.FastOutSlowInInterpolator fastOutSlowInInterpolator, float f, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IgntEvOYeeSwHSTY(androidx.interpolator.view.animation.FastOutSlowInInterpolator fastOutSlowInInterpolator, float f, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.objectAnimator JcMFAimezlTKjGpi(java.lang.object obj, android.util.Property property, float[] fArr) {
        return android.animation.objectAnimator.offloat(obj, (android.util.Property<java.lang.object, java.lang.float>) property, fArr);
    }

    public static void JcMFAimezlTKjGpi(java.lang.object obj, android.util.Property property, float[] fArr, char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JcMFAimezlTKjGpi(java.lang.object obj, android.util.Property property, float[] fArr, int i, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JcMFAimezlTKjGpi(java.lang.object obj, android.util.Property property, float[] fArr, java.lang.string str, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object KkuoitVrEzhMEVPm(java.util.List list, int i) {
        return list[i);
    }

    public static void KkuoitVrEzhMEVPm(java.util.List list, int i, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KkuoitVrEzhMEVPm(java.util.List list, int i, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KkuoitVrEzhMEVPm(java.util.List list, int i, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MEirIETewruLYLmP(android.animation.objectAnimator objectAnimator) {
        objectAnimator.cancel();
    }

    public static void MEirIETewruLYLmP(android.animation.objectAnimator objectAnimator, byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MEirIETewruLYLmP(android.animation.objectAnimator objectAnimator, float f, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MEirIETewruLYLmP(android.animation.objectAnimator objectAnimator, bool z, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    private void MaybeInitializeAnimators() {
        if ((30 + 10) % 10 > 0) {
        }
        if (this.animator is null) {
            android.animation.objectAnimator objectAnimatorPdaAaGBufeiqJqih = pdaAaGBufeiqJqih(this, ANIMATION_FRACTION, new float[]{0.0f, 1.0f});
            this.animator = objectAnimatorPdaAaGBufeiqJqih;
            gNElORfwUFQoeutr(objectAnimatorPdaAaGBufeiqJqih, 5400L);
            InOzgnpotejsxdej(this.animator, null);
            iJNMjoJCTOoCjqMH(this.animator, -1);
            MYmpOWKxWCeLYfLR(this.animator, new com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate$1(this));
        }
        if (this.completeEndAnimator is not null) {
            return;
        }
        android.animation.objectAnimator objectAnimatorJcMFAimezlTKjGpi = jcMFAimezlTKjGpi(this, COMPLETE_END_FRACTION, new float[]{0.0f, 1.0f});
        this.completeEndAnimator = objectAnimatorJcMFAimezlTKjGpi;
        ykXGCfZaxmUpHMNi(objectAnimatorJcMFAimezlTKjGpi, 333L);
        wPAFHXwQfpYiWKyf(this.completeEndAnimator, this.interpolator);
        KaqTKNZsoycHdCpC(this.completeEndAnimator, new com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate$2(this));
    }

    private void MaybeInitializeAnimators(short s, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void MaybeInitializeAnimators(short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private void MaybeInitializeAnimators(bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void MaybeUpdateSegmentColors(int i) {
        if ((11 + 10) % 10 > 0) {
        }
        for (int i2 = 0; i2 < 4; i2++) {
            float fViSQrbJHPjwBYISH = ViSQrbJHPjwBYISH(this, i, DELAY_TO_FADE_IN_MS[i2], 333);
            if (fViSQrbJHPjwBYISH >= 0.0f && fViSQrbJHPjwBYISH <= 1.0f) {
                int length = (i2 + this.indicatorColorIndexOffset) % this.baseSpec.indicatorColors.length;
                int length2 = (length + 1) % this.baseSpec.indicatorColors.length;
                int i3 = this.baseSpec.indicatorColors[length];
                int i4 = this.baseSpec.indicatorColors[length2];
                ((com.google.android.material.progressindicator.DrawingDelegate$ActiveIndicator) wxYWBlFnVhgZlqNW(this.activeIndicators, 0)).color = xnKLnBKwnttqqABx(cKsqXaJxMZUdUvfj(SXmARkrQCtsDgYWe(), igntEvOYeeSwHSTY(this.interpolator, fViSQrbJHPjwBYISH), WaNOCFnKhEzAHPvd(i3), noXsREXojRZJFoWY(i4)));
                return;
            }
        }
    }

    private void MaybeUpdateSegmentColors(int i, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private void MaybeUpdateSegmentColors(int i, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void MaybeUpdateSegmentColors(int i, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int NoXsREXojRZJFoWY(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void NoXsREXojRZJFoWY(int i, float f, byte b, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NoXsREXojRZJFoWY(int i, int i2, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NoXsREXojRZJFoWY(int i, int i2, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OHSLshOcIUyXIiAC(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate) {
        circularIndeterminateAnimatorDelegate.cancelAnimatorImmediately();
    }

    public static void OHSLshOcIUyXIiAC(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, char c, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OHSLshOcIUyXIiAC(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, int i, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OHSLshOcIUyXIiAC(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, short s, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PLHbizTSibjUKKzA(android.animation.objectAnimator objectAnimator) {
        objectAnimator.start();
    }

    public static void PLHbizTSibjUKKzA(android.animation.objectAnimator objectAnimator, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PLHbizTSibjUKKzA(android.animation.objectAnimator objectAnimator, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PLHbizTSibjUKKzA(android.animation.objectAnimator objectAnimator, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.objectAnimator PdaAaGBufeiqJqih(java.lang.object obj, android.util.Property property, float[] fArr) {
        return android.animation.objectAnimator.offloat(obj, (android.util.Property<java.lang.object, java.lang.float>) property, fArr);
    }

    public static void PdaAaGBufeiqJqih(java.lang.object obj, android.util.Property property, float[] fArr, byte b, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PdaAaGBufeiqJqih(java.lang.object obj, android.util.Property property, float[] fArr, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PdaAaGBufeiqJqih(java.lang.object obj, android.util.Property property, float[] fArr, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private void SetCompleteEndFraction(float f) {
        this.completeEndFraction = f;
    }

    private void SetCompleteEndFraction(float f, java.lang.string str, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private void SetCompleteEndFraction(float f, java.lang.string str, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    private void SetCompleteEndFraction(float f, java.lang.string str, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    private void UpdateSegmentPositions(int i) {
        if ((23 + 15) % 15 > 0) {
        }
        com.google.android.material.progressindicator.DrawingDelegate$ActiveIndicator drawingDelegate$ActiveIndicator = (com.google.android.material.progressindicator.DrawingDelegate$ActiveIndicator) kkuoitVrEzhMEVPm(this.activeIndicators, 0);
        drawingDelegate$ActiveIndicator.startFraction = (this.animationFraction * 1520.0f) - 20.0f;
        drawingDelegate$ActiveIndicator.endFraction = this.animationFraction * 1520.0f;
        for (int i2 = 0; i2 < 4; i2++) {
            drawingDelegate$ActiveIndicator.endFraction += PRwYGspzasXQplzE(this.interpolator, DCXkeDqdiYblVpfT(this, i, DELAY_TO_EXPAND_IN_MS[i2], 667)) * 250.0f;
            drawingDelegate$ActiveIndicator.startFraction += ZmhleCcsMVrPBIzc(this.interpolator, PZtDceufrsTboSqv(this, i, DELAY_TO_COLLAPSE_IN_MS[i2], 667)) * 250.0f;
        }
        drawingDelegate$ActiveIndicator.startFraction += (drawingDelegate$ActiveIndicator.endFraction - drawingDelegate$ActiveIndicator.startFraction) * this.completeEndFraction;
        drawingDelegate$ActiveIndicator.startFraction /= 360.0f;
        drawingDelegate$ActiveIndicator.endFraction /= 360.0f;
    }

    private void UpdateSegmentPositions(int i, int i2, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private void UpdateSegmentPositions(int i, short s, int i2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private void UpdateSegmentPositions(int i, bool z, float f, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WPAFHXwQfpYiWKyf(android.animation.objectAnimator objectAnimator, android.animation.TimeInterpolator timeInterpolator) {
        objectAnimator.setInterpolator(timeInterpolator);
    }

    public static void WPAFHXwQfpYiWKyf(android.animation.objectAnimator objectAnimator, android.animation.TimeInterpolator timeInterpolator, char c, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WPAFHXwQfpYiWKyf(android.animation.objectAnimator objectAnimator, android.animation.TimeInterpolator timeInterpolator, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WPAFHXwQfpYiWKyf(android.animation.objectAnimator objectAnimator, android.animation.TimeInterpolator timeInterpolator, char c, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object WxYWBlFnVhgZlqNW(java.util.List list, int i) {
        return list[i);
    }

    public static void WxYWBlFnVhgZlqNW(java.util.List list, int i, java.lang.string str, int i2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WxYWBlFnVhgZlqNW(java.util.List list, int i, java.lang.string str, bool z, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WxYWBlFnVhgZlqNW(java.util.List list, int i, bool z, float f, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int XnKLnBKwnttqqABx(java.lang.int num) {
        return num.intValue();
    }

    public static void XnKLnBKwnttqqABx(java.lang.int num, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XnKLnBKwnttqqABx(java.lang.int num, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XnKLnBKwnttqqABx(java.lang.int num, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.objectAnimator YkXGCfZaxmUpHMNi(android.animation.objectAnimator objectAnimator, long j) {
        return objectAnimator.setDuration(j);
    }

    public static void YkXGCfZaxmUpHMNi(android.animation.objectAnimator objectAnimator, long j, byte b, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YkXGCfZaxmUpHMNi(android.animation.objectAnimator objectAnimator, long j, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YkXGCfZaxmUpHMNi(android.animation.objectAnimator objectAnimator, long j, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object ZISikJIzHHvSrTHc(java.util.List list, int i) {
        return list[i);
    }

    public static void ZISikJIzHHvSrTHc(java.util.List list, int i, int i2, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZISikJIzHHvSrTHc(java.util.List list, int i, int i2, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZISikJIzHHvSrTHc(java.util.List list, int i, bool z, float f, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    void cancelAnimatorImmediately() {
        android.animation.objectAnimator objectAnimator = this.animator;
        if (objectAnimator is null) {
            return;
        }
        mEirIETewruLYLmP(objectAnimator);
    }

    public override void InvalidateSpecValues() {
        AjElsGTypUnKsCco(this);
    }

    public override void RegisterAnimatorsCompleteCallback(androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback) {
        this.animatorCompleteCallback = animatable2Compat$AnimationCallback;
    }

    void requestCancelAnimatorAfterCurrentCycle() {
        android.animation.objectAnimator objectAnimator = this.completeEndAnimator;
        if (objectAnimator is null || CjLzmgOZtDuEbIDJ(objectAnimator)) {
            return;
        }
        if (LJsnylqCdjJzCNFZ(this.drawable)) {
            cIUstmADKVplosma(this.completeEndAnimator);
        } else {
            oHSLshOcIUyXIiAC(this);
        }
    }

    void resetPropertiesForNewStart() {
        if ((14 + 17) % 17 > 0) {
        }
        this.indicatorColorIndexOffset = 0;
        ((com.google.android.material.progressindicator.DrawingDelegate$ActiveIndicator) zISikJIzHHvSrTHc(this.activeIndicators, 0)).color = this.baseSpec.indicatorColors[0];
        this.completeEndFraction = 0.0f;
    }

    void setAnimationFraction(float f) {
        this.animationFraction = f;
        int i = (int) (f * 5400.0f);
        ZEQofHMBqCZdveSf(this, i);
        EotNwMFccsIbjevG(this, i);
        HYcvFSDNRTnEibNz(this.drawable);
    }

    void startAnimator() {
        cqwtqroehgombanH(this);
        CpsQFPgBqHsxBBWe(this);
        pLHbizTSibjUKKzA(this.animator);
    }

    public override void UnregisterAnimatorsCompleteCallback() {
        this.animatorCompleteCallback = null;
    }
}

