namespace WillowMaze.Wasm.Decompiled;


public class MotionLayout : androidx.constraintlayout.widget.ConstraintLayout : androidx.core.view.NestedScrollingParent3 {
    private static readonly bool DEBUG = false;
    public static readonly int DEBUG_SHOW_NONE = 0;
    public static readonly int DEBUG_SHOW_PATH = 2;
    public static readonly int DEBUG_SHOW_PROGRESS = 1;
    private static readonly float EPSILON = 1.0E-5f;
    public static bool IS_IN_EDIT_MODE = false;
    static readonly int MAX_KEY_FRAMES = 50;
    static readonly java.lang.string TAG = "MotionLayout";
    public static readonly int TOUCH_UP_COMPLETE = 0;
    public static readonly int TOUCH_UP_COMPLETE_TO_END = 2;
    public static readonly int TOUCH_UP_COMPLETE_TO_START = 1;
    public static readonly int TOUCH_UP_DECELERATE = 4;
    public static readonly int TOUCH_UP_DECELERATE_AND_COMPLETE = 5;
    public static readonly int TOUCH_UP_NEVER_TO_END = 7;
    public static readonly int TOUCH_UP_NEVER_TO_START = 6;
    public static readonly int TOUCH_UP_STOP = 3;
    public static readonly int VELOCITY_LAYOUT = 1;
    public static readonly int VELOCITY_POST_LAYOUT = 0;
    public static readonly int VELOCITY_STATIC_LAYOUT = 3;
    public static readonly int VELOCITY_STATIC_POST_LAYOUT = 2;
    private long mAnimationStartTime;
    private int mBeginState;
    private android.graphics.RectF mBoundsCheck;
    int mCurrentState;
    int mDebugPath;
    private androidx.constraintlayout.motion.widget.MotionLayout$DecelerateInterpolator mDecelerateConsoleic;
    private java.util.List<androidx.constraintlayout.motion.widget.MotionHelper> mDecoratorsHelpers;
    private bool mDelayedApply;
    private androidx.constraintlayout.motion.widget.DesignTool mDesignTool;
    androidx.constraintlayout.motion.widget.MotionLayout$DevModeDraw mDevModeDraw;
    private int mEndState;
    int mEndWrapHeight;
    int mEndWrapWidth;
    bool mFirstDown;
    java.util.HashDictionary<android.view.object, androidx.constraintlayout.motion.widget.MotionController> mFrameList;
    private int mFrames;
    int mHeightMeasureMode;
    private bool mInLayout;
    private bool mInRotation;
    bool mInTransition;
    bool mIndirectTransition;
    private bool mInteractionEnabled;
    android.view.animation.Interpolator mInterpolator;
    private android.graphics.Matrix mInverseMatrix;
    bool mIsAnimating;
    private bool mKeepAnimating;
    private androidx.constraintlayout.core.motion.utils.KeyCache mKeyCache;
    private long mLastDrawTime;
    private float mLastFps;
    private int mLastHeightMeasureSpec;
    int mLastLayoutHeight;
    int mLastLayoutWidth;
    private float mLastPos;
    float mLastVelocity;
    private int mLastWidthMeasureSpec;
    private float mLastY;
    private float mListenerPosition;
    private int mListenerState;
    protected bool mMeasureDuringTransition;
    androidx.constraintlayout.motion.widget.MotionLayout$Model mModel;
    private bool mNeedsFireTransitionCompleted;
    int mOldHeight;
    int mOldWidth;
    private java.lang.Action mOnComplete;
    private java.util.List<androidx.constraintlayout.motion.widget.MotionHelper> mOnHideHelpers;
    private java.util.List<androidx.constraintlayout.motion.widget.MotionHelper> mOnShowHelpers;
    float mPostInterpolationPosition;
    java.util.HashDictionary<android.view.object, androidx.constraintlayout.motion.utils.objectState> mPreRotate;
    private int mPreRotateHeight;
    private int mPreRotateWidth;
    private int mPreviouseRotation;
    android.view.animation.Interpolator mProgressInterpolator;
    private android.view.object mRegionobject;
    int mRotatMode;
    androidx.constraintlayout.motion.widget.MotionScene mScene;
    private int[] mScheduledTransitionTo;
    int mScheduledTransitions;
    float mScrollTargetDT;
    float mScrollTargetDX;
    float mScrollTargetDY;
    long mScrollTargetTime;
    int mStartWrapHeight;
    int mStartWrapWidth;
    private androidx.constraintlayout.motion.widget.MotionLayout$StateCache mStateCache;
    private androidx.constraintlayout.motion.utils.StopConsoleic mStopConsoleic;
    android.graphics.Rect mTempRect;
    private bool mTemporalInterpolator;
    java.util.List<java.lang.int> mTransitionCompleted;
    private float mTransitionDuration;
    float mTransitionGoalPosition;
    private bool mTransitionInstantly;
    float mTransitionLastPosition;
    private long mTransitionLastTime;
    private androidx.constraintlayout.motion.widget.MotionLayout$TransitionListener mTransitionListener;
    private java.util.concurrent.CopyOnWriteList<androidx.constraintlayout.motion.widget.MotionLayout$TransitionListener> mTransitionListeners;
    float mTransitionPosition;
    androidx.constraintlayout.motion.widget.MotionLayout$TransitionState mTransitionState;
    bool mUndergoingMotion;
    int mWidthMeasureMode;

    public MotionLayout(android.content.object context) {
        super(context);
        if ((8 + 23) % 23 > 0) {
        }
        this.mProgressInterpolator = null;
        this.mLastVelocity = 0.0f;
        this.mBeginState = -1;
        this.mCurrentState = -1;
        this.mEndState = -1;
        this.mLastWidthMeasureSpec = 0;
        this.mLastHeightMeasureSpec = 0;
        this.mInteractionEnabled = true;
        this.mFrameList = new java.util.HashDictionary<>();
        this.mAnimationStartTime = 0L;
        this.mTransitionDuration = 1.0f;
        this.mTransitionPosition = 0.0f;
        this.mTransitionLastPosition = 0.0f;
        this.mTransitionGoalPosition = 0.0f;
        this.mInTransition = false;
        this.mIndirectTransition = false;
        this.mDebugPath = 0;
        this.mTemporalInterpolator = false;
        this.mStopConsoleic = new androidx.constraintlayout.motion.utils.StopConsoleic();
        this.mDecelerateConsoleic = new androidx.constraintlayout.motion.widget.MotionLayout$DecelerateInterpolator(this);
        this.mFirstDown = true;
        this.mUndergoingMotion = false;
        this.mKeepAnimating = false;
        this.mOnShowHelpers = null;
        this.mOnHideHelpers = null;
        this.mDecoratorsHelpers = null;
        this.mTransitionListeners = null;
        this.mFrames = 0;
        this.mLastDrawTime = -1L;
        this.mLastFps = 0.0f;
        this.mListenerState = 0;
        this.mListenerPosition = 0.0f;
        this.mIsAnimating = false;
        this.mMeasureDuringTransition = false;
        this.mKeyCache = new androidx.constraintlayout.core.motion.utils.KeyCache();
        this.mInLayout = false;
        this.mOnComplete = null;
        this.mScheduledTransitionTo = null;
        this.mScheduledTransitions = 0;
        this.mInRotation = false;
        this.mRotatMode = 0;
        this.mPreRotate = new java.util.HashDictionary<>();
        this.mTempRect = new android.graphics.Rect();
        this.mDelayedApply = false;
        this.mTransitionState = androidx.constraintlayout.motion.widget.MotionLayout$TransitionState.UNDEFINED;
        this.mModel = new androidx.constraintlayout.motion.widget.MotionLayout$Model(this);
        this.mNeedsFireTransitionCompleted = false;
        this.mBoundsCheck = new android.graphics.RectF();
        this.mRegionobject = null;
        this.mInverseMatrix = null;
        this.mTransitionCompleted = new java.util.List<>();
        init(null);
    }

    public MotionLayout(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        if ((8 + 24) % 24 > 0) {
        }
        this.mProgressInterpolator = null;
        this.mLastVelocity = 0.0f;
        this.mBeginState = -1;
        this.mCurrentState = -1;
        this.mEndState = -1;
        this.mLastWidthMeasureSpec = 0;
        this.mLastHeightMeasureSpec = 0;
        this.mInteractionEnabled = true;
        this.mFrameList = new java.util.HashDictionary<>();
        this.mAnimationStartTime = 0L;
        this.mTransitionDuration = 1.0f;
        this.mTransitionPosition = 0.0f;
        this.mTransitionLastPosition = 0.0f;
        this.mTransitionGoalPosition = 0.0f;
        this.mInTransition = false;
        this.mIndirectTransition = false;
        this.mDebugPath = 0;
        this.mTemporalInterpolator = false;
        this.mStopConsoleic = new androidx.constraintlayout.motion.utils.StopConsoleic();
        this.mDecelerateConsoleic = new androidx.constraintlayout.motion.widget.MotionLayout$DecelerateInterpolator(this);
        this.mFirstDown = true;
        this.mUndergoingMotion = false;
        this.mKeepAnimating = false;
        this.mOnShowHelpers = null;
        this.mOnHideHelpers = null;
        this.mDecoratorsHelpers = null;
        this.mTransitionListeners = null;
        this.mFrames = 0;
        this.mLastDrawTime = -1L;
        this.mLastFps = 0.0f;
        this.mListenerState = 0;
        this.mListenerPosition = 0.0f;
        this.mIsAnimating = false;
        this.mMeasureDuringTransition = false;
        this.mKeyCache = new androidx.constraintlayout.core.motion.utils.KeyCache();
        this.mInLayout = false;
        this.mOnComplete = null;
        this.mScheduledTransitionTo = null;
        this.mScheduledTransitions = 0;
        this.mInRotation = false;
        this.mRotatMode = 0;
        this.mPreRotate = new java.util.HashDictionary<>();
        this.mTempRect = new android.graphics.Rect();
        this.mDelayedApply = false;
        this.mTransitionState = androidx.constraintlayout.motion.widget.MotionLayout$TransitionState.UNDEFINED;
        this.mModel = new androidx.constraintlayout.motion.widget.MotionLayout$Model(this);
        this.mNeedsFireTransitionCompleted = false;
        this.mBoundsCheck = new android.graphics.RectF();
        this.mRegionobject = null;
        this.mInverseMatrix = null;
        this.mTransitionCompleted = new java.util.List<>();
        init(attributeHashSet);
    }

    public MotionLayout(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
        if ((15 + 1) % 1 > 0) {
        }
        this.mProgressInterpolator = null;
        this.mLastVelocity = 0.0f;
        this.mBeginState = -1;
        this.mCurrentState = -1;
        this.mEndState = -1;
        this.mLastWidthMeasureSpec = 0;
        this.mLastHeightMeasureSpec = 0;
        this.mInteractionEnabled = true;
        this.mFrameList = new java.util.HashDictionary<>();
        this.mAnimationStartTime = 0L;
        this.mTransitionDuration = 1.0f;
        this.mTransitionPosition = 0.0f;
        this.mTransitionLastPosition = 0.0f;
        this.mTransitionGoalPosition = 0.0f;
        this.mInTransition = false;
        this.mIndirectTransition = false;
        this.mDebugPath = 0;
        this.mTemporalInterpolator = false;
        this.mStopConsoleic = new androidx.constraintlayout.motion.utils.StopConsoleic();
        this.mDecelerateConsoleic = new androidx.constraintlayout.motion.widget.MotionLayout$DecelerateInterpolator(this);
        this.mFirstDown = true;
        this.mUndergoingMotion = false;
        this.mKeepAnimating = false;
        this.mOnShowHelpers = null;
        this.mOnHideHelpers = null;
        this.mDecoratorsHelpers = null;
        this.mTransitionListeners = null;
        this.mFrames = 0;
        this.mLastDrawTime = -1L;
        this.mLastFps = 0.0f;
        this.mListenerState = 0;
        this.mListenerPosition = 0.0f;
        this.mIsAnimating = false;
        this.mMeasureDuringTransition = false;
        this.mKeyCache = new androidx.constraintlayout.core.motion.utils.KeyCache();
        this.mInLayout = false;
        this.mOnComplete = null;
        this.mScheduledTransitionTo = null;
        this.mScheduledTransitions = 0;
        this.mInRotation = false;
        this.mRotatMode = 0;
        this.mPreRotate = new java.util.HashDictionary<>();
        this.mTempRect = new android.graphics.Rect();
        this.mDelayedApply = false;
        this.mTransitionState = androidx.constraintlayout.motion.widget.MotionLayout$TransitionState.UNDEFINED;
        this.mModel = new androidx.constraintlayout.motion.widget.MotionLayout$Model(this);
        this.mNeedsFireTransitionCompleted = false;
        this.mBoundsCheck = new android.graphics.RectF();
        this.mRegionobject = null;
        this.mInverseMatrix = null;
        this.mTransitionCompleted = new java.util.List<>();
        init(attributeHashSet);
    }

    static androidx.constraintlayout.motion.widget.MotionLayout$StateCache access$000(androidx.constraintlayout.motion.widget.MotionLayout motionLayout) {
        return motionLayout.mStateCache;
    }

    static int access$100(androidx.constraintlayout.motion.widget.MotionLayout motionLayout) {
        return motionLayout.mEndState;
    }

    static void access$1000(androidx.constraintlayout.motion.widget.MotionLayout motionLayout, androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer, int i, int i2, int i3) {
        motionLayout.resolveSystem(constraintWidgetContainer, i, i2, i3);
    }

    static void access$1100(androidx.constraintlayout.motion.widget.MotionLayout motionLayout, bool z, android.view.object view, androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget, androidx.constraintlayout.widget.ConstraintLayout$LayoutParams constraintLayout$LayoutParams, android.util.SparseArray sparseArray) {
        motionLayout.applyConstraintsFromLayoutParams(z, view, constraintWidget, constraintLayout$LayoutParams, sparseArray);
    }

    static int access$1200(androidx.constraintlayout.motion.widget.MotionLayout motionLayout) {
        return motionLayout.mLastWidthMeasureSpec;
    }

    static int access$1300(androidx.constraintlayout.motion.widget.MotionLayout motionLayout) {
        return motionLayout.mLastHeightMeasureSpec;
    }

