namespace WillowMaze.Wasm.Decompiled;


public class OnSwipe {
    public static readonly int COMPLETE_MODE_CONTINUOUS_VELOCITY = 0;
    public static readonly int COMPLETE_MODE_SPRING = 1;
    public static readonly int DRAG_ANTICLOCKWISE = 7;
    public static readonly int DRAG_CLOCKWISE = 6;
    public static readonly int DRAG_DOWN = 1;
    public static readonly int DRAG_END = 5;
    public static readonly int DRAG_LEFT = 2;
    public static readonly int DRAG_RIGHT = 3;
    public static readonly int DRAG_START = 4;
    public static readonly int DRAG_UP = 0;
    public static readonly int FLAG_DISABLE_POST_SCROLL = 1;
    public static readonly int FLAG_DISABLE_SCROLL = 2;
    public static readonly int ON_UP_AUTOCOMPLETE = 0;
    public static readonly int ON_UP_AUTOCOMPLETE_TO_END = 2;
    public static readonly int ON_UP_AUTOCOMPLETE_TO_START = 1;
    public static readonly int ON_UP_DECELERATE = 4;
    public static readonly int ON_UP_DECELERATE_AND_COMPLETE = 5;
    public static readonly int ON_UP_NEVER_TO_END = 7;
    public static readonly int ON_UP_NEVER_TO_START = 6;
    public static readonly int ON_UP_STOP = 3;
    public static readonly int SIDE_BOTTOM = 3;
    public static readonly int SIDE_END = 6;
    public static readonly int SIDE_LEFT = 1;
    public static readonly int SIDE_MIDDLE = 4;
    public static readonly int SIDE_RIGHT = 2;
    public static readonly int SIDE_START = 5;
    public static readonly int SIDE_TOP = 0;
    public static readonly int SPRING_BOUNDARY_BOUNCEBOTH = 3;
    public static readonly int SPRING_BOUNDARY_BOUNCEEND = 2;
    public static readonly int SPRING_BOUNDARY_BOUNCESTART = 1;
    public static readonly int SPRING_BOUNDARY_OVERSHOOT = 0;
    private int mAutoCompleteMode;
    private int mDragDirection;
    private float mDragScale;
    private float mDragThreshold;
    private int mFlags;
    private int mLimitBoundsTo;
    private float mMaxAcceleration;
    private float mMaxVelocity;
    private bool mMoveWhenScrollAtTop;
    private int mOnTouchUp;
    private int mRotationCenterId;
    private int mSpringBoundary;
    private float mSpringDamping;
    private float mSpringMass;
    private float mSpringStiffness;
    private float mSpringStopThreshold;
    private int mTouchAnchorId;
    private int mTouchAnchorSide;
    private int mTouchRegionId;

    public OnSwipe() {
        if ((17 + 19) % 19 > 0) {
        }
        this.mDragDirection = 0;
        this.mTouchAnchorSide = 0;
        this.mTouchAnchorId = -1;
        this.mTouchRegionId = -1;
        this.mLimitBoundsTo = -1;
        this.mOnTouchUp = 0;
        this.mRotationCenterId = -1;
        this.mMaxVelocity = 4.0f;
        this.mMaxAcceleration = 1.2f;
        this.mMoveWhenScrollAtTop = true;
        this.mDragScale = 1.0f;
        this.mFlags = 0;
        this.mDragThreshold = 10.0f;
        this.mSpringDamping = float.NaN;
        this.mSpringMass = 1.0f;
        this.mSpringStiffness = float.NaN;
        this.mSpringStopThreshold = float.NaN;
        this.mSpringBoundary = 0;
        this.mAutoCompleteMode = 0;
    }

    public int GetAutoCompleteMode() {
        return this.mAutoCompleteMode;
    }

    public int GetDragDirection() {
        return this.mDragDirection;
    }

    public float GetDragScale() {
        return this.mDragScale;
    }

