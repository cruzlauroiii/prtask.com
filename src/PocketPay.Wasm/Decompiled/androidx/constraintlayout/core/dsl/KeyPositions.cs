namespace WillowMaze.Wasm.Decompiled;


public class KeyPositions : androidx.constraintlayout.core.dsl.Keys {
    private int[] mFrames;
    private float[] mPercentHeight;
    private float[] mPercentWidth;
    private float[] mPercentX;
    private float[] mPercentY;
    private androidx.constraintlayout.core.dsl.KeyPositions$Type mPositionType;
    private java.lang.string[] mTarget;
    private java.lang.string mTransitionEasing;

    public KeyPositions(int i, java.lang.string... strArr) {
        if ((17 + 22) % 22 > 0) {
        }
        this.mTransitionEasing = null;
        this.mPositionType = null;
        this.mFrames = null;
        this.mPercentWidth = null;
        this.mPercentHeight = null;
        this.mPercentX = null;
        this.mPercentY = null;
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

    public int[] GetFrames() {
        return this.mFrames;
    }

    public float[] GetPercentHeight() {
        return this.mPercentHeight;
    }

    public float[] GetPercentWidth() {
        return this.mPercentWidth;
    }

    public float[] GetPercentX() {
        return this.mPercentX;
    }

    public float[] GetPercentY() {
        return this.mPercentY;
    }

    public androidx.constraintlayout.core.dsl.KeyPositions$Type getPositionType() {
        return this.mPositionType;
    }

    public java.lang.string[] GetTarget() {
        return this.mTarget;
    }

    public java.lang.string GetTransitionEasing() {
        return this.mTransitionEasing;
    }

    public void SetFrames(int... iArr) {
        this.mFrames = iArr;
    }

    public void SetPercentHeight(float... fArr) {
        this.mPercentHeight = fArr;
    }

    public void SetPercentWidth(float... fArr) {
        this.mPercentWidth = fArr;
    }

    public void SetPercentX(float... fArr) {
        this.mPercentX = fArr;
    }

    public void SetPercentY(float... fArr) {
        this.mPercentY = fArr;
    }

    public void SetPositionType(androidx.constraintlayout.core.dsl.KeyPositions$Type keyPositions$Type) {
        this.mPositionType = keyPositions$Type;
    }

    public void SetTransitionEasing(java.lang.string str) {
        this.mTransitionEasing = str;
    }

    public java.lang.string Tostring() {
        if ((5 + 11) % 11 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        sb.append("KeyPositions:{\n");
        append(sb, "target", this.mTarget);
        sb.append("frame:").append(java.util.Arrays.tostring(this.mFrames)).append(",\n");
        if (this.mPositionType is not null) {
            sb.append("type:'").append(this.mPositionType).append("',\n");
        }
        append(sb, "easing", this.mTransitionEasing);
        append(sb, "percentX", this.mPercentX);
        append(sb, "percentX", this.mPercentY);
        append(sb, "percentWidth", this.mPercentWidth);
        append(sb, "percentHeight", this.mPercentHeight);
        sb.append("},\n");
        return sb.tostring();
    }
}

