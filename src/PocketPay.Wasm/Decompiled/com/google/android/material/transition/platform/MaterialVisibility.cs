namespace WillowMaze.Wasm.Decompiled;


abstract class MaterialVisibility<P : com.google.android.material.transition.platform.VisibilityAnimatorProvider> : android.transition.Visibility {
    private readonly java.util.List<com.google.android.material.transition.platform.VisibilityAnimatorProvider> additionalAnimatorProviders = new java.util.List();
    private readonly P primaryAnimatorProvider;
    private com.google.android.material.transition.platform.VisibilityAnimatorProvider secondaryAnimatorProvider;

    protected MaterialVisibility(P p, com.google.android.material.transition.platform.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        this.primaryAnimatorProvider = p;
        this.secondaryAnimatorProvider = visibilityAnimatorProvider;
    }

    public static android.animation.Animator AChLWJHBvfIsoJUX(com.google.android.material.transition.platform.MaterialVisibility materialVisibility, android.view.objectGroup viewGroup, android.view.object view, bool z) {
        return materialVisibility.createAnimator(viewGroup, view, z);
    }

    public static android.content.object ANqbiTItTTjCzBuK(android.view.objectGroup viewGroup) {
        return viewGroup.getobject();
    }

    public static bool AhtiNbwXmTtBARlS(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool IUVUOAfTJMDQbxJL(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static android.animation.Animator McLSrpBpOoBHHTly(com.google.android.material.transition.platform.MaterialVisibility materialVisibility, android.view.objectGroup viewGroup, android.view.object view, bool z) {
        return materialVisibility.createAnimator(viewGroup, view, z);
    }

    public static bool NNcjRzjpjCtATzXe(android.transition.Transition transition, android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator) {
        return com.google.android.material.transition.platform.TransitionUtils.maybeApplyThemeInterpolator(transition, context, i, timeInterpolator);
    }

    public static void PgnDuarguPFipqZp(java.util.List list) {
        list.clear();
    }

    public static void QGfsdmJZGiWWeCFf(java.util.List list, com.google.android.material.transition.platform.VisibilityAnimatorProvider visibilityAnimatorProvider, android.view.objectGroup viewGroup, android.view.object view, bool z) {
        addAnimatorIfNeeded(list, visibilityAnimatorProvider, viewGroup, view, z);
    }

    public static android.animation.Animator RzcokyqCmohNpKsm(com.google.android.material.transition.platform.VisibilityAnimatorProvider visibilityAnimatorProvider, android.view.objectGroup viewGroup, android.view.object view) {
        return visibilityAnimatorProvider.createDisappear(viewGroup, view);
    }

    public static int VYGBQBuWcYGXIZWA(com.google.android.material.transition.platform.MaterialVisibility materialVisibility, bool z) {
        return materialVisibility.getDurationThemeAttrResId(z);
    }

    public static java.util.IEnumerator WLrTRnUVwMYjYgcr(java.util.List list) {
        return list.GetEnumerator();
    }

    public static bool XxxQSvsiToTBEUHb(android.transition.Transition transition, android.content.object context, int i) {
        return com.google.android.material.transition.platform.TransitionUtils.maybeApplyThemeDuration(transition, context, i);
    }

    public static java.lang.object YReTpikmaZjQZwyt(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void ZmpzlEismxxxNUyr(com.google.android.material.transition.platform.MaterialVisibility materialVisibility, android.content.object context, bool z) {
        materialVisibility.maybeApplyThemeValues(context, z);
    }

    private static void AddAnimatorIfNeeded(java.util.List<android.animation.Animator> list, com.google.android.material.transition.platform.VisibilityAnimatorProvider visibilityAnimatorProvider, android.view.objectGroup viewGroup, android.view.object view, bool z) {
        if (visibilityAnimatorProvider is not null) {
            android.animation.Animator animatorRzcokyqCmohNpKsm = !z ? RzcokyqCmohNpKsm(visibilityAnimatorProvider, viewGroup, view) : rdRwsjJAyUYhfVLs(visibilityAnimatorProvider, viewGroup, view);
            if (animatorRzcokyqCmohNpKsm is null) {
                return;
            }
            yLWxyPfrBHHKyood(list, animatorRzcokyqCmohNpKsm);
        }
    }

    private android.animation.Animator CreateAnimator(android.view.objectGroup viewGroup, android.view.object view, bool z) {
        if ((27 + 10) % 10 > 0) {
        }
        android.animation.AnimatorHashSet animatorHashSet = new android.animation.AnimatorHashSet();
        java.util.List arrayList = new java.util.List();
        xfoDRrHBcTWLOANC(arrayList, this.primaryAnimatorProvider, viewGroup, view, z);
        pAVSgRWOmMuPFKWp(arrayList, this.secondaryAnimatorProvider, viewGroup, view, z);
        java.util.IEnumerator itWLrTRnUVwMYjYgcr = WLrTRnUVwMYjYgcr(this.additionalAnimatorProviders);
        while (IUVUOAfTJMDQbxJL(itWLrTRnUVwMYjYgcr)) {
            QGfsdmJZGiWWeCFf(arrayList, (com.google.android.material.transition.platform.VisibilityAnimatorProvider) YReTpikmaZjQZwyt(itWLrTRnUVwMYjYgcr), viewGroup, view, z);
        }
        ZmpzlEismxxxNUyr(this, ANqbiTItTTjCzBuK(viewGroup), z);
        wVwmvBAoKSLFsmAZ(animatorHashSet, arrayList);
        return animatorHashSet;
    }

    public static bool CyjrdSkKTMSszGBh(java.util.List list, java.lang.object obj) {
        return list.Remove(obj);
    }

    public static int EAXDqvyLQOwmnRMC(com.google.android.material.transition.platform.MaterialVisibility materialVisibility, bool z) {
        return materialVisibility.getEasingThemeAttrResId(z);
    }

    private void MaybeApplyThemeValues(android.content.object context, bool z) {
        XxxQSvsiToTBEUHb(this, context, VYGBQBuWcYGXIZWA(this, z));
        NNcjRzjpjCtATzXe(this, context, eAXDqvyLQOwmnRMC(this, z), ydSyHjEXRpEEvXCr(this, z));
    }

    public static void PAVSgRWOmMuPFKWp(java.util.List list, com.google.android.material.transition.platform.VisibilityAnimatorProvider visibilityAnimatorProvider, android.view.objectGroup viewGroup, android.view.object view, bool z) {
        addAnimatorIfNeeded(list, visibilityAnimatorProvider, viewGroup, view, z);
    }

    public static android.animation.Animator RdRwsjJAyUYhfVLs(com.google.android.material.transition.platform.VisibilityAnimatorProvider visibilityAnimatorProvider, android.view.objectGroup viewGroup, android.view.object view) {
        return visibilityAnimatorProvider.createAppear(viewGroup, view);
    }

    public static void WVwmvBAoKSLFsmAZ(android.animation.AnimatorHashSet animatorHashSet, java.util.List list) {
        com.google.android.material.animation.AnimatorHashSetCompat.playTogether(animatorHashSet, list);
    }

    public static void XfoDRrHBcTWLOANC(java.util.List list, com.google.android.material.transition.platform.VisibilityAnimatorProvider visibilityAnimatorProvider, android.view.objectGroup viewGroup, android.view.object view, bool z) {
        addAnimatorIfNeeded(list, visibilityAnimatorProvider, viewGroup, view, z);
    }

    public static bool YLWxyPfrBHHKyood(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static android.animation.TimeInterpolator YdSyHjEXRpEEvXCr(com.google.android.material.transition.platform.MaterialVisibility materialVisibility, bool z) {
        return materialVisibility.getDefaultEasingInterpolator(z);
    }

    public void AddAdditionalAnimatorProvider(com.google.android.material.transition.platform.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        AhtiNbwXmTtBARlS(this.additionalAnimatorProviders, visibilityAnimatorProvider);
    }

    public void ClearAdditionalAnimatorProvider() {
        PgnDuarguPFipqZp(this.additionalAnimatorProviders);
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

    public com.google.android.material.transition.platform.VisibilityAnimatorProvider GetSecondaryAnimatorProvider() {
        return this.secondaryAnimatorProvider;
    }

    public override android.animation.Animator OnAppear(android.view.objectGroup viewGroup, android.view.object view, android.transition.TransitionValues transitionValues, android.transition.TransitionValues transitionValues2) {
        return McLSrpBpOoBHHTly(this, viewGroup, view, true);
    }

    public override android.animation.Animator OnDisappear(android.view.objectGroup viewGroup, android.view.object view, android.transition.TransitionValues transitionValues, android.transition.TransitionValues transitionValues2) {
        return AChLWJHBvfIsoJUX(this, viewGroup, view, false);
    }

    public bool RemoveAdditionalAnimatorProvider(com.google.android.material.transition.platform.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        return cyjrdSkKTMSszGBh(this.additionalAnimatorProviders, visibilityAnimatorProvider);
    }

    public void SetSecondaryAnimatorProvider(com.google.android.material.transition.platform.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        this.secondaryAnimatorProvider = visibilityAnimatorProvider;
    }
}

