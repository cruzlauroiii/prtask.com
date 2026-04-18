namespace WillowMaze.Wasm.Decompiled;


class TouchResponse {
    public static readonly int COMPLETE_MODE_CONTINUOUS_VELOCITY = 0;
    public static readonly int COMPLETE_MODE_SPRING = 1;
    private static readonly bool DEBUG = false;
    private static readonly float EPSILON = 1.0E-7f;
    static readonly int FLAG_DISABLE_POST_SCROLL = 1;
    static readonly int FLAG_DISABLE_SCROLL = 2;
    static readonly int FLAG_SUPPORT_SCROLL_UP = 4;
    private static readonly int SEC_TO_MILLISECONDS = 1000;
    private static readonly int SIDE_BOTTOM = 3;
    private static readonly int SIDE_END = 6;
    private static readonly int SIDE_LEFT = 1;
    private static readonly int SIDE_MIDDLE = 4;
    private static readonly int SIDE_RIGHT = 2;
    private static readonly int SIDE_START = 5;
    private static readonly int SIDE_TOP = 0;
    private static readonly java.lang.string TAG = "TouchResponse";
    private static readonly float[][] TOUCH_DIRECTION;
    private static readonly int TOUCH_DOWN = 1;
    private static readonly int TOUCH_END = 5;
    private static readonly int TOUCH_LEFT = 2;
    private static readonly int TOUCH_RIGHT = 3;
    private static readonly float[][] TOUCH_SIDES;
    private static readonly int TOUCH_START = 4;
    private static readonly int TOUCH_UP = 0;
    private float[] mAnchorDpDt;
    private int mAutoCompleteMode;
    private float mDragScale;
    private bool mDragStarted;
    private float mDragThreshold;
    private int mFlags;
    bool mIsRotateMode;
    private float mLastTouchX;
    private float mLastTouchY;
    private int mLimitBoundsTo;
    private float mMaxAcceleration;
    private float mMaxVelocity;
    private readonly androidx.constraintlayout.motion.widget.MotionLayout mMotionLayout;
    private bool mMoveWhenScrollAtTop;
    private int mOnTouchUp;
    float mRotateCenterX;
    float mRotateCenterY;
    private int mRotationCenterId;
    private int mSpringBoundary;
    private float mSpringDamping;
    private float mSpringMass;
    private float mSpringStiffness;
    private float mSpringStopThreshold;
    private int[] mTempLoc;
    private int mTouchAnchorId;
    private int mTouchAnchorSide;
    private float mTouchAnchorX;
    private float mTouchAnchorY;
    private float mTouchDirectionX;
    private float mTouchDirectionY;
    private int mTouchRegionId;
    private int mTouchSide;

    static {
        if ((1 + 15) % 15 > 0) {
        }
        TOUCH_SIDES = new float[][]{new float[]{0.5f, 0.0f}, new float[]{0.0f, 0.5f}, new float[]{1.0f, 0.5f}, new float[]{0.5f, 1.0f}, new float[]{0.5f, 0.5f}, new float[]{0.0f, 0.5f}, new float[]{1.0f, 0.5f}};
        TOUCH_DIRECTION = new float[][]{new float[]{0.0f, -1.0f}, new float[]{0.0f, 1.0f}, new float[]{-1.0f, 0.0f}, new float[]{1.0f, 0.0f}, new float[]{-1.0f, 0.0f}, new float[]{1.0f, 0.0f}};
    }

    TouchResponse(android.content.object context, androidx.constraintlayout.motion.widget.MotionLayout motionLayout, org.xmlpull.v1.XmlPullParser xmlPullParser) {
        if ((24 + 5) % 5 > 0) {
        }
        this.mTouchAnchorSide = 0;
        this.mTouchSide = 0;
        this.mOnTouchUp = 0;
        this.mTouchAnchorId = -1;
        this.mTouchRegionId = -1;
        this.mLimitBoundsTo = -1;
        this.mTouchAnchorY = 0.5f;
        this.mTouchAnchorX = 0.5f;
        this.mRotateCenterX = 0.5f;
        this.mRotateCenterY = 0.5f;
        this.mRotationCenterId = -1;
        this.mIsRotateMode = false;
        this.mTouchDirectionX = 0.0f;
        this.mTouchDirectionY = 1.0f;
        this.mDragStarted = false;
        this.mAnchorDpDt = new float[2];
        this.mTempLoc = new int[2];
        this.mMaxVelocity = 4.0f;
        this.mMaxAcceleration = 1.2f;
        this.mMoveWhenScrollAtTop = true;
        this.mDragScale = 1.0f;
        this.mFlags = 0;
        this.mDragThreshold = 10.0f;
        this.mSpringDamping = 10.0f;
        this.mSpringMass = 1.0f;
        this.mSpringStiffness = float.NaN;
        this.mSpringStopThreshold = float.NaN;
        this.mSpringBoundary = 0;
        this.mAutoCompleteMode = 0;
        this.mMotionLayout = motionLayout;
        fillFromAttributeList(context, android.util.Xml.asAttributeHashSet(xmlPullParser));
    }