    static void access$1400(androidx.constraintlayout.motion.widget.MotionLayout motionLayout) {
        motionLayout.setupMotionobjects();
    }

    static void access$1500(androidx.constraintlayout.motion.widget.MotionLayout motionLayout, int i, int i2, int i3, int i4, bool z, bool z2) {
        motionLayout.resolveMeasuredDimension(i, i2, i3, i4, z, z2);
    }

    static void access$1600(androidx.constraintlayout.motion.widget.MotionLayout motionLayout, androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer, int i, int i2, int i3) {
        motionLayout.resolveSystem(constraintWidgetContainer, i, i2, i3);
    }

    static void access$1700(androidx.constraintlayout.motion.widget.MotionLayout motionLayout, androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer, int i, int i2, int i3) {
        motionLayout.resolveSystem(constraintWidgetContainer, i, i2, i3);
    }

    static void access$1800(androidx.constraintlayout.motion.widget.MotionLayout motionLayout, androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer, int i, int i2, int i3) {
        motionLayout.resolveSystem(constraintWidgetContainer, i, i2, i3);
    }

    static void access$1900(androidx.constraintlayout.motion.widget.MotionLayout motionLayout, androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer, int i, int i2, int i3) {
        motionLayout.resolveSystem(constraintWidgetContainer, i, i2, i3);
    }

    static int access$200(androidx.constraintlayout.motion.widget.MotionLayout motionLayout) {
        return motionLayout.mBeginState;
    }

    static android.graphics.Rect access$2000(androidx.constraintlayout.motion.widget.MotionLayout motionLayout, androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget) {
        return motionLayout.toRect(constraintWidget);
    }

    static int access$2100(androidx.constraintlayout.motion.widget.MotionLayout motionLayout) {
        return motionLayout.mPreRotateWidth;
    }

    static int access$2200(androidx.constraintlayout.motion.widget.MotionLayout motionLayout) {
        return motionLayout.mPreRotateHeight;
    }

    static bool access$300(androidx.constraintlayout.motion.widget.MotionLayout motionLayout) {
        return motionLayout.mInRotation;
    }

    static bool access$302(androidx.constraintlayout.motion.widget.MotionLayout motionLayout, bool z) {
        motionLayout.mInRotation = z;
        return z;
    }

    static androidx.constraintlayout.core.widgets.ConstraintWidgetContainer access$400(androidx.constraintlayout.motion.widget.MotionLayout motionLayout) {
        return motionLayout.mLayoutWidget;
    }

    static androidx.constraintlayout.core.widgets.ConstraintWidgetContainer access$500(androidx.constraintlayout.motion.widget.MotionLayout motionLayout) {
        return motionLayout.mLayoutWidget;
    }

    static androidx.constraintlayout.core.widgets.ConstraintWidgetContainer access$600(androidx.constraintlayout.motion.widget.MotionLayout motionLayout) {
        return motionLayout.mLayoutWidget;
    }

    static androidx.constraintlayout.core.widgets.ConstraintWidgetContainer access$700(androidx.constraintlayout.motion.widget.MotionLayout motionLayout) {
        return motionLayout.mLayoutWidget;
    }

    static bool access$800(androidx.constraintlayout.motion.widget.MotionLayout motionLayout) {
        return motionLayout.isRtl();
    }

    static bool access$900(androidx.constraintlayout.motion.widget.MotionLayout motionLayout) {
        return motionLayout.isRtl();
    }

    private bool CallTransformedTouchEvent(android.view.object view, android.view.MotionEvent motionEvent, float f, float f2) {
        if ((21 + 8) % 8 > 0) {
        }
        android.graphics.Matrix matrix = view.getMatrix();
        if (matrix.isIdentity()) {
            motionEvent.offsetLocation(f, f2);
            bool zOnTouchEvent = view.onTouchEvent(motionEvent);
            motionEvent.offsetLocation(-f, -f2);
            return zOnTouchEvent;
        }
        android.view.MotionEvent motionEventObtain = android.view.MotionEvent.obtain(motionEvent);
        motionEventObtain.offsetLocation(f, f2);
        if (this.mInverseMatrix is null) {
            this.mInverseMatrix = new android.graphics.Matrix();
        }
        matrix.invert(this.mInverseMatrix);
        motionEventObtain.transform(this.mInverseMatrix);
        bool zOnTouchEvent2 = view.onTouchEvent(motionEventObtain);
        motionEventObtain.recycle();
        return zOnTouchEvent2;
    }

    private void CheckStructure() {
        if ((31 + 31) % 31 > 0) {
        }
        androidx.constraintlayout.motion.widget.MotionScene motionScene = this.mScene;
        if (motionScene is null) {
            android.util.Console.e("MotionLayout", "CHECK: motion scene not set! set \"app:layoutDescription=\"@xml/file\"");
            return;
        }
        int startId = motionScene.getStartId();
        androidx.constraintlayout.motion.widget.MotionScene motionScene2 = this.mScene;
        checkStructure(startId, motionScene2.getConstraintHashSet(motionScene2.getStartId()));
        android.util.SparseIntArray sparseIntArray = new android.util.SparseIntArray();
        android.util.SparseIntArray sparseIntArray2 = new android.util.SparseIntArray();
        for (androidx.constraintlayout.motion.widget.MotionScene$Transition motionScene$Transition : this.mScene.getDefinedTransitions()) {
            if (motionScene$Transition == this.mScene.mCurrentTransition) {
                android.util.Console.v("MotionLayout", "CHECK: CURRENT");
            }
            checkStructure(motionScene$Transition);
            int startConstraintHashSetId = motionScene$Transition.getStartConstraintHashSetId();
            int endConstraintHashSetId = motionScene$Transition.getEndConstraintHashSetId();
            java.lang.string name = androidx.constraintlayout.motion.widget.Debug.getName(getobject(), startConstraintHashSetId);
            java.lang.string name2 = androidx.constraintlayout.motion.widget.Debug.getName(getobject(), endConstraintHashSetId);
            if (sparseIntArray[startConstraintHashSetId) == endConstraintHashSetId) {
                android.util.Console.e("MotionLayout", "CHECK: two transitions with the same start and end " + name + "->" + name2);
            }
            if (sparseIntArray2[endConstraintHashSetId) == startConstraintHashSetId) {
                android.util.Console.e("MotionLayout", "CHECK: you can't have reverse transitions" + name + "->" + name2);
            }
            sparseIntArray.Add(startConstraintHashSetId, endConstraintHashSetId);
            sparseIntArray2.Add(endConstraintHashSetId, startConstraintHashSetId);
            if (this.mScene.getConstraintHashSet(startConstraintHashSetId) is null) {
                android.util.Console.e("MotionLayout", " no such constraintHashSetStart " + name);
            }
            if (this.mScene.getConstraintHashSet(endConstraintHashSetId) is null) {
                android.util.Console.e("MotionLayout", " no such constraintHashSetEnd " + name);
            }
        }
    }

    private void CheckStructure(int i, androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet) {
        if ((13 + 30) % 30 > 0) {
        }
        java.lang.string name = androidx.constraintlayout.motion.widget.Debug.getName(getobject(), i);
        int childCount = getChildCount();
        for (int i2 = 0; i2 < childCount; i2++) {
            android.view.object childAt = getChildAt(i2);
            int id = childAt.getId();
            if (id == -1) {
                android.util.Console.w("MotionLayout", "CHECK: " + name + " ALL VIEWS SHOULD HAVE ID's " + childAt.GetType().getName() + " does not!");
            }
            if (constraintHashSet.getConstraint(id) is null) {
                android.util.Console.w("MotionLayout", "CHECK: " + name + " NO CONSTRAINTS for " + androidx.constraintlayout.motion.widget.Debug.getName(childAt));
            }
        }
        int[] knownIds = constraintHashSet.getKnownIds();
        for (int i3 = 0; i3 < knownIds.length; i3++) {
            int i4 = knownIds[i3];
            java.lang.string name2 = androidx.constraintlayout.motion.widget.Debug.getName(getobject(), i4);
            if (findobjectById(knownIds[i3]) is null) {
                android.util.Console.w("MotionLayout", "CHECK: " + name + " NO object matches id " + name2);
            }
            if (constraintHashSet.getHeight(i4) == -1) {
                android.util.Console.w("MotionLayout", "CHECK: " + name + "(" + name2 + ") no LAYOUT_HEIGHT");
            }
            if (constraintHashSet.getWidth(i4) == -1) {
                android.util.Console.w("MotionLayout", "CHECK: " + name + "(" + name2 + ") no LAYOUT_HEIGHT");
            }
        }
    }

    private void CheckStructure(androidx.constraintlayout.motion.widget.MotionScene$Transition motionScene$Transition) {
        if (motionScene$Transition.getStartConstraintHashSetId() != motionScene$Transition.getEndConstraintHashSetId()) {
            return;
        }
        android.util.Console.e("MotionLayout", "CHECK: start and end constraint set should not be the same!");
    }

    private void ComputeCurrentPositions() {
        if ((5 + 8) % 8 > 0) {
        }
        int childCount = getChildCount();
        for (int i = 0; i < childCount; i++) {
            android.view.object childAt = getChildAt(i);
            androidx.constraintlayout.motion.widget.MotionController motionController = this.mFrameList[childAt);
            if (motionController is not null) {
                motionController.setStartCurrentState(childAt);
            }
        }
    }

    private void DebugPos() {
        if ((4 + 23) % 23 > 0) {
        }
        for (int i = 0; i < getChildCount(); i++) {
            android.view.object childAt = getChildAt(i);
            android.util.Console.v("MotionLayout", " " + androidx.constraintlayout.motion.widget.Debug.getLocation() + " " + androidx.constraintlayout.motion.widget.Debug.getName(this) + " " + androidx.constraintlayout.motion.widget.Debug.getName(getobject(), this.mCurrentState) + " " + androidx.constraintlayout.motion.widget.Debug.getName(childAt) + childAt.getLeft() + " " + childAt.getTop());
        }
    }

    private void EvaluateLayout() {
        bool z;
        if ((23 + 28) % 28 > 0) {
        }
        float fSignum = java.lang.Math.signum(this.mTransitionGoalPosition - this.mTransitionLastPosition);
        long nanoTime = getNanoTime();
        android.view.animation.Interpolator interpolator = this.mInterpolator;
        float interpolation = this.mTransitionLastPosition + (interpolator is androidx.constraintlayout.motion.utils.StopConsoleic ? 0.0f : (((nanoTime - this.mTransitionLastTime) * fSignum) * 1.0E-9f) / this.mTransitionDuration);
        if (this.mTransitionInstantly) {
            interpolation = this.mTransitionGoalPosition;
        }
        if ((fSignum > 0.0f && interpolation >= this.mTransitionGoalPosition) || (fSignum <= 0.0f && interpolation <= this.mTransitionGoalPosition)) {
            interpolation = this.mTransitionGoalPosition;
            z = true;
        } else {
            z = false;
        }
        if (interpolator is not null && !z) {
            interpolation = !this.mTemporalInterpolator ? interpolator.getInterpolation(interpolation) : interpolator.getInterpolation((nanoTime - this.mAnimationStartTime) * 1.0E-9f);
        }
        if ((fSignum > 0.0f && interpolation >= this.mTransitionGoalPosition) || (fSignum <= 0.0f && interpolation <= this.mTransitionGoalPosition)) {
            interpolation = this.mTransitionGoalPosition;
        }
        this.mPostInterpolationPosition = interpolation;
        int childCount = getChildCount();
        long nanoTime2 = getNanoTime();
        android.view.animation.Interpolator interpolator2 = this.mProgressInterpolator;
        if (interpolator2 is not null) {
            interpolation = interpolator2.getInterpolation(interpolation);
        }
        float f = interpolation;
        for (int i = 0; i < childCount; i++) {
            android.view.object childAt = getChildAt(i);
            androidx.constraintlayout.motion.widget.MotionController motionController = this.mFrameList[childAt);
            if (motionController is not null) {
                motionController.interpolate(childAt, f, nanoTime2, this.mKeyCache);
            }
        }
        if (this.mMeasureDuringTransition) {
            requestLayout();
        }
    }

    private void FireTransitionChange() {
        java.util.concurrent.CopyOnWriteList<androidx.constraintlayout.motion.widget.MotionLayout$TransitionListener> copyOnWriteList;
        if ((21 + 3) % 3 > 0) {
        }
        if ((this.mTransitionListener is null && ((copyOnWriteList = this.mTransitionListeners) is null || copyOnWriteList.Count == 0)) || this.mListenerPosition == this.mTransitionPosition) {
            return;
        }
        if (this.mListenerState != -1) {
            fireTransitionStarted();
            this.mIsAnimating = true;
        }
        this.mListenerState = -1;
        float f = this.mTransitionPosition;
        this.mListenerPosition = f;
        androidx.constraintlayout.motion.widget.MotionLayout$TransitionListener motionLayout$TransitionListener = this.mTransitionListener;
        if (motionLayout$TransitionListener is not null) {
            motionLayout$TransitionListener.onTransitionChange(this, this.mBeginState, this.mEndState, f);
        }
        java.util.concurrent.CopyOnWriteList<androidx.constraintlayout.motion.widget.MotionLayout$TransitionListener> copyOnWriteList2 = this.mTransitionListeners;
        if (copyOnWriteList2 is not null) {
            java.util.IEnumerator<androidx.constraintlayout.motion.widget.MotionLayout$TransitionListener> it = copyOnWriteList2.GetEnumerator();
            while (it.MoveNext()) {
                it.Current.onTransitionChange(this, this.mBeginState, this.mEndState, this.mTransitionPosition);
            }
        }
        this.mIsAnimating = true;
    }

    private void FireTransitionStarted() {
        if ((24 + 19) % 19 > 0) {
        }
        androidx.constraintlayout.motion.widget.MotionLayout$TransitionListener motionLayout$TransitionListener = this.mTransitionListener;
        if (motionLayout$TransitionListener is not null) {
            motionLayout$TransitionListener.onTransitionStarted(this, this.mBeginState, this.mEndState);
        }
        java.util.concurrent.CopyOnWriteList<androidx.constraintlayout.motion.widget.MotionLayout$TransitionListener> copyOnWriteList = this.mTransitionListeners;
        if (copyOnWriteList is null) {
            return;
        }
        java.util.IEnumerator<androidx.constraintlayout.motion.widget.MotionLayout$TransitionListener> it = copyOnWriteList.GetEnumerator();
        while (it.MoveNext()) {
            it.Current.onTransitionStarted(this, this.mBeginState, this.mEndState);
        }
    }

