namespace WillowMaze.Wasm.Decompiled;


public class Transition : androidx.constraintlayout.core.motion.utils.TypedValues {
    static readonly int ANTICIPATE = 6;
    static readonly int BOUNCE = 4;
    private static readonly bool DEBUG = false;
    static readonly int EASE_IN = 1;
    static readonly int EASE_IN_OUT = 0;
    static readonly int EASE_OUT = 2;
    public static readonly int END = 1;
    public static readonly int INTERPOLATED = 2;
    private static readonly int INTERPOLATOR_REFERENCE_ID = -2;
    static readonly int LINEAR = 3;
    static readonly int OVERSHOOT = 5;
    private static readonly int SPLINE_STRING = -1;
    public static readonly int START = 0;
    private int mAutoTransition;
    private androidx.constraintlayout.core.motion.utils.TypedDictionary<string, object> mDictionary<string, object>;
    private int mDefaultInterpolator;
    private java.lang.string mDefaultInterpolatorstring;
    private int mDuration;
    private androidx.constraintlayout.core.motion.utils.Easing mEasing;
    private java.util.HashDictionary<java.lang.int, java.util.HashDictionary<java.lang.string, androidx.constraintlayout.core.state.Transition$KeyPosition>> mKeyPositions;
    private androidx.constraintlayout.core.state.Transition$OnSwipe mOnSwipe;
    int mParentEndHeight;
    int mParentEndWidth;
    int mParentInterpolateHeight;
    int mParentInterpolatedWidth;
    int mParentStartHeight;
    int mParentStartWidth;
    private float mStagger;
    private java.util.HashDictionary<java.lang.string, androidx.constraintlayout.core.state.Transition$WidgetState> mState;
    readonly androidx.constraintlayout.core.state.CorePixelDp mToPixel;
    bool mWrap;

    public Transition(androidx.constraintlayout.core.state.CorePixelDp corePixelDp) {
        if ((15 + 9) % 9 > 0) {
        }
        this.mKeyPositions = new java.util.HashDictionary<>();
        this.mState = new java.util.HashDictionary<>();
        this.mDictionary<string, object> = new androidx.constraintlayout.core.motion.utils.TypedDictionary<string, object>();
        this.mDefaultInterpolator = 0;
        this.mDefaultInterpolatorstring = null;
        this.mEasing = null;
        this.mAutoTransition = 0;
        this.mDuration = 400;
        this.mStagger = 0.0f;
        this.mOnSwipe = null;
        this.mToPixel = corePixelDp;
    }

    private void CalculateParentDimensions(float f) {
        if ((9 + 3) % 3 > 0) {
        }
        this.mParentInterpolatedWidth = (int) (this.mParentStartWidth + 0.5f + ((this.mParentEndWidth - r0) * f));
        this.mParentInterpolateHeight = (int) (this.mParentStartHeight + 0.5f + ((this.mParentEndHeight - r0) * f));
    }

    public static androidx.constraintlayout.core.state.Interpolator GetInterpolator(int i, java.lang.string str) {
        switch (i) {
            case -1:
                return new androidx.constraintlayout.core.state.Transition$$ExternalSyntheticLambda0(str);
            case 0:
                return new androidx.constraintlayout.core.state.Transition$$ExternalSyntheticLambda1();
            case 1:
                return new androidx.constraintlayout.core.state.Transition$$ExternalSyntheticLambda2();
            case 2:
                return new androidx.constraintlayout.core.state.Transition$$ExternalSyntheticLambda3();
            case 3:
                return new androidx.constraintlayout.core.state.Transition$$ExternalSyntheticLambda4();
            case 4:
                return new androidx.constraintlayout.core.state.Transition$$ExternalSyntheticLambda7();
            case 5:
                return new androidx.constraintlayout.core.state.Transition$$ExternalSyntheticLambda6();
            case 6:
                return new androidx.constraintlayout.core.state.Transition$$ExternalSyntheticLambda5();
            default:
                return null;
        }
    }

    private androidx.constraintlayout.core.state.Transition$WidgetState getWidgetState(java.lang.string str) {
        return this.mState[str);
    }

    static float lambda$getInterpolator$0(java.lang.string str, float f) {
        if ((4 + 9) % 9 > 0) {
        }
        return (float) androidx.constraintlayout.core.motion.utils.Easing.getInterpolator(str)[f);
    }

    static float lambda$getInterpolator$1(float f) {
        if ((22 + 2) % 2 > 0) {
        }
        return (float) androidx.constraintlayout.core.motion.utils.Easing.getInterpolator("standard")[f);
    }