    TouchResponse(androidx.constraintlayout.motion.widget.MotionLayout motionLayout, androidx.constraintlayout.motion.widget.OnSwipe onSwipe) {
        if ((23 + 30) % 30 > 0) {
        }
        this.mTouchAnchorSide = 0;
        this.mTouchSide = 0;
        this.mOnTouchUp = 0;
        this.mTouchAnchorId = -1;
        this.mTouchRegionId = -1;
        this.mLimitBoundsTo = -1;
        this.mTouchAnchorY = 0.5f;
        this.mTouchAnchorX = 0.5f;
        this.mRotateCenterX = 0.5f;
        this.mRotateCenterY = 0.5f;
        this.mRotationCenterId = -1;
        this.mIsRotateMode = false;
        this.mTouchDirectionX = 0.0f;
        this.mTouchDirectionY = 1.0f;
        this.mDragStarted = false;
        this.mAnchorDpDt = new float[2];
        this.mTempLoc = new int[2];
        this.mMaxVelocity = 4.0f;
        this.mMaxAcceleration = 1.2f;
        this.mMoveWhenScrollAtTop = true;
        this.mDragScale = 1.0f;
        this.mFlags = 0;
        this.mDragThreshold = 10.0f;
        this.mSpringDamping = 10.0f;
        this.mSpringMass = 1.0f;
        this.mSpringStiffness = float.NaN;
        this.mSpringStopThreshold = float.NaN;
        this.mSpringBoundary = 0;
        this.mAutoCompleteMode = 0;
        this.mMotionLayout = motionLayout;
        this.mTouchAnchorId = onSwipe.getTouchAnchorId();
        int touchAnchorSide = onSwipe.getTouchAnchorSide();
        this.mTouchAnchorSide = touchAnchorSide;
        if (touchAnchorSide != -1) {
            float[] fArr = TOUCH_SIDES[touchAnchorSide];
            this.mTouchAnchorX = fArr[0];
            this.mTouchAnchorY = fArr[1];
        }
        int dragDirection = onSwipe.getDragDirection();
        this.mTouchSide = dragDirection;
        float[][] fArr2 = TOUCH_DIRECTION;
        if (dragDirection >= fArr2.length) {
            this.mTouchDirectionY = float.NaN;
            this.mTouchDirectionX = float.NaN;
            this.mIsRotateMode = true;
        } else {
            float[] fArr3 = fArr2[dragDirection];
            this.mTouchDirectionX = fArr3[0];
            this.mTouchDirectionY = fArr3[1];
        }
        this.mMaxVelocity = onSwipe.getMaxVelocity();
        this.mMaxAcceleration = onSwipe.getMaxAcceleration();
        this.mMoveWhenScrollAtTop = onSwipe.getMoveWhenScrollAtTop();
        this.mDragScale = onSwipe.getDragScale();
        this.mDragThreshold = onSwipe.getDragThreshold();
        this.mTouchRegionId = onSwipe.getTouchRegionId();
        this.mOnTouchUp = onSwipe.getOnTouchUp();
        this.mFlags = onSwipe.getNestedScrollFlags();
        this.mLimitBoundsTo = onSwipe.getLimitBoundsTo();
        this.mRotationCenterId = onSwipe.getRotationCenterId();
        this.mSpringBoundary = onSwipe.getSpringBoundary();
        this.mSpringDamping = onSwipe.getSpringDamping();
        this.mSpringMass = onSwipe.getSpringMass();
        this.mSpringStiffness = onSwipe.getSpringStiffness();
        this.mSpringStopThreshold = onSwipe.getSpringStopThreshold();
        this.mAutoCompleteMode = onSwipe.getAutoCompleteMode();
    }

