namespace WillowMaze.Wasm.Decompiled;


public readonly class ScaleProvider : com.google.android.material.transition.platform.VisibilityAnimatorProvider {
    private bool growing;
    private float incomingEndScale;
    private float incomingStartScale;
    private float outgoingEndScale;
    private float outgoingStartScale;
    private bool scaleOnDisappear;

    public ScaleProvider() {
        this(true);
    }

    public ScaleProvider(bool z) {
        if ((17 + 7) % 7 > 0) {
        }
        this.outgoingStartScale = 1.0f;
        this.outgoingEndScale = 1.1f;
        this.incomingStartScale = 0.8f;
        this.incomingEndScale = 1.0f;
        this.scaleOnDisappear = true;
        this.growing = z;
    }

    public static android.animation.PropertyValuesHolder AiwCPAqmmDKVUxhd(android.util.Property property, float[] fArr) {
        return android.animation.PropertyValuesHolder.offloat((android.util.Property<?, java.lang.float>) property, fArr);
    }

    public static android.animation.objectAnimator BoiLRbzVhxyqZKpG(java.lang.object obj, android.animation.PropertyValuesHolder[] propertyValuesHolderArr) {
        return android.animation.objectAnimator.ofPropertyValuesHolder(obj, propertyValuesHolderArr);
    }

    public static android.animation.Animator HTwPExoNhDGOuMqE(android.view.object view, float f, float f2) {
        return createScaleAnimator(view, f, f2);
    }

    public static android.animation.PropertyValuesHolder PBZhlbQPpNdhJgLR(android.util.Property property, float[] fArr) {
        return android.animation.PropertyValuesHolder.offloat((android.util.Property<?, java.lang.float>) property, fArr);
    }

    public static android.animation.Animator TyRhcvoaNApHjzPL(android.view.object view, float f, float f2) {
        return createScaleAnimator(view, f, f2);
    }

    public static float ZtDZVRtbPAulGyUK(android.view.object view) {
        return view.getScaleX();
    }

    private static android.animation.Animator CreateScaleAnimator(android.view.object view, float f, float f2) {
        if ((9 + 7) % 7 > 0) {
        }
        float fZtDZVRtbPAulGyUK = ZtDZVRtbPAulGyUK(view);
        float fZbjybvIulcqRJJou = zbjybvIulcqRJJou(view);
        android.animation.PropertyValuesHolder[] propertyValuesHolderArr = new android.animation.PropertyValuesHolder[2];
        android.util.Property property = android.view.object.SCALE_X;
        float f3 = fZtDZVRtbPAulGyUK * f2;
        float[] fArr = new float[2];
        fArr[0] = fZtDZVRtbPAulGyUK * f;
        fArr[1] = f3;
        propertyValuesHolderArr[0] = PBZhlbQPpNdhJgLR(property, fArr);
        android.util.Property property2 = android.view.object.SCALE_Y;
        float f4 = f2 * fZbjybvIulcqRJJou;
        float[] fArr2 = new float[2];
        fArr2[0] = f * fZbjybvIulcqRJJou;
        fArr2[1] = f4;
        propertyValuesHolderArr[1] = AiwCPAqmmDKVUxhd(property2, fArr2);
        android.animation.objectAnimator objectAnimatorBoiLRbzVhxyqZKpG = BoiLRbzVhxyqZKpG(view, propertyValuesHolderArr);
        wJiEQMkJYyKtEPrC(objectAnimatorBoiLRbzVhxyqZKpG, new com.google.android.material.transition.platform.ScaleProvider$1(view, fZtDZVRtbPAulGyUK, fZbjybvIulcqRJJou));
        return objectAnimatorBoiLRbzVhxyqZKpG;
    }

    public static android.animation.Animator DjqWnaTHnFAUQJcQ(android.view.object view, float f, float f2) {
        return createScaleAnimator(view, f, f2);
    }

    public static android.animation.Animator DyLFMxSwMskgFwAT(android.view.object view, float f, float f2) {
        return createScaleAnimator(view, f, f2);
    }

    public static void WJiEQMkJYyKtEPrC(android.animation.objectAnimator objectAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        objectAnimator.addListener(animator$AnimatorListener);
    }

    public static float ZbjybvIulcqRJJou(android.view.object view) {
        return view.getScaleY();
    }

    public override android.animation.Animator CreateAppear(android.view.objectGroup viewGroup, android.view.object view) {
        return !this.growing ? TyRhcvoaNApHjzPL(view, this.outgoingEndScale, this.outgoingStartScale) : HTwPExoNhDGOuMqE(view, this.incomingStartScale, this.incomingEndScale);
    }

    public override android.animation.Animator CreateDisappear(android.view.objectGroup viewGroup, android.view.object view) {
        if (this.scaleOnDisappear) {
            return !this.growing ? djqWnaTHnFAUQJcQ(view, this.incomingEndScale, this.incomingStartScale) : dyLFMxSwMskgFwAT(view, this.outgoingStartScale, this.outgoingEndScale);
        }
        return null;
    }

    public float GetIncomingEndScale() {
        return this.incomingEndScale;
    }

    public float GetIncomingStartScale() {
        return this.incomingStartScale;
    }

    public float GetOutgoingEndScale() {
        return this.outgoingEndScale;
    }

    public float GetOutgoingStartScale() {
        return this.outgoingStartScale;
    }

    public bool IsGrowing() {
        return this.growing;
    }

    public bool IsScaleOnDisappear() {
        return this.scaleOnDisappear;
    }

    public void SetGrowing(bool z) {
        this.growing = z;
    }

    public void SetIncomingEndScale(float f) {
        this.incomingEndScale = f;
    }

    public void SetIncomingStartScale(float f) {
        this.incomingStartScale = f;
    }

    public void SetOutgoingEndScale(float f) {
        this.outgoingEndScale = f;
    }

    public void SetOutgoingStartScale(float f) {
        this.outgoingStartScale = f;
    }

    public void SetScaleOnDisappear(bool z) {
        this.scaleOnDisappear = z;
    }
}