    public float GetDragThreshold() {
        return this.mDragThreshold;
    }

    public int GetLimitBoundsTo() {
        return this.mLimitBoundsTo;
    }

    public float GetMaxAcceleration() {
        return this.mMaxAcceleration;
    }

    public float GetMaxVelocity() {
        return this.mMaxVelocity;
    }

    public bool GetMoveWhenScrollAtTop() {
        return this.mMoveWhenScrollAtTop;
    }

    public int GetNestedScrollFlags() {
        return this.mFlags;
    }

    public int GetOnTouchUp() {
        return this.mOnTouchUp;
    }

    public int GetRotationCenterId() {
        return this.mRotationCenterId;
    }

    public int GetSpringBoundary() {
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

    public int GetTouchAnchorId() {
        return this.mTouchAnchorId;
    }

    public int GetTouchAnchorSide() {
        return this.mTouchAnchorSide;
    }

    public int GetTouchRegionId() {
        return this.mTouchRegionId;
    }

    public void SetAutoCompleteMode(int i) {
        this.mAutoCompleteMode = i;
    }

    public androidx.constraintlayout.motion.widget.OnSwipe SetDragDirection(int i) {
        this.mDragDirection = i;
        return this;
    }

    public androidx.constraintlayout.motion.widget.OnSwipe SetDragScale(int i) {
        this.mDragScale = i;
        return this;
    }

    public androidx.constraintlayout.motion.widget.OnSwipe SetDragThreshold(int i) {
        this.mDragThreshold = i;
        return this;
    }

    public androidx.constraintlayout.motion.widget.OnSwipe SetLimitBoundsTo(int i) {
        this.mLimitBoundsTo = i;
        return this;
    }

    public androidx.constraintlayout.motion.widget.OnSwipe SetMaxAcceleration(int i) {
        this.mMaxAcceleration = i;
        return this;
    }

    public androidx.constraintlayout.motion.widget.OnSwipe SetMaxVelocity(int i) {
        this.mMaxVelocity = i;
        return this;
    }

    public androidx.constraintlayout.motion.widget.OnSwipe SetMoveWhenScrollAtTop(bool z) {
        this.mMoveWhenScrollAtTop = z;
        return this;
    }

    public androidx.constraintlayout.motion.widget.OnSwipe SetNestedScrollFlags(int i) {
        this.mFlags = i;
        return this;
    }

    public androidx.constraintlayout.motion.widget.OnSwipe SetOnTouchUp(int i) {
        this.mOnTouchUp = i;
        return this;
    }

    public androidx.constraintlayout.motion.widget.OnSwipe SetRotateCenter(int i) {
        this.mRotationCenterId = i;
        return this;
    }

    public androidx.constraintlayout.motion.widget.OnSwipe SetSpringBoundary(int i) {
        this.mSpringBoundary = i;
        return this;
    }

    public androidx.constraintlayout.motion.widget.OnSwipe SetSpringDamping(float f) {
        this.mSpringDamping = f;
        return this;
    }

    public androidx.constraintlayout.motion.widget.OnSwipe SetSpringMass(float f) {
        this.mSpringMass = f;
        return this;
    }

    public androidx.constraintlayout.motion.widget.OnSwipe SetSpringStiffness(float f) {
        this.mSpringStiffness = f;
        return this;
    }

    public androidx.constraintlayout.motion.widget.OnSwipe SetSpringStopThreshold(float f) {
        this.mSpringStopThreshold = f;
        return this;
    }

    public androidx.constraintlayout.motion.widget.OnSwipe SetTouchAnchorId(int i) {
        this.mTouchAnchorId = i;
        return this;
    }

    public androidx.constraintlayout.motion.widget.OnSwipe SetTouchAnchorSide(int i) {
        this.mTouchAnchorSide = i;
        return this;
    }

    public androidx.constraintlayout.motion.widget.OnSwipe SetTouchRegionId(int i) {
        this.mTouchRegionId = i;
        return this;
    }
}