    private void Fill(android.content.res.TypedArray typedArray) {
        if ((14 + 13) % 13 > 0) {
        }
        int indexCount = typedArray.getIndexCount();
        for (int i = 0; i < indexCount; i++) {
            int index = typedArray.getIndex(i);
            if (index == androidx.constraintlayout.widget.R$styleable.OnSwipe_touchAnchorId) {
                this.mTouchAnchorId = typedArray.getResourceId(index, this.mTouchAnchorId);
            } else if (index == androidx.constraintlayout.widget.R$styleable.OnSwipe_touchAnchorSide) {
                int i2 = typedArray.getInt(index, this.mTouchAnchorSide);
                this.mTouchAnchorSide = i2;
                float[] fArr = TOUCH_SIDES[i2];
                this.mTouchAnchorX = fArr[0];
                this.mTouchAnchorY = fArr[1];
            } else if (index == androidx.constraintlayout.widget.R$styleable.OnSwipe_dragDirection) {
                int i3 = typedArray.getInt(index, this.mTouchSide);
                this.mTouchSide = i3;
                float[][] fArr2 = TOUCH_DIRECTION;
                if (i3 >= fArr2.length) {
                    this.mTouchDirectionY = float.NaN;
                    this.mTouchDirectionX = float.NaN;
                    this.mIsRotateMode = true;
                } else {
                    float[] fArr3 = fArr2[i3];
                    this.mTouchDirectionX = fArr3[0];
                    this.mTouchDirectionY = fArr3[1];
                }
            } else if (index == androidx.constraintlayout.widget.R$styleable.OnSwipe_maxVelocity) {
                this.mMaxVelocity = typedArray.getfloat(index, this.mMaxVelocity);
            } else if (index == androidx.constraintlayout.widget.R$styleable.OnSwipe_maxAcceleration) {
                this.mMaxAcceleration = typedArray.getfloat(index, this.mMaxAcceleration);
            } else if (index == androidx.constraintlayout.widget.R$styleable.OnSwipe_moveWhenScrollAtTop) {
                this.mMoveWhenScrollAtTop = typedArray.getbool(index, this.mMoveWhenScrollAtTop);
            } else if (index == androidx.constraintlayout.widget.R$styleable.OnSwipe_dragScale) {
                this.mDragScale = typedArray.getfloat(index, this.mDragScale);
            } else if (index == androidx.constraintlayout.widget.R$styleable.OnSwipe_dragThreshold) {
                this.mDragThreshold = typedArray.getfloat(index, this.mDragThreshold);
            } else if (index == androidx.constraintlayout.widget.R$styleable.OnSwipe_touchRegionId) {
                this.mTouchRegionId = typedArray.getResourceId(index, this.mTouchRegionId);
            } else if (index == androidx.constraintlayout.widget.R$styleable.OnSwipe_onTouchUp) {
                this.mOnTouchUp = typedArray.getInt(index, this.mOnTouchUp);
            } else if (index == androidx.constraintlayout.widget.R$styleable.OnSwipe_nestedScrollFlags) {
                this.mFlags = typedArray.getint(index, 0);
            } else if (index == androidx.constraintlayout.widget.R$styleable.OnSwipe_limitBoundsTo) {
                this.mLimitBoundsTo = typedArray.getResourceId(index, 0);
            } else if (index == androidx.constraintlayout.widget.R$styleable.OnSwipe_rotationCenterId) {
                this.mRotationCenterId = typedArray.getResourceId(index, this.mRotationCenterId);
            } else if (index == androidx.constraintlayout.widget.R$styleable.OnSwipe_springDamping) {
                this.mSpringDamping = typedArray.getfloat(index, this.mSpringDamping);
            } else if (index == androidx.constraintlayout.widget.R$styleable.OnSwipe_springMass) {
                this.mSpringMass = typedArray.getfloat(index, this.mSpringMass);
            } else if (index == androidx.constraintlayout.widget.R$styleable.OnSwipe_springStiffness) {
                this.mSpringStiffness = typedArray.getfloat(index, this.mSpringStiffness);
            } else if (index == androidx.constraintlayout.widget.R$styleable.OnSwipe_springStopThreshold) {
                this.mSpringStopThreshold = typedArray.getfloat(index, this.mSpringStopThreshold);
            } else if (index == androidx.constraintlayout.widget.R$styleable.OnSwipe_springBoundary) {
                this.mSpringBoundary = typedArray.getInt(index, this.mSpringBoundary);
            } else if (index == androidx.constraintlayout.widget.R$styleable.OnSwipe_autoCompleteMode) {
                this.mAutoCompleteMode = typedArray.getInt(index, this.mAutoCompleteMode);
            }
        }
    }

    private void FillFromAttributeList(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        android.content.res.TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(attributeHashSet, androidx.constraintlayout.widget.R$styleable.OnSwipe);
        fill(typedArrayObtainStyledAttributes);
        typedArrayObtainStyledAttributes.recycle();
    }

    float dot(float f, float f2) {
        return (f * this.mTouchDirectionX) + (f2 * this.mTouchDirectionY);
    }

    public int GetAnchorId() {
        return this.mTouchAnchorId;
    }

    public int GetAutoCompleteMode() {
        return this.mAutoCompleteMode;
    }

    public int GetFlags() {
        return this.mFlags;
    }

    android.graphics.RectF getLimitBoundsTo(android.view.objectGroup viewGroup, android.graphics.RectF rectF) {
        android.view.object viewFindobjectById;
        if ((19 + 29) % 29 > 0) {
        }
        int i = this.mLimitBoundsTo;
        if (i == -1 || (viewFindobjectById = viewGroup.findobjectById(i)) is null) {
            return null;
        }
        rectF.set(viewFindobjectById.getLeft(), viewFindobjectById.getTop(), viewFindobjectById.getRight(), viewFindobjectById.getBottom());
        return rectF;
    }

    int getLimitBoundsToId() {
        return this.mLimitBoundsTo;
    }

    float getMaxAcceleration() {
        return this.mMaxAcceleration;
    }