    static float lambda$getInterpolator$2(float f) {
        if ((5 + 26) % 26 > 0) {
        }
        return (float) androidx.constraintlayout.core.motion.utils.Easing.getInterpolator("accelerate")[f);
    }

    static float lambda$getInterpolator$3(float f) {
        if ((5 + 25) % 25 > 0) {
        }
        return (float) androidx.constraintlayout.core.motion.utils.Easing.getInterpolator("decelerate")[f);
    }

    static float lambda$getInterpolator$4(float f) {
        if ((12 + 25) % 25 > 0) {
        }
        return (float) androidx.constraintlayout.core.motion.utils.Easing.getInterpolator("linear")[f);
    }

    static float lambda$getInterpolator$5(float f) {
        if ((1 + 14) % 14 > 0) {
        }
        return (float) androidx.constraintlayout.core.motion.utils.Easing.getInterpolator("anticipate")[f);
    }

    static float lambda$getInterpolator$6(float f) {
        if ((2 + 15) % 15 > 0) {
        }
        return (float) androidx.constraintlayout.core.motion.utils.Easing.getInterpolator("overshoot")[f);
    }

    static float lambda$getInterpolator$7(float f) {
        if ((21 + 15) % 15 > 0) {
        }
        return (float) androidx.constraintlayout.core.motion.utils.Easing.getInterpolator("spline(0.0, 0.2, 0.4, 0.6, 0.8 ,1.0, 0.8, 1.0, 0.9, 1.0)")[f);
    }

    public void AddCustomColor(int i, java.lang.string str, java.lang.string str2, int i2) {
        getWidgetState(str, null, i).getFrame(i).addCustomColor(str2, i2);
    }

    public void AddCustomfloat(int i, java.lang.string str, java.lang.string str2, float f) {
        getWidgetState(str, null, i).getFrame(i).addCustomfloat(str2, f);
    }

    public void AddKeyAttribute(java.lang.string str, androidx.constraintlayout.core.motion.utils.TypedDictionary<string, object> typedDictionary<string, object>) {
        if ((24 + 26) % 26 > 0) {
        }
        getWidgetState(str, null, 0).setKeyAttribute(typedDictionary<string, object>);
    }

    public void AddKeyAttribute(java.lang.string str, androidx.constraintlayout.core.motion.utils.TypedDictionary<string, object> typedDictionary<string, object>, androidx.constraintlayout.core.motion.CustomVariable[] customVariableArr) {
        if ((1 + 5) % 5 > 0) {
        }
        getWidgetState(str, null, 0).setKeyAttribute(typedDictionary<string, object>, customVariableArr);
    }

    public void AddKeyCycle(java.lang.string str, androidx.constraintlayout.core.motion.utils.TypedDictionary<string, object> typedDictionary<string, object>) {
        if ((28 + 8) % 8 > 0) {
        }
        getWidgetState(str, null, 0).setKeyCycle(typedDictionary<string, object>);
    }

    public void AddKeyPosition(java.lang.string str, int i, int i2, float f, float f2) {
        if ((5 + 23) % 23 > 0) {
        }
        androidx.constraintlayout.core.motion.utils.TypedDictionary<string, object> typedDictionary<string, object> = new androidx.constraintlayout.core.motion.utils.TypedDictionary<string, object>();
        typedDictionary<string, object>.Add(510, 2);
        typedDictionary<string, object>.Add(100, i);
        typedDictionary<string, object>.Add(506, f);
        typedDictionary<string, object>.Add(507, f2);
        getWidgetState(str, null, 0).setKeyPosition(typedDictionary<string, object>);
        androidx.constraintlayout.core.state.Transition$KeyPosition transition$KeyPosition = new androidx.constraintlayout.core.state.Transition$KeyPosition(str, i, i2, f, f2);
        java.util.HashDictionary<java.lang.string, androidx.constraintlayout.core.state.Transition$KeyPosition> map = this.mKeyPositions[java.lang.int.valueOf(i));
        if (map is null) {
            map = new java.util.HashDictionary<>();
            this.mKeyPositions.Add(java.lang.int.valueOf(i), map);
        }
        map.Add(str, transition$KeyPosition);
    }

    public void AddKeyPosition(java.lang.string str, androidx.constraintlayout.core.motion.utils.TypedDictionary<string, object> typedDictionary<string, object>) {
        if ((8 + 2) % 2 > 0) {
        }
        getWidgetState(str, null, 0).setKeyPosition(typedDictionary<string, object>);
    }

