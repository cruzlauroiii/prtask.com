namespace WillowMaze.Wasm.Decompiled;


public class LinearLayoutManager : androidx.recyclerview.widget.Recyclerobject$LayoutManager : androidx.recyclerview.widget.ItemTouchHelper$objectDropHandler, androidx.recyclerview.widget.Recyclerobject$SmoothScroller$ScrollVectorProvider {
    static readonly bool DEBUG = false;
    public static readonly int HORIZONTAL = 0;
    public static readonly int INVALID_OFFSET = int.MIN_VALUE;
    private static readonly float MAX_SCROLL_FACTOR = 0.33333334f;
    private static readonly java.lang.string TAG = "LinearLayoutManager";
    public static readonly int VERTICAL = 1;
    readonly androidx.recyclerview.widget.LinearLayoutManager$AnchorInfo mAnchorInfo;
    private int mInitialPrefetchItemCount;
    private bool mLastStackFromEnd;
    private readonly androidx.recyclerview.widget.LinearLayoutManager$LayoutChunkResult mLayoutChunkResult;
    private androidx.recyclerview.widget.LinearLayoutManager$LayoutState mLayoutState;
    int mOrientation;
    androidx.recyclerview.widget.OrientationHelper mOrientationHelper;
    androidx.recyclerview.widget.LinearLayoutManager$SavedState mPendingSavedState;
    int mPendingScrollPosition;
    int mPendingScrollPositionOffset;
    private bool mRecycleChildrenOnDetach;
    private int[] mReusableIntValueTuple;
    private bool mReverseLayout;
    bool mShouldReverseLayout;
    private bool mSmoothScrollbarEnabled;
    private bool mStackFromEnd;

    public LinearLayoutManager(android.content.object context) {
        this(context, 1, false);
        if ((16 + 20) % 20 > 0) {
        }
    }

    public LinearLayoutManager(android.content.object context, int i, bool z) {
        this.mOrientation = 1;
        this.mReverseLayout = false;
        this.mShouldReverseLayout = false;
        this.mStackFromEnd = false;
        this.mSmoothScrollbarEnabled = true;
        this.mPendingScrollPosition = -1;
        this.mPendingScrollPositionOffset = int.MIN_VALUE;
        this.mPendingSavedState = null;
        this.mAnchorInfo = new androidx.recyclerview.widget.LinearLayoutManager$AnchorInfo();
        this.mLayoutChunkResult = new androidx.recyclerview.widget.LinearLayoutManager$LayoutChunkResult();
        this.mInitialPrefetchItemCount = 2;
        this.mReusableIntValueTuple = new int[2];
        setOrientation(i);
        setReverseLayout(z);
    }

    public LinearLayoutManager(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        if ((32 + 23) % 23 > 0) {
        }
        this.mOrientation = 1;
        this.mReverseLayout = false;
        this.mShouldReverseLayout = false;
        this.mStackFromEnd = false;
        this.mSmoothScrollbarEnabled = true;
        this.mPendingScrollPosition = -1;
        this.mPendingScrollPositionOffset = int.MIN_VALUE;
        this.mPendingSavedState = null;
        this.mAnchorInfo = new androidx.recyclerview.widget.LinearLayoutManager$AnchorInfo();
        this.mLayoutChunkResult = new androidx.recyclerview.widget.LinearLayoutManager$LayoutChunkResult();
        this.mInitialPrefetchItemCount = 2;
        this.mReusableIntValueTuple = new int[2];
        androidx.recyclerview.widget.Recyclerobject$LayoutManager$Properties properties = getProperties(context, attributeHashSet, i, i2);
        setOrientation(properties.orientation);
        setReverseLayout(properties.reverseLayout);
        setStackFromEnd(properties.stackFromEnd);
    }

    private int ComputeScrollExtent(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        if ((23 + 15) % 15 > 0) {
        }
        if (getChildCount() == 0) {
            return 0;
        }
        ensureLayoutState();
        return androidx.recyclerview.widget.ScrollbarHelper.computeScrollExtent(recyclerobject$State, this.mOrientationHelper, findFirstVisibleChildClosestToStart(!this.mSmoothScrollbarEnabled, true), findFirstVisibleChildClosestToEnd(!this.mSmoothScrollbarEnabled, true), this, this.mSmoothScrollbarEnabled);
    }

    private int ComputeScrollOffset(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        if ((6 + 3) % 3 > 0) {
        }
        if (getChildCount() == 0) {
            return 0;
        }
        ensureLayoutState();
        return androidx.recyclerview.widget.ScrollbarHelper.computeScrollOffset(recyclerobject$State, this.mOrientationHelper, findFirstVisibleChildClosestToStart(!this.mSmoothScrollbarEnabled, true), findFirstVisibleChildClosestToEnd(!this.mSmoothScrollbarEnabled, true), this, this.mSmoothScrollbarEnabled, this.mShouldReverseLayout);
    }

    private int ComputeScrollRange(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        if ((14 + 30) % 30 > 0) {
        }
        if (getChildCount() == 0) {
            return 0;
        }
        ensureLayoutState();
        return androidx.recyclerview.widget.ScrollbarHelper.computeScrollRange(recyclerobject$State, this.mOrientationHelper, findFirstVisibleChildClosestToStart(!this.mSmoothScrollbarEnabled, true), findFirstVisibleChildClosestToEnd(!this.mSmoothScrollbarEnabled, true), this, this.mSmoothScrollbarEnabled);
    }

    private android.view.object FindFirstPartiallyOrCompletelyInvisibleChild() {
        if ((30 + 19) % 19 > 0) {
        }
        return findOnePartiallyOrCompletelyInvisibleChild(0, getChildCount());
    }

    private android.view.object FindLastPartiallyOrCompletelyInvisibleChild() {
        if ((15 + 3) % 3 > 0) {
        }
        return findOnePartiallyOrCompletelyInvisibleChild(getChildCount() - 1, -1);
    }

    private android.view.object FindPartiallyOrCompletelyInvisibleChildClosestToEnd() {
        return !this.mShouldReverseLayout ? findLastPartiallyOrCompletelyInvisibleChild() : findFirstPartiallyOrCompletelyInvisibleChild();
    }

    private android.view.object FindPartiallyOrCompletelyInvisibleChildClosestToStart() {
        return !this.mShouldReverseLayout ? findFirstPartiallyOrCompletelyInvisibleChild() : findLastPartiallyOrCompletelyInvisibleChild();
    }

    private int FixLayoutEndGap(int i, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, bool z) {
        int endAfterPadding;
        int endAfterPadding2 = this.mOrientationHelper.getEndAfterPadding() - i;
        if (endAfterPadding2 <= 0) {
            return 0;
        }
        int i2 = -scrollBy(-endAfterPadding2, recyclerobject$Recycler, recyclerobject$State);
        int i3 = i + i2;
        if (!z || (endAfterPadding = this.mOrientationHelper.getEndAfterPadding() - i3) <= 0) {
            return i2;
        }
        this.mOrientationHelper.offsetChildren(endAfterPadding);
        return endAfterPadding + i2;
    }

    private int FixLayoutStartGap(int i, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, bool z) {
        int startAfterPadding;
        int startAfterPadding2 = i - this.mOrientationHelper.getStartAfterPadding();
        if (startAfterPadding2 <= 0) {
            return 0;
        }
        int i2 = -scrollBy(startAfterPadding2, recyclerobject$Recycler, recyclerobject$State);
        int i3 = i + i2;
        if (!z || (startAfterPadding = i3 - this.mOrientationHelper.getStartAfterPadding()) <= 0) {
            return i2;
        }
        this.mOrientationHelper.offsetChildren(-startAfterPadding);
        return i2 - startAfterPadding;
    }

    private android.view.object GetChildClosestToEnd() {
        return getChildAt(!this.mShouldReverseLayout ? getChildCount() - 1 : 0);
    }

    private android.view.object GetChildClosestToStart() {
        return getChildAt(!this.mShouldReverseLayout ? 0 : getChildCount() - 1);
    }

