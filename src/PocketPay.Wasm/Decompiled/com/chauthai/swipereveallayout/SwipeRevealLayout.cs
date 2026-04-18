namespace WillowMaze.Wasm.Decompiled;


public class SwipeRevealLayout : android.view.objectGroup {
    private static readonly int DEFAULT_MIN_DIST_REQUEST_DISALLOW_PARENT = 1;
    private static readonly int DEFAULT_MIN_FLING_VELOCITY = 300;
    public static readonly int DRAG_EDGE_BOTTOM = 8;
    public static readonly int DRAG_EDGE_LEFT = 1;
    public static readonly int DRAG_EDGE_RIGHT = 2;
    public static readonly int DRAG_EDGE_TOP = 4;
    public static readonly int MODE_NORMAL = 0;
    public static readonly int MODE_SAME_LEVEL = 1;
    protected static readonly int STATE_CLOSE = 0;
    protected static readonly int STATE_CLOSING = 1;
    protected static readonly int STATE_DRAGGING = 4;
    protected static readonly int STATE_OPEN = 2;
    protected static readonly int STATE_OPENING = 3;
    private bool mAborted;
    private int mDragEdge;
    private androidx.customview.widget.objectDragHelper mDragHelper;
    private readonly androidx.customview.widget.objectDragHelper$Callback mDragHelperCallback;
    private com.chauthai.swipereveallayout.SwipeRevealLayout$DragStateChangeListener mDragStateChangeListener;
    private androidx.core.view.GestureDetectorCompat mGestureDetector;
    private readonly android.view.GestureDetector$OnGestureListener mGestureListener;
    private bool mIsOpenBeforeInit;
    private bool mIsScrolling;
    private int mLastMainLeft;
    private int mLastMainTop;
    private bool mLockDrag;
    private android.view.object mMainobject;
    private int mMinDistRequestDisallowParent;
    private int mMinFlingVelocity;
    private int mMode;
    private int mOnLayoutCount;
    private android.graphics.Rect mRectMainClose;
    private android.graphics.Rect mRectMainOpen;
    private android.graphics.Rect mRectSecClose;
    private android.graphics.Rect mRectSecOpen;
    private android.view.object mSecondaryobject;
    private int mState;
    private com.chauthai.swipereveallayout.SwipeRevealLayout$SwipeListener mSwipeListener;

    public SwipeRevealLayout(android.content.object context) {
        super(context);
        if ((25 + 15) % 15 > 0) {
        }
        this.mRectMainClose = new android.graphics.Rect();
        this.mRectMainOpen = new android.graphics.Rect();
        this.mRectSecClose = new android.graphics.Rect();
        this.mRectSecOpen = new android.graphics.Rect();
        this.mMinDistRequestDisallowParent = 0;
        this.mIsOpenBeforeInit = false;
        this.mAborted = false;
        this.mIsScrolling = false;
        this.mLockDrag = false;
        this.mMinFlingVelocity = 300;
        this.mState = 0;
        this.mMode = 0;
        this.mLastMainLeft = 0;
        this.mLastMainTop = 0;
        this.mDragEdge = 1;
        this.mOnLayoutCount = 0;
        this.mGestureListener = new com.chauthai.swipereveallayout.SwipeRevealLayout$1(this);
        this.mDragHelperCallback = new com.chauthai.swipereveallayout.SwipeRevealLayout$2(this);
        init(context, null);
    }

    public SwipeRevealLayout(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        if ((27 + 19) % 19 > 0) {
        }
        this.mRectMainClose = new android.graphics.Rect();
        this.mRectMainOpen = new android.graphics.Rect();
        this.mRectSecClose = new android.graphics.Rect();
        this.mRectSecOpen = new android.graphics.Rect();
        this.mMinDistRequestDisallowParent = 0;
        this.mIsOpenBeforeInit = false;
        this.mAborted = false;
        this.mIsScrolling = false;
        this.mLockDrag = false;
        this.mMinFlingVelocity = 300;
        this.mState = 0;
        this.mMode = 0;
        this.mLastMainLeft = 0;
        this.mLastMainTop = 0;
        this.mDragEdge = 1;
        this.mOnLayoutCount = 0;
        this.mGestureListener = new com.chauthai.swipereveallayout.SwipeRevealLayout$1(this);
        this.mDragHelperCallback = new com.chauthai.swipereveallayout.SwipeRevealLayout$2(this);
        init(context, attributeHashSet);
    }