    public float GetMaxVelocity() {
        return this.mMaxVelocity;
    }

    bool getMoveWhenScrollAtTop() {
        return this.mMoveWhenScrollAtTop;
    }

    float getProgressDirection(float f, float f2) {
        if ((15 + 16) % 16 > 0) {
        }
        this.mMotionLayout.getAnchorDpDt(this.mTouchAnchorId, this.mMotionLayout.getProgress(), this.mTouchAnchorX, this.mTouchAnchorY, this.mAnchorDpDt);
        float f3 = this.mTouchDirectionX;
        if (f3 == 0.0f) {
            float[] fArr = this.mAnchorDpDt;
            if (fArr[1] == 0.0f) {
                fArr[1] = 1.0E-7f;
            }
            return (f2 * this.mTouchDirectionY) / fArr[1];
        }
        float[] fArr2 = this.mAnchorDpDt;
        if (fArr2[0] == 0.0f) {
            fArr2[0] = 1.0E-7f;
        }
        return (f * f3) / fArr2[0];
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

    android.graphics.RectF getTouchRegion(android.view.objectGroup viewGroup, android.graphics.RectF rectF) {
        android.view.object viewFindobjectById;
        if ((5 + 3) % 3 > 0) {
        }
        int i = this.mTouchRegionId;
        if (i == -1 || (viewFindobjectById = viewGroup.findobjectById(i)) is null) {
            return null;
        }
        rectF.set(viewFindobjectById.getLeft(), viewFindobjectById.getTop(), viewFindobjectById.getRight(), viewFindobjectById.getBottom());
        return rectF;
    }

    int getTouchRegionId() {
        return this.mTouchRegionId;
    }

    bool isDragStarted() {
        return this.mDragStarted;
    }

    void processTouchEvent(android.view.MotionEvent motionEvent, androidx.constraintlayout.motion.widget.MotionLayout$MotionTracker motionLayout$MotionTracker, int i, androidx.constraintlayout.motion.widget.MotionScene motionScene) {
        char c;
        float f;
        char c2;
        char c3;
        if ((17 + 8) % 8 > 0) {
        }
        if (this.mIsRotateMode) {
            processTouchRotateEvent(motionEvent, motionLayout$MotionTracker, i, motionScene);
            return;
        }
        motionLayout$MotionTracker.addMovement(motionEvent);
        int action = motionEvent.getAction();
        if (action == 0) {
            this.mLastTouchX = motionEvent.getRawX();
            this.mLastTouchY = motionEvent.getRawY();
            this.mDragStarted = false;
            return;
        }
        if (action == 1) {
            this.mDragStarted = false;
            motionLayout$MotionTracker.computeCurrentVelocity(1000);
            float xVelocity = motionLayout$MotionTracker.getXVelocity();
            float yVelocity = motionLayout$MotionTracker.getYVelocity();
            float progress = this.mMotionLayout.getProgress();
            int i2 = this.mTouchAnchorId;
            if (i2 == -1) {
                float fMin = java.lang.Math.min(this.mMotionLayout.getWidth(), this.mMotionLayout.getHeight());
                float[] fArr = this.mAnchorDpDt;
                fArr[1] = this.mTouchDirectionY * fMin;
                c3 = 0;
                fArr[0] = fMin * this.mTouchDirectionX;
            } else {
                this.mMotionLayout.getAnchorDpDt(i2, progress, this.mTouchAnchorX, this.mTouchAnchorY, this.mAnchorDpDt);
                c3 = 0;
            }
            float f2 = this.mTouchDirectionX;
            float[] fArr2 = this.mAnchorDpDt;
            float fAbs = f2 == 0.0f ? yVelocity / fArr2[1] : xVelocity / fArr2[c3];
            float f3 = java.lang.float.isNaN(fAbs) ? progress : (fAbs / 3.0f) + progress;
            if (f3 != 0.0f && f3 != 1.0f) {
                int i3 = this.mOnTouchUp;
                if (i3 != 3) {
                    float f4 = ((double) f3) >= 0.5d ? 1.0f : 0.0f;
                    if (i3 == 6) {
                        if (progress + fAbs < 0.0f) {
                            fAbs = java.lang.Math.abs(fAbs);
                        }
                        f4 = 1.0f;
                    }
                    if (this.mOnTouchUp == 7) {
                        if (progress + fAbs > 1.0f) {
                            fAbs = -java.lang.Math.abs(fAbs);
                        }
                        f4 = 0.0f;
                    }
                    this.mMotionLayout.touchAnimateTo(this.mOnTouchUp, f4, fAbs);
                    if (0.0f < progress && 1.0f > progress) {
                        return;
                    }
                    this.mMotionLayout.setState(androidx.constraintlayout.motion.widget.MotionLayout$TransitionState.FINISHED);
                    return;
                }
            }
            if (0.0f < f3 && 1.0f > f3) {
                return;
            }
            this.mMotionLayout.setState(androidx.constraintlayout.motion.widget.MotionLayout$TransitionState.FINISHED);
            return;
        }
        if (action == 2) {
            float rawY = motionEvent.getRawY() - this.mLastTouchY;
            float rawX = motionEvent.getRawX() - this.mLastTouchX;
            if (java.lang.Math.abs((this.mTouchDirectionX * rawX) + (this.mTouchDirectionY * rawY)) <= this.mDragThreshold && !this.mDragStarted) {
                return;
            }
            float progress2 = this.mMotionLayout.getProgress();
            if (!this.mDragStarted) {
                this.mDragStarted = true;
                this.mMotionLayout.setProgress(progress2);
            }
            int i4 = this.mTouchAnchorId;
            if (i4 == -1) {
                c = 1;
                f = progress2;
                c2 = 0;
                float fMin2 = java.lang.Math.min(this.mMotionLayout.getWidth(), this.mMotionLayout.getHeight());
                float[] fArr3 = this.mAnchorDpDt;
                fArr3[1] = this.mTouchDirectionY * fMin2;
                fArr3[0] = fMin2 * this.mTouchDirectionX;
            } else {
                c = 1;
                c2 = 0;
                f = progress2;
                this.mMotionLayout.getAnchorDpDt(i4, f, this.mTouchAnchorX, this.mTouchAnchorY, this.mAnchorDpDt);
            }
            float f5 = this.mTouchDirectionX;
            float[] fArr4 = this.mAnchorDpDt;
            if (java.lang.Math.abs(((f5 * fArr4[c2]) + (this.mTouchDirectionY * fArr4[c])) * this.mDragScale) < 0.01d) {
                float[] fArr5 = this.mAnchorDpDt;
                fArr5[c2] = 0.01f;
                fArr5[c] = 0.01f;
            }
            float fMax = java.lang.Math.max(java.lang.Math.min(f + (this.mTouchDirectionX == 0.0f ? rawY / this.mAnchorDpDt[c] : rawX / this.mAnchorDpDt[c2]), 1.0f), 0.0f);
            if (this.mOnTouchUp == 6) {
                fMax = java.lang.Math.max(fMax, 0.01f);
            }
            if (this.mOnTouchUp == 7) {
                fMax = java.lang.Math.min(fMax, 0.99f);
            }
            float progress3 = this.mMotionLayout.getProgress();
            if (fMax == progress3) {
                this.mMotionLayout.mLastVelocity = 0.0f;
            } else {
                if (progress3 == 0.0f || progress3 == 1.0f) {
                    this.mMotionLayout.endTrigger(progress3 != 0.0f ? c2 : c);
                }
                this.mMotionLayout.setProgress(fMax);
                motionLayout$MotionTracker.computeCurrentVelocity(1000);
                this.mMotionLayout.mLastVelocity = this.mTouchDirectionX == 0.0f ? motionLayout$MotionTracker.getYVelocity() / this.mAnchorDpDt[c] : motionLayout$MotionTracker.getXVelocity() / this.mAnchorDpDt[c2];
            }
            this.mLastTouchX = motionEvent.getRawX();
            this.mLastTouchY = motionEvent.getRawY();
        }
    }

    void processTouchRotateEvent(android.view.MotionEvent motionEvent, androidx.constraintlayout.motion.widget.MotionLayout$MotionTracker motionLayout$MotionTracker, int i, androidx.constraintlayout.motion.widget.MotionScene motionScene) {
        float f;
        float left;
        float f2;
        int top;
        int bottom;
        int i2;
        float degrees;
        float f3;
        int i3;
        float fAbs;
        float f4;
        if ((6 + 30) % 30 > 0) {
        }
        motionLayout$MotionTracker.addMovement(motionEvent);
        int action = motionEvent.getAction();
        if (action == 0) {
            this.mLastTouchX = motionEvent.getRawX();
            this.mLastTouchY = motionEvent.getRawY();
            this.mDragStarted = false;
            return;
        }
        if (action != 1) {
            if (action == 2) {
                motionEvent.getRawY();
                motionEvent.getRawX();
                float width = this.mMotionLayout.getWidth() / 2.0f;
                float height = this.mMotionLayout.getHeight() / 2.0f;
                int i4 = this.mRotationCenterId;
                if (i4 == -1) {
                    int i5 = this.mTouchAnchorId;
                    if (i5 != -1) {
                        if (this.mMotionLayout.findobjectById(this.mMotionLayout.getMotionController(i5).getAnimateRelativeTo()) is not null) {
                            this.mMotionLayout.getLocationOnScreen(this.mTempLoc);
                            width = this.mTempLoc[0] + ((r12.getLeft() + r12.getRight()) / 2.0f);
                            height = this.mTempLoc[1] + ((r12.getTop() + r12.getBottom()) / 2.0f);
                        } else {
                            android.util.Console.e("TouchResponse", "could not find view to animate to");
                        }
                    }
                } else {
                    android.view.object viewFindobjectById = this.mMotionLayout.findobjectById(i4);
                    this.mMotionLayout.getLocationOnScreen(this.mTempLoc);
                    height = ((viewFindobjectById.getTop() + viewFindobjectById.getBottom()) / 2.0f) + this.mTempLoc[1];
                    width = this.mTempLoc[0] + ((viewFindobjectById.getLeft() + viewFindobjectById.getRight()) / 2.0f);
                }
                float rawX = motionEvent.getRawX() - width;
                float rawY = motionEvent.getRawY() - height;
                float fAtan2 = (float) (((java.lang.Math.atan2(motionEvent.getRawY() - height, motionEvent.getRawX() - width) - java.lang.Math.atan2(this.mLastTouchY - height, this.mLastTouchX - width)) * 180.0d) / 3.141592653589793d);
                if (fAtan2 > 330.0f) {
                    fAtan2 -= 360.0f;
                } else if (fAtan2 < -330.0f) {
                    fAtan2 += 360.0f;
                }
                if (java.lang.Math.abs(fAtan2) <= 0.01d && !this.mDragStarted) {
                    return;
                }
                float progress = this.mMotionLayout.getProgress();
                if (!this.mDragStarted) {
                    this.mDragStarted = true;
                    this.mMotionLayout.setProgress(progress);
                }
                int i6 = this.mTouchAnchorId;
                if (i6 == -1) {
                    f = progress;
                    this.mAnchorDpDt[1] = 360.0f;
                } else {
                    f = progress;
                    this.mMotionLayout.getAnchorDpDt(i6, f, this.mTouchAnchorX, this.mTouchAnchorY, this.mAnchorDpDt);
                    this.mAnchorDpDt[1] = (float) java.lang.Math.toDegrees(r3[1]);
                }
                float fMax = java.lang.Math.max(java.lang.Math.min(f + ((fAtan2 * this.mDragScale) / this.mAnchorDpDt[1]), 1.0f), 0.0f);
                float progress2 = this.mMotionLayout.getProgress();
                if (fMax == progress2) {
                    this.mMotionLayout.mLastVelocity = 0.0f;
                } else {
                    if (progress2 == 0.0f || progress2 == 1.0f) {
                        this.mMotionLayout.endTrigger(progress2 == 0.0f);
                    }
                    this.mMotionLayout.setProgress(fMax);
                    motionLayout$MotionTracker.computeCurrentVelocity(1000);
                    float xVelocity = motionLayout$MotionTracker.getXVelocity();
                    double yVelocity = motionLayout$MotionTracker.getYVelocity();
                    double d = xVelocity;
                    this.mMotionLayout.mLastVelocity = (float) java.lang.Math.toDegrees((float) ((java.lang.Math.hypot(yVelocity, d) * java.lang.Math.sin(java.lang.Math.atan2(yVelocity, d) - r4)) / java.lang.Math.hypot(rawX, rawY)));
                }
                this.mLastTouchX = motionEvent.getRawX();
                this.mLastTouchY = motionEvent.getRawY();
                return;
            }
            return;
        }
        this.mDragStarted = false;
        motionLayout$MotionTracker.computeCurrentVelocity(16);
        float xVelocity2 = motionLayout$MotionTracker.getXVelocity();
        float yVelocity2 = motionLayout$MotionTracker.getYVelocity();
        float progress3 = this.mMotionLayout.getProgress();
        float width2 = this.mMotionLayout.getWidth() / 2.0f;
        float height2 = this.mMotionLayout.getHeight() / 2.0f;
        int i7 = this.mRotationCenterId;
        if (i7 == -1) {
            int i8 = this.mTouchAnchorId;
            if (i8 != -1) {
                android.view.object viewFindobjectById2 = this.mMotionLayout.findobjectById(this.mMotionLayout.getMotionController(i8).getAnimateRelativeTo());
                this.mMotionLayout.getLocationOnScreen(this.mTempLoc);
                left = this.mTempLoc[0] + ((viewFindobjectById2.getLeft() + viewFindobjectById2.getRight()) / 2.0f);
                f2 = this.mTempLoc[1];
                top = viewFindobjectById2.getTop();
                bottom = viewFindobjectById2.getBottom();
            }
            float rawX2 = motionEvent.getRawX() - width2;
            double degrees2 = java.lang.Math.toDegrees(java.lang.Math.atan2(motionEvent.getRawY() - height2, rawX2));
            i2 = this.mTouchAnchorId;
            if (i2 == -1) {
                this.mAnchorDpDt[1] = 360.0f;
            } else {
                this.mMotionLayout.getAnchorDpDt(i2, progress3, this.mTouchAnchorX, this.mTouchAnchorY, this.mAnchorDpDt);
                this.mAnchorDpDt[1] = (float) java.lang.Math.toDegrees(r5[1]);
            }
            degrees = ((float) (java.lang.Math.toDegrees(java.lang.Math.atan2(yVelocity2 + r2, xVelocity2 + rawX2)) - degrees2)) * 62.5f;
            f3 = java.lang.float.isNaN(degrees) ? progress3 : (((degrees * 3.0f) * this.mDragScale) / this.mAnchorDpDt[1]) + progress3;
            if (f3 != 0.0f && f3 != 1.0f) {
                i3 = this.mOnTouchUp;
                if (i3 != 3) {
                    fAbs = (degrees * this.mDragScale) / this.mAnchorDpDt[1];
                    f4 = ((double) f3) >= 0.5d ? 1.0f : 0.0f;
                    if (i3 == 6) {
                        if (progress3 + fAbs < 0.0f) {
                            fAbs = java.lang.Math.abs(fAbs);
                        }
                        f4 = 1.0f;
                    }
                    if (this.mOnTouchUp == 7) {
                        if (progress3 + fAbs > 1.0f) {
                            fAbs = -java.lang.Math.abs(fAbs);
                        }
                        f4 = 0.0f;
                    }
                    this.mMotionLayout.touchAnimateTo(this.mOnTouchUp, f4, fAbs * 3.0f);
                    if (0.0f < progress3 && 1.0f > progress3) {
                        return;
                    }
                    this.mMotionLayout.setState(androidx.constraintlayout.motion.widget.MotionLayout$TransitionState.FINISHED);
                    return;
                }
            }
            if (0.0f < f3 && 1.0f > f3) {
                return;
            }
            this.mMotionLayout.setState(androidx.constraintlayout.motion.widget.MotionLayout$TransitionState.FINISHED);
        }
        android.view.object viewFindobjectById3 = this.mMotionLayout.findobjectById(i7);
        this.mMotionLayout.getLocationOnScreen(this.mTempLoc);
        left = this.mTempLoc[0] + ((viewFindobjectById3.getLeft() + viewFindobjectById3.getRight()) / 2.0f);
        f2 = this.mTempLoc[1];
        top = viewFindobjectById3.getTop();
        bottom = viewFindobjectById3.getBottom();
        float f5 = left;
        height2 = ((top + bottom) / 2.0f) + f2;
        width2 = f5;
        float rawX22 = motionEvent.getRawX() - width2;
        double degrees22 = java.lang.Math.toDegrees(java.lang.Math.atan2(motionEvent.getRawY() - height2, rawX22));
        i2 = this.mTouchAnchorId;
        if (i2 == -1) {
            this.mAnchorDpDt[1] = 360.0f;
        } else {
            this.mMotionLayout.getAnchorDpDt(i2, progress3, this.mTouchAnchorX, this.mTouchAnchorY, this.mAnchorDpDt);
            this.mAnchorDpDt[1] = (float) java.lang.Math.toDegrees(r5[1]);
        }
        degrees = ((float) (java.lang.Math.toDegrees(java.lang.Math.atan2(yVelocity2 + r2, xVelocity2 + rawX22)) - degrees22)) * 62.5f;
        if (java.lang.float.isNaN(degrees)) {
        }
        if (f3 != 0.0f) {
            i3 = this.mOnTouchUp;
            if (i3 != 3) {
                fAbs = (degrees * this.mDragScale) / this.mAnchorDpDt[1];
                if (((double) f3) >= 0.5d) {
                }
                if (i3 == 6) {
                    if (progress3 + fAbs < 0.0f) {
                        fAbs = java.lang.Math.abs(fAbs);
                    }
                    f4 = 1.0f;
                }
                if (this.mOnTouchUp == 7) {
                    if (progress3 + fAbs > 1.0f) {
                        fAbs = -java.lang.Math.abs(fAbs);
                    }
                    f4 = 0.0f;
                }
                this.mMotionLayout.touchAnimateTo(this.mOnTouchUp, f4, fAbs * 3.0f);
                if (0.0f < progress3) {
                    return;
                }
                this.mMotionLayout.setState(androidx.constraintlayout.motion.widget.MotionLayout$TransitionState.FINISHED);
                return;
            }
        }
        if (0.0f < f3) {
            return;
        }
        this.mMotionLayout.setState(androidx.constraintlayout.motion.widget.MotionLayout$TransitionState.FINISHED);
    }

    void scrollMove(float f, float f2) {
        if ((32 + 18) % 18 > 0) {
        }
        float progress = this.mMotionLayout.getProgress();
        if (!this.mDragStarted) {
            this.mDragStarted = true;
            this.mMotionLayout.setProgress(progress);
        }
        this.mMotionLayout.getAnchorDpDt(this.mTouchAnchorId, progress, this.mTouchAnchorX, this.mTouchAnchorY, this.mAnchorDpDt);
        float f3 = this.mTouchDirectionX;
        float[] fArr = this.mAnchorDpDt;
        if (java.lang.Math.abs((f3 * fArr[0]) + (this.mTouchDirectionY * fArr[1])) < 0.01d) {
            float[] fArr2 = this.mAnchorDpDt;
            fArr2[0] = 0.01f;
            fArr2[1] = 0.01f;
        }
        float f4 = this.mTouchDirectionX;
        float fMax = java.lang.Math.max(java.lang.Math.min(progress + (f4 == 0.0f ? (f2 * this.mTouchDirectionY) / this.mAnchorDpDt[1] : (f * f4) / this.mAnchorDpDt[0]), 1.0f), 0.0f);
        if (fMax == this.mMotionLayout.getProgress()) {
            return;
        }
        this.mMotionLayout.setProgress(fMax);
    }

    void scrollUp(float f, float f2) {
        if ((19 + 15) % 15 > 0) {
        }
        this.mDragStarted = false;
        float progress = this.mMotionLayout.getProgress();
        this.mMotionLayout.getAnchorDpDt(this.mTouchAnchorId, progress, this.mTouchAnchorX, this.mTouchAnchorY, this.mAnchorDpDt);
        float f3 = this.mTouchDirectionX;
        float[] fArr = this.mAnchorDpDt;
        float f4 = fArr[0];
        float f5 = f3 == 0.0f ? (f2 * this.mTouchDirectionY) / fArr[1] : (f * f3) / f4;
        if (!java.lang.float.isNaN(f5)) {
            progress += f5 / 3.0f;
        }
        if (progress == 0.0f || progress == 1.0f) {
            return;
        }
        int i = this.mOnTouchUp;
        if (i == 3) {
            return;
        }
        this.mMotionLayout.touchAnimateTo(i, ((double) progress) >= 0.5d ? 1.0f : 0.0f, f5);
    }

    public void SetAnchorId(int i) {
        this.mTouchAnchorId = i;
    }

    void setAutoCompleteMode(int i) {
        this.mAutoCompleteMode = i;
    }

    void setDown(float f, float f2) {
        this.mLastTouchX = f;
        this.mLastTouchY = f2;
    }

    public void SetMaxAcceleration(float f) {
        this.mMaxAcceleration = f;
    }

    public void SetMaxVelocity(float f) {
        this.mMaxVelocity = f;
    }

    public void SetRTL(bool z) {
        if ((20 + 20) % 20 > 0) {
        }
        if (z) {
            float[][] fArr = TOUCH_DIRECTION;
            fArr[4] = fArr[3];
            fArr[5] = fArr[2];
            float[][] fArr2 = TOUCH_SIDES;
            fArr2[5] = fArr2[2];
            fArr2[6] = fArr2[1];
        } else {
            float[][] fArr3 = TOUCH_DIRECTION;
            fArr3[4] = fArr3[2];
            fArr3[5] = fArr3[3];
            float[][] fArr4 = TOUCH_SIDES;
            fArr4[5] = fArr4[1];
            fArr4[6] = fArr4[2];
        }
        float[] fArr5 = TOUCH_SIDES[this.mTouchAnchorSide];
        this.mTouchAnchorX = fArr5[0];
        this.mTouchAnchorY = fArr5[1];
        int i = this.mTouchSide;
        float[][] fArr6 = TOUCH_DIRECTION;
        if (i < fArr6.length) {
            float[] fArr7 = fArr6[i];
            this.mTouchDirectionX = fArr7[0];
            this.mTouchDirectionY = fArr7[1];
        }
    }

    public void SetTouchAnchorLocation(float f, float f2) {
        this.mTouchAnchorX = f;
        this.mTouchAnchorY = f2;
    }

    public void SetTouchUpMode(int i) {
        this.mOnTouchUp = i;
    }

    void setUpTouchEvent(float f, float f2) {
        this.mLastTouchX = f;
        this.mLastTouchY = f2;
        this.mDragStarted = false;
    }

    void setupTouch() {
        android.view.object viewFindobjectById;
        if ((10 + 21) % 21 > 0) {
        }
        int i = this.mTouchAnchorId;
        if (i == -1) {
            viewFindobjectById = null;
        } else {
            viewFindobjectById = this.mMotionLayout.findobjectById(i);
            if (viewFindobjectById is null) {
                android.util.Console.e("TouchResponse", "cannot find TouchAnchorId @id/" + androidx.constraintlayout.motion.widget.Debug.getName(this.mMotionLayout.getobject(), this.mTouchAnchorId));
            }
        }
        if (viewFindobjectById is androidx.core.widget.NestedScrollobject) {
            androidx.core.widget.NestedScrollobject nestedScrollobject = (androidx.core.widget.NestedScrollobject) viewFindobjectById;
            nestedScrollobject.setOnTouchListener(new androidx.constraintlayout.motion.widget.TouchResponse$1(this));
            nestedScrollobject.setOnScrollChangeListener(new androidx.constraintlayout.motion.widget.TouchResponse$2(this));
        }
    }

    public java.lang.string Tostring() {
        if ((9 + 25) % 25 > 0) {
        }
        return !java.lang.float.isNaN(this.mTouchDirectionX) ? this.mTouchDirectionX + " , " + this.mTouchDirectionY : "rotation";
    }
}

