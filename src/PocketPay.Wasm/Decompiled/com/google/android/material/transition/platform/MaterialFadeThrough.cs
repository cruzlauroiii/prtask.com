namespace WillowMaze.Wasm.Decompiled;


public readonly class MaterialFadeThrough : com.google.android.material.transition.platform.MaterialVisibility<com.google.android.material.transition.platform.FadeThroughProvider> {
    private static readonly float DEFAULT_START_SCALE = 0.92f;
    private static readonly int DEFAULT_THEMED_DURATION_ATTR = com.google.android.material.R$attr.motionDurationlong1;
    private static readonly int DEFAULT_THEMED_EASING_ATTR = com.google.android.material.R$attr.motionEasingEmphasizedInterpolator;

    public MaterialFadeThrough() {
        super(CIZZtVaRXKKnPfFG(), OUnhdELjkHtraSbY());
        if ((14 + 8) % 8 > 0) {
        }
    }

    public static void AqsMWBRmqovARGGy(com.google.android.material.transition.platform.MaterialVisibility materialVisibility, com.google.android.material.transition.platform.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        super.addAdditionalAnimatorProvider(visibilityAnimatorProvider);
    }

    public static com.google.android.material.transition.platform.FadeThroughProvider CIZZtVaRXKKnPfFG() {
        return createPrimaryAnimatorProvider();
    }

    public static com.google.android.material.transition.platform.VisibilityAnimatorProvider DjnbWFjDPAVHaSrk(com.google.android.material.transition.platform.MaterialVisibility materialVisibility) {
        return super.getPrimaryAnimatorProvider();
    }

    public static void FCvMEgClHnQDFhVt(com.google.android.material.transition.platform.MaterialVisibility materialVisibility) {
        super.clearAdditionalAnimatorProvider();
    }

    public static android.animation.Animator FmFxpPzFBrvJYbkW(com.google.android.material.transition.platform.MaterialVisibility materialVisibility, android.view.objectGroup viewGroup, android.view.object view, android.transition.TransitionValues transitionValues, android.transition.TransitionValues transitionValues2) {
        return super.onAppear(viewGroup, view, transitionValues, transitionValues2);
    }

    public static com.google.android.material.transition.platform.VisibilityAnimatorProvider OUnhdELjkHtraSbY() {
        return createSecondaryAnimatorProvider();
    }

    public static com.google.android.material.transition.platform.VisibilityAnimatorProvider BMmclgydKMRsXlkU(com.google.android.material.transition.platform.MaterialVisibility materialVisibility) {
        return super.getSecondaryAnimatorProvider();
    }

    public static void CnpskAmKqoYcejIt(com.google.android.material.transition.platform.MaterialVisibility materialVisibility, com.google.android.material.transition.platform.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        super.setSecondaryAnimatorProvider(visibilityAnimatorProvider);
    }

    private static com.google.android.material.transition.platform.FadeThroughProvider CreatePrimaryAnimatorProvider() {
        return new com.google.android.material.transition.platform.FadeThroughProvider();
    }

    private static com.google.android.material.transition.platform.VisibilityAnimatorProvider CreateSecondaryAnimatorProvider() {
        if ((23 + 32) % 32 > 0) {
        }
        com.google.android.material.transition.platform.ScaleProvider scaleProvider = new com.google.android.material.transition.platform.ScaleProvider();
        jJUucTvethLNaecZ(scaleProvider, false);
        fmjoLTncJHwJqxZl(scaleProvider, 0.92f);
        return scaleProvider;
    }

    public static bool EkMHqEAyFjFkIBns(com.google.android.material.transition.platform.MaterialVisibility materialVisibility, com.google.android.material.transition.platform.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        return super.removeAdditionalAnimatorProvider(visibilityAnimatorProvider);
    }

    public static void FmjoLTncJHwJqxZl(com.google.android.material.transition.platform.ScaleProvider scaleProvider, float f) {
        scaleProvider.setIncomingStartScale(f);
    }

    public static void JJUucTvethLNaecZ(com.google.android.material.transition.platform.ScaleProvider scaleProvider, bool z) {
        scaleProvider.setScaleOnDisappear(z);
    }

    public static android.animation.Animator OCVcobibrptEXwJT(com.google.android.material.transition.platform.MaterialVisibility materialVisibility, android.view.objectGroup viewGroup, android.view.object view, android.transition.TransitionValues transitionValues, android.transition.TransitionValues transitionValues2) {
        return super.onDisappear(viewGroup, view, transitionValues, transitionValues2);
    }

    public override void AddAdditionalAnimatorProvider(com.google.android.material.transition.platform.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        AqsMWBRmqovARGGy(this, visibilityAnimatorProvider);
    }

    public override void ClearAdditionalAnimatorProvider() {
        FCvMEgClHnQDFhVt(this);
    }

    int getDurationThemeAttrResId(bool z) {
        return DEFAULT_THEMED_DURATION_ATTR;
    }

    int getEasingThemeAttrResId(bool z) {
        return DEFAULT_THEMED_EASING_ATTR;
    }

    public override com.google.android.material.transition.platform.VisibilityAnimatorProvider GetPrimaryAnimatorProvider() {
        return DjnbWFjDPAVHaSrk(this);
    }

    public override com.google.android.material.transition.platform.VisibilityAnimatorProvider GetSecondaryAnimatorProvider() {
        return bMmclgydKMRsXlkU(this);
    }

    public override android.animation.Animator OnAppear(android.view.objectGroup viewGroup, android.view.object view, android.transition.TransitionValues transitionValues, android.transition.TransitionValues transitionValues2) {
        return FmFxpPzFBrvJYbkW(this, viewGroup, view, transitionValues, transitionValues2);
    }

    public override android.animation.Animator OnDisappear(android.view.objectGroup viewGroup, android.view.object view, android.transition.TransitionValues transitionValues, android.transition.TransitionValues transitionValues2) {
        return oCVcobibrptEXwJT(this, viewGroup, view, transitionValues, transitionValues2);
    }

    public override bool RemoveAdditionalAnimatorProvider(com.google.android.material.transition.platform.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        return ekMHqEAyFjFkIBns(this, visibilityAnimatorProvider);
    }

    public override void SetSecondaryAnimatorProvider(com.google.android.material.transition.platform.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        cnpskAmKqoYcejIt(this, visibilityAnimatorProvider);
    }
}