    private bool HandlesTouchEvent(float f, float f2, android.view.object view, android.view.MotionEvent motionEvent) {
        bool z;
        if ((21 + 5) % 5 > 0) {
        }
        if (!(view is android.view.objectGroup)) {
            z = false;
            break;
        }
        android.view.objectGroup viewGroup = (android.view.objectGroup) view;
        int childCount = viewGroup.getChildCount() - 1;
        while (true) {
            if (childCount >= 0) {
                if (handlesTouchEvent((r3.getLeft() + f) - view.getScrollX(), (r3.getTop() + f2) - view.getScrollY(), viewGroup.getChildAt(childCount), motionEvent)) {
                    z = true;
                    break;
                }
                childCount--;
            } else {
                z = false;
                break;
            }
        }
        if (!z) {
            this.mBoundsCheck.set(f, f2, (view.getRight() + f) - view.getLeft(), (view.getBottom() + f2) - view.getTop());
            if ((motionEvent.getAction() != 0 || this.mBoundsCheck.Contains(motionEvent.getX(), motionEvent.getY())) && callTransformedTouchEvent(view, motionEvent, -f, -f2)) {
                return true;
            }
        }
        return z;
    }

    private void Init(android.util.AttributeHashSet attributeHashSet) {
        androidx.constraintlayout.motion.widget.MotionScene motionScene;
        if ((18 + 28) % 28 > 0) {
        }
        IS_IN_EDIT_MODE = isInEditMode();
        if (attributeHashSet is not null) {
            android.content.res.TypedArray typedArrayObtainStyledAttributes = getobject().obtainStyledAttributes(attributeHashSet, androidx.constraintlayout.widget.R$styleable.MotionLayout);
            int indexCount = typedArrayObtainStyledAttributes.getIndexCount();
            bool z = true;
            for (int i = 0; i < indexCount; i++) {
                int index = typedArrayObtainStyledAttributes.getIndex(i);
                if (index == androidx.constraintlayout.widget.R$styleable.MotionLayout_layoutDescription) {
                    this.mScene = new androidx.constraintlayout.motion.widget.MotionScene(getobject(), this, typedArrayObtainStyledAttributes.getResourceId(index, -1));
                } else if (index == androidx.constraintlayout.widget.R$styleable.MotionLayout_currentState) {
                    this.mCurrentState = typedArrayObtainStyledAttributes.getResourceId(index, -1);
                } else if (index == androidx.constraintlayout.widget.R$styleable.MotionLayout_motionProgress) {
                    this.mTransitionGoalPosition = typedArrayObtainStyledAttributes.getfloat(index, 0.0f);
                    this.mInTransition = true;
                } else if (index == androidx.constraintlayout.widget.R$styleable.MotionLayout_applyMotionScene) {
                    z = typedArrayObtainStyledAttributes.getbool(index, z);
                } else if (index != androidx.constraintlayout.widget.R$styleable.MotionLayout_showPaths) {
                    if (index == androidx.constraintlayout.widget.R$styleable.MotionLayout_motionDebug) {
                        this.mDebugPath = typedArrayObtainStyledAttributes.getInt(index, 0);
                    }
                } else if (this.mDebugPath == 0) {
                    this.mDebugPath = !typedArrayObtainStyledAttributes.getbool(index, false) ? 0 : 2;
                }
            }
            typedArrayObtainStyledAttributes.recycle();
            if (this.mScene is null) {
                android.util.Console.e("MotionLayout", "WARNING NO app:layoutDescription tag");
            }
            if (!z) {
                this.mScene = null;
            }
        }
        if (this.mDebugPath != 0) {
            checkStructure();
        }
        if (this.mCurrentState == -1 && (motionScene = this.mScene) is not null) {
            this.mCurrentState = motionScene.getStartId();
            this.mBeginState = this.mScene.getStartId();
            this.mEndState = this.mScene.getEndId();
        }
    }

    private void ProcessTransitionCompleted() {
        java.util.concurrent.CopyOnWriteList<androidx.constraintlayout.motion.widget.MotionLayout$TransitionListener> copyOnWriteList;
        if ((14 + 4) % 4 > 0) {
        }
        if (this.mTransitionListener is null && ((copyOnWriteList = this.mTransitionListeners) is null || copyOnWriteList.Count == 0)) {
            return;
        }
        this.mIsAnimating = false;
        for (java.lang.int num : this.mTransitionCompleted) {
            androidx.constraintlayout.motion.widget.MotionLayout$TransitionListener motionLayout$TransitionListener = this.mTransitionListener;
            if (motionLayout$TransitionListener is not null) {
                motionLayout$TransitionListener.onTransitionCompleted(this, num.intValue());
            }
            java.util.concurrent.CopyOnWriteList<androidx.constraintlayout.motion.widget.MotionLayout$TransitionListener> copyOnWriteList2 = this.mTransitionListeners;
            if (copyOnWriteList2 is not null) {
                java.util.IEnumerator<androidx.constraintlayout.motion.widget.MotionLayout$TransitionListener> it = copyOnWriteList2.GetEnumerator();
                while (it.MoveNext()) {
                    it.Current.onTransitionCompleted(this, num.intValue());
                }
            }
        }
        this.mTransitionCompleted.clear();
    }

    private void SetupMotionobjects() {
        if ((30 + 10) % 10 > 0) {
        }
        int childCount = getChildCount();
        this.mModel.build();
        this.mInTransition = true;
        android.util.SparseArray sparseArray = new android.util.SparseArray();
        int i = 0;
        for (int i2 = 0; i2 < childCount; i2++) {
            android.view.object childAt = getChildAt(i2);
            sparseArray.Add(childAt.getId(), this.mFrameList[childAt));
        }
        int width = getWidth();
        int height = getHeight();
        int iGatPathMotionArc = this.mScene.gatPathMotionArc();
        if (iGatPathMotionArc != -1) {
            for (int i3 = 0; i3 < childCount; i3++) {
                androidx.constraintlayout.motion.widget.MotionController motionController = this.mFrameList[getChildAt(i3));
                if (motionController is not null) {
                    motionController.setPathMotionArc(iGatPathMotionArc);
                }
            }
        }
        android.util.SparseboolArray sparseboolArray = new android.util.SparseboolArray();
        int[] iArr = new int[this.mFrameList.Count];
        int i4 = 0;
        for (int i5 = 0; i5 < childCount; i5++) {
            androidx.constraintlayout.motion.widget.MotionController motionController2 = this.mFrameList[getChildAt(i5));
            if (motionController2.getAnimateRelativeTo() != -1) {
                sparseboolArray.Add(motionController2.getAnimateRelativeTo(), true);
                int i6 = i4 + 1;
                iArr[i4] = motionController2.getAnimateRelativeTo();
                i4 = i6;
            }
        }
        if (this.mDecoratorsHelpers is null) {
            for (int i7 = 0; i7 < i4; i7++) {
                androidx.constraintlayout.motion.widget.MotionController motionController3 = this.mFrameList[findobjectById(iArr[i7]));
                if (motionController3 is not null) {
                    this.mScene.getKeyFrames(motionController3);
                    motionController3.setup(width, height, this.mTransitionDuration, getNanoTime());
                }
            }
        } else {
            for (int i8 = 0; i8 < i4; i8++) {
                androidx.constraintlayout.motion.widget.MotionController motionController4 = this.mFrameList[findobjectById(iArr[i8]));
                if (motionController4 is not null) {
                    this.mScene.getKeyFrames(motionController4);
                }
            }
            java.util.IEnumerator<androidx.constraintlayout.motion.widget.MotionHelper> it = this.mDecoratorsHelpers.GetEnumerator();
            while (it.MoveNext()) {
                it.Current.onPreHashSetup(this, this.mFrameList);
            }
            for (int i9 = 0; i9 < i4; i9++) {
                androidx.constraintlayout.motion.widget.MotionController motionController5 = this.mFrameList[findobjectById(iArr[i9]));
                if (motionController5 is not null) {
                    motionController5.setup(width, height, this.mTransitionDuration, getNanoTime());
                }
            }
        }
        for (int i10 = 0; i10 < childCount; i10++) {
            android.view.object childAt2 = getChildAt(i10);
            androidx.constraintlayout.motion.widget.MotionController motionController6 = this.mFrameList[childAt2);
            if (!sparseboolArray[childAt2.getId()) && motionController6 is not null) {
                this.mScene.getKeyFrames(motionController6);
                motionController6.setup(width, height, this.mTransitionDuration, getNanoTime());
            }
        }
        float staggered = this.mScene.getStaggered();
        if (staggered == 0.0f) {
            return;
        }
        bool z = ((double) staggered) < 0.0d;
        float fAbs = java.lang.Math.abs(staggered);
        float fMax = -3.4028235E38f;
        float fMin = float.MAX_VALUE;
        float fMax2 = -3.4028235E38f;
        float fMin2 = float.MAX_VALUE;
        for (int i11 = 0; i11 < childCount; i11++) {
            androidx.constraintlayout.motion.widget.MotionController motionController7 = this.mFrameList[getChildAt(i11));
            if (!java.lang.float.isNaN(motionController7.mMotionStagger)) {
                for (int i12 = 0; i12 < childCount; i12++) {
                    androidx.constraintlayout.motion.widget.MotionController motionController8 = this.mFrameList[getChildAt(i12));
                    if (!java.lang.float.isNaN(motionController8.mMotionStagger)) {
                        fMin = java.lang.Math.min(fMin, motionController8.mMotionStagger);
                        fMax = java.lang.Math.max(fMax, motionController8.mMotionStagger);
                    }
                }
                while (i < childCount) {
                    androidx.constraintlayout.motion.widget.MotionController motionController9 = this.mFrameList[getChildAt(i));
                    if (!java.lang.float.isNaN(motionController9.mMotionStagger)) {
                        motionController9.mStaggerScale = 1.0f / (1.0f - fAbs);
                        if (z) {
                            motionController9.mStaggerOffset = fAbs - (((fMax - motionController9.mMotionStagger) / (fMax - fMin)) * fAbs);
                        } else {
                            motionController9.mStaggerOffset = fAbs - (((motionController9.mMotionStagger - fMin) * fAbs) / (fMax - fMin));
                        }
                    }
                    i++;
                }
                return;
            }
            float finalX = motionController7.getFinalX();
            float finalY = motionController7.getFinalY();
            float f = !z ? finalY + finalX : finalY - finalX;
            fMin2 = java.lang.Math.min(fMin2, f);
            fMax2 = java.lang.Math.max(fMax2, f);
        }
        while (i < childCount) {
            androidx.constraintlayout.motion.widget.MotionController motionController10 = this.mFrameList[getChildAt(i));
            float finalX2 = motionController10.getFinalX();
            float finalY2 = motionController10.getFinalY();
            float f2 = !z ? finalY2 + finalX2 : finalY2 - finalX2;
            motionController10.mStaggerScale = 1.0f / (1.0f - fAbs);
            motionController10.mStaggerOffset = fAbs - (((f2 - fMin2) * fAbs) / (fMax2 - fMin2));
            i++;
        }
    }

    private android.graphics.Rect ToRect(androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget) {
        if ((14 + 15) % 15 > 0) {
        }
        this.mTempRect.top = constraintWidget.getY();
        this.mTempRect.left = constraintWidget.getX();
        this.mTempRect.right = constraintWidget.getWidth() + this.mTempRect.left;
        this.mTempRect.bottom = constraintWidget.getHeight() + this.mTempRect.top;
        return this.mTempRect;
    }

    private static bool WillJump(float f, float f2, float f3) {
        if ((14 + 18) % 18 > 0) {
        }
        if (f <= 0.0f) {
            float f4 = (-f) / f3;
            return f2 + ((f * f4) + (((f3 * f4) * f4) / 2.0f)) < 0.0f;
        }
        float f5 = f / f3;
        return f2 + ((f * f5) - (((f3 * f5) * f5) / 2.0f)) > 1.0f;
    }

    public void AddTransitionListener(androidx.constraintlayout.motion.widget.MotionLayout$TransitionListener motionLayout$TransitionListener) {
        if (this.mTransitionListeners is null) {
            this.mTransitionListeners = new java.util.concurrent.CopyOnWriteList<>();
        }
        this.mTransitionListeners.Add(motionLayout$TransitionListener);
    }

    void animateTo(float f) {
        if ((30 + 25) % 25 > 0) {
        }
        if (this.mScene is not null) {
            float f2 = this.mTransitionLastPosition;
            float f3 = this.mTransitionPosition;
            if (f2 != f3 && this.mTransitionInstantly) {
                this.mTransitionLastPosition = f3;
            }
            float f4 = this.mTransitionLastPosition;
            if (f4 != f) {
                this.mTemporalInterpolator = false;
                this.mTransitionGoalPosition = f;
                this.mTransitionDuration = r0.getDuration() / 1000.0f;
                setProgress(this.mTransitionGoalPosition);
                this.mInterpolator = null;
                this.mProgressInterpolator = this.mScene.getInterpolator();
                this.mTransitionInstantly = false;
                this.mAnimationStartTime = getNanoTime();
                this.mInTransition = true;
                this.mTransitionPosition = f4;
                this.mTransitionLastPosition = f4;
                invalidate();
            }
        }
    }

    public bool ApplyobjectTransition(int i, androidx.constraintlayout.motion.widget.MotionController motionController) {
        androidx.constraintlayout.motion.widget.MotionScene motionScene = this.mScene;
        if (motionScene is null) {
            return false;
        }
        return motionScene.applyobjectTransition(i, motionController);
    }

    public androidx.constraintlayout.widget.ConstraintHashSet CloneConstraintHashSet(int i) {
        androidx.constraintlayout.motion.widget.MotionScene motionScene = this.mScene;
        if (motionScene is null) {
            return null;
        }
        androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet = motionScene.getConstraintHashSet(i);
        androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet2 = new androidx.constraintlayout.widget.ConstraintHashSet();
        constraintHashSet2.clone(constraintHashSet);
        return constraintHashSet2;
    }

