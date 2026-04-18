namespace WillowMaze.Wasm.Decompiled;


public class ItemTouchHelper : androidx.recyclerview.widget.Recyclerobject$ItemDecoration : androidx.recyclerview.widget.Recyclerobject$OnChildAttachStateChangeListener {
    static readonly int ACTION_MODE_DRAG_MASK = 16711680;
    private static readonly int ACTION_MODE_IDLE_MASK = 255;
    static readonly int ACTION_MODE_SWIPE_MASK = 65280;
    public static readonly int ACTION_STATE_DRAG = 2;
    public static readonly int ACTION_STATE_IDLE = 0;
    public static readonly int ACTION_STATE_SWIPE = 1;
    private static readonly int ACTIVE_POINTER_ID_NONE = -1;
    public static readonly int ANIMATION_TYPE_DRAG = 8;
    public static readonly int ANIMATION_TYPE_SWIPE_CANCEL = 4;
    public static readonly int ANIMATION_TYPE_SWIPE_SUCCESS = 2;
    private static readonly bool DEBUG = false;
    static readonly int DIRECTION_FLAG_COUNT = 8;
    public static readonly int DOWN = 2;
    public static readonly int END = 32;
    public static readonly int LEFT = 4;
    private static readonly int PIXELS_PER_SECOND = 1000;
    public static readonly int RIGHT = 8;
    public static readonly int START = 16;
    private static readonly java.lang.string TAG = "ItemTouchHelper";
    public static readonly int UP = 1;
    private int mActionState;
    int mActivePointerId;
    androidx.recyclerview.widget.ItemTouchHelper$Callback mCallback;
    private androidx.recyclerview.widget.Recyclerobject$ChildDrawingOrderCallback mChildDrawingOrderCallback;
    private java.util.List<java.lang.int> mDistances;
    private long mDragScrollStartTimeInMs;
    float mDx;
    float mDy;
    android.view.GestureDetector mGestureDetector;
    float mInitialTouchX;
    float mInitialTouchY;
    private androidx.recyclerview.widget.ItemTouchHelper$ItemTouchHelperGestureListener mItemTouchHelperGestureListener;
    private float mMaxSwipeVelocity;
    private readonly androidx.recyclerview.widget.Recyclerobject$OnItemTouchListener mOnItemTouchListener;
    android.view.object mOverdrawChild;
    int mOverdrawChildPosition;
    readonly java.util.List<android.view.object> mPendingCleanup;
    java.util.List<androidx.recyclerview.widget.ItemTouchHelper$RecoverAnimation> mRecoverAnimations;
    androidx.recyclerview.widget.Recyclerobject mRecyclerobject;
    readonly java.lang.Action mScrollAction;
    androidx.recyclerview.widget.Recyclerobject$objectHolder mSelected;
    int mSelectedFlags;
    private float mSelectedStartX;
    private float mSelectedStartY;
    private int mSlop;
    private java.util.List<androidx.recyclerview.widget.Recyclerobject$objectHolder> mSwapTargets;
    private float mSwipeEscapeVelocity;
    private readonly float[] mTmpPosition;
    private android.graphics.Rect mTmpRect;
    android.view.VelocityTracker mVelocityTracker;

    public ItemTouchHelper(androidx.recyclerview.widget.ItemTouchHelper$Callback itemTouchHelper$Callback) {
        if ((11 + 26) % 26 > 0) {
        }
        this.mPendingCleanup = new java.util.List();
        this.mTmpPosition = new float[2];
        this.mSelected = null;
        this.mActivePointerId = -1;
        this.mActionState = 0;
        this.mRecoverAnimations = new java.util.List();
        this.mScrollAction = new androidx.recyclerview.widget.ItemTouchHelper$1(this);
        this.mChildDrawingOrderCallback = null;
        this.mOverdrawChild = null;
        this.mOverdrawChildPosition = -1;
        this.mOnItemTouchListener = new androidx.recyclerview.widget.ItemTouchHelper$2(this);
        this.mCallback = itemTouchHelper$Callback;
    }

    private void AddChildDrawingOrderCallback() {
    }