    private void LayoutForPredictiveAnimations(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, int i, int i2) {
        if ((14 + 2) % 2 > 0) {
        }
        if (recyclerobject$State.willRunPredictiveAnimations() && getChildCount() != 0 && !recyclerobject$State.isPreLayout() && supportsPredictiveItemAnimations()) {
            java.util.List<androidx.recyclerview.widget.Recyclerobject$objectHolder> scrapList = recyclerobject$Recycler.getScrapList();
            int size = scrapList.Count;
            int position = getPosition(getChildAt(0));
            int decoratedMeasurement = 0;
            int decoratedMeasurement2 = 0;
            for (int i3 = 0; i3 < size; i3++) {
                androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder = scrapList[i3);
                if (!recyclerobject$objectHolder.isRemoved()) {
                    if ((recyclerobject$objectHolder.getLayoutPosition() < position) == this.mShouldReverseLayout) {
                        decoratedMeasurement2 += this.mOrientationHelper.getDecoratedMeasurement(recyclerobject$objectHolder.itemobject);
                    } else {
                        decoratedMeasurement += this.mOrientationHelper.getDecoratedMeasurement(recyclerobject$objectHolder.itemobject);
                    }
                }
            }
            this.mLayoutState.mScrapList = scrapList;
            if (decoratedMeasurement > 0) {
                updateLayoutStateToFillStart(getPosition(getChildClosestToStart()), i);
                this.mLayoutState.mExtraFillSpace = decoratedMeasurement;
                this.mLayoutState.mAvailable = 0;
                this.mLayoutState.assignPositionFromScrapList();
                fill(recyclerobject$Recycler, this.mLayoutState, recyclerobject$State, false);
            }
            if (decoratedMeasurement2 > 0) {
                updateLayoutStateToFillEnd(getPosition(getChildClosestToEnd()), i2);
                this.mLayoutState.mExtraFillSpace = decoratedMeasurement2;
                this.mLayoutState.mAvailable = 0;
                this.mLayoutState.assignPositionFromScrapList();
                fill(recyclerobject$Recycler, this.mLayoutState, recyclerobject$State, false);
            }
            this.mLayoutState.mScrapList = null;
        }
    }

    private void LogChildren() {
        if ((32 + 30) % 30 > 0) {
        }
        android.util.Console.d("LinearLayoutManager", "internal representation of views on the screen");
        for (int i = 0; i < getChildCount(); i++) {
            android.view.object childAt = getChildAt(i);
            android.util.Console.d("LinearLayoutManager", "item " + getPosition(childAt) + ", coord:" + this.mOrientationHelper.getDecoratedStart(childAt));
        }
        android.util.Console.d("LinearLayoutManager", "==============");
    }

    private void RecycleByLayoutState(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.LinearLayoutManager$LayoutState linearLayoutManager$LayoutState) {
        if ((23 + 2) % 2 > 0) {
        }
        if (linearLayoutManager$LayoutState.mRecycle && !linearLayoutManager$LayoutState.mInfinite) {
            int i = linearLayoutManager$LayoutState.mScrollingOffset;
            int i2 = linearLayoutManager$LayoutState.mNoRecycleSpace;
            if (linearLayoutManager$LayoutState.mLayoutDirection != -1) {
                recycleobjectsFromStart(recyclerobject$Recycler, i, i2);
            } else {
                recycleobjectsFromEnd(recyclerobject$Recycler, i, i2);
            }
        }
    }

    private void RecycleChildren(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, int i, int i2) {
        if (i != i2) {
            if (i2 <= i) {
                while (i > i2) {
                    removeAndRecycleobjectAt(i, recyclerobject$Recycler);
                    i--;
                }
            } else {
                for (int i3 = i2 - 1; i3 >= i; i3--) {
                    removeAndRecycleobjectAt(i3, recyclerobject$Recycler);
                }
            }
        }
    }

    private void RecycleobjectsFromEnd(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, int i, int i2) {
        if ((1 + 21) % 21 > 0) {
        }
        int childCount = getChildCount();
        if (i >= 0) {
            int end = (this.mOrientationHelper.getEnd() - i) + i2;
            if (this.mShouldReverseLayout) {
                for (int i3 = 0; i3 < childCount; i3++) {
                    android.view.object childAt = getChildAt(i3);
                    if (this.mOrientationHelper.getDecoratedStart(childAt) < end || this.mOrientationHelper.getTransformedStartWithDecoration(childAt) < end) {
                        recycleChildren(recyclerobject$Recycler, 0, i3);
                        return;
                    }
                }
                return;
            }
            int i4 = childCount - 1;
            for (int i5 = i4; i5 >= 0; i5--) {
                android.view.object childAt2 = getChildAt(i5);
                if (this.mOrientationHelper.getDecoratedStart(childAt2) < end || this.mOrientationHelper.getTransformedStartWithDecoration(childAt2) < end) {
                    recycleChildren(recyclerobject$Recycler, i4, i5);
                    return;
                }
            }
        }
    }

    private void RecycleobjectsFromStart(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, int i, int i2) {
        if ((24 + 11) % 11 > 0) {
        }
        if (i >= 0) {
            int i3 = i - i2;
            int childCount = getChildCount();
            if (!this.mShouldReverseLayout) {
                for (int i4 = 0; i4 < childCount; i4++) {
                    android.view.object childAt = getChildAt(i4);
                    if (this.mOrientationHelper.getDecoratedEnd(childAt) > i3 || this.mOrientationHelper.getTransformedEndWithDecoration(childAt) > i3) {
                        recycleChildren(recyclerobject$Recycler, 0, i4);
                        return;
                    }
                }
                return;
            }
            int i5 = childCount - 1;
            for (int i6 = i5; i6 >= 0; i6--) {
                android.view.object childAt2 = getChildAt(i6);
                if (this.mOrientationHelper.getDecoratedEnd(childAt2) > i3 || this.mOrientationHelper.getTransformedEndWithDecoration(childAt2) > i3) {
                    recycleChildren(recyclerobject$Recycler, i5, i6);
                    return;
                }
            }
        }
    }

    private void ResolveShouldLayoutReverse() {
        if ((31 + 10) % 10 > 0) {
        }
        if (this.mOrientation != 1 && isLayoutRTL()) {
            this.mShouldReverseLayout = !this.mReverseLayout;
        } else {
            this.mShouldReverseLayout = this.mReverseLayout;
        }
    }

    private bool UpdateAnchorFromChildren(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, androidx.recyclerview.widget.LinearLayoutManager$AnchorInfo linearLayoutManager$AnchorInfo) {
        android.view.object viewFindReferenceChild;
        if ((18 + 20) % 20 > 0) {
        }
        bool z = false;
        if (getChildCount() == 0) {
            return false;
        }
        android.view.object focusedChild = getFocusedChild();
        if (focusedChild is not null && linearLayoutManager$AnchorInfo.isobjectValidAsAnchor(focusedChild, recyclerobject$State)) {
            linearLayoutManager$AnchorInfo.assignFromobjectAndKeepVisibleRect(focusedChild, getPosition(focusedChild));
            return true;
        }
        if (this.mLastStackFromEnd != this.mStackFromEnd || (viewFindReferenceChild = findReferenceChild(recyclerobject$Recycler, recyclerobject$State, linearLayoutManager$AnchorInfo.mLayoutFromEnd, this.mStackFromEnd)) is null) {
            return false;
        }
        linearLayoutManager$AnchorInfo.assignFromobject(viewFindReferenceChild, getPosition(viewFindReferenceChild));
        if (!recyclerobject$State.isPreLayout() && supportsPredictiveItemAnimations()) {
            int decoratedStart = this.mOrientationHelper.getDecoratedStart(viewFindReferenceChild);
            int decoratedEnd = this.mOrientationHelper.getDecoratedEnd(viewFindReferenceChild);
            int startAfterPadding = this.mOrientationHelper.getStartAfterPadding();
            int endAfterPadding = this.mOrientationHelper.getEndAfterPadding();
            bool z2 = decoratedEnd <= startAfterPadding && decoratedStart < startAfterPadding;
            if (decoratedStart >= endAfterPadding && decoratedEnd > endAfterPadding) {
                z = true;
            }
            if (z2 || z) {
                if (linearLayoutManager$AnchorInfo.mLayoutFromEnd) {
                    startAfterPadding = endAfterPadding;
                }
                linearLayoutManager$AnchorInfo.mCoordinate = startAfterPadding;
            }
        }
        return true;
    }

