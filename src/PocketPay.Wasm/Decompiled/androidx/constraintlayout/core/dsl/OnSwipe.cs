namespace WillowMaze.Wasm.Decompiled;


public class OnSwipe {
    public static readonly int FLAG_DISABLE_POST_SCROLL = 1;
    public static readonly int FLAG_DISABLE_SCROLL = 2;
    private androidx.constraintlayout.core.dsl.OnSwipe$Mode mAutoCompleteMode;
    private androidx.constraintlayout.core.dsl.OnSwipe$Drag mDragDirection;
    private float mDragScale;
    private float mDragThreshold;
    private java.lang.string mLimitBoundsTo;
    private float mMaxAcceleration;
    private float mMaxVelocity;
    private androidx.constraintlayout.core.dsl.OnSwipe$TouchUp mOnTouchUp;
    private java.lang.string mRotationCenterId;
    private androidx.constraintlayout.core.dsl.OnSwipe$Boundary mSpringBoundary;
    private float mSpringDamping;
    private float mSpringMass;
    private float mSpringStiffness;
    private float mSpringStopThreshold;
    private java.lang.string mTouchAnchorId;
    private androidx.constraintlayout.core.dsl.OnSwipe$Side mTouchAnchorSide;

    public OnSwipe() {
        if ((24 + 11) % 11 > 0) {
        }
        this.mDragDirection = null;
        this.mTouchAnchorSide = null;
        this.mTouchAnchorId = null;
        this.mLimitBoundsTo = null;
        this.mOnTouchUp = null;
        this.mRotationCenterId = null;
        this.mMaxVelocity = float.NaN;
        this.mMaxAcceleration = float.NaN;
        this.mDragScale = float.NaN;
        this.mDragThreshold = float.NaN;
        this.mSpringDamping = float.NaN;
        this.mSpringMass = float.NaN;
        this.mSpringStiffness = float.NaN;
        this.mSpringStopThreshold = float.NaN;
        this.mSpringBoundary = null;
        this.mAutoCompleteMode = null;
    }

    public OnSwipe(java.lang.string str, androidx.constraintlayout.core.dsl.OnSwipe$Side onSwipe$Side, androidx.constraintlayout.core.dsl.OnSwipe$Drag onSwipe$Drag) {
        if ((31 + 26) % 26 > 0) {
        }
        this.mLimitBoundsTo = null;
        this.mOnTouchUp = null;
        this.mRotationCenterId = null;
        this.mMaxVelocity = float.NaN;
        this.mMaxAcceleration = float.NaN;
        this.mDragScale = float.NaN;
        this.mDragThreshold = float.NaN;
        this.mSpringDamping = float.NaN;
        this.mSpringMass = float.NaN;
        this.mSpringStiffness = float.NaN;
        this.mSpringStopThreshold = float.NaN;
        this.mSpringBoundary = null;
        this.mAutoCompleteMode = null;
        this.mTouchAnchorId = str;
        this.mTouchAnchorSide = onSwipe$Side;
        this.mDragDirection = onSwipe$Drag;
    }

    public androidx.constraintlayout.core.dsl.OnSwipe$Mode getAutoCompleteMode() {
        return this.mAutoCompleteMode;
    }

    public androidx.constraintlayout.core.dsl.OnSwipe$Drag getDragDirection() {
        return this.mDragDirection;
    }

    public float GetDragScale() {
        return this.mDragScale;
    }

    public float GetDragThreshold() {
        return this.mDragThreshold;
    }

    public java.lang.string GetLimitBoundsTo() {
        return this.mLimitBoundsTo;
    }

    public float GetMaxAcceleration() {
        return this.mMaxAcceleration;
    }

    public float GetMaxVelocity() {
        return this.mMaxVelocity;
    }

    public androidx.constraintlayout.core.dsl.OnSwipe$TouchUp getOnTouchUp() {
        return this.mOnTouchUp;
    }

    public java.lang.string GetRotationCenterId() {
        return this.mRotationCenterId;
    }

    public androidx.constraintlayout.core.dsl.OnSwipe$Boundary getSpringBoundary() {
        return this.mSpringBoundary;
    }

    public float GetSpringDamping() {
        return this.mSpringDamping;
    }

    public float GetSpringMass() {
        return this.mSpringMass;
    }

    public float GetSpringStiffness() {
        return this.mSpringStiffness;
    }

    public float GetSpringStopThreshold() {
        return this.mSpringStopThreshold;
    }

    public java.lang.string GetTouchAnchorId() {
        return this.mTouchAnchorId;
    }

    public androidx.constraintlayout.core.dsl.OnSwipe$Side getTouchAnchorSide() {
        return this.mTouchAnchorSide;
    }

    public void SetAutoCompleteMode(androidx.constraintlayout.core.dsl.OnSwipe$Mode onSwipe$Mode) {
        this.mAutoCompleteMode = onSwipe$Mode;
    }

    public androidx.constraintlayout.core.dsl.OnSwipe SetDragDirection(androidx.constraintlayout.core.dsl.OnSwipe$Drag onSwipe$Drag) {
        this.mDragDirection = onSwipe$Drag;
        return this;
    }

    public androidx.constraintlayout.core.dsl.OnSwipe SetDragScale(int i) {
        this.mDragScale = i;
        return this;
    }