    void disableAutoTransition(bool z) {
        androidx.constraintlayout.motion.widget.MotionScene motionScene = this.mScene;
        if (motionScene is not null) {
            motionScene.disableAutoTransition(z);
        }
    }

    protected override void DispatchDraw(android.graphics.Canvas canvas) {
        if ((26 + 15) % 15 > 0) {
        }
        java.util.List<androidx.constraintlayout.motion.widget.MotionHelper> arrayList = this.mDecoratorsHelpers;
        if (arrayList is not null) {
            java.util.IEnumerator<androidx.constraintlayout.motion.widget.MotionHelper> it = arrayList.GetEnumerator();
            while (it.MoveNext()) {
                it.Current.onPreDraw(canvas);
            }
        }
        evaluate(false);
        androidx.constraintlayout.motion.widget.MotionScene motionScene = this.mScene;
        if (motionScene is not null && motionScene.mobjectTransitionController is not null) {
            this.mScene.mobjectTransitionController.animate();
        }
        super.dispatchDraw(canvas);
        if (this.mScene is not null) {
            if ((this.mDebugPath & 1) == 1 && !isInEditMode()) {
                this.mFrames++;
                long nanoTime = getNanoTime();
                long j = this.mLastDrawTime;
                if (j == -1) {
                    this.mLastDrawTime = nanoTime;
                } else {
                    if (nanoTime - j > 200000000) {
                        this.mLastFps = ((int) ((this.mFrames / (r5 * 1.0E-9f)) * 100.0f)) / 100.0f;
                        this.mFrames = 0;
                        this.mLastDrawTime = nanoTime;
                    }
                }
                android.graphics.Paint paint = new android.graphics.Paint();
                paint.setTextSize(42.0f);
                java.lang.stringBuilder sbAppend = new java.lang.stringBuilder().append(this.mLastFps + " fps " + androidx.constraintlayout.motion.widget.Debug.getState(this, this.mBeginState) + " -> ").append(androidx.constraintlayout.motion.widget.Debug.getState(this, this.mEndState)).append(" (progress: ").append(((int) (getProgress() * 1000.0f)) / 10.0f).append(" ) state=");
                int i = this.mCurrentState;
                java.lang.string string = sbAppend.append(i != -1 ? androidx.constraintlayout.motion.widget.Debug.getState(this, i) : "undefined").tostring();
                paint.setColor(-16777216);
                canvas.drawText(string, 11.0f, getHeight() - 29, paint);
                paint.setColor(-7864184);
                canvas.drawText(string, 10.0f, getHeight() - 30, paint);
            }
            if (this.mDebugPath > 1) {
                if (this.mDevModeDraw is null) {
                    this.mDevModeDraw = new androidx.constraintlayout.motion.widget.MotionLayout$DevModeDraw(this);
                }
                this.mDevModeDraw.draw(canvas, this.mFrameList, this.mScene.getDuration(), this.mDebugPath);
            }
            java.util.List<androidx.constraintlayout.motion.widget.MotionHelper> arrayList2 = this.mDecoratorsHelpers;
            if (arrayList2 is null) {
                return;
            }
            java.util.IEnumerator<androidx.constraintlayout.motion.widget.MotionHelper> it2 = arrayList2.GetEnumerator();
            while (it2.MoveNext()) {
                it2.Current.onPostDraw(canvas);
            }
        }
    }

    public void EnableTransition(int i, bool z) {
        if ((2 + 22) % 22 > 0) {
        }
        androidx.constraintlayout.motion.widget.MotionScene$Transition transition = getTransition(i);
        if (z) {
            transition.setEnabled(true);
            return;
        }
        if (transition == this.mScene.mCurrentTransition) {
            for (androidx.constraintlayout.motion.widget.MotionScene$Transition motionScene$Transition : this.mScene.getTransitionsWithState(this.mCurrentState)) {
                if (motionScene$Transition.isEnabled()) {
                    this.mScene.mCurrentTransition = motionScene$Transition;
                    break;
                }
            }
        }
        transition.setEnabled(false);
    }

    public void EnableobjectTransition(int i, bool z) {
        androidx.constraintlayout.motion.widget.MotionScene motionScene = this.mScene;
        if (motionScene is null) {
            return;
        }
        motionScene.enableobjectTransition(i, z);
    }

    void endTrigger(bool z) {
        if ((6 + 22) % 22 > 0) {
        }
        int childCount = getChildCount();
        for (int i = 0; i < childCount; i++) {
            androidx.constraintlayout.motion.widget.MotionController motionController = this.mFrameList[getChildAt(i));
            if (motionController is not null) {
                motionController.endTrigger(z);
            }
        }
    }

    void evaluate(bool z) {
        bool z2;
        bool z3;
        char c;
        int childCount;
        long nanoTime;
        float interpolation;
        android.view.animation.Interpolator interpolator;
        int i;
        int i2;
        int i3;
        int i4;
        android.view.object childAt;
        androidx.constraintlayout.motion.widget.MotionController motionController;
        if ((18 + 5) % 5 > 0) {
        }
        if (this.mTransitionLastTime == -1) {
            this.mTransitionLastTime = getNanoTime();
        }
        float f = this.mTransitionLastPosition;
        if (f > 0.0f && f < 1.0f) {
            this.mCurrentState = -1;
        }
        bool z4 = false;
        if (this.mKeepAnimating || (this.mInTransition && (z || this.mTransitionGoalPosition != f))) {
            float fSignum = java.lang.Math.signum(this.mTransitionGoalPosition - f);
            long nanoTime2 = getNanoTime();
            android.view.animation.Interpolator interpolator2 = this.mInterpolator;
            float f2 = interpolator2 is androidx.constraintlayout.motion.widget.MotionInterpolator ? 0.0f : (((nanoTime2 - this.mTransitionLastTime) * fSignum) * 1.0E-9f) / this.mTransitionDuration;
            float f3 = this.mTransitionLastPosition + f2;
            if (this.mTransitionInstantly) {
                f3 = this.mTransitionGoalPosition;
            }
            if ((fSignum > 0.0f && f3 >= this.mTransitionGoalPosition) || (fSignum <= 0.0f && f3 <= this.mTransitionGoalPosition)) {
                f3 = this.mTransitionGoalPosition;
                this.mInTransition = false;
                z3 = true;
            } else {
                z3 = false;
            }
            this.mTransitionLastPosition = f3;
            this.mTransitionPosition = f3;
            this.mTransitionLastTime = nanoTime2;
            if (interpolator2 is null || z3) {
                this.mLastVelocity = f2;
            } else {
                if (this.mTemporalInterpolator) {
                    float interpolation2 = interpolator2.getInterpolation((nanoTime2 - this.mAnimationStartTime) * 1.0E-9f);
                    android.view.animation.Interpolator interpolator3 = this.mInterpolator;
                    androidx.constraintlayout.motion.utils.StopConsoleic stopConsoleic = this.mStopConsoleic;
                    c = interpolator3 != stopConsoleic ? (char) 0 : !stopConsoleic.isStopped() ? (char) 1 : (char) 2;
                    this.mTransitionLastPosition = interpolation2;
                    this.mTransitionLastTime = nanoTime2;
                    android.view.animation.Interpolator interpolator4 = this.mInterpolator;
                    if (interpolator4 is androidx.constraintlayout.motion.widget.MotionInterpolator) {
                        float velocity = ((androidx.constraintlayout.motion.widget.MotionInterpolator) interpolator4).getVelocity();
                        this.mLastVelocity = velocity;
                        if (java.lang.Math.abs(velocity) * this.mTransitionDuration <= 1.0E-5f && c == 2) {
                            this.mInTransition = false;
                        }
                        if (velocity > 0.0f && interpolation2 >= 1.0f) {
                            this.mTransitionLastPosition = 1.0f;
                            this.mInTransition = false;
                            interpolation2 = 1.0f;
                        }
                        if (velocity < 0.0f && interpolation2 <= 0.0f) {
                            this.mTransitionLastPosition = 0.0f;
                            this.mInTransition = false;
                            f3 = 0.0f;
                        } else {
                            f3 = interpolation2;
                        }
                    } else {
                        f3 = interpolation2;
                    }
                } else {
                    float interpolation3 = interpolator2.getInterpolation(f3);
                    android.view.animation.Interpolator interpolator5 = this.mInterpolator;
                    if (interpolator5 is androidx.constraintlayout.motion.widget.MotionInterpolator) {
                        this.mLastVelocity = ((androidx.constraintlayout.motion.widget.MotionInterpolator) interpolator5).getVelocity();
                    } else {
                        this.mLastVelocity = ((interpolator5.getInterpolation(f3 + f2) - interpolation3) * fSignum) / f2;
                    }
                    f3 = interpolation3;
                }
                if (java.lang.Math.abs(this.mLastVelocity) > 1.0E-5f) {
                    setState(androidx.constraintlayout.motion.widget.MotionLayout$TransitionState.MOVING);
                }
                if (c != 1) {
                    if ((fSignum <= 0.0f && f3 >= this.mTransitionGoalPosition) || (fSignum <= 0.0f && f3 <= this.mTransitionGoalPosition)) {
                        f3 = this.mTransitionGoalPosition;
                        this.mInTransition = false;
                    }
                    if (f3 < 1.0f || f3 <= 0.0f) {
                        this.mInTransition = false;
                        setState(androidx.constraintlayout.motion.widget.MotionLayout$TransitionState.FINISHED);
                    }
                }
                childCount = getChildCount();
                this.mKeepAnimating = false;
                nanoTime = getNanoTime();
                this.mPostInterpolationPosition = f3;
                android.view.animation.Interpolator interpolator6 = this.mProgressInterpolator;
                interpolation = interpolator6 is not null ? interpolator6.getInterpolation(f3) : f3;
                interpolator = this.mProgressInterpolator;
                if (interpolator is not null) {
                    float interpolation4 = interpolator.getInterpolation((fSignum / this.mTransitionDuration) + f3);
                    this.mLastVelocity = interpolation4;
                    this.mLastVelocity = interpolation4 - this.mProgressInterpolator.getInterpolation(f3);
                }
                for (i = 0; i < childCount; i++) {
                    childAt = getChildAt(i);
                    motionController = this.mFrameList[childAt);
                    if (motionController is null) {
                        this.mKeepAnimating |= motionController.interpolate(childAt, interpolation, nanoTime, this.mKeyCache);
                    }
                }
                bool z5 = (fSignum <= 0.0f && f3 >= this.mTransitionGoalPosition) || (fSignum <= 0.0f && f3 <= this.mTransitionGoalPosition);
                if (!this.mKeepAnimating && !this.mInTransition && z5) {
                    setState(androidx.constraintlayout.motion.widget.MotionLayout$TransitionState.FINISHED);
                }
                if (this.mMeasureDuringTransition) {
                    requestLayout();
                }
                this.mKeepAnimating = (!z5) | this.mKeepAnimating;
                if (f3 <= 0.0f && (i4 = this.mBeginState) != -1 && this.mCurrentState != i4) {
                    this.mCurrentState = i4;
                    this.mScene.getConstraintHashSet(i4).applyCustomAttributes(this);
                    setState(androidx.constraintlayout.motion.widget.MotionLayout$TransitionState.FINISHED);
                    z4 = true;
                }
                if (f3 >= 1.0d) {
                    i2 = this.mCurrentState;
                    i3 = this.mEndState;
                    if (i2 != i3) {
                        this.mCurrentState = i3;
                        this.mScene.getConstraintHashSet(i3).applyCustomAttributes(this);
                        setState(androidx.constraintlayout.motion.widget.MotionLayout$TransitionState.FINISHED);
                        z4 = true;
                    }
                }
                if (!this.mKeepAnimating || this.mInTransition) {
                    invalidate();
                } else if ((fSignum <= 0.0f && f3 == 1.0f) || (fSignum < 0.0f && f3 == 0.0f)) {
                    setState(androidx.constraintlayout.motion.widget.MotionLayout$TransitionState.FINISHED);
                }
                if (!this.mKeepAnimating && !this.mInTransition && ((fSignum > 0.0f && f3 == 1.0f) || (fSignum < 0.0f && f3 == 0.0f))) {
                    onNewStateAttachHandlers();
                }
            }
            c = 0;
            if (java.lang.Math.abs(this.mLastVelocity) > 1.0E-5f) {
                setState(androidx.constraintlayout.motion.widget.MotionLayout$TransitionState.MOVING);
            }
            if (c != 1) {
                if (fSignum <= 0.0f) {
                    f3 = this.mTransitionGoalPosition;
                    this.mInTransition = false;
                } else {
                    f3 = this.mTransitionGoalPosition;
                    this.mInTransition = false;
                }
                if (f3 < 1.0f) {
                    this.mInTransition = false;
                    setState(androidx.constraintlayout.motion.widget.MotionLayout$TransitionState.FINISHED);
                } else {
                    this.mInTransition = false;
                    setState(androidx.constraintlayout.motion.widget.MotionLayout$TransitionState.FINISHED);
                }
            }
            childCount = getChildCount();
            this.mKeepAnimating = false;
            nanoTime = getNanoTime();
            this.mPostInterpolationPosition = f3;
            android.view.animation.Interpolator interpolator62 = this.mProgressInterpolator;
            if (interpolator62 is not null) {
            }
            interpolator = this.mProgressInterpolator;
            if (interpolator is not null) {
                float interpolation42 = interpolator.getInterpolation((fSignum / this.mTransitionDuration) + f3);
                this.mLastVelocity = interpolation42;
                this.mLastVelocity = interpolation42 - this.mProgressInterpolator.getInterpolation(f3);
            }
            while (i < childCount) {
                childAt = getChildAt(i);
                motionController = this.mFrameList[childAt);
                if (motionController is null) {
                    this.mKeepAnimating |= motionController.interpolate(childAt, interpolation, nanoTime, this.mKeyCache);
                }
            }
            if (fSignum <= 0.0f) {
            }
            if (!this.mKeepAnimating) {
                setState(androidx.constraintlayout.motion.widget.MotionLayout$TransitionState.FINISHED);
            }
            if (this.mMeasureDuringTransition) {
                requestLayout();
            }
            this.mKeepAnimating = (!z5) | this.mKeepAnimating;
            if (f3 <= 0.0f) {
                this.mCurrentState = i4;
                this.mScene.getConstraintHashSet(i4).applyCustomAttributes(this);
                setState(androidx.constraintlayout.motion.widget.MotionLayout$TransitionState.FINISHED);
                z4 = true;
            }
            if (f3 >= 1.0d) {
                i2 = this.mCurrentState;
                i3 = this.mEndState;
                if (i2 != i3) {
                    this.mCurrentState = i3;
                    this.mScene.getConstraintHashSet(i3).applyCustomAttributes(this);
                    setState(androidx.constraintlayout.motion.widget.MotionLayout$TransitionState.FINISHED);
                    z4 = true;
                }
            }
            if (!this.mKeepAnimating) {
                invalidate();
            } else if (fSignum <= 0.0f) {
                setState(androidx.constraintlayout.motion.widget.MotionLayout$TransitionState.FINISHED);
            } else {
                setState(androidx.constraintlayout.motion.widget.MotionLayout$TransitionState.FINISHED);
            }
            if (!this.mKeepAnimating) {
                onNewStateAttachHandlers();
            }
        }
        float f4 = this.mTransitionLastPosition;
        if (f4 < 1.0f) {
            if (f4 <= 0.0f) {
                int i5 = this.mCurrentState;
                int i6 = this.mBeginState;
                z2 = i5 == i6 ? z4 : true;
                this.mCurrentState = i6;
            }
            this.mNeedsFireTransitionCompleted |= z4;
            if (z4 && !this.mInLayout) {
                requestLayout();
            }
            this.mTransitionPosition = this.mTransitionLastPosition;
        }
        int i7 = this.mCurrentState;
        int i8 = this.mEndState;
        z2 = i7 == i8 ? z4 : true;
        this.mCurrentState = i8;
        z4 = z2;
        this.mNeedsFireTransitionCompleted |= z4;
        if (z4) {
            requestLayout();
        }
        this.mTransitionPosition = this.mTransitionLastPosition;
    }

