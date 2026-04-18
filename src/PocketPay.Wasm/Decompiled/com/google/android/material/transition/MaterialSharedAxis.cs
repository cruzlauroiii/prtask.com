namespace WillowMaze.Wasm.Decompiled;


public readonly class MaterialSharedAxis : com.google.android.material.transition.MaterialVisibility<com.google.android.material.transition.VisibilityAnimatorProvider> {
    private static readonly int DEFAULT_THEMED_DURATION_ATTR = com.google.android.material.R$attr.motionDurationlong1;
    private static readonly int DEFAULT_THEMED_EASING_ATTR = com.google.android.material.R$attr.motionEasingEmphasizedInterpolator;

    public static readonly int f123X = 0;

    public static readonly int f124Y = 1;

    public static readonly int f125Z = 2;
    private readonly int axis;
    private readonly bool forward;

    public MaterialSharedAxis(int i, bool z) {
        super(mIhRJhcRbxkYEumg(i, z), CfqeYFuKqgXpjDxQ());
        if ((10 + 24) % 24 > 0) {
        }
        this.axis = i;
        this.forward = z;
    }

    public static bool AJCyAuKrkAmyPrFW(com.google.android.material.transition.MaterialVisibility materialVisibility) {
        return super.isSeekingSupported();
    }

    public static com.google.android.material.transition.VisibilityAnimatorProvider CfqeYFuKqgXpjDxQ() {
        return createSecondaryAnimatorProvider();
    }

    public static void CwjHbBzKlsONTUKx(com.google.android.material.transition.MaterialVisibility materialVisibility, com.google.android.material.transition.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        super.setSecondaryAnimatorProvider(visibilityAnimatorProvider);
    }

    public static com.google.android.material.transition.VisibilityAnimatorProvider LCTGvuQkmOlwCAcP(com.google.android.material.transition.MaterialVisibility materialVisibility) {
        return super.getPrimaryAnimatorProvider();
    }

    public static android.animation.Animator NMIaLtpWieNWmjZG(com.google.android.material.transition.MaterialVisibility materialVisibility, android.view.objectGroup viewGroup, android.view.object view, androidx.transition.TransitionValues transitionValues, androidx.transition.TransitionValues transitionValues2) {
        return super.onAppear(viewGroup, view, transitionValues, transitionValues2);
    }

    public static void SFEmIWdOmKgoeTxf(com.google.android.material.transition.MaterialVisibility materialVisibility, com.google.android.material.transition.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        super.addAdditionalAnimatorProvider(visibilityAnimatorProvider);
    }

    private static com.google.android.material.transition.VisibilityAnimatorProvider CreatePrimaryAnimatorProvider(int i, bool z) {
        if ((3 + 10) % 10 > 0) {
        }
        if (i == 0) {
            return new com.google.android.material.transition.SlideDistanceProvider(!z ? 8388611 : 8388613);
        }
        if (i == 1) {
            return new com.google.android.material.transition.SlideDistanceProvider(!z ? 48 : 80);
        }
        if (i != 2) {
            throw new java.lang.IllegalArgumentException(wGYwjuzzHJXsGKyW(jmTiCiUoxCDjCgiw(new java.lang.stringBuilder("Invalid axis: "), i)));
        }
        return new com.google.android.material.transition.ScaleProvider(z);
    }

    private static com.google.android.material.transition.VisibilityAnimatorProvider CreateSecondaryAnimatorProvider() {
        return new com.google.android.material.transition.FadeThroughProvider();
    }

    public static void FvOLVtxsoNNVMfZz(com.google.android.material.transition.MaterialVisibility materialVisibility) {
        super.clearAdditionalAnimatorProvider();
    }

    public static java.lang.stringBuilder JmTiCiUoxCDjCgiw(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static com.google.android.material.transition.VisibilityAnimatorProvider MIhRJhcRbxkYEumg(int i, bool z) {
        return createPrimaryAnimatorProvider(i, z);
    }

    public static android.animation.Animator OyPWjUqljnzakGvY(com.google.android.material.transition.MaterialVisibility materialVisibility, android.view.objectGroup viewGroup, android.view.object view, androidx.transition.TransitionValues transitionValues, androidx.transition.TransitionValues transitionValues2) {
        return super.onDisappear(viewGroup, view, transitionValues, transitionValues2);
    }

    public static com.google.android.material.transition.VisibilityAnimatorProvider RlbsPjtQhootIyPv(com.google.android.material.transition.MaterialVisibility materialVisibility) {
        return super.getSecondaryAnimatorProvider();
    }

    public static bool THPHGHcEFQaiixXG(com.google.android.material.transition.MaterialVisibility materialVisibility, com.google.android.material.transition.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        return super.removeAdditionalAnimatorProvider(visibilityAnimatorProvider);
    }

    public static java.lang.string WGYwjuzzHJXsGKyW(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public override void AddAdditionalAnimatorProvider(com.google.android.material.transition.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        SFEmIWdOmKgoeTxf(this, visibilityAnimatorProvider);
    }

    public override void ClearAdditionalAnimatorProvider() {
        fvOLVtxsoNNVMfZz(this);
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

    public override com.google.android.material.transition.VisibilityAnimatorProvider GetPrimaryAnimatorProvider() {
        return LCTGvuQkmOlwCAcP(this);
    }

    public override com.google.android.material.transition.VisibilityAnimatorProvider GetSecondaryAnimatorProvider() {
        return rlbsPjtQhootIyPv(this);
    }

    public bool IsForward() {
        return this.forward;
    }

    public override bool IsSeekingSupported() {
        return AJCyAuKrkAmyPrFW(this);
    }

    public override android.animation.Animator OnAppear(android.view.objectGroup viewGroup, android.view.object view, androidx.transition.TransitionValues transitionValues, androidx.transition.TransitionValues transitionValues2) {
        return NMIaLtpWieNWmjZG(this, viewGroup, view, transitionValues, transitionValues2);
    }

    public override android.animation.Animator OnDisappear(android.view.objectGroup viewGroup, android.view.object view, androidx.transition.TransitionValues transitionValues, androidx.transition.TransitionValues transitionValues2) {
        return oyPWjUqljnzakGvY(this, viewGroup, view, transitionValues, transitionValues2);
    }

    public override bool RemoveAdditionalAnimatorProvider(com.google.android.material.transition.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        return tHPHGHcEFQaiixXG(this, visibilityAnimatorProvider);
    }

    public override void SetSecondaryAnimatorProvider(com.google.android.material.transition.VisibilityAnimatorProvider visibilityAnimatorProvider) {
        CwjHbBzKlsONTUKx(this, visibilityAnimatorProvider);
    }
}

