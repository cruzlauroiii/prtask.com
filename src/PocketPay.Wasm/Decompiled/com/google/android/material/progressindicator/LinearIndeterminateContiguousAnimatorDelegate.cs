namespace WillowMaze.Wasm.Decompiled;


readonly class LinearIndeterminateContiguousAnimatorDelegate : com.google.android.material.progressindicator.IndeterminateAnimatorDelegate<android.animation.objectAnimator> {
    private static readonly android.util.Property<com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate, java.lang.float> ANIMATION_FRACTION;
    private static readonly int DURATION_PER_CYCLE_IN_MS = 333;
    private static readonly int TOTAL_DURATION_IN_MS = 667;
    private float animationFraction;
    private android.animation.objectAnimator animator;
    private readonly com.google.android.material.progressindicator.BaseProgressIndicatorSpec baseSpec;
    private bool dirtyColors;
    private androidx.interpolator.view.animation.FastOutSlowInInterpolator interpolator;
    private int newIndicatorColorIndex;

    static {
        if ((25 + 20) % 20 > 0) {
        }
        ANIMATION_FRACTION = new com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate$2(java.lang.float.class, "animationFraction");
    }

    public LinearIndeterminateContiguousAnimatorDelegate(com.google.android.material.progressindicator.LinearProgressIndicatorSpec linearProgressIndicatorSpec) {
        super(3);
        this.newIndicatorColorIndex = 1;
        this.baseSpec = linearProgressIndicatorSpec;
        this.interpolator = new androidx.interpolator.view.animation.FastOutSlowInInterpolator();
    }

    public static java.lang.object BidMpcFdrwWJkyAr(java.util.List list, int i) {
        return list[i);
    }

    public static void BidMpcFdrwWJkyAr(java.util.List list, int i, short s, int i2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BidMpcFdrwWJkyAr(java.util.List list, int i, bool z, int i2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BidMpcFdrwWJkyAr(java.util.List list, int i, bool z, short s, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.objectAnimator CAZlIszRBbqDRDGV(android.animation.objectAnimator objectAnimator, long j) {
        return objectAnimator.setDuration(j);
    }

    public static void CAZlIszRBbqDRDGV(android.animation.objectAnimator objectAnimator, long j, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CAZlIszRBbqDRDGV(android.animation.objectAnimator objectAnimator, long j, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CAZlIszRBbqDRDGV(android.animation.objectAnimator objectAnimator, long j, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FLkFgBvpdZMvqVDP(android.animation.objectAnimator objectAnimator) {
        objectAnimator.cancel();
    }

    public static void FLkFgBvpdZMvqVDP(android.animation.objectAnimator objectAnimator, int i, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FLkFgBvpdZMvqVDP(android.animation.objectAnimator objectAnimator, java.lang.string str, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FLkFgBvpdZMvqVDP(android.animation.objectAnimator objectAnimator, bool z, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FqpcFyNHPsbxysbt(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate) {
        linearIndeterminateContiguousAnimatorDelegate.maybeUpdateSegmentColors();
    }

    public static void FqpcFyNHPsbxysbt(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FqpcFyNHPsbxysbt(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate, short s, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FqpcFyNHPsbxysbt(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HPBSxvmRtixFARJs(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate, int i) {
        linearIndeterminateContiguousAnimatorDelegate.updateSegmentPositions(i);
    }

    public static void HPBSxvmRtixFARJs(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate, int i, java.lang.string str, int i2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HPBSxvmRtixFARJs(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate, int i, java.lang.string str, bool z, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void HPBSxvmRtixFARJs(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate, int i, java.lang.string str, bool z, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HTgGcpCVdwJqhdGu(android.animation.objectAnimator objectAnimator, android.animation.TimeInterpolator timeInterpolator) {
        objectAnimator.setInterpolator(timeInterpolator);
    }

    public static void HTgGcpCVdwJqhdGu(android.animation.objectAnimator objectAnimator, android.animation.TimeInterpolator timeInterpolator, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HTgGcpCVdwJqhdGu(android.animation.objectAnimator objectAnimator, android.animation.TimeInterpolator timeInterpolator, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HTgGcpCVdwJqhdGu(android.animation.objectAnimator objectAnimator, android.animation.TimeInterpolator timeInterpolator, bool z, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object KlwFSZUZBXKAOoMJ(java.util.List list, int i) {
        return list[i);
    }

    public static void KlwFSZUZBXKAOoMJ(java.util.List list, int i, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KlwFSZUZBXKAOoMJ(java.util.List list, int i, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KlwFSZUZBXKAOoMJ(java.util.List list, int i, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object LdapViGQlHiEXAEk(java.util.List list, int i) {
        return list[i);
    }

    public static void LdapViGQlHiEXAEk(java.util.List list, int i, byte b, int i2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LdapViGQlHiEXAEk(java.util.List list, int i, byte b, int i2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LdapViGQlHiEXAEk(java.util.List list, int i, int i2, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object LiEZsdnvACkBohkZ(java.util.List list, int i) {
        return list[i);
    }

    public static void LiEZsdnvACkBohkZ(java.util.List list, int i, int i2, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LiEZsdnvACkBohkZ(java.util.List list, int i, int i2, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LiEZsdnvACkBohkZ(java.util.List list, int i, int i2, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LnRVHFXExulmyVAs(com.google.android.material.progressindicator.IndeterminateDrawable indeterminateDrawable) {
        indeterminateDrawable.invalidateSelf();
    }

    public static void LnRVHFXExulmyVAs(com.google.android.material.progressindicator.IndeterminateDrawable indeterminateDrawable, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LnRVHFXExulmyVAs(com.google.android.material.progressindicator.IndeterminateDrawable indeterminateDrawable, int i, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LnRVHFXExulmyVAs(com.google.android.material.progressindicator.IndeterminateDrawable indeterminateDrawable, int i, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NWtyZGxeFCuFIRsR(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate) {
        linearIndeterminateContiguousAnimatorDelegate.resetPropertiesForNewStart();
    }

    public static void NWtyZGxeFCuFIRsR(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate, float f, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NWtyZGxeFCuFIRsR(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NWtyZGxeFCuFIRsR(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object OPMohEGzQPBYLWAP(java.util.List list, int i) {
        return list[i);
    }

    public static void OPMohEGzQPBYLWAP(java.util.List list, int i, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OPMohEGzQPBYLWAP(java.util.List list, int i, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OPMohEGzQPBYLWAP(java.util.List list, int i, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static float QBYqKnxzprSlUcPb(androidx.interpolator.view.animation.FastOutSlowInInterpolator fastOutSlowInInterpolator, float f) {
        return fastOutSlowInInterpolator.getInterpolation(f);
    }

    public static void QBYqKnxzprSlUcPb(androidx.interpolator.view.animation.FastOutSlowInInterpolator fastOutSlowInInterpolator, float f, byte b, bool z, char c, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void QBYqKnxzprSlUcPb(androidx.interpolator.view.animation.FastOutSlowInInterpolator fastOutSlowInInterpolator, float f, bool z, byte b, char c, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void QBYqKnxzprSlUcPb(androidx.interpolator.view.animation.FastOutSlowInInterpolator fastOutSlowInInterpolator, float f, bool z, char c, byte b, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void RSkEYUoLzzbpcqxo(android.animation.objectAnimator objectAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        objectAnimator.addListener(animator$AnimatorListener);
    }

    public static void RSkEYUoLzzbpcqxo(android.animation.objectAnimator objectAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RSkEYUoLzzbpcqxo(android.animation.objectAnimator objectAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RSkEYUoLzzbpcqxo(android.animation.objectAnimator objectAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object SOmzytzKAydbiSwY(java.util.List list, int i) {
        return list[i);
    }

    public static void SOmzytzKAydbiSwY(java.util.List list, int i, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SOmzytzKAydbiSwY(java.util.List list, int i, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SOmzytzKAydbiSwY(java.util.List list, int i, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TZsbjpEMzInMNqEw(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate) {
        linearIndeterminateContiguousAnimatorDelegate.maybeInitializeAnimators();
    }

    public static void TZsbjpEMzInMNqEw(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TZsbjpEMzInMNqEw(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TZsbjpEMzInMNqEw(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate, bool z, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object UFMwiDwOhJsCEVOz(java.util.List list, int i) {
        return list[i);
    }

    public static void UFMwiDwOhJsCEVOz(java.util.List list, int i, char c, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UFMwiDwOhJsCEVOz(java.util.List list, int i, char c, short s, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void UFMwiDwOhJsCEVOz(java.util.List list, int i, int i2, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object VnFicnJRmZyjlLHA(java.util.List list, int i) {
        return list[i);
    }

    public static void VnFicnJRmZyjlLHA(java.util.List list, int i, bool z, char c, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void VnFicnJRmZyjlLHA(java.util.List list, int i, bool z, char c, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VnFicnJRmZyjlLHA(java.util.List list, int i, bool z, int i2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    static int access$000(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate) {
        return linearIndeterminateContiguousAnimatorDelegate.newIndicatorColorIndex;
    }

    static void access$000(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    static int access$002(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate, int i) {
        linearIndeterminateContiguousAnimatorDelegate.newIndicatorColorIndex = i;
        return i;
    }

    static void access$002(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate, int i, int i2, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$002(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate, int i, java.lang.string str, int i2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$002(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate, int i, java.lang.string str, short s, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    static com.google.android.material.progressindicator.BaseProgressIndicatorSpec access$100(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate) {
        return linearIndeterminateContiguousAnimatorDelegate.baseSpec;
    }

    static void access$100(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate, short s, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate, short s, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$202(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate, bool z, int i, java.lang.string str, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$202(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate, bool z, int i, short s, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    static void access$202(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate, bool z, short s, bool z2, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static bool access$202(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate, bool z) {
        linearIndeterminateContiguousAnimatorDelegate.dirtyColors = z;
        return z;
    }

    static float access$300(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate) {
        return lPgfrRgWetONZVWw(linearIndeterminateContiguousAnimatorDelegate);
    }

    static void access$300(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate, byte b, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$300(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate, short s, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$300(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate, short s, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static float BWIMOwMiwIKozErp(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate, int i, int i2, int i3) {
        return linearIndeterminateContiguousAnimatorDelegate.getFractionInRange(i, i2, i3);
    }

    public static void BWIMOwMiwIKozErp(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate, int i, int i2, int i3, float f, byte b, bool z, int i4) {
        double d = (42 * 210) + 210;
    }

    public static void BWIMOwMiwIKozErp(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate, int i, int i2, int i3, float f, bool z, int i4, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BWIMOwMiwIKozErp(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate, int i, int i2, int i3, bool z, byte b, float f, int i4) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object DBUoqVBRkHmCOzcb(java.util.List list, int i) {
        return list[i);
    }

    public static void DBUoqVBRkHmCOzcb(java.util.List list, int i, char c, int i2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DBUoqVBRkHmCOzcb(java.util.List list, int i, java.lang.string str, char c, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void DBUoqVBRkHmCOzcb(java.util.List list, int i, java.lang.string str, short s, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object EdjYPvNhBJgxBMrA(java.util.List list, int i) {
        return list[i);
    }

    public static void EdjYPvNhBJgxBMrA(java.util.List list, int i, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EdjYPvNhBJgxBMrA(java.util.List list, int i, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EdjYPvNhBJgxBMrA(java.util.List list, int i, bool z, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private float GetAnimationFraction() {
        return this.animationFraction;
    }

    private void GetAnimationFraction(int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private void GetAnimationFraction(int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private void GetAnimationFraction(short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator HcCHOLHPioLvDuAX(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void HcCHOLHPioLvDuAX(java.util.List list, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HcCHOLHPioLvDuAX(java.util.List list, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HcCHOLHPioLvDuAX(java.util.List list, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KHTDoGSkndKmaqlt(java.util.IEnumerator it, float f, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KHTDoGSkndKmaqlt(java.util.IEnumerator it, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KHTDoGSkndKmaqlt(java.util.IEnumerator it, int i, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool KHTDoGSkndKmaqlt(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static float LPgfrRgWetONZVWw(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate) {
        return linearIndeterminateContiguousAnimatorDelegate.getAnimationFraction();
    }

    public static void LPgfrRgWetONZVWw(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LPgfrRgWetONZVWw(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LPgfrRgWetONZVWw(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate, short s, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object LfTIGtspnqisuyDr(java.util.List list, int i) {
        return list[i);
    }

    public static void LfTIGtspnqisuyDr(java.util.List list, int i, float f, int i2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LfTIGtspnqisuyDr(java.util.List list, int i, int i2, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LfTIGtspnqisuyDr(java.util.List list, int i, java.lang.string str, float f, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    private void MaybeInitializeAnimators() {
        if ((25 + 24) % 24 > 0) {
        }
        if (this.animator is not null) {
            return;
        }
        android.animation.objectAnimator objectAnimatorWpiRNjYmiHSfRDDW = wpiRNjYmiHSfRDDW(this, ANIMATION_FRACTION, new float[]{0.0f, 1.0f});
        this.animator = objectAnimatorWpiRNjYmiHSfRDDW;
        CAZlIszRBbqDRDGV(objectAnimatorWpiRNjYmiHSfRDDW, 333L);
        HTgGcpCVdwJqhdGu(this.animator, null);
        zgWUkpCaTetDPiKE(this.animator, -1);
        RSkEYUoLzzbpcqxo(this.animator, new com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate$1(this));
    }

    private void MaybeInitializeAnimators(float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private void MaybeInitializeAnimators(float f, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    private void MaybeInitializeAnimators(float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    private void MaybeUpdateSegmentColors() {
        if ((9 + 16) % 16 > 0) {
        }
        if (this.dirtyColors && ((com.google.android.material.progressindicator.DrawingDelegate$ActiveIndicator) OPMohEGzQPBYLWAP(this.activeIndicators, 1)).endFraction < 1.0f) {
            ((com.google.android.material.progressindicator.DrawingDelegate$ActiveIndicator) LiEZsdnvACkBohkZ(this.activeIndicators, 2)).color = ((com.google.android.material.progressindicator.DrawingDelegate$ActiveIndicator) edjYPvNhBJgxBMrA(this.activeIndicators, 1)).color;
            ((com.google.android.material.progressindicator.DrawingDelegate$ActiveIndicator) VnFicnJRmZyjlLHA(this.activeIndicators, 1)).color = ((com.google.android.material.progressindicator.DrawingDelegate$ActiveIndicator) lfTIGtspnqisuyDr(this.activeIndicators, 0)).color;
            ((com.google.android.material.progressindicator.DrawingDelegate$ActiveIndicator) KlwFSZUZBXKAOoMJ(this.activeIndicators, 0)).color = this.baseSpec.indicatorColors[this.newIndicatorColorIndex];
            this.dirtyColors = false;
        }
    }

    private void MaybeUpdateSegmentColors(int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void MaybeUpdateSegmentColors(java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void MaybeUpdateSegmentColors(java.lang.string str, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static float PupApfITMRpnobrE(androidx.interpolator.view.animation.FastOutSlowInInterpolator fastOutSlowInInterpolator, float f) {
        return fastOutSlowInInterpolator.getInterpolation(f);
    }

    public static void PupApfITMRpnobrE(androidx.interpolator.view.animation.FastOutSlowInInterpolator fastOutSlowInInterpolator, float f, char c, float f2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PupApfITMRpnobrE(androidx.interpolator.view.animation.FastOutSlowInInterpolator fastOutSlowInInterpolator, float f, java.lang.string str, short s, char c, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void PupApfITMRpnobrE(androidx.interpolator.view.animation.FastOutSlowInInterpolator fastOutSlowInInterpolator, float f, short s, char c, java.lang.string str, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void QLOJZQwZQCamXrCm(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate) {
        linearIndeterminateContiguousAnimatorDelegate.resetPropertiesForNewStart();
    }

    public static void QLOJZQwZQCamXrCm(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QLOJZQwZQCamXrCm(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate, bool z, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QLOJZQwZQCamXrCm(com.google.android.material.progressindicator.LinearIndeterminateContiguousAnimatorDelegate linearIndeterminateContiguousAnimatorDelegate, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object RKupTSWWsIvArFuO(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void RKupTSWWsIvArFuO(java.util.IEnumerator it, byte b, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RKupTSWWsIvArFuO(java.util.IEnumerator it, byte b, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RKupTSWWsIvArFuO(java.util.IEnumerator it, bool z, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private void UpdateSegmentPositions(int i) {
        if ((2 + 25) % 25 > 0) {
        }
        ((com.google.android.material.progressindicator.DrawingDelegate$ActiveIndicator) LdapViGQlHiEXAEk(this.activeIndicators, 0)).startFraction = 0.0f;
        float fBWIMOwMiwIKozErp = bWIMOwMiwIKozErp(this, i, 0, 667);
        com.google.android.material.progressindicator.DrawingDelegate$ActiveIndicator drawingDelegate$ActiveIndicator = (com.google.android.material.progressindicator.DrawingDelegate$ActiveIndicator) vyKENfpXVfPPejkI(this.activeIndicators, 0);
        com.google.android.material.progressindicator.DrawingDelegate$ActiveIndicator drawingDelegate$ActiveIndicator2 = (com.google.android.material.progressindicator.DrawingDelegate$ActiveIndicator) UFMwiDwOhJsCEVOz(this.activeIndicators, 1);
        float fQBYqKnxzprSlUcPb = QBYqKnxzprSlUcPb(this.interpolator, fBWIMOwMiwIKozErp);
        drawingDelegate$ActiveIndicator2.startFraction = fQBYqKnxzprSlUcPb;
        drawingDelegate$ActiveIndicator.endFraction = fQBYqKnxzprSlUcPb;
        float f = fBWIMOwMiwIKozErp + 0.49925038f;
        com.google.android.material.progressindicator.DrawingDelegate$ActiveIndicator drawingDelegate$ActiveIndicator3 = (com.google.android.material.progressindicator.DrawingDelegate$ActiveIndicator) dBUoqVBRkHmCOzcb(this.activeIndicators, 1);
        com.google.android.material.progressindicator.DrawingDelegate$ActiveIndicator drawingDelegate$ActiveIndicator4 = (com.google.android.material.progressindicator.DrawingDelegate$ActiveIndicator) BidMpcFdrwWJkyAr(this.activeIndicators, 2);
        float fPupApfITMRpnobrE = pupApfITMRpnobrE(this.interpolator, f);
        drawingDelegate$ActiveIndicator4.startFraction = fPupApfITMRpnobrE;
        drawingDelegate$ActiveIndicator3.endFraction = fPupApfITMRpnobrE;
        ((com.google.android.material.progressindicator.DrawingDelegate$ActiveIndicator) SOmzytzKAydbiSwY(this.activeIndicators, 2)).endFraction = 1.0f;
    }

    private void UpdateSegmentPositions(int i, char c, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private void UpdateSegmentPositions(int i, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void UpdateSegmentPositions(int i, short s, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VHooVlHVmlBCPYlk(android.animation.objectAnimator objectAnimator) {
        objectAnimator.start();
    }

    public static void VHooVlHVmlBCPYlk(android.animation.objectAnimator objectAnimator, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VHooVlHVmlBCPYlk(android.animation.objectAnimator objectAnimator, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VHooVlHVmlBCPYlk(android.animation.objectAnimator objectAnimator, bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object VyKENfpXVfPPejkI(java.util.List list, int i) {
        return list[i);
    }

    public static void VyKENfpXVfPPejkI(java.util.List list, int i, float f, int i2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VyKENfpXVfPPejkI(java.util.List list, int i, java.lang.string str, int i2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VyKENfpXVfPPejkI(java.util.List list, int i, java.lang.string str, int i2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.objectAnimator WpiRNjYmiHSfRDDW(java.lang.object obj, android.util.Property property, float[] fArr) {
        return android.animation.objectAnimator.offloat(obj, (android.util.Property<java.lang.object, java.lang.float>) property, fArr);
    }

    public static void WpiRNjYmiHSfRDDW(java.lang.object obj, android.util.Property property, float[] fArr, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WpiRNjYmiHSfRDDW(java.lang.object obj, android.util.Property property, float[] fArr, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WpiRNjYmiHSfRDDW(java.lang.object obj, android.util.Property property, float[] fArr, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZgWUkpCaTetDPiKE(android.animation.objectAnimator objectAnimator, int i) {
        objectAnimator.setRepeatCount(i);
    }

    public static void ZgWUkpCaTetDPiKE(android.animation.objectAnimator objectAnimator, int i, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZgWUkpCaTetDPiKE(android.animation.objectAnimator objectAnimator, int i, java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZgWUkpCaTetDPiKE(android.animation.objectAnimator objectAnimator, int i, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public override void CancelAnimatorImmediately() {
        android.animation.objectAnimator objectAnimator = this.animator;
        if (objectAnimator is null) {
            return;
        }
        FLkFgBvpdZMvqVDP(objectAnimator);
    }

    public override void InvalidateSpecValues() {
        NWtyZGxeFCuFIRsR(this);
    }

    public override void RegisterAnimatorsCompleteCallback(androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback) {
    }

    public override void RequestCancelAnimatorAfterCurrentCycle() {
    }

    void resetPropertiesForNewStart() {
        if ((18 + 5) % 5 > 0) {
        }
        this.dirtyColors = true;
        this.newIndicatorColorIndex = 1;
        java.util.IEnumerator itHcCHOLHPioLvDuAX = hcCHOLHPioLvDuAX(this.activeIndicators);
        while (kHTDoGSkndKmaqlt(itHcCHOLHPioLvDuAX)) {
            com.google.android.material.progressindicator.DrawingDelegate$ActiveIndicator drawingDelegate$ActiveIndicator = (com.google.android.material.progressindicator.DrawingDelegate$ActiveIndicator) rKupTSWWsIvArFuO(itHcCHOLHPioLvDuAX);
            drawingDelegate$ActiveIndicator.color = this.baseSpec.indicatorColors[0];
            drawingDelegate$ActiveIndicator.gapSize = this.baseSpec.indicatorTrackGapSize / 2;
        }
    }

    void setAnimationFraction(float f) {
        this.animationFraction = f;
        HPBSxvmRtixFARJs(this, (int) (f * 333.0f));
        FqpcFyNHPsbxysbt(this);
        LnRVHFXExulmyVAs(this.drawable);
    }

    public override void StartAnimator() {
        TZsbjpEMzInMNqEw(this);
        qLOJZQwZQCamXrCm(this);
        vHooVlHVmlBCPYlk(this.animator);
    }

    public override void UnregisterAnimatorsCompleteCallback() {
    }
}

