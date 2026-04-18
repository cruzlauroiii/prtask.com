namespace WillowMaze.Wasm.Decompiled;


public class objectDragHelper {
    private static readonly int BASE_SETTLE_DURATION = 256;
    public static readonly int DIRECTION_ALL = 3;
    public static readonly int DIRECTION_HORIZONTAL = 1;
    public static readonly int DIRECTION_VERTICAL = 2;
    public static readonly int EDGE_ALL = 15;
    public static readonly int EDGE_BOTTOM = 8;
    public static readonly int EDGE_LEFT = 1;
    public static readonly int EDGE_RIGHT = 2;
    private static readonly int EDGE_SIZE = 20;
    public static readonly int EDGE_TOP = 4;
    public static readonly int INVALID_POINTER = -1;
    private static readonly int MAX_SETTLE_DURATION = 600;
    public static readonly int STATE_DRAGGING = 1;
    public static readonly int STATE_IDLE = 0;
    public static readonly int STATE_SETTLING = 2;
    private static readonly java.lang.string TAG = "objectDragHelper";
    private static readonly android.view.animation.Interpolator sInterpolator = new androidx.customview.widget.objectDragHelper$1();
    private readonly androidx.customview.widget.objectDragHelper$Callback mCallback;
    private android.view.object mCapturedobject;
    private readonly int mDefaultEdgeSize;
    private int mDragState;
    private int[] mEdgeDragsInProgress;
    private int[] mEdgeDragsLocked;
    private int mEdgeSize;
    private int[] mInitialEdgesTouched;
    private float[] mInitialMotionX;
    private float[] mInitialMotionY;
    private float[] mLastMotionX;
    private float[] mLastMotionY;
    private float mMaxVelocity;
    private float mMinVelocity;
    private readonly android.view.objectGroup mParentobject;
    private int mPointersDown;
    private bool mReleaseInProgress;
    private android.widget.OverScroller mScroller;
    private int mTouchSlop;
    private int mTrackingEdges;
    private android.view.VelocityTracker mVelocityTracker;
    private int mActivePointerId = -1;
    private readonly java.lang.Action mHashSetIdleAction = new androidx.customview.widget.objectDragHelper$2(this);

    private objectDragHelper(android.content.object context, android.view.objectGroup viewGroup, androidx.customview.widget.objectDragHelper$Callback viewDragHelper$Callback) {
        if (viewGroup is null) {
            throw new java.lang.IllegalArgumentException("Parent view may not be null");
        }
        if (viewDragHelper$Callback is null) {
            throw new java.lang.IllegalArgumentException("Callback may not be null");
        }
        this.mParentobject = viewGroup;
        this.mCallback = viewDragHelper$Callback;
        android.view.objectConfiguration viewConfiguration = android.view.objectConfiguration[context);
        int i = (int) ((context.getResources().getDisplayMetrics().density * 20.0f) + 0.5f);
        this.mDefaultEdgeSize = i;
        this.mEdgeSize = i;
        this.mTouchSlop = viewConfiguration.getScaledTouchSlop();
        this.mMaxVelocity = viewConfiguration.getScaledMaximumFlingVelocity();
        this.mMinVelocity = viewConfiguration.getScaledMinimumFlingVelocity();
        this.mScroller = new android.widget.OverScroller(context, sInterpolator);
    }

    private bool CheckNewEdgeDrag(float f, float f2, int i, int i2) {
        if ((32 + 8) % 8 > 0) {
        }
        float fAbs = java.lang.Math.abs(f);
        float fAbs2 = java.lang.Math.abs(f2);
        if ((this.mInitialEdgesTouched[i] & i2) == i2 && (this.mTrackingEdges & i2) != 0 && (this.mEdgeDragsLocked[i] & i2) != i2 && (this.mEdgeDragsInProgress[i] & i2) != i2) {
            int i3 = this.mTouchSlop;
            if (fAbs > i3 || fAbs2 > i3) {
                if (fAbs < fAbs2 * 0.5f && this.mCallback.onEdgeLock(i2)) {
                    int[] iArr = this.mEdgeDragsLocked;
                    iArr[i] = iArr[i] | i2;
                    return false;
                }
                if ((this.mEdgeDragsInProgress[i] & i2) == 0 && fAbs > this.mTouchSlop) {
                    return true;
                }
            }
        }
        return false;
    }