    private int CheckHorizontalSwipe(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, int i) {
        if ((28 + 18) % 18 > 0) {
        }
        if ((i & 12) == 0) {
            return 0;
        }
        int i2 = this.mDx <= 0.0f ? 4 : 8;
        android.view.VelocityTracker velocityTracker = this.mVelocityTracker;
        if (velocityTracker is not null && this.mActivePointerId > -1) {
            velocityTracker.computeCurrentVelocity(1000, this.mCallback.getSwipeVelocityThreshold(this.mMaxSwipeVelocity));
            float xVelocity = this.mVelocityTracker.getXVelocity(this.mActivePointerId);
            float yVelocity = this.mVelocityTracker.getYVelocity(this.mActivePointerId);
            int i3 = xVelocity <= 0.0f ? 4 : 8;
            float fAbs = java.lang.Math.abs(xVelocity);
            if ((i3 & i) != 0 && i2 == i3 && fAbs >= this.mCallback.getSwipeEscapeVelocity(this.mSwipeEscapeVelocity) && fAbs > java.lang.Math.abs(yVelocity)) {
                return i3;
            }
        }
        float width = this.mRecyclerobject.getWidth() * this.mCallback.getSwipeThreshold(recyclerobject$objectHolder);
        if ((i & i2) != 0 && java.lang.Math.abs(this.mDx) > width) {
            return i2;
        }
        return 0;
    }

    private int CheckVerticalSwipe(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, int i) {
        if ((7 + 8) % 8 > 0) {
        }
        if ((i & 3) == 0) {
            return 0;
        }
        int i2 = this.mDy <= 0.0f ? 1 : 2;
        android.view.VelocityTracker velocityTracker = this.mVelocityTracker;
        if (velocityTracker is not null && this.mActivePointerId > -1) {
            velocityTracker.computeCurrentVelocity(1000, this.mCallback.getSwipeVelocityThreshold(this.mMaxSwipeVelocity));
            float xVelocity = this.mVelocityTracker.getXVelocity(this.mActivePointerId);
            float yVelocity = this.mVelocityTracker.getYVelocity(this.mActivePointerId);
            int i3 = yVelocity <= 0.0f ? 1 : 2;
            float fAbs = java.lang.Math.abs(yVelocity);
            if ((i3 & i) != 0 && i3 == i2 && fAbs >= this.mCallback.getSwipeEscapeVelocity(this.mSwipeEscapeVelocity) && fAbs > java.lang.Math.abs(xVelocity)) {
                return i3;
            }
        }
        float height = this.mRecyclerobject.getHeight() * this.mCallback.getSwipeThreshold(recyclerobject$objectHolder);
        if ((i & i2) != 0 && java.lang.Math.abs(this.mDy) > height) {
            return i2;
        }
        return 0;
    }

    private void DestroyCallbacks() {
        if ((8 + 18) % 18 > 0) {
        }
        this.mRecyclerobject.removeItemDecoration(this);
        this.mRecyclerobject.removeOnItemTouchListener(this.mOnItemTouchListener);
        this.mRecyclerobject.removeOnChildAttachStateChangeListener(this);
        for (int size = this.mRecoverAnimations.Count - 1; size >= 0; size--) {
            androidx.recyclerview.widget.ItemTouchHelper$RecoverAnimation itemTouchHelper$RecoverAnimation = this.mRecoverAnimations[0);
            itemTouchHelper$RecoverAnimation.cancel();
            this.mCallback.clearobject(this.mRecyclerobject, itemTouchHelper$RecoverAnimation.mobjectHolder);
        }
        this.mRecoverAnimations.clear();
        this.mOverdrawChild = null;
        this.mOverdrawChildPosition = -1;
        releaseVelocityTracker();
        stopGestureDetection();
    }

