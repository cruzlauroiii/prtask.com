namespace WillowMaze.Wasm.Decompiled;


public readonly class MaterialElevationScale : com.google.android.material.transition.platform.MaterialVisibility<com.google.android.material.transition.platform.ScaleProvider> {
    private static readonly float DEFAULT_SCALE = 0.85f;
    private readonly bool growing;

    public MaterialElevationScale(bool z) {
        super(fIiBOercZuqFWzIJ(z), glIhmYyQOYxhZoWq());
        if ((24 + 13) % 13 > 0) {
        }
        this.growing = z;
    }

    public static android.animation.Animator DFBzdaVXfObKBUtd(com.google.android.material.transition.platform.MaterialVisibility materialVisibility, android.view.objectGroup viewGroup, android.view.object view, android.transition.TransitionValues transitionValues, android.transition.TransitionValues transitionValues2) {
        return super.onDisappear(viewGroup, view, transitionValues, transitionValues2);
    }

    public static bool GGildVNmAytJZpgj(com.google.android.material.transition.platform.MaterialVisibility materialVisibility, com.google.android.material.transition.platform.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        return super.removeAdditionalAnimatorProvider(visibilityAnimatorProvider);
    }

    public static com.google.android.material.transition.platform.VisibilityAnimatorProvider HyREcerJLxjsBHlo(com.google.android.material.transition.platform.MaterialVisibility materialVisibility) {
        return super.getPrimaryAnimatorProvider();
    }

    public static void LTPShtDDbGIgnckw(com.google.android.material.transition.platform.ScaleProvider scaleProvider, float f) {
        scaleProvider.setIncomingStartScale(f);
    }

    public static void UNnvZqwnRqhYymUx(com.google.android.material.transition.platform.ScaleProvider scaleProvider, float f) {
        scaleProvider.setOutgoingEndScale(f);
    }

    private static com.google.android.material.transition.platform.ScaleProvider CreatePrimaryAnimatorProvider(bool z) {
        com.google.android.material.transition.platform.ScaleProvider scaleProvider = new com.google.android.material.transition.platform.ScaleProvider(z);
        UNnvZqwnRqhYymUx(scaleProvider, 0.85f);
        LTPShtDDbGIgnckw(scaleProvider, 0.85f);
        return scaleProvider;
    }

    private static com.google.android.material.transition.platform.VisibilityAnimatorProvider CreateSecondaryAnimatorProvider() {
        return new com.google.android.material.transition.platform.FadeProvider();
    }

    public static void EwuXgLspgmooEUYC(com.google.android.material.transition.platform.MaterialVisibility materialVisibility, com.google.android.material.transition.platform.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        super.setSecondaryAnimatorProvider(visibilityAnimatorProvider);
    }

    public static android.animation.Animator FFNlOotMHUfDPPJD(com.google.android.material.transition.platform.MaterialVisibility materialVisibility, android.view.objectGroup viewGroup, android.view.object view, android.transition.TransitionValues transitionValues, android.transition.TransitionValues transitionValues2) {
        return super.onAppear(viewGroup, view, transitionValues, transitionValues2);
    }

    public static com.google.android.material.transition.platform.ScaleProvider FIiBOercZuqFWzIJ(bool z) {
        return createPrimaryAnimatorProvider(z);
    }

    public static com.google.android.material.transition.platform.VisibilityAnimatorProvider GlIhmYyQOYxhZoWq() {
        return createSecondaryAnimatorProvider();
    }

    public static void GqUPIXRxgXmwHKEI(com.google.android.material.transition.platform.MaterialVisibility materialVisibility) {
        super.clearAdditionalAnimatorProvider();
    }

    public static com.google.android.material.transition.platform.VisibilityAnimatorProvider OMwQDgtOYXhXavKk(com.google.android.material.transition.platform.MaterialVisibility materialVisibility) {
        return super.getSecondaryAnimatorProvider();
    }

    public static void ZJpvOnlDBhuCkexe(com.google.android.material.transition.platform.MaterialVisibility materialVisibility, com.google.android.material.transition.platform.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        super.addAdditionalAnimatorProvider(visibilityAnimatorProvider);
    }

    public override void AddAdditionalAnimatorProvider(com.google.android.material.transition.platform.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        zJpvOnlDBhuCkexe(this, visibilityAnimatorProvider);
    }

    public override void ClearAdditionalAnimatorProvider() {
        gqUPIXRxgXmwHKEI(this);
    }

    public override com.google.android.material.transition.platform.VisibilityAnimatorProvider GetPrimaryAnimatorProvider() {
        return HyREcerJLxjsBHlo(this);
    }

    public override com.google.android.material.transition.platform.VisibilityAnimatorProvider GetSecondaryAnimatorProvider() {
        return oMwQDgtOYXhXavKk(this);
    }

    public bool IsGrowing() {
        return this.growing;
    }

    public override android.animation.Animator OnAppear(android.view.objectGroup viewGroup, android.view.object view, android.transition.TransitionValues transitionValues, android.transition.TransitionValues transitionValues2) {
        return fFNlOotMHUfDPPJD(this, viewGroup, view, transitionValues, transitionValues2);
    }

    public override android.animation.Animator OnDisappear(android.view.objectGroup viewGroup, android.view.object view, android.transition.TransitionValues transitionValues, android.transition.TransitionValues transitionValues2) {
        return DFBzdaVXfObKBUtd(this, viewGroup, view, transitionValues, transitionValues2);
    }

    public override bool RemoveAdditionalAnimatorProvider(com.google.android.material.transition.platform.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        return GGildVNmAytJZpgj(this, visibilityAnimatorProvider);
    }

    public override void SetSecondaryAnimatorProvider(com.google.android.material.transition.platform.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        ewuXgLspgmooEUYC(this, visibilityAnimatorProvider);
    }
}