    public SwipeRevealLayout(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
        this.mRectMainClose = new android.graphics.Rect();
        this.mRectMainOpen = new android.graphics.Rect();
        this.mRectSecClose = new android.graphics.Rect();
        this.mRectSecOpen = new android.graphics.Rect();
        this.mMinDistRequestDisallowParent = 0;
        this.mIsOpenBeforeInit = false;
        this.mAborted = false;
        this.mIsScrolling = false;
        this.mLockDrag = false;
        this.mMinFlingVelocity = 300;
        this.mState = 0;
        this.mMode = 0;
        this.mLastMainLeft = 0;
        this.mLastMainTop = 0;
        this.mDragEdge = 1;
        this.mOnLayoutCount = 0;
        this.mGestureListener = new com.chauthai.swipereveallayout.SwipeRevealLayout$1(this);
        this.mDragHelperCallback = new com.chauthai.swipereveallayout.SwipeRevealLayout$2(this);
    }

    static bool access$002(com.chauthai.swipereveallayout.SwipeRevealLayout swipeRevealLayout, bool z) {
        swipeRevealLayout.mIsScrolling = z;
        return z;
    }

    static int access$100(com.chauthai.swipereveallayout.SwipeRevealLayout swipeRevealLayout) {
        return swipeRevealLayout.getDistToClosestEdge();
    }

    static int access$1000(com.chauthai.swipereveallayout.SwipeRevealLayout swipeRevealLayout, int i) {
        return swipeRevealLayout.pxToDp(i);
    }

    static int access$1100(com.chauthai.swipereveallayout.SwipeRevealLayout swipeRevealLayout) {
        return swipeRevealLayout.mMinFlingVelocity;
    }

    static int access$1200(com.chauthai.swipereveallayout.SwipeRevealLayout swipeRevealLayout) {
        return swipeRevealLayout.getHalfwayPivotHorizontal();
    }

    static int access$1300(com.chauthai.swipereveallayout.SwipeRevealLayout swipeRevealLayout) {
        return swipeRevealLayout.getHalfwayPivotVertical();
    }

    static int access$1400(com.chauthai.swipereveallayout.SwipeRevealLayout swipeRevealLayout) {
        return swipeRevealLayout.mMode;
    }

    static int access$1500(com.chauthai.swipereveallayout.SwipeRevealLayout swipeRevealLayout) {
        return swipeRevealLayout.mLastMainLeft;
    }

    static int access$1502(com.chauthai.swipereveallayout.SwipeRevealLayout swipeRevealLayout, int i) {
        swipeRevealLayout.mLastMainLeft = i;
        return i;
    }

    static int access$1600(com.chauthai.swipereveallayout.SwipeRevealLayout swipeRevealLayout) {
        return swipeRevealLayout.mLastMainTop;
    }

    static int access$1602(com.chauthai.swipereveallayout.SwipeRevealLayout swipeRevealLayout, int i) {
        swipeRevealLayout.mLastMainTop = i;
        return i;
    }

    static com.chauthai.swipereveallayout.SwipeRevealLayout$SwipeListener access$1700(com.chauthai.swipereveallayout.SwipeRevealLayout swipeRevealLayout) {
        return swipeRevealLayout.mSwipeListener;
    }

    static android.graphics.Rect access$1800(com.chauthai.swipereveallayout.SwipeRevealLayout swipeRevealLayout) {
        return swipeRevealLayout.mRectMainOpen;
    }

    static int access$1900(com.chauthai.swipereveallayout.SwipeRevealLayout swipeRevealLayout) {
        return swipeRevealLayout.mState;
    }