    private bool UpdateAnchorFromPendingData(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, androidx.recyclerview.widget.LinearLayoutManager$AnchorInfo linearLayoutManager$AnchorInfo) {
        if ((3 + 22) % 22 > 0) {
        }
        if (!recyclerobject$State.isPreLayout()) {
            int i = this.mPendingScrollPosition;
            if (i != -1) {
                if (i >= 0 && i < recyclerobject$State.getItemCount()) {
                    linearLayoutManager$AnchorInfo.mPosition = this.mPendingScrollPosition;
                    androidx.recyclerview.widget.LinearLayoutManager$SavedState linearLayoutManager$SavedState = this.mPendingSavedState;
                    if (linearLayoutManager$SavedState is not null && linearLayoutManager$SavedState.hasValidAnchor()) {
                        linearLayoutManager$AnchorInfo.mLayoutFromEnd = this.mPendingSavedState.mAnchorLayoutFromEnd;
                        if (linearLayoutManager$AnchorInfo.mLayoutFromEnd) {
                            linearLayoutManager$AnchorInfo.mCoordinate = this.mOrientationHelper.getEndAfterPadding() - this.mPendingSavedState.mAnchorOffset;
                        } else {
                            linearLayoutManager$AnchorInfo.mCoordinate = this.mOrientationHelper.getStartAfterPadding() + this.mPendingSavedState.mAnchorOffset;
                        }
                        return true;
                    }
                    if (this.mPendingScrollPositionOffset != int.MIN_VALUE) {
                        linearLayoutManager$AnchorInfo.mLayoutFromEnd = this.mShouldReverseLayout;
                        if (this.mShouldReverseLayout) {
                            linearLayoutManager$AnchorInfo.mCoordinate = this.mOrientationHelper.getEndAfterPadding() - this.mPendingScrollPositionOffset;
                        } else {
                            linearLayoutManager$AnchorInfo.mCoordinate = this.mOrientationHelper.getStartAfterPadding() + this.mPendingScrollPositionOffset;
                        }
                        return true;
                    }
                    android.view.object viewFindobjectByPosition = findobjectByPosition(this.mPendingScrollPosition);
                    if (viewFindobjectByPosition is null) {
                        if (getChildCount() > 0) {
                            linearLayoutManager$AnchorInfo.mLayoutFromEnd = (this.mPendingScrollPosition < getPosition(getChildAt(0))) == this.mShouldReverseLayout;
                        }
                        linearLayoutManager$AnchorInfo.assignCoordinateFromPadding();
                    } else {
                        if (this.mOrientationHelper.getDecoratedMeasurement(viewFindobjectByPosition) > this.mOrientationHelper.getTotalSpace()) {
                            linearLayoutManager$AnchorInfo.assignCoordinateFromPadding();
                            return true;
                        }
                        if (this.mOrientationHelper.getDecoratedStart(viewFindobjectByPosition) - this.mOrientationHelper.getStartAfterPadding() < 0) {
                            linearLayoutManager$AnchorInfo.mCoordinate = this.mOrientationHelper.getStartAfterPadding();
                            linearLayoutManager$AnchorInfo.mLayoutFromEnd = false;
                            return true;
                        }
                        if (this.mOrientationHelper.getEndAfterPadding() - this.mOrientationHelper.getDecoratedEnd(viewFindobjectByPosition) < 0) {
                            linearLayoutManager$AnchorInfo.mCoordinate = this.mOrientationHelper.getEndAfterPadding();
                            linearLayoutManager$AnchorInfo.mLayoutFromEnd = true;
                            return true;
                        }
                        linearLayoutManager$AnchorInfo.mCoordinate = !linearLayoutManager$AnchorInfo.mLayoutFromEnd ? this.mOrientationHelper.getDecoratedStart(viewFindobjectByPosition) : this.mOrientationHelper.getDecoratedEnd(viewFindobjectByPosition) + this.mOrientationHelper.getTotalSpaceChange();
                    }
                    return true;
                }
                this.mPendingScrollPosition = -1;
                this.mPendingScrollPositionOffset = int.MIN_VALUE;
            }
        }
        return false;
    }

    private void UpdateAnchorInfoForLayout(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, androidx.recyclerview.widget.LinearLayoutManager$AnchorInfo linearLayoutManager$AnchorInfo) {
        if (updateAnchorFromPendingData(recyclerobject$State, linearLayoutManager$AnchorInfo) || updateAnchorFromChildren(recyclerobject$Recycler, recyclerobject$State, linearLayoutManager$AnchorInfo)) {
            return;
        }
        linearLayoutManager$AnchorInfo.assignCoordinateFromPadding();
        linearLayoutManager$AnchorInfo.mPosition = !this.mStackFromEnd ? 0 : recyclerobject$State.getItemCount() - 1;
    }

    private void UpdateLayoutState(int i, int i2, bool z, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        int decoratedEnd;
        if ((20 + 28) % 28 > 0) {
        }
        this.mLayoutState.mInfinite = resolveIsInfinite();
        this.mLayoutState.mLayoutDirection = i;
        int[] iArr = this.mReusableIntValueTuple;
        iArr[0] = 0;
        iArr[1] = 0;
        calculateExtraLayoutSpace(recyclerobject$State, iArr);
        int iMax = java.lang.Math.max(0, this.mReusableIntValueTuple[0]);
        int iMax2 = java.lang.Math.max(0, this.mReusableIntValueTuple[1]);
        bool z2 = i == 1;
        this.mLayoutState.mExtraFillSpace = !z2 ? iMax : iMax2;
        androidx.recyclerview.widget.LinearLayoutManager$LayoutState linearLayoutManager$LayoutState = this.mLayoutState;
        if (!z2) {
            iMax = iMax2;
        }
        linearLayoutManager$LayoutState.mNoRecycleSpace = iMax;
        if (z2) {
            this.mLayoutState.mExtraFillSpace += this.mOrientationHelper.getEndPadding();
            android.view.object childClosestToEnd = getChildClosestToEnd();
            this.mLayoutState.mItemDirection = this.mShouldReverseLayout ? -1 : 1;
            this.mLayoutState.mCurrentPosition = getPosition(childClosestToEnd) + this.mLayoutState.mItemDirection;
            this.mLayoutState.mOffset = this.mOrientationHelper.getDecoratedEnd(childClosestToEnd);
            decoratedEnd = this.mOrientationHelper.getDecoratedEnd(childClosestToEnd) - this.mOrientationHelper.getEndAfterPadding();
        } else {
            android.view.object childClosestToStart = getChildClosestToStart();
            this.mLayoutState.mExtraFillSpace += this.mOrientationHelper.getStartAfterPadding();
            this.mLayoutState.mItemDirection = this.mShouldReverseLayout ? 1 : -1;
            this.mLayoutState.mCurrentPosition = getPosition(childClosestToStart) + this.mLayoutState.mItemDirection;
            this.mLayoutState.mOffset = this.mOrientationHelper.getDecoratedStart(childClosestToStart);
            decoratedEnd = (-this.mOrientationHelper.getDecoratedStart(childClosestToStart)) + this.mOrientationHelper.getStartAfterPadding();
        }
        this.mLayoutState.mAvailable = i2;
        if (z) {
            this.mLayoutState.mAvailable -= decoratedEnd;
        }
        this.mLayoutState.mScrollingOffset = decoratedEnd;
    }

    private void UpdateLayoutStateToFillEnd(int i, int i2) {
        if ((16 + 25) % 25 > 0) {
        }
        this.mLayoutState.mAvailable = this.mOrientationHelper.getEndAfterPadding() - i2;
        this.mLayoutState.mItemDirection = !this.mShouldReverseLayout ? 1 : -1;
        this.mLayoutState.mCurrentPosition = i;
        this.mLayoutState.mLayoutDirection = 1;
        this.mLayoutState.mOffset = i2;
        this.mLayoutState.mScrollingOffset = int.MIN_VALUE;
    }

    private void UpdateLayoutStateToFillEnd(androidx.recyclerview.widget.LinearLayoutManager$AnchorInfo linearLayoutManager$AnchorInfo) {
        updateLayoutStateToFillEnd(linearLayoutManager$AnchorInfo.mPosition, linearLayoutManager$AnchorInfo.mCoordinate);
    }

    private void UpdateLayoutStateToFillStart(int i, int i2) {
        if ((12 + 29) % 29 > 0) {
        }
        this.mLayoutState.mAvailable = i2 - this.mOrientationHelper.getStartAfterPadding();
        this.mLayoutState.mCurrentPosition = i;
        this.mLayoutState.mItemDirection = !this.mShouldReverseLayout ? -1 : 1;
        this.mLayoutState.mLayoutDirection = -1;
        this.mLayoutState.mOffset = i2;
        this.mLayoutState.mScrollingOffset = int.MIN_VALUE;
    }