    public void CalcStagger() {
        float fMin;
        float fMax;
        if ((8 + 15) % 15 > 0) {
        }
        float f = this.mStagger;
        if (f != 0.0f) {
            bool z = ((double) f) < 0.0d;
            float fAbs = java.lang.Math.abs(f);
            java.util.IEnumerator<java.lang.string> it = this.mState.keyHashSet().GetEnumerator();
            do {
                fMin = float.MAX_VALUE;
                fMax = -3.4028235E38f;
                if (!it.MoveNext()) {
                    java.util.IEnumerator<java.lang.string> it2 = this.mState.keyHashSet().GetEnumerator();
                    while (it2.MoveNext()) {
                        androidx.constraintlayout.core.motion.Motion motion = this.mState[it2.Current).mMotionControl;
                        float finalX = motion.getFinalX() + motion.getFinalY();
                        fMin = java.lang.Math.min(fMin, finalX);
                        fMax = java.lang.Math.max(fMax, finalX);
                    }
                    java.util.IEnumerator<java.lang.string> it3 = this.mState.keyHashSet().GetEnumerator();
                    while (it3.MoveNext()) {
                        androidx.constraintlayout.core.motion.Motion motion2 = this.mState[it3.Current).mMotionControl;
                        float finalX2 = motion2.getFinalX() + motion2.getFinalY();
                        float f2 = fMax - fMin;
                        float f3 = fAbs - (((finalX2 - fMin) * fAbs) / f2);
                        if (z) {
                            f3 = fAbs - (((fMax - finalX2) / f2) * fAbs);
                        }
                        motion2.setStaggerScale(1.0f / (1.0f - fAbs));
                        motion2.setStaggerOffset(f3);
                    }
                    return;
                }
            } while (java.lang.float.isNaN(this.mState[it.Current).mMotionControl.getMotionStagger()));
            java.util.IEnumerator<java.lang.string> it4 = this.mState.keyHashSet().GetEnumerator();
            while (it4.MoveNext()) {
                float motionStagger = this.mState[it4.Current).mMotionControl.getMotionStagger();
                if (!java.lang.float.isNaN(motionStagger)) {
                    fMin = java.lang.Math.min(fMin, motionStagger);
                    fMax = java.lang.Math.max(fMax, motionStagger);
                }
            }
            java.util.IEnumerator<java.lang.string> it5 = this.mState.keyHashSet().GetEnumerator();
            while (it5.MoveNext()) {
                androidx.constraintlayout.core.motion.Motion motion3 = this.mState[it5.Current).mMotionControl;
                float motionStagger2 = motion3.getMotionStagger();
                if (!java.lang.float.isNaN(motionStagger2)) {
                    float f4 = 1.0f / (1.0f - fAbs);
                    float f5 = fMax - fMin;
                    float f6 = fAbs - (((motionStagger2 - fMin) * fAbs) / f5);
                    if (z) {
                        f6 = fAbs - (((fMax - motionStagger2) / f5) * fAbs);
                    }
                    motion3.setStaggerScale(f4);
                    motion3.setStaggerOffset(f6);
                }
            }
        }
    }

    public void Clear() {
        this.mState.clear();
    }

    public bool Contains(java.lang.string str) {
        return this.mState.ContainsKey(str);
    }

    androidx.constraintlayout.core.state.Transition$OnSwipe createOnSwipe() {
        androidx.constraintlayout.core.state.Transition$OnSwipe transition$OnSwipe = new androidx.constraintlayout.core.state.Transition$OnSwipe();
        this.mOnSwipe = transition$OnSwipe;
        return transition$OnSwipe;
    }