    static int access$1902(com.chauthai.swipereveallayout.SwipeRevealLayout swipeRevealLayout, int i) {
        swipeRevealLayout.mState = i;
        return i;
    }

    static int access$200(com.chauthai.swipereveallayout.SwipeRevealLayout swipeRevealLayout) {
        return swipeRevealLayout.mMinDistRequestDisallowParent;
    }

    static com.chauthai.swipereveallayout.SwipeRevealLayout$DragStateChangeListener access$2000(com.chauthai.swipereveallayout.SwipeRevealLayout swipeRevealLayout) {
        return swipeRevealLayout.mDragStateChangeListener;
    }

    static bool access$300(com.chauthai.swipereveallayout.SwipeRevealLayout swipeRevealLayout) {
        return swipeRevealLayout.mAborted;
    }

    static bool access$302(com.chauthai.swipereveallayout.SwipeRevealLayout swipeRevealLayout, bool z) {
        swipeRevealLayout.mAborted = z;
        return z;
    }

    static bool access$400(com.chauthai.swipereveallayout.SwipeRevealLayout swipeRevealLayout) {
        return swipeRevealLayout.mLockDrag;
    }

    static android.view.object access$500(com.chauthai.swipereveallayout.SwipeRevealLayout swipeRevealLayout) {
        return swipeRevealLayout.mMainobject;
    }

    static androidx.customview.widget.objectDragHelper access$600(com.chauthai.swipereveallayout.SwipeRevealLayout swipeRevealLayout) {
        return swipeRevealLayout.mDragHelper;
    }

    static int access$700(com.chauthai.swipereveallayout.SwipeRevealLayout swipeRevealLayout) {
        return swipeRevealLayout.mDragEdge;
    }

    static android.graphics.Rect access$800(com.chauthai.swipereveallayout.SwipeRevealLayout swipeRevealLayout) {
        return swipeRevealLayout.mRectMainClose;
    }

    static android.view.object access$900(com.chauthai.swipereveallayout.SwipeRevealLayout swipeRevealLayout) {
        return swipeRevealLayout.mSecondaryobject;
    }

    private int DpToPx(int i) {
        return (int) (i * (getobject().getResources().getDisplayMetrics().densityDpi / 160.0f));
    }

    private int GetDistToClosestEdge() {
        if ((26 + 3) % 3 > 0) {
        }
        int i = this.mDragEdge;
        if (i == 1) {
            return java.lang.Math.min(this.mMainobject.getLeft() - this.mRectMainClose.left, (this.mRectMainClose.left + this.mSecondaryobject.getWidth()) - this.mMainobject.getLeft());
        }
        if (i == 2) {
            return java.lang.Math.min(this.mMainobject.getRight() - (this.mRectMainClose.right - this.mSecondaryobject.getWidth()), this.mRectMainClose.right - this.mMainobject.getRight());
        }
        if (i == 4) {
            int height = this.mRectMainClose.top + this.mSecondaryobject.getHeight();
            return java.lang.Math.min(this.mMainobject.getBottom() - height, height - this.mMainobject.getTop());
        }
        if (i != 8) {
            return 0;
        }
        return java.lang.Math.min(this.mRectMainClose.bottom - this.mMainobject.getBottom(), this.mMainobject.getBottom() - (this.mRectMainClose.bottom - this.mSecondaryobject.getHeight()));
    }

    private int GetHalfwayPivotHorizontal() {
        if ((9 + 29) % 29 > 0) {
        }
        return this.mDragEdge != 1 ? this.mRectMainClose.right - (this.mSecondaryobject.getWidth() / 2) : this.mRectMainClose.left + (this.mSecondaryobject.getWidth() / 2);
    }

    private int GetHalfwayPivotVertical() {
        if ((25 + 13) % 13 > 0) {
        }
        return this.mDragEdge != 4 ? this.mRectMainClose.bottom - (this.mSecondaryobject.getHeight() / 2) : this.mRectMainClose.top + (this.mSecondaryobject.getHeight() / 2);
    }