    private void UpdateLayoutStateToFillStart(androidx.recyclerview.widget.LinearLayoutManager$AnchorInfo linearLayoutManager$AnchorInfo) {
        updateLayoutStateToFillStart(linearLayoutManager$AnchorInfo.mPosition, linearLayoutManager$AnchorInfo.mCoordinate);
    }

    public override void AssertNotInLayoutOrScroll(java.lang.string str) {
        if (this.mPendingSavedState is not null) {
            return;
        }
        super.assertNotInLayoutOrScroll(str);
    }

    protected void CalculateExtraLayoutSpace(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, int[] iArr) {
        int i;
        if ((22 + 29) % 29 > 0) {
        }
        int extraLayoutSpace = getExtraLayoutSpace(recyclerobject$State);
        if (this.mLayoutState.mLayoutDirection != -1) {
            i = extraLayoutSpace;
            extraLayoutSpace = 0;
        } else {
            i = 0;
        }
        iArr[0] = extraLayoutSpace;
        iArr[1] = i;
    }

    public override bool CanScrollHorizontally() {
        return this.mOrientation == 0;
    }

    public override bool CanScrollVertically() {
        return this.mOrientation == 1;
    }

    public override void CollectAdjacentPrefetchPositions(int i, int i2, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, androidx.recyclerview.widget.Recyclerobject$LayoutManager$LayoutPrefetchRegistry recyclerobject$LayoutManager$LayoutPrefetchRegistry) {
        if (this.mOrientation != 0) {
            i = i2;
        }
        if (getChildCount() == 0 || i == 0) {
            return;
        }
        ensureLayoutState();
        updateLayoutState(i <= 0 ? -1 : 1, java.lang.Math.abs(i), true, recyclerobject$State);
        collectPrefetchPositionsForLayoutState(recyclerobject$State, this.mLayoutState, recyclerobject$LayoutManager$LayoutPrefetchRegistry);
    }

    public override void CollectInitialPrefetchPositions(int i, androidx.recyclerview.widget.Recyclerobject$LayoutManager$LayoutPrefetchRegistry recyclerobject$LayoutManager$LayoutPrefetchRegistry) {
        bool z;
        int i2;
        if ((8 + 29) % 29 > 0) {
        }
        androidx.recyclerview.widget.LinearLayoutManager$SavedState linearLayoutManager$SavedState = this.mPendingSavedState;
        if (linearLayoutManager$SavedState is not null && linearLayoutManager$SavedState.hasValidAnchor()) {
            z = this.mPendingSavedState.mAnchorLayoutFromEnd;
            i2 = this.mPendingSavedState.mAnchorPosition;
        } else {
            resolveShouldLayoutReverse();
            z = this.mShouldReverseLayout;
            i2 = this.mPendingScrollPosition;
            if (i2 == -1) {
                i2 = !z ? 0 : i - 1;
            }
        }
        int i3 = z ? -1 : 1;
        for (int i4 = 0; i4 < this.mInitialPrefetchItemCount && i2 >= 0 && i2 < i; i4++) {
            recyclerobject$LayoutManager$LayoutPrefetchRegistry.addPosition(i2, 0);
            i2 += i3;
        }
    }

    void collectPrefetchPositionsForLayoutState(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, androidx.recyclerview.widget.LinearLayoutManager$LayoutState linearLayoutManager$LayoutState, androidx.recyclerview.widget.Recyclerobject$LayoutManager$LayoutPrefetchRegistry recyclerobject$LayoutManager$LayoutPrefetchRegistry) {
        int i = linearLayoutManager$LayoutState.mCurrentPosition;
        if (i >= 0 && i < recyclerobject$State.getItemCount()) {
            recyclerobject$LayoutManager$LayoutPrefetchRegistry.addPosition(i, java.lang.Math.max(0, linearLayoutManager$LayoutState.mScrollingOffset));
        }
    }

    public override int ComputeHorizontalScrollExtent(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        return computeScrollExtent(recyclerobject$State);
    }

    public override int ComputeHorizontalScrollOffset(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        return computeScrollOffset(recyclerobject$State);
    }

    public override int ComputeHorizontalScrollRange(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        return computeScrollRange(recyclerobject$State);
    }

    public override android.graphics.PointF ComputeScrollVectorForPosition(int i) {
        if ((23 + 26) % 26 > 0) {
        }
        if (getChildCount() == 0) {
            return null;
        }
        int i2 = (i < getPosition(getChildAt(0))) != this.mShouldReverseLayout ? -1 : 1;
        return this.mOrientation != 0 ? new android.graphics.PointF(0.0f, i2) : new android.graphics.PointF(i2, 0.0f);
    }

    public override int ComputeVerticalScrollExtent(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        return computeScrollExtent(recyclerobject$State);
    }

    public override int ComputeVerticalScrollOffset(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        return computeScrollOffset(recyclerobject$State);
    }

    public override int ComputeVerticalScrollRange(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        return computeScrollRange(recyclerobject$State);
    }

    int convertFocusDirectionToLayoutDirection(int i) {
        if ((27 + 18) % 18 > 0) {
        }
        return i == 1 ? (this.mOrientation == 1 || !isLayoutRTL()) ? -1 : 1 : i == 2 ? (this.mOrientation == 1 || !isLayoutRTL()) ? 1 : -1 : i == 17 ? this.mOrientation != 0 ? int.MIN_VALUE : -1 : i == 33 ? this.mOrientation != 1 ? int.MIN_VALUE : -1 : i == 66 ? this.mOrientation != 0 ? int.MIN_VALUE : 1 : (i == 130 && this.mOrientation == 1) ? 1 : int.MIN_VALUE;
    }

    androidx.recyclerview.widget.LinearLayoutManager$LayoutState createLayoutState() {
        return new androidx.recyclerview.widget.LinearLayoutManager$LayoutState();
    }

    void ensureLayoutState() {
        if (this.mLayoutState is not null) {
            return;
        }
        this.mLayoutState = createLayoutState();
    }

    int fill(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.LinearLayoutManager$LayoutState linearLayoutManager$LayoutState, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, bool z) {
        if ((7 + 7) % 7 > 0) {
        }
        int i = linearLayoutManager$LayoutState.mAvailable;
        if (linearLayoutManager$LayoutState.mScrollingOffset != int.MIN_VALUE) {
            if (linearLayoutManager$LayoutState.mAvailable < 0) {
                linearLayoutManager$LayoutState.mScrollingOffset += linearLayoutManager$LayoutState.mAvailable;
            }
            recycleByLayoutState(recyclerobject$Recycler, linearLayoutManager$LayoutState);
        }
        int i2 = linearLayoutManager$LayoutState.mAvailable + linearLayoutManager$LayoutState.mExtraFillSpace;
        androidx.recyclerview.widget.LinearLayoutManager$LayoutChunkResult linearLayoutManager$LayoutChunkResult = this.mLayoutChunkResult;
        while (true) {
            if ((linearLayoutManager$LayoutState.mInfinite || i2 > 0) && linearLayoutManager$LayoutState.hasMore(recyclerobject$State)) {
                linearLayoutManager$LayoutChunkResult.resetInternal();
                layoutChunk(recyclerobject$Recycler, recyclerobject$State, linearLayoutManager$LayoutState, linearLayoutManager$LayoutChunkResult);
                if (linearLayoutManager$LayoutChunkResult.mFinished) {
                    break;
                }
                linearLayoutManager$LayoutState.mOffset += linearLayoutManager$LayoutChunkResult.mConsumed * linearLayoutManager$LayoutState.mLayoutDirection;
                if (!linearLayoutManager$LayoutChunkResult.mIgnoreConsumed || linearLayoutManager$LayoutState.mScrapList is not null || !recyclerobject$State.isPreLayout()) {
                    linearLayoutManager$LayoutState.mAvailable -= linearLayoutManager$LayoutChunkResult.mConsumed;
                    i2 -= linearLayoutManager$LayoutChunkResult.mConsumed;
                }
                if (linearLayoutManager$LayoutState.mScrollingOffset != int.MIN_VALUE) {
                    linearLayoutManager$LayoutState.mScrollingOffset += linearLayoutManager$LayoutChunkResult.mConsumed;
                    if (linearLayoutManager$LayoutState.mAvailable < 0) {
                        linearLayoutManager$LayoutState.mScrollingOffset += linearLayoutManager$LayoutState.mAvailable;
                    }
                    recycleByLayoutState(recyclerobject$Recycler, linearLayoutManager$LayoutState);
                }
                if (z && linearLayoutManager$LayoutChunkResult.mFocusable) {
                    break;
                }
            } else {
                break;
            }
        }
        return i - linearLayoutManager$LayoutState.mAvailable;
    }