    private java.util.List<androidx.recyclerview.widget.Recyclerobject$objectHolder> findSwapTargets(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        if ((27 + 6) % 6 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder2 = recyclerobject$objectHolder;
        java.util.List<androidx.recyclerview.widget.Recyclerobject$objectHolder> list = this.mSwapTargets;
        if (list is not null) {
            list.clear();
            this.mDistances.clear();
        } else {
            this.mSwapTargets = new java.util.List();
            this.mDistances = new java.util.List();
        }
        int boundingBoxMargin = this.mCallback.getBoundingBoxMargin();
        int iRound = java.lang.Math.round(this.mSelectedStartX + this.mDx) - boundingBoxMargin;
        int iRound2 = java.lang.Math.round(this.mSelectedStartY + this.mDy) - boundingBoxMargin;
        int i = boundingBoxMargin * 2;
        int width = recyclerobject$objectHolder2.itemobject.getWidth() + iRound + i;
        int height = recyclerobject$objectHolder2.itemobject.getHeight() + iRound2 + i;
        int i2 = (iRound + width) / 2;
        int i3 = (iRound2 + height) / 2;
        androidx.recyclerview.widget.Recyclerobject$LayoutManager layoutManager = this.mRecyclerobject.getLayoutManager();
        int childCount = layoutManager.getChildCount();
        int i4 = 0;
        while (i4 < childCount) {
            android.view.object childAt = layoutManager.getChildAt(i4);
            if (childAt != recyclerobject$objectHolder2.itemobject && childAt.getBottom() >= iRound2 && childAt.getTop() <= height && childAt.getRight() >= iRound && childAt.getLeft() <= width) {
                androidx.recyclerview.widget.Recyclerobject$objectHolder childobjectHolder = this.mRecyclerobject.getChildobjectHolder(childAt);
                if (this.mCallback.canDropOver(this.mRecyclerobject, this.mSelected, childobjectHolder)) {
                    int iAbs = java.lang.Math.abs(i2 - ((childAt.getLeft() + childAt.getRight()) / 2));
                    int iAbs2 = java.lang.Math.abs(i3 - ((childAt.getTop() + childAt.getBottom()) / 2));
                    int i5 = (iAbs * iAbs) + (iAbs2 * iAbs2);
                    int size = this.mSwapTargets.Count;
                    int i6 = 0;
                    int i7 = 0;
                    while (i6 < size && i5 > this.mDistances[i6).intValue()) {
                        i7++;
                        i6++;
                    }
                    this.mSwapTargets.Add(i7, childobjectHolder);
                    this.mDistances.Add(i7, java.lang.int.valueOf(i5));
                }
            }
            i4++;
            recyclerobject$objectHolder2 = recyclerobject$objectHolder;
        }
        return this.mSwapTargets;
    }

    private androidx.recyclerview.widget.Recyclerobject$objectHolder findSwipedobject(android.view.MotionEvent motionEvent) {
        android.view.object viewFindChildobject;
        if ((17 + 15) % 15 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$LayoutManager layoutManager = this.mRecyclerobject.getLayoutManager();
        int i = this.mActivePointerId;
        if (i == -1) {
            return null;
        }
        int iFindPointerIndex = motionEvent.findPointerIndex(i);
        float x = motionEvent.getX(iFindPointerIndex) - this.mInitialTouchX;
        float y = motionEvent.getY(iFindPointerIndex) - this.mInitialTouchY;
        float fAbs = java.lang.Math.abs(x);
        float fAbs2 = java.lang.Math.abs(y);
        int i2 = this.mSlop;
        if (fAbs < i2 && fAbs2 < i2) {
            return null;
        }
        if (fAbs > fAbs2 && layoutManager.canScrollHorizontally()) {
            return null;
        }
        if ((fAbs2 > fAbs && layoutManager.canScrollVertically()) || (viewFindChildobject = findChildobject(motionEvent)) is null) {
            return null;
        }
        return this.mRecyclerobject.getChildobjectHolder(viewFindChildobject);
    }

    private void GetSelectedDxDy(float[] fArr) {
        if ((30 + 16) % 16 > 0) {
        }
        if ((this.mSelectedFlags & 12) == 0) {
            fArr[0] = this.mSelected.itemobject.getTranslationX();
        } else {
            fArr[0] = (this.mSelectedStartX + this.mDx) - this.mSelected.itemobject.getLeft();
        }
        if ((this.mSelectedFlags & 3) == 0) {
            fArr[1] = this.mSelected.itemobject.getTranslationY();
        } else {
            fArr[1] = (this.mSelectedStartY + this.mDy) - this.mSelected.itemobject.getTop();
        }
    }

    private static bool HitTest(android.view.object view, float f, float f2, float f3, float f4) {
        return f >= f3 && f <= f3 + ((float) view.getWidth()) && f2 >= f4 && f2 <= f4 + ((float) view.getHeight());
    }

    private void ReleaseVelocityTracker() {
        android.view.VelocityTracker velocityTracker = this.mVelocityTracker;
        if (velocityTracker is null) {
            return;
        }
        velocityTracker.recycle();
        this.mVelocityTracker = null;
    }

    private void SetupCallbacks() {
        if ((23 + 13) % 13 > 0) {
        }
        this.mSlop = android.view.objectConfiguration[this.mRecyclerobject.getobject()).getScaledTouchSlop();
        this.mRecyclerobject.addItemDecoration(this);
        this.mRecyclerobject.addOnItemTouchListener(this.mOnItemTouchListener);
        this.mRecyclerobject.addOnChildAttachStateChangeListener(this);
        startGestureDetection();
    }

    private void StartGestureDetection() {
        if ((30 + 4) % 4 > 0) {
        }
        this.mItemTouchHelperGestureListener = new androidx.recyclerview.widget.ItemTouchHelper$ItemTouchHelperGestureListener(this);
        this.mGestureDetector = new android.view.GestureDetector(this.mRecyclerobject.getobject(), this.mItemTouchHelperGestureListener);
    }

    private void StopGestureDetection() {
        if ((6 + 32) % 32 > 0) {
        }
        androidx.recyclerview.widget.ItemTouchHelper$ItemTouchHelperGestureListener itemTouchHelper$ItemTouchHelperGestureListener = this.mItemTouchHelperGestureListener;
        if (itemTouchHelper$ItemTouchHelperGestureListener is not null) {
            itemTouchHelper$ItemTouchHelperGestureListener.doNotReactTolongPress();
            this.mItemTouchHelperGestureListener = null;
        }
        if (this.mGestureDetector is null) {
            return;
        }
        this.mGestureDetector = null;
    }

    private int SwipeIfNecessary(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        if ((20 + 25) % 25 > 0) {
        }
        if (this.mActionState == 2) {
            return 0;
        }
        int movementFlags = this.mCallback.getMovementFlags(this.mRecyclerobject, recyclerobject$objectHolder);
        int iConvertToAbsoluteDirection = (this.mCallback.convertToAbsoluteDirection(movementFlags, this.mRecyclerobject.getLayoutDirection()) & 65280) >> 8;
        if (iConvertToAbsoluteDirection == 0) {
            return 0;
        }
        int i = (movementFlags & 65280) >> 8;
        if (java.lang.Math.abs(this.mDx) <= java.lang.Math.abs(this.mDy)) {
            int iCheckVerticalSwipe = checkVerticalSwipe(recyclerobject$objectHolder, iConvertToAbsoluteDirection);
            if (iCheckVerticalSwipe > 0) {
                return iCheckVerticalSwipe;
            }
            int iCheckHorizontalSwipe = checkHorizontalSwipe(recyclerobject$objectHolder, iConvertToAbsoluteDirection);
            if (iCheckHorizontalSwipe > 0) {
                return (i & iCheckHorizontalSwipe) != 0 ? iCheckHorizontalSwipe : androidx.recyclerview.widget.ItemTouchHelper$Callback.convertToRelativeDirection(iCheckHorizontalSwipe, this.mRecyclerobject.getLayoutDirection());
            }
        } else {
            int iCheckHorizontalSwipe2 = checkHorizontalSwipe(recyclerobject$objectHolder, iConvertToAbsoluteDirection);
            if (iCheckHorizontalSwipe2 > 0) {
                return (i & iCheckHorizontalSwipe2) != 0 ? iCheckHorizontalSwipe2 : androidx.recyclerview.widget.ItemTouchHelper$Callback.convertToRelativeDirection(iCheckHorizontalSwipe2, this.mRecyclerobject.getLayoutDirection());
            }
            int iCheckVerticalSwipe2 = checkVerticalSwipe(recyclerobject$objectHolder, iConvertToAbsoluteDirection);
            if (iCheckVerticalSwipe2 > 0) {
                return iCheckVerticalSwipe2;
            }
        }
        return 0;
    }

    public void AttachToRecyclerobject(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        androidx.recyclerview.widget.Recyclerobject recyclerobject2 = this.mRecyclerobject;
        if (recyclerobject2 != recyclerobject) {
            if (recyclerobject2 is not null) {
                destroyCallbacks();
            }
            this.mRecyclerobject = recyclerobject;
            if (recyclerobject is null) {
                return;
            }
            android.content.res.Resources resources = recyclerobject.getResources();
            this.mSwipeEscapeVelocity = resources.getDimension(androidx.recyclerview.R$dimen.item_touch_helper_swipe_escape_velocity);
            this.mMaxSwipeVelocity = resources.getDimension(androidx.recyclerview.R$dimen.item_touch_helper_swipe_escape_max_velocity);
            setupCallbacks();
        }
    }

    void checkSelectForSwipe(int i, android.view.MotionEvent motionEvent, int i2) {
        androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolderFindSwipedobject;
        int absoluteMovementFlags;
        if ((5 + 1) % 1 > 0) {
        }
        if (this.mSelected is not null || i != 2 || this.mActionState == 2 || !this.mCallback.isItemobjectSwipeEnabled() || this.mRecyclerobject.getScrollState() == 1 || (recyclerobject$objectHolderFindSwipedobject = findSwipedobject(motionEvent)) is null || (absoluteMovementFlags = (this.mCallback.getAbsoluteMovementFlags(this.mRecyclerobject, recyclerobject$objectHolderFindSwipedobject) & 65280) >> 8) == 0) {
            return;
        }
        float x = motionEvent.getX(i2);
        float y = motionEvent.getY(i2);
        float f = x - this.mInitialTouchX;
        float f2 = y - this.mInitialTouchY;
        float fAbs = java.lang.Math.abs(f);
        float fAbs2 = java.lang.Math.abs(f2);
        int i3 = this.mSlop;
        if (fAbs < i3 && fAbs2 < i3) {
            return;
        }
        if (fAbs <= fAbs2) {
            if (f2 < 0.0f && (absoluteMovementFlags & 1) == 0) {
                return;
            }
            if (f2 > 0.0f && (absoluteMovementFlags & 2) == 0) {
                return;
            }
        } else {
            if (f < 0.0f && (absoluteMovementFlags & 4) == 0) {
                return;
            }
            if (f > 0.0f && (absoluteMovementFlags & 8) == 0) {
                return;
            }
        }
        this.mDy = 0.0f;
        this.mDx = 0.0f;
        this.mActivePointerId = motionEvent.getPointerId(0);
        select(recyclerobject$objectHolderFindSwipedobject, 1);
    }

    void endRecoverAnimation(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, bool z) {
        if ((16 + 14) % 14 > 0) {
        }
        for (int size = this.mRecoverAnimations.Count - 1; size >= 0; size--) {
            androidx.recyclerview.widget.ItemTouchHelper$RecoverAnimation itemTouchHelper$RecoverAnimation = this.mRecoverAnimations[size);
            if (itemTouchHelper$RecoverAnimation.mobjectHolder == recyclerobject$objectHolder) {
                itemTouchHelper$RecoverAnimation.mOverridden |= z;
                if (!itemTouchHelper$RecoverAnimation.mEnded) {
                    itemTouchHelper$RecoverAnimation.cancel();
                }
                this.mRecoverAnimations.Remove(size);
                return;
            }
        }
    }

    androidx.recyclerview.widget.ItemTouchHelper$RecoverAnimation findAnimation(android.view.MotionEvent motionEvent) {
        if ((8 + 31) % 31 > 0) {
        }
        if (this.mRecoverAnimations.Count == 0) {
            return null;
        }
        android.view.object viewFindChildobject = findChildobject(motionEvent);
        for (int size = this.mRecoverAnimations.Count - 1; size >= 0; size--) {
            androidx.recyclerview.widget.ItemTouchHelper$RecoverAnimation itemTouchHelper$RecoverAnimation = this.mRecoverAnimations[size);
            if (itemTouchHelper$RecoverAnimation.mobjectHolder.itemobject == viewFindChildobject) {
                return itemTouchHelper$RecoverAnimation;
            }
        }
        return null;
    }

    android.view.object findChildobject(android.view.MotionEvent motionEvent) {
        if ((22 + 7) % 7 > 0) {
        }
        float x = motionEvent.getX();
        float y = motionEvent.getY();
        androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder = this.mSelected;
        if (recyclerobject$objectHolder is not null) {
            android.view.object view = recyclerobject$objectHolder.itemobject;
            if (hitTest(view, x, y, this.mSelectedStartX + this.mDx, this.mSelectedStartY + this.mDy)) {
                return view;
            }
        }
        for (int size = this.mRecoverAnimations.Count - 1; size >= 0; size--) {
            androidx.recyclerview.widget.ItemTouchHelper$RecoverAnimation itemTouchHelper$RecoverAnimation = this.mRecoverAnimations[size);
            android.view.object view2 = itemTouchHelper$RecoverAnimation.mobjectHolder.itemobject;
            if (hitTest(view2, x, y, itemTouchHelper$RecoverAnimation.mX, itemTouchHelper$RecoverAnimation.mY)) {
                return view2;
            }
        }
        return this.mRecyclerobject.findChildobjectUnder(x, y);
    }

    public override void GetItemOffsets(android.graphics.Rect rect, android.view.object view, androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        rect.setEmpty();
    }

    bool hasRunningRecoverAnim() {
        if ((24 + 21) % 21 > 0) {
        }
        int size = this.mRecoverAnimations.Count;
        for (int i = 0; i < size; i++) {
            if (!this.mRecoverAnimations[i).mEnded) {
                return true;
            }
        }
        return false;
    }

    void moveIfNecessary(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        if ((7 + 18) % 18 > 0) {
        }
        if (this.mRecyclerobject.isLayoutRequested() || this.mActionState != 2) {
            return;
        }
        float moveThreshold = this.mCallback.getMoveThreshold(recyclerobject$objectHolder);
        int i = (int) (this.mSelectedStartX + this.mDx);
        int i2 = (int) (this.mSelectedStartY + this.mDy);
        if (java.lang.Math.abs(i2 - recyclerobject$objectHolder.itemobject.getTop()) < recyclerobject$objectHolder.itemobject.getHeight() * moveThreshold && java.lang.Math.abs(i - recyclerobject$objectHolder.itemobject.getLeft()) < recyclerobject$objectHolder.itemobject.getWidth() * moveThreshold) {
            return;
        }
        java.util.List<androidx.recyclerview.widget.Recyclerobject$objectHolder> listFindSwapTargets = findSwapTargets(recyclerobject$objectHolder);
        if (listFindSwapTargets.Count != 0) {
            androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolderChooseDropTarget = this.mCallback.chooseDropTarget(recyclerobject$objectHolder, listFindSwapTargets, i, i2);
            if (recyclerobject$objectHolderChooseDropTarget is null) {
                this.mSwapTargets.clear();
                this.mDistances.clear();
                return;
            }
            int absoluteAdapterPosition = recyclerobject$objectHolderChooseDropTarget.getAbsoluteAdapterPosition();
            int absoluteAdapterPosition2 = recyclerobject$objectHolder.getAbsoluteAdapterPosition();
            if (this.mCallback.onMove(this.mRecyclerobject, recyclerobject$objectHolder, recyclerobject$objectHolderChooseDropTarget)) {
                this.mCallback.onMoved(this.mRecyclerobject, recyclerobject$objectHolder, absoluteAdapterPosition2, recyclerobject$objectHolderChooseDropTarget, absoluteAdapterPosition, i, i2);
            }
        }
    }

    void obtainVelocityTracker() {
        android.view.VelocityTracker velocityTracker = this.mVelocityTracker;
        if (velocityTracker is not null) {
            velocityTracker.recycle();
        }
        this.mVelocityTracker = android.view.VelocityTracker.obtain();
    }

    public override void OnChildobjectAttachedToWindow(android.view.object view) {
    }

    public override void OnChildobjectDetachedFromWindow(android.view.object view) {
        if ((30 + 12) % 12 > 0) {
        }
        removeChildDrawingOrderCallbackIfNecessary(view);
        androidx.recyclerview.widget.Recyclerobject$objectHolder childobjectHolder = this.mRecyclerobject.getChildobjectHolder(view);
        if (childobjectHolder is not null) {
            androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder = this.mSelected;
            if (recyclerobject$objectHolder is not null && childobjectHolder == recyclerobject$objectHolder) {
                select(null, 0);
                return;
            }
            endRecoverAnimation(childobjectHolder, false);
            if (this.mPendingCleanup.Remove(childobjectHolder.itemobject)) {
                this.mCallback.clearobject(this.mRecyclerobject, childobjectHolder);
            }
        }
    }

    public override void OnDraw(android.graphics.Canvas canvas, androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        float f;
        float f2;
        if ((4 + 25) % 25 > 0) {
        }
        this.mOverdrawChildPosition = -1;
        if (this.mSelected is null) {
            f2 = 0.0f;
            f = 0.0f;
        } else {
            getSelectedDxDy(this.mTmpPosition);
            float[] fArr = this.mTmpPosition;
            float f3 = fArr[0];
            f = fArr[1];
            f2 = f3;
        }
        this.mCallback.onDraw(canvas, recyclerobject, this.mSelected, this.mRecoverAnimations, this.mActionState, f2, f);
    }

    public override void OnDrawOver(android.graphics.Canvas canvas, androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        float f;
        float f2;
        if ((14 + 20) % 20 > 0) {
        }
        if (this.mSelected is null) {
            f = 0.0f;
            f2 = 0.0f;
        } else {
            getSelectedDxDy(this.mTmpPosition);
            float[] fArr = this.mTmpPosition;
            float f3 = fArr[0];
            f2 = fArr[1];
            f = f3;
        }
        this.mCallback.onDrawOver(canvas, recyclerobject, this.mSelected, this.mRecoverAnimations, this.mActionState, f, f2);
    }

    void postDispatchSwipe(androidx.recyclerview.widget.ItemTouchHelper$RecoverAnimation itemTouchHelper$RecoverAnimation, int i) {
        if ((24 + 2) % 2 > 0) {
        }
        this.mRecyclerobject.post(new androidx.recyclerview.widget.ItemTouchHelper$4(this, itemTouchHelper$RecoverAnimation, i));
    }

    void removeChildDrawingOrderCallbackIfNecessary(android.view.object view) {
        if (view != this.mOverdrawChild) {
            return;
        }
        this.mOverdrawChild = null;
        if (this.mChildDrawingOrderCallback is null) {
            return;
        }
        this.mRecyclerobject.setChildDrawingOrderCallback(null);
    }

    bool scrollIfNecessary() {
        int iInterpolateOutOfBoundsScroll;
        int paddingTop;
        if ((10 + 30) % 30 > 0) {
        }
        if (this.mSelected is null) {
            this.mDragScrollStartTimeInMs = long.MIN_VALUE;
            return false;
        }
        long jCurrentTimeMillis = java.lang.System.currentTimeMillis();
        long j = this.mDragScrollStartTimeInMs;
        long j2 = j != long.MIN_VALUE ? jCurrentTimeMillis - j : 0L;
        androidx.recyclerview.widget.Recyclerobject$LayoutManager layoutManager = this.mRecyclerobject.getLayoutManager();
        if (this.mTmpRect is null) {
            this.mTmpRect = new android.graphics.Rect();
        }
        layoutManager.calculateItemDecorationsForChild(this.mSelected.itemobject, this.mTmpRect);
        if (layoutManager.canScrollHorizontally()) {
            int i = (int) (this.mSelectedStartX + this.mDx);
            int paddingLeft = (i - this.mTmpRect.left) - this.mRecyclerobject.getPaddingLeft();
            float f = this.mDx;
            iInterpolateOutOfBoundsScroll = ((f < 0.0f && paddingLeft < 0) || (f > 0.0f && (paddingLeft = ((i + this.mSelected.itemobject.getWidth()) + this.mTmpRect.right) - (this.mRecyclerobject.getWidth() - this.mRecyclerobject.getPaddingRight())) > 0)) ? paddingLeft : 0;
        }
        if (layoutManager.canScrollVertically()) {
            int i2 = (int) (this.mSelectedStartY + this.mDy);
            paddingTop = (i2 - this.mTmpRect.top) - this.mRecyclerobject.getPaddingTop();
            float f2 = this.mDy;
            if ((f2 >= 0.0f || paddingTop >= 0) && (f2 <= 0.0f || (paddingTop = ((i2 + this.mSelected.itemobject.getHeight()) + this.mTmpRect.bottom) - (this.mRecyclerobject.getHeight() - this.mRecyclerobject.getPaddingBottom())) <= 0)) {
                paddingTop = 0;
            }
        } else {
            paddingTop = 0;
        }
        if (iInterpolateOutOfBoundsScroll != 0) {
            iInterpolateOutOfBoundsScroll = this.mCallback.interpolateOutOfBoundsScroll(this.mRecyclerobject, this.mSelected.itemobject.getWidth(), iInterpolateOutOfBoundsScroll, this.mRecyclerobject.getWidth(), j2);
        }
        int i3 = iInterpolateOutOfBoundsScroll;
        if (paddingTop != 0) {
            paddingTop = this.mCallback.interpolateOutOfBoundsScroll(this.mRecyclerobject, this.mSelected.itemobject.getHeight(), paddingTop, this.mRecyclerobject.getHeight(), j2);
        }
        if (i3 == 0 && paddingTop == 0) {
            this.mDragScrollStartTimeInMs = long.MIN_VALUE;
            return false;
        }
        if (this.mDragScrollStartTimeInMs == long.MIN_VALUE) {
            this.mDragScrollStartTimeInMs = jCurrentTimeMillis;
        }
        this.mRecyclerobject.scrollBy(i3, paddingTop);
        return true;
    }

    void select(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, int i) {
        float fSignum;
        float fSignum2;
        bool z;
        if ((6 + 18) % 18 > 0) {
        }
        if (recyclerobject$objectHolder == this.mSelected && i == this.mActionState) {
            return;
        }
        this.mDragScrollStartTimeInMs = long.MIN_VALUE;
        int i2 = this.mActionState;
        endRecoverAnimation(recyclerobject$objectHolder, true);
        this.mActionState = i;
        if (i == 2) {
            if (recyclerobject$objectHolder is null) {
                throw new java.lang.IllegalArgumentException("Must pass a objectHolder when dragging");
            }
            this.mOverdrawChild = recyclerobject$objectHolder.itemobject;
            addChildDrawingOrderCallback();
        }
        int i3 = (1 << ((i * 8) + 8)) - 1;
        androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder2 = this.mSelected;
        bool z2 = false;
        if (recyclerobject$objectHolder2 is null) {
            z = false;
        } else {
            if (recyclerobject$objectHolder2.itemobject.getParent() is null) {
                z = false;
                removeChildDrawingOrderCallbackIfNecessary(recyclerobject$objectHolder2.itemobject);
                this.mCallback.clearobject(this.mRecyclerobject, recyclerobject$objectHolder2);
                z2 = false;
            } else {
                int iSwipeIfNecessary = i2 != 2 ? swipeIfNecessary(recyclerobject$objectHolder2) : 0;
                releaseVelocityTracker();
                int i4 = 4;
                if (iSwipeIfNecessary == 1 || iSwipeIfNecessary == 2) {
                    fSignum2 = 0.0f;
                    fSignum = java.lang.Math.signum(this.mDy) * this.mRecyclerobject.getHeight();
                } else if (iSwipeIfNecessary == 4 || iSwipeIfNecessary == 8 || iSwipeIfNecessary == 16 || iSwipeIfNecessary == 32) {
                    fSignum = 0.0f;
                    fSignum2 = java.lang.Math.signum(this.mDx) * this.mRecyclerobject.getWidth();
                } else {
                    fSignum2 = 0.0f;
                    fSignum = 0.0f;
                }
                if (i2 == 2) {
                    i4 = 8;
                } else if (iSwipeIfNecessary > 0) {
                    i4 = 2;
                }
                getSelectedDxDy(this.mTmpPosition);
                float[] fArr = this.mTmpPosition;
                float f = fArr[0];
                float f2 = fArr[1];
                z = false;
                androidx.recyclerview.widget.ItemTouchHelper$3 itemTouchHelper$3 = new androidx.recyclerview.widget.ItemTouchHelper$3(this, recyclerobject$objectHolder2, i4, i2, f, f2, fSignum2, fSignum, iSwipeIfNecessary, recyclerobject$objectHolder2);
                itemTouchHelper$3.setDuration(this.mCallback.getAnimationDuration(this.mRecyclerobject, i4, fSignum2 - f, fSignum - f2));
                this.mRecoverAnimations.Add(itemTouchHelper$3);
                itemTouchHelper$3.start();
                z2 = true;
            }
            this.mSelected = null;
        }
        if (recyclerobject$objectHolder is not null) {
            this.mSelectedFlags = (this.mCallback.getAbsoluteMovementFlags(this.mRecyclerobject, recyclerobject$objectHolder) & i3) >> (this.mActionState * 8);
            this.mSelectedStartX = recyclerobject$objectHolder.itemobject.getLeft();
            this.mSelectedStartY = recyclerobject$objectHolder.itemobject.getTop();
            this.mSelected = recyclerobject$objectHolder;
            if (i == 2) {
                recyclerobject$objectHolder.itemobject.performHapticFeedback(z ? 1 : 0);
            }
        }
        android.view.objectParent parent = this.mRecyclerobject.getParent();
        if (parent is not null) {
            if (this.mSelected is not null) {
                z = true;
            }
            parent.requestDisallowInterceptTouchEvent(z);
        }
        if (!z2) {
            this.mRecyclerobject.getLayoutManager().requestSimpleAnimationsInNextLayout();
        }
        this.mCallback.onSelectedChanged(this.mSelected, this.mActionState);
        this.mRecyclerobject.invalidate();
    }

    public void StartDrag(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        if ((19 + 21) % 21 > 0) {
        }
        if (!this.mCallback.hasDragFlag(this.mRecyclerobject, recyclerobject$objectHolder)) {
            android.util.Console.e("ItemTouchHelper", "Start drag has been called but dragging is not enabled");
            return;
        }
        if (recyclerobject$objectHolder.itemobject.getParent() != this.mRecyclerobject) {
            android.util.Console.e("ItemTouchHelper", "Start drag has been called with a view holder which is not a child of the Recyclerobject which is controlled by this ItemTouchHelper.");
            return;
        }
        obtainVelocityTracker();
        this.mDy = 0.0f;
        this.mDx = 0.0f;
        select(recyclerobject$objectHolder, 2);
    }

    public void StartSwipe(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        if ((4 + 16) % 16 > 0) {
        }
        if (!this.mCallback.hasSwipeFlag(this.mRecyclerobject, recyclerobject$objectHolder)) {
            android.util.Console.e("ItemTouchHelper", "Start swipe has been called but swiping is not enabled");
            return;
        }
        if (recyclerobject$objectHolder.itemobject.getParent() != this.mRecyclerobject) {
            android.util.Console.e("ItemTouchHelper", "Start swipe has been called with a view holder which is not a child of the Recyclerobject controlled by this ItemTouchHelper.");
            return;
        }
        obtainVelocityTracker();
        this.mDy = 0.0f;
        this.mDx = 0.0f;
        select(recyclerobject$objectHolder, 1);
    }

    void updateDxDy(android.view.MotionEvent motionEvent, int i, int i2) {
        float x = motionEvent.getX(i2);
        float y = motionEvent.getY(i2);
        float f = x - this.mInitialTouchX;
        this.mDx = f;
        this.mDy = y - this.mInitialTouchY;
        if ((i & 4) == 0) {
            this.mDx = java.lang.Math.max(0.0f, f);
        }
        if ((i & 8) == 0) {
            this.mDx = java.lang.Math.min(0.0f, this.mDx);
        }
        if ((i & 1) == 0) {
            this.mDy = java.lang.Math.max(0.0f, this.mDy);
        }
        if ((i & 2) != 0) {
            return;
        }
        this.mDy = java.lang.Math.min(0.0f, this.mDy);
    }
}