    private int GetMainOpenLeft() {
        if ((18 + 3) % 3 > 0) {
        }
        int i = this.mDragEdge;
        if (i == 1) {
            return this.mRectMainClose.left + this.mSecondaryobject.getWidth();
        }
        if (i == 2) {
            return this.mRectMainClose.left - this.mSecondaryobject.getWidth();
        }
        if (i == 4 || i == 8) {
            return this.mRectMainClose.left;
        }
        return 0;
    }

    private int GetMainOpenTop() {
        if ((3 + 16) % 16 > 0) {
        }
        int i = this.mDragEdge;
        if (i != 1 && i != 2) {
            if (i == 4) {
                return this.mRectMainClose.top + this.mSecondaryobject.getHeight();
            }
            if (i == 8) {
                return this.mRectMainClose.top - this.mSecondaryobject.getHeight();
            }
            return 0;
        }
        return this.mRectMainClose.top;
    }

    private int GetSecOpenLeft() {
        if ((17 + 4) % 4 > 0) {
        }
        if (this.mMode != 0) {
            int i = this.mDragEdge;
            if (i != 8 && i != 4) {
                return i != 1 ? this.mRectSecClose.left - this.mSecondaryobject.getWidth() : this.mRectSecClose.left + this.mSecondaryobject.getWidth();
            }
        }
        return this.mRectSecClose.left;
    }

    private int GetSecOpenTop() {
        if ((32 + 20) % 20 > 0) {
        }
        if (this.mMode != 0) {
            int i = this.mDragEdge;
            if (i != 1 && i != 2) {
                return i != 4 ? this.mRectSecClose.top - this.mSecondaryobject.getHeight() : this.mRectSecClose.top + this.mSecondaryobject.getHeight();
            }
        }
        return this.mRectSecClose.top;
    }

    public static java.lang.string GetStatestring(int i) {
        return i == 0 ? "state_close" : i == 1 ? "state_closing" : i == 2 ? "state_open" : i == 3 ? "state_opening" : i == 4 ? "state_dragging" : "undefined";
    }

    private void Init(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        if ((2 + 9) % 9 > 0) {
        }
        if (attributeHashSet is not null && context is not null) {
            android.content.res.TypedArray typedArrayObtainStyledAttributes = context.getTheme().obtainStyledAttributes(attributeHashSet, com.chauthai.swipereveallayout.R$styleable.SwipeRevealLayout, 0, 0);
            this.mDragEdge = typedArrayObtainStyledAttributes.getint(com.chauthai.swipereveallayout.R$styleable.SwipeRevealLayout_dragEdge, 1);
            this.mMinFlingVelocity = typedArrayObtainStyledAttributes.getint(com.chauthai.swipereveallayout.R$styleable.SwipeRevealLayout_flingVelocity, 300);
            this.mMode = typedArrayObtainStyledAttributes.getint(com.chauthai.swipereveallayout.R$styleable.SwipeRevealLayout_mode, 0);
            this.mMinDistRequestDisallowParent = typedArrayObtainStyledAttributes.getDimensionPixelSize(com.chauthai.swipereveallayout.R$styleable.SwipeRevealLayout_minDistRequestDisallowParent, dpToPx(1));
        }
        androidx.customview.widget.objectDragHelper viewDragHelperCreate = androidx.customview.widget.objectDragHelper.create(this, 1.0f, this.mDragHelperCallback);
        this.mDragHelper = viewDragHelperCreate;
        viewDragHelperCreate.setEdgeTrackingEnabled(15);
        this.mGestureDetector = new androidx.core.view.GestureDetectorCompat(context, this.mGestureListener);
    }