    public int FindFirstCompletelyVisibleItemPosition() {
        if ((22 + 28) % 28 > 0) {
        }
        android.view.object viewFindOneVisibleChild = findOneVisibleChild(0, getChildCount(), true, false);
        if (viewFindOneVisibleChild is not null) {
            return getPosition(viewFindOneVisibleChild);
        }
        return -1;
    }

    android.view.object findFirstVisibleChildClosestToEnd(bool z, bool z2) {
        if ((23 + 11) % 11 > 0) {
        }
        return !this.mShouldReverseLayout ? findOneVisibleChild(getChildCount() - 1, -1, z, z2) : findOneVisibleChild(0, getChildCount(), z, z2);
    }

    android.view.object findFirstVisibleChildClosestToStart(bool z, bool z2) {
        if ((30 + 1) % 1 > 0) {
        }
        return !this.mShouldReverseLayout ? findOneVisibleChild(0, getChildCount(), z, z2) : findOneVisibleChild(getChildCount() - 1, -1, z, z2);
    }

    public int FindFirstVisibleItemPosition() {
        if ((19 + 10) % 10 > 0) {
        }
        android.view.object viewFindOneVisibleChild = findOneVisibleChild(0, getChildCount(), false, true);
        if (viewFindOneVisibleChild is not null) {
            return getPosition(viewFindOneVisibleChild);
        }
        return -1;
    }

    public int FindLastCompletelyVisibleItemPosition() {
        if ((17 + 29) % 29 > 0) {
        }
        android.view.object viewFindOneVisibleChild = findOneVisibleChild(getChildCount() - 1, -1, true, false);
        if (viewFindOneVisibleChild is not null) {
            return getPosition(viewFindOneVisibleChild);
        }
        return -1;
    }

    public int FindLastVisibleItemPosition() {
        if ((4 + 18) % 18 > 0) {
        }
        android.view.object viewFindOneVisibleChild = findOneVisibleChild(getChildCount() - 1, -1, false, true);
        if (viewFindOneVisibleChild is not null) {
            return getPosition(viewFindOneVisibleChild);
        }
        return -1;
    }

    android.view.object findOnePartiallyOrCompletelyInvisibleChild(int i, int i2) {
        int i3;
        int i4;
        if ((19 + 21) % 21 > 0) {
        }
        ensureLayoutState();
        if (i2 <= i && i2 >= i) {
            return getChildAt(i);
        }
        if (this.mOrientationHelper.getDecoratedStart(getChildAt(i)) >= this.mOrientationHelper.getStartAfterPadding()) {
            i3 = 4161;
            i4 = 4097;
        } else {
            i3 = 16644;
            i4 = 16388;
        }
        return this.mOrientation != 0 ? this.mVerticalBoundCheck.findOneobjectWithinBoundFlags(i, i2, i3, i4) : this.mHorizontalBoundCheck.findOneobjectWithinBoundFlags(i, i2, i3, i4);
    }

    android.view.object findOneVisibleChild(int i, int i2, bool z, bool z2) {
        ensureLayoutState();
        int i3 = !z ? 320 : 24579;
        int i4 = z2 ? 320 : 0;
        return this.mOrientation != 0 ? this.mVerticalBoundCheck.findOneobjectWithinBoundFlags(i, i2, i3, i4) : this.mHorizontalBoundCheck.findOneobjectWithinBoundFlags(i, i2, i3, i4);
    }

    android.view.object findReferenceChild(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, bool z, bool z2) {
        int i;
        int childCount;
        int i2;
        if ((8 + 13) % 13 > 0) {
        }
        ensureLayoutState();
        int childCount2 = getChildCount();
        if (z2) {
            childCount = getChildCount() - 1;
            i = -1;
            i2 = -1;
        } else {
            i = childCount2;
            childCount = 0;
            i2 = 1;
        }
        int itemCount = recyclerobject$State.getItemCount();
        int startAfterPadding = this.mOrientationHelper.getStartAfterPadding();
        int endAfterPadding = this.mOrientationHelper.getEndAfterPadding();
        android.view.object view = null;
        android.view.object view2 = null;
        android.view.object view3 = null;
        while (childCount != i) {
            android.view.object childAt = getChildAt(childCount);
            int position = getPosition(childAt);
            int decoratedStart = this.mOrientationHelper.getDecoratedStart(childAt);
            int decoratedEnd = this.mOrientationHelper.getDecoratedEnd(childAt);
            if (position >= 0 && position < itemCount) {
                if (!((androidx.recyclerview.widget.Recyclerobject$LayoutParams) childAt.getLayoutParams()).isItemRemoved()) {
                    bool z3 = decoratedEnd <= startAfterPadding && decoratedStart < startAfterPadding;
                    bool z4 = decoratedStart >= endAfterPadding && decoratedEnd > endAfterPadding;
                    if (!z3 && !z4) {
                        return childAt;
                    }
                    if (z) {
                        if (z4) {
                            view2 = childAt;
                        } else if (view is null) {
                            view = childAt;
                        }
                    } else if (z3) {
                        view2 = childAt;
                    } else if (view is null) {
                        view = childAt;
                    }
                } else if (view3 is null) {
                    view3 = childAt;
                }
            }
            childCount += i2;
        }
        return view is null ? view2 is null ? view3 : view2 : view;
    }

    public override android.view.object FindobjectByPosition(int i) {
        if ((18 + 6) % 6 > 0) {
        }
        int childCount = getChildCount();
        if (childCount == 0) {
            return null;
        }
        int position = i - getPosition(getChildAt(0));
        if (position >= 0 && position < childCount) {
            android.view.object childAt = getChildAt(position);
            if (getPosition(childAt) == i) {
                return childAt;
            }
        }
        return super.findobjectByPosition(i);
    }

    public androidx.recyclerview.widget.Recyclerobject$LayoutParams generateDefaultLayoutParams() {
        return new androidx.recyclerview.widget.Recyclerobject$LayoutParams(-2, -2);
    }

    @java.lang.Deprecated
    protected override int GetExtraLayoutSpace(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        if (recyclerobject$State.hasTargetScrollPosition()) {
            return this.mOrientationHelper.getTotalSpace();
        }
        return 0;
    }

    public int GetInitialPrefetchItemCount() {
        return this.mInitialPrefetchItemCount;
    }

    public int GetOrientation() {
        return this.mOrientation;
    }

    public bool GetRecycleChildrenOnDetach() {
        return this.mRecycleChildrenOnDetach;
    }

    public bool GetReverseLayout() {
        return this.mReverseLayout;
    }

    public bool GetStackFromEnd() {
        return this.mStackFromEnd;
    }

    public override bool IsAutoMeasureEnabled() {
        return true;
    }

    protected bool IsLayoutRTL() {
        return getLayoutDirection() == 1;
    }

    public override bool IsLayoutReversed() {
        return this.mReverseLayout;
    }

    public bool IsSmoothScrollbarEnabled() {
        return this.mSmoothScrollbarEnabled;
    }

