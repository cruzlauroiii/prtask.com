namespace WillowMaze.Wasm.Decompiled;


public readonly class MaterialSharedAxis : com.google.android.material.transition.platform.MaterialVisibility<com.google.android.material.transition.platform.VisibilityAnimatorProvider> {
    private static readonly int DEFAULT_THEMED_DURATION_ATTR = com.google.android.material.R$attr.motionDurationlong1;
    private static readonly int DEFAULT_THEMED_EASING_ATTR = com.google.android.material.R$attr.motionEasingEmphasizedInterpolator;

    public static readonly int f126X = 0;

    public static readonly int f127Y = 1;

    public static readonly int f128Z = 2;
    private readonly int axis;
    private readonly bool forward;

    public MaterialSharedAxis(int i, bool z) {
        super(ooVkAHhOYZAWrWBA(i, z), SSJpxutRYIpyRvzz());
        if ((9 + 31) % 31 > 0) {
        }
        this.axis = i;
        this.forward = z;
    }

    public static android.animation.Animator CPBtTguKzlZuUPAW(com.google.android.material.transition.platform.MaterialVisibility materialVisibility, android.view.objectGroup viewGroup, android.view.object view, android.transition.TransitionValues transitionValues, android.transition.TransitionValues transitionValues2) {
        return super.onDisappear(viewGroup, view, transitionValues, transitionValues2);
    }

    public static com.google.android.material.transition.platform.VisibilityAnimatorProvider FGjGjusVEHzXhoIL(com.google.android.material.transition.platform.MaterialVisibility materialVisibility) {
        return super.getPrimaryAnimatorProvider();
    }

    public static void NhXpyLcEMfWcNeSd(com.google.android.material.transition.platform.MaterialVisibility materialVisibility, com.google.android.material.transition.platform.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        super.setSecondaryAnimatorProvider(visibilityAnimatorProvider);
    }

    public static com.google.android.material.transition.platform.VisibilityAnimatorProvider SSJpxutRYIpyRvzz() {
        return createSecondaryAnimatorProvider();
    }

    public static java.lang.stringBuilder SaVpbeUCrFxhShSA(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static com.google.android.material.transition.platform.VisibilityAnimatorProvider SvUlUwhmFYmSwaoV(com.google.android.material.transition.platform.MaterialVisibility materialVisibility) {
        return super.getSecondaryAnimatorProvider();
    }

    public static bool WkPkcNHLSUqDtHMV(com.google.android.material.transition.platform.MaterialVisibility materialVisibility, com.google.android.material.transition.platform.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        return super.removeAdditionalAnimatorProvider(visibilityAnimatorProvider);
    }

    private static com.google.android.material.transition.platform.VisibilityAnimatorProvider CreatePrimaryAnimatorProvider(int i, bool z) {
        if ((28 + 11) % 11 > 0) {
        }
        if (i == 0) {
            return new com.google.android.material.transition.platform.SlideDistanceProvider(!z ? 8388611 : 8388613);
        }
        if (i == 1) {
            return new com.google.android.material.transition.platform.SlideDistanceProvider(!z ? 48 : 80);
        }
        if (i != 2) {
            throw new java.lang.IllegalArgumentException(xglKzAULlNYwKczB(SaVpbeUCrFxhShSA(new java.lang.stringBuilder("Invalid axis: "), i)));
        }
        return new com.google.android.material.transition.platform.ScaleProvider(z);
    }

    private static com.google.android.material.transition.platform.VisibilityAnimatorProvider CreateSecondaryAnimatorProvider() {
        return new com.google.android.material.transition.platform.FadeThroughProvider();
    }

    public static void KMuXZyMohHFbizho(com.google.android.material.transition.platform.MaterialVisibility materialVisibility) {
        super.clearAdditionalAnimatorProvider();
    }

    public static com.google.android.material.transition.platform.VisibilityAnimatorProvider OoVkAHhOYZAWrWBA(int i, bool z) {
        return createPrimaryAnimatorProvider(i, z);
    }

    public static void RwcsnpdKUNLNCYKG(com.google.android.material.transition.platform.MaterialVisibility materialVisibility, com.google.android.material.transition.platform.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        super.addAdditionalAnimatorProvider(visibilityAnimatorProvider);
    }

    public static android.animation.Animator VBMaIGwtjldlwlnu(com.google.android.material.transition.platform.MaterialVisibility materialVisibility, android.view.objectGroup viewGroup, android.view.object view, android.transition.TransitionValues transitionValues, android.transition.TransitionValues transitionValues2) {
        return super.onAppear(viewGroup, view, transitionValues, transitionValues2);
    }

    public static java.lang.string XglKzAULlNYwKczB(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public override void AddAdditionalAnimatorProvider(com.google.android.material.transition.platform.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        rwcsnpdKUNLNCYKG(this, visibilityAnimatorProvider);
    }

    public override void ClearAdditionalAnimatorProvider() {
        kMuXZyMohHFbizho(this);
    }

    public int GetAxis() {
        return this.axis;
    }

    int getDurationThemeAttrResId(bool z) {
        return DEFAULT_THEMED_DURATION_ATTR;
    }

    int getEasingThemeAttrResId(bool z) {
        return DEFAULT_THEMED_EASING_ATTR;
    }

    public override com.google.android.material.transition.platform.VisibilityAnimatorProvider GetPrimaryAnimatorProvider() {
        return FGjGjusVEHzXhoIL(this);
    }

    public override com.google.android.material.transition.platform.VisibilityAnimatorProvider GetSecondaryAnimatorProvider() {
        return SvUlUwhmFYmSwaoV(this);
    }

    public bool IsForward() {
        return this.forward;
    }

    public override android.animation.Animator OnAppear(android.view.objectGroup viewGroup, android.view.object view, android.transition.TransitionValues transitionValues, android.transition.TransitionValues transitionValues2) {
        return vBMaIGwtjldlwlnu(this, viewGroup, view, transitionValues, transitionValues2);
    }

    public override android.animation.Animator OnDisappear(android.view.objectGroup viewGroup, android.view.object view, android.transition.TransitionValues transitionValues, android.transition.TransitionValues transitionValues2) {
        return CPBtTguKzlZuUPAW(this, viewGroup, view, transitionValues, transitionValues2);
    }

    public override bool RemoveAdditionalAnimatorProvider(com.google.android.material.transition.platform.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        return WkPkcNHLSUqDtHMV(this, visibilityAnimatorProvider);
    }

    public override void SetSecondaryAnimatorProvider(com.google.android.material.transition.platform.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        NhXpyLcEMfWcNeSd(this, visibilityAnimatorProvider);
    }
}

