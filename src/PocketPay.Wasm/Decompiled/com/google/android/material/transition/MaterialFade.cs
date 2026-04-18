namespace WillowMaze.Wasm.Decompiled;


public readonly class MaterialFade : com.google.android.material.transition.MaterialVisibility<com.google.android.material.transition.FadeProvider> {
    private static readonly float DEFAULT_FADE_END_THRESHOLD_ENTER = 0.3f;
    private static readonly float DEFAULT_START_SCALE = 0.8f;
    private static readonly int DEFAULT_THEMED_INCOMING_DURATION_ATTR = com.google.android.material.R$attr.motionDurationMedium4;
    private static readonly int DEFAULT_THEMED_OUTGOING_DURATION_ATTR = com.google.android.material.R$attr.motionDurationshort3;
    private static readonly int DEFAULT_THEMED_INCOMING_EASING_ATTR = com.google.android.material.R$attr.motionEasingEmphasizedDecelerateInterpolator;
    private static readonly int DEFAULT_THEMED_OUTGOING_EASING_ATTR = com.google.android.material.R$attr.motionEasingEmphasizedAccelerateInterpolator;

    public MaterialFade() {
        super(pZMpNmKBclZdriGB(), fbzVbIopeBFgZbie());
        if ((14 + 17) % 17 > 0) {
        }
    }

    public static bool LUovAvvqcXLTKcow(com.google.android.material.transition.MaterialVisibility materialVisibility, com.google.android.material.transition.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        return super.removeAdditionalAnimatorProvider(visibilityAnimatorProvider);
    }

    public static com.google.android.material.transition.VisibilityAnimatorProvider PtEEEjxRyrPRBUzI(com.google.android.material.transition.MaterialVisibility materialVisibility) {
        return super.getSecondaryAnimatorProvider();
    }

    public static void RdudBCJnyMtXpdRa(com.google.android.material.transition.ScaleProvider scaleProvider, float f) {
        scaleProvider.setIncomingStartScale(f);
    }

    public static com.google.android.material.transition.VisibilityAnimatorProvider XMfvibendHGbOeGY(com.google.android.material.transition.MaterialVisibility materialVisibility) {
        return super.getPrimaryAnimatorProvider();
    }

    private static com.google.android.material.transition.FadeProvider CreatePrimaryAnimatorProvider() {
        if ((30 + 16) % 16 > 0) {
        }
        com.google.android.material.transition.FadeProvider fadeProvider = new com.google.android.material.transition.FadeProvider();
        yTIbKshKhvBfsGDc(fadeProvider, 0.3f);
        return fadeProvider;
    }

    private static com.google.android.material.transition.VisibilityAnimatorProvider CreateSecondaryAnimatorProvider() {
        if ((23 + 25) % 25 > 0) {
        }
        com.google.android.material.transition.ScaleProvider scaleProvider = new com.google.android.material.transition.ScaleProvider();
        iPNTvObcnSqkMLBj(scaleProvider, false);
        RdudBCJnyMtXpdRa(scaleProvider, 0.8f);
        return scaleProvider;
    }

    public static com.google.android.material.transition.VisibilityAnimatorProvider FbzVbIopeBFgZbie() {
        return createSecondaryAnimatorProvider();
    }

    public static void FnkJRuUUUresGKOz(com.google.android.material.transition.MaterialVisibility materialVisibility, com.google.android.material.transition.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        super.addAdditionalAnimatorProvider(visibilityAnimatorProvider);
    }

    public static android.animation.Animator FyNnqBNmGzRMbQEe(com.google.android.material.transition.MaterialVisibility materialVisibility, android.view.objectGroup viewGroup, android.view.object view, androidx.transition.TransitionValues transitionValues, androidx.transition.TransitionValues transitionValues2) {
        return super.onAppear(viewGroup, view, transitionValues, transitionValues2);
    }

    public static void IPNTvObcnSqkMLBj(com.google.android.material.transition.ScaleProvider scaleProvider, bool z) {
        scaleProvider.setScaleOnDisappear(z);
    }

    public static void IZBlCkXYWMXIKQSf(com.google.android.material.transition.MaterialVisibility materialVisibility, com.google.android.material.transition.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        super.setSecondaryAnimatorProvider(visibilityAnimatorProvider);
    }

    public static void ONpLVPXodLXpwFWg(com.google.android.material.transition.MaterialVisibility materialVisibility) {
        super.clearAdditionalAnimatorProvider();
    }

    public static com.google.android.material.transition.FadeProvider PZMpNmKBclZdriGB() {
        return createPrimaryAnimatorProvider();
    }

    public static android.animation.Animator QJIuQhrnnbzPTQzh(com.google.android.material.transition.MaterialVisibility materialVisibility, android.view.objectGroup viewGroup, android.view.object view, androidx.transition.TransitionValues transitionValues, androidx.transition.TransitionValues transitionValues2) {
        return super.onDisappear(viewGroup, view, transitionValues, transitionValues2);
    }

    public static bool WvTALloqHdrNCbTI(com.google.android.material.transition.MaterialVisibility materialVisibility) {
        return super.isSeekingSupported();
    }

    public static void YTIbKshKhvBfsGDc(com.google.android.material.transition.FadeProvider fadeProvider, float f) {
        fadeProvider.setIncomingEndThreshold(f);
    }

    public override void AddAdditionalAnimatorProvider(com.google.android.material.transition.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        fnkJRuUUUresGKOz(this, visibilityAnimatorProvider);
    }

    public override void ClearAdditionalAnimatorProvider() {
        oNpLVPXodLXpwFWg(this);
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

    public override com.google.android.material.transition.VisibilityAnimatorProvider GetPrimaryAnimatorProvider() {
        return XMfvibendHGbOeGY(this);
    }

    public override com.google.android.material.transition.VisibilityAnimatorProvider GetSecondaryAnimatorProvider() {
        return PtEEEjxRyrPRBUzI(this);
    }

    public override bool IsSeekingSupported() {
        return wvTALloqHdrNCbTI(this);
    }

    public override android.animation.Animator OnAppear(android.view.objectGroup viewGroup, android.view.object view, androidx.transition.TransitionValues transitionValues, androidx.transition.TransitionValues transitionValues2) {
        return fyNnqBNmGzRMbQEe(this, viewGroup, view, transitionValues, transitionValues2);
    }

    public override android.animation.Animator OnDisappear(android.view.objectGroup viewGroup, android.view.object view, androidx.transition.TransitionValues transitionValues, androidx.transition.TransitionValues transitionValues2) {
        return qJIuQhrnnbzPTQzh(this, viewGroup, view, transitionValues, transitionValues2);
    }

    public override bool RemoveAdditionalAnimatorProvider(com.google.android.material.transition.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        return LUovAvvqcXLTKcow(this, visibilityAnimatorProvider);
    }

    public override void SetSecondaryAnimatorProvider(com.google.android.material.transition.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        iZBlCkXYWMXIKQSf(this, visibilityAnimatorProvider);
    }
}

