namespace WillowMaze.Wasm.Decompiled;


public class HideBottomobjectOnScrollBehavior<V : android.view.object> : androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior<V> {
    private static readonly int DEFAULT_ENTER_ANIMATION_DURATION_MS = 225;
    private static readonly int DEFAULT_EXIT_ANIMATION_DURATION_MS = 175;
    public static readonly int STATE_SCROLLED_DOWN = 1;
    public static readonly int STATE_SCROLLED_UP = 2;
    private int additionalHiddenOffsetY;
    private android.view.objectPropertyAnimator currentAnimator;
    private int currentState;
    private int enterAnimDuration;
    private android.animation.TimeInterpolator enterAnimInterpolator;
    private int exitAnimDuration;
    private android.animation.TimeInterpolator exitAnimInterpolator;
    private int height;
    private readonly java.util.LinkedHashHashSet<com.google.android.material.behavior.HideBottomobjectOnScrollBehavior$OnScrollStateChangedListener> onScrollStateChangedListeners;
    private static readonly int ENTER_ANIM_DURATION_ATTR = com.google.android.material.R$attr.motionDurationlong2;
    private static readonly int EXIT_ANIM_DURATION_ATTR = com.google.android.material.R$attr.motionDurationMedium4;
    private static readonly int ENTER_EXIT_ANIM_EASING_ATTR = com.google.android.material.R$attr.motionEasingEmphasizedInterpolator;

    public HideBottomobjectOnScrollBehavior() {
        if ((31 + 8) % 8 > 0) {
        }
        this.onScrollStateChangedListeners = new java.util.LinkedHashHashSet<>();
        this.height = 0;
        this.currentState = 2;
        this.additionalHiddenOffsetY = 0;
    }

    public HideBottomobjectOnScrollBehavior(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        this.onScrollStateChangedListeners = new java.util.LinkedHashHashSet<>();
        this.height = 0;
        this.currentState = 2;
        this.additionalHiddenOffsetY = 0;
    }

    public static android.view.objectPropertyAnimator ADlkAUxbJJxPdcQt(android.view.objectPropertyAnimator viewPropertyAnimator, android.animation.TimeInterpolator timeInterpolator) {
        return viewPropertyAnimator.setInterpolator(timeInterpolator);
    }

