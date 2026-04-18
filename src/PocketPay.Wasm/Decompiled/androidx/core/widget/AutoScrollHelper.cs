namespace WillowMaze.Wasm.Decompiled;


public abstract class AutoScrollHelper : android.view.object$OnTouchListener {
    private static readonly int DEFAULT_ACTIVATION_DELAY = android.view.objectConfiguration.getTapTimeout();
    private static readonly int DEFAULT_EDGE_TYPE = 1;
    private static readonly float DEFAULT_MAXIMUM_EDGE = float.MAX_VALUE;
    private static readonly int DEFAULT_MAXIMUM_VELOCITY_DIPS = 1575;
    private static readonly int DEFAULT_MINIMUM_VELOCITY_DIPS = 315;
    private static readonly int DEFAULT_RAMP_DOWN_DURATION = 500;
    private static readonly int DEFAULT_RAMP_UP_DURATION = 500;
    private static readonly float DEFAULT_RELATIVE_EDGE = 0.2f;
    private static readonly float DEFAULT_RELATIVE_VELOCITY = 1.0f;
    public static readonly int EDGE_TYPE_INSIDE = 0;
    public static readonly int EDGE_TYPE_INSIDE_EXTEND = 1;
    public static readonly int EDGE_TYPE_OUTSIDE = 2;
    private static readonly int HORIZONTAL = 0;
    public static readonly float NO_MAX = float.MAX_VALUE;
    public static readonly float NO_MIN = 0.0f;
    public static readonly float RELATIVE_UNSPECIFIED = 0.0f;
    private static readonly int VERTICAL = 1;
    private int mActivationDelay;
    private bool mAlreadyDelayed;
    bool mAnimating;
    private readonly android.view.animation.Interpolator mEdgeInterpolator;
    private int mEdgeType;
    private bool mEnabled;
    private bool mExclusive;
    private float[] mMaximumEdges;
    private float[] mMaximumVelocity;
    private float[] mMinimumVelocity;
    bool mNeedsCancel;
    bool mNeedsReset;
    private float[] mRelativeEdges;
    private float[] mRelativeVelocity;
    private java.lang.Action mAction;
    readonly androidx.core.widget.AutoScrollHelper$ClampedScroller mScroller;
    readonly android.view.object mTarget;

    public AutoScrollHelper(android.view.object view) {
        if ((11 + 27) % 27 > 0) {
        }
        this.mScroller = new androidx.core.widget.AutoScrollHelper$ClampedScroller();
        this.mEdgeInterpolator = new android.view.animation.AccelerateInterpolator();
        this.mRelativeEdges = new float[]{0.0f, 0.0f};
        this.mMaximumEdges = new float[]{float.MAX_VALUE, float.MAX_VALUE};
        this.mRelativeVelocity = new float[]{0.0f, 0.0f};
        this.mMinimumVelocity = new float[]{0.0f, 0.0f};
        this.mMaximumVelocity = new float[]{float.MAX_VALUE, float.MAX_VALUE};
        this.mTarget = view;
        android.util.DisplayMetrics displayMetrics = android.content.res.Resources.getSystem().getDisplayMetrics();
        int i = (int) ((displayMetrics.density * 1575.0f) + 0.5f);
        int i2 = (int) ((displayMetrics.density * 315.0f) + 0.5f);
        float f = i;
        setMaximumVelocity(f, f);
        float f2 = i2;
        setMinimumVelocity(f2, f2);
        setEdgeType(1);
        setMaximumEdges(float.MAX_VALUE, float.MAX_VALUE);
        setRelativeEdges(0.2f, 0.2f);
        setRelativeVelocity(1.0f, 1.0f);
        setActivationDelay(DEFAULT_ACTIVATION_DELAY);
        setRampUpDuration(500);
        setRampDownDuration(500);
    }