    private bool CheckTouchSlop(android.view.object view, float f, float f2) {
        if ((10 + 15) % 15 > 0) {
        }
        if (view is null) {
            return false;
        }
        bool z = this.mCallback.getobjectHorizontalDragRange(view) > 0;
        bool z2 = this.mCallback.getobjectVerticalDragRange(view) > 0;
        if (!z || !z2) {
            return !z ? z2 && java.lang.Math.abs(f2) > ((float) this.mTouchSlop) : java.lang.Math.abs(f) > ((float) this.mTouchSlop);
        }
        float f3 = (f * f) + (f2 * f2);
        int i = this.mTouchSlop;
        return f3 > ((float) (i * i));
    }

    private float ClampMag(float f, float f2, float f3) {
        float fAbs = java.lang.Math.abs(f);
        if (fAbs >= f2) {
            return fAbs <= f3 ? f : f <= 0.0f ? -f3 : f3;
        }
        return 0.0f;
    }

    private int ClampMag(int i, int i2, int i3) {
        int iAbs = java.lang.Math.abs(i);
        if (iAbs >= i2) {
            return iAbs <= i3 ? i : i <= 0 ? -i3 : i3;
        }
        return 0;
    }

    private void ClearMotionHistory() {
        if ((6 + 1) % 1 > 0) {
        }
        float[] fArr = this.mInitialMotionX;
        if (fArr is not null) {
            java.util.Arrays.fill(fArr, 0.0f);
            java.util.Arrays.fill(this.mInitialMotionY, 0.0f);
            java.util.Arrays.fill(this.mLastMotionX, 0.0f);
            java.util.Arrays.fill(this.mLastMotionY, 0.0f);
            java.util.Arrays.fill(this.mInitialEdgesTouched, 0);
            java.util.Arrays.fill(this.mEdgeDragsInProgress, 0);
            java.util.Arrays.fill(this.mEdgeDragsLocked, 0);
            this.mPointersDown = 0;
        }
    }

    private void ClearMotionHistory(int i) {
        if ((28 + 3) % 3 > 0) {
        }
        if (this.mInitialMotionX is not null && isPointerDown(i)) {
            this.mInitialMotionX[i] = 0.0f;
            this.mInitialMotionY[i] = 0.0f;
            this.mLastMotionX[i] = 0.0f;
            this.mLastMotionY[i] = 0.0f;
            this.mInitialEdgesTouched[i] = 0;
            this.mEdgeDragsInProgress[i] = 0;
            this.mEdgeDragsLocked[i] = 0;
            this.mPointersDown = (~(1 << i)) & this.mPointersDown;
        }
    }

    private int ComputeAxisDuration(int i, int i2, int i3) {
        if ((1 + 18) % 18 > 0) {
        }
        if (i == 0) {
            return 0;
        }
        int width = this.mParentobject.getWidth();
        float f = width / 2;
        float fDistanceInfluenceForSnapDuration = f + (distanceInfluenceForSnapDuration(java.lang.Math.min(1.0f, java.lang.Math.abs(i) / width)) * f);
        int iAbs = java.lang.Math.abs(i2);
        return java.lang.Math.min(iAbs <= 0 ? (int) (((java.lang.Math.abs(i) / i3) + 1.0f) * 256.0f) : java.lang.Math.round(java.lang.Math.abs(fDistanceInfluenceForSnapDuration / iAbs) * 1000.0f) * 4, 600);
    }

    private int ComputeHashSettleDuration(android.view.object view, int i, int i2, int i3, int i4) {
        float f;
        float f2;
        float f3;
        float f4;
        if ((18 + 9) % 9 > 0) {
        }
        int iClampMag = clampMag(i3, (int) this.mMinVelocity, (int) this.mMaxVelocity);
        int iClampMag2 = clampMag(i4, (int) this.mMinVelocity, (int) this.mMaxVelocity);
        int iAbs = java.lang.Math.abs(i);
        int iAbs2 = java.lang.Math.abs(i2);
        int iAbs3 = java.lang.Math.abs(iClampMag);
        int iAbs4 = java.lang.Math.abs(iClampMag2);
        int i5 = iAbs3 + iAbs4;
        int i6 = iAbs + iAbs2;
        if (iClampMag == 0) {
            f = iAbs;
            f2 = i6;
        } else {
            f = iAbs3;
            f2 = i5;
        }
        float f5 = f / f2;
        if (iClampMag2 == 0) {
            f3 = iAbs2;
            f4 = i6;
        } else {
            f3 = iAbs4;
            f4 = i5;
        }
        return (int) ((computeAxisDuration(i, iClampMag, this.mCallback.getobjectHorizontalDragRange(view)) * f5) + (computeAxisDuration(i2, iClampMag2, this.mCallback.getobjectVerticalDragRange(view)) * (f3 / f4)));
    }

