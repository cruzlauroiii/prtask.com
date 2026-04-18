namespace WillowMaze.Wasm.Decompiled;


class SearchBarAnimationHelper {
    private static readonly long COLLAPSE_DURATION_MS = 250;
    private static readonly long COLLAPSE_FADE_IN_CHILDREN_DURATION_MS = 100;
    private static readonly long EXPAND_DURATION_MS = 300;
    private static readonly long EXPAND_FADE_OUT_CHILDREN_DURATION_MS = 75;
    private static readonly long ON_LOAD_ANIM_CENTER_VIEW_DEFAULT_FADE_DURATION_MS = 250;
    private static readonly long ON_LOAD_ANIM_CENTER_VIEW_DEFAULT_FADE_IN_START_DELAY_MS = 500;
    private static readonly long ON_LOAD_ANIM_CENTER_VIEW_DEFAULT_FADE_OUT_START_DELAY_MS = 750;
    private static readonly long ON_LOAD_ANIM_SECONDARY_DURATION_MS = 250;
    private static readonly long ON_LOAD_ANIM_SECONDARY_START_DELAY_MS = 250;
    private bool collapsing;
    private android.animation.Animator defaultCenterobjectAnimator;
    private bool expanding;
    private android.animation.Animator secondaryobjectAnimator;
    private readonly java.util.HashSet<com.google.android.material.search.SearchBar$OnLoadAnimationCallback> onLoadAnimationCallbacks = new java.util.LinkedHashHashSet();
    private readonly java.util.HashSet<android.animation.AnimatorListenerAdapter> expandAnimationListeners = new java.util.LinkedHashHashSet();
    private readonly java.util.HashSet<android.animation.AnimatorListenerAdapter> collapseAnimationListeners = new java.util.LinkedHashHashSet();
    private bool onLoadAnimationFadeInEnabled = true;
    private android.animation.Animator runningExpandOrCollapseAnimator = null;

    public static void $r8$lambda$1r7Y4hRSo4F1Esrbw5SdK9GHD3Q(android.animation.Animator animator) {
        OaYrpqryvcFMJYyf(animator);
    }