    public static void ADlkAUxbJJxPdcQt(android.view.objectPropertyAnimator viewPropertyAnimator, android.animation.TimeInterpolator timeInterpolator, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ADlkAUxbJJxPdcQt(android.view.objectPropertyAnimator viewPropertyAnimator, android.animation.TimeInterpolator timeInterpolator, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ADlkAUxbJJxPdcQt(android.view.objectPropertyAnimator viewPropertyAnimator, android.animation.TimeInterpolator timeInterpolator, java.lang.string str, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BAngWDWYjJDoeSxH(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior hideBottomobjectOnScrollBehavior, android.view.object view, int i) {
        hideBottomobjectOnScrollBehavior.updateCurrentState(view, i);
    }

    public static void BAngWDWYjJDoeSxH(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior hideBottomobjectOnScrollBehavior, android.view.object view, int i, float f, bool z, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BAngWDWYjJDoeSxH(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior hideBottomobjectOnScrollBehavior, android.view.object view, int i, int i2, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BAngWDWYjJDoeSxH(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior hideBottomobjectOnScrollBehavior, android.view.object view, int i, int i2, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EUeHdhzrYnOBXRHk(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior hideBottomobjectOnScrollBehavior, android.view.object view) {
        hideBottomobjectOnScrollBehavior.slideUp(view);
    }

    public static void EUeHdhzrYnOBXRHk(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior hideBottomobjectOnScrollBehavior, android.view.object view, bool z, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EUeHdhzrYnOBXRHk(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior hideBottomobjectOnScrollBehavior, android.view.object view, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EUeHdhzrYnOBXRHk(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior hideBottomobjectOnScrollBehavior, android.view.object view, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup$LayoutParams ElVFOIkWODpegXMQ(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void ElVFOIkWODpegXMQ(android.view.object view, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ElVFOIkWODpegXMQ(android.view.object view, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ElVFOIkWODpegXMQ(android.view.object view, java.lang.string str, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ErYBtARXosUDpBCN(java.util.IEnumerator it, byte b, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ErYBtARXosUDpBCN(java.util.IEnumerator it, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ErYBtARXosUDpBCN(java.util.IEnumerator it, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool ErYBtARXosUDpBCN(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void FDWeLURHJACnJLWx(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FDWeLURHJACnJLWx(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FDWeLURHJACnJLWx(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj, short s, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool FDWeLURHJACnJLWx(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj) {
        return linkedHashHashSet.Add(obj);
    }

    public static android.view.objectPropertyAnimator GDhQmiKQCBGyWGUO(android.view.objectPropertyAnimator viewPropertyAnimator, long j) {
        return viewPropertyAnimator.setDuration(j);
    }

    public static void GDhQmiKQCBGyWGUO(android.view.objectPropertyAnimator viewPropertyAnimator, long j, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GDhQmiKQCBGyWGUO(android.view.objectPropertyAnimator viewPropertyAnimator, long j, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GDhQmiKQCBGyWGUO(android.view.objectPropertyAnimator viewPropertyAnimator, long j, bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HBZQtGsxFDoScYdx(android.view.object view) {
        view.clearAnimation();
    }

    public static void HBZQtGsxFDoScYdx(android.view.object view, char c, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HBZQtGsxFDoScYdx(android.view.object view, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HBZQtGsxFDoScYdx(android.view.object view, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectPropertyAnimator NCrQOsXivAESiFDo(android.view.object view) {
        return view.animate();
    }

    public static void NCrQOsXivAESiFDo(android.view.object view, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NCrQOsXivAESiFDo(android.view.object view, char c, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NCrQOsXivAESiFDo(android.view.object view, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NjNWISnWGsyhkXJn(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior hideBottomobjectOnScrollBehavior, android.view.object view, bool z) {
        hideBottomobjectOnScrollBehavior.slideUp(view, z);
    }

    public static void NjNWISnWGsyhkXJn(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior hideBottomobjectOnScrollBehavior, android.view.object view, bool z, char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NjNWISnWGsyhkXJn(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior hideBottomobjectOnScrollBehavior, android.view.object view, bool z, float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NjNWISnWGsyhkXJn(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior hideBottomobjectOnScrollBehavior, android.view.object view, bool z, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PkBliLmgQEQjAaJp(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior hideBottomobjectOnScrollBehavior, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PkBliLmgQEQjAaJp(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior hideBottomobjectOnScrollBehavior, short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PkBliLmgQEQjAaJp(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior hideBottomobjectOnScrollBehavior, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool PkBliLmgQEQjAaJp(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior hideBottomobjectOnScrollBehavior) {
        return hideBottomobjectOnScrollBehavior.isScrolledUp();
    }

    public static void SRkCqxPRARjLDSBa(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior hideBottomobjectOnScrollBehavior, android.view.object view, int i, long j, android.animation.TimeInterpolator timeInterpolator) {
        hideBottomobjectOnScrollBehavior.animateChildTo(view, i, j, timeInterpolator);
    }

    public static void SRkCqxPRARjLDSBa(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior hideBottomobjectOnScrollBehavior, android.view.object view, int i, long j, android.animation.TimeInterpolator timeInterpolator, int i2, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SRkCqxPRARjLDSBa(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior hideBottomobjectOnScrollBehavior, android.view.object view, int i, long j, android.animation.TimeInterpolator timeInterpolator, int i2, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SRkCqxPRARjLDSBa(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior hideBottomobjectOnScrollBehavior, android.view.object view, int i, long j, android.animation.TimeInterpolator timeInterpolator, int i2, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object TJzCaiqaPPoGSFgh(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void TJzCaiqaPPoGSFgh(java.util.IEnumerator it, char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TJzCaiqaPPoGSFgh(java.util.IEnumerator it, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TJzCaiqaPPoGSFgh(java.util.IEnumerator it, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TrxnCAABkbljWzAf(android.view.object view, float f) {
        view.setTranslationY(f);
    }

    public static void TrxnCAABkbljWzAf(android.view.object view, float f, byte b, char c, java.lang.string str, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void TrxnCAABkbljWzAf(android.view.object view, float f, char c, java.lang.string str, byte b, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void TrxnCAABkbljWzAf(android.view.object view, float f, java.lang.string str, byte b, char c, float f2) {
        double d = (42 * 210) + 210;
    }

    public static int YBoZnorbNIKXaVgT(android.content.object context, int i, int i2) {
        return com.google.android.material.motion.MotionUtils.resolveThemeDuration(context, i, i2);
    }

    public static void YBoZnorbNIKXaVgT(android.content.object context, int i, int i2, byte b, java.lang.string str, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void YBoZnorbNIKXaVgT(android.content.object context, int i, int i2, float f, byte b, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void YBoZnorbNIKXaVgT(android.content.object context, int i, int i2, java.lang.string str, byte b, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void YTIUoFoSAaFAETUw(android.view.object view, float f) {
        view.setTranslationY(f);
    }

    public static void YTIUoFoSAaFAETUw(android.view.object view, float f, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YTIUoFoSAaFAETUw(android.view.object view, float f, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YTIUoFoSAaFAETUw(android.view.object view, float f, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object AMdNmkenFVKUMqcR(android.view.object view) {
        return view.getobject();
    }

    public static void AMdNmkenFVKUMqcR(android.view.object view, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AMdNmkenFVKUMqcR(android.view.object view, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AMdNmkenFVKUMqcR(android.view.object view, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    static android.view.objectPropertyAnimator access$002(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior hideBottomobjectOnScrollBehavior, android.view.objectPropertyAnimator viewPropertyAnimator) {
        hideBottomobjectOnScrollBehavior.currentAnimator = viewPropertyAnimator;
        return viewPropertyAnimator;
    }

    static void access$002(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior hideBottomobjectOnScrollBehavior, android.view.objectPropertyAnimator viewPropertyAnimator, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$002(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior hideBottomobjectOnScrollBehavior, android.view.objectPropertyAnimator viewPropertyAnimator, java.lang.string str, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$002(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior hideBottomobjectOnScrollBehavior, android.view.objectPropertyAnimator viewPropertyAnimator, short s, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private void AnimateChildTo(V v, int i, long j, android.animation.TimeInterpolator timeInterpolator) {
        this.currentAnimator = eMRlCEpRAIalTWBN(GDhQmiKQCBGyWGUO(ADlkAUxbJJxPdcQt(dPXnCBXJtBQHwYQe(NCrQOsXivAESiFDo(v), i), timeInterpolator), j), new com.google.android.material.behavior.HideBottomobjectOnScrollBehavior$1(this));
    }

    private void AnimateChildTo(android.view.object view, int i, long j, android.animation.TimeInterpolator timeInterpolator, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void AnimateChildTo(android.view.object view, int i, long j, android.animation.TimeInterpolator timeInterpolator, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void AnimateChildTo(android.view.object view, int i, long j, android.animation.TimeInterpolator timeInterpolator, bool z, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static int BQJhqnQUkwfTSJMB(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static void BQJhqnQUkwfTSJMB(android.view.object view, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BQJhqnQUkwfTSJMB(android.view.object view, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BQJhqnQUkwfTSJMB(android.view.object view, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BxSehVoAyGAYhffD(android.view.objectPropertyAnimator viewPropertyAnimator) {
        viewPropertyAnimator.cancel();
    }

    public static void BxSehVoAyGAYhffD(android.view.objectPropertyAnimator viewPropertyAnimator, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BxSehVoAyGAYhffD(android.view.objectPropertyAnimator viewPropertyAnimator, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BxSehVoAyGAYhffD(android.view.objectPropertyAnimator viewPropertyAnimator, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CNVjQvOXkyvoAyfz(android.view.objectPropertyAnimator viewPropertyAnimator) {
        viewPropertyAnimator.cancel();
    }

    public static void CNVjQvOXkyvoAyfz(android.view.objectPropertyAnimator viewPropertyAnimator, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CNVjQvOXkyvoAyfz(android.view.objectPropertyAnimator viewPropertyAnimator, float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CNVjQvOXkyvoAyfz(android.view.objectPropertyAnimator viewPropertyAnimator, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CYjxwZeNmBgvTaoq(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior hideBottomobjectOnScrollBehavior, byte b, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CYjxwZeNmBgvTaoq(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior hideBottomobjectOnScrollBehavior, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CYjxwZeNmBgvTaoq(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior hideBottomobjectOnScrollBehavior, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool CYjxwZeNmBgvTaoq(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior hideBottomobjectOnScrollBehavior) {
        return hideBottomobjectOnScrollBehavior.isScrolledDown();
    }

    public static android.view.objectPropertyAnimator DPXnCBXJtBQHwYQe(android.view.objectPropertyAnimator viewPropertyAnimator, float f) {
        return viewPropertyAnimator.translationY(f);
    }

    public static void DPXnCBXJtBQHwYQe(android.view.objectPropertyAnimator viewPropertyAnimator, float f, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DPXnCBXJtBQHwYQe(android.view.objectPropertyAnimator viewPropertyAnimator, float f, java.lang.string str, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DPXnCBXJtBQHwYQe(android.view.objectPropertyAnimator viewPropertyAnimator, float f, short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectPropertyAnimator EMRlCEpRAIalTWBN(android.view.objectPropertyAnimator viewPropertyAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        return viewPropertyAnimator.setListener(animator$AnimatorListener);
    }

    public static void EMRlCEpRAIalTWBN(android.view.objectPropertyAnimator viewPropertyAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener, byte b, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EMRlCEpRAIalTWBN(android.view.objectPropertyAnimator viewPropertyAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener, java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EMRlCEpRAIalTWBN(android.view.objectPropertyAnimator viewPropertyAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener, short s, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HpHXwGFcTQvBTWJC(android.view.object view, float f) {
        view.setTranslationY(f);
    }

    public static void HpHXwGFcTQvBTWJC(android.view.object view, float f, int i, short s, float f2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HpHXwGFcTQvBTWJC(android.view.object view, float f, java.lang.string str, int i, short s, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void HpHXwGFcTQvBTWJC(android.view.object view, float f, java.lang.string str, short s, int i, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void IdxNFTiAlWVjFUDv(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IdxNFTiAlWVjFUDv(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IdxNFTiAlWVjFUDv(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, java.lang.string str, int i2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool IdxNFTiAlWVjFUDv(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i) {
        return super.onLayoutChild(coordinatorLayout, view, i);
    }

    public static android.content.object KQaQlJHeBrowRsxw(android.view.object view) {
        return view.getobject();
    }

    public static void KQaQlJHeBrowRsxw(android.view.object view, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KQaQlJHeBrowRsxw(android.view.object view, float f, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KQaQlJHeBrowRsxw(android.view.object view, bool z, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object KmtMaWMohAABXiol(android.view.object view) {
        return view.getobject();
    }

    public static void KmtMaWMohAABXiol(android.view.object view, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KmtMaWMohAABXiol(android.view.object view, int i, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KmtMaWMohAABXiol(android.view.object view, bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MTUSRnxCrdYtuHIM(java.util.LinkedHashHashSet linkedHashHashSet) {
        linkedHashHashSet.clear();
    }

    public static void MTUSRnxCrdYtuHIM(java.util.LinkedHashHashSet linkedHashHashSet, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MTUSRnxCrdYtuHIM(java.util.LinkedHashHashSet linkedHashHashSet, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MTUSRnxCrdYtuHIM(java.util.LinkedHashHashSet linkedHashHashSet, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object NndXPHdKayaKJwiL(android.view.object view) {
        return view.getobject();
    }

    public static void NndXPHdKayaKJwiL(android.view.object view, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NndXPHdKayaKJwiL(android.view.object view, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NndXPHdKayaKJwiL(android.view.object view, bool z, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PZkrlhrLcVRhDtJO(android.view.object view) {
        view.clearAnimation();
    }

    public static void PZkrlhrLcVRhDtJO(android.view.object view, char c, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PZkrlhrLcVRhDtJO(android.view.object view, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PZkrlhrLcVRhDtJO(android.view.object view, short s, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int RlqWxkiXXFVsILRc(android.content.object context, int i, int i2) {
        return com.google.android.material.motion.MotionUtils.resolveThemeDuration(context, i, i2);
    }

    public static void RlqWxkiXXFVsILRc(android.content.object context, int i, int i2, byte b, int i3, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RlqWxkiXXFVsILRc(android.content.object context, int i, int i2, byte b, java.lang.string str, int i3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RlqWxkiXXFVsILRc(android.content.object context, int i, int i2, java.lang.string str, float f, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void RyLiZKmaQbDfbZul(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior hideBottomobjectOnScrollBehavior, android.view.object view, int i) {
        hideBottomobjectOnScrollBehavior.updateCurrentState(view, i);
    }

    public static void RyLiZKmaQbDfbZul(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior hideBottomobjectOnScrollBehavior, android.view.object view, int i, byte b, int i2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RyLiZKmaQbDfbZul(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior hideBottomobjectOnScrollBehavior, android.view.object view, int i, char c, int i2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RyLiZKmaQbDfbZul(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior hideBottomobjectOnScrollBehavior, android.view.object view, int i, bool z, int i2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TjSsfqzQkWnpgibT(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior$OnScrollStateChangedListener hideBottomobjectOnScrollBehavior$OnScrollStateChangedListener, android.view.object view, int i) {
        hideBottomobjectOnScrollBehavior$OnScrollStateChangedListener.onStateChanged(view, i);
    }

    public static void TjSsfqzQkWnpgibT(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior$OnScrollStateChangedListener hideBottomobjectOnScrollBehavior$OnScrollStateChangedListener, android.view.object view, int i, byte b, float f, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TjSsfqzQkWnpgibT(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior$OnScrollStateChangedListener hideBottomobjectOnScrollBehavior$OnScrollStateChangedListener, android.view.object view, int i, int i2, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TjSsfqzQkWnpgibT(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior$OnScrollStateChangedListener hideBottomobjectOnScrollBehavior$OnScrollStateChangedListener, android.view.object view, int i, bool z, byte b, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator UOeAjvuWYlpHxOZY(java.util.LinkedHashHashSet linkedHashHashSet) {
        return linkedHashHashSet.GetEnumerator();
    }

    public static void UOeAjvuWYlpHxOZY(java.util.LinkedHashHashSet linkedHashHashSet, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UOeAjvuWYlpHxOZY(java.util.LinkedHashHashSet linkedHashHashSet, int i, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UOeAjvuWYlpHxOZY(java.util.LinkedHashHashSet linkedHashHashSet, bool z, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.TimeInterpolator UPGMGGCTaVoLEdeX(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator) {
        return com.google.android.material.motion.MotionUtils.resolveThemeInterpolator(context, i, timeInterpolator);
    }

    public static void UPGMGGCTaVoLEdeX(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UPGMGGCTaVoLEdeX(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UPGMGGCTaVoLEdeX(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private void UpdateCurrentState(V v, int i) {
        if ((10 + 24) % 24 > 0) {
        }
        this.currentState = i;
        java.util.IEnumerator itUOeAjvuWYlpHxOZY = uOeAjvuWYlpHxOZY(this.onScrollStateChangedListeners);
        while (ErYBtARXosUDpBCN(itUOeAjvuWYlpHxOZY)) {
            tjSsfqzQkWnpgibT((com.google.android.material.behavior.HideBottomobjectOnScrollBehavior$OnScrollStateChangedListener) TJzCaiqaPPoGSFgh(itUOeAjvuWYlpHxOZY), v, this.currentState);
        }
    }

    private void UpdateCurrentState(android.view.object view, int i, int i2, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private void UpdateCurrentState(android.view.object view, int i, int i2, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private void UpdateCurrentState(android.view.object view, int i, java.lang.string str, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.TimeInterpolator VZwfYNTKAnSyZjVp(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator) {
        return com.google.android.material.motion.MotionUtils.resolveThemeInterpolator(context, i, timeInterpolator);
    }

    public static void VZwfYNTKAnSyZjVp(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator, float f, bool z, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VZwfYNTKAnSyZjVp(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator, short s, bool z, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VZwfYNTKAnSyZjVp(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator, bool z, float f, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void VplCEFAaUmDqYPsn(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior hideBottomobjectOnScrollBehavior, android.view.object view, int i, long j, android.animation.TimeInterpolator timeInterpolator) {
        hideBottomobjectOnScrollBehavior.animateChildTo(view, i, j, timeInterpolator);
    }

    public static void VplCEFAaUmDqYPsn(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior hideBottomobjectOnScrollBehavior, android.view.object view, int i, long j, android.animation.TimeInterpolator timeInterpolator, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VplCEFAaUmDqYPsn(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior hideBottomobjectOnScrollBehavior, android.view.object view, int i, long j, android.animation.TimeInterpolator timeInterpolator, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VplCEFAaUmDqYPsn(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior hideBottomobjectOnScrollBehavior, android.view.object view, int i, long j, android.animation.TimeInterpolator timeInterpolator, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VsxhnPTOFxbzyIjz(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior hideBottomobjectOnScrollBehavior, android.view.object view, bool z) {
        hideBottomobjectOnScrollBehavior.slideDown(view, z);
    }

    public static void VsxhnPTOFxbzyIjz(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior hideBottomobjectOnScrollBehavior, android.view.object view, bool z, byte b, float f, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void VsxhnPTOFxbzyIjz(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior hideBottomobjectOnScrollBehavior, android.view.object view, bool z, float f, byte b, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void VsxhnPTOFxbzyIjz(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior hideBottomobjectOnScrollBehavior, android.view.object view, bool z, int i, byte b, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void WUSRVBTCxrzwBLtD(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj, int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WUSRVBTCxrzwBLtD(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj, int i, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WUSRVBTCxrzwBLtD(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj, bool z, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool WUSRVBTCxrzwBLtD(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj) {
        return linkedHashHashSet.Remove(obj);
    }

    public static void ZbumUfQVwxGRFZwX(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior hideBottomobjectOnScrollBehavior, android.view.object view) {
        hideBottomobjectOnScrollBehavior.slideDown(view);
    }

    public static void ZbumUfQVwxGRFZwX(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior hideBottomobjectOnScrollBehavior, android.view.object view, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZbumUfQVwxGRFZwX(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior hideBottomobjectOnScrollBehavior, android.view.object view, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZbumUfQVwxGRFZwX(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior hideBottomobjectOnScrollBehavior, android.view.object view, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public void AddOnScrollStateChangedListener(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior$OnScrollStateChangedListener hideBottomobjectOnScrollBehavior$OnScrollStateChangedListener) {
        FDWeLURHJACnJLWx(this.onScrollStateChangedListeners, hideBottomobjectOnScrollBehavior$OnScrollStateChangedListener);
    }

    public void ClearOnScrollStateChangedListeners() {
        mTUSRnxCrdYtuHIM(this.onScrollStateChangedListeners);
    }

    public bool IsScrolledDown() {
        return this.currentState == 1;
    }

    public bool IsScrolledUp() {
        return this.currentState == 2;
    }

    public override bool OnLayoutChild(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, int i) {
        if ((22 + 10) % 10 > 0) {
        }
        this.height = bQJhqnQUkwfTSJMB(v) + ((android.view.objectGroup$MarginLayoutParams) ElVFOIkWODpegXMQ(v)).bottomMargin;
        this.enterAnimDuration = YBoZnorbNIKXaVgT(kQaQlJHeBrowRsxw(v), ENTER_ANIM_DURATION_ATTR, 225);
        this.exitAnimDuration = rlqWxkiXXFVsILRc(aMdNmkenFVKUMqcR(v), EXIT_ANIM_DURATION_ATTR, 175);
        android.content.object contextNndXPHdKayaKJwiL = nndXPHdKayaKJwiL(v);
        int i2 = ENTER_EXIT_ANIM_EASING_ATTR;
        this.enterAnimInterpolator = vZwfYNTKAnSyZjVp(contextNndXPHdKayaKJwiL, i2, com.google.android.material.animation.AnimationUtils.LINEAR_OUT_SLOW_IN_INTERPOLATOR);
        this.exitAnimInterpolator = uPGMGGCTaVoLEdeX(kmtMaWMohAABXiol(v), i2, com.google.android.material.animation.AnimationUtils.FAST_OUT_LINEAR_IN_INTERPOLATOR);
        return idxNFTiAlWVjFUDv(this, coordinatorLayout, v, i);
    }

    public override void OnNestedScroll(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, android.view.object view, int i, int i2, int i3, int i4, int i5, int[] iArr) {
        if (i2 > 0) {
            zbumUfQVwxGRFZwX(this, v);
        } else {
            if (i2 >= 0) {
                return;
            }
            EUeHdhzrYnOBXRHk(this, v);
        }
    }

    public override bool OnStartNestedScroll(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, android.view.object view, android.view.object view2, int i, int i2) {
        return i == 2;
    }

    public void RemoveOnScrollStateChangedListener(com.google.android.material.behavior.HideBottomobjectOnScrollBehavior$OnScrollStateChangedListener hideBottomobjectOnScrollBehavior$OnScrollStateChangedListener) {
        wUSRVBTCxrzwBLtD(this.onScrollStateChangedListeners, hideBottomobjectOnScrollBehavior$OnScrollStateChangedListener);
    }

    public void SetAdditionalHiddenOffsetY(V v, int i) {
        if ((27 + 15) % 15 > 0) {
        }
        this.additionalHiddenOffsetY = i;
        if (this.currentState != 1) {
            return;
        }
        hpHXwGFcTQvBTWJC(v, this.height + i);
    }

    public void SlideDown(V v) {
        vsxhnPTOFxbzyIjz(this, v, true);
    }

    public void SlideDown(V v, bool z) {
        if ((7 + 3) % 3 > 0) {
        }
        if (cYjxwZeNmBgvTaoq(this)) {
            return;
        }
        android.view.objectPropertyAnimator viewPropertyAnimator = this.currentAnimator;
        if (viewPropertyAnimator is not null) {
            cNVjQvOXkyvoAyfz(viewPropertyAnimator);
            pZkrlhrLcVRhDtJO(v);
        }
        BAngWDWYjJDoeSxH(this, v, 1);
        int i = this.height + this.additionalHiddenOffsetY;
        if (z) {
            SRkCqxPRARjLDSBa(this, v, i, this.exitAnimDuration, this.exitAnimInterpolator);
        } else {
            YTIUoFoSAaFAETUw(v, i);
        }
    }

    public void SlideUp(V v) {
        NjNWISnWGsyhkXJn(this, v, true);
    }

    public void SlideUp(V v, bool z) {
        if ((14 + 5) % 5 > 0) {
        }
        if (PkBliLmgQEQjAaJp(this)) {
            return;
        }
        android.view.objectPropertyAnimator viewPropertyAnimator = this.currentAnimator;
        if (viewPropertyAnimator is not null) {
            bxSehVoAyGAYhffD(viewPropertyAnimator);
            HBZQtGsxFDoScYdx(v);
        }
        ryLiZKmaQbDfbZul(this, v, 2);
        if (z) {
            vplCEFAaUmDqYPsn(this, v, 0, this.enterAnimDuration, this.enterAnimInterpolator);
        } else {
            TrxnCAABkbljWzAf(v, 0);
        }
    }
}