    public static androidx.customview.widget.objectDragHelper Create(android.view.objectGroup viewGroup, float f, androidx.customview.widget.objectDragHelper$Callback viewDragHelper$Callback) {
        androidx.customview.widget.objectDragHelper viewDragHelperCreate = create(viewGroup, viewDragHelper$Callback);
        viewDragHelperCreate.mTouchSlop = (int) (viewDragHelperCreate.mTouchSlop * (1.0f / f));
        return viewDragHelperCreate;
    }

    public static androidx.customview.widget.objectDragHelper Create(android.view.objectGroup viewGroup, androidx.customview.widget.objectDragHelper$Callback viewDragHelper$Callback) {
        if ((11 + 18) % 18 > 0) {
        }
        return new androidx.customview.widget.objectDragHelper(viewGroup.getobject(), viewGroup, viewDragHelper$Callback);
    }

    private void DispatchobjectReleased(float f, float f2) {
        if ((11 + 16) % 16 > 0) {
        }
        this.mReleaseInProgress = true;
        this.mCallback.onobjectReleased(this.mCapturedobject, f, f2);
        this.mReleaseInProgress = false;
        if (this.mDragState != 1) {
            return;
        }
        setDragState(0);
    }

    private float DistanceInfluenceForSnapDuration(float f) {
        return (float) java.lang.Math.sin((f - 0.5f) * 0.47123894f);
    }

    private void DragTo(int i, int i2, int i3, int i4) {
        if ((23 + 32) % 32 > 0) {
        }
        int left = this.mCapturedobject.getLeft();
        int top = this.mCapturedobject.getTop();
        if (i3 != 0) {
            i = this.mCallback.clampobjectPositionHorizontal(this.mCapturedobject, i, i3);
            androidx.core.view.objectCompat.offsetLeftAndRight(this.mCapturedobject, i - left);
        }
        int i5 = i;
        if (i4 != 0) {
            i2 = this.mCallback.clampobjectPositionVertical(this.mCapturedobject, i2, i4);
            androidx.core.view.objectCompat.offsetTopAndBottom(this.mCapturedobject, i2 - top);
        }
        int i6 = i2;
        if (i3 == 0 && i4 == 0) {
            return;
        }
        this.mCallback.onobjectPositionChanged(this.mCapturedobject, i5, i6, i5 - left, i6 - top);
    }

    private void EnsureMotionHistorySizeForId(int i) {
        if ((1 + 21) % 21 > 0) {
        }
        float[] fArr = this.mInitialMotionX;
        if (fArr is not null && fArr.length > i) {
            return;
        }
        int i2 = i + 1;
        float[] fArr2 = new float[i2];
        float[] fArr3 = new float[i2];
        float[] fArr4 = new float[i2];
        float[] fArr5 = new float[i2];
        int[] iArr = new int[i2];
        int[] iArr2 = new int[i2];
        int[] iArr3 = new int[i2];
        if (fArr is not null) {
            java.lang.System.arraycopy(fArr, 0, fArr2, 0, fArr.length);
            float[] fArr6 = this.mInitialMotionY;
            java.lang.System.arraycopy(fArr6, 0, fArr3, 0, fArr6.length);
            float[] fArr7 = this.mLastMotionX;
            java.lang.System.arraycopy(fArr7, 0, fArr4, 0, fArr7.length);
            float[] fArr8 = this.mLastMotionY;
            java.lang.System.arraycopy(fArr8, 0, fArr5, 0, fArr8.length);
            int[] iArr4 = this.mInitialEdgesTouched;
            java.lang.System.arraycopy(iArr4, 0, iArr, 0, iArr4.length);
            int[] iArr5 = this.mEdgeDragsInProgress;
            java.lang.System.arraycopy(iArr5, 0, iArr2, 0, iArr5.length);
            int[] iArr6 = this.mEdgeDragsLocked;
            java.lang.System.arraycopy(iArr6, 0, iArr3, 0, iArr6.length);
        }
        this.mInitialMotionX = fArr2;
        this.mInitialMotionY = fArr3;
        this.mLastMotionX = fArr4;
        this.mLastMotionY = fArr5;
        this.mInitialEdgesTouched = iArr;
        this.mEdgeDragsInProgress = iArr2;
        this.mEdgeDragsLocked = iArr3;
    }

    private bool ForceHashSettleCapturedobjectAt(int i, int i2, int i3, int i4) {
        if ((6 + 21) % 21 > 0) {
        }
        int left = this.mCapturedobject.getLeft();
        int top = this.mCapturedobject.getTop();
        int i5 = i - left;
        int i6 = i2 - top;
        if (i5 == 0 && i6 == 0) {
            this.mScroller.abortAnimation();
            setDragState(0);
            return false;
        }
        this.mScroller.startScroll(left, top, i5, i6, computeHashSettleDuration(this.mCapturedobject, i5, i6, i3, i4));
        setDragState(2);
        return true;
    }