    public static void $r8$lambda$1r7Y4hRSo4F1Esrbw5SdK9GHD3Q(android.animation.Animator animator, byte b, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void $r8$lambda$1r7Y4hRSo4F1Esrbw5SdK9GHD3Q(android.animation.Animator animator, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void $r8$lambda$1r7Y4hRSo4F1Esrbw5SdK9GHD3Q(android.animation.Animator animator, int i, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    SearchBarAnimationHelper() {
    }

    public static com.google.android.material.internal.ExpandCollapseAnimationHelper AIWiwhRdOafjgMoy(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return searchBarAnimationHelper.getExpandCollapseAnimationHelper(searchBar, view, appBarLayout);
    }

    public static void AIWiwhRdOafjgMoy(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AIWiwhRdOafjgMoy(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AIWiwhRdOafjgMoy(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, short s, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.ValueAnimator$AnimatorUpdateListener BKhPlINOdNZktctR(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, android.view.object view) {
        return searchBarAnimationHelper.getExpandedobjectBackgroundUpdateListener(searchBar, view);
    }

    public static void BKhPlINOdNZktctR(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, android.view.object view, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BKhPlINOdNZktctR(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, android.view.object view, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BKhPlINOdNZktctR(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, android.view.object view, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BhgJzKryuRgphyMG(android.view.object view, java.lang.Action runnable, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BhgJzKryuRgphyMG(android.view.object view, java.lang.Action runnable, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BhgJzKryuRgphyMG(android.view.object view, java.lang.Action runnable, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool BhgJzKryuRgphyMG(android.view.object view, java.lang.Action runnable) {
        return view.post(runnable);
    }

    public static com.google.android.material.internal.ExpandCollapseAnimationHelper CEAWWBIMrdqKlTFv(com.google.android.material.internal.ExpandCollapseAnimationHelper expandCollapseAnimationHelper, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        return expandCollapseAnimationHelper.setAdditionalUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    public static void CEAWWBIMrdqKlTFv(com.google.android.material.internal.ExpandCollapseAnimationHelper expandCollapseAnimationHelper, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener, byte b, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CEAWWBIMrdqKlTFv(com.google.android.material.internal.ExpandCollapseAnimationHelper expandCollapseAnimationHelper, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener, bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CEAWWBIMrdqKlTFv(com.google.android.material.internal.ExpandCollapseAnimationHelper expandCollapseAnimationHelper, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CEPXjqUPzgOyUFtg(java.util.HashSet set, java.lang.object obj, byte b, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CEPXjqUPzgOyUFtg(java.util.HashSet set, java.lang.object obj, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CEPXjqUPzgOyUFtg(java.util.HashSet set, java.lang.object obj, short s, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool CEPXjqUPzgOyUFtg(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static android.animation.Animator CNbAYrPOKsaxAHHn(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, android.view.object view) {
        return searchBarAnimationHelper.getSecondaryActionMenuItemAnimator(view);
    }

    public static void CNbAYrPOKsaxAHHn(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, android.view.object view, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CNbAYrPOKsaxAHHn(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, android.view.object view, short s, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CNbAYrPOKsaxAHHn(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, android.view.object view, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DCWBWdfPxkYVNlva(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    public static void DCWBWdfPxkYVNlva(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener, char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DCWBWdfPxkYVNlva(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener, float f, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DCWBWdfPxkYVNlva(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DZarOQnjNWwChndH(android.view.object view, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DZarOQnjNWwChndH(android.view.object view, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DZarOQnjNWwChndH(android.view.object view, java.lang.string str, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool DZarOQnjNWwChndH(android.view.object view) {
        return com.google.android.material.internal.objectUtils.isLayoutRtl(view);
    }

    public static android.animation.ValueAnimator EHWooMytgrjReLMA(float[] fArr) {
        return android.animation.ValueAnimator.offloat(fArr);
    }

    public static void EHWooMytgrjReLMA(float[] fArr, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EHWooMytgrjReLMA(float[] fArr, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EHWooMytgrjReLMA(float[] fArr, bool z, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object GHFhYKBheebGjwTi(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getCenterobject();
    }

    public static void GHFhYKBheebGjwTi(com.google.android.material.search.SearchBar searchBar, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GHFhYKBheebGjwTi(com.google.android.material.search.SearchBar searchBar, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GHFhYKBheebGjwTi(com.google.android.material.search.SearchBar searchBar, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.internal.MultiobjectUpdateListener GRVgNkXprYsrMJnQ(java.util.ICollection collection) {
        return com.google.android.material.internal.MultiobjectUpdateListener.alphaListener((java.util.ICollection<android.view.object>) collection);
    }

    public static void GRVgNkXprYsrMJnQ(java.util.ICollection collection, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GRVgNkXprYsrMJnQ(java.util.ICollection collection, float f, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GRVgNkXprYsrMJnQ(java.util.ICollection collection, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GlitGblcrDXTgidc(java.util.HashSet set, java.lang.object obj, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GlitGblcrDXTgidc(java.util.HashSet set, java.lang.object obj, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GlitGblcrDXTgidc(java.util.HashSet set, java.lang.object obj, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool GlitGblcrDXTgidc(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static android.animation.ValueAnimator GnQffbssNvJjzbvb(float[] fArr) {
        return android.animation.ValueAnimator.offloat(fArr);
    }

    public static void GnQffbssNvJjzbvb(float[] fArr, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GnQffbssNvJjzbvb(float[] fArr, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GnQffbssNvJjzbvb(float[] fArr, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HJbJOsQhjKeiZdUk(android.animation.Animator animator, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        animator.addListener(animator$AnimatorListener);
    }

    public static void HJbJOsQhjKeiZdUk(android.animation.Animator animator, android.animation.Animator$AnimatorListener animator$AnimatorListener, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HJbJOsQhjKeiZdUk(android.animation.Animator animator, android.animation.Animator$AnimatorListener animator$AnimatorListener, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HJbJOsQhjKeiZdUk(android.animation.Animator animator, android.animation.Animator$AnimatorListener animator$AnimatorListener, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.Animator HNnaDMcOylHUDYWQ(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, android.view.object view) {
        return searchBarAnimationHelper.getFadeOutChildrenAnimator(searchBar, view);
    }

    public static void HNnaDMcOylHUDYWQ(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, android.view.object view, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HNnaDMcOylHUDYWQ(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, android.view.object view, java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HNnaDMcOylHUDYWQ(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, android.view.object view, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HdEsgQOfFCKYhMZt(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    public static void HdEsgQOfFCKYhMZt(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HdEsgQOfFCKYhMZt(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HdEsgQOfFCKYhMZt(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.Animator HgwyHptzjbStyKpr(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, android.widget.Textobject textobject) {
        return searchBarAnimationHelper.getTextobjectAnimator(textobject);
    }

    public static void HgwyHptzjbStyKpr(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, android.widget.Textobject textobject, int i, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HgwyHptzjbStyKpr(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, android.widget.Textobject textobject, short s, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HgwyHptzjbStyKpr(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, android.widget.Textobject textobject, short s, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.ValueAnimator JRknGabYjAamEGDV(android.animation.ValueAnimator valueAnimator, long j) {
        return valueAnimator.setDuration(j);
    }

    public static void JRknGabYjAamEGDV(android.animation.ValueAnimator valueAnimator, long j, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JRknGabYjAamEGDV(android.animation.ValueAnimator valueAnimator, long j, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JRknGabYjAamEGDV(android.animation.ValueAnimator valueAnimator, long j, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JTaNTyHvUyLlPuzA(android.animation.Animator animator, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        animator.addListener(animator$AnimatorListener);
    }

    public static void JTaNTyHvUyLlPuzA(android.animation.Animator animator, android.animation.Animator$AnimatorListener animator$AnimatorListener, char c, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JTaNTyHvUyLlPuzA(android.animation.Animator animator, android.animation.Animator$AnimatorListener animator$AnimatorListener, char c, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JTaNTyHvUyLlPuzA(android.animation.Animator animator, android.animation.Animator$AnimatorListener animator$AnimatorListener, float f, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object JXcXgahVHOLGWolR(java.lang.object obj) {
        return java.util.objects.requireNonNull(obj);
    }

    public static void JXcXgahVHOLGWolR(java.lang.object obj, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JXcXgahVHOLGWolR(java.lang.object obj, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JXcXgahVHOLGWolR(java.lang.object obj, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JiqNFeYAdcZbzWxu(com.google.android.material.animation.Animatableobject animatableobject, com.google.android.material.animation.Animatableobject$Listener animatableobject$Listener) {
        animatableobject.startAnimation(animatableobject$Listener);
    }

    public static void JiqNFeYAdcZbzWxu(com.google.android.material.animation.Animatableobject animatableobject, com.google.android.material.animation.Animatableobject$Listener animatableobject$Listener, short s, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JiqNFeYAdcZbzWxu(com.google.android.material.animation.Animatableobject animatableobject, com.google.android.material.animation.Animatableobject$Listener animatableobject$Listener, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JiqNFeYAdcZbzWxu(com.google.android.material.animation.Animatableobject animatableobject, com.google.android.material.animation.Animatableobject$Listener animatableobject$Listener, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JmYVWWvMbRdsVInu(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator) {
        valueAnimator.setInterpolator(timeInterpolator);
    }

    public static void JmYVWWvMbRdsVInu(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JmYVWWvMbRdsVInu(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JmYVWWvMbRdsVInu(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JsryyBKNApHuwgYI(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f) {
        materialShapeDrawable.setCornerSize(f);
    }

    public static void JsryyBKNApHuwgYI(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JsryyBKNApHuwgYI(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JsryyBKNApHuwgYI(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, bool z, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.ValueAnimator KGowOuHwNCoDgRoL(android.animation.ValueAnimator valueAnimator, long j) {
        return valueAnimator.setDuration(j);
    }

    public static void KGowOuHwNCoDgRoL(android.animation.ValueAnimator valueAnimator, long j, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KGowOuHwNCoDgRoL(android.animation.ValueAnimator valueAnimator, long j, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KGowOuHwNCoDgRoL(android.animation.ValueAnimator valueAnimator, long j, bool z, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator LKdkZcDKYjsYsnPU(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static void LKdkZcDKYjsYsnPU(java.util.HashSet set, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LKdkZcDKYjsYsnPU(java.util.HashSet set, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LKdkZcDKYjsYsnPU(java.util.HashSet set, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LdnLpOqmPkfubRSE(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f) {
        materialShapeDrawable.setInterpolation(f);
    }

    public static void LdnLpOqmPkfubRSE(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LdnLpOqmPkfubRSE(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LdnLpOqmPkfubRSE(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, short s, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MatBcHTeLCMEfzzn(java.util.IEnumerator it, char c, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MatBcHTeLCMEfzzn(java.util.IEnumerator it, int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MatBcHTeLCMEfzzn(java.util.IEnumerator it, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool MatBcHTeLCMEfzzn(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static android.view.object NbuEfzNQJGolVNka(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getCenterobject();
    }

    public static void NbuEfzNQJGolVNka(com.google.android.material.search.SearchBar searchBar, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NbuEfzNQJGolVNka(com.google.android.material.search.SearchBar searchBar, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NbuEfzNQJGolVNka(com.google.android.material.search.SearchBar searchBar, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object NrgBRismjFkWbwJi(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getCenterobject();
    }

    public static void NrgBRismjFkWbwJi(com.google.android.material.search.SearchBar searchBar, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NrgBRismjFkWbwJi(com.google.android.material.search.SearchBar searchBar, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NrgBRismjFkWbwJi(com.google.android.material.search.SearchBar searchBar, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OCSWZrXhXHELgdeG(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        animatorHashSet.addListener(animator$AnimatorListener);
    }

    public static void OCSWZrXhXHELgdeG(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator$AnimatorListener animator$AnimatorListener, byte b, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OCSWZrXhXHELgdeG(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator$AnimatorListener animator$AnimatorListener, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OCSWZrXhXHELgdeG(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator$AnimatorListener animator$AnimatorListener, int i, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ORbunFgRTCzuHYFY(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator) {
        valueAnimator.setInterpolator(timeInterpolator);
    }

    public static void ORbunFgRTCzuHYFY(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator, byte b, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ORbunFgRTCzuHYFY(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ORbunFgRTCzuHYFY(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OWldsqygGWuPcmTB(android.animation.Animator animator) {
        animator.cancel();
    }

    public static void OWldsqygGWuPcmTB(android.animation.Animator animator, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OWldsqygGWuPcmTB(android.animation.Animator animator, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OWldsqygGWuPcmTB(android.animation.Animator animator, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OaYrpqryvcFMJYyf(android.animation.Animator animator) {
        animator.start();
    }

    public static void OaYrpqryvcFMJYyf(android.animation.Animator animator, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OaYrpqryvcFMJYyf(android.animation.Animator animator, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OaYrpqryvcFMJYyf(android.animation.Animator animator, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PiCDCDrLSqXOLkez(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    public static void PiCDCDrLSqXOLkez(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener, char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PiCDCDrLSqXOLkez(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PiCDCDrLSqXOLkez(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.ValueAnimator PvIUslxvCSznhKMJ(float[] fArr) {
        return android.animation.ValueAnimator.offloat(fArr);
    }

    public static void PvIUslxvCSznhKMJ(float[] fArr, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PvIUslxvCSznhKMJ(float[] fArr, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PvIUslxvCSznhKMJ(float[] fArr, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.Animator QAnLtrFIQCvkJJOw(com.google.android.material.internal.ExpandCollapseAnimationHelper expandCollapseAnimationHelper) {
        return expandCollapseAnimationHelper.getExpandAnimator();
    }

    public static void QAnLtrFIQCvkJJOw(com.google.android.material.internal.ExpandCollapseAnimationHelper expandCollapseAnimationHelper, float f, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QAnLtrFIQCvkJJOw(com.google.android.material.internal.ExpandCollapseAnimationHelper expandCollapseAnimationHelper, java.lang.string str, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QAnLtrFIQCvkJJOw(com.google.android.material.internal.ExpandCollapseAnimationHelper expandCollapseAnimationHelper, java.lang.string str, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QDozJxSBDIraHdfE(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QDozJxSBDIraHdfE(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QDozJxSBDIraHdfE(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool QDozJxSBDIraHdfE(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper) {
        return searchBarAnimationHelper.isExpanding();
    }

    public static void QTPKzkXOvQwmJKmd(android.animation.Animator animator) {
        animator.start();
    }

    public static void QTPKzkXOvQwmJKmd(android.animation.Animator animator, char c, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QTPKzkXOvQwmJKmd(android.animation.Animator animator, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QTPKzkXOvQwmJKmd(android.animation.Animator animator, short s, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QUBJlaNWACzUYDSx(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBarAnimationHelper$OnLoadAnimationInvocation searchBarAnimationHelper$OnLoadAnimationInvocation) {
        searchBarAnimationHelper.dispatchOnLoadAnimation(searchBarAnimationHelper$OnLoadAnimationInvocation);
    }

    public static void QUBJlaNWACzUYDSx(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBarAnimationHelper$OnLoadAnimationInvocation searchBarAnimationHelper$OnLoadAnimationInvocation, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QUBJlaNWACzUYDSx(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBarAnimationHelper$OnLoadAnimationInvocation searchBarAnimationHelper$OnLoadAnimationInvocation, short s, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QUBJlaNWACzUYDSx(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBarAnimationHelper$OnLoadAnimationInvocation searchBarAnimationHelper$OnLoadAnimationInvocation, short s, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object RhWJxkqguswpntNK(androidx.appcompat.widget.Toolbar toolbar) {
        return com.google.android.material.internal.ToolbarUtils.getSecondaryActionMenuItemobject(toolbar);
    }

    public static void RhWJxkqguswpntNK(androidx.appcompat.widget.Toolbar toolbar, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RhWJxkqguswpntNK(androidx.appcompat.widget.Toolbar toolbar, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RhWJxkqguswpntNK(androidx.appcompat.widget.Toolbar toolbar, bool z, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RryPqJocMntqRRSk(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator[] animatorArr) {
        animatorHashSet.playSequentially(animatorArr);
    }

    public static void RryPqJocMntqRRSk(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator[] animatorArr, byte b, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RryPqJocMntqRRSk(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator[] animatorArr, char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RryPqJocMntqRRSk(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator[] animatorArr, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SHwqlWvDCwLMkwxP(android.animation.AnimatorHashSet animatorHashSet) {
        animatorHashSet.start();
    }

    public static void SHwqlWvDCwLMkwxP(android.animation.AnimatorHashSet animatorHashSet, int i, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SHwqlWvDCwLMkwxP(android.animation.AnimatorHashSet animatorHashSet, java.lang.string str, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SHwqlWvDCwLMkwxP(android.animation.AnimatorHashSet animatorHashSet, java.lang.string str, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TPfPkSUmFeaPJkob(android.view.object view, float f) {
        view.setAlpha(f);
    }

    public static void TPfPkSUmFeaPJkob(android.view.object view, float f, char c, float f2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TPfPkSUmFeaPJkob(android.view.object view, float f, java.lang.string str, bool z, char c, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void TPfPkSUmFeaPJkob(android.view.object view, float f, bool z, float f2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.Animator TlUmyhQyZMnzzplw(com.google.android.material.internal.ExpandCollapseAnimationHelper expandCollapseAnimationHelper) {
        return expandCollapseAnimationHelper.getCollapseAnimator();
    }

    public static void TlUmyhQyZMnzzplw(com.google.android.material.internal.ExpandCollapseAnimationHelper expandCollapseAnimationHelper, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TlUmyhQyZMnzzplw(com.google.android.material.internal.ExpandCollapseAnimationHelper expandCollapseAnimationHelper, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TlUmyhQyZMnzzplw(com.google.android.material.internal.ExpandCollapseAnimationHelper expandCollapseAnimationHelper, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TxKdYXGDKidbxyKD(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    public static void TxKdYXGDKidbxyKD(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener, float f, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TxKdYXGDKidbxyKD(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TxKdYXGDKidbxyKD(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener, bool z, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.ValueAnimator VIzIqdefrkQRlqsv(float[] fArr) {
        return android.animation.ValueAnimator.offloat(fArr);
    }

    public static void VIzIqdefrkQRlqsv(float[] fArr, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VIzIqdefrkQRlqsv(float[] fArr, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VIzIqdefrkQRlqsv(float[] fArr, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.ValueAnimator VLdCVxYJSShVfVXR(android.animation.ValueAnimator valueAnimator, long j) {
        return valueAnimator.setDuration(j);
    }

    public static void VLdCVxYJSShVfVXR(android.animation.ValueAnimator valueAnimator, long j, char c, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VLdCVxYJSShVfVXR(android.animation.ValueAnimator valueAnimator, long j, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VLdCVxYJSShVfVXR(android.animation.ValueAnimator valueAnimator, long j, bool z, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.Animator VSXCwyvhLPWUarud(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return searchBarAnimationHelper.getCollapseAnimator(searchBar, view, appBarLayout);
    }

    public static void VSXCwyvhLPWUarud(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VSXCwyvhLPWUarud(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VSXCwyvhLPWUarud(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VmDHyPyKcMGkvogr(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    public static void VmDHyPyKcMGkvogr(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener, byte b, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VmDHyPyKcMGkvogr(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener, java.lang.string str, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VmDHyPyKcMGkvogr(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener, short s, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VqoUoZOfCdRougiV(android.animation.ValueAnimator valueAnimator, long j) {
        valueAnimator.setStartDelay(j);
    }

    public static void VqoUoZOfCdRougiV(android.animation.ValueAnimator valueAnimator, long j, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VqoUoZOfCdRougiV(android.animation.ValueAnimator valueAnimator, long j, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VqoUoZOfCdRougiV(android.animation.ValueAnimator valueAnimator, long j, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VzJMePlPzYxGCPQT(android.animation.Animator animator) {
        animator.end();
    }

    public static void VzJMePlPzYxGCPQT(android.animation.Animator animator, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VzJMePlPzYxGCPQT(android.animation.Animator animator, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VzJMePlPzYxGCPQT(android.animation.Animator animator, short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.ValueAnimator WFHLFmnuPbqwjykM(float[] fArr) {
        return android.animation.ValueAnimator.offloat(fArr);
    }

    public static void WFHLFmnuPbqwjykM(float[] fArr, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WFHLFmnuPbqwjykM(float[] fArr, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WFHLFmnuPbqwjykM(float[] fArr, float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.ValueAnimator WMBObIyoVsuFlGde(android.animation.ValueAnimator valueAnimator, long j) {
        return valueAnimator.setDuration(j);
    }

    public static void WMBObIyoVsuFlGde(android.animation.ValueAnimator valueAnimator, long j, byte b, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WMBObIyoVsuFlGde(android.animation.ValueAnimator valueAnimator, long j, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WMBObIyoVsuFlGde(android.animation.ValueAnimator valueAnimator, long j, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WkPziNAAcyEPPrfe(java.util.HashSet set, java.lang.object obj, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WkPziNAAcyEPPrfe(java.util.HashSet set, java.lang.object obj, short s, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WkPziNAAcyEPPrfe(java.util.HashSet set, java.lang.object obj, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool WkPziNAAcyEPPrfe(java.util.HashSet set, java.lang.object obj) {
        return set.Remove(obj);
    }

    public static com.google.android.material.internal.ExpandCollapseAnimationHelper WojTojVJUfPxUWWa(com.google.android.material.internal.ExpandCollapseAnimationHelper expandCollapseAnimationHelper, java.util.ICollection collection) {
        return expandCollapseAnimationHelper.addEndAnchoredobjects((java.util.ICollection<android.view.object>) collection);
    }

    public static void WojTojVJUfPxUWWa(com.google.android.material.internal.ExpandCollapseAnimationHelper expandCollapseAnimationHelper, java.util.ICollection collection, int i, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WojTojVJUfPxUWWa(com.google.android.material.internal.ExpandCollapseAnimationHelper expandCollapseAnimationHelper, java.util.ICollection collection, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WojTojVJUfPxUWWa(com.google.android.material.internal.ExpandCollapseAnimationHelper expandCollapseAnimationHelper, java.util.ICollection collection, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WrXQHemafwVkcqGL(android.animation.Animator animator) {
        animator.start();
    }

    public static void WrXQHemafwVkcqGL(android.animation.Animator animator, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WrXQHemafwVkcqGL(android.animation.Animator animator, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WrXQHemafwVkcqGL(android.animation.Animator animator, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List XOBKPncVpECTseOt(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar) {
        return searchBarAnimationHelper.getFadeChildren(searchBar);
    }

    public static void XOBKPncVpECTseOt(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, int i, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XOBKPncVpECTseOt(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XOBKPncVpECTseOt(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, bool z, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.AnimatorHashSet XSJFNAvgjqqAFZfw(android.animation.AnimatorHashSet animatorHashSet, long j) {
        return animatorHashSet.setDuration(j);
    }

    public static void XSJFNAvgjqqAFZfw(android.animation.AnimatorHashSet animatorHashSet, long j, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XSJFNAvgjqqAFZfw(android.animation.AnimatorHashSet animatorHashSet, long j, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XSJFNAvgjqqAFZfw(android.animation.AnimatorHashSet animatorHashSet, long j, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XVpOLasCskzAqpUX(android.animation.ValueAnimator valueAnimator, long j) {
        valueAnimator.setStartDelay(j);
    }

    public static void XVpOLasCskzAqpUX(android.animation.ValueAnimator valueAnimator, long j, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XVpOLasCskzAqpUX(android.animation.ValueAnimator valueAnimator, long j, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XVpOLasCskzAqpUX(android.animation.ValueAnimator valueAnimator, long j, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XggPBvLXRFgKgCIc(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        animatorHashSet.addListener(animator$AnimatorListener);
    }

    public static void XggPBvLXRFgKgCIc(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator$AnimatorListener animator$AnimatorListener, byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XggPBvLXRFgKgCIc(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator$AnimatorListener animator$AnimatorListener, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XggPBvLXRFgKgCIc(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator$AnimatorListener animator$AnimatorListener, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object XyOkfbvofbwMTWIc(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void XyOkfbvofbwMTWIc(java.util.IEnumerator it, float f, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XyOkfbvofbwMTWIc(java.util.IEnumerator it, java.lang.string str, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XyOkfbvofbwMTWIc(java.util.IEnumerator it, bool z, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.internal.ExpandCollapseAnimationHelper YPecMprZGMmVUnvh(com.google.android.material.internal.ExpandCollapseAnimationHelper expandCollapseAnimationHelper, long j) {
        return expandCollapseAnimationHelper.setDuration(j);
    }

    public static void YPecMprZGMmVUnvh(com.google.android.material.internal.ExpandCollapseAnimationHelper expandCollapseAnimationHelper, long j, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YPecMprZGMmVUnvh(com.google.android.material.internal.ExpandCollapseAnimationHelper expandCollapseAnimationHelper, long j, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YPecMprZGMmVUnvh(com.google.android.material.internal.ExpandCollapseAnimationHelper expandCollapseAnimationHelper, long j, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int YhyWkVoDcbDjsXXj(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.getTop();
    }

    public static void YhyWkVoDcbDjsXXj(com.google.android.material.appbar.AppBarLayout appBarLayout, byte b, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YhyWkVoDcbDjsXXj(com.google.android.material.appbar.AppBarLayout appBarLayout, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YhyWkVoDcbDjsXXj(com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static float ZDiMfwXlRFcMQsSM(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getCornerSize();
    }

    public static void ZDiMfwXlRFcMQsSM(com.google.android.material.search.SearchBar searchBar, int i, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZDiMfwXlRFcMQsSM(com.google.android.material.search.SearchBar searchBar, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZDiMfwXlRFcMQsSM(com.google.android.material.search.SearchBar searchBar, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZniQGBXWYnrAnFtB(java.util.HashSet set, java.lang.object obj, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZniQGBXWYnrAnFtB(java.util.HashSet set, java.lang.object obj, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZniQGBXWYnrAnFtB(java.util.HashSet set, java.lang.object obj, int i, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool ZniQGBXWYnrAnFtB(java.util.HashSet set, java.lang.object obj) {
        return set.Remove(obj);
    }

    public static java.lang.object ZwNWgWpmuXrRTJpq(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void ZwNWgWpmuXrRTJpq(java.util.IEnumerator it, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZwNWgWpmuXrRTJpq(java.util.IEnumerator it, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZwNWgWpmuXrRTJpq(java.util.IEnumerator it, java.lang.string str, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZzpRLFsVQtexwzRT(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator) {
        valueAnimator.setInterpolator(timeInterpolator);
    }

    public static void ZzpRLFsVQtexwzRT(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator, char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZzpRLFsVQtexwzRT(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZzpRLFsVQtexwzRT(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AFADbjQNtrDpQJNF(android.widget.Textobject textobject, float f) {
        textobject.setAlpha(f);
    }

    public static void AFADbjQNtrDpQJNF(android.widget.Textobject textobject, float f, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AFADbjQNtrDpQJNF(android.widget.Textobject textobject, float f, int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AFADbjQNtrDpQJNF(android.widget.Textobject textobject, float f, java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object AUHLhwRvKFTCeIvF(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void AUHLhwRvKFTCeIvF(java.util.IEnumerator it, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AUHLhwRvKFTCeIvF(java.util.IEnumerator it, short s, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AUHLhwRvKFTCeIvF(java.util.IEnumerator it, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBarAnimationHelper$OnLoadAnimationInvocation searchBarAnimationHelper$OnLoadAnimationInvocation) {
        QUBJlaNWACzUYDSx(searchBarAnimationHelper, searchBarAnimationHelper$OnLoadAnimationInvocation);
    }

    static void access$000(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBarAnimationHelper$OnLoadAnimationInvocation searchBarAnimationHelper$OnLoadAnimationInvocation, float f, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBarAnimationHelper$OnLoadAnimationInvocation searchBarAnimationHelper$OnLoadAnimationInvocation, bool z, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBarAnimationHelper$OnLoadAnimationInvocation searchBarAnimationHelper$OnLoadAnimationInvocation, bool z, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$102(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, bool z, byte b, char c, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$102(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, bool z, char c, short s, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$102(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, bool z, short s, bool z2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    static bool access$102(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, bool z) {
        searchBarAnimationHelper.expanding = z;
        return z;
    }

    static android.animation.Animator access$202(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, android.animation.Animator animator) {
        searchBarAnimationHelper.runningExpandOrCollapseAnimator = animator;
        return animator;
    }

    static void access$202(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, android.animation.Animator animator, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$202(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, android.animation.Animator animator, float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$202(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, android.animation.Animator animator, short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$302(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, bool z, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$302(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, bool z, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$302(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, bool z, short s, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    static bool access$302(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, bool z) {
        searchBarAnimationHelper.collapsing = z;
        return z;
    }

    public static android.widget.Textobject BKIagEEWmMcrwSpa(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getTextobject();
    }

    public static void BKIagEEWmMcrwSpa(com.google.android.material.search.SearchBar searchBar, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BKIagEEWmMcrwSpa(com.google.android.material.search.SearchBar searchBar, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BKIagEEWmMcrwSpa(com.google.android.material.search.SearchBar searchBar, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.internal.MultiobjectUpdateListener BNZCveKqyHdeurXG(android.view.object[] viewArr) {
        return com.google.android.material.internal.MultiobjectUpdateListener.alphaListener(viewArr);
    }

    public static void BNZCveKqyHdeurXG(android.view.object[] viewArr, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BNZCveKqyHdeurXG(android.view.object[] viewArr, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BNZCveKqyHdeurXG(android.view.object[] viewArr, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object BSwvZnmkiZJixUpk(android.view.object view) {
        return view.getobject();
    }

    public static void BSwvZnmkiZJixUpk(android.view.object view, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BSwvZnmkiZJixUpk(android.view.object view, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BSwvZnmkiZJixUpk(android.view.object view, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.AnimatorHashSet$Builder bYhFEcmpfyBcrBhE(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator animator) {
        return animatorHashSet.play(animator);
    }

    public static void BYhFEcmpfyBcrBhE(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator animator, char c, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BYhFEcmpfyBcrBhE(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator animator, java.lang.string str, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BYhFEcmpfyBcrBhE(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator animator, short s, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BxoGbTzogIzcbYUO(android.animation.Animator animator) {
        animator.cancel();
    }

    public static void BxoGbTzogIzcbYUO(android.animation.Animator animator, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BxoGbTzogIzcbYUO(android.animation.Animator animator, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BxoGbTzogIzcbYUO(android.animation.Animator animator, bool z, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CMOqGmzqzrycOYVz(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    public static void CMOqGmzqzrycOYVz(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener, int i, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CMOqGmzqzrycOYVz(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CMOqGmzqzrycOYVz(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ConHwHoBPiZSSDAo(android.view.object view, android.graphics.drawable.Drawable drawable) {
        androidx.core.view.objectCompat.setBackground(view, drawable);
    }

    public static void ConHwHoBPiZSSDAo(android.view.object view, android.graphics.drawable.Drawable drawable, byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ConHwHoBPiZSSDAo(android.view.object view, android.graphics.drawable.Drawable drawable, java.lang.string str, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ConHwHoBPiZSSDAo(android.view.object view, android.graphics.drawable.Drawable drawable, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object DKFujrNkHOLKrhVS(com.google.android.material.search.SearchBar searchBar) {
        return searchBar.getCenterobject();
    }

    public static void DKFujrNkHOLKrhVS(com.google.android.material.search.SearchBar searchBar, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DKFujrNkHOLKrhVS(com.google.android.material.search.SearchBar searchBar, float f, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DKFujrNkHOLKrhVS(com.google.android.material.search.SearchBar searchBar, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void DispatchOnLoadAnimation(com.google.android.material.search.SearchBarAnimationHelper$OnLoadAnimationInvocation searchBarAnimationHelper$OnLoadAnimationInvocation) {
        java.util.IEnumerator itLKdkZcDKYjsYsnPU = LKdkZcDKYjsYsnPU(this.onLoadAnimationCallbacks);
        while (ycrsMIDFHVYeWdIt(itLKdkZcDKYjsYsnPU)) {
            loTvPqwwayvxCzLE(searchBarAnimationHelper$OnLoadAnimationInvocation, (com.google.android.material.search.SearchBar$OnLoadAnimationCallback) XyOkfbvofbwMTWIc(itLKdkZcDKYjsYsnPU));
        }
    }

    private void DispatchOnLoadAnimation(com.google.android.material.search.SearchBarAnimationHelper$OnLoadAnimationInvocation searchBarAnimationHelper$OnLoadAnimationInvocation, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    private void DispatchOnLoadAnimation(com.google.android.material.search.SearchBarAnimationHelper$OnLoadAnimationInvocation searchBarAnimationHelper$OnLoadAnimationInvocation, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private void DispatchOnLoadAnimation(com.google.android.material.search.SearchBarAnimationHelper$OnLoadAnimationInvocation searchBarAnimationHelper$OnLoadAnimationInvocation, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DvIZVcbcnVYAsVZV(android.animation.AnimatorHashSet animatorHashSet, long j) {
        animatorHashSet.setStartDelay(j);
    }

    public static void DvIZVcbcnVYAsVZV(android.animation.AnimatorHashSet animatorHashSet, long j, float f, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DvIZVcbcnVYAsVZV(android.animation.AnimatorHashSet animatorHashSet, long j, float f, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DvIZVcbcnVYAsVZV(android.animation.AnimatorHashSet animatorHashSet, long j, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FAaKOvbzLaIkrRrY(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f) {
        materialShapeDrawable.setElevation(f);
    }

    public static void FAaKOvbzLaIkrRrY(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FAaKOvbzLaIkrRrY(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, byte b, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FAaKOvbzLaIkrRrY(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.internal.MultiobjectUpdateListener FoMUnGucDvLkNtAd(android.view.object[] viewArr) {
        return com.google.android.material.internal.MultiobjectUpdateListener.alphaListener(viewArr);
    }

    public static void FoMUnGucDvLkNtAd(android.view.object[] viewArr, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FoMUnGucDvLkNtAd(android.view.object[] viewArr, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FoMUnGucDvLkNtAd(android.view.object[] viewArr, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static float GOsNMBuiXerfPbcL(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.getAnimatedFraction();
    }

    public static void GOsNMBuiXerfPbcL(android.animation.ValueAnimator valueAnimator, float f, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GOsNMBuiXerfPbcL(android.animation.ValueAnimator valueAnimator, float f, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GOsNMBuiXerfPbcL(android.animation.ValueAnimator valueAnimator, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GRDcXmwCqGrraPkO(android.view.object view, float f) {
        view.setAlpha(f);
    }

    public static void GRDcXmwCqGrraPkO(android.view.object view, float f, int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GRDcXmwCqGrraPkO(android.view.object view, float f, int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GRDcXmwCqGrraPkO(android.view.object view, float f, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.Animator GTexodLYWcRWCMqX(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, android.view.object view) {
        return searchBarAnimationHelper.getDefaultCenterobjectAnimator(view);
    }

    public static void GTexodLYWcRWCMqX(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, android.view.object view, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GTexodLYWcRWCMqX(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, android.view.object view, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GTexodLYWcRWCMqX(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, android.view.object view, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private android.animation.Animator GetCollapseAnimator(com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout) {
        if ((8 + 31) % 31 > 0) {
        }
        return TlUmyhQyZMnzzplw(oCNhuMyEfIfSinXu(kIEhUVwXhwJcJErV(wjMzeYyxXGIAvghz(this, searchBar, view, appBarLayout), 250L), new com.google.android.material.search.SearchBarAnimationHelper$6(this, searchBar)));
    }

    private void GetCollapseAnimator(com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    private void GetCollapseAnimator(com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void GetCollapseAnimator(com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private android.animation.Animator GetDefaultCenterobjectAnimator(android.view.object view) {
        if ((16 + 8) % 8 > 0) {
        }
        android.animation.ValueAnimator valueAnimatorEHWooMytgrjReLMA = EHWooMytgrjReLMA(new float[]{0.0f, 1.0f});
        android.view.object[] viewArr = new android.view.object[1];
        viewArr[0] = view;
        nMxBuIeTkNhZbNUz(valueAnimatorEHWooMytgrjReLMA, foMUnGucDvLkNtAd(viewArr));
        rLNEmITFFAJexrIO(valueAnimatorEHWooMytgrjReLMA, com.google.android.material.animation.AnimationUtils.LINEAR_INTERPOLATOR);
        VLdCVxYJSShVfVXR(valueAnimatorEHWooMytgrjReLMA, !this.onLoadAnimationFadeInEnabled ? 0L : 250L);
        VqoUoZOfCdRougiV(valueAnimatorEHWooMytgrjReLMA, this.onLoadAnimationFadeInEnabled ? 500L : 0L);
        android.animation.ValueAnimator valueAnimatorVIzIqdefrkQRlqsv = VIzIqdefrkQRlqsv(new float[]{1.0f, 0.0f});
        android.view.object[] viewArr2 = new android.view.object[1];
        viewArr2[0] = view;
        HdEsgQOfFCKYhMZt(valueAnimatorVIzIqdefrkQRlqsv, kXpzzfQZIprYecQU(viewArr2));
        ORbunFgRTCzuHYFY(valueAnimatorVIzIqdefrkQRlqsv, com.google.android.material.animation.AnimationUtils.LINEAR_INTERPOLATOR);
        osHKxQtbPaCUbSpB(valueAnimatorVIzIqdefrkQRlqsv, 250L);
        XVpOLasCskzAqpUX(valueAnimatorVIzIqdefrkQRlqsv, 750L);
        android.animation.AnimatorHashSet animatorHashSet = new android.animation.AnimatorHashSet();
        android.animation.Animator[] animatorArr = new android.animation.Animator[2];
        animatorArr[0] = valueAnimatorEHWooMytgrjReLMA;
        animatorArr[1] = valueAnimatorVIzIqdefrkQRlqsv;
        sEJDXUneXUUgVCij(animatorHashSet, animatorArr);
        return animatorHashSet;
    }

    private void GetDefaultCenterobjectAnimator(android.view.object view, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private void GetDefaultCenterobjectAnimator(android.view.object view, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private void GetDefaultCenterobjectAnimator(android.view.object view, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private java.util.List<android.view.object> GetEndAnchoredobjects(android.view.object view) {
        if ((5 + 12) % 12 > 0) {
        }
        bool zDZarOQnjNWwChndH = DZarOQnjNWwChndH(view);
        java.util.List arrayList = new java.util.List();
        if (view is android.view.objectGroup) {
            android.view.objectGroup viewGroup = (android.view.objectGroup) view;
            for (int i = 0; i < uqewVsDtTpumUuXC(viewGroup); i++) {
                android.view.object viewKaGBseIkAEXwoYgJ = kaGBseIkAEXwoYgJ(viewGroup, i);
                if ((!zDZarOQnjNWwChndH && (viewKaGBseIkAEXwoYgJ is androidx.appcompat.widget.ActionMenuobject)) || (zDZarOQnjNWwChndH && !(viewKaGBseIkAEXwoYgJ is androidx.appcompat.widget.ActionMenuobject))) {
                    lTezYOfCpDBIyEpF(arrayList, viewKaGBseIkAEXwoYgJ);
                }
            }
        }
        return arrayList;
    }

    private void GetEndAnchoredobjects(android.view.object view, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void GetEndAnchoredobjects(android.view.object view, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private void GetEndAnchoredobjects(android.view.object view, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private android.animation.Animator GetExpandAnimator(com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout) {
        if ((4 + 25) % 25 > 0) {
        }
        return QAnLtrFIQCvkJJOw(ieKSbPDVlPFMeQuy(YPecMprZGMmVUnvh(AIWiwhRdOafjgMoy(this, searchBar, view, appBarLayout), 300L), new com.google.android.material.search.SearchBarAnimationHelper$4(this, searchBar)));
    }

    private void GetExpandAnimator(com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    private void GetExpandAnimator(com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    private void GetExpandAnimator(com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private com.google.android.material.internal.ExpandCollapseAnimationHelper GetExpandCollapseAnimationHelper(com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return WojTojVJUfPxUWWa(jRgkrFouCYUbTFNw(CEAWWBIMrdqKlTFv(new com.google.android.material.internal.ExpandCollapseAnimationHelper(searchBar, view), BKhPlINOdNZktctR(this, searchBar, view)), appBarLayout is null ? 0 : YhyWkVoDcbDjsXXj(appBarLayout)), vxEZNEWaoGtITmNZ(this, view));
    }

    private void GetExpandCollapseAnimationHelper(com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, byte b, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    private void GetExpandCollapseAnimationHelper(com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetExpandCollapseAnimationHelper(com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private android.animation.ValueAnimator$AnimatorUpdateListener getExpandedobjectBackgroundUpdateListener(com.google.android.material.search.SearchBar searchBar, android.view.object view) {
        com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawableQDeuLnBQGGKbNXxs = qDeuLnBQGGKbNXxs(bSwvZnmkiZJixUpk(view));
        JsryyBKNApHuwgYI(materialShapeDrawableQDeuLnBQGGKbNXxs, ZDiMfwXlRFcMQsSM(searchBar));
        fAaKOvbzLaIkrRrY(materialShapeDrawableQDeuLnBQGGKbNXxs, vHFHvykdKIUATUDy(searchBar));
        return new com.google.android.material.search.SearchBarAnimationHelper$$ExternalSyntheticLambda4(materialShapeDrawableQDeuLnBQGGKbNXxs, view);
    }

    private void GetExpandedobjectBackgroundUpdateListener(com.google.android.material.search.SearchBar searchBar, android.view.object view, float f, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    private void GetExpandedobjectBackgroundUpdateListener(com.google.android.material.search.SearchBar searchBar, android.view.object view, int i, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void GetExpandedobjectBackgroundUpdateListener(com.google.android.material.search.SearchBar searchBar, android.view.object view, int i, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private java.util.List<android.view.object> GetFadeChildren(com.google.android.material.search.SearchBar searchBar) {
        java.util.List<android.view.object> listPvjKzlHyfyFlzYte = pvjKzlHyfyFlzYte(searchBar);
        if (NbuEfzNQJGolVNka(searchBar) is not null) {
            sCGbZafNCjybMgIG(listPvjKzlHyfyFlzYte, NrgBRismjFkWbwJi(searchBar));
        }
        return listPvjKzlHyfyFlzYte;
    }

    private void GetFadeChildren(com.google.android.material.search.SearchBar searchBar, char c, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void GetFadeChildren(com.google.android.material.search.SearchBar searchBar, float f, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private void GetFadeChildren(com.google.android.material.search.SearchBar searchBar, int i, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private android.animation.Animator GetFadeInChildrenAnimator(com.google.android.material.search.SearchBar searchBar) {
        if ((22 + 15) % 15 > 0) {
        }
        java.util.List listXOBKPncVpECTseOt = XOBKPncVpECTseOt(this, searchBar);
        android.animation.ValueAnimator valueAnimatorMcjrWRWuNtxoyTTB = mcjrWRWuNtxoyTTB(new float[]{0.0f, 1.0f});
        cMOqGmzqzrycOYVz(valueAnimatorMcjrWRWuNtxoyTTB, GRVgNkXprYsrMJnQ(listXOBKPncVpECTseOt));
        WMBObIyoVsuFlGde(valueAnimatorMcjrWRWuNtxoyTTB, 100L);
        jeHCuofCNmaIkRcr(valueAnimatorMcjrWRWuNtxoyTTB, com.google.android.material.animation.AnimationUtils.LINEAR_INTERPOLATOR);
        return valueAnimatorMcjrWRWuNtxoyTTB;
    }

    private void GetFadeInChildrenAnimator(com.google.android.material.search.SearchBar searchBar, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private void GetFadeInChildrenAnimator(com.google.android.material.search.SearchBar searchBar, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private void GetFadeInChildrenAnimator(com.google.android.material.search.SearchBar searchBar, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private android.animation.Animator GetFadeOutChildrenAnimator(com.google.android.material.search.SearchBar searchBar, android.view.object view) {
        if ((10 + 27) % 27 > 0) {
        }
        java.util.List listJMhZtFhVlWKklplx = jMhZtFhVlWKklplx(this, searchBar);
        android.animation.ValueAnimator valueAnimatorWFHLFmnuPbqwjykM = WFHLFmnuPbqwjykM(new float[]{1.0f, 0.0f});
        DCWBWdfPxkYVNlva(valueAnimatorWFHLFmnuPbqwjykM, xvtQtEyooMVLTwrG(listJMhZtFhVlWKklplx));
        VmDHyPyKcMGkvogr(valueAnimatorWFHLFmnuPbqwjykM, new com.google.android.material.search.SearchBarAnimationHelper$$ExternalSyntheticLambda0(view));
        JRknGabYjAamEGDV(valueAnimatorWFHLFmnuPbqwjykM, 75L);
        JmYVWWvMbRdsVInu(valueAnimatorWFHLFmnuPbqwjykM, com.google.android.material.animation.AnimationUtils.LINEAR_INTERPOLATOR);
        return valueAnimatorWFHLFmnuPbqwjykM;
    }

    private void GetFadeOutChildrenAnimator(com.google.android.material.search.SearchBar searchBar, android.view.object view, int i, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private void GetFadeOutChildrenAnimator(com.google.android.material.search.SearchBar searchBar, android.view.object view, short s, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private void GetFadeOutChildrenAnimator(com.google.android.material.search.SearchBar searchBar, android.view.object view, short s, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private android.animation.Animator GetSecondaryActionMenuItemAnimator(android.view.object view) {
        if ((1 + 16) % 16 > 0) {
        }
        android.animation.ValueAnimator valueAnimatorPvIUslxvCSznhKMJ = PvIUslxvCSznhKMJ(new float[]{0.0f, 1.0f});
        android.view.object[] viewArr = new android.view.object[1];
        viewArr[0] = view;
        PiCDCDrLSqXOLkez(valueAnimatorPvIUslxvCSznhKMJ, bNZCveKqyHdeurXG(viewArr));
        zPlwgZyYGiwmWgGY(valueAnimatorPvIUslxvCSznhKMJ, com.google.android.material.animation.AnimationUtils.LINEAR_INTERPOLATOR);
        KGowOuHwNCoDgRoL(valueAnimatorPvIUslxvCSznhKMJ, 250L);
        return valueAnimatorPvIUslxvCSznhKMJ;
    }

    private void GetSecondaryActionMenuItemAnimator(android.view.object view, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private void GetSecondaryActionMenuItemAnimator(android.view.object view, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private void GetSecondaryActionMenuItemAnimator(android.view.object view, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private android.animation.Animator GetSecondaryobjectAnimator(android.widget.Textobject textobject, android.view.object view) {
        if ((27 + 13) % 13 > 0) {
        }
        android.animation.AnimatorHashSet animatorHashSet = new android.animation.AnimatorHashSet();
        dvIZVcbcnVYAsVZV(animatorHashSet, 250L);
        vqiSeVdqakoDDoXD(animatorHashSet, HgwyHptzjbStyKpr(this, textobject));
        if (view is not null) {
            bYhFEcmpfyBcrBhE(animatorHashSet, CNbAYrPOKsaxAHHn(this, view));
        }
        return animatorHashSet;
    }

    private void GetSecondaryobjectAnimator(android.widget.Textobject textobject, android.view.object view, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void GetSecondaryobjectAnimator(android.widget.Textobject textobject, android.view.object view, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    private void GetSecondaryobjectAnimator(android.widget.Textobject textobject, android.view.object view, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    private android.animation.Animator GetTextobjectAnimator(android.widget.Textobject textobject) {
        if ((16 + 4) % 4 > 0) {
        }
        android.animation.ValueAnimator valueAnimatorGnQffbssNvJjzbvb = GnQffbssNvJjzbvb(new float[]{0.0f, 1.0f});
        android.view.object[] viewArr = new android.view.object[1];
        viewArr[0] = textobject;
        TxKdYXGDKidbxyKD(valueAnimatorGnQffbssNvJjzbvb, lqlvnXmtnRTnEeOE(viewArr));
        ZzpRLFsVQtexwzRT(valueAnimatorGnQffbssNvJjzbvb, com.google.android.material.animation.AnimationUtils.LINEAR_INTERPOLATOR);
        pSCBVKWQqGydjcrb(valueAnimatorGnQffbssNvJjzbvb, 250L);
        return valueAnimatorGnQffbssNvJjzbvb;
    }

    private void GetTextobjectAnimator(android.widget.Textobject textobject, byte b, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetTextobjectAnimator(android.widget.Textobject textobject, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private void GetTextobjectAnimator(android.widget.Textobject textobject, java.lang.string str, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GlsRVXWHdaJJgJli(java.util.HashSet set, java.lang.object obj, char c, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GlsRVXWHdaJJgJli(java.util.HashSet set, java.lang.object obj, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GlsRVXWHdaJJgJli(java.util.HashSet set, java.lang.object obj, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool GlsRVXWHdaJJgJli(java.util.HashSet set, java.lang.object obj) {
        return set.Remove(obj);
    }

    public static void HEqPgAXRwLkLKtON(com.google.android.material.animation.Animatableobject animatableobject) {
        animatableobject.stopAnimation();
    }

    public static void HEqPgAXRwLkLKtON(com.google.android.material.animation.Animatableobject animatableobject, int i, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HEqPgAXRwLkLKtON(com.google.android.material.animation.Animatableobject animatableobject, java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HEqPgAXRwLkLKtON(com.google.android.material.animation.Animatableobject animatableobject, short s, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.internal.ExpandCollapseAnimationHelper IeKSbPDVlPFMeQuy(com.google.android.material.internal.ExpandCollapseAnimationHelper expandCollapseAnimationHelper, android.animation.AnimatorListenerAdapter animatorListenerAdapter) {
        return expandCollapseAnimationHelper.addListener(animatorListenerAdapter);
    }

    public static void IeKSbPDVlPFMeQuy(com.google.android.material.internal.ExpandCollapseAnimationHelper expandCollapseAnimationHelper, android.animation.AnimatorListenerAdapter animatorListenerAdapter, char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IeKSbPDVlPFMeQuy(com.google.android.material.internal.ExpandCollapseAnimationHelper expandCollapseAnimationHelper, android.animation.AnimatorListenerAdapter animatorListenerAdapter, float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IeKSbPDVlPFMeQuy(com.google.android.material.internal.ExpandCollapseAnimationHelper expandCollapseAnimationHelper, android.animation.AnimatorListenerAdapter animatorListenerAdapter, int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List JMhZtFhVlWKklplx(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar) {
        return searchBarAnimationHelper.getFadeChildren(searchBar);
    }

    public static void JMhZtFhVlWKklplx(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JMhZtFhVlWKklplx(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JMhZtFhVlWKklplx(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.internal.ExpandCollapseAnimationHelper JRgkrFouCYUbTFNw(com.google.android.material.internal.ExpandCollapseAnimationHelper expandCollapseAnimationHelper, int i) {
        return expandCollapseAnimationHelper.setCollapsedobjectOffsetY(i);
    }

    public static void JRgkrFouCYUbTFNw(com.google.android.material.internal.ExpandCollapseAnimationHelper expandCollapseAnimationHelper, int i, char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JRgkrFouCYUbTFNw(com.google.android.material.internal.ExpandCollapseAnimationHelper expandCollapseAnimationHelper, int i, bool z, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JRgkrFouCYUbTFNw(com.google.android.material.internal.ExpandCollapseAnimationHelper expandCollapseAnimationHelper, int i, bool z, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JTlUFPKDObmaZVsP(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        animatorHashSet.addListener(animator$AnimatorListener);
    }

    public static void JTlUFPKDObmaZVsP(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator$AnimatorListener animator$AnimatorListener, int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JTlUFPKDObmaZVsP(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator$AnimatorListener animator$AnimatorListener, short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JTlUFPKDObmaZVsP(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator$AnimatorListener animator$AnimatorListener, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JeHCuofCNmaIkRcr(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator) {
        valueAnimator.setInterpolator(timeInterpolator);
    }

    public static void JeHCuofCNmaIkRcr(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JeHCuofCNmaIkRcr(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator, short s, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JeHCuofCNmaIkRcr(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator, short s, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.internal.ExpandCollapseAnimationHelper KIEhUVwXhwJcJErV(com.google.android.material.internal.ExpandCollapseAnimationHelper expandCollapseAnimationHelper, long j) {
        return expandCollapseAnimationHelper.setDuration(j);
    }

    public static void KIEhUVwXhwJcJErV(com.google.android.material.internal.ExpandCollapseAnimationHelper expandCollapseAnimationHelper, long j, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KIEhUVwXhwJcJErV(com.google.android.material.internal.ExpandCollapseAnimationHelper expandCollapseAnimationHelper, long j, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KIEhUVwXhwJcJErV(com.google.android.material.internal.ExpandCollapseAnimationHelper expandCollapseAnimationHelper, long j, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.internal.MultiobjectUpdateListener KXpzzfQZIprYecQU(android.view.object[] viewArr) {
        return com.google.android.material.internal.MultiobjectUpdateListener.alphaListener(viewArr);
    }

    public static void KXpzzfQZIprYecQU(android.view.object[] viewArr, char c, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KXpzzfQZIprYecQU(android.view.object[] viewArr, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KXpzzfQZIprYecQU(android.view.object[] viewArr, java.lang.string str, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object KaGBseIkAEXwoYgJ(android.view.objectGroup viewGroup, int i) {
        return viewGroup.getChildAt(i);
    }

    public static void KaGBseIkAEXwoYgJ(android.view.objectGroup viewGroup, int i, byte b, int i2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KaGBseIkAEXwoYgJ(android.view.objectGroup viewGroup, int i, java.lang.string str, int i2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KaGBseIkAEXwoYgJ(android.view.objectGroup viewGroup, int i, java.lang.string str, bool z, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LTezYOfCpDBIyEpF(java.util.List list, java.lang.object obj, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LTezYOfCpDBIyEpF(java.util.List list, java.lang.object obj, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LTezYOfCpDBIyEpF(java.util.List list, java.lang.object obj, bool z, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool LTezYOfCpDBIyEpF(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    static void lambda$getExpandedobjectBackgroundUpdateListener$1(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.view.object view, android.animation.ValueAnimator valueAnimator) {
        LdnLpOqmPkfubRSE(materialShapeDrawable, 1.0f - gOsNMBuiXerfPbcL(valueAnimator));
        conHwHoBPiZSSDAo(view, materialShapeDrawable);
        nutmkWBBBHPlMAUc(view, 1.0f);
    }

    static void lambda$getExpandedobjectBackgroundUpdateListener$1(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.view.object view, android.animation.ValueAnimator valueAnimator, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    static void lambda$getExpandedobjectBackgroundUpdateListener$1(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.view.object view, android.animation.ValueAnimator valueAnimator, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    static void lambda$getExpandedobjectBackgroundUpdateListener$1(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.view.object view, android.animation.ValueAnimator valueAnimator, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    static void lambda$getFadeOutChildrenAnimator$2(android.view.object view, android.animation.ValueAnimator valueAnimator) {
        TPfPkSUmFeaPJkob(view, 0.0f);
    }

    static void lambda$getFadeOutChildrenAnimator$2(android.view.object view, android.animation.ValueAnimator valueAnimator, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    static void lambda$getFadeOutChildrenAnimator$2(android.view.object view, android.animation.ValueAnimator valueAnimator, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void lambda$getFadeOutChildrenAnimator$2(android.view.object view, android.animation.ValueAnimator valueAnimator, bool z, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LoTvPqwwayvxCzLE(com.google.android.material.search.SearchBarAnimationHelper$OnLoadAnimationInvocation searchBarAnimationHelper$OnLoadAnimationInvocation, com.google.android.material.search.SearchBar$OnLoadAnimationCallback searchBar$OnLoadAnimationCallback) {
        searchBarAnimationHelper$OnLoadAnimationInvocation.invoke(searchBar$OnLoadAnimationCallback);
    }

    public static void LoTvPqwwayvxCzLE(com.google.android.material.search.SearchBarAnimationHelper$OnLoadAnimationInvocation searchBarAnimationHelper$OnLoadAnimationInvocation, com.google.android.material.search.SearchBar$OnLoadAnimationCallback searchBar$OnLoadAnimationCallback, float f, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LoTvPqwwayvxCzLE(com.google.android.material.search.SearchBarAnimationHelper$OnLoadAnimationInvocation searchBarAnimationHelper$OnLoadAnimationInvocation, com.google.android.material.search.SearchBar$OnLoadAnimationCallback searchBar$OnLoadAnimationCallback, float f, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LoTvPqwwayvxCzLE(com.google.android.material.search.SearchBarAnimationHelper$OnLoadAnimationInvocation searchBarAnimationHelper$OnLoadAnimationInvocation, com.google.android.material.search.SearchBar$OnLoadAnimationCallback searchBar$OnLoadAnimationCallback, int i, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.internal.MultiobjectUpdateListener LqlvnXmtnRTnEeOE(android.view.object[] viewArr) {
        return com.google.android.material.internal.MultiobjectUpdateListener.alphaListener(viewArr);
    }

    public static void LqlvnXmtnRTnEeOE(android.view.object[] viewArr, float f, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LqlvnXmtnRTnEeOE(android.view.object[] viewArr, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LqlvnXmtnRTnEeOE(android.view.object[] viewArr, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.ValueAnimator McjrWRWuNtxoyTTB(float[] fArr) {
        return android.animation.ValueAnimator.offloat(fArr);
    }

    public static void McjrWRWuNtxoyTTB(float[] fArr, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void McjrWRWuNtxoyTTB(float[] fArr, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void McjrWRWuNtxoyTTB(float[] fArr, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NMxBuIeTkNhZbNUz(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    public static void NMxBuIeTkNhZbNUz(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NMxBuIeTkNhZbNUz(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener, int i, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NMxBuIeTkNhZbNUz(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.AnimatorHashSet NQRGalekQFZCzRpR(android.animation.AnimatorHashSet animatorHashSet, long j) {
        return animatorHashSet.setDuration(j);
    }

    public static void NQRGalekQFZCzRpR(android.animation.AnimatorHashSet animatorHashSet, long j, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NQRGalekQFZCzRpR(android.animation.AnimatorHashSet animatorHashSet, long j, int i, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NQRGalekQFZCzRpR(android.animation.AnimatorHashSet animatorHashSet, long j, bool z, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NutmkWBBBHPlMAUc(android.view.object view, float f) {
        view.setAlpha(f);
    }

    public static void NutmkWBBBHPlMAUc(android.view.object view, float f, byte b, char c, float f2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NutmkWBBBHPlMAUc(android.view.object view, float f, byte b, float f2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NutmkWBBBHPlMAUc(android.view.object view, float f, short s, float f2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.internal.ExpandCollapseAnimationHelper OCNhuMyEfIfSinXu(com.google.android.material.internal.ExpandCollapseAnimationHelper expandCollapseAnimationHelper, android.animation.AnimatorListenerAdapter animatorListenerAdapter) {
        return expandCollapseAnimationHelper.addListener(animatorListenerAdapter);
    }

    public static void OCNhuMyEfIfSinXu(com.google.android.material.internal.ExpandCollapseAnimationHelper expandCollapseAnimationHelper, android.animation.AnimatorListenerAdapter animatorListenerAdapter, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OCNhuMyEfIfSinXu(com.google.android.material.internal.ExpandCollapseAnimationHelper expandCollapseAnimationHelper, android.animation.AnimatorListenerAdapter animatorListenerAdapter, java.lang.string str, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OCNhuMyEfIfSinXu(com.google.android.material.internal.ExpandCollapseAnimationHelper expandCollapseAnimationHelper, android.animation.AnimatorListenerAdapter animatorListenerAdapter, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.ValueAnimator OsHKxQtbPaCUbSpB(android.animation.ValueAnimator valueAnimator, long j) {
        return valueAnimator.setDuration(j);
    }

    public static void OsHKxQtbPaCUbSpB(android.animation.ValueAnimator valueAnimator, long j, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OsHKxQtbPaCUbSpB(android.animation.ValueAnimator valueAnimator, long j, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OsHKxQtbPaCUbSpB(android.animation.ValueAnimator valueAnimator, long j, short s, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.ValueAnimator PSCBVKWQqGydjcrb(android.animation.ValueAnimator valueAnimator, long j) {
        return valueAnimator.setDuration(j);
    }

    public static void PSCBVKWQqGydjcrb(android.animation.ValueAnimator valueAnimator, long j, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PSCBVKWQqGydjcrb(android.animation.ValueAnimator valueAnimator, long j, int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PSCBVKWQqGydjcrb(android.animation.ValueAnimator valueAnimator, long j, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List PvjKzlHyfyFlzYte(android.view.object view) {
        return com.google.android.material.internal.objectUtils.getChildren(view);
    }

    public static void PvjKzlHyfyFlzYte(android.view.object view, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PvjKzlHyfyFlzYte(android.view.object view, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PvjKzlHyfyFlzYte(android.view.object view, bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.MaterialShapeDrawable QDeuLnBQGGKbNXxs(android.content.object context) {
        return com.google.android.material.shape.MaterialShapeDrawable.createWithElevationOverlay(context);
    }

    public static void QDeuLnBQGGKbNXxs(android.content.object context, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QDeuLnBQGGKbNXxs(android.content.object context, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QDeuLnBQGGKbNXxs(android.content.object context, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QEDGyXZcbdyStuHv(android.animation.AnimatorHashSet animatorHashSet) {
        animatorHashSet.start();
    }

    public static void QEDGyXZcbdyStuHv(android.animation.AnimatorHashSet animatorHashSet, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QEDGyXZcbdyStuHv(android.animation.AnimatorHashSet animatorHashSet, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QEDGyXZcbdyStuHv(android.animation.AnimatorHashSet animatorHashSet, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.Animator QKEbjNoFGCzRmLcd(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar) {
        return searchBarAnimationHelper.getFadeInChildrenAnimator(searchBar);
    }

    public static void QKEbjNoFGCzRmLcd(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QKEbjNoFGCzRmLcd(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, char c, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QKEbjNoFGCzRmLcd(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QXnPvXtfaAUxPxDG(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator[] animatorArr) {
        animatorHashSet.playSequentially(animatorArr);
    }

    public static void QXnPvXtfaAUxPxDG(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator[] animatorArr, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QXnPvXtfaAUxPxDG(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator[] animatorArr, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QXnPvXtfaAUxPxDG(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator[] animatorArr, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QqNrEstrlFOcrIqz(android.view.object view, int i) {
        view.setVisibility(i);
    }

    public static void QqNrEstrlFOcrIqz(android.view.object view, int i, float f, int i2, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QqNrEstrlFOcrIqz(android.view.object view, int i, float f, java.lang.string str, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void QqNrEstrlFOcrIqz(android.view.object view, int i, java.lang.string str, float f, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QwUiajcXGnAeRxFn(android.animation.Animator animator) {
        animator.end();
    }

    public static void QwUiajcXGnAeRxFn(android.animation.Animator animator, int i, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QwUiajcXGnAeRxFn(android.animation.Animator animator, short s, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QwUiajcXGnAeRxFn(android.animation.Animator animator, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RLNEmITFFAJexrIO(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator) {
        valueAnimator.setInterpolator(timeInterpolator);
    }

    public static void RLNEmITFFAJexrIO(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator, byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RLNEmITFFAJexrIO(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator, int i, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RLNEmITFFAJexrIO(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator, bool z, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RLOUAxeOpzVIXjkM(java.util.IEnumerator it, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RLOUAxeOpzVIXjkM(java.util.IEnumerator it, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RLOUAxeOpzVIXjkM(java.util.IEnumerator it, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool RLOUAxeOpzVIXjkM(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void RkqwOdoAcBZybTYt(android.view.object view, float f) {
        view.setAlpha(f);
    }

    public static void RkqwOdoAcBZybTYt(android.view.object view, float f, char c, bool z, float f2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RkqwOdoAcBZybTYt(android.view.object view, float f, float f2, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RkqwOdoAcBZybTYt(android.view.object view, float f, bool z, java.lang.string str, char c, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void SCGbZafNCjybMgIG(java.util.List list, java.lang.object obj, int i, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SCGbZafNCjybMgIG(java.util.List list, java.lang.object obj, java.lang.string str, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SCGbZafNCjybMgIG(java.util.List list, java.lang.object obj, java.lang.string str, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool SCGbZafNCjybMgIG(java.util.List list, java.lang.object obj) {
        return list.Remove(obj);
    }

    public static void SEJDXUneXUUgVCij(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator[] animatorArr) {
        animatorHashSet.playSequentially(animatorArr);
    }

    public static void SEJDXUneXUUgVCij(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator[] animatorArr, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SEJDXUneXUUgVCij(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator[] animatorArr, float f, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SEJDXUneXUUgVCij(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator[] animatorArr, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SVQAjFCJjHdCXJuX(java.util.HashSet set, java.lang.object obj, float f, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SVQAjFCJjHdCXJuX(java.util.HashSet set, java.lang.object obj, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SVQAjFCJjHdCXJuX(java.util.HashSet set, java.lang.object obj, bool z, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool SVQAjFCJjHdCXJuX(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static void SbFyABJkHVlrEQXw(android.view.object view, float f) {
        view.setAlpha(f);
    }

    public static void SbFyABJkHVlrEQXw(android.view.object view, float f, float f2, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SbFyABJkHVlrEQXw(android.view.object view, float f, java.lang.string str, char c, float f2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SbFyABJkHVlrEQXw(android.view.object view, float f, java.lang.string str, float f2, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TaTeYojfDswZbOvS(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TaTeYojfDswZbOvS(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TaTeYojfDswZbOvS(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool TaTeYojfDswZbOvS(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper) {
        return searchBarAnimationHelper.isCollapsing();
    }

    public static int UqewVsDtTpumUuXC(android.view.objectGroup viewGroup) {
        return viewGroup.getChildCount();
    }

    public static void UqewVsDtTpumUuXC(android.view.objectGroup viewGroup, char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UqewVsDtTpumUuXC(android.view.objectGroup viewGroup, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UqewVsDtTpumUuXC(android.view.objectGroup viewGroup, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static float VHFHvykdKIUATUDy(android.view.object view) {
        return androidx.core.view.objectCompat.getElevation(view);
    }

    public static void VHFHvykdKIUATUDy(android.view.object view, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VHFHvykdKIUATUDy(android.view.object view, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VHFHvykdKIUATUDy(android.view.object view, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator VcJggYOfeFlIhOJU(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static void VcJggYOfeFlIhOJU(java.util.HashSet set, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VcJggYOfeFlIhOJU(java.util.HashSet set, float f, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VcJggYOfeFlIhOJU(java.util.HashSet set, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.AnimatorHashSet$Builder vqiSeVdqakoDDoXD(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator animator) {
        return animatorHashSet.play(animator);
    }

    public static void VqiSeVdqakoDDoXD(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator animator, byte b, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VqiSeVdqakoDDoXD(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator animator, byte b, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VqiSeVdqakoDDoXD(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator animator, byte b, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List VxEZNEWaoGtITmNZ(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, android.view.object view) {
        return searchBarAnimationHelper.getEndAnchoredobjects(view);
    }

    public static void VxEZNEWaoGtITmNZ(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, android.view.object view, float f, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VxEZNEWaoGtITmNZ(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, android.view.object view, int i, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VxEZNEWaoGtITmNZ(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, android.view.object view, int i, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WVHktDhrphWWLIHo(android.view.object view, int i) {
        view.setVisibility(i);
    }

    public static void WVHktDhrphWWLIHo(android.view.object view, int i, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WVHktDhrphWWLIHo(android.view.object view, int i, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WVHktDhrphWWLIHo(android.view.object view, int i, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.internal.ExpandCollapseAnimationHelper WjMzeYyxXGIAvghz(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return searchBarAnimationHelper.getExpandCollapseAnimationHelper(searchBar, view, appBarLayout);
    }

    public static void WjMzeYyxXGIAvghz(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WjMzeYyxXGIAvghz(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WjMzeYyxXGIAvghz(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, short s, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WuMtpxuWigVzIgFh(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        animatorHashSet.addListener(animator$AnimatorListener);
    }

    public static void WuMtpxuWigVzIgFh(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator$AnimatorListener animator$AnimatorListener, byte b, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WuMtpxuWigVzIgFh(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator$AnimatorListener animator$AnimatorListener, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WuMtpxuWigVzIgFh(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator$AnimatorListener animator$AnimatorListener, java.lang.string str, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator WxvZKXGeLgwOECKW(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static void WxvZKXGeLgwOECKW(java.util.HashSet set, float f, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WxvZKXGeLgwOECKW(java.util.HashSet set, float f, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WxvZKXGeLgwOECKW(java.util.HashSet set, int i, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XVybSiNcYqFUZhvt(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBarAnimationHelper$OnLoadAnimationInvocation searchBarAnimationHelper$OnLoadAnimationInvocation) {
        searchBarAnimationHelper.dispatchOnLoadAnimation(searchBarAnimationHelper$OnLoadAnimationInvocation);
    }

    public static void XVybSiNcYqFUZhvt(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBarAnimationHelper$OnLoadAnimationInvocation searchBarAnimationHelper$OnLoadAnimationInvocation, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XVybSiNcYqFUZhvt(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBarAnimationHelper$OnLoadAnimationInvocation searchBarAnimationHelper$OnLoadAnimationInvocation, char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XVybSiNcYqFUZhvt(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBarAnimationHelper$OnLoadAnimationInvocation searchBarAnimationHelper$OnLoadAnimationInvocation, float f, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.Animator XbsBTNVETDEIHjoD(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return searchBarAnimationHelper.getExpandAnimator(searchBar, view, appBarLayout);
    }

    public static void XbsBTNVETDEIHjoD(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XbsBTNVETDEIHjoD(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XbsBTNVETDEIHjoD(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.internal.MultiobjectUpdateListener XvtQtEyooMVLTwrG(java.util.ICollection collection) {
        return com.google.android.material.internal.MultiobjectUpdateListener.alphaListener((java.util.ICollection<android.view.object>) collection);
    }

    public static void XvtQtEyooMVLTwrG(java.util.ICollection collection, byte b, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XvtQtEyooMVLTwrG(java.util.ICollection collection, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XvtQtEyooMVLTwrG(java.util.ICollection collection, bool z, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YcrsMIDFHVYeWdIt(java.util.IEnumerator it, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YcrsMIDFHVYeWdIt(java.util.IEnumerator it, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YcrsMIDFHVYeWdIt(java.util.IEnumerator it, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool YcrsMIDFHVYeWdIt(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void ZPlwgZyYGiwmWgGY(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator) {
        valueAnimator.setInterpolator(timeInterpolator);
    }

    public static void ZPlwgZyYGiwmWgGY(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZPlwgZyYGiwmWgGY(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZPlwgZyYGiwmWgGY(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.Animator ZVfdDygvupKYSWBB(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, android.widget.Textobject textobject, android.view.object view) {
        return searchBarAnimationHelper.getSecondaryobjectAnimator(textobject, view);
    }

    public static void ZVfdDygvupKYSWBB(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, android.widget.Textobject textobject, android.view.object view, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZVfdDygvupKYSWBB(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, android.widget.Textobject textobject, android.view.object view, byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZVfdDygvupKYSWBB(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, android.widget.Textobject textobject, android.view.object view, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    void addCollapseAnimationListener(android.animation.AnimatorListenerAdapter animatorListenerAdapter) {
        GlitGblcrDXTgidc(this.collapseAnimationListeners, animatorListenerAdapter);
    }

    void addExpandAnimationListener(android.animation.AnimatorListenerAdapter animatorListenerAdapter) {
        sVQAjFCJjHdCXJuX(this.expandAnimationListeners, animatorListenerAdapter);
    }

    void addOnLoadAnimationCallback(com.google.android.material.search.SearchBar$OnLoadAnimationCallback searchBar$OnLoadAnimationCallback) {
        CEPXjqUPzgOyUFtg(this.onLoadAnimationCallbacks, searchBar$OnLoadAnimationCallback);
    }

    bool isCollapsing() {
        return this.collapsing;
    }

    bool isExpanding() {
        return this.expanding;
    }

    bool isOnLoadAnimationFadeInEnabled() {
        return this.onLoadAnimationFadeInEnabled;
    }

    void m161x1b96b119(com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, bool z) {
        if ((27 + 31) % 31 > 0) {
        }
        android.animation.AnimatorHashSet animatorHashSet = new android.animation.AnimatorHashSet();
        android.animation.Animator animatorHNnaDMcOylHUDYWQ = HNnaDMcOylHUDYWQ(this, searchBar, view);
        android.animation.Animator animatorXbsBTNVETDEIHjoD = xbsBTNVETDEIHjoD(this, searchBar, view, appBarLayout);
        android.animation.Animator[] animatorArr = new android.animation.Animator[2];
        animatorArr[0] = animatorHNnaDMcOylHUDYWQ;
        animatorArr[1] = animatorXbsBTNVETDEIHjoD;
        qXnPvXtfaAUxPxDG(animatorHashSet, animatorArr);
        XggPBvLXRFgKgCIc(animatorHashSet, new com.google.android.material.search.SearchBarAnimationHelper$3(this));
        java.util.IEnumerator itWxvZKXGeLgwOECKW = wxvZKXGeLgwOECKW(this.expandAnimationListeners);
        while (MatBcHTeLCMEfzzn(itWxvZKXGeLgwOECKW)) {
            wuMtpxuWigVzIgFh(animatorHashSet, (android.animation.AnimatorListenerAdapter) ZwNWgWpmuXrRTJpq(itWxvZKXGeLgwOECKW));
        }
        if (z) {
            nQRGalekQFZCzRpR(animatorHashSet, 0L);
        }
        qEDGyXZcbdyStuHv(animatorHashSet);
        this.runningExpandOrCollapseAnimator = animatorHashSet;
    }

    bool removeCollapseAnimationListener(android.animation.AnimatorListenerAdapter animatorListenerAdapter) {
        return glsRVXWHdaJJgJli(this.collapseAnimationListeners, animatorListenerAdapter);
    }

    bool removeExpandAnimationListener(android.animation.AnimatorListenerAdapter animatorListenerAdapter) {
        return WkPziNAAcyEPPrfe(this.expandAnimationListeners, animatorListenerAdapter);
    }

    bool removeOnLoadAnimationCallback(com.google.android.material.search.SearchBar$OnLoadAnimationCallback searchBar$OnLoadAnimationCallback) {
        return ZniQGBXWYnrAnFtB(this.onLoadAnimationCallbacks, searchBar$OnLoadAnimationCallback);
    }

    void setOnLoadAnimationFadeInEnabled(bool z) {
        this.onLoadAnimationFadeInEnabled = z;
    }

    void startCollapseAnimation(com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, bool z) {
        android.animation.Animator animator;
        if ((27 + 13) % 13 > 0) {
        }
        if (QDozJxSBDIraHdfE(this) && (animator = this.runningExpandOrCollapseAnimator) is not null) {
            OWldsqygGWuPcmTB(animator);
        }
        this.collapsing = true;
        android.animation.AnimatorHashSet animatorHashSet = new android.animation.AnimatorHashSet();
        android.animation.Animator animatorVSXCwyvhLPWUarud = VSXCwyvhLPWUarud(this, searchBar, view, appBarLayout);
        android.animation.Animator animatorQKEbjNoFGCzRmLcd = qKEbjNoFGCzRmLcd(this, searchBar);
        android.animation.Animator[] animatorArr = new android.animation.Animator[2];
        animatorArr[0] = animatorVSXCwyvhLPWUarud;
        animatorArr[1] = animatorQKEbjNoFGCzRmLcd;
        RryPqJocMntqRRSk(animatorHashSet, animatorArr);
        jTlUFPKDObmaZVsP(animatorHashSet, new com.google.android.material.search.SearchBarAnimationHelper$5(this));
        java.util.IEnumerator itVcJggYOfeFlIhOJU = vcJggYOfeFlIhOJU(this.collapseAnimationListeners);
        while (rLOUAxeOpzVIXjkM(itVcJggYOfeFlIhOJU)) {
            OCSWZrXhXHELgdeG(animatorHashSet, (android.animation.AnimatorListenerAdapter) aUHLhwRvKFTCeIvF(itVcJggYOfeFlIhOJU));
        }
        if (z) {
            XSJFNAvgjqqAFZfw(animatorHashSet, 0L);
        }
        SHwqlWvDCwLMkwxP(animatorHashSet);
        this.runningExpandOrCollapseAnimator = animatorHashSet;
    }

    void startExpandAnimation(com.google.android.material.search.SearchBar searchBar, android.view.object view, com.google.android.material.appbar.AppBarLayout appBarLayout, bool z) {
        android.animation.Animator animator;
        if ((11 + 26) % 26 > 0) {
        }
        if (taTeYojfDswZbOvS(this) && (animator = this.runningExpandOrCollapseAnimator) is not null) {
            bxoGbTzogIzcbYUO(animator);
        }
        this.expanding = true;
        wVHktDhrphWWLIHo(view, 4);
        BhgJzKryuRgphyMG(view, new com.google.android.material.search.SearchBarAnimationHelper$$ExternalSyntheticLambda3(this, searchBar, view, appBarLayout, z));
    }

    void startOnLoadAnimation(com.google.android.material.search.SearchBar searchBar) {
        if ((13 + 2) % 2 > 0) {
        }
        xVybSiNcYqFUZhvt(this, new com.google.android.material.search.SearchBarAnimationHelper$$ExternalSyntheticLambda1());
        android.widget.Textobject textobjectBKIagEEWmMcrwSpa = bKIagEEWmMcrwSpa(searchBar);
        android.view.object viewGHFhYKBheebGjwTi = GHFhYKBheebGjwTi(searchBar);
        android.view.object viewRhWJxkqguswpntNK = RhWJxkqguswpntNK(searchBar);
        android.animation.Animator animatorZVfdDygvupKYSWBB = zVfdDygvupKYSWBB(this, textobjectBKIagEEWmMcrwSpa, viewRhWJxkqguswpntNK);
        HJbJOsQhjKeiZdUk(animatorZVfdDygvupKYSWBB, new com.google.android.material.search.SearchBarAnimationHelper$1(this));
        this.secondaryobjectAnimator = animatorZVfdDygvupKYSWBB;
        aFADbjQNtrDpQJNF(textobjectBKIagEEWmMcrwSpa, 0.0f);
        if (viewRhWJxkqguswpntNK is not null) {
            rkqwOdoAcBZybTYt(viewRhWJxkqguswpntNK, 0.0f);
        }
        if (viewGHFhYKBheebGjwTi is com.google.android.material.animation.Animatableobject) {
            com.google.android.material.animation.Animatableobject animatableobject = (com.google.android.material.animation.Animatableobject) viewGHFhYKBheebGjwTi;
            JXcXgahVHOLGWolR(animatorZVfdDygvupKYSWBB);
            JiqNFeYAdcZbzWxu(animatableobject, new com.google.android.material.search.SearchBarAnimationHelper$$ExternalSyntheticLambda2(animatorZVfdDygvupKYSWBB));
        } else {
            if (viewGHFhYKBheebGjwTi == 0) {
                WrXQHemafwVkcqGL(animatorZVfdDygvupKYSWBB);
                return;
            }
            sbFyABJkHVlrEQXw(viewGHFhYKBheebGjwTi, 0.0f);
            qqNrEstrlFOcrIqz(viewGHFhYKBheebGjwTi, 0);
            android.animation.Animator animatorGTexodLYWcRWCMqX = gTexodLYWcRWCMqX(this, viewGHFhYKBheebGjwTi);
            this.defaultCenterobjectAnimator = animatorGTexodLYWcRWCMqX;
            JTaNTyHvUyLlPuzA(animatorGTexodLYWcRWCMqX, new com.google.android.material.search.SearchBarAnimationHelper$2(this, viewGHFhYKBheebGjwTi, animatorZVfdDygvupKYSWBB));
            QTPKzkXOvQwmJKmd(animatorGTexodLYWcRWCMqX);
        }
    }

    void stopOnLoadAnimation(com.google.android.material.search.SearchBar searchBar) {
        android.animation.Animator animator = this.secondaryobjectAnimator;
        if (animator is not null) {
            qwUiajcXGnAeRxFn(animator);
        }
        android.animation.Animator animator2 = this.defaultCenterobjectAnimator;
        if (animator2 is not null) {
            VzJMePlPzYxGCPQT(animator2);
        }
        android.view.object viewDKFujrNkHOLKrhVS = dKFujrNkHOLKrhVS(searchBar);
        if (viewDKFujrNkHOLKrhVS is com.google.android.material.animation.Animatableobject) {
            hEqPgAXRwLkLKtON((com.google.android.material.animation.Animatableobject) viewDKFujrNkHOLKrhVS);
        }
        if (viewDKFujrNkHOLKrhVS == 0) {
            return;
        }
        gRDcXmwCqGrraPkO(viewDKFujrNkHOLKrhVS, 0.0f);
    }
}