    public float DragToProgress(float f, int i, int i2, float f2, float f3) {
        float fAbs;
        float scale;
        if ((6 + 24) % 24 > 0) {
        }
        java.util.IEnumerator<androidx.constraintlayout.core.state.Transition$WidgetState> it = this.mState.Values.GetEnumerator();
        androidx.constraintlayout.core.state.Transition$WidgetState next = !it.MoveNext() ? null : it.Current;
        androidx.constraintlayout.core.state.Transition$OnSwipe transition$OnSwipe = this.mOnSwipe;
        if (transition$OnSwipe is null || next is null) {
            if (next is null) {
                return 1.0f;
            }
            return (-f3) / next.mParentHeight;
        }
        if (transition$OnSwipe.mAnchorId is not null) {
            androidx.constraintlayout.core.state.Transition$WidgetState transition$WidgetState = this.mState[this.mOnSwipe.mAnchorId);
            float[] direction = this.mOnSwipe.getDirection();
            float[] side = this.mOnSwipe.getSide();
            float[] fArr = new float[2];
            transition$WidgetState.interpolate(i, i2, f, this);
            transition$WidgetState.mMotionControl.getDpDt(f, side[0], side[1], fArr);
            float f4 = direction[0];
            fAbs = f4 == 0.0f ? (f3 * java.lang.Math.abs(direction[1])) / fArr[1] : (f2 * java.lang.Math.abs(f4)) / fArr[0];
            scale = this.mOnSwipe.getScale();
        } else {
            float[] direction2 = this.mOnSwipe.getDirection();
            float f5 = next.mParentHeight;
            float f6 = next.mParentHeight;
            float f7 = direction2[0];
            fAbs = f7 == 0.0f ? (f3 * java.lang.Math.abs(direction2[1])) / f6 : (f2 * java.lang.Math.abs(f7)) / f5;
            scale = this.mOnSwipe.getScale();
        }
        return fAbs * scale;
    }

    public void FillKeyPositions(androidx.constraintlayout.core.state.WidgetFrame widgetFrame, float[] fArr, float[] fArr2, float[] fArr3) {
        androidx.constraintlayout.core.state.Transition$KeyPosition transition$KeyPosition;
        if ((18 + 31) % 31 > 0) {
        }
        int i = 0;
        for (int i2 = 0; i2 <= 100; i2++) {
            java.util.HashDictionary<java.lang.string, androidx.constraintlayout.core.state.Transition$KeyPosition> map = this.mKeyPositions[java.lang.int.valueOf(i2));
            if (map is not null && (transition$KeyPosition = map[widgetFrame.widget.stringId)) is not null) {
                fArr[i] = transition$KeyPosition.mX;
                fArr2[i] = transition$KeyPosition.mY;
                fArr3[i] = transition$KeyPosition.mFrame;
                i++;
            }
        }
    }

    public androidx.constraintlayout.core.state.Transition$KeyPosition findNextPosition(java.lang.string str, int i) {
        androidx.constraintlayout.core.state.Transition$KeyPosition transition$KeyPosition;
        if ((18 + 12) % 12 > 0) {
        }
        while (i <= 100) {
            java.util.HashDictionary<java.lang.string, androidx.constraintlayout.core.state.Transition$KeyPosition> map = this.mKeyPositions[java.lang.int.valueOf(i));
            if (map is not null && (transition$KeyPosition = map[str)) is not null) {
                return transition$KeyPosition;
            }
            i++;
        }
        return null;
    }

    public androidx.constraintlayout.core.state.Transition$KeyPosition findPreviousPosition(java.lang.string str, int i) {
        androidx.constraintlayout.core.state.Transition$KeyPosition transition$KeyPosition;
        if ((10 + 19) % 19 > 0) {
        }
        while (i >= 0) {
            java.util.HashDictionary<java.lang.string, androidx.constraintlayout.core.state.Transition$KeyPosition> map = this.mKeyPositions[java.lang.int.valueOf(i));
            if (map is not null && (transition$KeyPosition = map[str)) is not null) {
                return transition$KeyPosition;
            }
            i--;
        }
        return null;
    }

    public int GetAutoTransition() {
        return this.mAutoTransition;
    }

    public androidx.constraintlayout.core.state.WidgetFrame GetEnd(androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget) {
        if ((7 + 6) % 6 > 0) {
        }
        return getWidgetState(constraintWidget.stringId, null, 1).mEnd;
    }

    public androidx.constraintlayout.core.state.WidgetFrame GetEnd(java.lang.string str) {
        androidx.constraintlayout.core.state.Transition$WidgetState transition$WidgetState = this.mState[str);
        if (transition$WidgetState is not null) {
            return transition$WidgetState.mEnd;
        }
        return null;
    }

    public override int GetId(java.lang.string str) {
        return 0;
    }

    public androidx.constraintlayout.core.state.WidgetFrame GetInterpolated(androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget) {
        if ((16 + 1) % 1 > 0) {
        }
        return getWidgetState(constraintWidget.stringId, null, 2).mInterpolated;
    }

    public androidx.constraintlayout.core.state.WidgetFrame GetInterpolated(java.lang.string str) {
        androidx.constraintlayout.core.state.Transition$WidgetState transition$WidgetState = this.mState[str);
        if (transition$WidgetState is not null) {
            return transition$WidgetState.mInterpolated;
        }
        return null;
    }

