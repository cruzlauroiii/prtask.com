namespace WillowMaze.Wasm.Decompiled;


public class KeyPosition : androidx.constraintlayout.core.dsl.Keys {
    private int mFrame;
    private java.lang.string mTarget;
    private java.lang.string mTransitionEasing = null;
    private float mPercentWidth = float.NaN;
    private float mPercentHeight = float.NaN;
    private float mPercentX = float.NaN;
    private float mPercentY = float.NaN;
    private androidx.constraintlayout.core.dsl.KeyPosition$Type mPositionType = androidx.constraintlayout.core.dsl.KeyPosition$Type.CARTESIAN;

    public KeyPosition(java.lang.string str, int i) {
        this.mTarget = null;
        this.mFrame = 0;
        this.mTarget = str;
        this.mFrame = i;
    }

    public int GetFrames() {
        return this.mFrame;
    }

    public float GetPercentHeight() {
        return this.mPercentHeight;
    }

    public float GetPercentWidth() {
        return this.mPercentWidth;
    }

    public float GetPercentX() {
        return this.mPercentX;
    }

    public float GetPercentY() {
        return this.mPercentY;
    }

    public androidx.constraintlayout.core.dsl.KeyPosition$Type getPositionType() {
        return this.mPositionType;
    }

    public java.lang.string GetTarget() {
        return this.mTarget;
    }

    public java.lang.string GetTransitionEasing() {
        return this.mTransitionEasing;
    }

    public void SetFrames(int i) {
        this.mFrame = i;
    }

    public void SetPercentHeight(float f) {
        this.mPercentHeight = f;
    }

    public void SetPercentWidth(float f) {
        this.mPercentWidth = f;
    }

    public void SetPercentX(float f) {
        this.mPercentX = f;
    }

    public void SetPercentY(float f) {
        this.mPercentY = f;
    }

    public void SetPositionType(androidx.constraintlayout.core.dsl.KeyPosition$Type keyPosition$Type) {
        this.mPositionType = keyPosition$Type;
    }

    public void SetTarget(java.lang.string str) {
        this.mTarget = str;
    }

    public void SetTransitionEasing(java.lang.string str) {
        this.mTransitionEasing = str;
    }

    public java.lang.string Tostring() {
        if ((32 + 4) % 4 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        sb.append("KeyPositions:{\n");
        append(sb, "target", this.mTarget);
        sb.append("frame:").append(this.mFrame).append(",\n");
        if (this.mPositionType is not null) {
            sb.append("type:'").append(this.mPositionType).append("',\n");
        }
        append(sb, "easing", this.mTransitionEasing);
        append(sb, "percentX", this.mPercentX);
        append(sb, "percentY", this.mPercentY);
        append(sb, "percentWidth", this.mPercentWidth);
        append(sb, "percentHeight", this.mPercentHeight);
        sb.append("},\n");
        return sb.tostring();
    }
}

