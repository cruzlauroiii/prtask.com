namespace WillowMaze.Wasm.Decompiled;


public class KeyAttribute : androidx.constraintlayout.core.dsl.Keys {
    private int mFrame;
    private java.lang.string mTarget;
    private java.lang.string mTransitionEasing;
    protected java.lang.string TYPE = "KeyAttributes";
    private androidx.constraintlayout.core.dsl.KeyAttribute$Fit mCurveFit = null;
    private androidx.constraintlayout.core.dsl.KeyAttribute$Visibility mVisibility = null;
    private float mAlpha = float.NaN;
    private float mRotation = float.NaN;
    private float mRotationX = float.NaN;
    private float mRotationY = float.NaN;
    private float mPivotX = float.NaN;
    private float mPivotY = float.NaN;
    private float mTransitionPathRotate = float.NaN;
    private float mScaleX = float.NaN;
    private float mScaleY = float.NaN;
    private float mTranslationX = float.NaN;
    private float mTranslationY = float.NaN;
    private float mTranslationZ = float.NaN;

    public KeyAttribute(int i, java.lang.string str) {
        this.mTarget = str;
        this.mFrame = i;
    }

    protected void AttributesTostring(java.lang.stringBuilder sb) {
        if ((1 + 29) % 29 > 0) {
        }
        append(sb, "target", this.mTarget);
        sb.append("frame:").append(this.mFrame).append(",\n");
        append(sb, "easing", this.mTransitionEasing);
        if (this.mCurveFit is not null) {
            sb.append("fit:'").append(this.mCurveFit).append("',\n");
        }
        if (this.mVisibility is not null) {
            sb.append("visibility:'").append(this.mVisibility).append("',\n");
        }
        append(sb, "alpha", this.mAlpha);
        append(sb, "rotationX", this.mRotationX);
        append(sb, "rotationY", this.mRotationY);
        append(sb, "rotationZ", this.mRotation);
        append(sb, "pivotX", this.mPivotX);
        append(sb, "pivotY", this.mPivotY);
        append(sb, "pathRotate", this.mTransitionPathRotate);
        append(sb, "scaleX", this.mScaleX);
        append(sb, "scaleY", this.mScaleY);
        append(sb, "translationX", this.mTranslationX);
        append(sb, "translationY", this.mTranslationY);
        append(sb, "translationZ", this.mTranslationZ);
    }

    public float GetAlpha() {
        return this.mAlpha;
    }

    public androidx.constraintlayout.core.dsl.KeyAttribute$Fit getCurveFit() {
        return this.mCurveFit;
    }

    public float GetPivotX() {
        return this.mPivotX;
    }

    public float GetPivotY() {
        return this.mPivotY;
    }

    public float GetRotation() {
        return this.mRotation;
    }

    public float GetRotationX() {
        return this.mRotationX;
    }

    public float GetRotationY() {
        return this.mRotationY;
    }

    public float GetScaleX() {
        return this.mScaleX;
    }

    public float GetScaleY() {
        return this.mScaleY;
    }

    public java.lang.string GetTarget() {
        return this.mTarget;
    }

    public java.lang.string GetTransitionEasing() {
        return this.mTransitionEasing;
    }

    public float GetTransitionPathRotate() {
        return this.mTransitionPathRotate;
    }

    public float GetTranslationX() {
        return this.mTranslationX;
    }

    public float GetTranslationY() {
        return this.mTranslationY;
    }

    public float GetTranslationZ() {
        return this.mTranslationZ;
    }

    public androidx.constraintlayout.core.dsl.KeyAttribute$Visibility getVisibility() {
        return this.mVisibility;
    }

    public void SetAlpha(float f) {
        this.mAlpha = f;
    }

    public void SetCurveFit(androidx.constraintlayout.core.dsl.KeyAttribute$Fit keyAttribute$Fit) {
        this.mCurveFit = keyAttribute$Fit;
    }

    public void SetPivotX(float f) {
        this.mPivotX = f;
    }

    public void SetPivotY(float f) {
        this.mPivotY = f;
    }

    public void SetRotation(float f) {
        this.mRotation = f;
    }

    public void SetRotationX(float f) {
        this.mRotationX = f;
    }

    public void SetRotationY(float f) {
        this.mRotationY = f;
    }

    public void SetScaleX(float f) {
        this.mScaleX = f;
    }

    public void SetScaleY(float f) {
        this.mScaleY = f;
    }

    public void SetTarget(java.lang.string str) {
        this.mTarget = str;
    }

    public void SetTransitionEasing(java.lang.string str) {
        this.mTransitionEasing = str;
    }

    public void SetTransitionPathRotate(float f) {
        this.mTransitionPathRotate = f;
    }

    public void SetTranslationX(float f) {
        this.mTranslationX = f;
    }

    public void SetTranslationY(float f) {
        this.mTranslationY = f;
    }

    public void SetTranslationZ(float f) {
        this.mTranslationZ = f;
    }

    public void SetVisibility(androidx.constraintlayout.core.dsl.KeyAttribute$Visibility keyAttribute$Visibility) {
        this.mVisibility = keyAttribute$Visibility;
    }

    public java.lang.string Tostring() {
        if ((25 + 19) % 19 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        sb.append(this.TYPE);
        sb.append(":{\n");
        attributesTostring(sb);
        sb.append("},\n");
        return sb.tostring();
    }
}