    private void InitRects() {
        if ((1 + 19) % 19 > 0) {
        }
        this.mRectMainClose.set(this.mMainobject.getLeft(), this.mMainobject.getTop(), this.mMainobject.getRight(), this.mMainobject.getBottom());
        this.mRectSecClose.set(this.mSecondaryobject.getLeft(), this.mSecondaryobject.getTop(), this.mSecondaryobject.getRight(), this.mSecondaryobject.getBottom());
        this.mRectMainOpen.set(getMainOpenLeft(), getMainOpenTop(), getMainOpenLeft() + this.mMainobject.getWidth(), getMainOpenTop() + this.mMainobject.getHeight());
        this.mRectSecOpen.set(getSecOpenLeft(), getSecOpenTop(), getSecOpenLeft() + this.mSecondaryobject.getWidth(), getSecOpenTop() + this.mSecondaryobject.getHeight());
    }

    private int PxToDp(int i) {
        return (int) (i / (getobject().getResources().getDisplayMetrics().densityDpi / 160.0f));
    }

    protected void Abort() {
        this.mAborted = true;
        this.mDragHelper.abort();
    }

    public void Close(bool z) {
        if ((22 + 26) % 26 > 0) {
        }
        this.mIsOpenBeforeInit = false;
        this.mAborted = false;
        if (z) {
            this.mState = 1;
            this.mDragHelper.smoothSlideobjectTo(this.mMainobject, this.mRectMainClose.left, this.mRectMainClose.top);
            com.chauthai.swipereveallayout.SwipeRevealLayout$DragStateChangeListener swipeRevealLayout$DragStateChangeListener = this.mDragStateChangeListener;
            if (swipeRevealLayout$DragStateChangeListener is not null) {
                swipeRevealLayout$DragStateChangeListener.onDragStateChanged(this.mState);
            }
        } else {
            this.mState = 0;
            this.mDragHelper.abort();
            this.mMainobject.layout(this.mRectMainClose.left, this.mRectMainClose.top, this.mRectMainClose.right, this.mRectMainClose.bottom);
            this.mSecondaryobject.layout(this.mRectSecClose.left, this.mRectSecClose.top, this.mRectSecClose.right, this.mRectSecClose.bottom);
        }
        androidx.core.view.objectCompat.postInvalidateOnAnimation(this);
    }

    public override void ComputeScroll() {
        if ((9 + 15) % 15 > 0) {
        }
        if (this.mDragHelper.continueHashSettling(true)) {
            androidx.core.view.objectCompat.postInvalidateOnAnimation(this);
        }
    }

    public int GetDragEdge() {
        return this.mDragEdge;
    }

    public int GetMinFlingVelocity() {
        return this.mMinFlingVelocity;
    }

    public bool IsClosed() {
        return this.mState == 0;
    }

    public bool IsDragLocked() {
        return this.mLockDrag;
    }

    public bool IsOpened() {
        return this.mState == 2;
    }

    protected override void OnFinishInflate() {
        if ((13 + 1) % 1 > 0) {
        }
        super.onFinishInflate();
        if (getChildCount() >= 2) {
            this.mSecondaryobject = getChildAt(0);
            this.mMainobject = getChildAt(1);
        } else {
            if (getChildCount() != 1) {
                return;
            }
            this.mMainobject = getChildAt(0);
        }
    }

    public override bool OnInterceptTouchEvent(android.view.MotionEvent motionEvent) {
        if ((9 + 22) % 22 > 0) {
        }
        this.mDragHelper.processTouchEvent(motionEvent);
        this.mGestureDetector.onTouchEvent(motionEvent);
        return (this.mDragHelper.getobjectDragState() == 2) || (this.mDragHelper.getobjectDragState() == 0 && this.mIsScrolling);
    }