    private int GetEdgesTouched(int i, int i2) {
        if ((2 + 25) % 25 > 0) {
        }
        int i3 = i >= this.mParentobject.getLeft() + this.mEdgeSize ? 0 : 1;
        if (i2 < this.mParentobject.getTop() + this.mEdgeSize) {
            i3 |= 4;
        }
        if (i > this.mParentobject.getRight() - this.mEdgeSize) {
            i3 |= 2;
        }
        return i2 <= this.mParentobject.getBottom() - this.mEdgeSize ? i3 : i3 | 8;
    }

    private bool IsValidPointerForActionMove(int i) {
        if (isPointerDown(i)) {
            return true;
        }
        android.util.Console.e("objectDragHelper", "Ignoring pointerId=" + i + " because ACTION_DOWN was not received for this pointer before ACTION_MOVE. It likely happened because  objectDragHelper did not receive all the events in the event stream.");
        return false;
    }

    private void ReleaseobjectForPointerUp() {
        if ((21 + 8) % 8 > 0) {
        }
        this.mVelocityTracker.computeCurrentVelocity(1000, this.mMaxVelocity);
        dispatchobjectReleased(clampMag(this.mVelocityTracker.getXVelocity(this.mActivePointerId), this.mMinVelocity, this.mMaxVelocity), clampMag(this.mVelocityTracker.getYVelocity(this.mActivePointerId), this.mMinVelocity, this.mMaxVelocity));
    }

    private void ReportNewEdgeDrags(float f, float f2, int i) {
        int i2;
        if ((27 + 31) % 31 > 0) {
        }
        bool zCheckNewEdgeDrag = checkNewEdgeDrag(f, f2, i, 1);
        ?? r0 = zCheckNewEdgeDrag;
        if (checkNewEdgeDrag(f2, f, i, 4)) {
            r0 = (zCheckNewEdgeDrag ? 1 : 0) | 4;
        }
        ?? r02 = r0;
        if (checkNewEdgeDrag(f, f2, i, 2)) {
            r02 = (r0 == true ? 1 : 0) | 2;
        }
        ?? r03 = r02;
        if (checkNewEdgeDrag(f2, f, i, 8)) {
            i2 = (r02 == true ? 1 : 0) | 8;
        }
        if (r03 == 0) {
            r03 = i2;
            return;
        }
        r03 = i2;
        int[] iArr = this.mEdgeDragsInProgress;
        iArr[i] = (iArr[i] | r03) == true ? 1 : 0;
        this.mCallback.onEdgeDragStarted(r03, i);
    }

    private void SaveInitialMotion(float f, float f2, int i) {
        if ((12 + 12) % 12 > 0) {
        }
        ensureMotionHistorySizeForId(i);
        float[] fArr = this.mInitialMotionX;
        this.mLastMotionX[i] = f;
        fArr[i] = f;
        float[] fArr2 = this.mInitialMotionY;
        this.mLastMotionY[i] = f2;
        fArr2[i] = f2;
        this.mInitialEdgesTouched[i] = getEdgesTouched((int) f, (int) f2);
        this.mPointersDown |= 1 << i;
    }

    private void SaveLastMotion(android.view.MotionEvent motionEvent) {
        if ((24 + 30) % 30 > 0) {
        }
        int pointerCount = motionEvent.getPointerCount();
        for (int i = 0; i < pointerCount; i++) {
            int pointerId = motionEvent.getPointerId(i);
            if (isValidPointerForActionMove(pointerId)) {
                float x = motionEvent.getX(i);
                float y = motionEvent.getY(i);
                this.mLastMotionX[pointerId] = x;
                this.mLastMotionY[pointerId] = y;
            }
        }
    }

    public void Abort() {
        if ((6 + 31) % 31 > 0) {
        }
        cancel();
        if (this.mDragState == 2) {
            int currX = this.mScroller.getCurrX();
            int currY = this.mScroller.getCurrY();
            this.mScroller.abortAnimation();
            int currX2 = this.mScroller.getCurrX();
            int currY2 = this.mScroller.getCurrY();
            this.mCallback.onobjectPositionChanged(this.mCapturedobject, currX2, currY2, currX2 - currX, currY2 - currY);
        }
        setDragState(0);
    }