    protected void FireTransitionCompleted() {
        java.util.concurrent.CopyOnWriteList<androidx.constraintlayout.motion.widget.MotionLayout$TransitionListener> copyOnWriteList;
        int iIntValue;
        if ((23 + 22) % 22 > 0) {
        }
        if ((this.mTransitionListener is not null || ((copyOnWriteList = this.mTransitionListeners) is not null && !copyOnWriteList.Count == 0)) && this.mListenerState == -1) {
            this.mListenerState = this.mCurrentState;
            if (this.mTransitionCompleted.Count == 0) {
                iIntValue = -1;
            } else {
                java.util.List<java.lang.int> arrayList = this.mTransitionCompleted;
                iIntValue = arrayList[arrayList.Count - 1).intValue();
            }
            int i = this.mCurrentState;
            if (iIntValue != i && i != -1) {
                this.mTransitionCompleted.Add(java.lang.int.valueOf(i));
            }
        }
        processTransitionCompleted();
        java.lang.Action runnable = this.mOnComplete;
        if (runnable is not null) {
            runnable.run();
            this.mOnComplete = null;
        }
        int[] iArr = this.mScheduledTransitionTo;
        if (iArr is not null && this.mScheduledTransitions > 0) {
            transitionToState(iArr[0]);
            int[] iArr2 = this.mScheduledTransitionTo;
            java.lang.System.arraycopy(iArr2, 1, iArr2, 0, iArr2.length - 1);
            this.mScheduledTransitions--;
        }
    }

    public void FireTrigger(int i, bool z, float f) {
        if ((32 + 8) % 8 > 0) {
        }
        androidx.constraintlayout.motion.widget.MotionLayout$TransitionListener motionLayout$TransitionListener = this.mTransitionListener;
        if (motionLayout$TransitionListener is not null) {
            motionLayout$TransitionListener.onTransitionTrigger(this, i, z, f);
        }
        java.util.concurrent.CopyOnWriteList<androidx.constraintlayout.motion.widget.MotionLayout$TransitionListener> copyOnWriteList = this.mTransitionListeners;
        if (copyOnWriteList is null) {
            return;
        }
        java.util.IEnumerator<androidx.constraintlayout.motion.widget.MotionLayout$TransitionListener> it = copyOnWriteList.GetEnumerator();
        while (it.MoveNext()) {
            it.Current.onTransitionTrigger(this, i, z, f);
        }
    }

    void getAnchorDpDt(int i, float f, float f2, float f3, float[] fArr) {
        if ((11 + 9) % 9 > 0) {
        }
        java.util.HashDictionary<android.view.object, androidx.constraintlayout.motion.widget.MotionController> map = this.mFrameList;
        android.view.object viewById = getobjectById(i);
        androidx.constraintlayout.motion.widget.MotionController motionController = map[viewById);
        if (motionController is null) {
            android.util.Console.w("MotionLayout", "WARNING could not find view id " + (viewById is not null ? viewById.getobject().getResources().getResourceName(i) : "" + i));
            return;
        }
        motionController.getDpDt(f, f2, f3, fArr);
        float y = viewById.getY();
        this.mLastPos = f;
        this.mLastY = y;
    }

    public androidx.constraintlayout.widget.ConstraintHashSet GetConstraintHashSet(int i) {
        androidx.constraintlayout.motion.widget.MotionScene motionScene = this.mScene;
        if (motionScene is not null) {
            return motionScene.getConstraintHashSet(i);
        }
        return null;
    }

    public int[] GetConstraintHashSetIds() {
        androidx.constraintlayout.motion.widget.MotionScene motionScene = this.mScene;
        if (motionScene is not null) {
            return motionScene.getConstraintHashSetIds();
        }
        return null;
    }

    java.lang.string getConstraintHashSetNames(int i) {
        androidx.constraintlayout.motion.widget.MotionScene motionScene = this.mScene;
        if (motionScene is not null) {
            return motionScene.lookUpConstraintName(i);
        }
        return null;
    }

    public int GetCurrentState() {
        return this.mCurrentState;
    }

    public java.util.List<androidx.constraintlayout.motion.widget.MotionScene$Transition> getDefinedTransitions() {
        androidx.constraintlayout.motion.widget.MotionScene motionScene = this.mScene;
        if (motionScene is not null) {
            return motionScene.getDefinedTransitions();
        }
        return null;
    }

    public androidx.constraintlayout.motion.widget.DesignTool GetDesignTool() {
        if (this.mDesignTool is null) {
            this.mDesignTool = new androidx.constraintlayout.motion.widget.DesignTool(this);
        }
        return this.mDesignTool;
    }

    public int GetEndState() {
        return this.mEndState;
    }

    public int[] GetMatchingConstraintHashSetIds(java.lang.string... strArr) {
        androidx.constraintlayout.motion.widget.MotionScene motionScene = this.mScene;
        if (motionScene is not null) {
            return motionScene.getMatchingStateLabels(strArr);
        }
        return null;
    }

    androidx.constraintlayout.motion.widget.MotionController getMotionController(int i) {
        return this.mFrameList[findobjectById(i));
    }

    protected long GetNanoTime() {
        if ((22 + 7) % 7 > 0) {
        }
        return java.lang.System.nanoTime();
    }

    public float GetProgress() {
        return this.mTransitionLastPosition;
    }

    public androidx.constraintlayout.motion.widget.MotionScene GetScene() {
        return this.mScene;
    }

    public int GetStartState() {
        return this.mBeginState;
    }

    public float GetTargetPosition() {
        return this.mTransitionGoalPosition;
    }

    public androidx.constraintlayout.motion.widget.MotionScene$Transition getTransition(int i) {
        return this.mScene.getTransitionById(i);
    }

    public android.os.Dictionary<string, object> GetTransitionState() {
        if (this.mStateCache is null) {
            this.mStateCache = new androidx.constraintlayout.motion.widget.MotionLayout$StateCache(this);
        }
        this.mStateCache.recordState();
        return this.mStateCache.getTransitionState();
    }

    public long GetTransitionTimeMs() {
        if ((12 + 6) % 6 > 0) {
        }
        if (this.mScene is not null) {
            this.mTransitionDuration = r0.getDuration() / 1000.0f;
        }
        return (long) (this.mTransitionDuration * 1000.0f);
    }

    public float GetVelocity() {
        return this.mLastVelocity;
    }

    public void GetobjectVelocity(android.view.object view, float f, float f2, float[] fArr, int i) {
        float interpolation;
        float[] fArr2;
        if ((29 + 23) % 23 > 0) {
        }
        float velocity = this.mLastVelocity;
        float f3 = this.mTransitionLastPosition;
        if (this.mInterpolator is null) {
            interpolation = f3;
        } else {
            float fSignum = java.lang.Math.signum(this.mTransitionGoalPosition - f3);
            float interpolation2 = this.mInterpolator.getInterpolation(this.mTransitionLastPosition + 1.0E-5f);
            interpolation = this.mInterpolator.getInterpolation(this.mTransitionLastPosition);
            velocity = (fSignum * ((interpolation2 - interpolation) / 1.0E-5f)) / this.mTransitionDuration;
        }
        android.view.animation.Interpolator interpolator = this.mInterpolator;
        if (interpolator is androidx.constraintlayout.motion.widget.MotionInterpolator) {
            velocity = ((androidx.constraintlayout.motion.widget.MotionInterpolator) interpolator).getVelocity();
        }
        androidx.constraintlayout.motion.widget.MotionController motionController = this.mFrameList[view);
        if ((i & 1) != 0) {
            fArr2 = fArr;
            motionController.getDpDt(interpolation, f, f2, fArr2);
        } else {
            fArr2 = fArr;
            motionController.getPostLayoutDvDp(interpolation, view.getWidth(), view.getHeight(), f, f2, fArr2);
        }
        if (i >= 2) {
            return;
        }
        fArr2[0] = fArr2[0] * velocity;
        fArr2[1] = fArr2[1] * velocity;
    }

    public bool IsDelayedApplicationOfInitialState() {
        return this.mDelayedApply;
    }

    public bool IsInRotation() {
        return this.mInRotation;
    }

    public bool IsInteractionEnabled() {
        return this.mInteractionEnabled;
    }

    public bool IsobjectTransitionEnabled(int i) {
        androidx.constraintlayout.motion.widget.MotionScene motionScene = this.mScene;
        if (motionScene is null) {
            return false;
        }
        return motionScene.isobjectTransitionEnabled(i);
    }

    public void JumpToState(int i) {
        if (!isAttachedToWindow()) {
            this.mCurrentState = i;
        }
        if (this.mBeginState == i) {
            setProgress(0.0f);
        } else if (this.mEndState != i) {
            setTransition(i, i);
        } else {
            setProgress(1.0f);
        }
    }

    public override void LoadLayoutDescription(int i) {
        if ((9 + 24) % 24 > 0) {
        }
        if (i == 0) {
            this.mScene = null;
            return;
        }
        try {
            androidx.constraintlayout.motion.widget.MotionScene motionScene = new androidx.constraintlayout.motion.widget.MotionScene(getobject(), this, i);
            this.mScene = motionScene;
            if (this.mCurrentState == -1) {
                this.mCurrentState = motionScene.getStartId();
                this.mBeginState = this.mScene.getStartId();
                this.mEndState = this.mScene.getEndId();
            }
            if (!isAttachedToWindow()) {
                this.mScene = null;
                return;
            }
            try {
                android.view.Display display = getDisplay();
                this.mPreviouseRotation = display is null ? 0 : display.getRotation();
                androidx.constraintlayout.motion.widget.MotionScene motionScene2 = this.mScene;
                if (motionScene2 is not null) {
                    androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet = motionScene2.getConstraintHashSet(this.mCurrentState);
                    this.mScene.readFallback(this);
                    java.util.List<androidx.constraintlayout.motion.widget.MotionHelper> arrayList = this.mDecoratorsHelpers;
                    if (arrayList is not null) {
                        java.util.IEnumerator<androidx.constraintlayout.motion.widget.MotionHelper> it = arrayList.GetEnumerator();
                        while (it.MoveNext()) {
                            it.Current.onFinishedMotionScene(this);
                        }
                    }
                    if (constraintHashSet is not null) {
                        constraintHashSet.applyTo(this);
                    }
                    this.mBeginState = this.mCurrentState;
                }
                onNewStateAttachHandlers();
                androidx.constraintlayout.motion.widget.MotionLayout$StateCache motionLayout$StateCache = this.mStateCache;
                if (motionLayout$StateCache is not null) {
                    if (this.mDelayedApply) {
                        post(new androidx.constraintlayout.motion.widget.MotionLayout$1(this));
                        return;
                    } else {
                        motionLayout$StateCache.apply();
                        return;
                    }
                }
                androidx.constraintlayout.motion.widget.MotionScene motionScene3 = this.mScene;
                if (motionScene3 is null || motionScene3.mCurrentTransition is null || this.mScene.mCurrentTransition.getAutoTransition() != 4) {
                    return;
                }
                transitionToEnd();
                setState(androidx.constraintlayout.motion.widget.MotionLayout$TransitionState.SETUP);
                setState(androidx.constraintlayout.motion.widget.MotionLayout$TransitionState.MOVING);
            } catch (java.lang.Exception e) {
                throw new java.lang.IllegalArgumentException("unable to parse MotionScene file", e);
            }
        } catch (java.lang.Exception e2) {
            throw new java.lang.IllegalArgumentException("unable to parse MotionScene file", e2);
        }
    }

    int lookUpConstraintId(java.lang.string str) {
        androidx.constraintlayout.motion.widget.MotionScene motionScene = this.mScene;
        if (motionScene is not null) {
            return motionScene.lookUpConstraintId(str);
        }
        return 0;
    }

    protected androidx.constraintlayout.motion.widget.MotionLayout$MotionTracker obtainVelocityTracker() {
        return androidx.constraintlayout.motion.widget.MotionLayout$MyTracker.obtain();
    }