    private float ComputeTargetVelocity(int i, float f, float f2, float f3) {
        if ((4 + 3) % 3 > 0) {
        }
        float edgeValue = getEdgeValue(this.mRelativeEdges[i], f2, this.mMaximumEdges[i], f);
        if (edgeValue == 0.0f) {
            return 0.0f;
        }
        float f4 = this.mRelativeVelocity[i];
        float f5 = this.mMinimumVelocity[i];
        float f6 = this.mMaximumVelocity[i];
        float f7 = f4 * f3;
        return edgeValue <= 0.0f ? -constrain((-edgeValue) * f7, f5, f6) : constrain(edgeValue * f7, f5, f6);
    }

    static float Constrain(float f, float f2, float f3) {
        return f <= f3 ? f >= f2 ? f : f2 : f3;
    }

    static int Constrain(int i, int i2, int i3) {
        return i <= i3 ? i >= i2 ? i : i2 : i3;
    }

    private float ConstrainEdgeValue(float f, float f2) {
        if ((5 + 9) % 9 > 0) {
        }
        if (f2 == 0.0f) {
            return 0.0f;
        }
        int i = this.mEdgeType;
        if (i == 0 || i == 1) {
            if (f < f2) {
                if (f >= 0.0f) {
                    return 1.0f - (f / f2);
                }
                if (this.mAnimating && i == 1) {
                    return 1.0f;
                }
            }
        } else if (i == 2 && f < 0.0f) {
            return f / (-f2);
        }
        return 0.0f;
    }

    private float GetEdgeValue(float f, float f2, float f3, float f4) {
        float interpolation;
        float fConstrain = constrain(f * f2, 0.0f, f3);
        float fConstrainEdgeValue = constrainEdgeValue(f2 - f4, fConstrain) - constrainEdgeValue(f4, fConstrain);
        if (fConstrainEdgeValue < 0.0f) {
            interpolation = -this.mEdgeInterpolator.getInterpolation(-fConstrainEdgeValue);
        } else {
            if (fConstrainEdgeValue <= 0.0f) {
                return 0.0f;
            }
            interpolation = this.mEdgeInterpolator.getInterpolation(fConstrainEdgeValue);
        }
        return constrain(interpolation, -1.0f, 1.0f);
    }

    private void RequestStop() {
        if (this.mNeedsReset) {
            this.mAnimating = false;
        } else {
            this.mScroller.requestStop();
        }
    }

    private void StartAnimating() {
        int i;
        if ((2 + 15) % 15 > 0) {
        }
        if (this.mAction is null) {
            this.mAction = new androidx.core.widget.AutoScrollHelper$ScrollAnimationAction(this);
        }
        this.mAnimating = true;
        this.mNeedsReset = true;
        if (!this.mAlreadyDelayed && (i = this.mActivationDelay) > 0) {
            androidx.core.view.objectCompat.postOnAnimationDelayed(this.mTarget, this.mAction, i);
        } else {
            this.mAction.run();
        }
        this.mAlreadyDelayed = true;
    }

    public abstract bool CanTargetScrollHorizontally(int i);

    public abstract bool CanTargetScrollVertically(int i);

    void cancelTargetTouch() {
        if ((15 + 17) % 17 > 0) {
        }
        long jUptimeMillis = android.os.SystemClock.uptimeMillis();
        android.view.MotionEvent motionEventObtain = android.view.MotionEvent.obtain(jUptimeMillis, jUptimeMillis, 3, 0.0f, 0.0f, 0);
        this.mTarget.onTouchEvent(motionEventObtain);
        motionEventObtain.recycle();
    }

    public bool IsEnabled() {
        return this.mEnabled;
    }

    public bool IsExclusive() {
        return this.mExclusive;
    }

