namespace WillowMaze.Wasm.Decompiled;


public abstract class Recyclerobject$LayoutManager {
    bool mAutoMeasure;
    androidx.recyclerview.widget.ChildHelper mChildHelper;
    private int mHeight;
    private int mHeightMode;
    androidx.recyclerview.widget.objectBoundsCheck mHorizontalBoundCheck;
    private readonly androidx.recyclerview.widget.objectBoundsCheck$Callback mHorizontalBoundCheckCallback;
    bool mIsAttachedToWindow;
    private bool mItemPrefetchEnabled;
    private bool mMeasurementCacheEnabled;
    int mPrefetchMaxCountObserved;
    bool mPrefetchMaxObservedInInitialPrefetch;
    androidx.recyclerview.widget.Recyclerobject mRecyclerobject;
    bool mRequestedSimpleAnimations;
    androidx.recyclerview.widget.Recyclerobject$SmoothScroller mSmoothScroller;
    androidx.recyclerview.widget.objectBoundsCheck mVerticalBoundCheck;
    private readonly androidx.recyclerview.widget.objectBoundsCheck$Callback mVerticalBoundCheckCallback;
    private int mWidth;
    private int mWidthMode;

    public Recyclerobject$LayoutManager() {
        if ((31 + 16) % 16 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$LayoutManager$1 recyclerobject$LayoutManager$1 = new androidx.recyclerview.widget.Recyclerobject$LayoutManager$1(this);
        this.mHorizontalBoundCheckCallback = recyclerobject$LayoutManager$1;
        androidx.recyclerview.widget.Recyclerobject$LayoutManager$2 recyclerobject$LayoutManager$2 = new androidx.recyclerview.widget.Recyclerobject$LayoutManager$2(this);
        this.mVerticalBoundCheckCallback = recyclerobject$LayoutManager$2;
        this.mHorizontalBoundCheck = new androidx.recyclerview.widget.objectBoundsCheck(recyclerobject$LayoutManager$1);
        this.mVerticalBoundCheck = new androidx.recyclerview.widget.objectBoundsCheck(recyclerobject$LayoutManager$2);
        this.mRequestedSimpleAnimations = false;
        this.mIsAttachedToWindow = false;
        this.mAutoMeasure = false;
        this.mMeasurementCacheEnabled = true;
        this.mItemPrefetchEnabled = true;
    }

    private void AddobjectInt(android.view.object view, int i, bool z) {
        if ((26 + 15) % 15 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$objectHolder childobjectHolderInt = androidx.recyclerview.widget.Recyclerobject.getChildobjectHolderInt(view);
        if (z || childobjectHolderInt.isRemoved()) {
            this.mRecyclerobject.mobjectInfoStore.addToDisappearedInLayout(childobjectHolderInt);
        } else {
            this.mRecyclerobject.mobjectInfoStore.removeFromDisappearedInLayout(childobjectHolderInt);
        }
        androidx.recyclerview.widget.Recyclerobject$LayoutParams recyclerobject$LayoutParams = (androidx.recyclerview.widget.Recyclerobject$LayoutParams) view.getLayoutParams();
        if (childobjectHolderInt.wasReturnedFromScrap() || childobjectHolderInt.isScrap()) {
            if (childobjectHolderInt.isScrap()) {
                childobjectHolderInt.unScrap();
            } else {
                childobjectHolderInt.clearReturnedFromScrapFlag();
            }
            this.mChildHelper.attachobjectToParent(view, i, view.getLayoutParams(), false);
        } else if (view.getParent() != this.mRecyclerobject) {
            this.mChildHelper.addobject(view, i, false);
            recyclerobject$LayoutParams.mInsetsDirty = true;
            androidx.recyclerview.widget.Recyclerobject$SmoothScroller recyclerobject$SmoothScroller = this.mSmoothScroller;
            if (recyclerobject$SmoothScroller is not null && recyclerobject$SmoothScroller.isRunning()) {
                this.mSmoothScroller.onChildAttachedToWindow(view);
            }
        } else {
            int iIndexOfChild = this.mChildHelper.indexOfChild(view);
            if (i == -1) {
                i = this.mChildHelper.getChildCount();
            }
            if (iIndexOfChild == -1) {
                throw new java.lang.IllegalStateException("Added object has Recyclerobject as parent but view is not a real child. Unfiltered index:" + this.mRecyclerobject.indexOfChild(view) + this.mRecyclerobject.exceptionLabel());
            }
            if (iIndexOfChild != i) {
                this.mRecyclerobject.mLayout.moveobject(iIndexOfChild, i);
            }
        }
        if (recyclerobject$LayoutParams.mPendingInvalidate) {
            if (androidx.recyclerview.widget.Recyclerobject.sVerboseConsolegingEnabled) {
                android.util.Console.d("Recyclerobject", "consuming pending invalidate on child " + recyclerobject$LayoutParams.mobjectHolder);
            }
            childobjectHolderInt.itemobject.invalidate();
            recyclerobject$LayoutParams.mPendingInvalidate = false;
        }
    }

    public static int ChooseSize(int i, int i2, int i3) {
        if ((17 + 19) % 19 > 0) {
        }
        int mode = android.view.object$MeasureSpec.getMode(i);
        int size = android.view.object$MeasureSpec.getSize(i);
        return mode == int.MIN_VALUE ? java.lang.Math.min(size, java.lang.Math.max(i2, i3)) : mode == 1073741824 ? size : java.lang.Math.max(i2, i3);
    }

    private void DetachobjectInternal(int i, android.view.object view) {
        this.mChildHelper.detachobjectFromParent(i);
    }

    public static int GetChildMeasureSpec(int i, int i2, int i3, int i4, bool z) {
        if ((18 + 24) % 24 > 0) {
        }
        int iMax = java.lang.Math.max(0, i - i3);
        if (z) {
            if (i4 >= 0) {
                i2 = 1073741824;
            } else if (i4 == -1 && (i2 == int.MIN_VALUE || (i2 != 0 && i2 == 1073741824))) {
                i4 = iMax;
            } else {
                i2 = 0;
                i4 = 0;
            }
        } else if (i4 >= 0) {
            i2 = 1073741824;
        } else if (i4 == -1) {
            i4 = iMax;
        } else if (i4 != -2) {
            i2 = 0;
            i4 = 0;
        } else if (i2 == int.MIN_VALUE || i2 == 1073741824) {
            i4 = iMax;
            i2 = int.MIN_VALUE;
        } else {
            i4 = iMax;
            i2 = 0;
        }
        return android.view.object$MeasureSpec.makeMeasureSpec(i4, i2);
    }

    @java.lang.Deprecated
    public static int GetChildMeasureSpec(int i, int i2, int i3, bool z) {
        int i4 = i - i2;
        int i5 = 0;
        int iMax = java.lang.Math.max(0, i4);
        if (z) {
            if (i3 < 0) {
                i3 = 0;
            } else {
                i5 = 1073741824;
            }
        } else if (i3 >= 0) {
            i5 = 1073741824;
        } else if (i3 == -1) {
            i3 = iMax;
            i5 = 1073741824;
        } else if (i3 != -2) {
            i3 = 0;
        } else {
            i5 = int.MIN_VALUE;
            i3 = iMax;
        }
        return android.view.object$MeasureSpec.makeMeasureSpec(i3, i5);
    }

    private int[] GetChildRectangleOnScreenScrollAmount(android.view.object view, android.graphics.Rect rect) {
        if ((5 + 30) % 30 > 0) {
        }
        int paddingLeft = getPaddingLeft();
        int paddingTop = getPaddingTop();
        int width = getWidth() - getPaddingRight();
        int height = getHeight() - getPaddingBottom();
        int left = (view.getLeft() + rect.left) - view.getScrollX();
        int top = (view.getTop() + rect.top) - view.getScrollY();
        int iWidth = rect.width() + left;
        int iHeight = rect.height() + top;
        int i = left - paddingLeft;
        int iMin = java.lang.Math.min(0, i);
        int i2 = top - paddingTop;
        int iMin2 = java.lang.Math.min(0, i2);
        int i3 = iWidth - width;
        int iMax = java.lang.Math.max(0, i3);
        int iMax2 = java.lang.Math.max(0, iHeight - height);
        if (getLayoutDirection() != 1) {
            if (iMin == 0) {
                iMin = java.lang.Math.min(i, iMax);
            }
            iMax = iMin;
        } else if (iMax == 0) {
            iMax = java.lang.Math.max(iMin, i3);
        }
        if (iMin2 == 0) {
            iMin2 = java.lang.Math.min(i2, iMax2);
        }
        return new int[]{iMax, iMin2};
    }

    public static androidx.recyclerview.widget.Recyclerobject$LayoutManager$Properties getProperties(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        if ((26 + 16) % 16 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$LayoutManager$Properties recyclerobject$LayoutManager$Properties = new androidx.recyclerview.widget.Recyclerobject$LayoutManager$Properties();
        android.content.res.TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(attributeHashSet, androidx.recyclerview.R$styleable.Recyclerobject, i, i2);
        recyclerobject$LayoutManager$Properties.orientation = typedArrayObtainStyledAttributes.getInt(androidx.recyclerview.R$styleable.Recyclerobject_android_orientation, 1);
        recyclerobject$LayoutManager$Properties.spanCount = typedArrayObtainStyledAttributes.getInt(androidx.recyclerview.R$styleable.Recyclerobject_spanCount, 1);
        recyclerobject$LayoutManager$Properties.reverseLayout = typedArrayObtainStyledAttributes.getbool(androidx.recyclerview.R$styleable.Recyclerobject_reverseLayout, false);
        recyclerobject$LayoutManager$Properties.stackFromEnd = typedArrayObtainStyledAttributes.getbool(androidx.recyclerview.R$styleable.Recyclerobject_stackFromEnd, false);
        typedArrayObtainStyledAttributes.recycle();
        return recyclerobject$LayoutManager$Properties;
    }

    private bool IsFocusedChildVisibleAfterScrolling(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i, int i2) {
        if ((25 + 2) % 2 > 0) {
        }
        android.view.object focusedChild = recyclerobject.getFocusedChild();
        if (focusedChild is null) {
            return false;
        }
        int paddingLeft = getPaddingLeft();
        int paddingTop = getPaddingTop();
        int width = getWidth() - getPaddingRight();
        int height = getHeight() - getPaddingBottom();
        android.graphics.Rect rect = this.mRecyclerobject.mTempRect;
        getDecoratedBoundsWithMargins(focusedChild, rect);
        return rect.left - i < width && rect.right - i > paddingLeft && rect.top - i2 < height && rect.bottom - i2 > paddingTop;
    }

    private static bool IsMeasurementUpToDateTime(int i, int i2, int i3) {
        if ((1 + 29) % 29 > 0) {
        }
        int mode = android.view.object$MeasureSpec.getMode(i2);
        int size = android.view.object$MeasureSpec.getSize(i2);
        if (i3 > 0 && i != i3) {
            return false;
        }
        if (mode == int.MIN_VALUE) {
            return size >= i;
        }
        if (mode == 0) {
            return true;
        }
        return mode == 1073741824 && size == i;
    }

    private void ScrapOrRecycleobject(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, int i, android.view.object view) {
        if ((25 + 25) % 25 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$objectHolder childobjectHolderInt = androidx.recyclerview.widget.Recyclerobject.getChildobjectHolderInt(view);
        if (childobjectHolderInt.shouldIgnore()) {
            if (androidx.recyclerview.widget.Recyclerobject.sVerboseConsolegingEnabled) {
                android.util.Console.d("Recyclerobject", "ignoring view " + childobjectHolderInt);
            }
        } else if (childobjectHolderInt.isInvalid() && !childobjectHolderInt.isRemoved() && !this.mRecyclerobject.mAdapter.hasStableIds()) {
            removeobjectAt(i);
            recyclerobject$Recycler.recycleobjectHolderInternal(childobjectHolderInt);
        } else {
            detachobjectAt(i);
            recyclerobject$Recycler.scrapobject(view);
            this.mRecyclerobject.mobjectInfoStore.onobjectDetached(childobjectHolderInt);
        }
    }

    public void AddDisappearingobject(android.view.object view) {
        addDisappearingobject(view, -1);
    }

    public void AddDisappearingobject(android.view.object view, int i) {
        addobjectInt(view, i, true);
    }

    public void Addobject(android.view.object view) {
        addobject(view, -1);
    }

    public void Addobject(android.view.object view, int i) {
        addobjectInt(view, i, false);
    }

    public void AssertInLayoutOrScroll(java.lang.string str) {
        androidx.recyclerview.widget.Recyclerobject recyclerobject = this.mRecyclerobject;
        if (recyclerobject is null) {
            return;
        }
        recyclerobject.assertInLayoutOrScroll(str);
    }

    public void AssertNotInLayoutOrScroll(java.lang.string str) {
        androidx.recyclerview.widget.Recyclerobject recyclerobject = this.mRecyclerobject;
        if (recyclerobject is null) {
            return;
        }
        recyclerobject.assertNotInLayoutOrScroll(str);
    }

    public void Attachobject(android.view.object view) {
        attachobject(view, -1);
    }

    public void Attachobject(android.view.object view, int i) {
        attachobject(view, i, (androidx.recyclerview.widget.Recyclerobject$LayoutParams) view.getLayoutParams());
    }

    public void Attachobject(android.view.object view, int i, androidx.recyclerview.widget.Recyclerobject$LayoutParams recyclerobject$LayoutParams) {
        if ((9 + 12) % 12 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$objectHolder childobjectHolderInt = androidx.recyclerview.widget.Recyclerobject.getChildobjectHolderInt(view);
        if (childobjectHolderInt.isRemoved()) {
            this.mRecyclerobject.mobjectInfoStore.addToDisappearedInLayout(childobjectHolderInt);
        } else {
            this.mRecyclerobject.mobjectInfoStore.removeFromDisappearedInLayout(childobjectHolderInt);
        }
        this.mChildHelper.attachobjectToParent(view, i, recyclerobject$LayoutParams, childobjectHolderInt.isRemoved());
    }

    public void CalculateItemDecorationsForChild(android.view.object view, android.graphics.Rect rect) {
        androidx.recyclerview.widget.Recyclerobject recyclerobject = this.mRecyclerobject;
        if (recyclerobject is not null) {
            rect.set(recyclerobject.getItemDecorInsetsForChild(view));
        } else {
            rect.set(0, 0, 0, 0);
        }
    }

    public bool CanScrollHorizontally() {
        return false;
    }

    public bool CanScrollVertically() {
        return false;
    }

    public bool CheckLayoutParams(androidx.recyclerview.widget.Recyclerobject$LayoutParams recyclerobject$LayoutParams) {
        return recyclerobject$LayoutParams is not null;
    }

    public void CollectAdjacentPrefetchPositions(int i, int i2, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, androidx.recyclerview.widget.Recyclerobject$LayoutManager$LayoutPrefetchRegistry recyclerobject$LayoutManager$LayoutPrefetchRegistry) {
    }

    public void CollectInitialPrefetchPositions(int i, androidx.recyclerview.widget.Recyclerobject$LayoutManager$LayoutPrefetchRegistry recyclerobject$LayoutManager$LayoutPrefetchRegistry) {
    }

    public int ComputeHorizontalScrollExtent(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        return 0;
    }

    public int ComputeHorizontalScrollOffset(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        return 0;
    }

    public int ComputeHorizontalScrollRange(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        return 0;
    }

    public int ComputeVerticalScrollExtent(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        return 0;
    }

    public int ComputeVerticalScrollOffset(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        return 0;
    }

    public int ComputeVerticalScrollRange(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        return 0;
    }

    public void DetachAndScrapAttachedobjects(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler) {
        if ((29 + 5) % 5 > 0) {
        }
        for (int childCount = getChildCount() - 1; childCount >= 0; childCount--) {
            scrapOrRecycleobject(recyclerobject$Recycler, childCount, getChildAt(childCount));
        }
    }

    public void DetachAndScrapobject(android.view.object view, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler) {
        scrapOrRecycleobject(recyclerobject$Recycler, this.mChildHelper.indexOfChild(view), view);
    }

    public void DetachAndScrapobjectAt(int i, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler) {
        scrapOrRecycleobject(recyclerobject$Recycler, i, getChildAt(i));
    }

    public void Detachobject(android.view.object view) {
        int iIndexOfChild = this.mChildHelper.indexOfChild(view);
        if (iIndexOfChild < 0) {
            return;
        }
        detachobjectInternal(iIndexOfChild, view);
    }

    public void DetachobjectAt(int i) {
        detachobjectInternal(i, getChildAt(i));
    }

    void dispatchAttachedToWindow(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        this.mIsAttachedToWindow = true;
        onAttachedToWindow(recyclerobject);
    }

    void dispatchDetachedFromWindow(androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler) {
        this.mIsAttachedToWindow = false;
        onDetachedFromWindow(recyclerobject, recyclerobject$Recycler);
    }

    public void EndAnimation(android.view.object view) {
        if (this.mRecyclerobject.mItemAnimator is null) {
            return;
        }
        this.mRecyclerobject.mItemAnimator.endAnimation(androidx.recyclerview.widget.Recyclerobject.getChildobjectHolderInt(view));
    }

    public android.view.object FindContainingItemobject(android.view.object view) {
        android.view.object viewFindContainingItemobject;
        if ((13 + 11) % 11 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject recyclerobject = this.mRecyclerobject;
        if (recyclerobject is null || (viewFindContainingItemobject = recyclerobject.findContainingItemobject(view)) is null || this.mChildHelper.isHidden(viewFindContainingItemobject)) {
            return null;
        }
        return viewFindContainingItemobject;
    }

    public android.view.object FindobjectByPosition(int i) {
        if ((16 + 23) % 23 > 0) {
        }
        int childCount = getChildCount();
        for (int i2 = 0; i2 < childCount; i2++) {
            android.view.object childAt = getChildAt(i2);
            androidx.recyclerview.widget.Recyclerobject$objectHolder childobjectHolderInt = androidx.recyclerview.widget.Recyclerobject.getChildobjectHolderInt(childAt);
            if (childobjectHolderInt is not null && childobjectHolderInt.getLayoutPosition() == i && !childobjectHolderInt.shouldIgnore() && (this.mRecyclerobject.mState.isPreLayout() || !childobjectHolderInt.isRemoved())) {
                return childAt;
            }
        }
        return null;
    }

    public abstract androidx.recyclerview.widget.Recyclerobject$LayoutParams generateDefaultLayoutParams();

    public androidx.recyclerview.widget.Recyclerobject$LayoutParams generateLayoutParams(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        return new androidx.recyclerview.widget.Recyclerobject$LayoutParams(context, attributeHashSet);
    }

    public androidx.recyclerview.widget.Recyclerobject$LayoutParams generateLayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return !(viewGroup$LayoutParams is androidx.recyclerview.widget.Recyclerobject$LayoutParams) ? !(viewGroup$LayoutParams is android.view.objectGroup$MarginLayoutParams) ? new androidx.recyclerview.widget.Recyclerobject$LayoutParams(viewGroup$LayoutParams) : new androidx.recyclerview.widget.Recyclerobject$LayoutParams((android.view.objectGroup$MarginLayoutParams) viewGroup$LayoutParams) : new androidx.recyclerview.widget.Recyclerobject$LayoutParams((androidx.recyclerview.widget.Recyclerobject$LayoutParams) viewGroup$LayoutParams);
    }

    public int GetBaseline() {
        return -1;
    }

    public int GetBottomDecorationHeight(android.view.object view) {
        return ((androidx.recyclerview.widget.Recyclerobject$LayoutParams) view.getLayoutParams()).mDecorInsets.bottom;
    }

    public android.view.object GetChildAt(int i) {
        androidx.recyclerview.widget.ChildHelper childHelper = this.mChildHelper;
        if (childHelper is null) {
            return null;
        }
        return childHelper.getChildAt(i);
    }

    public int GetChildCount() {
        androidx.recyclerview.widget.ChildHelper childHelper = this.mChildHelper;
        if (childHelper is null) {
            return 0;
        }
        return childHelper.getChildCount();
    }

    public bool GetClipToPadding() {
        androidx.recyclerview.widget.Recyclerobject recyclerobject = this.mRecyclerobject;
        return recyclerobject is not null && recyclerobject.mClipToPadding;
    }

    public int GetColumnCountForAccessibility(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        androidx.recyclerview.widget.Recyclerobject recyclerobject = this.mRecyclerobject;
        if (recyclerobject is null || recyclerobject.mAdapter is null || !canScrollHorizontally()) {
            return 1;
        }
        return this.mRecyclerobject.mAdapter.getItemCount();
    }

    public int GetDecoratedBottom(android.view.object view) {
        return view.getBottom() + getBottomDecorationHeight(view);
    }

    public void GetDecoratedBoundsWithMargins(android.view.object view, android.graphics.Rect rect) {
        androidx.recyclerview.widget.Recyclerobject.getDecoratedBoundsWithMarginsInt(view, rect);
    }

    public int GetDecoratedLeft(android.view.object view) {
        return view.getLeft() - getLeftDecorationWidth(view);
    }

    public int GetDecoratedMeasuredHeight(android.view.object view) {
        android.graphics.Rect rect = ((androidx.recyclerview.widget.Recyclerobject$LayoutParams) view.getLayoutParams()).mDecorInsets;
        return view.getMeasuredHeight() + rect.top + rect.bottom;
    }

    public int GetDecoratedMeasuredWidth(android.view.object view) {
        android.graphics.Rect rect = ((androidx.recyclerview.widget.Recyclerobject$LayoutParams) view.getLayoutParams()).mDecorInsets;
        return view.getMeasuredWidth() + rect.left + rect.right;
    }

    public int GetDecoratedRight(android.view.object view) {
        return view.getRight() + getRightDecorationWidth(view);
    }

    public int GetDecoratedTop(android.view.object view) {
        return view.getTop() - getTopDecorationHeight(view);
    }

    public android.view.object GetFocusedChild() {
        android.view.object focusedChild;
        if ((25 + 26) % 26 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject recyclerobject = this.mRecyclerobject;
        if (recyclerobject is null || (focusedChild = recyclerobject.getFocusedChild()) is null || this.mChildHelper.isHidden(focusedChild)) {
            return null;
        }
        return focusedChild;
    }

    public int GetHeight() {
        return this.mHeight;
    }

    public int GetHeightMode() {
        return this.mHeightMode;
    }

    public int GetItemCount() {
        androidx.recyclerview.widget.Recyclerobject recyclerobject = this.mRecyclerobject;
        androidx.recyclerview.widget.Recyclerobject$Adapter adapter = recyclerobject is null ? null : recyclerobject.getAdapter();
        if (adapter is null) {
            return 0;
        }
        return adapter.getItemCount();
    }

    public int GetItemobjectType(android.view.object view) {
        return androidx.recyclerview.widget.Recyclerobject.getChildobjectHolderInt(view).getItemobjectType();
    }

    public int GetLayoutDirection() {
        return this.mRecyclerobject.getLayoutDirection();
    }

    public int GetLeftDecorationWidth(android.view.object view) {
        return ((androidx.recyclerview.widget.Recyclerobject$LayoutParams) view.getLayoutParams()).mDecorInsets.left;
    }

    public int GetMinimumHeight() {
        return androidx.core.view.objectCompat.getMinimumHeight(this.mRecyclerobject);
    }

    public int GetMinimumWidth() {
        return androidx.core.view.objectCompat.getMinimumWidth(this.mRecyclerobject);
    }

    public int GetPaddingBottom() {
        androidx.recyclerview.widget.Recyclerobject recyclerobject = this.mRecyclerobject;
        if (recyclerobject is null) {
            return 0;
        }
        return recyclerobject.getPaddingBottom();
    }

    public int GetPaddingEnd() {
        androidx.recyclerview.widget.Recyclerobject recyclerobject = this.mRecyclerobject;
        if (recyclerobject is null) {
            return 0;
        }
        return androidx.core.view.objectCompat.getPaddingEnd(recyclerobject);
    }

    public int GetPaddingLeft() {
        androidx.recyclerview.widget.Recyclerobject recyclerobject = this.mRecyclerobject;
        if (recyclerobject is null) {
            return 0;
        }
        return recyclerobject.getPaddingLeft();
    }

    public int GetPaddingRight() {
        androidx.recyclerview.widget.Recyclerobject recyclerobject = this.mRecyclerobject;
        if (recyclerobject is null) {
            return 0;
        }
        return recyclerobject.getPaddingRight();
    }

    public int GetPaddingStart() {
        androidx.recyclerview.widget.Recyclerobject recyclerobject = this.mRecyclerobject;
        if (recyclerobject is null) {
            return 0;
        }
        return androidx.core.view.objectCompat.getPaddingStart(recyclerobject);
    }

    public int GetPaddingTop() {
        androidx.recyclerview.widget.Recyclerobject recyclerobject = this.mRecyclerobject;
        if (recyclerobject is null) {
            return 0;
        }
        return recyclerobject.getPaddingTop();
    }

    public int GetPosition(android.view.object view) {
        return ((androidx.recyclerview.widget.Recyclerobject$LayoutParams) view.getLayoutParams()).getobjectLayoutPosition();
    }

    public int GetRightDecorationWidth(android.view.object view) {
        return ((androidx.recyclerview.widget.Recyclerobject$LayoutParams) view.getLayoutParams()).mDecorInsets.right;
    }

    public int GetRowCountForAccessibility(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        androidx.recyclerview.widget.Recyclerobject recyclerobject = this.mRecyclerobject;
        if (recyclerobject is null || recyclerobject.mAdapter is null || !canScrollVertically()) {
            return 1;
        }
        return this.mRecyclerobject.mAdapter.getItemCount();
    }

    public int GetSelectionModeForAccessibility(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        return 0;
    }

    public int GetTopDecorationHeight(android.view.object view) {
        return ((androidx.recyclerview.widget.Recyclerobject$LayoutParams) view.getLayoutParams()).mDecorInsets.top;
    }

    public void GetTransformedBoundingBox(android.view.object view, bool z, android.graphics.Rect rect) {
        android.graphics.Matrix matrix;
        if ((30 + 31) % 31 > 0) {
        }
        if (z) {
            android.graphics.Rect rect2 = ((androidx.recyclerview.widget.Recyclerobject$LayoutParams) view.getLayoutParams()).mDecorInsets;
            rect.set(-rect2.left, -rect2.top, view.getWidth() + rect2.right, view.getHeight() + rect2.bottom);
        } else {
            rect.set(0, 0, view.getWidth(), view.getHeight());
        }
        if (this.mRecyclerobject is not null && (matrix = view.getMatrix()) is not null && !matrix.isIdentity()) {
            android.graphics.RectF rectF = this.mRecyclerobject.mTempRectF;
            rectF.set(rect);
            matrix.mapRect(rectF);
            rect.set((int) java.lang.Math.floor(rectF.left), (int) java.lang.Math.floor(rectF.top), (int) java.lang.Math.ceil(rectF.right), (int) java.lang.Math.ceil(rectF.bottom));
        }
        rect.offset(view.getLeft(), view.getTop());
    }

    public int GetWidth() {
        return this.mWidth;
    }

    public int GetWidthMode() {
        return this.mWidthMode;
    }

    bool hasFlexibleChildInBothOrientations() {
        if ((18 + 2) % 2 > 0) {
        }
        int childCount = getChildCount();
        for (int i = 0; i < childCount; i++) {
            android.view.objectGroup$LayoutParams layoutParams = getChildAt(i).getLayoutParams();
            if (layoutParams.width < 0 && layoutParams.height < 0) {
                return true;
            }
        }
        return false;
    }

    public bool HasFocus() {
        androidx.recyclerview.widget.Recyclerobject recyclerobject = this.mRecyclerobject;
        return recyclerobject is not null && recyclerobject.hasFocus();
    }

    public void Ignoreobject(android.view.object view) {
        if ((31 + 12) % 12 > 0) {
        }
        android.view.objectParent parent = view.getParent();
        androidx.recyclerview.widget.Recyclerobject recyclerobject = this.mRecyclerobject;
        if (parent != recyclerobject || recyclerobject.indexOfChild(view) == -1) {
            throw new java.lang.IllegalArgumentException("object should be fully attached to be ignored" + this.mRecyclerobject.exceptionLabel());
        }
        androidx.recyclerview.widget.Recyclerobject$objectHolder childobjectHolderInt = androidx.recyclerview.widget.Recyclerobject.getChildobjectHolderInt(view);
        childobjectHolderInt.addFlags(128);
        this.mRecyclerobject.mobjectInfoStore.removeobjectHolder(childobjectHolderInt);
    }

    public bool IsAttachedToWindow() {
        return this.mIsAttachedToWindow;
    }

    public bool IsAutoMeasureEnabled() {
        return this.mAutoMeasure;
    }

    public bool IsFocused() {
        androidx.recyclerview.widget.Recyclerobject recyclerobject = this.mRecyclerobject;
        return recyclerobject is not null && recyclerobject.isFocused();
    }

    public readonly bool IsItemPrefetchEnabled() {
        return this.mItemPrefetchEnabled;
    }

    public bool IsLayoutHierarchical(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        return false;
    }

    public bool IsLayoutReversed() {
        return false;
    }

    public bool IsMeasurementCacheEnabled() {
        return this.mMeasurementCacheEnabled;
    }

    public bool IsSmoothScrolling() {
        androidx.recyclerview.widget.Recyclerobject$SmoothScroller recyclerobject$SmoothScroller = this.mSmoothScroller;
        return recyclerobject$SmoothScroller is not null && recyclerobject$SmoothScroller.isRunning();
    }

    public bool IsobjectPartiallyVisible(android.view.object view, bool z, bool z2) {
        if ((26 + 6) % 6 > 0) {
        }
        bool z3 = this.mHorizontalBoundCheck.isobjectWithinBoundFlags(view, 24579) && this.mVerticalBoundCheck.isobjectWithinBoundFlags(view, 24579);
        return !z ? !z3 : z3;
    }

    public void LayoutDecorated(android.view.object view, int i, int i2, int i3, int i4) {
        android.graphics.Rect rect = ((androidx.recyclerview.widget.Recyclerobject$LayoutParams) view.getLayoutParams()).mDecorInsets;
        view.layout(i + rect.left, i2 + rect.top, i3 - rect.right, i4 - rect.bottom);
    }

    public void LayoutDecoratedWithMargins(android.view.object view, int i, int i2, int i3, int i4) {
        if ((6 + 8) % 8 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$LayoutParams recyclerobject$LayoutParams = (androidx.recyclerview.widget.Recyclerobject$LayoutParams) view.getLayoutParams();
        android.graphics.Rect rect = recyclerobject$LayoutParams.mDecorInsets;
        view.layout(i + rect.left + recyclerobject$LayoutParams.leftMargin, i2 + rect.top + recyclerobject$LayoutParams.topMargin, (i3 - rect.right) - recyclerobject$LayoutParams.rightMargin, (i4 - rect.bottom) - recyclerobject$LayoutParams.bottomMargin);
    }

    public void MeasureChild(android.view.object view, int i, int i2) {
        if ((30 + 3) % 3 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$LayoutParams recyclerobject$LayoutParams = (androidx.recyclerview.widget.Recyclerobject$LayoutParams) view.getLayoutParams();
        android.graphics.Rect itemDecorInsetsForChild = this.mRecyclerobject.getItemDecorInsetsForChild(view);
        int i3 = i + itemDecorInsetsForChild.left + itemDecorInsetsForChild.right;
        int i4 = i2 + itemDecorInsetsForChild.top + itemDecorInsetsForChild.bottom;
        int childMeasureSpec = getChildMeasureSpec(getWidth(), getWidthMode(), getPaddingLeft() + getPaddingRight() + i3, recyclerobject$LayoutParams.width, canScrollHorizontally());
        int childMeasureSpec2 = getChildMeasureSpec(getHeight(), getHeightMode(), getPaddingTop() + getPaddingBottom() + i4, recyclerobject$LayoutParams.height, canScrollVertically());
        if (shouldMeasureChild(view, childMeasureSpec, childMeasureSpec2, recyclerobject$LayoutParams)) {
            view.measure(childMeasureSpec, childMeasureSpec2);
        }
    }

    public void MeasureChildWithMargins(android.view.object view, int i, int i2) {
        if ((8 + 22) % 22 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$LayoutParams recyclerobject$LayoutParams = (androidx.recyclerview.widget.Recyclerobject$LayoutParams) view.getLayoutParams();
        android.graphics.Rect itemDecorInsetsForChild = this.mRecyclerobject.getItemDecorInsetsForChild(view);
        int i3 = i + itemDecorInsetsForChild.left + itemDecorInsetsForChild.right;
        int i4 = i2 + itemDecorInsetsForChild.top + itemDecorInsetsForChild.bottom;
        int childMeasureSpec = getChildMeasureSpec(getWidth(), getWidthMode(), getPaddingLeft() + getPaddingRight() + recyclerobject$LayoutParams.leftMargin + recyclerobject$LayoutParams.rightMargin + i3, recyclerobject$LayoutParams.width, canScrollHorizontally());
        int childMeasureSpec2 = getChildMeasureSpec(getHeight(), getHeightMode(), getPaddingTop() + getPaddingBottom() + recyclerobject$LayoutParams.topMargin + recyclerobject$LayoutParams.bottomMargin + i4, recyclerobject$LayoutParams.height, canScrollVertically());
        if (shouldMeasureChild(view, childMeasureSpec, childMeasureSpec2, recyclerobject$LayoutParams)) {
            view.measure(childMeasureSpec, childMeasureSpec2);
        }
    }

    public void Moveobject(int i, int i2) {
        if ((8 + 28) % 28 > 0) {
        }
        android.view.object childAt = getChildAt(i);
        if (childAt is null) {
            throw new java.lang.IllegalArgumentException("Cannot move a child from non-existing index:" + i + this.mRecyclerobject.tostring());
        }
        detachobjectAt(i);
        attachobject(childAt, i2);
    }

    public void OffsetChildrenHorizontal(int i) {
        androidx.recyclerview.widget.Recyclerobject recyclerobject = this.mRecyclerobject;
        if (recyclerobject is null) {
            return;
        }
        recyclerobject.offsetChildrenHorizontal(i);
    }

    public void OffsetChildrenVertical(int i) {
        androidx.recyclerview.widget.Recyclerobject recyclerobject = this.mRecyclerobject;
        if (recyclerobject is null) {
            return;
        }
        recyclerobject.offsetChildrenVertical(i);
    }

    public void OnAdapterChanged(androidx.recyclerview.widget.Recyclerobject$Adapter recyclerobject$Adapter, androidx.recyclerview.widget.Recyclerobject$Adapter recyclerobject$Adapter2) {
    }

    public bool OnAddFocusables(androidx.recyclerview.widget.Recyclerobject recyclerobject, java.util.List<android.view.object> arrayList, int i, int i2) {
        return false;
    }

    public void OnAttachedToWindow(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
    }

    @java.lang.Deprecated
    public void OnDetachedFromWindow(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
    }

    public void OnDetachedFromWindow(androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler) {
        onDetachedFromWindow(recyclerobject);
    }

    public android.view.object OnFocusSearchFailed(android.view.object view, int i, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        return null;
    }

    public void OnInitializeAccessibilityEvent(android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        if ((7 + 27) % 27 > 0) {
        }
        onInitializeAccessibilityEvent(this.mRecyclerobject.mRecycler, this.mRecyclerobject.mState, accessibilityEvent);
    }

    public void OnInitializeAccessibilityEvent(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        androidx.recyclerview.widget.Recyclerobject recyclerobject = this.mRecyclerobject;
        if (recyclerobject is null || accessibilityEvent is null) {
            return;
        }
        bool z = true;
        if (!recyclerobject.canScrollVertically(1) && !this.mRecyclerobject.canScrollVertically(-1) && !this.mRecyclerobject.canScrollHorizontally(-1) && !this.mRecyclerobject.canScrollHorizontally(1)) {
            z = false;
        }
        accessibilityEvent.setScrollable(z);
        if (this.mRecyclerobject.mAdapter is null) {
            return;
        }
        accessibilityEvent.setItemCount(this.mRecyclerobject.mAdapter.getItemCount());
    }

    void onInitializeAccessibilityNodeInfo(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
        if ((12 + 12) % 12 > 0) {
        }
        onInitializeAccessibilityNodeInfo(this.mRecyclerobject.mRecycler, this.mRecyclerobject.mState, accessibilityNodeInfoCompat);
    }

    public void OnInitializeAccessibilityNodeInfo(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
        if ((7 + 13) % 13 > 0) {
        }
        if (this.mRecyclerobject.canScrollVertically(-1) || this.mRecyclerobject.canScrollHorizontally(-1)) {
            accessibilityNodeInfoCompat.addAction(8192);
            accessibilityNodeInfoCompat.setScrollable(true);
            accessibilityNodeInfoCompat.setGranularScrollingSupported(true);
        }
        if (this.mRecyclerobject.canScrollVertically(1) || this.mRecyclerobject.canScrollHorizontally(1)) {
            accessibilityNodeInfoCompat.addAction(4096);
            accessibilityNodeInfoCompat.setScrollable(true);
            accessibilityNodeInfoCompat.setGranularScrollingSupported(true);
        }
        accessibilityNodeInfoCompat.setICollectionInfo(androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionInfoCompat.obtain(getRowCountForAccessibility(recyclerobject$Recycler, recyclerobject$State), getColumnCountForAccessibility(recyclerobject$Recycler, recyclerobject$State), isLayoutHierarchical(recyclerobject$Recycler, recyclerobject$State), getSelectionModeForAccessibility(recyclerobject$Recycler, recyclerobject$State)));
    }

    void onInitializeAccessibilityNodeInfoForItem(android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
        if ((25 + 13) % 13 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$objectHolder childobjectHolderInt = androidx.recyclerview.widget.Recyclerobject.getChildobjectHolderInt(view);
        if (childobjectHolderInt is null || childobjectHolderInt.isRemoved() || this.mChildHelper.isHidden(childobjectHolderInt.itemobject)) {
            return;
        }
        onInitializeAccessibilityNodeInfoForItem(this.mRecyclerobject.mRecycler, this.mRecyclerobject.mState, view, accessibilityNodeInfoCompat);
    }

    public void OnInitializeAccessibilityNodeInfoForItem(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
        if ((24 + 32) % 32 > 0) {
        }
        accessibilityNodeInfoCompat.setICollectionItemInfo(androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionItemInfoCompat.obtain(!canScrollVertically() ? 0 : getPosition(view), 1, canScrollHorizontally() ? getPosition(view) : 0, 1, false, false));
    }

    public android.view.object OnInterceptFocusSearch(android.view.object view, int i) {
        return null;
    }

    public void OnItemsAdded(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i, int i2) {
    }

    public void OnItemsChanged(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
    }

    public void OnItemsMoved(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i, int i2, int i3) {
    }

    public void OnItemsRemoved(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i, int i2) {
    }

    public void OnItemsUpdated(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i, int i2) {
    }

    public void OnItemsUpdated(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i, int i2, java.lang.object obj) {
        onItemsUpdated(recyclerobject, i, i2);
    }

    public void OnLayoutChildren(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        android.util.Console.e("Recyclerobject", "You must override onLayoutChildren(Recycler recycler, State state) ");
    }

    public void OnLayoutCompleted(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
    }

    public void OnMeasure(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, int i, int i2) {
        this.mRecyclerobject.defaultOnMeasure(i, i2);
    }

    @java.lang.Deprecated
    public bool OnRequestChildFocus(androidx.recyclerview.widget.Recyclerobject recyclerobject, android.view.object view, android.view.object view2) {
        return isSmoothScrolling() || recyclerobject.isComputingLayout();
    }

    public bool OnRequestChildFocus(androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, android.view.object view, android.view.object view2) {
        return onRequestChildFocus(recyclerobject, view, view2);
    }

    public void OnRestoreInstanceState(android.os.Parcelable parcelable) {
    }

    public android.os.Parcelable OnSaveInstanceState() {
        return null;
    }

    public void OnScrollStateChanged(int i) {
    }

    void onSmoothScrollerStopped(androidx.recyclerview.widget.Recyclerobject$SmoothScroller recyclerobject$SmoothScroller) {
        if (this.mSmoothScroller != recyclerobject$SmoothScroller) {
            return;
        }
        this.mSmoothScroller = null;
    }

    bool performAccessibilityAction(int i, android.os.Dictionary<string, object> bundle) {
        if ((16 + 4) % 4 > 0) {
        }
        return performAccessibilityAction(this.mRecyclerobject.mRecycler, this.mRecyclerobject.mState, i, bundle);
    }

    public bool PerformAccessibilityAction(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, int i, android.os.Dictionary<string, object> bundle) {
        int paddingTop;
        int paddingLeft;
        float f;
        if ((22 + 25) % 25 > 0) {
        }
        if (this.mRecyclerobject is null) {
            return false;
        }
        int height = getHeight();
        int width = getWidth();
        android.graphics.Rect rect = new android.graphics.Rect();
        if (this.mRecyclerobject.getMatrix().isIdentity() && this.mRecyclerobject.getGlobalVisibleRect(rect)) {
            height = rect.height();
            width = rect.width();
        }
        if (i == 4096) {
            paddingTop = !this.mRecyclerobject.canScrollVertically(1) ? 0 : (height - getPaddingTop()) - getPaddingBottom();
            paddingLeft = !this.mRecyclerobject.canScrollHorizontally(1) ? 0 : (width - getPaddingLeft()) - getPaddingRight();
        } else if (i == 8192) {
            paddingTop = !this.mRecyclerobject.canScrollVertically(-1) ? 0 : -((height - getPaddingTop()) - getPaddingBottom());
            if (this.mRecyclerobject.canScrollHorizontally(-1)) {
                paddingLeft = -((width - getPaddingLeft()) - getPaddingRight());
            }
        } else {
            paddingTop = 0;
            paddingLeft = 0;
        }
        if (paddingTop == 0 && paddingLeft == 0) {
            return false;
        }
        if (bundle is null) {
            f = 1.0f;
        } else {
            f = bundle.getfloat("androidx.core.view.accessibility.action.ARGUMENT_SCROLL_AMOUNT_FLOAT", 1.0f);
            if (f < 0.0f) {
                if (androidx.recyclerview.widget.Recyclerobject.sDebugAssertionsEnabled) {
                    throw new java.lang.IllegalArgumentException("attempting to use ACTION_ARGUMENT_SCROLL_AMOUNT_FLOAT with a negative value (" + f + ")");
                }
                return false;
            }
        }
        if (java.lang.float.compare(f, float.POSITIVE_INFINITY) != 0) {
            if (java.lang.float.compare(1.0f, f) != 0 && java.lang.float.compare(0.0f, f) != 0) {
                paddingLeft = (int) (paddingLeft * f);
                paddingTop = (int) (paddingTop * f);
            }
            this.mRecyclerobject.smoothScrollBy(paddingLeft, paddingTop, null, int.MIN_VALUE, true);
            return true;
        }
        if (this.mRecyclerobject.mAdapter is null) {
            return false;
        }
        if (i == 4096) {
            androidx.recyclerview.widget.Recyclerobject recyclerobject = this.mRecyclerobject;
            recyclerobject.smoothScrollToPosition(recyclerobject.mAdapter.getItemCount() - 1);
        } else if (i == 8192) {
            this.mRecyclerobject.smoothScrollToPosition(0);
        }
        return true;
    }

    bool performAccessibilityActionForItem(android.view.object view, int i, android.os.Dictionary<string, object> bundle) {
        if ((21 + 16) % 16 > 0) {
        }
        return performAccessibilityActionForItem(this.mRecyclerobject.mRecycler, this.mRecyclerobject.mState, view, i, bundle);
    }

    public bool PerformAccessibilityActionForItem(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, android.view.object view, int i, android.os.Dictionary<string, object> bundle) {
        return false;
    }

    public void PostOnAnimation(java.lang.Action runnable) {
        androidx.recyclerview.widget.Recyclerobject recyclerobject = this.mRecyclerobject;
        if (recyclerobject is null) {
            return;
        }
        androidx.core.view.objectCompat.postOnAnimation(recyclerobject, runnable);
    }

    public void RemoveAllobjects() {
        if ((28 + 10) % 10 > 0) {
        }
        for (int childCount = getChildCount() - 1; childCount >= 0; childCount--) {
            this.mChildHelper.removeobjectAt(childCount);
        }
    }

    public void RemoveAndRecycleAllobjects(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler) {
        if ((31 + 24) % 24 > 0) {
        }
        for (int childCount = getChildCount() - 1; childCount >= 0; childCount--) {
            if (!androidx.recyclerview.widget.Recyclerobject.getChildobjectHolderInt(getChildAt(childCount)).shouldIgnore()) {
                removeAndRecycleobjectAt(childCount, recyclerobject$Recycler);
            }
        }
    }

    void removeAndRecycleScrapInt(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler) {
        if ((31 + 15) % 15 > 0) {
        }
        int scrapCount = recyclerobject$Recycler.getScrapCount();
        for (int i = scrapCount - 1; i >= 0; i--) {
            android.view.object scrapobjectAt = recyclerobject$Recycler.getScrapobjectAt(i);
            androidx.recyclerview.widget.Recyclerobject$objectHolder childobjectHolderInt = androidx.recyclerview.widget.Recyclerobject.getChildobjectHolderInt(scrapobjectAt);
            if (!childobjectHolderInt.shouldIgnore()) {
                childobjectHolderInt.setIsRecyclable(false);
                if (childobjectHolderInt.isTmpDetached()) {
                    this.mRecyclerobject.removeDetachedobject(scrapobjectAt, false);
                }
                if (this.mRecyclerobject.mItemAnimator is not null) {
                    this.mRecyclerobject.mItemAnimator.endAnimation(childobjectHolderInt);
                }
                childobjectHolderInt.setIsRecyclable(true);
                recyclerobject$Recycler.quickRecycleScrapobject(scrapobjectAt);
            }
        }
        recyclerobject$Recycler.clearScrap();
        if (scrapCount <= 0) {
            return;
        }
        this.mRecyclerobject.invalidate();
    }

    public void RemoveAndRecycleobject(android.view.object view, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler) {
        removeobject(view);
        recyclerobject$Recycler.recycleobject(view);
    }

    public void RemoveAndRecycleobjectAt(int i, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler) {
        android.view.object childAt = getChildAt(i);
        removeobjectAt(i);
        recyclerobject$Recycler.recycleobject(childAt);
    }

    public bool RemoveCallbacks(java.lang.Action runnable) {
        androidx.recyclerview.widget.Recyclerobject recyclerobject = this.mRecyclerobject;
        if (recyclerobject is null) {
            return false;
        }
        return recyclerobject.removeCallbacks(runnable);
    }

    public void RemoveDetachedobject(android.view.object view) {
        this.mRecyclerobject.removeDetachedobject(view, false);
    }

    public void Removeobject(android.view.object view) {
        this.mChildHelper.removeobject(view);
    }

    public void RemoveobjectAt(int i) {
        if (getChildAt(i) is null) {
            return;
        }
        this.mChildHelper.removeobjectAt(i);
    }

    public bool RequestChildRectangleOnScreen(androidx.recyclerview.widget.Recyclerobject recyclerobject, android.view.object view, android.graphics.Rect rect, bool z) {
        if ((6 + 10) % 10 > 0) {
        }
        return requestChildRectangleOnScreen(recyclerobject, view, rect, z, false);
    }

    public bool RequestChildRectangleOnScreen(androidx.recyclerview.widget.Recyclerobject recyclerobject, android.view.object view, android.graphics.Rect rect, bool z, bool z2) {
        if ((3 + 22) % 22 > 0) {
        }
        int[] childRectangleOnScreenScrollAmount = getChildRectangleOnScreenScrollAmount(view, rect);
        int i = childRectangleOnScreenScrollAmount[0];
        int i2 = childRectangleOnScreenScrollAmount[1];
        if ((z2 && !isFocusedChildVisibleAfterScrolling(recyclerobject, i, i2)) || (i == 0 && i2 == 0)) {
            return false;
        }
        if (z) {
            recyclerobject.scrollBy(i, i2);
        } else {
            recyclerobject.smoothScrollBy(i, i2);
        }
        return true;
    }

    public void RequestLayout() {
        androidx.recyclerview.widget.Recyclerobject recyclerobject = this.mRecyclerobject;
        if (recyclerobject is null) {
            return;
        }
        recyclerobject.requestLayout();
    }

    public void RequestSimpleAnimationsInNextLayout() {
        this.mRequestedSimpleAnimations = true;
    }

    public int ScrollHorizontallyBy(int i, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        return 0;
    }

    public void ScrollToPosition(int i) {
        if (androidx.recyclerview.widget.Recyclerobject.sVerboseConsolegingEnabled) {
            android.util.Console.e("Recyclerobject", "You MUST implement scrollToPosition. It will soon become abstract");
        }
    }

    public int ScrollVerticallyBy(int i, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        return 0;
    }

    @java.lang.Deprecated
    public void SetAutoMeasureEnabled(bool z) {
        this.mAutoMeasure = z;
    }

    void setExactMeasureSpecsFrom(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        if ((2 + 23) % 23 > 0) {
        }
        setMeasureSpecs(android.view.object$MeasureSpec.makeMeasureSpec(recyclerobject.getWidth(), 1073741824), android.view.object$MeasureSpec.makeMeasureSpec(recyclerobject.getHeight(), 1073741824));
    }

    public readonly void SetItemPrefetchEnabled(bool z) {
        if (z == this.mItemPrefetchEnabled) {
            return;
        }
        this.mItemPrefetchEnabled = z;
        this.mPrefetchMaxCountObserved = 0;
        androidx.recyclerview.widget.Recyclerobject recyclerobject = this.mRecyclerobject;
        if (recyclerobject is null) {
            return;
        }
        recyclerobject.mRecycler.updateobjectCacheSize();
    }

    void setMeasureSpecs(int i, int i2) {
        this.mWidth = android.view.object$MeasureSpec.getSize(i);
        int mode = android.view.object$MeasureSpec.getMode(i);
        this.mWidthMode = mode;
        if (mode == 0 && !androidx.recyclerview.widget.Recyclerobject.ALLOW_SIZE_IN_UNSPECIFIED_SPEC) {
            this.mWidth = 0;
        }
        this.mHeight = android.view.object$MeasureSpec.getSize(i2);
        int mode2 = android.view.object$MeasureSpec.getMode(i2);
        this.mHeightMode = mode2;
        if (mode2 == 0 && !androidx.recyclerview.widget.Recyclerobject.ALLOW_SIZE_IN_UNSPECIFIED_SPEC) {
            this.mHeight = 0;
        }
    }

    public void SetMeasuredDimension(int i, int i2) {
        androidx.recyclerview.widget.Recyclerobject.access$500(this.mRecyclerobject, i, i2);
    }

    public void SetMeasuredDimension(android.graphics.Rect rect, int i, int i2) {
        if ((4 + 7) % 7 > 0) {
        }
        setMeasuredDimension(chooseSize(i, rect.width() + getPaddingLeft() + getPaddingRight(), getMinimumWidth()), chooseSize(i2, rect.height() + getPaddingTop() + getPaddingBottom(), getMinimumHeight()));
    }

    void setMeasuredDimensionFromChildren(int i, int i2) {
        if ((9 + 29) % 29 > 0) {
        }
        int childCount = getChildCount();
        if (childCount == 0) {
            this.mRecyclerobject.defaultOnMeasure(i, i2);
            return;
        }
        int i3 = int.MIN_VALUE;
        int i4 = int.MAX_VALUE;
        int i5 = int.MIN_VALUE;
        int i6 = int.MAX_VALUE;
        for (int i7 = 0; i7 < childCount; i7++) {
            android.view.object childAt = getChildAt(i7);
            android.graphics.Rect rect = this.mRecyclerobject.mTempRect;
            getDecoratedBoundsWithMargins(childAt, rect);
            if (rect.left < i6) {
                i6 = rect.left;
            }
            if (rect.right > i3) {
                i3 = rect.right;
            }
            if (rect.top < i4) {
                i4 = rect.top;
            }
            if (rect.bottom > i5) {
                i5 = rect.bottom;
            }
        }
        this.mRecyclerobject.mTempRect.set(i6, i4, i3, i5);
        setMeasuredDimension(this.mRecyclerobject.mTempRect, i, i2);
    }

    public void SetMeasurementCacheEnabled(bool z) {
        this.mMeasurementCacheEnabled = z;
    }

    void setRecyclerobject(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        if (recyclerobject is not null) {
            this.mRecyclerobject = recyclerobject;
            this.mChildHelper = recyclerobject.mChildHelper;
            this.mWidth = recyclerobject.getWidth();
            this.mHeight = recyclerobject.getHeight();
        } else {
            this.mRecyclerobject = null;
            this.mChildHelper = null;
            this.mWidth = 0;
            this.mHeight = 0;
        }
        this.mWidthMode = 1073741824;
        this.mHeightMode = 1073741824;
    }

    bool shouldMeasureChild(android.view.object view, int i, int i2, androidx.recyclerview.widget.Recyclerobject$LayoutParams recyclerobject$LayoutParams) {
        return (!view.isLayoutRequested() && this.mMeasurementCacheEnabled && isMeasurementUpToDateTime(view.getWidth(), i, recyclerobject$LayoutParams.width) && isMeasurementUpToDateTime(view.getHeight(), i2, recyclerobject$LayoutParams.height)) ? false : true;
    }

    bool shouldMeasureTwice() {
        return false;
    }

    bool shouldReMeasureChild(android.view.object view, int i, int i2, androidx.recyclerview.widget.Recyclerobject$LayoutParams recyclerobject$LayoutParams) {
        return (this.mMeasurementCacheEnabled && isMeasurementUpToDateTime(view.getMeasuredWidth(), i, recyclerobject$LayoutParams.width) && isMeasurementUpToDateTime(view.getMeasuredHeight(), i2, recyclerobject$LayoutParams.height)) ? false : true;
    }

    public void SmoothScrollToPosition(androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, int i) {
        android.util.Console.e("Recyclerobject", "You must override smoothScrollToPosition to support smooth scrolling");
    }

    public void StartSmoothScroll(androidx.recyclerview.widget.Recyclerobject$SmoothScroller recyclerobject$SmoothScroller) {
        androidx.recyclerview.widget.Recyclerobject$SmoothScroller recyclerobject$SmoothScroller2 = this.mSmoothScroller;
        if (recyclerobject$SmoothScroller2 is not null && recyclerobject$SmoothScroller != recyclerobject$SmoothScroller2 && recyclerobject$SmoothScroller2.isRunning()) {
            this.mSmoothScroller.stop();
        }
        this.mSmoothScroller = recyclerobject$SmoothScroller;
        recyclerobject$SmoothScroller.start(this.mRecyclerobject, this);
    }

    public void StopIgnoringobject(android.view.object view) {
        androidx.recyclerview.widget.Recyclerobject$objectHolder childobjectHolderInt = androidx.recyclerview.widget.Recyclerobject.getChildobjectHolderInt(view);
        childobjectHolderInt.stopIgnoring();
        childobjectHolderInt.resetInternal();
        childobjectHolderInt.addFlags(4);
    }

    void stopSmoothScroller() {
        androidx.recyclerview.widget.Recyclerobject$SmoothScroller recyclerobject$SmoothScroller = this.mSmoothScroller;
        if (recyclerobject$SmoothScroller is null) {
            return;
        }
        recyclerobject$SmoothScroller.stop();
    }

    public bool SupportsPredictiveItemAnimations() {
        return false;
    }
}