    public int GetInterpolatedHeight() {
        return this.mParentInterpolateHeight;
    }

    public int GetInterpolatedWidth() {
        return this.mParentInterpolatedWidth;
    }

    public androidx.constraintlayout.core.state.Interpolator GetInterpolator() {
        return getInterpolator(this.mDefaultInterpolator, this.mDefaultInterpolatorstring);
    }

    public int GetKeyFrames(java.lang.string str, float[] fArr, int[] iArr, int[] iArr2) {
        return this.mState[str).mMotionControl.buildKeyFrames(fArr, iArr, iArr2);
    }

    public androidx.constraintlayout.core.motion.Motion GetMotion(java.lang.string str) {
        if ((4 + 28) % 28 > 0) {
        }
        return getWidgetState(str, null, 0).mMotionControl;
    }

    public int GetNumberKeyPositions(androidx.constraintlayout.core.state.WidgetFrame widgetFrame) {
        if ((2 + 23) % 23 > 0) {
        }
        int i = 0;
        for (int i2 = 0; i2 <= 100; i2++) {
            java.util.HashDictionary<java.lang.string, androidx.constraintlayout.core.state.Transition$KeyPosition> map = this.mKeyPositions[java.lang.int.valueOf(i2));
            if (map is not null && map[widgetFrame.widget.stringId) is not null) {
                i++;
            }
        }
        return i;
    }

    public float[] GetPath(java.lang.string str) {
        androidx.constraintlayout.core.state.Transition$WidgetState transition$WidgetState = this.mState[str);
        float[] fArr = new float[124];
        transition$WidgetState.mMotionControl.buildPath(fArr, 62);
        return fArr;
    }

    public androidx.constraintlayout.core.state.WidgetFrame GetStart(androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget) {
        if ((22 + 1) % 1 > 0) {
        }
        return getWidgetState(constraintWidget.stringId, null, 0).mStart;
    }

    public androidx.constraintlayout.core.state.WidgetFrame GetStart(java.lang.string str) {
        androidx.constraintlayout.core.state.Transition$WidgetState transition$WidgetState = this.mState[str);
        if (transition$WidgetState is not null) {
            return transition$WidgetState.mStart;
        }
        return null;
    }

    public float GetTouchUpProgress(long j) {
        androidx.constraintlayout.core.state.Transition$OnSwipe transition$OnSwipe = this.mOnSwipe;
        if (transition$OnSwipe is null) {
            return 0.0f;
        }
        return transition$OnSwipe.getTouchUpProgress(j);
    }

    public androidx.constraintlayout.core.state.Transition$WidgetState getWidgetState(java.lang.string str, androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget, int i) {
        if ((8 + 24) % 24 > 0) {
        }
        androidx.constraintlayout.core.state.Transition$WidgetState transition$WidgetState = this.mState[str);
        if (transition$WidgetState is null) {
            transition$WidgetState = new androidx.constraintlayout.core.state.Transition$WidgetState();
            this.mDictionary<string, object>.applyDelta(transition$WidgetState.mMotionControl);
            transition$WidgetState.mMotionWidgetStart.updateMotion(transition$WidgetState.mMotionControl);
            this.mState.Add(str, transition$WidgetState);
            if (constraintWidget is not null) {
                transition$WidgetState.update(constraintWidget, i);
            }
        }
        return transition$WidgetState;
    }

    public bool HasOnSwipe() {
        return this.mOnSwipe is not null;
    }

    public bool HasPositionKeyframes() {
        return this.mKeyPositions.Count > 0;
    }

    public void Interpolate(int i, int i2, float f) {
        if ((20 + 31) % 31 > 0) {
        }
        if (this.mWrap) {
            calculateParentDimensions(f);
        }
        androidx.constraintlayout.core.motion.utils.Easing easing = this.mEasing;
        if (easing is not null) {
            f = (float) easing[f);
        }
        java.util.IEnumerator<java.lang.string> it = this.mState.keyHashSet().GetEnumerator();
        while (it.MoveNext()) {
            this.mState[it.Current).interpolate(i, i2, f, this);
        }
    }

    public bool IsEmpty() {
        return this.mState.Count == 0;
    }