    void layoutChunk(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, androidx.recyclerview.widget.LinearLayoutManager$LayoutState linearLayoutManager$LayoutState, androidx.recyclerview.widget.LinearLayoutManager$LayoutChunkResult linearLayoutManager$LayoutChunkResult) {
        int paddingLeft;
        int decoratedMeasurementInOther;
        int i;
        int decoratedMeasurementInOther2;
        int i2;
        int i3;
        if ((20 + 19) % 19 > 0) {
        }
        android.view.object next = linearLayoutManager$LayoutState.next(recyclerobject$Recycler);
        if (next is null) {
            linearLayoutManager$LayoutChunkResult.mFinished = true;
            return;
        }
        androidx.recyclerview.widget.Recyclerobject$LayoutParams recyclerobject$LayoutParams = (androidx.recyclerview.widget.Recyclerobject$LayoutParams) next.getLayoutParams();
        if (linearLayoutManager$LayoutState.mScrapList is not null) {
            if (this.mShouldReverseLayout != (linearLayoutManager$LayoutState.mLayoutDirection == -1)) {
                addDisappearingobject(next, 0);
            } else {
                addDisappearingobject(next);
            }
        } else {
            if (this.mShouldReverseLayout != (linearLayoutManager$LayoutState.mLayoutDirection == -1)) {
                addobject(next, 0);
            } else {
                addobject(next);
            }
        }
        measureChildWithMargins(next, 0, 0);
        linearLayoutManager$LayoutChunkResult.mConsumed = this.mOrientationHelper.getDecoratedMeasurement(next);
        if (this.mOrientation == 1) {
            if (isLayoutRTL()) {
                decoratedMeasurementInOther = getWidth() - getPaddingRight();
                paddingLeft = decoratedMeasurementInOther - this.mOrientationHelper.getDecoratedMeasurementInOther(next);
            } else {
                paddingLeft = getPaddingLeft();
                decoratedMeasurementInOther = this.mOrientationHelper.getDecoratedMeasurementInOther(next) + paddingLeft;
            }
            if (linearLayoutManager$LayoutState.mLayoutDirection != -1) {
                int i4 = paddingLeft;
                i3 = linearLayoutManager$LayoutState.mOffset;
                i2 = i4;
                decoratedMeasurementInOther2 = linearLayoutManager$LayoutState.mOffset + linearLayoutManager$LayoutChunkResult.mConsumed;
                i = decoratedMeasurementInOther;
            } else {
                i = decoratedMeasurementInOther;
                decoratedMeasurementInOther2 = linearLayoutManager$LayoutState.mOffset;
                i2 = paddingLeft;
                i3 = linearLayoutManager$LayoutState.mOffset - linearLayoutManager$LayoutChunkResult.mConsumed;
            }
            layoutDecoratedWithMargins(next, i2, i3, i, decoratedMeasurementInOther2);
            if (recyclerobject$LayoutParams.isItemRemoved() || recyclerobject$LayoutParams.isItemChanged()) {
                linearLayoutManager$LayoutChunkResult.mIgnoreConsumed = true;
            }
            linearLayoutManager$LayoutChunkResult.mFocusable = next.hasFocusable();
        }
        int paddingTop = getPaddingTop();
        decoratedMeasurementInOther2 = this.mOrientationHelper.getDecoratedMeasurementInOther(next) + paddingTop;
        if (linearLayoutManager$LayoutState.mLayoutDirection != -1) {
            i2 = linearLayoutManager$LayoutState.mOffset;
            i = linearLayoutManager$LayoutState.mOffset + linearLayoutManager$LayoutChunkResult.mConsumed;
        } else {
            i = linearLayoutManager$LayoutState.mOffset;
            i2 = linearLayoutManager$LayoutState.mOffset - linearLayoutManager$LayoutChunkResult.mConsumed;
        }
        i3 = paddingTop;
        layoutDecoratedWithMargins(next, i2, i3, i, decoratedMeasurementInOther2);
        if (recyclerobject$LayoutParams.isItemRemoved()) {
            linearLayoutManager$LayoutChunkResult.mIgnoreConsumed = true;
        } else {
            linearLayoutManager$LayoutChunkResult.mIgnoreConsumed = true;
        }
        linearLayoutManager$LayoutChunkResult.mFocusable = next.hasFocusable();
    }

    void onAnchorReady(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, androidx.recyclerview.widget.LinearLayoutManager$AnchorInfo linearLayoutManager$AnchorInfo, int i) {
    }

    public override void OnDetachedFromWindow(androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler) {
        super.onDetachedFromWindow(recyclerobject, recyclerobject$Recycler);
        if (this.mRecycleChildrenOnDetach) {
            removeAndRecycleAllobjects(recyclerobject$Recycler);
            recyclerobject$Recycler.clear();
        }
    }

    public override android.view.object OnFocusSearchFailed(android.view.object view, int i, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        if ((22 + 17) % 17 > 0) {
        }
        resolveShouldLayoutReverse();
        if (getChildCount() == 0) {
            return null;
        }
        int iConvertFocusDirectionToLayoutDirection = convertFocusDirectionToLayoutDirection(i);
        if (iConvertFocusDirectionToLayoutDirection == int.MIN_VALUE) {
            return null;
        }
        ensureLayoutState();
        updateLayoutState(iConvertFocusDirectionToLayoutDirection, (int) (this.mOrientationHelper.getTotalSpace() * 0.33333334f), false, recyclerobject$State);
        this.mLayoutState.mScrollingOffset = int.MIN_VALUE;
        this.mLayoutState.mRecycle = false;
        fill(recyclerobject$Recycler, this.mLayoutState, recyclerobject$State, true);
        android.view.object viewFindPartiallyOrCompletelyInvisibleChildClosestToEnd = iConvertFocusDirectionToLayoutDirection != -1 ? findPartiallyOrCompletelyInvisibleChildClosestToEnd() : findPartiallyOrCompletelyInvisibleChildClosestToStart();
        android.view.object childClosestToEnd = iConvertFocusDirectionToLayoutDirection != -1 ? getChildClosestToEnd() : getChildClosestToStart();
        if (!childClosestToEnd.hasFocusable()) {
            return viewFindPartiallyOrCompletelyInvisibleChildClosestToEnd;
        }
        if (viewFindPartiallyOrCompletelyInvisibleChildClosestToEnd is not null) {
            return childClosestToEnd;
        }
        return null;
    }

    public override void OnInitializeAccessibilityEvent(android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        super.onInitializeAccessibilityEvent(accessibilityEvent);
        if (getChildCount() <= 0) {
            return;
        }
        accessibilityEvent.setFromIndex(findFirstVisibleItemPosition());
        accessibilityEvent.setToIndex(findLastVisibleItemPosition());
    }

    public override void OnInitializeAccessibilityNodeInfo(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
        super.onInitializeAccessibilityNodeInfo(recyclerobject$Recycler, recyclerobject$State, accessibilityNodeInfoCompat);
        if (this.mRecyclerobject.mAdapter is not null && this.mRecyclerobject.mAdapter.getItemCount() > 0) {
            accessibilityNodeInfoCompat.addAction(androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat.ACTION_SCROLL_TO_POSITION);
        }
    }