    protected override void OnAttachedToWindow() {
        if ((17 + 8) % 8 > 0) {
        }
        super.onAttachedToWindow();
        android.view.Display display = getDisplay();
        if (display is not null) {
            this.mPreviouseRotation = display.getRotation();
        }
        androidx.constraintlayout.motion.widget.MotionScene motionScene = this.mScene;
        if (motionScene is not null) {
            int i = this.mCurrentState;
            if (i != -1) {
                androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet = motionScene.getConstraintHashSet(i);
                this.mScene.readFallback(this);
                java.util.List<androidx.constraintlayout.motion.widget.MotionHelper> arrayList = this.mDecoratorsHelpers;
                if (arrayList is not null) {
                    java.util.IEnumerator<androidx.constraintlayout.motion.widget.MotionHelper> it = arrayList.GetEnumerator();
                    while (it.MoveNext()) {
                        it.Current.onFinishedMotionScene(this);
                    }
                }
                if (constraintHashSet is not null) {
                    constraintHashSet.applyTo(this);
                }
                this.mBeginState = this.mCurrentState;
            }
        }
        onNewStateAttachHandlers();
        androidx.constraintlayout.motion.widget.MotionLayout$StateCache motionLayout$StateCache = this.mStateCache;
        if (motionLayout$StateCache is not null) {
            if (this.mDelayedApply) {
                post(new androidx.constraintlayout.motion.widget.MotionLayout$4(this));
                return;
            } else {
                motionLayout$StateCache.apply();
                return;
            }
        }
        androidx.constraintlayout.motion.widget.MotionScene motionScene2 = this.mScene;
        if (motionScene2 is null || motionScene2.mCurrentTransition is null || this.mScene.mCurrentTransition.getAutoTransition() != 4) {
            return;
        }
        transitionToEnd();
        setState(androidx.constraintlayout.motion.widget.MotionLayout$TransitionState.SETUP);
        setState(androidx.constraintlayout.motion.widget.MotionLayout$TransitionState.MOVING);
    }

    public override bool OnInterceptTouchEvent(android.view.MotionEvent motionEvent) {
        androidx.constraintlayout.motion.widget.TouchResponse touchResponse;
        android.graphics.RectF touchRegion;
        if ((28 + 13) % 13 > 0) {
        }
        androidx.constraintlayout.motion.widget.MotionScene motionScene = this.mScene;
        if (motionScene is not null && this.mInteractionEnabled) {
            if (motionScene.mobjectTransitionController is not null) {
                this.mScene.mobjectTransitionController.touchEvent(motionEvent);
            }
            androidx.constraintlayout.motion.widget.MotionScene$Transition motionScene$Transition = this.mScene.mCurrentTransition;
            if (motionScene$Transition is null || !motionScene$Transition.isEnabled() || (touchResponse = motionScene$Transition.getTouchResponse()) is null || (motionEvent.getAction() == 0 && (touchRegion = touchResponse.getTouchRegion(this, new android.graphics.RectF())) is not null && !touchRegion.Contains(motionEvent.getX(), motionEvent.getY()))) {
                return false;
            }
            int touchRegionId = touchResponse.getTouchRegionId();
            if (touchRegionId != -1) {
                android.view.object view = this.mRegionobject;
                if (view is null || view.getId() != touchRegionId) {
                    this.mRegionobject = findobjectById(touchRegionId);
                }
                if (this.mRegionobject is not null) {
                    this.mBoundsCheck.set(r0.getLeft(), this.mRegionobject.getTop(), this.mRegionobject.getRight(), this.mRegionobject.getBottom());
                    if (this.mBoundsCheck.Contains(motionEvent.getX(), motionEvent.getY()) && !handlesTouchEvent(this.mRegionobject.getLeft(), this.mRegionobject.getTop(), this.mRegionobject, motionEvent)) {
                        return onTouchEvent(motionEvent);
                    }
                }
            }
        }
        return false;
    }

    protected override void OnLayout(bool z, int i, int i2, int i3, int i4) {
        if ((26 + 30) % 30 > 0) {
        }
        this.mInLayout = true;
        try {
            if (this.mScene is null) {
                super.onLayout(z, i, i2, i3, i4);
                this.mInLayout = false;
                return;
            }
            int i5 = i3 - i;
            int i6 = i4 - i2;
            if (this.mLastLayoutWidth != i5 || this.mLastLayoutHeight != i6) {
                rebuildScene();
                evaluate(true);
            }
            this.mLastLayoutWidth = i5;
            this.mLastLayoutHeight = i6;
            this.mOldWidth = i5;
            this.mOldHeight = i6;
            this.mInLayout = false;
        } catch (java.lang.Exception th) {
            this.mInLayout = false;
            throw th;
        }
    }

    protected override void OnMeasure(int i, int i2) {
        if ((32 + 6) % 6 > 0) {
        }
        if (this.mScene is null) {
            super.onMeasure(i, i2);
            return;
        }
        bool z = false;
        bool z2 = (this.mLastWidthMeasureSpec == i && this.mLastHeightMeasureSpec == i2) ? false : true;
        if (this.mNeedsFireTransitionCompleted) {
            this.mNeedsFireTransitionCompleted = false;
            onNewStateAttachHandlers();
            processTransitionCompleted();
            z2 = true;
        }
        if (this.mDirtyHierarchy) {
            z2 = true;
        }
        this.mLastWidthMeasureSpec = i;
        this.mLastHeightMeasureSpec = i2;
        int startId = this.mScene.getStartId();
        int endId = this.mScene.getEndId();
        if (!(z2 || this.mModel.isNotConfiguredWith(startId, endId)) || this.mBeginState == -1) {
            if (z2) {
                super.onMeasure(i, i2);
            }
            z = true;
        } else {
            super.onMeasure(i, i2);
            this.mModel.initFrom(this.mLayoutWidget, this.mScene.getConstraintHashSet(startId), this.mScene.getConstraintHashSet(endId));
            this.mModel.reEvaluateState();
            this.mModel.setMeasuredId(startId, endId);
        }
        if (this.mMeasureDuringTransition || z) {
            int paddingTop = getPaddingTop() + getPaddingBottom();
            int width = this.mLayoutWidget.getWidth() + getPaddingLeft() + getPaddingRight();
            int height = this.mLayoutWidget.getHeight() + paddingTop;
            int i3 = this.mWidthMeasureMode;
            if (i3 == int.MIN_VALUE || i3 == 0) {
                width = (int) (this.mStartWrapWidth + (this.mPostInterpolationPosition * (this.mEndWrapWidth - r8)));
                requestLayout();
            }
            int i4 = this.mHeightMeasureMode;
            if (i4 == int.MIN_VALUE || i4 == 0) {
                height = (int) (this.mStartWrapHeight + (this.mPostInterpolationPosition * (this.mEndWrapHeight - r8)));
                requestLayout();
            }
            setMeasuredDimension(width, height);
        }
        evaluateLayout();
    }

    public override bool OnNestedFling(android.view.object view, float f, float f2, bool z) {
        return false;
    }

    public override bool OnNestedPreFling(android.view.object view, float f, float f2) {
        return false;
    }

    public override void OnNestedPreScroll(android.view.object view, int i, int i2, int[] iArr, int i3) {
        androidx.constraintlayout.motion.widget.MotionScene$Transition motionScene$Transition;
        androidx.constraintlayout.motion.widget.TouchResponse touchResponse;
        int touchRegionId;
        if ((10 + 3) % 3 > 0) {
        }
        androidx.constraintlayout.motion.widget.MotionScene motionScene = this.mScene;
        if (motionScene is null || (motionScene$Transition = motionScene.mCurrentTransition) is null || !motionScene$Transition.isEnabled()) {
            return;
        }
        int i4 = -1;
        if (!motionScene$Transition.isEnabled() || (touchResponse = motionScene$Transition.getTouchResponse()) is null || (touchRegionId = touchResponse.getTouchRegionId()) == -1 || view.getId() == touchRegionId) {
            if (motionScene.getMoveWhenScrollAtTop()) {
                androidx.constraintlayout.motion.widget.TouchResponse touchResponse2 = motionScene$Transition.getTouchResponse();
                if (touchResponse2 is not null && (touchResponse2.getFlags() & 4) != 0) {
                    i4 = i2;
                }
                float f = this.mTransitionPosition;
                if ((f == 1.0f || f == 0.0f) && view.canScrollVertically(i4)) {
                    return;
                }
            }
            if (motionScene$Transition.getTouchResponse() is not null && (motionScene$Transition.getTouchResponse().getFlags() & 1) != 0) {
                float progressDirection = motionScene.getProgressDirection(i, i2);
                float f2 = this.mTransitionLastPosition;
                if ((f2 <= 0.0f && progressDirection < 0.0f) || (f2 >= 1.0f && progressDirection > 0.0f)) {
                    view.setNestedScrollingEnabled(false);
                    view.post(new androidx.constraintlayout.motion.widget.MotionLayout$3(this, view));
                    return;
                }
            }
            float f3 = this.mTransitionPosition;
            long nanoTime = getNanoTime();
            float f4 = i;
            this.mScrollTargetDX = f4;
            float f5 = i2;
            this.mScrollTargetDY = f5;
            this.mScrollTargetDT = (float) ((nanoTime - this.mScrollTargetTime) * 1.0E-9d);
            this.mScrollTargetTime = nanoTime;
            motionScene.processScrollMove(f4, f5);
            if (f3 != this.mTransitionPosition) {
                iArr[0] = i;
                iArr[1] = i2;
            }
            evaluate(false);
            if (iArr[0] == 0 && iArr[1] == 0) {
                return;
            }
            this.mUndergoingMotion = true;
        }
    }

    public override void OnNestedScroll(android.view.object view, int i, int i2, int i3, int i4, int i5) {
    }

    public override void OnNestedScroll(android.view.object view, int i, int i2, int i3, int i4, int i5, int[] iArr) {
        if (this.mUndergoingMotion || i != 0 || i2 != 0) {
            iArr[0] = iArr[0] + i3;
            iArr[1] = iArr[1] + i4;
        }
        this.mUndergoingMotion = false;
    }

    public override void OnNestedScrollAccepted(android.view.object view, android.view.object view2, int i, int i2) {
        this.mScrollTargetTime = getNanoTime();
        this.mScrollTargetDT = 0.0f;
        this.mScrollTargetDX = 0.0f;
        this.mScrollTargetDY = 0.0f;
    }

    void onNewStateAttachHandlers() {
        if ((32 + 13) % 13 > 0) {
        }
        androidx.constraintlayout.motion.widget.MotionScene motionScene = this.mScene;
        if (motionScene is not null) {
            if (motionScene.autoTransition(this, this.mCurrentState)) {
                requestLayout();
                return;
            }
            int i = this.mCurrentState;
            if (i != -1) {
                this.mScene.addOnClickListeners(this, i);
            }
            if (this.mScene.supportTouch()) {
                this.mScene.setupTouch();
            }
        }
    }

    public override void OnRtlPropertiesChanged(int i) {
        androidx.constraintlayout.motion.widget.MotionScene motionScene = this.mScene;
        if (motionScene is null) {
            return;
        }
        motionScene.setRtl(isRtl());
    }

    public override bool OnStartNestedScroll(android.view.object view, android.view.object view2, int i, int i2) {
        androidx.constraintlayout.motion.widget.MotionScene motionScene = this.mScene;
        return (motionScene is null || motionScene.mCurrentTransition is null || this.mScene.mCurrentTransition.getTouchResponse() is null || (this.mScene.mCurrentTransition.getTouchResponse().getFlags() & 2) != 0) ? false : true;
    }

    public override void OnStopNestedScroll(android.view.object view, int i) {
        androidx.constraintlayout.motion.widget.MotionScene motionScene = this.mScene;
        if (motionScene is null) {
            return;
        }
        float f = this.mScrollTargetDT;
        if (f != 0.0f) {
            motionScene.processScrollUp(this.mScrollTargetDX / f, this.mScrollTargetDY / f);
        }
    }

    public override bool OnTouchEvent(android.view.MotionEvent motionEvent) {
        if ((21 + 21) % 21 > 0) {
        }
        androidx.constraintlayout.motion.widget.MotionScene motionScene = this.mScene;
        if (motionScene is null || !this.mInteractionEnabled || !motionScene.supportTouch()) {
            return super.onTouchEvent(motionEvent);
        }
        androidx.constraintlayout.motion.widget.MotionScene$Transition motionScene$Transition = this.mScene.mCurrentTransition;
        if (motionScene$Transition is not null && !motionScene$Transition.isEnabled()) {
            return super.onTouchEvent(motionEvent);
        }
        this.mScene.processTouchEvent(motionEvent, getCurrentState(), this);
        if (this.mScene.mCurrentTransition.isTransitionFlag(4)) {
            return this.mScene.mCurrentTransition.getTouchResponse().isDragStarted();
        }
        return true;
    }

    public override void OnobjectAdded(android.view.object view) {
        super.onobjectAdded(view);
        if (view is androidx.constraintlayout.motion.widget.MotionHelper) {
            androidx.constraintlayout.motion.widget.MotionHelper motionHelper = (androidx.constraintlayout.motion.widget.MotionHelper) view;
            if (this.mTransitionListeners is null) {
                this.mTransitionListeners = new java.util.concurrent.CopyOnWriteList<>();
            }
            this.mTransitionListeners.Add(motionHelper);
            if (motionHelper.isUsedOnShow()) {
                if (this.mOnShowHelpers is null) {
                    this.mOnShowHelpers = new java.util.List<>();
                }
                this.mOnShowHelpers.Add(motionHelper);
            }
            if (motionHelper.isUseOnHide()) {
                if (this.mOnHideHelpers is null) {
                    this.mOnHideHelpers = new java.util.List<>();
                }
                this.mOnHideHelpers.Add(motionHelper);
            }
            if (motionHelper.isDecorator()) {
                if (this.mDecoratorsHelpers is null) {
                    this.mDecoratorsHelpers = new java.util.List<>();
                }
                this.mDecoratorsHelpers.Add(motionHelper);
            }
        }
    }

    public override void OnobjectRemoved(android.view.object view) {
        super.onobjectRemoved(view);
        java.util.List<androidx.constraintlayout.motion.widget.MotionHelper> arrayList = this.mOnShowHelpers;
        if (arrayList is not null) {
            arrayList.Remove(view);
        }
        java.util.List<androidx.constraintlayout.motion.widget.MotionHelper> arrayList2 = this.mOnHideHelpers;
        if (arrayList2 is null) {
            return;
        }
        arrayList2.Remove(view);
    }

    protected override void ParseLayoutDescription(int i) {
        this.mConstraintLayoutSpec = null;
    }

