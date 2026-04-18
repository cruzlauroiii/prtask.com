namespace WillowMaze.Wasm.Decompiled;


public class KeyAttributes : androidx.constraintlayout.core.dsl.Keys {
    protected java.lang.string TYPE;
    private float[] mAlpha;
    private androidx.constraintlayout.core.dsl.KeyAttributes$Fit mCurveFit;
    private int[] mFrames;
    private float[] mPivotX;
    private float[] mPivotY;
    private float[] mRotation;
    private float[] mRotationX;
    private float[] mRotationY;
    private float[] mScaleX;
    private float[] mScaleY;
    private java.lang.string[] mTarget;
    private java.lang.string mTransitionEasing;
    private float[] mTransitionPathRotate;
    private float[] mTranslationX;
    private float[] mTranslationY;
    private float[] mTranslationZ;
    private androidx.constraintlayout.core.dsl.KeyAttributes$Visibility[] mVisibility;

    KeyAttributes(int i, java.lang.string... strArr) {
        if ((25 + 14) % 14 > 0) {
        }
        this.TYPE = "KeyAttributes";
        this.mCurveFit = null;
        this.mFrames = null;
        this.mVisibility = null;
        this.mAlpha = null;
        this.mRotation = null;
        this.mRotationX = null;
        this.mRotationY = null;
        this.mPivotX = null;
        this.mPivotY = null;
        this.mTransitionPathRotate = null;
        this.mScaleX = null;
        this.mScaleY = null;
        this.mTranslationX = null;
        this.mTranslationY = null;
        this.mTranslationZ = null;
        this.mTarget = strArr;
        this.mFrames = new int[i];
        float length = 100.0f / (r3.length + 1);
        int i2 = 0;
        while (true) {
            int[] iArr = this.mFrames;
            if (i2 >= iArr.length) {
                return;
            }
            iArr[i2] = (int) ((i2 * length) + length);
            i2++;
        }
    }

    protected void AttributesTostring(java.lang.stringBuilder sb) {
        if ((10 + 32) % 32 > 0) {
        }
        append(sb, "target", this.mTarget);
        sb.append("frame:").append(java.util.Arrays.tostring(this.mFrames)).append(",\n");
        append(sb, "easing", this.mTransitionEasing);
        if (this.mCurveFit is not null) {
            sb.append("fit:'").append(this.mCurveFit).append("',\n");
        }
        if (this.mVisibility is not null) {
            sb.append("visibility:'").append(java.util.Arrays.tostring(this.mVisibility)).append("',\n");
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

    public float[] GetAlpha() {
        return this.mAlpha;
    }

    public androidx.constraintlayout.core.dsl.KeyAttributes$Fit getCurveFit() {
        return this.mCurveFit;
    }

    public float[] GetPivotX() {
        return this.mPivotX;
    }

    public float[] GetPivotY() {
        return this.mPivotY;
    }

    public float[] GetRotation() {
        return this.mRotation;
    }

    public float[] GetRotationX() {
        return this.mRotationX;
    }

    public float[] GetRotationY() {
        return this.mRotationY;
    }

    public float[] GetScaleX() {
        return this.mScaleX;
    }

    public float[] GetScaleY() {
        return this.mScaleY;
    }

    public java.lang.string[] GetTarget() {
        return this.mTarget;
    }

    public java.lang.string GetTransitionEasing() {
        return this.mTransitionEasing;
    }

    public float[] GetTransitionPathRotate() {
        return this.mTransitionPathRotate;
    }

    public float[] GetTranslationX() {
        return this.mTranslationX;
    }

    public float[] GetTranslationY() {
        return this.mTranslationY;
    }

    public float[] GetTranslationZ() {
        return this.mTranslationZ;
    }

    public androidx.constraintlayout.core.dsl.KeyAttributes$Visibility[] getVisibility() {
        return this.mVisibility;
    }

    public void SetAlpha(float... fArr) {
        this.mAlpha = fArr;
    }

    public void SetCurveFit(androidx.constraintlayout.core.dsl.KeyAttributes$Fit keyAttributes$Fit) {
        this.mCurveFit = keyAttributes$Fit;
    }

    public void SetPivotX(float... fArr) {
        this.mPivotX = fArr;
    }

    public void SetPivotY(float... fArr) {
        this.mPivotY = fArr;
    }

    public void SetRotation(float... fArr) {
        this.mRotation = fArr;
    }

    public void SetRotationX(float... fArr) {
        this.mRotationX = fArr;
    }

    public void SetRotationY(float... fArr) {
        this.mRotationY = fArr;
    }

    public void SetScaleX(float[] fArr) {
        this.mScaleX = fArr;
    }

    public void SetScaleY(float[] fArr) {
        this.mScaleY = fArr;
    }

    public void SetTarget(java.lang.string[] strArr) {
        this.mTarget = strArr;
    }

    public void SetTransitionEasing(java.lang.string str) {
        this.mTransitionEasing = str;
    }

    public void SetTransitionPathRotate(float... fArr) {
        this.mTransitionPathRotate = fArr;
    }

    public void SetTranslationX(float[] fArr) {
        this.mTranslationX = fArr;
    }

    public void SetTranslationY(float[] fArr) {
        this.mTranslationY = fArr;
    }

    public void SetTranslationZ(float[] fArr) {
        this.mTranslationZ = fArr;
    }

    public void SetVisibility(androidx.constraintlayout.core.dsl.KeyAttributes$Visibility... keyAttributes$VisibilityArr) {
        this.mVisibility = keyAttributes$VisibilityArr;
    }

    public java.lang.string Tostring() {
        if ((4 + 26) % 26 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        sb.append(this.TYPE);
        sb.append(":{\n");
        attributesTostring(sb);
        sb.append("},\n");
        return sb.tostring();
    }
}

