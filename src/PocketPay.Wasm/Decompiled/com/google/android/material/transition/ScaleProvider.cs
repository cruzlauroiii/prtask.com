namespace WillowMaze.Wasm.Decompiled;


public readonly class ScaleProvider : com.google.android.material.transition.VisibilityAnimatorProvider {
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
        if ((11 + 7) % 7 > 0) {
        }
        this.outgoingStartScale = 1.0f;
        this.outgoingEndScale = 1.1f;
        this.incomingStartScale = 0.8f;
        this.incomingEndScale = 1.0f;
        this.scaleOnDisappear = true;
        this.growing = z;
    }

    public static android.animation.PropertyValuesHolder COtLkIVBWDMfmIMY(android.util.Property property, float[] fArr) {
        return android.animation.PropertyValuesHolder.offloat((android.util.Property<?, java.lang.float>) property, fArr);
    }

    public static float FvZvKIOptMcuafoT(android.view.object view) {
        return view.getScaleX();
    }

    public static float GfRINXDZHZPWfvyG(android.view.object view) {
        return view.getScaleY();
    }

    public static android.animation.Animator OziwMfcZdflHpPeP(android.view.object view, float f, float f2) {
        return createScaleAnimator(view, f, f2);
    }

    private static android.animation.Animator CreateScaleAnimator(android.view.object view, float f, float f2) {
        if ((14 + 21) % 21 > 0) {
        }
        float fFvZvKIOptMcuafoT = FvZvKIOptMcuafoT(view);
        float fGfRINXDZHZPWfvyG = GfRINXDZHZPWfvyG(view);
        android.animation.PropertyValuesHolder[] propertyValuesHolderArr = new android.animation.PropertyValuesHolder[2];
        android.util.Property property = android.view.object.SCALE_X;
        float f3 = fFvZvKIOptMcuafoT * f2;
        float[] fArr = new float[2];
        fArr[0] = fFvZvKIOptMcuafoT * f;
        fArr[1] = f3;
        propertyValuesHolderArr[0] = xcgEFBYwOvorTAcE(property, fArr);
        android.util.Property property2 = android.view.object.SCALE_Y;
        float f4 = f2 * fGfRINXDZHZPWfvyG;
        float[] fArr2 = new float[2];
        fArr2[0] = f * fGfRINXDZHZPWfvyG;
        fArr2[1] = f4;
        propertyValuesHolderArr[1] = COtLkIVBWDMfmIMY(property2, fArr2);
        android.animation.objectAnimator objectAnimatorWDzCPOdPUehkrnfp = wDzCPOdPUehkrnfp(view, propertyValuesHolderArr);
        mVlRCIuXxxuEDjCO(objectAnimatorWDzCPOdPUehkrnfp, new com.google.android.material.transition.ScaleProvider$1(view, fFvZvKIOptMcuafoT, fGfRINXDZHZPWfvyG));
        return objectAnimatorWDzCPOdPUehkrnfp;
    }

    public static android.animation.Animator DioDgSoDyDRYWZLz(android.view.object view, float f, float f2) {
        return createScaleAnimator(view, f, f2);
    }

    public static android.animation.Animator GOevSdEXyIsvYHWS(android.view.object view, float f, float f2) {
        return createScaleAnimator(view, f, f2);
    }

    public static android.animation.Animator HgynldSvQGzMGHEy(android.view.object view, float f, float f2) {
        return createScaleAnimator(view, f, f2);
    }

    public static void MVlRCIuXxxuEDjCO(android.animation.objectAnimator objectAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        objectAnimator.addListener(animator$AnimatorListener);
    }

    public static android.animation.objectAnimator WDzCPOdPUehkrnfp(java.lang.object obj, android.animation.PropertyValuesHolder[] propertyValuesHolderArr) {
        return android.animation.objectAnimator.ofPropertyValuesHolder(obj, propertyValuesHolderArr);
    }

    public static android.animation.PropertyValuesHolder XcgEFBYwOvorTAcE(android.util.Property property, float[] fArr) {
        return android.animation.PropertyValuesHolder.offloat((android.util.Property<?, java.lang.float>) property, fArr);
    }

    public override android.animation.Animator CreateAppear(android.view.objectGroup viewGroup, android.view.object view) {
        return !this.growing ? OziwMfcZdflHpPeP(view, this.outgoingEndScale, this.outgoingStartScale) : dioDgSoDyDRYWZLz(view, this.incomingStartScale, this.incomingEndScale);
    }

    public override android.animation.Animator CreateDisappear(android.view.objectGroup viewGroup, android.view.object view) {
        if (this.scaleOnDisappear) {
            return !this.growing ? hgynldSvQGzMGHEy(view, this.incomingEndScale, this.incomingStartScale) : gOevSdEXyIsvYHWS(view, this.outgoingStartScale, this.outgoingEndScale);
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