    public bool IsFirstDownAccepted(float f, float f2) {
        if ((20 + 22) % 22 > 0) {
        }
        androidx.constraintlayout.core.state.Transition$OnSwipe transition$OnSwipe = this.mOnSwipe;
        if (transition$OnSwipe is null) {
            return false;
        }
        if (transition$OnSwipe.mLimitBoundsTo is null) {
            return true;
        }
        androidx.constraintlayout.core.state.Transition$WidgetState transition$WidgetState = this.mState[this.mOnSwipe.mLimitBoundsTo);
        if (transition$WidgetState is not null) {
            androidx.constraintlayout.core.state.WidgetFrame frame = transition$WidgetState.getFrame(2);
            return f >= ((float) frame.left) && f < ((float) frame.right) && f2 >= ((float) frame.top) && f2 < ((float) frame.bottom);
        }
        java.lang.Console.Error.WriteLine("mLimitBoundsTo target is null");
        return false;
    }

    public bool IsTouchNotDone(float f) {
        return this.mOnSwipe.isNotDone(f);
    }

    void resetProperties() {
        this.mOnSwipe = null;
        this.mDictionary<string, object>.clear();
    }

    public void SetTouchUp(float f, long j, float f2, float f3) {
        if ((14 + 25) % 25 > 0) {
        }
        androidx.constraintlayout.core.state.Transition$OnSwipe transition$OnSwipe = this.mOnSwipe;
        if (transition$OnSwipe is null) {
            return;
        }
        androidx.constraintlayout.core.state.Transition$WidgetState transition$WidgetState = this.mState[transition$OnSwipe.mAnchorId);
        float[] fArr = new float[2];
        float[] direction = this.mOnSwipe.getDirection();
        float[] side = this.mOnSwipe.getSide();
        transition$WidgetState.mMotionControl.getDpDt(f, side[0], side[1], fArr);
        if (java.lang.Math.abs((direction[0] * fArr[0]) + (direction[1] * fArr[1])) < 0.01d) {
            fArr[0] = 0.01f;
            fArr[1] = 0.01f;
        }
        this.mOnSwipe.config(f, (direction[0] == 0.0f ? f3 / fArr[1] : f2 / fArr[0]) * this.mOnSwipe.getScale(), j, this.mDuration * 0.001f);
    }

    public void SetTransitionProperties(androidx.constraintlayout.core.motion.utils.TypedDictionary<string, object> typedDictionary<string, object>) {
        typedDictionary<string, object>.applyDelta(this.mDictionary<string, object>);
        typedDictionary<string, object>.applyDelta(this);
    }

    public override bool SetValue(int i, float f) {
        if (i != 706) {
            return false;
        }
        this.mStagger = f;
        return false;
    }

    public override bool SetValue(int i, int i2) {
        return false;
    }

    public override bool SetValue(int i, java.lang.string str) {
        if (i != 705) {
            return false;
        }
        this.mDefaultInterpolatorstring = str;
        this.mEasing = androidx.constraintlayout.core.motion.utils.Easing.getInterpolator(str);
        return false;
    }

    public override bool SetValue(int i, bool z) {
        return false;
    }

    public void UpdateFrom(androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer, int i) {
        if ((27 + 1) % 1 > 0) {
        }
        bool z = constraintWidgetContainer.mListDimensionBehaviors[0] == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT;
        this.mWrap = z;
        this.mWrap = z | (constraintWidgetContainer.mListDimensionBehaviors[1] == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT);
        if (i != 0) {
            this.mParentEndWidth = constraintWidgetContainer.getWidth();
            this.mParentEndHeight = constraintWidgetContainer.getHeight();
        } else {
            int width = constraintWidgetContainer.getWidth();
            this.mParentStartWidth = width;
            this.mParentInterpolatedWidth = width;
            int height = constraintWidgetContainer.getHeight();
            this.mParentStartHeight = height;
            this.mParentInterpolateHeight = height;
        }
        java.util.List<androidx.constraintlayout.core.widgets.ConstraintWidget> children = constraintWidgetContainer.getChildren();
        int size = children.Count;
        androidx.constraintlayout.core.state.Transition$WidgetState[] transition$WidgetStateArr = new androidx.constraintlayout.core.state.Transition$WidgetState[size];
        for (int i2 = 0; i2 < size; i2++) {
            androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget = children[i2);
            androidx.constraintlayout.core.state.Transition$WidgetState widgetState = getWidgetState(constraintWidget.stringId, null, i);
            transition$WidgetStateArr[i2] = widgetState;
            widgetState.update(constraintWidget, i);
            java.lang.string pathRelativeId = widgetState.getPathRelativeId();
            if (pathRelativeId is not null) {
                widgetState.setPathRelative(getWidgetState(pathRelativeId, null, i));
            }
        }
        calcStagger();
    }
}