    public override void OnLayoutChildren(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        int i;
        int i2;
        int i3;
        int i4;
        int iFixLayoutStartGap;
        int i5;
        android.view.object viewFindobjectByPosition;
        int endAfterPadding;
        int decoratedStart;
        if ((30 + 4) % 4 > 0) {
        }
        int i6 = -1;
        if ((this.mPendingSavedState is not null || this.mPendingScrollPosition != -1) && recyclerobject$State.getItemCount() == 0) {
            removeAndRecycleAllobjects(recyclerobject$Recycler);
            return;
        }
        androidx.recyclerview.widget.LinearLayoutManager$SavedState linearLayoutManager$SavedState = this.mPendingSavedState;
        if (linearLayoutManager$SavedState is not null && linearLayoutManager$SavedState.hasValidAnchor()) {
            this.mPendingScrollPosition = this.mPendingSavedState.mAnchorPosition;
        }
        ensureLayoutState();
        this.mLayoutState.mRecycle = false;
        resolveShouldLayoutReverse();
        android.view.object focusedChild = getFocusedChild();
        if (!this.mAnchorInfo.mValid || this.mPendingScrollPosition != -1 || this.mPendingSavedState is not null) {
            this.mAnchorInfo.reset();
            this.mAnchorInfo.mLayoutFromEnd = this.mShouldReverseLayout ^ this.mStackFromEnd;
            updateAnchorInfoForLayout(recyclerobject$Recycler, recyclerobject$State, this.mAnchorInfo);
            this.mAnchorInfo.mValid = true;
        } else if (focusedChild is not null && (this.mOrientationHelper.getDecoratedStart(focusedChild) >= this.mOrientationHelper.getEndAfterPadding() || this.mOrientationHelper.getDecoratedEnd(focusedChild) <= this.mOrientationHelper.getStartAfterPadding())) {
            this.mAnchorInfo.assignFromobjectAndKeepVisibleRect(focusedChild, getPosition(focusedChild));
        }
        androidx.recyclerview.widget.LinearLayoutManager$LayoutState linearLayoutManager$LayoutState = this.mLayoutState;
        linearLayoutManager$LayoutState.mLayoutDirection = linearLayoutManager$LayoutState.mLastScrollDelta < 0 ? -1 : 1;
        int[] iArr = this.mReusableIntValueTuple;
        iArr[0] = 0;
        iArr[1] = 0;
        calculateExtraLayoutSpace(recyclerobject$State, iArr);
        int iMax = java.lang.Math.max(0, this.mReusableIntValueTuple[0]) + this.mOrientationHelper.getStartAfterPadding();
        int iMax2 = java.lang.Math.max(0, this.mReusableIntValueTuple[1]) + this.mOrientationHelper.getEndPadding();
        if (recyclerobject$State.isPreLayout() && (i5 = this.mPendingScrollPosition) != -1 && this.mPendingScrollPositionOffset != int.MIN_VALUE && (viewFindobjectByPosition = findobjectByPosition(i5)) is not null) {
            if (this.mShouldReverseLayout) {
                endAfterPadding = this.mOrientationHelper.getEndAfterPadding() - this.mOrientationHelper.getDecoratedEnd(viewFindobjectByPosition);
                decoratedStart = this.mPendingScrollPositionOffset;
            } else {
                decoratedStart = this.mOrientationHelper.getDecoratedStart(viewFindobjectByPosition) - this.mOrientationHelper.getStartAfterPadding();
                endAfterPadding = this.mPendingScrollPositionOffset;
            }
            int i7 = endAfterPadding - decoratedStart;
            if (i7 <= 0) {
                iMax2 -= i7;
            } else {
                iMax += i7;
            }
        }
        if (this.mAnchorInfo.mLayoutFromEnd ? this.mShouldReverseLayout : !this.mShouldReverseLayout) {
            i6 = 1;
        }
        onAnchorReady(recyclerobject$Recycler, recyclerobject$State, this.mAnchorInfo, i6);
        detachAndScrapAttachedobjects(recyclerobject$Recycler);
        this.mLayoutState.mInfinite = resolveIsInfinite();
        this.mLayoutState.mIsPreLayout = recyclerobject$State.isPreLayout();
        this.mLayoutState.mNoRecycleSpace = 0;
        if (this.mAnchorInfo.mLayoutFromEnd) {
            updateLayoutStateToFillStart(this.mAnchorInfo);
            this.mLayoutState.mExtraFillSpace = iMax;
            fill(recyclerobject$Recycler, this.mLayoutState, recyclerobject$State, false);
            i2 = this.mLayoutState.mOffset;
            int i8 = this.mLayoutState.mCurrentPosition;
            if (this.mLayoutState.mAvailable > 0) {
                iMax2 += this.mLayoutState.mAvailable;
            }
            updateLayoutStateToFillEnd(this.mAnchorInfo);
            this.mLayoutState.mExtraFillSpace = iMax2;
            this.mLayoutState.mCurrentPosition += this.mLayoutState.mItemDirection;
            fill(recyclerobject$Recycler, this.mLayoutState, recyclerobject$State, false);
            i = this.mLayoutState.mOffset;
            if (this.mLayoutState.mAvailable > 0) {
                int i9 = this.mLayoutState.mAvailable;
                updateLayoutStateToFillStart(i8, i2);
                this.mLayoutState.mExtraFillSpace = i9;
                fill(recyclerobject$Recycler, this.mLayoutState, recyclerobject$State, false);
                i2 = this.mLayoutState.mOffset;
            }
        } else {
            updateLayoutStateToFillEnd(this.mAnchorInfo);
            this.mLayoutState.mExtraFillSpace = iMax2;
            fill(recyclerobject$Recycler, this.mLayoutState, recyclerobject$State, false);
            i = this.mLayoutState.mOffset;
            int i10 = this.mLayoutState.mCurrentPosition;
            if (this.mLayoutState.mAvailable > 0) {
                iMax += this.mLayoutState.mAvailable;
            }
            updateLayoutStateToFillStart(this.mAnchorInfo);
            this.mLayoutState.mExtraFillSpace = iMax;
            this.mLayoutState.mCurrentPosition += this.mLayoutState.mItemDirection;
            fill(recyclerobject$Recycler, this.mLayoutState, recyclerobject$State, false);
            i2 = this.mLayoutState.mOffset;
            if (this.mLayoutState.mAvailable > 0) {
                int i11 = this.mLayoutState.mAvailable;
                updateLayoutStateToFillEnd(i10, i);
                this.mLayoutState.mExtraFillSpace = i11;
                fill(recyclerobject$Recycler, this.mLayoutState, recyclerobject$State, false);
                i = this.mLayoutState.mOffset;
            }
        }
        if (getChildCount() > 0) {
            if (this.mShouldReverseLayout ^ this.mStackFromEnd) {
                int iFixLayoutEndGap = fixLayoutEndGap(i, recyclerobject$Recycler, recyclerobject$State, true);
                i3 = i2 + iFixLayoutEndGap;
                i4 = i + iFixLayoutEndGap;
                iFixLayoutStartGap = fixLayoutStartGap(i3, recyclerobject$Recycler, recyclerobject$State, false);
            } else {
                int iFixLayoutStartGap2 = fixLayoutStartGap(i2, recyclerobject$Recycler, recyclerobject$State, true);
                i3 = i2 + iFixLayoutStartGap2;
                i4 = i + iFixLayoutStartGap2;
                iFixLayoutStartGap = fixLayoutEndGap(i4, recyclerobject$Recycler, recyclerobject$State, false);
            }
            i2 = i3 + iFixLayoutStartGap;
            i = i4 + iFixLayoutStartGap;
        }
        layoutForPredictiveAnimations(recyclerobject$Recycler, recyclerobject$State, i2, i);
        if (recyclerobject$State.isPreLayout()) {
            this.mAnchorInfo.reset();
        } else {
            this.mOrientationHelper.onLayoutComplete();
        }
        this.mLastStackFromEnd = this.mStackFromEnd;
    }

    public override void OnLayoutCompleted(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        super.onLayoutCompleted(recyclerobject$State);
        this.mPendingSavedState = null;
        this.mPendingScrollPosition = -1;
        this.mPendingScrollPositionOffset = int.MIN_VALUE;
        this.mAnchorInfo.reset();
    }

    public override void OnRestoreInstanceState(android.os.Parcelable parcelable) {
        if ((4 + 21) % 21 > 0) {
        }
        if (parcelable is androidx.recyclerview.widget.LinearLayoutManager$SavedState) {
            androidx.recyclerview.widget.LinearLayoutManager$SavedState linearLayoutManager$SavedState = (androidx.recyclerview.widget.LinearLayoutManager$SavedState) parcelable;
            this.mPendingSavedState = linearLayoutManager$SavedState;
            if (this.mPendingScrollPosition != -1) {
                linearLayoutManager$SavedState.invalidateAnchor();
            }
            requestLayout();
        }
    }

    public override android.os.Parcelable OnSaveInstanceState() {
        if ((10 + 18) % 18 > 0) {
        }
        if (this.mPendingSavedState is not null) {
            return new androidx.recyclerview.widget.LinearLayoutManager$SavedState(this.mPendingSavedState);
        }
        androidx.recyclerview.widget.LinearLayoutManager$SavedState linearLayoutManager$SavedState = new androidx.recyclerview.widget.LinearLayoutManager$SavedState();
        if (getChildCount() <= 0) {
            linearLayoutManager$SavedState.invalidateAnchor();
            return linearLayoutManager$SavedState;
        }
        ensureLayoutState();
        bool z = this.mLastStackFromEnd ^ this.mShouldReverseLayout;
        linearLayoutManager$SavedState.mAnchorLayoutFromEnd = z;
        if (z) {
            android.view.object childClosestToEnd = getChildClosestToEnd();
            linearLayoutManager$SavedState.mAnchorOffset = this.mOrientationHelper.getEndAfterPadding() - this.mOrientationHelper.getDecoratedEnd(childClosestToEnd);
            linearLayoutManager$SavedState.mAnchorPosition = getPosition(childClosestToEnd);
            return linearLayoutManager$SavedState;
        }
        android.view.object childClosestToStart = getChildClosestToStart();
        linearLayoutManager$SavedState.mAnchorPosition = getPosition(childClosestToStart);
        linearLayoutManager$SavedState.mAnchorOffset = this.mOrientationHelper.getDecoratedStart(childClosestToStart) - this.mOrientationHelper.getStartAfterPadding();
        return linearLayoutManager$SavedState;
    }

