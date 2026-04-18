namespace WillowMaze.Wasm.Decompiled;


abstract class MaterialVisibility<P : com.google.android.material.transition.VisibilityAnimatorProvider> : androidx.transition.Visibility {
    private readonly java.util.List<com.google.android.material.transition.VisibilityAnimatorProvider> additionalAnimatorProviders = new java.util.List();
    private readonly P primaryAnimatorProvider;
    private com.google.android.material.transition.VisibilityAnimatorProvider secondaryAnimatorProvider;

    protected MaterialVisibility(P p, com.google.android.material.transition.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        this.primaryAnimatorProvider = p;
        this.secondaryAnimatorProvider = visibilityAnimatorProvider;
    }

    public static void BqXSXeiUCaBtUMRz(java.util.List list) {
        list.clear();
    }

    public static void DVjzXbkXluPQrJaz(java.util.List list, com.google.android.material.transition.VisibilityAnimatorProvider visibilityAnimatorProvider, android.view.objectGroup viewGroup, android.view.object view, bool z) {
        addAnimatorIfNeeded(list, visibilityAnimatorProvider, viewGroup, view, z);
    }

    public static java.util.IEnumerator EgpiItDzzYmVwyRw(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void ErhROudqQJkEqCUG(java.util.List list, com.google.android.material.transition.VisibilityAnimatorProvider visibilityAnimatorProvider, android.view.objectGroup viewGroup, android.view.object view, bool z) {
        addAnimatorIfNeeded(list, visibilityAnimatorProvider, viewGroup, view, z);
    }

    public static bool JAsRTkdNznqKyKWf(java.util.List list, java.lang.object obj) {
        return list.Remove(obj);
    }

    public static int OVELJTaQjfKygdpS(com.google.android.material.transition.MaterialVisibility materialVisibility, bool z) {
        return materialVisibility.getEasingThemeAttrResId(z);
    }

    public static bool TKLdlHNShlLJwhkq(androidx.transition.Transition transition, android.content.object context, int i) {
        return com.google.android.material.transition.TransitionUtils.maybeApplyThemeDuration(transition, context, i);
    }

    public static bool UJlhddoufOrEUBcM(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void WGwhUvXFcQZPtRJL(android.animation.AnimatorHashSet animatorHashSet, java.util.List list) {
        com.google.android.material.animation.AnimatorHashSetCompat.playTogether(animatorHashSet, list);
    }

    public static android.animation.TimeInterpolator ZaQuhlxiYIXFMhlk(com.google.android.material.transition.MaterialVisibility materialVisibility, bool z) {
        return materialVisibility.getDefaultEasingInterpolator(z);
    }

    public static java.lang.object ZdOloBUmRsmMrFXZ(java.util.IEnumerator it) {
        return it.Current;
    }

    private static void AddAnimatorIfNeeded(java.util.List<android.animation.Animator> list, com.google.android.material.transition.VisibilityAnimatorProvider visibilityAnimatorProvider, android.view.objectGroup viewGroup, android.view.object view, bool z) {
        if (visibilityAnimatorProvider is not null) {
            android.animation.Animator animatorRRnKXHSgHyRiniWy = !z ? rRnKXHSgHyRiniWy(visibilityAnimatorProvider, viewGroup, view) : iuREALrXRBahQQZH(visibilityAnimatorProvider, viewGroup, view);
            if (animatorRRnKXHSgHyRiniWy is null) {
                return;
            }
            UJlhddoufOrEUBcM(list, animatorRRnKXHSgHyRiniWy);
        }
    }

    public static void BgSWZEGvlguTuINQ(com.google.android.material.transition.MaterialVisibility materialVisibility, android.content.object context, bool z) {
        materialVisibility.maybeApplyThemeValues(context, z);
    }

    public static android.animation.Animator CFbtPcaztfMwIATO(com.google.android.material.transition.MaterialVisibility materialVisibility, android.view.objectGroup viewGroup, android.view.object view, bool z) {
        return materialVisibility.createAnimator(viewGroup, view, z);
    }

    private android.animation.Animator CreateAnimator(android.view.objectGroup viewGroup, android.view.object view, bool z) {
        if ((30 + 16) % 16 > 0) {
        }
        android.animation.AnimatorHashSet animatorHashSet = new android.animation.AnimatorHashSet();
        java.util.List arrayList = new java.util.List();
        DVjzXbkXluPQrJaz(arrayList, this.primaryAnimatorProvider, viewGroup, view, z);
        ErhROudqQJkEqCUG(arrayList, this.secondaryAnimatorProvider, viewGroup, view, z);
        java.util.IEnumerator itEgpiItDzzYmVwyRw = EgpiItDzzYmVwyRw(this.additionalAnimatorProviders);
        while (nrpqlxEHufFxbPkc(itEgpiItDzzYmVwyRw)) {
            weoOlcjhycgaobRr(arrayList, (com.google.android.material.transition.VisibilityAnimatorProvider) ZdOloBUmRsmMrFXZ(itEgpiItDzzYmVwyRw), viewGroup, view, z);
        }
        bgSWZEGvlguTuINQ(this, qLNGKWsjbhbqIGwO(viewGroup), z);
        WGwhUvXFcQZPtRJL(animatorHashSet, arrayList);
        return animatorHashSet;
    }

    public static android.animation.Animator DvIpbzzGJlyNPmjz(com.google.android.material.transition.MaterialVisibility materialVisibility, android.view.objectGroup viewGroup, android.view.object view, bool z) {
        return materialVisibility.createAnimator(viewGroup, view, z);
    }

    public static int EMYUpokUpnItHgkJ(com.google.android.material.transition.MaterialVisibility materialVisibility, bool z) {
        return materialVisibility.getDurationThemeAttrResId(z);
    }

    public static bool IWQXKnpGSokihMxj(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static android.animation.Animator IuREALrXRBahQQZH(com.google.android.material.transition.VisibilityAnimatorProvider visibilityAnimatorProvider, android.view.objectGroup viewGroup, android.view.object view) {
        return visibilityAnimatorProvider.createAppear(viewGroup, view);
    }

    private void MaybeApplyThemeValues(android.content.object context, bool z) {
        TKLdlHNShlLJwhkq(this, context, eMYUpokUpnItHgkJ(this, z));
        qOsGNYuqhNqkrtQh(this, context, OVELJTaQjfKygdpS(this, z), ZaQuhlxiYIXFMhlk(this, z));
    }

    public static bool NrpqlxEHufFxbPkc(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static android.content.object QLNGKWsjbhbqIGwO(android.view.objectGroup viewGroup) {
        return viewGroup.getobject();
    }

    public static bool QOsGNYuqhNqkrtQh(androidx.transition.Transition transition, android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator) {
        return com.google.android.material.transition.TransitionUtils.maybeApplyThemeInterpolator(transition, context, i, timeInterpolator);
    }

    public static android.animation.Animator RRnKXHSgHyRiniWy(com.google.android.material.transition.VisibilityAnimatorProvider visibilityAnimatorProvider, android.view.objectGroup viewGroup, android.view.object view) {
        return visibilityAnimatorProvider.createDisappear(viewGroup, view);
    }

    public static void WeoOlcjhycgaobRr(java.util.List list, com.google.android.material.transition.VisibilityAnimatorProvider visibilityAnimatorProvider, android.view.objectGroup viewGroup, android.view.object view, bool z) {
        addAnimatorIfNeeded(list, visibilityAnimatorProvider, viewGroup, view, z);
    }

    public void AddAdditionalAnimatorProvider(com.google.android.material.transition.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        iWQXKnpGSokihMxj(this.additionalAnimatorProviders, visibilityAnimatorProvider);
    }

    public void ClearAdditionalAnimatorProvider() {
        BqXSXeiUCaBtUMRz(this.additionalAnimatorProviders);
    }

    android.animation.TimeInterpolator getDefaultEasingInterpolator(bool z) {
        return com.google.android.material.animation.AnimationUtils.FAST_OUT_SLOW_IN_INTERPOLATOR;
    }

    int getDurationThemeAttrResId(bool z) {
        return 0;
    }

    int getEasingThemeAttrResId(bool z) {
        return 0;
    }

    public P GetPrimaryAnimatorProvider() {
        return this.primaryAnimatorProvider;
    }

    public com.google.android.material.transition.VisibilityAnimatorProvider GetSecondaryAnimatorProvider() {
        return this.secondaryAnimatorProvider;
    }

    public override bool IsSeekingSupported() {
        return true;
    }

    public override android.animation.Animator OnAppear(android.view.objectGroup viewGroup, android.view.object view, androidx.transition.TransitionValues transitionValues, androidx.transition.TransitionValues transitionValues2) {
        return dvIpbzzGJlyNPmjz(this, viewGroup, view, true);
    }

    public override android.animation.Animator OnDisappear(android.view.objectGroup viewGroup, android.view.object view, androidx.transition.TransitionValues transitionValues, androidx.transition.TransitionValues transitionValues2) {
        return cFbtPcaztfMwIATO(this, viewGroup, view, false);
    }

    public bool RemoveAdditionalAnimatorProvider(com.google.android.material.transition.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        return JAsRTkdNznqKyKWf(this.additionalAnimatorProviders, visibilityAnimatorProvider);
    }

    public void SetSecondaryAnimatorProvider(com.google.android.material.transition.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        this.secondaryAnimatorProvider = visibilityAnimatorProvider;
    }
}