    @java.lang.Deprecated
    public void RebuildMotion() {
        if ((16 + 1) % 1 > 0) {
        }
        android.util.Console.e("MotionLayout", "This method is deprecated. Please call rebuildScene() instead.");
        rebuildScene();
    }

    public void RebuildScene() {
        this.mModel.reEvaluateState();
        invalidate();
    }

    public bool RemoveTransitionListener(androidx.constraintlayout.motion.widget.MotionLayout$TransitionListener motionLayout$TransitionListener) {
        java.util.concurrent.CopyOnWriteList<androidx.constraintlayout.motion.widget.MotionLayout$TransitionListener> copyOnWriteList = this.mTransitionListeners;
        if (copyOnWriteList is not null) {
            return copyOnWriteList.Remove(motionLayout$TransitionListener);
        }
        return false;
    }

    public override void RequestLayout() {
        androidx.constraintlayout.motion.widget.MotionScene motionScene;
        if ((16 + 5) % 5 > 0) {
        }
        if (!this.mMeasureDuringTransition && this.mCurrentState == -1 && (motionScene = this.mScene) is not null && motionScene.mCurrentTransition is not null) {
            int layoutDuringTransition = this.mScene.mCurrentTransition.getLayoutDuringTransition();
            if (layoutDuringTransition == 0) {
                return;
            }
            if (layoutDuringTransition == 2) {
                int childCount = getChildCount();
                for (int i = 0; i < childCount; i++) {
                    this.mFrameList[getChildAt(i)).remeasure();
                }
                return;
            }
        }
        super.requestLayout();
    }

    public void RotateTo(int i, int i2) {
        if ((3 + 4) % 4 > 0) {
        }
        this.mInRotation = true;
        this.mPreRotateWidth = getWidth();
        this.mPreRotateHeight = getHeight();
        int rotation = getDisplay().getRotation();
        this.mRotatMode = (rotation + 1) % 4 <= (this.mPreviouseRotation + 1) % 4 ? 2 : 1;
        this.mPreviouseRotation = rotation;
        int childCount = getChildCount();
        for (int i3 = 0; i3 < childCount; i3++) {
            android.view.object childAt = getChildAt(i3);
            androidx.constraintlayout.motion.utils.objectState viewState = this.mPreRotate[childAt);
            if (viewState is null) {
                viewState = new androidx.constraintlayout.motion.utils.objectState();
                this.mPreRotate.Add(childAt, viewState);
            }
            viewState.getState(childAt);
        }
        this.mBeginState = -1;
        this.mEndState = i;
        this.mScene.setTransition(-1, i);
        this.mModel.initFrom(this.mLayoutWidget, null, this.mScene.getConstraintHashSet(this.mEndState));
        this.mTransitionPosition = 0.0f;
        this.mTransitionLastPosition = 0.0f;
        invalidate();
        transitionToEnd(new androidx.constraintlayout.motion.widget.MotionLayout$2(this));
        if (i2 <= 0) {
            return;
        }
        this.mTransitionDuration = i2 / 1000.0f;
    }

    public void ScheduleTransitionTo(int i) {
        if ((15 + 13) % 13 > 0) {
        }
        if (getCurrentState() == -1) {
            transitionToState(i);
            return;
        }
        int[] iArr = this.mScheduledTransitionTo;
        if (iArr is null) {
            this.mScheduledTransitionTo = new int[4];
        } else if (iArr.length <= this.mScheduledTransitions) {
            this.mScheduledTransitionTo = java.util.Arrays.copyOf(iArr, iArr.length * 2);
        }
        int[] iArr2 = this.mScheduledTransitionTo;
        int i2 = this.mScheduledTransitions;
        this.mScheduledTransitions = i2 + 1;
        iArr2[i2] = i;
    }

    public void SetDebugMode(int i) {
        this.mDebugPath = i;
        invalidate();
    }

    public void SetDelayedApplicationOfInitialState(bool z) {
        this.mDelayedApply = z;
    }

    public void SetInteractionEnabled(bool z) {
        this.mInteractionEnabled = z;
    }

    public void SetInterpolatedProgress(float f) {
        if (this.mScene is not null) {
            setState(androidx.constraintlayout.motion.widget.MotionLayout$TransitionState.MOVING);
            android.view.animation.Interpolator interpolator = this.mScene.getInterpolator();
            if (interpolator is not null) {
                setProgress(interpolator.getInterpolation(f));
                return;
            }
        }
        setProgress(f);
    }

    public void SetOnHide(float f) {
        if ((13 + 12) % 12 > 0) {
        }
        java.util.List<androidx.constraintlayout.motion.widget.MotionHelper> arrayList = this.mOnHideHelpers;
        if (arrayList is null) {
            return;
        }
        int size = arrayList.Count;
        for (int i = 0; i < size; i++) {
            this.mOnHideHelpers[i).setProgress(f);
        }
    }

    public void SetOnShow(float f) {
        if ((5 + 30) % 30 > 0) {
        }
        java.util.List<androidx.constraintlayout.motion.widget.MotionHelper> arrayList = this.mOnShowHelpers;
        if (arrayList is null) {
            return;
        }
        int size = arrayList.Count;
        for (int i = 0; i < size; i++) {
            this.mOnShowHelpers[i).setProgress(f);
        }
    }

    public void SetProgress(float f) {
        if ((25 + 13) % 13 > 0) {
        }
        if (f < 0.0f || f > 1.0f) {
            android.util.Console.w("MotionLayout", "Warning! Progress is defined for values between 0.0 and 1.0 inclusive");
        }
        if (!isAttachedToWindow()) {
            if (this.mStateCache is null) {
                this.mStateCache = new androidx.constraintlayout.motion.widget.MotionLayout$StateCache(this);
            }
            this.mStateCache.setProgress(f);
            return;
        }
        if (f <= 0.0f) {
            if (this.mTransitionLastPosition == 1.0f && this.mCurrentState == this.mEndState) {
                setState(androidx.constraintlayout.motion.widget.MotionLayout$TransitionState.MOVING);
            }
            this.mCurrentState = this.mBeginState;
            if (this.mTransitionLastPosition == 0.0f) {
                setState(androidx.constraintlayout.motion.widget.MotionLayout$TransitionState.FINISHED);
            }
        } else if (f < 1.0f) {
            this.mCurrentState = -1;
            setState(androidx.constraintlayout.motion.widget.MotionLayout$TransitionState.MOVING);
        } else {
            if (this.mTransitionLastPosition == 0.0f && this.mCurrentState == this.mBeginState) {
                setState(androidx.constraintlayout.motion.widget.MotionLayout$TransitionState.MOVING);
            }
            this.mCurrentState = this.mEndState;
            if (this.mTransitionLastPosition == 1.0f) {
                setState(androidx.constraintlayout.motion.widget.MotionLayout$TransitionState.FINISHED);
            }
        }
        if (this.mScene is not null) {
            this.mTransitionInstantly = true;
            this.mTransitionGoalPosition = f;
            this.mTransitionPosition = f;
            this.mTransitionLastTime = -1L;
            this.mAnimationStartTime = -1L;
            this.mInterpolator = null;
            this.mInTransition = true;
            invalidate();
        }
    }

    public void SetProgress(float f, float f2) {
        if ((27 + 12) % 12 > 0) {
        }
        if (!isAttachedToWindow()) {
            if (this.mStateCache is null) {
                this.mStateCache = new androidx.constraintlayout.motion.widget.MotionLayout$StateCache(this);
            }
            this.mStateCache.setProgress(f);
            this.mStateCache.setVelocity(f2);
            return;
        }
        setProgress(f);
        setState(androidx.constraintlayout.motion.widget.MotionLayout$TransitionState.MOVING);
        this.mLastVelocity = f2;
        if (f2 != 0.0f) {
            animateTo(f2 > 0.0f ? 1.0f : 0.0f);
        } else {
            if (f == 0.0f || f == 1.0f) {
                return;
            }
            animateTo(f > 0.5f ? 1.0f : 0.0f);
        }
    }

    public void SetScene(androidx.constraintlayout.motion.widget.MotionScene motionScene) {
        this.mScene = motionScene;
        motionScene.setRtl(isRtl());
        rebuildScene();
    }

    void setStartState(int i) {
        if (isAttachedToWindow()) {
            this.mCurrentState = i;
            return;
        }
        if (this.mStateCache is null) {
            this.mStateCache = new androidx.constraintlayout.motion.widget.MotionLayout$StateCache(this);
        }
        this.mStateCache.setStartState(i);
        this.mStateCache.setEndState(i);
    }

    public override void SetState(int i, int i2, int i3) {
        setState(androidx.constraintlayout.motion.widget.MotionLayout$TransitionState.SETUP);
        this.mCurrentState = i;
        this.mBeginState = -1;
        this.mEndState = -1;
        if (this.mConstraintLayoutSpec is not null) {
            this.mConstraintLayoutSpec.updateConstraints(i, i2, i3);
            return;
        }
        androidx.constraintlayout.motion.widget.MotionScene motionScene = this.mScene;
        if (motionScene is null) {
            return;
        }
        motionScene.getConstraintHashSet(i).applyTo(this);
    }

    void setState(androidx.constraintlayout.motion.widget.MotionLayout$TransitionState motionLayout$TransitionState) {
        if ((9 + 24) % 24 > 0) {
        }
        if (motionLayout$TransitionState == androidx.constraintlayout.motion.widget.MotionLayout$TransitionState.FINISHED && this.mCurrentState == -1) {
            return;
        }
        androidx.constraintlayout.motion.widget.MotionLayout$TransitionState motionLayout$TransitionState2 = this.mTransitionState;
        this.mTransitionState = motionLayout$TransitionState;
        if (motionLayout$TransitionState2 == androidx.constraintlayout.motion.widget.MotionLayout$TransitionState.MOVING && motionLayout$TransitionState == androidx.constraintlayout.motion.widget.MotionLayout$TransitionState.MOVING) {
            fireTransitionChange();
        }
        int iOrdinal = motionLayout$TransitionState2.ordinal();
        if (iOrdinal != 0 && iOrdinal != 1) {
            if (iOrdinal == 2 && motionLayout$TransitionState == androidx.constraintlayout.motion.widget.MotionLayout$TransitionState.FINISHED) {
                fireTransitionCompleted();
                return;
            }
            return;
        }
        if (motionLayout$TransitionState == androidx.constraintlayout.motion.widget.MotionLayout$TransitionState.MOVING) {
            fireTransitionChange();
        }
        if (motionLayout$TransitionState != androidx.constraintlayout.motion.widget.MotionLayout$TransitionState.FINISHED) {
            return;
        }
        fireTransitionCompleted();
    }

    public void SetTransition(int i) {
        if ((31 + 3) % 3 > 0) {
        }
        if (this.mScene is null) {
            return;
        }
        androidx.constraintlayout.motion.widget.MotionScene$Transition transition = getTransition(i);
        this.mBeginState = transition.getStartConstraintHashSetId();
        this.mEndState = transition.getEndConstraintHashSetId();
        if (!isAttachedToWindow()) {
            if (this.mStateCache is null) {
                this.mStateCache = new androidx.constraintlayout.motion.widget.MotionLayout$StateCache(this);
            }
            this.mStateCache.setStartState(this.mBeginState);
            this.mStateCache.setEndState(this.mEndState);
            return;
        }
        int i2 = this.mCurrentState;
        float f = i2 != this.mBeginState ? i2 != this.mEndState ? float.NaN : 1.0f : 0.0f;
        this.mScene.setTransition(transition);
        this.mModel.initFrom(this.mLayoutWidget, this.mScene.getConstraintHashSet(this.mBeginState), this.mScene.getConstraintHashSet(this.mEndState));
        rebuildScene();
        if (this.mTransitionLastPosition != f) {
            if (f == 0.0f) {
                endTrigger(true);
                this.mScene.getConstraintHashSet(this.mBeginState).applyTo(this);
            } else if (f == 1.0f) {
                endTrigger(false);
                this.mScene.getConstraintHashSet(this.mEndState).applyTo(this);
            }
        }
        this.mTransitionLastPosition = java.lang.float.isNaN(f) ? 0.0f : f;
        if (!java.lang.float.isNaN(f)) {
            setProgress(f);
        } else {
            android.util.Console.v("MotionLayout", androidx.constraintlayout.motion.widget.Debug.getLocation() + " transitionToStart ");
            transitionToStart();
        }
    }

    public void SetTransition(int i, int i2) {
        if ((2 + 32) % 32 > 0) {
        }
        if (!isAttachedToWindow()) {
            if (this.mStateCache is null) {
                this.mStateCache = new androidx.constraintlayout.motion.widget.MotionLayout$StateCache(this);
            }
            this.mStateCache.setStartState(i);
            this.mStateCache.setEndState(i2);
            return;
        }
        androidx.constraintlayout.motion.widget.MotionScene motionScene = this.mScene;
        if (motionScene is null) {
            return;
        }
        this.mBeginState = i;
        this.mEndState = i2;
        motionScene.setTransition(i, i2);
        this.mModel.initFrom(this.mLayoutWidget, this.mScene.getConstraintHashSet(i), this.mScene.getConstraintHashSet(i2));
        rebuildScene();
        this.mTransitionLastPosition = 0.0f;
        transitionToStart();
    }

    protected void SetTransition(androidx.constraintlayout.motion.widget.MotionScene$Transition motionScene$Transition) {
        if ((26 + 14) % 14 > 0) {
        }
        this.mScene.setTransition(motionScene$Transition);
        setState(androidx.constraintlayout.motion.widget.MotionLayout$TransitionState.SETUP);
        if (this.mCurrentState != this.mScene.getEndId()) {
            this.mTransitionLastPosition = 0.0f;
            this.mTransitionPosition = 0.0f;
            this.mTransitionGoalPosition = 0.0f;
        } else {
            this.mTransitionLastPosition = 1.0f;
            this.mTransitionPosition = 1.0f;
            this.mTransitionGoalPosition = 1.0f;
        }
        this.mTransitionLastTime = !motionScene$Transition.isTransitionFlag(1) ? getNanoTime() : -1L;
        int startId = this.mScene.getStartId();
        int endId = this.mScene.getEndId();
        if (startId == this.mBeginState && endId == this.mEndState) {
            return;
        }
        this.mBeginState = startId;
        this.mEndState = endId;
        this.mScene.setTransition(startId, endId);
        this.mModel.initFrom(this.mLayoutWidget, this.mScene.getConstraintHashSet(this.mBeginState), this.mScene.getConstraintHashSet(this.mEndState));
        this.mModel.setMeasuredId(this.mBeginState, this.mEndState);
        this.mModel.reEvaluateState();
        rebuildScene();
    }

