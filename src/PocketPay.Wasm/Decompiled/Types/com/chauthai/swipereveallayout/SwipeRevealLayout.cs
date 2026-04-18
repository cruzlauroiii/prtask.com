namespace WillowMaze.Wasm.Decompiled;

public class SwipeRevealLayout : ViewGroup
{
    private static int DEFAULT_MIN_DIST_REQUEST_DISALLOW_PARENT;
    private static int DEFAULT_MIN_FLING_VELOCITY;
    public static int DRAG_EDGE_BOTTOM;
    public static int DRAG_EDGE_LEFT;
    public static int DRAG_EDGE_RIGHT;
    public static int DRAG_EDGE_TOP;
    public static int MODE_NORMAL;
    public static int MODE_SAME_LEVEL;
    private static int STATE_CLOSE;
    private static int STATE_CLOSING;
    private static int STATE_DRAGGING;
    private static int STATE_OPEN;
    private static int STATE_OPENING;
    private bool MAborted;
    private int MDragEdge;
    private ViewDragHelper MDragHelper;
    private readonly ViewDragHelper$Callback MDragHelperCallback;
    private SwipeRevealLayout$DragStateChangeListener MDragStateChangeListener;
    private GestureDetectorCompat MGestureDetector;
    private readonly GestureDetector$OnGestureListener MGestureListener;
    private bool MIsOpenBeforeInit;
    private bool MIsScrolling;
    private int MLastMainLeft;
    private int MLastMainTop;
    private bool MLockDrag;
    private object MMainView;
    private int MMinDistRequestDisallowParent;
    private int MMinFlingVelocity;
    private int MMode;
    private int MOnLayoutCount;
    private Rect MRectMainClose;
    private Rect MRectMainOpen;
    private Rect MRectSecClose;
    private Rect MRectSecOpen;
    private object MSecondaryView;
    private int MState;
    private SwipeRevealLayout$SwipeListener MSwipeListener;

    private static bool Access$002(SwipeRevealLayout P0, bool P1)
    {
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mIsScrolling
        return false;
    }

    private static int Access$100(SwipeRevealLayout P0)
    {
        // call: SwipeRevealLayout.getDistToClosestEdge
        return 0;
    }

    private static int Access$1000(SwipeRevealLayout P0, int P1)
    {
        // call: SwipeRevealLayout.pxToDp
        return 0;
    }

    private static int Access$1100(SwipeRevealLayout P0)
    {
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mMinFlingVelocity
        return 0;
    }

    private static int Access$1200(SwipeRevealLayout P0)
    {
        // call: SwipeRevealLayout.getHalfwayPivotHorizontal
        return 0;
    }

    private static int Access$1300(SwipeRevealLayout P0)
    {
        // call: SwipeRevealLayout.getHalfwayPivotVertical
        return 0;
    }

    private static int Access$1400(SwipeRevealLayout P0)
    {
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mMode
        return 0;
    }

    private static int Access$1500(SwipeRevealLayout P0)
    {
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mLastMainLeft
        return 0;
    }

    private static int Access$1502(SwipeRevealLayout P0, int P1)
    {
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mLastMainLeft
        return 0;
    }

    private static int Access$1600(SwipeRevealLayout P0)
    {
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mLastMainTop
        return 0;
    }

    private static int Access$1602(SwipeRevealLayout P0, int P1)
    {
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mLastMainTop
        return 0;
    }

    private static SwipeRevealLayout$SwipeListener Access$1700(SwipeRevealLayout P0)
    {
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mSwipeListener
        return default!;
    }

    private static Rect Access$1800(SwipeRevealLayout P0)
    {
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mRectMainOpen
        return default!;
    }

    private static int Access$1900(SwipeRevealLayout P0)
    {
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mState
        return 0;
    }

    private static int Access$1902(SwipeRevealLayout P0, int P1)
    {
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mState
        return 0;
    }

    private static int Access$200(SwipeRevealLayout P0)
    {
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mMinDistRequestDisallowParent
        return 0;
    }

    private static SwipeRevealLayout$DragStateChangeListener Access$2000(SwipeRevealLayout P0)
    {
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mDragStateChangeListener
        return default!;
    }

    private static bool Access$300(SwipeRevealLayout P0)
    {
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mAborted
        return false;
    }

    private static bool Access$302(SwipeRevealLayout P0, bool P1)
    {
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mAborted
        return false;
    }

    private static bool Access$400(SwipeRevealLayout P0)
    {
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mLockDrag
        return false;
    }

    private static object Access$500(SwipeRevealLayout P0)
    {
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mMainView
        return default!;
    }

    private static ViewDragHelper Access$600(SwipeRevealLayout P0)
    {
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mDragHelper
        return default!;
    }

    private static int Access$700(SwipeRevealLayout P0)
    {
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mDragEdge
        return 0;
    }

    private static Rect Access$800(SwipeRevealLayout P0)
    {
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mRectMainClose
        return default!;
    }

    private static object Access$900(SwipeRevealLayout P0)
    {
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mSecondaryView
        return default!;
    }