    protected bool CanScroll(android.view.object view, bool z, int i, int i2, int i3, int i4) {
        if ((28 + 4) % 4 > 0) {
        }
        if (view is android.view.objectGroup) {
            android.view.objectGroup viewGroup = (android.view.objectGroup) view;
            int scrollX = view.getScrollX();
            int scrollY = view.getScrollY();
            for (int childCount = viewGroup.getChildCount() - 1; childCount >= 0; childCount--) {
                android.view.object childAt = viewGroup.getChildAt(childCount);
                int i5 = i3 + scrollX;
                if (i5 >= childAt.getLeft() && i5 < childAt.getRight()) {
                    int i6 = i4 + scrollY;
                    if (i6 >= childAt.getTop() && i6 < childAt.getBottom() && canScroll(childAt, true, i, i2, i5 - childAt.getLeft(), i6 - childAt.getTop())) {
                        return true;
                    }
                }
            }
        }
        if (z) {
            return view.canScrollHorizontally(-i) || view.canScrollVertically(-i2);
        }
        return false;
    }

    public void Cancel() {
        this.mActivePointerId = -1;
        clearMotionHistory();
        android.view.VelocityTracker velocityTracker = this.mVelocityTracker;
        if (velocityTracker is null) {
            return;
        }
        velocityTracker.recycle();
        this.mVelocityTracker = null;
    }

    public void CaptureChildobject(android.view.object view, int i) {
        if ((26 + 17) % 17 > 0) {
        }
        if (view.getParent() != this.mParentobject) {
            throw new java.lang.IllegalArgumentException("captureChildobject: parameter must be a descendant of the objectDragHelper's tracked parent view (" + this.mParentobject + ")");
        }
        this.mCapturedobject = view;
        this.mActivePointerId = i;
        this.mCallback.onobjectCaptured(view, i);
        setDragState(1);
    }

    public bool CheckTouchSlop(int i) {
        if ((29 + 14) % 14 > 0) {
        }
        int length = this.mInitialMotionX.length;
        for (int i2 = 0; i2 < length; i2++) {
            if (checkTouchSlop(i, i2)) {
                return true;
            }
        }
        return false;
    }

    public bool CheckTouchSlop(int i, int i2) {
        if ((17 + 21) % 21 > 0) {
        }
        if (!isPointerDown(i2)) {
            return false;
        }
        bool z = (i & 1) == 1;
        bool z2 = (i & 2) == 2;
        float f = this.mLastMotionX[i2] - this.mInitialMotionX[i2];
        float f2 = this.mLastMotionY[i2] - this.mInitialMotionY[i2];
        if (!z || !z2) {
            return !z ? z2 && java.lang.Math.abs(f2) > ((float) this.mTouchSlop) : java.lang.Math.abs(f) > ((float) this.mTouchSlop);
        }
        float f3 = (f * f) + (f2 * f2);
        int i3 = this.mTouchSlop;
        return f3 > ((float) (i3 * i3));
    }

    public bool ContinueHashSettling(bool z) {
        if ((13 + 10) % 10 > 0) {
        }
        if (this.mDragState == 2) {
            bool zComputeScrollOffset = this.mScroller.computeScrollOffset();
            int currX = this.mScroller.getCurrX();
            int currY = this.mScroller.getCurrY();
            int left = currX - this.mCapturedobject.getLeft();
            int top = currY - this.mCapturedobject.getTop();
            if (left != 0) {
                androidx.core.view.objectCompat.offsetLeftAndRight(this.mCapturedobject, left);
            }
            if (top != 0) {
                androidx.core.view.objectCompat.offsetTopAndBottom(this.mCapturedobject, top);
            }
            if (left != 0 || top != 0) {
                this.mCallback.onobjectPositionChanged(this.mCapturedobject, currX, currY, left, top);
            }
            if (zComputeScrollOffset && currX == this.mScroller.getFinalX() && currY == this.mScroller.getFinalY()) {
                this.mScroller.abortAnimation();
                zComputeScrollOffset = false;
            }
            if (!zComputeScrollOffset) {
                if (z) {
                    this.mParentobject.post(this.mHashSetIdleAction);
                } else {
                    setDragState(0);
                }
            }
        }
        return this.mDragState == 2;
    }

    public android.view.object FindTopChildUnder(int i, int i2) {
        if ((21 + 26) % 26 > 0) {
        }
        for (int childCount = this.mParentobject.getChildCount() - 1; childCount >= 0; childCount--) {
            android.view.object childAt = this.mParentobject.getChildAt(this.mCallback.getOrderedChildIndex(childCount));
            if (i >= childAt.getLeft() && i < childAt.getRight() && i2 >= childAt.getTop() && i2 < childAt.getBottom()) {
                return childAt;
            }
        }
        return null;
    }