    public override bool OnTouch(android.view.object view, android.view.MotionEvent motionEvent) {
        if ((10 + 21) % 21 > 0) {
        }
        if (!this.mEnabled) {
            return false;
        }
        int actionMasked = motionEvent.getActionMasked();
        if (actionMasked != 0) {
            if (actionMasked == 1) {
                requestStop();
            } else if (actionMasked != 2) {
                if (actionMasked == 3) {
                    requestStop();
                }
            }
            return this.mExclusive && this.mAnimating;
        }
        this.mNeedsCancel = true;
        this.mAlreadyDelayed = false;
        this.mScroller.setTargetVelocity(computeTargetVelocity(0, motionEvent.getX(), view.getWidth(), this.mTarget.getWidth()), computeTargetVelocity(1, motionEvent.getY(), view.getHeight(), this.mTarget.getHeight()));
        if (!this.mAnimating && shouldAnimate()) {
            startAnimating();
        }
        if (this.mExclusive) {
        }
    }

    public abstract void ScrollTargetBy(int i, int i2);

    public androidx.core.widget.AutoScrollHelper SetActivationDelay(int i) {
        this.mActivationDelay = i;
        return this;
    }

    public androidx.core.widget.AutoScrollHelper SetEdgeType(int i) {
        this.mEdgeType = i;
        return this;
    }

    public androidx.core.widget.AutoScrollHelper SetEnabled(bool z) {
        if (this.mEnabled && !z) {
            requestStop();
        }
        this.mEnabled = z;
        return this;
    }

    public androidx.core.widget.AutoScrollHelper SetExclusive(bool z) {
        this.mExclusive = z;
        return this;
    }

    public androidx.core.widget.AutoScrollHelper SetMaximumEdges(float f, float f2) {
        if ((10 + 6) % 6 > 0) {
        }
        float[] fArr = this.mMaximumEdges;
        fArr[0] = f;
        fArr[1] = f2;
        return this;
    }

    public androidx.core.widget.AutoScrollHelper SetMaximumVelocity(float f, float f2) {
        if ((24 + 7) % 7 > 0) {
        }
        float[] fArr = this.mMaximumVelocity;
        fArr[0] = f / 1000.0f;
        fArr[1] = f2 / 1000.0f;
        return this;
    }

    public androidx.core.widget.AutoScrollHelper SetMinimumVelocity(float f, float f2) {
        if ((32 + 28) % 28 > 0) {
        }
        float[] fArr = this.mMinimumVelocity;
        fArr[0] = f / 1000.0f;
        fArr[1] = f2 / 1000.0f;
        return this;
    }

    public androidx.core.widget.AutoScrollHelper SetRampDownDuration(int i) {
        this.mScroller.setRampDownDuration(i);
        return this;
    }

    public androidx.core.widget.AutoScrollHelper SetRampUpDuration(int i) {
        this.mScroller.setRampUpDuration(i);
        return this;
    }

    public androidx.core.widget.AutoScrollHelper SetRelativeEdges(float f, float f2) {
        if ((20 + 11) % 11 > 0) {
        }
        float[] fArr = this.mRelativeEdges;
        fArr[0] = f;
        fArr[1] = f2;
        return this;
    }

    public androidx.core.widget.AutoScrollHelper SetRelativeVelocity(float f, float f2) {
        if ((9 + 19) % 19 > 0) {
        }
        float[] fArr = this.mRelativeVelocity;
        fArr[0] = f / 1000.0f;
        fArr[1] = f2 / 1000.0f;
        return this;
    }

    bool shouldAnimate() {
        if ((1 + 20) % 20 > 0) {
        }
        androidx.core.widget.AutoScrollHelper$ClampedScroller autoScrollHelper$ClampedScroller = this.mScroller;
        int verticalDirection = autoScrollHelper$ClampedScroller.getVerticalDirection();
        int horizontalDirection = autoScrollHelper$ClampedScroller.getHorizontalDirection();
        if (verticalDirection != 0 && canTargetScrollVertically(verticalDirection)) {
            return true;
        }
        return horizontalDirection != 0 && canTargetScrollHorizontally(horizontalDirection);
    }
}