    private int DpToPx(int P0)
    {
        // call: SwipeRevealLayout.getContext
        // call: Resources.getDisplayMetrics
        // call: object.getResources
        // field: android.util.DisplayMetrics.densityDpi
        return 0;
    }

    private int GetDistToClosestEdge()
    {
        // call: object.getWidth
        // call: object.getBottom
        // call: Math.min
        // call: object.getRight
        // call: object.getLeft
        // call: object.getTop
        // call: object.getHeight
        // field: android.graphics.Rect.left
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mRectMainClose
        // field: android.graphics.Rect.bottom
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mMainView
        // field: android.graphics.Rect.right
        // field: android.graphics.Rect.top
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mDragEdge
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mSecondaryView
        return 0;
    }

    private int GetHalfwayPivotHorizontal()
    {
        // call: object.getWidth
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mDragEdge
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mSecondaryView
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mRectMainClose
        // field: android.graphics.Rect.right
        // field: android.graphics.Rect.left
        return 0;
    }

    private int GetHalfwayPivotVertical()
    {
        // call: object.getHeight
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mRectMainClose
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mDragEdge
        // field: android.graphics.Rect.bottom
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mSecondaryView
        // field: android.graphics.Rect.top
        return 0;
    }

    private int GetMainOpenLeft()
    {
        // call: object.getWidth
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mRectMainClose
        // field: android.graphics.Rect.left
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mSecondaryView
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mDragEdge
        return 0;
    }

    private int GetMainOpenTop()
    {
        // call: object.getHeight
        // field: android.graphics.Rect.top
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mSecondaryView
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mRectMainClose
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mDragEdge
        return 0;
    }

    private int GetSecOpenLeft()
    {
        // call: object.getWidth
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mRectSecClose
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mMode
        // field: android.graphics.Rect.left
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mDragEdge
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mSecondaryView
        return 0;
    }

    private int GetSecOpenTop()
    {
        // call: object.getHeight
        // field: android.graphics.Rect.top
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mDragEdge
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mMode
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mRectSecClose
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mSecondaryView
        return 0;
    }

    public static string GetStateString(int P0)
    {
        // str: "state_dragging"
        // str: "state_open"
        // str: "state_close"
        // str: "state_opening"
        // str: "undefined"
        // str: "state_closing"
        return string.Empty;
    }

    private void Init(object P0, AttributeSet P1)
    {
        // call: ViewDragHelper.setEdgeTrackingEnabled
        // call: Resources$Theme.obtainStyledAttributes
        // call: ViewDragHelper.create
        // call: TypedArray.getInteger
        // call: GestureDetectorCompat.<init>
        // call: TypedArray.getDimensionPixelSize
        // call: object.getTheme
        // call: SwipeRevealLayout.dpToPx
        // field: com.chauthai.swipereveallayout.R$styleable.SwipeRevealLayout_dragEdge
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mDragEdge
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mGestureDetector
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mMode
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mMinDistRequestDisallowParent
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mDragHelperCallback
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mMinFlingVelocity
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mGestureListener
        // field: com.chauthai.swipereveallayout.R$styleable.SwipeRevealLayout_minDistRequestDisallowParent
        // field: com.chauthai.swipereveallayout.R$styleable.SwipeRevealLayout
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mDragHelper
        // field: com.chauthai.swipereveallayout.R$styleable.SwipeRevealLayout_flingVelocity
        // field: com.chauthai.swipereveallayout.R$styleable.SwipeRevealLayout_mode
        // type: GestureDetectorCompat
    }

    private void InitRects()
    {
        // call: object.getHeight
        // call: Rect.set
        // call: object.getRight
        // call: SwipeRevealLayout.getMainOpenLeft
        // call: object.getLeft
        // call: object.getTop
        // call: object.getBottom
        // call: SwipeRevealLayout.getSecOpenTop
        // call: SwipeRevealLayout.getMainOpenTop
        // call: SwipeRevealLayout.getSecOpenLeft
        // call: object.getWidth
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mSecondaryView
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mMainView
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mRectMainClose
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mRectSecOpen
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mRectSecClose
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mRectMainOpen
    }

    private int PxToDp(int P0)
    {
        // call: Resources.getDisplayMetrics
        // call: object.getResources
        // call: SwipeRevealLayout.getContext
        // field: android.util.DisplayMetrics.densityDpi
        return 0;
    }

    private void Abort()
    {
        // call: ViewDragHelper.abort
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mDragHelper
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mAborted
    }

    public void Close(bool P0)
    {
        // call: SwipeRevealLayout$DragStateChangeListener.onDragStateChanged
        // call: ViewDragHelper.abort
        // call: object.layout
        // call: ViewDragHelper.smoothSlideViewTo
        // call: ViewCompat.postInvalidateOnAnimation
        // field: android.graphics.Rect.right
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mState
        // field: android.graphics.Rect.bottom
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mIsOpenBeforeInit
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mRectSecClose
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mMainView
        // field: android.graphics.Rect.left
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mRectMainClose
        // field: android.graphics.Rect.top
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mAborted
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mDragStateChangeListener
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mDragHelper
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mSecondaryView
    }

