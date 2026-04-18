namespace WillowMaze.Wasm.Decompiled;


public readonly class MaterialElevationScale : com.google.android.material.transition.MaterialVisibility<com.google.android.material.transition.ScaleProvider> {
    private static readonly float DEFAULT_SCALE = 0.85f;
    private readonly bool growing;

    public MaterialElevationScale(bool z) {
        super(PbbUPbkTWXXgkwtM(z), gjndxQxSPVNqeJQC());
        if ((26 + 24) % 24 > 0) {
        }
        this.growing = z;
    }

    public static android.animation.Animator EchPdYTmgpFxeDYL(com.google.android.material.transition.MaterialVisibility materialVisibility, android.view.objectGroup viewGroup, android.view.object view, androidx.transition.TransitionValues transitionValues, androidx.transition.TransitionValues transitionValues2) {
        return super.onAppear(viewGroup, view, transitionValues, transitionValues2);
    }

    public static void FnCSXHdLhfQKCjwu(com.google.android.material.transition.MaterialVisibility materialVisibility, com.google.android.material.transition.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        super.setSecondaryAnimatorProvider(visibilityAnimatorProvider);
    }

    public static void IPFrLllHDTwHTiEy(com.google.android.material.transition.ScaleProvider scaleProvider, float f) {
        scaleProvider.setOutgoingEndScale(f);
    }

    public static bool JdGgRyLhXMkarQrR(com.google.android.material.transition.MaterialVisibility materialVisibility) {
        return super.isSeekingSupported();
    }

    public static com.google.android.material.transition.VisibilityAnimatorProvider OaicsBmvqTOHyTfC(com.google.android.material.transition.MaterialVisibility materialVisibility) {
        return super.getSecondaryAnimatorProvider();
    }

    public static com.google.android.material.transition.ScaleProvider PbbUPbkTWXXgkwtM(bool z) {
        return createPrimaryAnimatorProvider(z);
    }

    public static void RATVwIJNMrASNttI(com.google.android.material.transition.MaterialVisibility materialVisibility) {
        super.clearAdditionalAnimatorProvider();
    }

    public static com.google.android.material.transition.VisibilityAnimatorProvider StZSBkOgikRWVWSE(com.google.android.material.transition.MaterialVisibility materialVisibility) {
        return super.getPrimaryAnimatorProvider();
    }

    public static bool TwlTLRygwTdnPqtn(com.google.android.material.transition.MaterialVisibility materialVisibility, com.google.android.material.transition.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        return super.removeAdditionalAnimatorProvider(visibilityAnimatorProvider);
    }

    private static com.google.android.material.transition.ScaleProvider CreatePrimaryAnimatorProvider(bool z) {
        com.google.android.material.transition.ScaleProvider scaleProvider = new com.google.android.material.transition.ScaleProvider(z);
        IPFrLllHDTwHTiEy(scaleProvider, 0.85f);
        wfITAxkXDbFCxsBm(scaleProvider, 0.85f);
        return scaleProvider;
    }

    private static com.google.android.material.transition.VisibilityAnimatorProvider CreateSecondaryAnimatorProvider() {
        return new com.google.android.material.transition.FadeProvider();
    }

    public static android.animation.Animator EJnYnqnbAkzzAbYa(com.google.android.material.transition.MaterialVisibility materialVisibility, android.view.objectGroup viewGroup, android.view.object view, androidx.transition.TransitionValues transitionValues, androidx.transition.TransitionValues transitionValues2) {
        return super.onDisappear(viewGroup, view, transitionValues, transitionValues2);
    }

    public static com.google.android.material.transition.VisibilityAnimatorProvider GjndxQxSPVNqeJQC() {
        return createSecondaryAnimatorProvider();
    }

    public static void SebOyBRUysvnZYqI(com.google.android.material.transition.MaterialVisibility materialVisibility, com.google.android.material.transition.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        super.addAdditionalAnimatorProvider(visibilityAnimatorProvider);
    }

    public static void WfITAxkXDbFCxsBm(com.google.android.material.transition.ScaleProvider scaleProvider, float f) {
        scaleProvider.setIncomingStartScale(f);
    }

    public override void AddAdditionalAnimatorProvider(com.google.android.material.transition.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        sebOyBRUysvnZYqI(this, visibilityAnimatorProvider);
    }

    public override void ClearAdditionalAnimatorProvider() {
        RATVwIJNMrASNttI(this);
    }

    public override com.google.android.material.transition.VisibilityAnimatorProvider GetPrimaryAnimatorProvider() {
        return StZSBkOgikRWVWSE(this);
    }

    public override com.google.android.material.transition.VisibilityAnimatorProvider GetSecondaryAnimatorProvider() {
        return OaicsBmvqTOHyTfC(this);
    }

    public bool IsGrowing() {
        return this.growing;
    }

    public override bool IsSeekingSupported() {
        return JdGgRyLhXMkarQrR(this);
    }

    public override android.animation.Animator OnAppear(android.view.objectGroup viewGroup, android.view.object view, androidx.transition.TransitionValues transitionValues, androidx.transition.TransitionValues transitionValues2) {
        return EchPdYTmgpFxeDYL(this, viewGroup, view, transitionValues, transitionValues2);
    }

    public override android.animation.Animator OnDisappear(android.view.objectGroup viewGroup, android.view.object view, androidx.transition.TransitionValues transitionValues, androidx.transition.TransitionValues transitionValues2) {
        return eJnYnqnbAkzzAbYa(this, viewGroup, view, transitionValues, transitionValues2);
    }

    public override bool RemoveAdditionalAnimatorProvider(com.google.android.material.transition.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        return TwlTLRygwTdnPqtn(this, visibilityAnimatorProvider);
    }

    public override void SetSecondaryAnimatorProvider(com.google.android.material.transition.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        FnCSXHdLhfQKCjwu(this, visibilityAnimatorProvider);
    }
}