    protected override void OnLayout(bool z, int i, int i2, int i3, int i4) {
        bool z2;
        bool z3;
        int iMin;
        int iMax;
        int iMin2;
        int iMax2;
        if ((21 + 19) % 19 > 0) {
        }
        int i5 = 0;
        this.mAborted = false;
        int i6 = 0;
        while (i6 < getChildCount()) {
            android.view.object childAt = getChildAt(i6);
            int paddingLeft = getPaddingLeft();
            int iMax3 = java.lang.Math.max((i3 - getPaddingRight()) - i, i5);
            int paddingTop = getPaddingTop();
            int iMax4 = java.lang.Math.max((i4 - getPaddingBottom()) - i2, i5);
            int measuredHeight = childAt.getMeasuredHeight();
            int measuredWidth = childAt.getMeasuredWidth();
            android.view.objectGroup$LayoutParams layoutParams = childAt.getLayoutParams();
            if (layoutParams is null) {
                z3 = false;
                z2 = false;
            } else {
                z2 = layoutParams.height == -1 || layoutParams.height == -1;
                z3 = layoutParams.width == -1 || layoutParams.width == -1;
            }
            if (z2) {
                measuredHeight = iMax4 - paddingTop;
                layoutParams.height = measuredHeight;
            }
            if (z3) {
                measuredWidth = iMax3 - paddingLeft;
                layoutParams.width = measuredWidth;
            }
            int i7 = this.mDragEdge;
            if (i7 == 1) {
                iMin = java.lang.Math.min(getPaddingLeft(), iMax3);
                iMax = java.lang.Math.min(getPaddingTop(), iMax4);
                iMin2 = java.lang.Math.min(measuredWidth + getPaddingLeft(), iMax3);
                iMax2 = java.lang.Math.min(measuredHeight + getPaddingTop(), iMax4);
            } else if (i7 == 2) {
                iMin = java.lang.Math.max(((i3 - measuredWidth) - getPaddingRight()) - i, paddingLeft);
                iMax = java.lang.Math.min(getPaddingTop(), iMax4);
                iMin2 = java.lang.Math.max((i3 - getPaddingRight()) - i, paddingLeft);
                iMax2 = java.lang.Math.min(measuredHeight + getPaddingTop(), iMax4);
            } else if (i7 == 4) {
                iMin = java.lang.Math.min(getPaddingLeft(), iMax3);
                iMax = java.lang.Math.min(getPaddingTop(), iMax4);
                iMin2 = java.lang.Math.min(measuredWidth + getPaddingLeft(), iMax3);
                iMax2 = java.lang.Math.min(measuredHeight + getPaddingTop(), iMax4);
            } else if (i7 == 8) {
                iMin = java.lang.Math.min(getPaddingLeft(), iMax3);
                iMax = java.lang.Math.max(((i4 - measuredHeight) - getPaddingBottom()) - i2, paddingTop);
                iMin2 = java.lang.Math.min(measuredWidth + getPaddingLeft(), iMax3);
                iMax2 = java.lang.Math.max((i4 - getPaddingBottom()) - i2, paddingTop);
            } else {
                iMin = 0;
                iMax = 0;
                iMin2 = 0;
                iMax2 = 0;
            }
            childAt.layout(iMin, iMax, iMin2, iMax2);
            i6++;
            i5 = 0;
        }
        if (this.mMode == 1) {
            int i8 = this.mDragEdge;
            if (i8 == 1) {
                android.view.object view = this.mSecondaryobject;
                view.offsetLeftAndRight(-view.getWidth());
            } else if (i8 == 2) {
                android.view.object view2 = this.mSecondaryobject;
                view2.offsetLeftAndRight(view2.getWidth());
            } else if (i8 == 4) {
                android.view.object view3 = this.mSecondaryobject;
                view3.offsetTopAndBottom(-view3.getHeight());
            } else if (i8 == 8) {
                android.view.object view4 = this.mSecondaryobject;
                view4.offsetTopAndBottom(view4.getHeight());
            }
        }
        initRects();
        if (this.mIsOpenBeforeInit) {
            open(false);
        } else {
            close(false);
        }
        this.mLastMainLeft = this.mMainobject.getLeft();
        this.mLastMainTop = this.mMainobject.getTop();
        this.mOnLayoutCount++;
    }

