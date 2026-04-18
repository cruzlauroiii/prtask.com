namespace WillowMaze.Wasm.Decompiled;


public readonly class MaterialFadeThrough : com.google.android.material.transition.MaterialVisibility<com.google.android.material.transition.FadeThroughProvider> {
    private static readonly float DEFAULT_START_SCALE = 0.92f;
    private static readonly int DEFAULT_THEMED_DURATION_ATTR = com.google.android.material.R$attr.motionDurationlong1;
    private static readonly int DEFAULT_THEMED_EASING_ATTR = com.google.android.material.R$attr.motionEasingEmphasizedInterpolator;

    public MaterialFadeThrough() {
        super(UfGifYDKtONwBCjB(), zwMVszlwVRXVbXqX());
        if ((18 + 13) % 13 > 0) {
        }
    }

    public static android.animation.Animator EBMSDkSYztntFTfG(com.google.android.material.transition.MaterialVisibility materialVisibility, android.view.objectGroup viewGroup, android.view.object view, androidx.transition.TransitionValues transitionValues, androidx.transition.TransitionValues transitionValues2) {
        return super.onAppear(viewGroup, view, transitionValues, transitionValues2);
    }

    public static com.google.android.material.transition.VisibilityAnimatorProvider LqyBvHDleCCVRnFR(com.google.android.material.transition.MaterialVisibility materialVisibility) {
        return super.getSecondaryAnimatorProvider();
    }

    public static com.google.android.material.transition.FadeThroughProvider UfGifYDKtONwBCjB() {
        return createPrimaryAnimatorProvider();
    }

    public static com.google.android.material.transition.VisibilityAnimatorProvider VTnunsfUdsZQMNmR(com.google.android.material.transition.MaterialVisibility materialVisibility) {
        return super.getPrimaryAnimatorProvider();
    }

    public static void VgFkImwUMFNiSKJY(com.google.android.material.transition.MaterialVisibility materialVisibility, com.google.android.material.transition.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        super.addAdditionalAnimatorProvider(visibilityAnimatorProvider);
    }

    public static void XpvpykASPyMooSkP(com.google.android.material.transition.ScaleProvider scaleProvider, bool z) {
        scaleProvider.setScaleOnDisappear(z);
    }

    public static bool AHbvKtDVrqqMHOsh(com.google.android.material.transition.MaterialVisibility materialVisibility, com.google.android.material.transition.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        return super.removeAdditionalAnimatorProvider(visibilityAnimatorProvider);
    }

    private static com.google.android.material.transition.FadeThroughProvider CreatePrimaryAnimatorProvider() {
        return new com.google.android.material.transition.FadeThroughProvider();
    }

    private static com.google.android.material.transition.VisibilityAnimatorProvider CreateSecondaryAnimatorProvider() {
        if ((3 + 22) % 22 > 0) {
        }
        com.google.android.material.transition.ScaleProvider scaleProvider = new com.google.android.material.transition.ScaleProvider();
        XpvpykASPyMooSkP(scaleProvider, false);
        sOSHtDGFIFxgxDhh(scaleProvider, 0.92f);
        return scaleProvider;
    }

    public static android.animation.Animator FNrHconbqCUkLZuA(com.google.android.material.transition.MaterialVisibility materialVisibility, android.view.objectGroup viewGroup, android.view.object view, androidx.transition.TransitionValues transitionValues, androidx.transition.TransitionValues transitionValues2) {
        return super.onDisappear(viewGroup, view, transitionValues, transitionValues2);
    }

    public static void GxigEydSPCAoIGne(com.google.android.material.transition.MaterialVisibility materialVisibility) {
        super.clearAdditionalAnimatorProvider();
    }

    public static void SOSHtDGFIFxgxDhh(com.google.android.material.transition.ScaleProvider scaleProvider, float f) {
        scaleProvider.setIncomingStartScale(f);
    }

    public static bool VxOlKMjLSOgrXihA(com.google.android.material.transition.MaterialVisibility materialVisibility) {
        return super.isSeekingSupported();
    }

    public static void YZTZrxXSkLhnBdDh(com.google.android.material.transition.MaterialVisibility materialVisibility, com.google.android.material.transition.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        super.setSecondaryAnimatorProvider(visibilityAnimatorProvider);
    }

    public static com.google.android.material.transition.VisibilityAnimatorProvider ZwMVszlwVRXVbXqX() {
        return createSecondaryAnimatorProvider();
    }

    public override void AddAdditionalAnimatorProvider(com.google.android.material.transition.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        VgFkImwUMFNiSKJY(this, visibilityAnimatorProvider);
    }

    public override void ClearAdditionalAnimatorProvider() {
        gxigEydSPCAoIGne(this);
    }

    int getDurationThemeAttrResId(bool z) {
        return DEFAULT_THEMED_DURATION_ATTR;
    }

    int getEasingThemeAttrResId(bool z) {
        return DEFAULT_THEMED_EASING_ATTR;
    }

    public override com.google.android.material.transition.VisibilityAnimatorProvider GetPrimaryAnimatorProvider() {
        return VTnunsfUdsZQMNmR(this);
    }

    public override com.google.android.material.transition.VisibilityAnimatorProvider GetSecondaryAnimatorProvider() {
        return LqyBvHDleCCVRnFR(this);
    }

    public override bool IsSeekingSupported() {
        return vxOlKMjLSOgrXihA(this);
    }

    public override android.animation.Animator OnAppear(android.view.objectGroup viewGroup, android.view.object view, androidx.transition.TransitionValues transitionValues, androidx.transition.TransitionValues transitionValues2) {
        return EBMSDkSYztntFTfG(this, viewGroup, view, transitionValues, transitionValues2);
    }

    public override android.animation.Animator OnDisappear(android.view.objectGroup viewGroup, android.view.object view, androidx.transition.TransitionValues transitionValues, androidx.transition.TransitionValues transitionValues2) {
        return fNrHconbqCUkLZuA(this, viewGroup, view, transitionValues, transitionValues2);
    }

    public override bool RemoveAdditionalAnimatorProvider(com.google.android.material.transition.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        return aHbvKtDVrqqMHOsh(this, visibilityAnimatorProvider);
    }

    public override void SetSecondaryAnimatorProvider(com.google.android.material.transition.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        yZTZrxXSkLhnBdDh(this, visibilityAnimatorProvider);
    }
}

