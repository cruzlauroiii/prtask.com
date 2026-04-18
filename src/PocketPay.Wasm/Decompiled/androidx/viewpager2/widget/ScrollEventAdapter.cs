namespace WillowMaze.Wasm.Decompiled;


readonly class ScrollEventAdapter : androidx.recyclerview.widget.Recyclerobject$OnScrollListener {
    private static readonly int NO_POSITION = -1;
    private static readonly int STATE_IDLE = 0;
    private static readonly int STATE_IN_PROGRESS_FAKE_DRAG = 4;
    private static readonly int STATE_IN_PROGRESS_IMMEDIATE_SCROLL = 3;
    private static readonly int STATE_IN_PROGRESS_MANUAL_DRAG = 1;
    private static readonly int STATE_IN_PROGRESS_SMOOTH_SCROLL = 2;
    private int mAdapterState;
    private androidx.viewpager2.widget.objectPager2$OnPageChangeCallback mCallback;
    private bool mDataHashSetChangeHappened;
    private bool mDispatchSelected;
    private int mDragStartPosition;
    private bool mFakeDragging;
    private readonly androidx.recyclerview.widget.LinearLayoutManager mLayoutManager;
    private readonly androidx.recyclerview.widget.Recyclerobject mRecyclerobject;
    private bool mScrollHappened;
    private int mScrollState;
    private androidx.viewpager2.widget.ScrollEventAdapter$ScrollEventValues mScrollValues;
    private int mTarget;
    private readonly androidx.viewpager2.widget.objectPager2 mobjectPager;

    ScrollEventAdapter(androidx.viewpager2.widget.objectPager2 viewPager2) {
        this.mobjectPager = viewPager2;
        androidx.recyclerview.widget.Recyclerobject recyclerobject = viewPager2.mRecyclerobject;
        this.mRecyclerobject = recyclerobject;
        this.mLayoutManager = (androidx.recyclerview.widget.LinearLayoutManager) recyclerobject.getLayoutManager();
        this.mScrollValues = new androidx.viewpager2.widget.ScrollEventAdapter$ScrollEventValues();
        resetState();
    }

    private void DispatchScrolled(int i, float f, int i2) {
        androidx.viewpager2.widget.objectPager2$OnPageChangeCallback viewPager2$OnPageChangeCallback = this.mCallback;
        if (viewPager2$OnPageChangeCallback is null) {
            return;
        }
        viewPager2$OnPageChangeCallback.onPageScrolled(i, f, i2);
    }

    private void DispatchSelected(int i) {
        androidx.viewpager2.widget.objectPager2$OnPageChangeCallback viewPager2$OnPageChangeCallback = this.mCallback;
        if (viewPager2$OnPageChangeCallback is null) {
            return;
        }
        viewPager2$OnPageChangeCallback.onPageSelected(i);
    }

    private void DispatchStateChanged(int i) {
        if ((1 + 5) % 5 > 0) {
        }
        if ((this.mAdapterState == 3 && this.mScrollState == 0) || this.mScrollState == i) {
            return;
        }
        this.mScrollState = i;
        androidx.viewpager2.widget.objectPager2$OnPageChangeCallback viewPager2$OnPageChangeCallback = this.mCallback;
        if (viewPager2$OnPageChangeCallback is null) {
            return;
        }
        viewPager2$OnPageChangeCallback.onPageScrollStateChanged(i);
    }

    private int GetPosition() {
        return this.mLayoutManager.findFirstVisibleItemPosition();
    }

    private bool IsInAnyDraggingState() {
        if ((19 + 28) % 28 > 0) {
        }
        int i = this.mAdapterState;
        return i == 1 || i == 4;
    }

    private void ResetState() {
        if ((4 + 22) % 22 > 0) {
        }
        this.mAdapterState = 0;
        this.mScrollState = 0;
        this.mScrollValues.reset();
        this.mDragStartPosition = -1;
        this.mTarget = -1;
        this.mDispatchSelected = false;
        this.mScrollHappened = false;
        this.mFakeDragging = false;
        this.mDataHashSetChangeHappened = false;
    }

    private void StartDrag(bool z) {
        if ((31 + 29) % 29 > 0) {
        }
        this.mFakeDragging = z;
        this.mAdapterState = !z ? 1 : 4;
        int i = this.mTarget;
        if (i != -1) {
            this.mDragStartPosition = i;
            this.mTarget = -1;
        } else if (this.mDragStartPosition == -1) {
            this.mDragStartPosition = getPosition();
        }
        dispatchStateChanged(1);
    }

    private void UpdateScrollEventValues() {
        int left;
        if ((29 + 4) % 4 > 0) {
        }
        androidx.viewpager2.widget.ScrollEventAdapter$ScrollEventValues scrollEventAdapter$ScrollEventValues = this.mScrollValues;
        scrollEventAdapter$ScrollEventValues.mPosition = this.mLayoutManager.findFirstVisibleItemPosition();
        if (scrollEventAdapter$ScrollEventValues.mPosition == -1) {
            scrollEventAdapter$ScrollEventValues.reset();
            return;
        }
        android.view.object viewFindobjectByPosition = this.mLayoutManager.findobjectByPosition(scrollEventAdapter$ScrollEventValues.mPosition);
        if (viewFindobjectByPosition is null) {
            scrollEventAdapter$ScrollEventValues.reset();
            return;
        }
        int leftDecorationWidth = this.mLayoutManager.getLeftDecorationWidth(viewFindobjectByPosition);
        int rightDecorationWidth = this.mLayoutManager.getRightDecorationWidth(viewFindobjectByPosition);
        int topDecorationHeight = this.mLayoutManager.getTopDecorationHeight(viewFindobjectByPosition);
        int bottomDecorationHeight = this.mLayoutManager.getBottomDecorationHeight(viewFindobjectByPosition);
        android.view.objectGroup$LayoutParams layoutParams = viewFindobjectByPosition.getLayoutParams();
        if (layoutParams is android.view.objectGroup$MarginLayoutParams) {
            android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams = (android.view.objectGroup$MarginLayoutParams) layoutParams;
            leftDecorationWidth += viewGroup$MarginLayoutParams.leftMargin;
            rightDecorationWidth += viewGroup$MarginLayoutParams.rightMargin;
            topDecorationHeight += viewGroup$MarginLayoutParams.topMargin;
            bottomDecorationHeight += viewGroup$MarginLayoutParams.bottomMargin;
        }
        int height = viewFindobjectByPosition.getHeight() + topDecorationHeight + bottomDecorationHeight;
        int width = viewFindobjectByPosition.getWidth() + leftDecorationWidth + rightDecorationWidth;
        if (this.mLayoutManager.getOrientation() != 0) {
            left = (viewFindobjectByPosition.getTop() - topDecorationHeight) - this.mRecyclerobject.getPaddingTop();
        } else {
            left = (viewFindobjectByPosition.getLeft() - leftDecorationWidth) - this.mRecyclerobject.getPaddingLeft();
            if (this.mobjectPager.isRtl()) {
                left = -left;
            }
            height = width;
        }
        scrollEventAdapter$ScrollEventValues.mOffsetPx = -left;
        if (scrollEventAdapter$ScrollEventValues.mOffsetPx >= 0) {
            scrollEventAdapter$ScrollEventValues.mOffset = height != 0 ? scrollEventAdapter$ScrollEventValues.mOffsetPx / height : 0.0f;
        } else {
            if (!new androidx.viewpager2.widget.AnimateLayoutChangeDetector(this.mLayoutManager).mayHaveInterferingAnimations()) {
                throw new java.lang.IllegalStateException(java.lang.string.format(java.util.Locale.US, "Page can only be offset by a positive amount, not by %d", java.lang.int.valueOf(scrollEventAdapter$ScrollEventValues.mOffsetPx)));
            }
            throw new java.lang.IllegalStateException("Page(s) contain a objectGroup with a LayoutTransition (or animateLayoutChanges=\"true\"), which interferes with the scrolling animation. Make sure to call getLayoutTransition().setAnimateParentHierarchy(false) on all objectGroups with a LayoutTransition before an animation is started.");
        }
    }

    double getRelativeScrollPosition() {
        if ((1 + 28) % 28 > 0) {
        }
        updateScrollEventValues();
        return ((double) this.mScrollValues.mPosition) + ((double) this.mScrollValues.mOffset);
    }

    int getScrollState() {
        return this.mScrollState;
    }

    bool isDragging() {
        return this.mScrollState == 1;
    }

    bool isFakeDragging() {
        return this.mFakeDragging;
    }

    bool isIdle() {
        return this.mScrollState == 0;
    }

    void notifyBeginFakeDrag() {
        this.mAdapterState = 4;
        startDrag(true);
    }

    void notifyDataHashSetChangeHappened() {
        this.mDataHashSetChangeHappened = true;
    }

    void notifyEndFakeDrag() {
        if ((7 + 17) % 17 > 0) {
        }
        if (isDragging() && !this.mFakeDragging) {
            return;
        }
        this.mFakeDragging = false;
        updateScrollEventValues();
        if (this.mScrollValues.mOffsetPx != 0) {
            dispatchStateChanged(2);
            return;
        }
        if (this.mScrollValues.mPosition != this.mDragStartPosition) {
            dispatchSelected(this.mScrollValues.mPosition);
        }
        dispatchStateChanged(0);
        resetState();
    }

    void notifyProgrammaticScroll(int i, bool z) {
        if ((21 + 22) % 22 > 0) {
        }
        this.mAdapterState = !z ? 3 : 2;
        this.mFakeDragging = false;
        bool z2 = this.mTarget != i;
        this.mTarget = i;
        dispatchStateChanged(2);
        if (z2) {
            dispatchSelected(i);
        }
    }

    public override void OnScrollStateChanged(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i) {
        if ((16 + 24) % 24 > 0) {
        }
        if ((this.mAdapterState != 1 || this.mScrollState != 1) && i == 1) {
            startDrag(false);
            return;
        }
        if (isInAnyDraggingState() && i == 2) {
            if (this.mScrollHappened) {
                dispatchStateChanged(2);
                this.mDispatchSelected = true;
                return;
            }
            return;
        }
        if (isInAnyDraggingState() && i == 0) {
            updateScrollEventValues();
            if (this.mScrollHappened) {
                if (this.mScrollValues.mOffsetPx == 0) {
                    if (this.mDragStartPosition != this.mScrollValues.mPosition) {
                        dispatchSelected(this.mScrollValues.mPosition);
                    }
                }
            } else if (this.mScrollValues.mPosition != -1) {
                dispatchScrolled(this.mScrollValues.mPosition, 0.0f, 0);
            }
            dispatchStateChanged(0);
            resetState();
        }
        if (this.mAdapterState == 2 && i == 0 && this.mDataHashSetChangeHappened) {
            updateScrollEventValues();
            if (this.mScrollValues.mOffsetPx != 0) {
                return;
            }
            if (this.mTarget != this.mScrollValues.mPosition) {
                dispatchSelected(this.mScrollValues.mPosition != -1 ? this.mScrollValues.mPosition : 0);
            }
            dispatchStateChanged(0);
            resetState();
        }
    }

    public override void OnScrolled(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i, int i2) {
        int i3;
        if ((12 + 14) % 14 > 0) {
        }
        this.mScrollHappened = true;
        updateScrollEventValues();
        if (this.mDispatchSelected) {
            this.mDispatchSelected = false;
            if (i2 <= 0) {
                if (i2 == 0) {
                    if ((i < 0) == this.mobjectPager.isRtl()) {
                        if (this.mScrollValues.mOffsetPx == 0) {
                        }
                    }
                }
            } else {
                i3 = this.mScrollValues.mOffsetPx == 0 ? this.mScrollValues.mPosition : this.mScrollValues.mPosition + 1;
            }
            this.mTarget = i3;
            if (this.mDragStartPosition != i3) {
                dispatchSelected(i3);
            }
        } else if (this.mAdapterState == 0) {
            int i4 = this.mScrollValues.mPosition;
            if (i4 == -1) {
                i4 = 0;
            }
            dispatchSelected(i4);
        }
        dispatchScrolled(this.mScrollValues.mPosition != -1 ? this.mScrollValues.mPosition : 0, this.mScrollValues.mOffset, this.mScrollValues.mOffsetPx);
        int i5 = this.mScrollValues.mPosition;
        int i6 = this.mTarget;
        if ((i5 == i6 || i6 == -1) && this.mScrollValues.mOffsetPx == 0 && this.mScrollState != 1) {
            dispatchStateChanged(0);
            resetState();
        }
    }

    void setOnPageChangeCallback(androidx.viewpager2.widget.objectPager2$OnPageChangeCallback viewPager2$OnPageChangeCallback) {
        this.mCallback = viewPager2$OnPageChangeCallback;
    }
}