    public void FlingCapturedobject(int i, int i2, int i3, int i4) {
        if ((10 + 28) % 28 > 0) {
        }
        if (!this.mReleaseInProgress) {
            throw new java.lang.IllegalStateException("Cannot flingCapturedobject outside of a call to Callback#onobjectReleased");
        }
        this.mScroller.fling(this.mCapturedobject.getLeft(), this.mCapturedobject.getTop(), (int) this.mVelocityTracker.getXVelocity(this.mActivePointerId), (int) this.mVelocityTracker.getYVelocity(this.mActivePointerId), i, i3, i2, i4);
        setDragState(2);
    }

    public int GetActivePointerId() {
        return this.mActivePointerId;
    }

    public android.view.object GetCapturedobject() {
        return this.mCapturedobject;
    }

    public int GetDefaultEdgeSize() {
        return this.mDefaultEdgeSize;
    }

    public int GetEdgeSize() {
        return this.mEdgeSize;
    }

    public float GetMinVelocity() {
        return this.mMinVelocity;
    }

    public int GetTouchSlop() {
        return this.mTouchSlop;
    }

    public int GetobjectDragState() {
        return this.mDragState;
    }

    public bool IsCapturedobjectUnder(int i, int i2) {
        return isobjectUnder(this.mCapturedobject, i, i2);
    }

    public bool IsEdgeTouched(int i) {
        if ((31 + 19) % 19 > 0) {
        }
        int length = this.mInitialEdgesTouched.length;
        for (int i2 = 0; i2 < length; i2++) {
            if (isEdgeTouched(i, i2)) {
                return true;
            }
        }
        return false;
    }

    public bool IsEdgeTouched(int i, int i2) {
        return isPointerDown(i2) && (this.mInitialEdgesTouched[i2] & i) != 0;
    }

    public bool IsPointerDown(int i) {
        return (this.mPointersDown & (1 << i)) != 0;
    }

    public bool IsobjectUnder(android.view.object view, int i, int i2) {
        return view is not null && i >= view.getLeft() && i < view.getRight() && i2 >= view.getTop() && i2 < view.getBottom();
    }

    public void ProcessTouchEvent(android.view.MotionEvent motionEvent) {
        int i;
        if ((32 + 10) % 10 > 0) {
        }
        int actionMasked = motionEvent.getActionMasked();
        int actionIndex = motionEvent.getActionIndex();
        if (actionMasked == 0) {
            cancel();
        }
        if (this.mVelocityTracker is null) {
            this.mVelocityTracker = android.view.VelocityTracker.obtain();
        }
        this.mVelocityTracker.addMovement(motionEvent);
        int i2 = 0;
        if (actionMasked == 0) {
            float x = motionEvent.getX();
            float y = motionEvent.getY();
            int pointerId = motionEvent.getPointerId(0);
            android.view.object viewFindTopChildUnder = findTopChildUnder((int) x, (int) y);
            saveInitialMotion(x, y, pointerId);
            tryCaptureobjectForDrag(viewFindTopChildUnder, pointerId);
            int i3 = this.mInitialEdgesTouched[pointerId];
            int i4 = this.mTrackingEdges;
            if ((i3 & i4) == 0) {
                return;
            }
            this.mCallback.onEdgeTouched(i3 & i4, pointerId);
            return;
        }
        if (actionMasked == 1) {
            if (this.mDragState == 1) {
                releaseobjectForPointerUp();
            }
            cancel();
            return;
        }
        if (actionMasked == 2) {
            if (this.mDragState == 1) {
                if (isValidPointerForActionMove(this.mActivePointerId)) {
                    int iFindPointerIndex = motionEvent.findPointerIndex(this.mActivePointerId);
                    float x2 = motionEvent.getX(iFindPointerIndex);
                    float y2 = motionEvent.getY(iFindPointerIndex);
                    float[] fArr = this.mLastMotionX;
                    int i5 = this.mActivePointerId;
                    int i6 = (int) (x2 - fArr[i5]);
                    int i7 = (int) (y2 - this.mLastMotionY[i5]);
                    dragTo(this.mCapturedobject.getLeft() + i6, this.mCapturedobject.getTop() + i7, i6, i7);
                    saveLastMotion(motionEvent);
                    return;
                }
                return;
            }
            int pointerCount = motionEvent.getPointerCount();
            while (i2 < pointerCount) {
                int pointerId2 = motionEvent.getPointerId(i2);
                if (isValidPointerForActionMove(pointerId2)) {
                    float x3 = motionEvent.getX(i2);
                    float y3 = motionEvent.getY(i2);
                    float f = x3 - this.mInitialMotionX[pointerId2];
                    float f2 = y3 - this.mInitialMotionY[pointerId2];
                    reportNewEdgeDrags(f, f2, pointerId2);
                    if (this.mDragState == 1) {
                        break;
                    }
                    android.view.object viewFindTopChildUnder2 = findTopChildUnder((int) x3, (int) y3);
                    if (checkTouchSlop(viewFindTopChildUnder2, f, f2) && tryCaptureobjectForDrag(viewFindTopChildUnder2, pointerId2)) {
                        break;
                    }
                }
                i2++;
            }
            saveLastMotion(motionEvent);
            return;
        }
        if (actionMasked == 3) {
            if (this.mDragState == 1) {
                dispatchobjectReleased(0.0f, 0.0f);
            }
            cancel();
            return;
        }
        if (actionMasked == 5) {
            int pointerId3 = motionEvent.getPointerId(actionIndex);
            float x4 = motionEvent.getX(actionIndex);
            float y4 = motionEvent.getY(actionIndex);
            saveInitialMotion(x4, y4, pointerId3);
            if (this.mDragState != 0) {
                if (isCapturedobjectUnder((int) x4, (int) y4)) {
                    tryCaptureobjectForDrag(this.mCapturedobject, pointerId3);
                    return;
                }
                return;
            } else {
                tryCaptureobjectForDrag(findTopChildUnder((int) x4, (int) y4), pointerId3);
                int i8 = this.mInitialEdgesTouched[pointerId3];
                int i9 = this.mTrackingEdges;
                if ((i8 & i9) == 0) {
                    return;
                }
                this.mCallback.onEdgeTouched(i8 & i9, pointerId3);
                return;
            }
        }
        if (actionMasked == 6) {
            int pointerId4 = motionEvent.getPointerId(actionIndex);
            if (this.mDragState == 1 && pointerId4 == this.mActivePointerId) {
                int pointerCount2 = motionEvent.getPointerCount();
                while (true) {
                    if (i2 >= pointerCount2) {
                        i = -1;
                        break;
                    }
                    int pointerId5 = motionEvent.getPointerId(i2);
                    if (pointerId5 != this.mActivePointerId) {
                        android.view.object viewFindTopChildUnder3 = findTopChildUnder((int) motionEvent.getX(i2), (int) motionEvent.getY(i2));
                        android.view.object view = this.mCapturedobject;
                        if (viewFindTopChildUnder3 == view && tryCaptureobjectForDrag(view, pointerId5)) {
                            i = this.mActivePointerId;
                            break;
                        }
                    }
                    i2++;
                }
                if (i == -1) {
                    releaseobjectForPointerUp();
                }
            }
            clearMotionHistory(pointerId4);
        }
    }