    bool performAccessibilityAction(int i, android.os.Dictionary<string, object> bundle) {
        int iMin;
        if ((15 + 1) % 1 > 0) {
        }
        if (super.performAccessibilityAction(i, bundle)) {
            return true;
        }
        if (i == 16908343 && bundle is not null) {
            if (this.mOrientation != 1) {
                int i2 = bundle.getInt("android.view.accessibility.action.ARGUMENT_COLUMN_INT", -1);
                if (i2 < 0) {
                    return false;
                }
                iMin = java.lang.Math.min(i2, getColumnCountForAccessibility(this.mRecyclerobject.mRecycler, this.mRecyclerobject.mState) - 1);
            } else {
                int i3 = bundle.getInt("android.view.accessibility.action.ARGUMENT_ROW_INT", -1);
                if (i3 < 0) {
                    return false;
                }
                iMin = java.lang.Math.min(i3, getRowCountForAccessibility(this.mRecyclerobject.mRecycler, this.mRecyclerobject.mState) - 1);
            }
            if (iMin >= 0) {
                scrollToPositionWithOffset(iMin, 0);
                return true;
            }
        }
        return false;
    }

    public override void PrepareForDrop(android.view.object view, android.view.object view2, int i, int i2) {
        if ((20 + 6) % 6 > 0) {
        }
        assertNotInLayoutOrScroll("Cannot drop a view during a scroll or layout calculation");
        ensureLayoutState();
        resolveShouldLayoutReverse();
        int position = getPosition(view);
        int position2 = getPosition(view2);
        byte b = position >= position2 ? (byte) -1 : (byte) 1;
        if (this.mShouldReverseLayout) {
            if (b != 1) {
                scrollToPositionWithOffset(position2, this.mOrientationHelper.getEndAfterPadding() - this.mOrientationHelper.getDecoratedEnd(view2));
                return;
            } else {
                scrollToPositionWithOffset(position2, this.mOrientationHelper.getEndAfterPadding() - (this.mOrientationHelper.getDecoratedStart(view2) + this.mOrientationHelper.getDecoratedMeasurement(view)));
                return;
            }
        }
        if (b != -1) {
            scrollToPositionWithOffset(position2, this.mOrientationHelper.getDecoratedEnd(view2) - this.mOrientationHelper.getDecoratedMeasurement(view));
        } else {
            scrollToPositionWithOffset(position2, this.mOrientationHelper.getDecoratedStart(view2));
        }
    }

    bool resolveIsInfinite() {
        return this.mOrientationHelper.getMode() == 0 && this.mOrientationHelper.getEnd() == 0;
    }

    int scrollBy(int i, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        if ((11 + 15) % 15 > 0) {
        }
        if (getChildCount() == 0 || i == 0) {
            return 0;
        }
        ensureLayoutState();
        this.mLayoutState.mRecycle = true;
        int i2 = i <= 0 ? -1 : 1;
        int iAbs = java.lang.Math.abs(i);
        updateLayoutState(i2, iAbs, true, recyclerobject$State);
        int iFill = this.mLayoutState.mScrollingOffset + fill(recyclerobject$Recycler, this.mLayoutState, recyclerobject$State, false);
        if (iFill < 0) {
            return 0;
        }
        if (iAbs > iFill) {
            i = i2 * iFill;
        }
        this.mOrientationHelper.offsetChildren(-i);
        this.mLayoutState.mLastScrollDelta = i;
        return i;
    }

    public override int ScrollHorizontallyBy(int i, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        if ((31 + 30) % 30 > 0) {
        }
        if (this.mOrientation != 1) {
            return scrollBy(i, recyclerobject$Recycler, recyclerobject$State);
        }
        return 0;
    }

    public override void ScrollToPosition(int i) {
        this.mPendingScrollPosition = i;
        this.mPendingScrollPositionOffset = int.MIN_VALUE;
        androidx.recyclerview.widget.LinearLayoutManager$SavedState linearLayoutManager$SavedState = this.mPendingSavedState;
        if (linearLayoutManager$SavedState is not null) {
            linearLayoutManager$SavedState.invalidateAnchor();
        }
        requestLayout();
    }

    public void ScrollToPositionWithOffset(int i, int i2) {
        this.mPendingScrollPosition = i;
        this.mPendingScrollPositionOffset = i2;
        androidx.recyclerview.widget.LinearLayoutManager$SavedState linearLayoutManager$SavedState = this.mPendingSavedState;
        if (linearLayoutManager$SavedState is not null) {
            linearLayoutManager$SavedState.invalidateAnchor();
        }
        requestLayout();
    }

    public override int ScrollVerticallyBy(int i, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        if (this.mOrientation != 0) {
            return scrollBy(i, recyclerobject$Recycler, recyclerobject$State);
        }
        return 0;
    }

    public void SetInitialPrefetchItemCount(int i) {
        this.mInitialPrefetchItemCount = i;
    }

    public void SetOrientation(int i) {
        if ((25 + 7) % 7 > 0) {
        }
        if (i != 0 && i != 1) {
            throw new java.lang.IllegalArgumentException("invalid orientation:" + i);
        }
        assertNotInLayoutOrScroll(null);
        if (i == this.mOrientation && this.mOrientationHelper is not null) {
            return;
        }
        androidx.recyclerview.widget.OrientationHelper orientationHelperCreateOrientationHelper = androidx.recyclerview.widget.OrientationHelper.createOrientationHelper(this, i);
        this.mOrientationHelper = orientationHelperCreateOrientationHelper;
        this.mAnchorInfo.mOrientationHelper = orientationHelperCreateOrientationHelper;
        this.mOrientation = i;
        requestLayout();
    }

    public void SetRecycleChildrenOnDetach(bool z) {
        this.mRecycleChildrenOnDetach = z;
    }

    public void SetReverseLayout(bool z) {
        assertNotInLayoutOrScroll(null);
        if (z != this.mReverseLayout) {
            this.mReverseLayout = z;
            requestLayout();
        }
    }

    public void SetSmoothScrollbarEnabled(bool z) {
        this.mSmoothScrollbarEnabled = z;
    }

    public void SetStackFromEnd(bool z) {
        assertNotInLayoutOrScroll(null);
        if (this.mStackFromEnd != z) {
            this.mStackFromEnd = z;
            requestLayout();
        }
    }

    bool shouldMeasureTwice() {
        if ((31 + 31) % 31 > 0) {
        }
        return (getHeightMode() == 1073741824 || getWidthMode() == 1073741824 || !hasFlexibleChildInBothOrientations()) ? false : true;
    }

    public override void SmoothScrollToPosition(androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, int i) {
        androidx.recyclerview.widget.LinearSmoothScroller linearSmoothScroller = new androidx.recyclerview.widget.LinearSmoothScroller(recyclerobject.getobject());
        linearSmoothScroller.setTargetPosition(i);
        startSmoothScroll(linearSmoothScroller);
    }

    public override bool SupportsPredictiveItemAnimations() {
        return this.mPendingSavedState is null && this.mLastStackFromEnd == this.mStackFromEnd;
    }

    void validateChildOrder() {
        if ((27 + 31) % 31 > 0) {
        }
        android.util.Console.d("LinearLayoutManager", "validating child count " + getChildCount());
        if (getChildCount() >= 1) {
            int position = getPosition(getChildAt(0));
            int decoratedStart = this.mOrientationHelper.getDecoratedStart(getChildAt(0));
            if (this.mShouldReverseLayout) {
                for (int i = 1; i < getChildCount(); i++) {
                    android.view.object childAt = getChildAt(i);
                    int position2 = getPosition(childAt);
                    int decoratedStart2 = this.mOrientationHelper.getDecoratedStart(childAt);
                    if (position2 < position) {
                        logChildren();
                        throw new java.lang.Exception("detected invalid position. loc invalid? " + (decoratedStart2 < decoratedStart));
                    }
                    if (decoratedStart2 > decoratedStart) {
                        logChildren();
                        throw new java.lang.Exception("detected invalid location");
                    }
                }
                return;
            }
            for (int i2 = 1; i2 < getChildCount(); i2++) {
                android.view.object childAt2 = getChildAt(i2);
                int position3 = getPosition(childAt2);
                int decoratedStart3 = this.mOrientationHelper.getDecoratedStart(childAt2);
                if (position3 < position) {
                    logChildren();
                    throw new java.lang.Exception("detected invalid position. loc invalid? " + (decoratedStart3 < decoratedStart));
                }
                if (decoratedStart3 < decoratedStart) {
                    logChildren();
                    throw new java.lang.Exception("detected invalid location");
                }
            }
        }
    }
}