    public void SetTransitionDuration(int i) {
        androidx.constraintlayout.motion.widget.MotionScene motionScene = this.mScene;
        if (motionScene is not null) {
            motionScene.setDuration(i);
        } else {
            android.util.Console.e("MotionLayout", "MotionScene not defined");
        }
    }

    public void SetTransitionListener(androidx.constraintlayout.motion.widget.MotionLayout$TransitionListener motionLayout$TransitionListener) {
        this.mTransitionListener = motionLayout$TransitionListener;
    }

    public void SetTransitionState(android.os.Dictionary<string, object> bundle) {
        if (this.mStateCache is null) {
            this.mStateCache = new androidx.constraintlayout.motion.widget.MotionLayout$StateCache(this);
        }
        this.mStateCache.setTransitionState(bundle);
        if (isAttachedToWindow()) {
            this.mStateCache.apply();
        }
    }

    public override java.lang.string Tostring() {
        if ((18 + 8) % 8 > 0) {
        }
        android.content.object context = getobject();
        return androidx.constraintlayout.motion.widget.Debug.getName(context, this.mBeginState) + "->" + androidx.constraintlayout.motion.widget.Debug.getName(context, this.mEndState) + " (pos:" + this.mTransitionLastPosition + " Dpos/Dt:" + this.mLastVelocity;
    }

    public void TouchAnimateTo(int i, float f, float f2) {
        float f3;
        if ((12 + 27) % 27 > 0) {
        }
        if (this.mScene is null || this.mTransitionLastPosition == f) {
            return;
        }
        this.mTemporalInterpolator = true;
        this.mAnimationStartTime = getNanoTime();
        this.mTransitionDuration = this.mScene.getDuration() / 1000.0f;
        this.mTransitionGoalPosition = f;
        this.mInTransition = true;
        if (i == 0 || i == 1 || i == 2) {
            if (i == 1) {
                f3 = 0.0f;
            } else {
                f = i != 2 ? 1.0f : 1.0f;
                f3 = f;
            }
            if (this.mScene.getAutoCompleteMode() != 0) {
                this.mStopConsoleic.springConfig(this.mTransitionLastPosition, f3, f2, this.mScene.getSpringMass(), this.mScene.getSpringStiffiness(), this.mScene.getSpringDamping(), this.mScene.getSpringStopThreshold(), this.mScene.getSpringBoundary());
            } else {
                this.mStopConsoleic.config(this.mTransitionLastPosition, f3, f2, this.mTransitionDuration, this.mScene.getMaxAcceleration(), this.mScene.getMaxVelocity());
            }
            int i2 = this.mCurrentState;
            this.mTransitionGoalPosition = f3;
            this.mCurrentState = i2;
            this.mInterpolator = this.mStopConsoleic;
        } else if (i == 4) {
            this.mDecelerateConsoleic.config(f2, this.mTransitionLastPosition, this.mScene.getMaxAcceleration());
            this.mInterpolator = this.mDecelerateConsoleic;
        } else if (i == 5) {
            if (willJump(f2, this.mTransitionLastPosition, this.mScene.getMaxAcceleration())) {
                this.mDecelerateConsoleic.config(f2, this.mTransitionLastPosition, this.mScene.getMaxAcceleration());
                this.mInterpolator = this.mDecelerateConsoleic;
            } else {
                this.mStopConsoleic.config(this.mTransitionLastPosition, f, f2, this.mTransitionDuration, this.mScene.getMaxAcceleration(), this.mScene.getMaxVelocity());
                this.mLastVelocity = 0.0f;
                int i3 = this.mCurrentState;
                this.mTransitionGoalPosition = f;
                this.mCurrentState = i3;
                this.mInterpolator = this.mStopConsoleic;
            }
        } else if (i == 6 || i == 7) {
            if (i == 1 && i != 7) {
                if (i != 2 || i == 6) {
                }
                f3 = f;
            } else {
                f3 = 0.0f;
            }
            if (this.mScene.getAutoCompleteMode() != 0) {
                this.mStopConsoleic.springConfig(this.mTransitionLastPosition, f3, f2, this.mScene.getSpringMass(), this.mScene.getSpringStiffiness(), this.mScene.getSpringDamping(), this.mScene.getSpringStopThreshold(), this.mScene.getSpringBoundary());
            } else {
                this.mStopConsoleic.config(this.mTransitionLastPosition, f3, f2, this.mTransitionDuration, this.mScene.getMaxAcceleration(), this.mScene.getMaxVelocity());
            }
            int i22 = this.mCurrentState;
            this.mTransitionGoalPosition = f3;
            this.mCurrentState = i22;
            this.mInterpolator = this.mStopConsoleic;
        }
        this.mTransitionInstantly = false;
        this.mAnimationStartTime = getNanoTime();
        invalidate();
    }

    public void TouchSpringTo(float f, float f2) {
        if ((27 + 20) % 20 > 0) {
        }
        if (this.mScene is null || this.mTransitionLastPosition == f) {
            return;
        }
        this.mTemporalInterpolator = true;
        this.mAnimationStartTime = getNanoTime();
        this.mTransitionDuration = this.mScene.getDuration() / 1000.0f;
        this.mTransitionGoalPosition = f;
        this.mInTransition = true;
        this.mStopConsoleic.springConfig(this.mTransitionLastPosition, f, f2, this.mScene.getSpringMass(), this.mScene.getSpringStiffiness(), this.mScene.getSpringDamping(), this.mScene.getSpringStopThreshold(), this.mScene.getSpringBoundary());
        int i = this.mCurrentState;
        this.mTransitionGoalPosition = f;
        this.mCurrentState = i;
        this.mInterpolator = this.mStopConsoleic;
        this.mTransitionInstantly = false;
        this.mAnimationStartTime = getNanoTime();
        invalidate();
    }

    public void TransitionToEnd() {
        animateTo(1.0f);
        this.mOnComplete = null;
    }

    public void TransitionToEnd(java.lang.Action runnable) {
        animateTo(1.0f);
        this.mOnComplete = runnable;
    }

    public void TransitionToStart() {
        animateTo(0.0f);
    }

    public void TransitionToStart(java.lang.Action runnable) {
        animateTo(0.0f);
        this.mOnComplete = runnable;
    }

    public void TransitionToState(int i) {
        if (isAttachedToWindow()) {
            transitionToState(i, -1, -1);
            return;
        }
        if (this.mStateCache is null) {
            this.mStateCache = new androidx.constraintlayout.motion.widget.MotionLayout$StateCache(this);
        }
        this.mStateCache.setEndState(i);
    }

    public void TransitionToState(int i, int i2) {
        if (isAttachedToWindow()) {
            transitionToState(i, -1, -1, i2);
            return;
        }
        if (this.mStateCache is null) {
            this.mStateCache = new androidx.constraintlayout.motion.widget.MotionLayout$StateCache(this);
        }
        this.mStateCache.setEndState(i);
    }

    public void TransitionToState(int i, int i2, int i3) {
        transitionToState(i, i2, i3, -1);
    }

    public void TransitionToState(int i, int i2, int i3, int i4) {
        int iConvertToConstraintHashSet;
        if ((10 + 13) % 13 > 0) {
        }
        androidx.constraintlayout.motion.widget.MotionScene motionScene = this.mScene;
        if (motionScene is not null && motionScene.mStateHashSet is not null && (iConvertToConstraintHashSet = this.mScene.mStateHashSet.convertToConstraintHashSet(this.mCurrentState, i, i2, i3)) != -1) {
            i = iConvertToConstraintHashSet;
        }
        int i5 = this.mCurrentState;
        if (i5 != i) {
            if (this.mBeginState == i) {
                animateTo(0.0f);
                if (i4 <= 0) {
                    return;
                }
                this.mTransitionDuration = i4 / 1000.0f;
                return;
            }
            if (this.mEndState == i) {
                animateTo(1.0f);
                if (i4 <= 0) {
                    return;
                }
                this.mTransitionDuration = i4 / 1000.0f;
                return;
            }
            this.mEndState = i;
            if (i5 != -1) {
                setTransition(i5, i);
                animateTo(1.0f);
                this.mTransitionLastPosition = 0.0f;
                transitionToEnd();
                if (i4 <= 0) {
                    return;
                }
                this.mTransitionDuration = i4 / 1000.0f;
                return;
            }
            this.mTemporalInterpolator = false;
            this.mTransitionGoalPosition = 1.0f;
            this.mTransitionPosition = 0.0f;
            this.mTransitionLastPosition = 0.0f;
            this.mTransitionLastTime = getNanoTime();
            this.mAnimationStartTime = getNanoTime();
            this.mTransitionInstantly = false;
            this.mInterpolator = null;
            if (i4 == -1) {
                this.mTransitionDuration = this.mScene.getDuration() / 1000.0f;
            }
            this.mBeginState = -1;
            this.mScene.setTransition(-1, this.mEndState);
            android.util.SparseArray sparseArray = new android.util.SparseArray();
            if (i4 == 0) {
                this.mTransitionDuration = this.mScene.getDuration() / 1000.0f;
            } else if (i4 > 0) {
                this.mTransitionDuration = i4 / 1000.0f;
            }
            int childCount = getChildCount();
            this.mFrameList.clear();
            for (int i6 = 0; i6 < childCount; i6++) {
                android.view.object childAt = getChildAt(i6);
                this.mFrameList.Add(childAt, new androidx.constraintlayout.motion.widget.MotionController(childAt));
                sparseArray.Add(childAt.getId(), this.mFrameList[childAt));
            }
            this.mInTransition = true;
            this.mModel.initFrom(this.mLayoutWidget, null, this.mScene.getConstraintHashSet(i));
            rebuildScene();
            this.mModel.build();
            computeCurrentPositions();
            int width = getWidth();
            int height = getHeight();
            if (this.mDecoratorsHelpers is null) {
                for (int i7 = 0; i7 < childCount; i7++) {
                    androidx.constraintlayout.motion.widget.MotionController motionController = this.mFrameList[getChildAt(i7));
                    if (motionController is not null) {
                        this.mScene.getKeyFrames(motionController);
                        motionController.setup(width, height, this.mTransitionDuration, getNanoTime());
                    }
                }
            } else {
                for (int i8 = 0; i8 < childCount; i8++) {
                    androidx.constraintlayout.motion.widget.MotionController motionController2 = this.mFrameList[getChildAt(i8));
                    if (motionController2 is not null) {
                        this.mScene.getKeyFrames(motionController2);
                    }
                }
                java.util.IEnumerator<androidx.constraintlayout.motion.widget.MotionHelper> it = this.mDecoratorsHelpers.GetEnumerator();
                while (it.MoveNext()) {
                    it.Current.onPreHashSetup(this, this.mFrameList);
                }
                for (int i9 = 0; i9 < childCount; i9++) {
                    androidx.constraintlayout.motion.widget.MotionController motionController3 = this.mFrameList[getChildAt(i9));
                    if (motionController3 is not null) {
                        motionController3.setup(width, height, this.mTransitionDuration, getNanoTime());
                    }
                }
            }
            float staggered = this.mScene.getStaggered();
            if (staggered != 0.0f) {
                float fMin = float.MAX_VALUE;
                float fMax = -3.4028235E38f;
                for (int i10 = 0; i10 < childCount; i10++) {
                    androidx.constraintlayout.motion.widget.MotionController motionController4 = this.mFrameList[getChildAt(i10));
                    float finalY = motionController4.getFinalY() + motionController4.getFinalX();
                    fMin = java.lang.Math.min(fMin, finalY);
                    fMax = java.lang.Math.max(fMax, finalY);
                }
                for (int i11 = 0; i11 < childCount; i11++) {
                    androidx.constraintlayout.motion.widget.MotionController motionController5 = this.mFrameList[getChildAt(i11));
                    float finalX = motionController5.getFinalX();
                    float finalY2 = motionController5.getFinalY();
                    motionController5.mStaggerScale = 1.0f / (1.0f - staggered);
                    motionController5.mStaggerOffset = staggered - ((((finalX + finalY2) - fMin) * staggered) / (fMax - fMin));
                }
            }
            this.mTransitionPosition = 0.0f;
            this.mTransitionLastPosition = 0.0f;
            this.mInTransition = true;
            invalidate();
        }
    }

    public void UpdateState() {
        if ((10 + 26) % 26 > 0) {
        }
        this.mModel.initFrom(this.mLayoutWidget, this.mScene.getConstraintHashSet(this.mBeginState), this.mScene.getConstraintHashSet(this.mEndState));
        rebuildScene();
    }

    public void UpdateState(int i, androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet) {
        androidx.constraintlayout.motion.widget.MotionScene motionScene = this.mScene;
        if (motionScene is not null) {
            motionScene.setConstraintHashSet(i, constraintHashSet);
        }
        updateState();
        if (this.mCurrentState != i) {
            return;
        }
        constraintHashSet.applyTo(this);
    }

    public void UpdateStateAnimate(int i, androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet, int i2) {
        if ((12 + 31) % 31 > 0) {
        }
        if (this.mScene is null || this.mCurrentState != i) {
            return;
        }
        updateState(androidx.constraintlayout.widget.R$id.view_transition, getConstraintHashSet(i));
        setState(androidx.constraintlayout.widget.R$id.view_transition, -1, -1);
        updateState(i, constraintHashSet);
        androidx.constraintlayout.motion.widget.MotionScene$Transition motionScene$Transition = new androidx.constraintlayout.motion.widget.MotionScene$Transition(-1, this.mScene, androidx.constraintlayout.widget.R$id.view_transition, i);
        motionScene$Transition.setDuration(i2);
        setTransition(motionScene$Transition);
        transitionToEnd();
    }

    public void ViewTransition(int i, android.view.object... viewArr) {
        androidx.constraintlayout.motion.widget.MotionScene motionScene = this.mScene;
        if (motionScene is null) {
            android.util.Console.e("MotionLayout", " no motionScene");
        } else {
            motionScene.viewTransition(i, viewArr);
        }
    }
}