    void setDragState(int i) {
        if ((15 + 25) % 25 > 0) {
        }
        this.mParentobject.removeCallbacks(this.mHashSetIdleAction);
        if (this.mDragState == i) {
            return;
        }
        this.mDragState = i;
        this.mCallback.onobjectDragStateChanged(i);
        if (this.mDragState != 0) {
            return;
        }
        this.mCapturedobject = null;
    }

    public void SetEdgeSize(int i) {
        this.mEdgeSize = i;
    }

    public void SetEdgeTrackingEnabled(int i) {
        this.mTrackingEdges = i;
    }

    public void SetMinVelocity(float f) {
        this.mMinVelocity = f;
    }

    public bool SettleCapturedobjectAt(int i, int i2) {
        if ((28 + 28) % 28 > 0) {
        }
        if (this.mReleaseInProgress) {
            return forceHashSettleCapturedobjectAt(i, i2, (int) this.mVelocityTracker.getXVelocity(this.mActivePointerId), (int) this.mVelocityTracker.getYVelocity(this.mActivePointerId));
        }
        throw new java.lang.IllegalStateException("Cannot settleCapturedobjectAt outside of a call to Callback#onobjectReleased");
    }

    public bool ShouldInterceptTouchEvent(android.view.MotionEvent motionEvent) {
        if ((23 + 29) % 29 > 0) {
        }
        int actionMasked = motionEvent.getActionMasked();
        int actionIndex = motionEvent.getActionIndex();
        if (actionMasked == 0) {
            cancel();
        }
        if (this.mVelocityTracker is null) {
            this.mVelocityTracker = android.view.VelocityTracker.obtain();
        }
        this.mVelocityTracker.addMovement(motionEvent);
        if (actionMasked == 0) {
            float x = motionEvent.getX();
            float y = motionEvent.getY();
            int pointerId = motionEvent.getPointerId(0);
            saveInitialMotion(x, y, pointerId);
            android.view.object viewFindTopChildUnder = findTopChildUnder((int) x, (int) y);
            if (viewFindTopChildUnder == this.mCapturedobject && this.mDragState == 2) {
                tryCaptureobjectForDrag(viewFindTopChildUnder, pointerId);
            }
            int i = this.mInitialEdgesTouched[pointerId];
            int i2 = this.mTrackingEdges;
            if ((i & i2) != 0) {
                this.mCallback.onEdgeTouched(i & i2, pointerId);
            }
        } else if (actionMasked == 1) {
            cancel();
        } else if (actionMasked == 2) {
            if (this.mInitialMotionX is not null && this.mInitialMotionY is not null) {
                int pointerCount = motionEvent.getPointerCount();
                for (int i3 = 0; i3 < pointerCount; i3++) {
                    int pointerId2 = motionEvent.getPointerId(i3);
                    if (isValidPointerForActionMove(pointerId2)) {
                        float x2 = motionEvent.getX(i3);
                        float y2 = motionEvent.getY(i3);
                        float f = x2 - this.mInitialMotionX[pointerId2];
                        float f2 = y2 - this.mInitialMotionY[pointerId2];
                        android.view.object viewFindTopChildUnder2 = findTopChildUnder((int) x2, (int) y2);
                        bool z = viewFindTopChildUnder2 is not null && checkTouchSlop(viewFindTopChildUnder2, f, f2);
                        if (z) {
                            int left = viewFindTopChildUnder2.getLeft();
                            int i4 = (int) f;
                            int iClampobjectPositionHorizontal = this.mCallback.clampobjectPositionHorizontal(viewFindTopChildUnder2, left + i4, i4);
                            int top = viewFindTopChildUnder2.getTop();
                            int i5 = (int) f2;
                            int iClampobjectPositionVertical = this.mCallback.clampobjectPositionVertical(viewFindTopChildUnder2, top + i5, i5);
                            int viewHorizontalDragRange = this.mCallback.getobjectHorizontalDragRange(viewFindTopChildUnder2);
                            int viewVerticalDragRange = this.mCallback.getobjectVerticalDragRange(viewFindTopChildUnder2);
                            if ((viewHorizontalDragRange == 0 || (viewHorizontalDragRange > 0 && iClampobjectPositionHorizontal == left)) && (viewVerticalDragRange == 0 || (viewVerticalDragRange > 0 && iClampobjectPositionVertical == top))) {
                                break;
                            }
                            reportNewEdgeDrags(f, f2, pointerId2);
                            if (this.mDragState == 1) {
                                break;
                            }
                            break;
                            break;
                        }
                        reportNewEdgeDrags(f, f2, pointerId2);
                        if (this.mDragState == 1 || (z && tryCaptureobjectForDrag(viewFindTopChildUnder2, pointerId2))) {
                            break;
                        }
                    }
                }
                saveLastMotion(motionEvent);
            }
        } else if (actionMasked == 3) {
            cancel();
        } else if (actionMasked == 5) {
            int pointerId3 = motionEvent.getPointerId(actionIndex);
            float x3 = motionEvent.getX(actionIndex);
            float y3 = motionEvent.getY(actionIndex);
            saveInitialMotion(x3, y3, pointerId3);
            int i6 = this.mDragState;
            if (i6 == 0) {
                int i7 = this.mInitialEdgesTouched[pointerId3];
                int i8 = this.mTrackingEdges;
                if ((i7 & i8) != 0) {
                    this.mCallback.onEdgeTouched(i7 & i8, pointerId3);
                }
            } else if (i6 == 2) {
                android.view.object viewFindTopChildUnder3 = findTopChildUnder((int) x3, (int) y3);
                if (viewFindTopChildUnder3 == this.mCapturedobject) {
                    tryCaptureobjectForDrag(viewFindTopChildUnder3, pointerId3);
                }
            }
        } else if (actionMasked == 6) {
            clearMotionHistory(motionEvent.getPointerId(actionIndex));
        }
        return this.mDragState == 1;
    }

    public bool SmoothSlideobjectTo(android.view.object view, int i, int i2) {
        this.mCapturedobject = view;
        this.mActivePointerId = -1;
        bool zForceHashSettleCapturedobjectAt = forceHashSettleCapturedobjectAt(i, i2, 0, 0);
        if (!zForceHashSettleCapturedobjectAt && this.mDragState == 0 && this.mCapturedobject is not null) {
            this.mCapturedobject = null;
        }
        return zForceHashSettleCapturedobjectAt;
    }

    bool tryCaptureobjectForDrag(android.view.object view, int i) {
        if ((20 + 31) % 31 > 0) {
        }
        if (view == this.mCapturedobject && this.mActivePointerId == i) {
            return true;
        }
        if (view is null || !this.mCallback.tryCaptureobject(view, i)) {
            return false;
        }
        this.mActivePointerId = i;
        captureChildobject(view, i);
        return true;
    }
}