    public void ComputeScroll()
    {
        // call: ViewDragHelper.continueSettling
        // call: ViewCompat.postInvalidateOnAnimation
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mDragHelper
    }

    public int GetDragEdge()
    {
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mDragEdge
        return 0;
    }

    public int GetMinFlingVelocity()
    {
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mMinFlingVelocity
        return 0;
    }

    public bool IsClosed()
    {
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mState
        return false;
    }

    public bool IsDragLocked()
    {
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mLockDrag
        return false;
    }

    public bool IsOpened()
    {
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mState
        return false;
    }

    private void OnFinishInflate()
    {
        // call: SwipeRevealLayout.getChildAt
        // call: SwipeRevealLayout.getChildCount
        // call: ViewGroup.onFinishInflate
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mMainView
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mSecondaryView
    }

    public bool OnInterceptTouchEvent(MotionEvent P0)
    {
        // call: ViewDragHelper.getViewDragState
        // call: ViewDragHelper.processTouchEvent
        // call: GestureDetectorCompat.onTouchEvent
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mDragHelper
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mGestureDetector
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mIsScrolling
        return false;
    }

    private void OnLayout(bool P0, int P1, int P2, int P3, int P4)
    {
        // call: SwipeRevealLayout.getPaddingTop
        // call: SwipeRevealLayout.getPaddingLeft
        // call: Math.max
        // call: object.offsetLeftAndRight
        // call: Math.min
        // call: object.getLayoutParams
        // call: SwipeRevealLayout.getPaddingBottom
        // call: object.getMeasuredHeight
        // call: object.getWidth
        // call: object.getHeight
        // call: SwipeRevealLayout.getPaddingRight
        // call: object.getTop
        // call: object.offsetTopAndBottom
        // call: object.getMeasuredWidth
        // call: object.layout
        // call: SwipeRevealLayout.getChildCount
        // call: SwipeRevealLayout.initRects
        // call: object.getLeft
        // call: SwipeRevealLayout.getChildAt
        // call: SwipeRevealLayout.open
        // field: android.view.ViewGroup$LayoutParams.height
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mDragEdge
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mMode
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mOnLayoutCount
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mMainView
        // field: android.view.ViewGroup$LayoutParams.width
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mSecondaryView
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mAborted
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mIsOpenBeforeInit
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mLastMainLeft
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mLastMainTop
    }

    private void OnMeasure(int P0, int P1)
    {
        // str: "Layout must have two children"
        // call: SwipeRevealLayout.getPaddingTop
        // call: Math.max
        // call: SwipeRevealLayout.measureChild
        // call: SwipeRevealLayout.getLayoutParams
        // call: SwipeRevealLayout.getPaddingBottom
        // call: object.getMeasuredWidth
        // call: SwipeRevealLayout.getChildCount
        // call: SwipeRevealLayout.getChildAt
        // call: object.setMinimumHeight
        // call: View$MeasureSpec.getMode
        // call: object.getLayoutParams
        // call: object.getMeasuredHeight
        // call: View$MeasureSpec.getSize
        // call: SwipeRevealLayout.getPaddingRight
        // call: SwipeRevealLayout.getPaddingLeft
        // call: SwipeRevealLayout.setMeasuredDimension
        // call: object.setMinimumWidth
        // call: Exception.<init>
        // field: android.view.ViewGroup$LayoutParams.width
        // field: android.view.ViewGroup$LayoutParams.height
        // type: Exception
    }

    public bool OnTouchEvent(MotionEvent P0)
    {
        // call: ViewDragHelper.processTouchEvent
        // call: GestureDetectorCompat.onTouchEvent
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mGestureDetector
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mDragHelper
        return false;
    }

    public void Open(bool P0)
    {
        // call: ViewDragHelper.abort
        // call: object.layout
        // call: SwipeRevealLayout$DragStateChangeListener.onDragStateChanged
        // call: ViewCompat.postInvalidateOnAnimation
        // call: ViewDragHelper.smoothSlideViewTo
        // field: android.graphics.Rect.left
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mDragHelper
        // field: android.graphics.Rect.top
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mRectMainOpen
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mAborted
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mRectSecOpen
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mIsOpenBeforeInit
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mDragStateChangeListener
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mState
        // field: android.graphics.Rect.bottom
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mMainView
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mSecondaryView
        // field: android.graphics.Rect.right
    }

    public void SetDragEdge(int P0)
    {
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mDragEdge
    }

    private void SetDragStateChangeListener(SwipeRevealLayout$DragStateChangeListener P0)
    {
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mDragStateChangeListener
    }

    public void SetLockDrag(bool P0)
    {
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mLockDrag
    }

    public void SetMinFlingVelocity(int P0)
    {
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mMinFlingVelocity
    }

    public void SetSwipeListener(SwipeRevealLayout$SwipeListener P0)
    {
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mSwipeListener
    }

    private bool ShouldRequestLayout()
    {
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout.mOnLayoutCount
        return false;
    }

}
