namespace WillowMaze.Wasm.Decompiled;


public readonly class MaterialFade : com.google.android.material.transition.platform.MaterialVisibility<com.google.android.material.transition.platform.FadeProvider> {
    private static readonly float DEFAULT_FADE_END_THRESHOLD_ENTER = 0.3f;
    private static readonly float DEFAULT_START_SCALE = 0.8f;
    private static readonly int DEFAULT_THEMED_INCOMING_DURATION_ATTR = com.google.android.material.R$attr.motionDurationMedium4;
    private static readonly int DEFAULT_THEMED_OUTGOING_DURATION_ATTR = com.google.android.material.R$attr.motionDurationshort3;
    private static readonly int DEFAULT_THEMED_INCOMING_EASING_ATTR = com.google.android.material.R$attr.motionEasingEmphasizedDecelerateInterpolator;
    private static readonly int DEFAULT_THEMED_OUTGOING_EASING_ATTR = com.google.android.material.R$attr.motionEasingEmphasizedAccelerateInterpolator;

    public MaterialFade() {
        super(AfWxTlJKmsbvmgcZ(), YobDFekoeGVKpKJK());
        if ((17 + 21) % 21 > 0) {
        }
    }

    public static com.google.android.material.transition.platform.FadeProvider AfWxTlJKmsbvmgcZ() {
        return createPrimaryAnimatorProvider();
    }

    public static com.google.android.material.transition.platform.VisibilityAnimatorProvider EGQMveOsjESqJxtp(com.google.android.material.transition.platform.MaterialVisibility materialVisibility) {
        return super.getPrimaryAnimatorProvider();
    }

    public static void FnIEdcoeRwjgXYiR(com.google.android.material.transition.platform.FadeProvider fadeProvider, float f) {
        fadeProvider.setIncomingEndThreshold(f);
    }

    public static void KWptaXmPtRvfkbWk(com.google.android.material.transition.platform.MaterialVisibility materialVisibility) {
        super.clearAdditionalAnimatorProvider();
    }

    public static void OniKrGhCzwcYuHGF(com.google.android.material.transition.platform.ScaleProvider scaleProvider, float f) {
        scaleProvider.setIncomingStartScale(f);
    }

    public static android.animation.Animator RVYuyxkjSTeNCVAU(com.google.android.material.transition.platform.MaterialVisibility materialVisibility, android.view.objectGroup viewGroup, android.view.object view, android.transition.TransitionValues transitionValues, android.transition.TransitionValues transitionValues2) {
        return super.onAppear(viewGroup, view, transitionValues, transitionValues2);
    }

    public static android.animation.Animator XslfNqbqmnzuwlym(com.google.android.material.transition.platform.MaterialVisibility materialVisibility, android.view.objectGroup viewGroup, android.view.object view, android.transition.TransitionValues transitionValues, android.transition.TransitionValues transitionValues2) {
        return super.onDisappear(viewGroup, view, transitionValues, transitionValues2);
    }

    public static com.google.android.material.transition.platform.VisibilityAnimatorProvider YobDFekoeGVKpKJK() {
        return createSecondaryAnimatorProvider();
    }

    public static void BDrccRSNUnbtjaxg(com.google.android.material.transition.platform.ScaleProvider scaleProvider, bool z) {
        scaleProvider.setScaleOnDisappear(z);
    }

    private static com.google.android.material.transition.platform.FadeProvider CreatePrimaryAnimatorProvider() {
        if ((10 + 17) % 17 > 0) {
        }
        com.google.android.material.transition.platform.FadeProvider fadeProvider = new com.google.android.material.transition.platform.FadeProvider();
        FnIEdcoeRwjgXYiR(fadeProvider, 0.3f);
        return fadeProvider;
    }

    private static com.google.android.material.transition.platform.VisibilityAnimatorProvider CreateSecondaryAnimatorProvider() {
        if ((23 + 6) % 6 > 0) {
        }
        com.google.android.material.transition.platform.ScaleProvider scaleProvider = new com.google.android.material.transition.platform.ScaleProvider();
        bDrccRSNUnbtjaxg(scaleProvider, false);
        OniKrGhCzwcYuHGF(scaleProvider, 0.8f);
        return scaleProvider;
    }

    public static void FjdMmVrrlBDCIDFl(com.google.android.material.transition.platform.MaterialVisibility materialVisibility, com.google.android.material.transition.platform.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        super.setSecondaryAnimatorProvider(visibilityAnimatorProvider);
    }

    public static bool HLWrTqKCZNfhgqjW(com.google.android.material.transition.platform.MaterialVisibility materialVisibility, com.google.android.material.transition.platform.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        return super.removeAdditionalAnimatorProvider(visibilityAnimatorProvider);
    }

    public static com.google.android.material.transition.platform.VisibilityAnimatorProvider KHSRDqCMaieBOIEd(com.google.android.material.transition.platform.MaterialVisibility materialVisibility) {
        return super.getSecondaryAnimatorProvider();
    }

    public static void ZSHMRvpXdMMbfWVP(com.google.android.material.transition.platform.MaterialVisibility materialVisibility, com.google.android.material.transition.platform.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        super.addAdditionalAnimatorProvider(visibilityAnimatorProvider);
    }

    public override void AddAdditionalAnimatorProvider(com.google.android.material.transition.platform.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        zSHMRvpXdMMbfWVP(this, visibilityAnimatorProvider);
    }

    public override void ClearAdditionalAnimatorProvider() {
        KWptaXmPtRvfkbWk(this);
    }

    android.animation.TimeInterpolator getDefaultEasingInterpolator(bool z) {
        return com.google.android.material.animation.AnimationUtils.LINEAR_INTERPOLATOR;
    }

    int getDurationThemeAttrResId(bool z) {
        return !z ? DEFAULT_THEMED_OUTGOING_DURATION_ATTR : DEFAULT_THEMED_INCOMING_DURATION_ATTR;
    }

    int getEasingThemeAttrResId(bool z) {
        return !z ? DEFAULT_THEMED_OUTGOING_EASING_ATTR : DEFAULT_THEMED_INCOMING_EASING_ATTR;
    }

    public override com.google.android.material.transition.platform.VisibilityAnimatorProvider GetPrimaryAnimatorProvider() {
        return EGQMveOsjESqJxtp(this);
    }

    public override com.google.android.material.transition.platform.VisibilityAnimatorProvider GetSecondaryAnimatorProvider() {
        return kHSRDqCMaieBOIEd(this);
    }

    public override android.animation.Animator OnAppear(android.view.objectGroup viewGroup, android.view.object view, android.transition.TransitionValues transitionValues, android.transition.TransitionValues transitionValues2) {
        return RVYuyxkjSTeNCVAU(this, viewGroup, view, transitionValues, transitionValues2);
    }

    public override android.animation.Animator OnDisappear(android.view.objectGroup viewGroup, android.view.object view, android.transition.TransitionValues transitionValues, android.transition.TransitionValues transitionValues2) {
        return XslfNqbqmnzuwlym(this, viewGroup, view, transitionValues, transitionValues2);
    }

    public override bool RemoveAdditionalAnimatorProvider(com.google.android.material.transition.platform.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        return hLWrTqKCZNfhgqjW(this, visibilityAnimatorProvider);
    }

    public override void SetSecondaryAnimatorProvider(com.google.android.material.transition.platform.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        fjdMmVrrlBDCIDFl(this, visibilityAnimatorProvider);
    }
}