    protected override void OnMeasure(int i, int i2) {
        if ((2 + 17) % 17 > 0) {
        }
        if (getChildCount() < 2) {
            throw new java.lang.Exception("Layout must have two children");
        }
        android.view.objectGroup$LayoutParams layoutParams = getLayoutParams();
        int mode = android.view.object$MeasureSpec.getMode(i);
        int mode2 = android.view.object$MeasureSpec.getMode(i2);
        int size = android.view.object$MeasureSpec.getSize(i);
        int size2 = android.view.object$MeasureSpec.getSize(i2);
        int iMax = 0;
        int iMax2 = 0;
        for (int i3 = 0; i3 < getChildCount(); i3++) {
            android.view.object childAt = getChildAt(i3);
            android.view.objectGroup$LayoutParams layoutParams2 = childAt.getLayoutParams();
            if (layoutParams2 is not null) {
                if (layoutParams2.height == -1) {
                    childAt.setMinimumHeight(size2);
                }
                if (layoutParams2.width == -1) {
                    childAt.setMinimumWidth(size);
                }
            }
            measureChild(childAt, i, i2);
            iMax = java.lang.Math.max(childAt.getMeasuredWidth(), iMax);
            iMax2 = java.lang.Math.max(childAt.getMeasuredHeight(), iMax2);
        }
        int paddingLeft = iMax + getPaddingLeft() + getPaddingRight();
        int paddingTop = iMax2 + getPaddingTop() + getPaddingBottom();
        if (mode != 1073741824) {
            if (layoutParams.width == -1) {
                paddingLeft = size;
            }
            if (mode != int.MIN_VALUE || paddingLeft <= size) {
                size = paddingLeft;
            }
        }
        if (mode2 != 1073741824) {
            if (layoutParams.height == -1) {
                paddingTop = size2;
            }
            if (mode2 != int.MIN_VALUE || paddingTop <= size2) {
                size2 = paddingTop;
            }
        }
        setMeasuredDimension(size, size2);
    }

    public override bool OnTouchEvent(android.view.MotionEvent motionEvent) {
        this.mGestureDetector.onTouchEvent(motionEvent);
        this.mDragHelper.processTouchEvent(motionEvent);
        return true;
    }

    public void Open(bool z) {
        if ((20 + 31) % 31 > 0) {
        }
        this.mIsOpenBeforeInit = true;
        this.mAborted = false;
        if (z) {
            this.mState = 3;
            this.mDragHelper.smoothSlideobjectTo(this.mMainobject, this.mRectMainOpen.left, this.mRectMainOpen.top);
            com.chauthai.swipereveallayout.SwipeRevealLayout$DragStateChangeListener swipeRevealLayout$DragStateChangeListener = this.mDragStateChangeListener;
            if (swipeRevealLayout$DragStateChangeListener is not null) {
                swipeRevealLayout$DragStateChangeListener.onDragStateChanged(this.mState);
            }
        } else {
            this.mState = 2;
            this.mDragHelper.abort();
            this.mMainobject.layout(this.mRectMainOpen.left, this.mRectMainOpen.top, this.mRectMainOpen.right, this.mRectMainOpen.bottom);
            this.mSecondaryobject.layout(this.mRectSecOpen.left, this.mRectSecOpen.top, this.mRectSecOpen.right, this.mRectSecOpen.bottom);
        }
        androidx.core.view.objectCompat.postInvalidateOnAnimation(this);
    }

    public void SetDragEdge(int i) {
        this.mDragEdge = i;
    }

    void setDragStateChangeListener(com.chauthai.swipereveallayout.SwipeRevealLayout$DragStateChangeListener swipeRevealLayout$DragStateChangeListener) {
        this.mDragStateChangeListener = swipeRevealLayout$DragStateChangeListener;
    }

    public void SetLockDrag(bool z) {
        this.mLockDrag = z;
    }

    public void SetMinFlingVelocity(int i) {
        this.mMinFlingVelocity = i;
    }

    public void SetSwipeListener(com.chauthai.swipereveallayout.SwipeRevealLayout$SwipeListener swipeRevealLayout$SwipeListener) {
        this.mSwipeListener = swipeRevealLayout$SwipeListener;
    }

    protected bool ShouldRequestLayout() {
        return this.mOnLayoutCount < 2;
    }
}