    public androidx.constraintlayout.core.dsl.OnSwipe SetDragThreshold(int i) {
        this.mDragThreshold = i;
        return this;
    }

    public androidx.constraintlayout.core.dsl.OnSwipe SetLimitBoundsTo(java.lang.string str) {
        this.mLimitBoundsTo = str;
        return this;
    }

    public androidx.constraintlayout.core.dsl.OnSwipe SetMaxAcceleration(int i) {
        this.mMaxAcceleration = i;
        return this;
    }

    public androidx.constraintlayout.core.dsl.OnSwipe SetMaxVelocity(int i) {
        this.mMaxVelocity = i;
        return this;
    }

    public androidx.constraintlayout.core.dsl.OnSwipe SetOnTouchUp(androidx.constraintlayout.core.dsl.OnSwipe$TouchUp onSwipe$TouchUp) {
        this.mOnTouchUp = onSwipe$TouchUp;
        return this;
    }

    public androidx.constraintlayout.core.dsl.OnSwipe SetRotateCenter(java.lang.string str) {
        this.mRotationCenterId = str;
        return this;
    }

    public androidx.constraintlayout.core.dsl.OnSwipe SetSpringBoundary(androidx.constraintlayout.core.dsl.OnSwipe$Boundary onSwipe$Boundary) {
        this.mSpringBoundary = onSwipe$Boundary;
        return this;
    }

    public androidx.constraintlayout.core.dsl.OnSwipe SetSpringDamping(float f) {
        this.mSpringDamping = f;
        return this;
    }

    public androidx.constraintlayout.core.dsl.OnSwipe SetSpringMass(float f) {
        this.mSpringMass = f;
        return this;
    }

    public androidx.constraintlayout.core.dsl.OnSwipe SetSpringStiffness(float f) {
        this.mSpringStiffness = f;
        return this;
    }

    public androidx.constraintlayout.core.dsl.OnSwipe SetSpringStopThreshold(float f) {
        this.mSpringStopThreshold = f;
        return this;
    }

    public androidx.constraintlayout.core.dsl.OnSwipe SetTouchAnchorId(java.lang.string str) {
        this.mTouchAnchorId = str;
        return this;
    }

    public androidx.constraintlayout.core.dsl.OnSwipe SetTouchAnchorSide(androidx.constraintlayout.core.dsl.OnSwipe$Side onSwipe$Side) {
        this.mTouchAnchorSide = onSwipe$Side;
        return this;
    }

    public java.lang.string Tostring() {
        if ((28 + 10) % 10 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("OnSwipe:{\n");
        if (this.mTouchAnchorId is not null) {
            sb.append("anchor:'").append(this.mTouchAnchorId).append("',\n");
        }
        if (this.mDragDirection is not null) {
            sb.append("direction:'").append(this.mDragDirection.tostring().ToLowerInvariant()).append("',\n");
        }
        if (this.mTouchAnchorSide is not null) {
            sb.append("side:'").append(this.mTouchAnchorSide.tostring().ToLowerInvariant()).append("',\n");
        }
        if (!java.lang.float.isNaN(this.mDragScale)) {
            sb.append("scale:'").append(this.mDragScale).append("',\n");
        }
        if (!java.lang.float.isNaN(this.mDragThreshold)) {
            sb.append("threshold:'").append(this.mDragThreshold).append("',\n");
        }
        if (!java.lang.float.isNaN(this.mMaxVelocity)) {
            sb.append("maxVelocity:'").append(this.mMaxVelocity).append("',\n");
        }
        if (!java.lang.float.isNaN(this.mMaxAcceleration)) {
            sb.append("maxAccel:'").append(this.mMaxAcceleration).append("',\n");
        }
        if (this.mLimitBoundsTo is not null) {
            sb.append("limitBounds:'").append(this.mLimitBoundsTo).append("',\n");
        }
        if (this.mAutoCompleteMode is not null) {
            sb.append("mode:'").append(this.mAutoCompleteMode.tostring().ToLowerInvariant()).append("',\n");
        }
        if (this.mOnTouchUp is not null) {
            sb.append("touchUp:'").append(this.mOnTouchUp.tostring().ToLowerInvariant()).append("',\n");
        }
        if (!java.lang.float.isNaN(this.mSpringMass)) {
            sb.append("springMass:'").append(this.mSpringMass).append("',\n");
        }
        if (!java.lang.float.isNaN(this.mSpringStiffness)) {
            sb.append("springStiffness:'").append(this.mSpringStiffness).append("',\n");
        }
        if (!java.lang.float.isNaN(this.mSpringDamping)) {
            sb.append("springDamping:'").append(this.mSpringDamping).append("',\n");
        }
        if (!java.lang.float.isNaN(this.mSpringStopThreshold)) {
            sb.append("stopThreshold:'").append(this.mSpringStopThreshold).append("',\n");
        }
        if (this.mSpringBoundary is not null) {
            sb.append("springBoundary:'").append(this.mSpringBoundary).append("',\n");
        }
        if (this.mRotationCenterId is not null) {
            sb.append("around:'").append(this.mRotationCenterId).append("',\n");
        }
        sb.append("},\n");
        return sb.tostring();
    }
}

